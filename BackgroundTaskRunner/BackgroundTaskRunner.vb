Imports Microsoft.Win32
Imports System.IO

Public Class MainForm

    Const WM_SYSCOMMAND As Integer = &H112
    Const SC_SCREENSAVE As Integer = &HF140

    Private batchProcessStartInfo As ProcessStartInfo = Nothing
    Private batchProcess As Process = Nothing

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SystemEvents.SessionSwitch, AddressOf SystemEvents_SessionSwitch
        LogEvent("Startup")
        Try
            My.Settings.Reload()
            tbFilePath.Text = My.Settings.TargetPath
            cbStopOnAwake.Checked = My.Settings.StopOnAwake
        Catch ex As Exception
            LogEvent("Failed to load cached settings: " & ex.Message)
        End Try
    End Sub

    Private Sub LogEvent(log As String)
        lbEventLogs.Items.Add(Now.ToLocalTime() & ":    " & log)
    End Sub

    Private Sub btnClearLogs_Click(sender As Object, e As EventArgs) Handles btnClearLogs.Click
        lbEventLogs.Items.Clear()
    End Sub

    Private Sub tbFilePath_TextChanged(sender As Object, e As EventArgs) Handles tbFilePath.TextChanged
        My.Settings.TargetPath = tbFilePath.Text
        My.Settings.Save()
    End Sub

    Private Sub cbStopOnAwake_CheckedChanged(sender As Object, e As EventArgs) Handles cbStopOnAwake.CheckedChanged
        My.Settings.StopOnAwake = cbStopOnAwake.Checked
        My.Settings.Save()
    End Sub

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

    Protected Overrides Sub WndProc(ByRef m As Message)
        MyBase.WndProc(m)
        If m.Msg = WM_SYSCOMMAND AndAlso m.WParam.ToInt32 = SC_SCREENSAVE Then
            LogEvent("Screensaver Started")
            StartChildProcess()
            AddHandler Application.Idle, AddressOf OnScreensaverIdle
        End If
    End Sub

    Private Sub OnScreensaverIdle(ByVal sender As Object, ByVal e As EventArgs)
        RemoveHandler Application.Idle, AddressOf OnScreensaverIdle
        LogEvent("Screensaver Stopped")
        StopChildProcessOnAwake()
    End Sub

    Private Sub SystemEvents_SessionSwitch(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)
        LogEvent("Session Switch (" & e.Reason.ToString() & ")")
        Select Case e.Reason
            Case SessionSwitchReason.SessionLock
                StartChildProcess()
            Case SessionSwitchReason.SessionUnlock
                StopChildProcessOnAwake()
        End Select
    End Sub

    Private Sub StartChildProcess() Handles btnStartChildProcess.Click
        Dim path As String = tbFilePath.Text
        If batchProcess Is Nothing Then
            If path.EndsWith(".bat") Then
                If File.Exists(path) Then
                    CreateChildProcess(path)
                Else
                    LogEvent("Failed to start process (not a file) '" & path & "'")
                End If
            Else
                LogEvent("Failed to start process (not an executable file) '" & path & "'")
            End If
        Else
            LogEvent("Process '" & batchProcess.ProcessName & "' (ID " & batchProcess.Id & ") already running, skipping duplicate call")
        End If
    End Sub

    Private Sub StopChildProcessOnAwake()
        If cbStopOnAwake.Checked Then
            StopChildProcess()
        Else
            LogEvent("Process will not be stopped (Stop on Awake = False)")
        End If
    End Sub

    Private Sub StopChildProcess() Handles btnStopChildProcess.Click
        If batchProcess IsNot Nothing Then
            Try
                If Not batchProcess.HasExited Then
                    Threading.Thread.Sleep(1000)
                    LogEvent("Killing process '" & batchProcess.ProcessName & "' (ID " & batchProcess.Id & ")")
                    batchProcess.CloseMainWindow()
                Else
                    LogEvent("Process has already exited (Exit Code " & batchProcess.ExitCode & ")")
                End If
            Catch ex As Exception
                LogEvent("Failed To stop process (Error: " & ex.Message & ")")
            End Try
        Else
            LogEvent("No process detected, skipping 'stop'")
        End If
        batchProcess = Nothing
    End Sub

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
End Class
