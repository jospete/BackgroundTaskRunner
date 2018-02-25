Imports Microsoft.Win32
Imports System.IO

Public Class MainForm

    Private childProcessDomain As String = "backgroundTaskRunnerChild"
    Private batchProcessStartInfo As ProcessStartInfo = Nothing
    Private batchProcess As Process = Nothing

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler SystemEvents.SessionSwitch, AddressOf SystemEvents_SessionSwitch
        LogEvent("Startup")
    End Sub

    Private Sub LogEvent(log As String)
        lbEventLogs.Items.Add(Now.ToLocalTime() & ":    " & log)
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

    Private Sub SystemEvents_SessionSwitch(ByVal sender As Object, ByVal e As SessionSwitchEventArgs)
        LogEvent("Session Switch (" & e.Reason.ToString() & ")")
        Select Case e.Reason
            Case SessionSwitchReason.SessionLock
                StartChildProcess()
            Case SessionSwitchReason.SessionUnlock
                If cbStopOnAwake.Checked Then
                    StopChildProcess()
                Else
                    LogEvent("Child process will be left open")
                End If
        End Select
    End Sub

    Private Sub StartChildProcess() Handles btnStartChildProcess.Click

        Dim path As String = tbFilePath.Text
        LogEvent("Starting child process... killing previous process")
        StopChildProcess()

        If path.EndsWith(".bat") Then
            If File.Exists(path) Then
                CreateChildProcess(path)
            Else
                LogEvent("Failed to start process (not a file) '" & path & "'")
            End If
        Else
            LogEvent("Failed to start process (not an executable file) '" & path & "'")
        End If
    End Sub

    Private Sub StopChildProcess() Handles btnStopChildProcess.Click

        If batchProcess IsNot Nothing Then
            Try
                If Not batchProcess.HasExited Then
                    LogEvent("Killing child main process (ID " & batchProcess.Id & ")")
                    batchProcess.CloseMainWindow()
                Else
                    LogEvent("Child process has already exited (Exit Code " & batchProcess.ExitCode & ")")
                End If
            Catch ex As Exception
                LogEvent("Failed To fetch child process (Error: " & ex.Message & ")")
            End Try
        Else
            LogEvent("No child process detected, skipping 'stop'")
        End If

        batchProcess = Nothing

    End Sub

    Private Sub CreateChildProcess(path As String)
        Try

            batchProcessStartInfo = New ProcessStartInfo(path)
            batchProcessStartInfo.WorkingDirectory = path.Substring(0, path.LastIndexOf("\"))
            LogEvent("Using Execution Directory: " & batchProcessStartInfo.WorkingDirectory)

            batchProcess = Process.Start(batchProcessStartInfo)
            LogEvent("Child process started (ID " & batchProcess.Id & ")")

        Catch ex As Exception
            LogEvent("Failed to start process (caught error) - " & ex.Message)
        End Try
    End Sub
End Class
