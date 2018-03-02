Imports Microsoft.Win32
Imports System.IO

Public Class BackgroundTaskRunnerForm

    Private Const WM_SYSCOMMAND As Integer = &H112
    Private Const SC_SCREENSAVE As Integer = &HF140

    Private batchProcessStartInfo As ProcessStartInfo = Nothing
    Private batchProcess As Process = Nothing

    ' Load user settings and apply them
    Private Sub BackgroundTaskRunnerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SystemEvents.SessionSwitch, AddressOf SystemEvents_SessionSwitch
        LogEvent("Startup")
        ReloadSettings()
        If My.Settings.MinimizeOnStart Then
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub

    ' Kill batchProcess if it is running
    Private Sub BackgroundTaskRunnerForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        LogEvent("Closing...")
        StopChildProcess()
    End Sub

    ' Helper for client status
    Private Sub LogEvent(log As String)
        lbEventLogs.Items.Add(Now.ToLocalTime() & ":    " & log)
    End Sub

    ' Option to clear the logs for cases where app is open for long periods of time
    Private Sub btnClearLogs_Click(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        lbEventLogs.Items.Clear()
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

    ' Auto-save for "Minimize On Start" checkbox
    Private Sub cbMinimizeOnStart_CheckedChanged(sender As Object, e As EventArgs) Handles cbMinimizeOnStart.CheckedChanged
        My.Settings.MinimizeOnStart = cbMinimizeOnStart.Checked
        My.Settings.Save()
    End Sub

    ' Reload settings from cache
    Private Sub ReloadSettings()
        tbFilePath.Text = My.Settings.TargetPath
        cbStopOnAwake.Checked = My.Settings.StopOnAwake
        cbMinimizeOnStart.Checked = My.Settings.MinimizeOnStart
    End Sub

    ' Listen for "Screensaver Start" windows event, and start the process when this event happens.
    ' Also registers a hook for the "Screensaver Stop" event so we know when to stop the process.
    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32 = SC_SCREENSAVE Then
            LogEvent("Screensaver Started")
            StartChildProcess()
            AddHandler Application.Idle, AddressOf OnScreensaverIdle
        End If
    End Sub

    ' Screensaver was stopped, de-register our "Screensaver Stop" listener and stop the process
    Private Sub OnScreensaverIdle(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler Application.Idle, AddressOf OnScreensaverIdle
        LogEvent("Screensaver Stopped")
        StopChildProcessOnAwake()
    End Sub

    ' Listens for session switch events so we can start and stop the process when the user locks/unlocks their computer
    Private Sub SystemEvents_SessionSwitch(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)
        LogEvent("Session Switch (" & e.Reason.ToString() & ")")
        Select Case e.Reason
            Case SessionSwitchReason.SessionLock
                StartChildProcess()
            Case SessionSwitchReason.SessionUnlock
                StopChildProcessOnAwake()
        End Select
    End Sub

    ' Stops the target process if there is one running and "Stop on Awake" is checked
    Private Sub StopChildProcessOnAwake()
        If cbStopOnAwake.Checked Then
            StopChildProcess()
        Else
            LogEvent("Process will not be stopped (Stop on Awake = False)")
        End If
    End Sub

    ' Starts the process at the given path
    Private Sub CreateChildProcess(path As String)
        Try
            batchProcessStartInfo = New ProcessStartInfo(path)
            batchProcessStartInfo.WorkingDirectory = path.Substring(0, path.LastIndexOf("\"))
            LogEvent("Using Execution Directory: " & batchProcessStartInfo.WorkingDirectory)
            batchProcess = Process.Start(batchProcessStartInfo)
            LogEvent("Starting process '" & batchProcess.ProcessName & "' (ID " & batchProcess.Id & ")")
        Catch ex As Exception
            LogEvent("Failed to start process (caught error) - " & ex.Message)
        End Try
    End Sub

    ' Opens a file browser for the file path text box
    Private Sub btnFileBrowser_Click(sender As Object, e As EventArgs) Handles btnFileBrowser.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Filter = "Batch files (*.bat)|*.bat|Executables (*.exe)|(*.exe)"
        fd.Title = "Select Background Task"
        fd.InitialDirectory = "C:\Desktop"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        If fd.ShowDialog() = DialogResult.OK Then
            tbFilePath.Text = fd.FileName
        End If
    End Sub

    ' Starts the target process if the target file is a valid executable or batch file
    Private Sub StartChildProcess() Handles btnStartChildProcess.Click

        ' Don't overlap a running process
        If batchProcess IsNot Nothing Then
            LogEvent("Process '" & batchProcess.ProcessName & "' (ID " & batchProcess.Id & ") already running, skipping duplicate call")
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
            CreateChildProcess(path)
        Else
            LogEvent("Failed to start process (not a file) '" & path & "'")
        End If
    End Sub

    ' Stops the target process if there is one running
    Private Sub StopChildProcess() Handles btnStopChildProcess.Click

        If batchProcess Is Nothing Then
            LogEvent("No process detected, skipping 'stop'")
            Return
        End If

        If batchProcess.HasExited Then
            LogEvent("Process has already exited (Exit Code " & batchProcess.ExitCode & ")")
            batchProcess = Nothing
            Return
        End If

        Try
            ' Allow time to settle if we're waking up from screen lock or screensaver
            Threading.Thread.Sleep(1000)
            LogEvent("Killing process '" & batchProcess.ProcessName & "' (ID " & batchProcess.Id & ")")
            batchProcess.CloseMainWindow()
        Catch ex As Exception
            LogEvent("Failed To stop process (Error: " & ex.Message & ")")
        End Try

        batchProcess = Nothing

    End Sub
End Class
