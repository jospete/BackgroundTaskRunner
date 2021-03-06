﻿Imports Microsoft.Win32
Imports System.IO

Public Class BackgroundTaskRunnerForm

    Private Const REGISTRY_PATH As String = "SOFTWARE\Microsoft\Windows\CurrentVersion\Run"
    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_SCREENSAVE As Integer = &HF140

    Private runnableStartInfo As ProcessStartInfo = Nothing
    Private WithEvents runnable As Process = Nothing

    ' Load user settings and apply them
    Private Sub BackgroundTaskRunnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SystemEvents.SessionSwitch, AddressOf SystemEvents_SessionSwitch
        AddHandler SystemEvents.PowerModeChanged, AddressOf SystemEvents_PowerModeChanged
        LogEvent("Startup")
        ReloadSettings()
        If My.Settings.OpenMinimized Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    ' Kill runnable if it is running
    Private Sub BackgroundTaskRunnerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LogEvent("Closing...")
        StopRunnable()
    End Sub

    ' Helper for client status
    Private Sub LogEvent(log As String)
        lbEventLogs.Items.Add(Now.ToLocalTime() & ":    " & log)
    End Sub

    ' Option to clear the logs for cases where app is open for long periods of time
    Private Sub btnClearLogs_Click(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        lbEventLogs.Items.Clear()
    End Sub

    ' Provide a reference to the source, because why not
    Private Sub linkSourceCode_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkSourceCode.LinkClicked
        Process.Start(linkSourceCode.Text)
    End Sub

    ' Auto-save for file path text box
    Private Sub tbFilePath_TextChanged(sender As Object, e As EventArgs) Handles tbFilePath.TextChanged
        My.Settings.TargetPath = tbFilePath.Text
        My.Settings.Save()
    End Sub

    ' Auto-save for "Stop on Awake" checkbox
    Private Sub cbStopOnAwake_CheckedChanged(sender As Object, e As EventArgs) Handles cbStopOnAwake.CheckedChanged
        My.Settings.StopOnAwake = cbStopOnAwake.Checked
        My.Settings.Save()
    End Sub

    ' Auto-save for "Open Minimized" checkbox
    Private Sub cbMinimizeOnOpen_CheckedChanged(sender As Object, e As EventArgs) Handles cbMinimizeOnOpen.CheckedChanged
        My.Settings.OpenMinimized = cbMinimizeOnOpen.Checked
        My.Settings.Save()
    End Sub

    ' Auto-save for "Run On Startup" Checkbox
    Private Sub cbRunOnStartup_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.RunOnStartup = False ' cbRunOnStartup.Checked
        My.Settings.Save()
        If My.Settings.RunOnStartup Then
            RegisterStartup()
        Else
            DeregisterStartup()
        End If
    End Sub

    ' Reload settings from cache
    Private Sub ReloadSettings()
        tbFilePath.Text = My.Settings.TargetPath
        cbStopOnAwake.Checked = My.Settings.StopOnAwake
        cbMinimizeOnOpen.Checked = My.Settings.OpenMinimized
    End Sub

    ' Add this app to startup registery
    Private Sub RegisterStartup()
        Try
            Dim registryKey = My.Computer.Registry.LocalMachine.OpenSubKey(REGISTRY_PATH, True)
            registryKey.SetValue(Application.ProductName, Application.ExecutablePath)
        Catch ex As Exception
            LogEvent("Failed to register as startup task: " + ex.Message)
        End Try
    End Sub

    ' Remove this app from startup registery
    Private Sub DeregisterStartup()
        Try
            Dim registryKey = My.Computer.Registry.LocalMachine.OpenSubKey(REGISTRY_PATH, True)
            registryKey.SetValue(Application.ProductName, Application.ExecutablePath)
        Catch ex As Exception
            LogEvent("Failed to de-register as startup task: " + ex.Message)
        End Try
    End Sub

    ' Listen for "Screensaver Start" windows event, and start the process when this event happens.
    ' Also registers a hook for the "Screensaver Stop" event so we know when to stop the process.
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32 = SC_SCREENSAVE Then
            LogEvent("Screensaver Started")
            StartRunnable()
            AddHandler Application.Idle, AddressOf OnScreensaverIdle
        End If
    End Sub

    ' Screensaver was stopped, de-register our "Screensaver Stop" listener and stop the process
    Private Sub OnScreensaverIdle(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler Application.Idle, AddressOf OnScreensaverIdle
        LogEvent("Screensaver Stopped")
        StopRunnableOnAwake()
    End Sub

    ' Listens for session switch events so we can start and stop the process when the user locks/unlocks their computer
    Private Sub SystemEvents_SessionSwitch(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)
        LogEvent("Session Switch (" & e.Reason.ToString() & ")")
        Select Case e.Reason
            Case SessionSwitchReason.SessionLock
                StartRunnable()
            Case SessionSwitchReason.SessionUnlock
                StopRunnableOnAwake()
        End Select
    End Sub

    ' Listens for power mode events so we can start and stop the process when the computer hibernates/resumes
    Private Sub SystemEvents_PowerModeChanged(ByVal sender As Object, ByVal e As PowerModeChangedEventArgs)
        LogEvent("Power Mode Change (" & e.Mode.ToString() & ")")
        Select Case e.Mode
            Case PowerModes.Suspend
                StartRunnable()
            Case PowerModes.Resume
                StopRunnableOnAwake()
        End Select
    End Sub

    ' Stops the target process if there is one running and "Stop on Awake" is checked
    Private Sub StopRunnableOnAwake()
        If cbStopOnAwake.Checked Then
            StopRunnable()
        Else
            LogEvent("Process will not be stopped (Stop on Awake = False)")
        End If
    End Sub

    ' Handle "Exited" event for processes we spawn
    Private Sub OnRunnableExit(ByVal sender As Object, ByVal e As EventArgs)
        Me.Invoke(
            Sub()
                If runnable IsNot Nothing Then
                    Me.StopRunnable()
                End If
            End Sub
        )
    End Sub

    ' Opens a file browser for the file path text box
    Private Sub btnFileBrowser_Click(sender As Object, e As EventArgs) Handles btnFileBrowser.Click

        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Filter = "Batch files (*.bat)|*.bat|Executables (*.exe)|(*.exe)"
        fd.Title = "Select Background Task"
        fd.InitialDirectory = "C:\Desktop"
        fd.RestoreDirectory = True
        fd.FilterIndex = 1

        If fd.ShowDialog() = DialogResult.OK Then
            tbFilePath.Text = fd.FileName
        End If
    End Sub

    ' Starts the process at the given path
    Private Sub CreateRunnableProcess(path As String)
        Try

            runnableStartInfo = New ProcessStartInfo(path)

            ' Set the working directory for cases where the runnable calls other stuff in the same relative directory
            runnableStartInfo.WorkingDirectory = path.Substring(0, path.LastIndexOf("\"))

            ' Start the runnable in another Thread
            runnable = Process.Start(runnableStartInfo)
            LogEvent("Starting process '" & runnable.ProcessName & "' (ID " & runnable.Id & ")")

            ' Add listener for the runnable's "Exited" event
            runnable.EnableRaisingEvents = True
            AddHandler runnable.Exited, AddressOf OnRunnableExit

        Catch ex As Exception
            LogEvent("Failed to start process (caught error) - " & ex.Message)
        End Try
    End Sub

    ' Starts the target process if the target file is a valid executable or batch file
    Private Sub StartRunnable() Handles btnStartRunnable.Click

        ' Don't overlap a running process
        If runnable IsNot Nothing Then
            LogEvent("Process '" & runnable.ProcessName & "' (ID " & runnable.Id & ") already running, skipping duplicate call")
            Return
        End If

        Dim path As String = tbFilePath.Text

        ' Don't run a non-executable file
        If Not path.EndsWith(".bat") AndAlso Not path.EndsWith(".exe") Then
            LogEvent("Failed to start process (invalid extension) '" & path & "'")
            Return
        End If

        ' Make sure the file exists before starting the process
        If File.Exists(path) Then
            CreateRunnableProcess(path)
        Else
            LogEvent("Failed to start process (not a file) '" & path & "'")
        End If
    End Sub

    ' Stops the target process if there is one running
    Private Sub StopRunnable() Handles btnStopRunnable.Click

        If runnable Is Nothing Then
            LogEvent("No process detected, skipping 'stop'")
            Return
        End If

        If runnable.HasExited Then
            LogEvent("Process exited (Exit Code " & runnable.ExitCode & ")")
            runnable = Nothing
            Return
        End If

        Try
            ' Allow time to settle if we're waking up from screen lock or screensaver
            Threading.Thread.Sleep(500)
            LogEvent("Killing process '" & runnable.ProcessName & "' (ID " & runnable.Id & ")")
            runnable.CloseMainWindow()
        Catch ex As Exception
            LogEvent("Failed To stop process (Error: " & ex.Message & ")")
        End Try

        runnable = Nothing

    End Sub

End Class
