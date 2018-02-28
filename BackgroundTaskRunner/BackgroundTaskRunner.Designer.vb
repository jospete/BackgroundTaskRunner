<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackgroundTaskRunnerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblBatchFileSelector = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnFileBrowser = New System.Windows.Forms.Button()
        Me.cbStopOnAwake = New System.Windows.Forms.CheckBox()
        Me.lblEventLogs = New System.Windows.Forms.Label()
        Me.lbEventLogs = New System.Windows.Forms.ListBox()
        Me.btnStartChildProcess = New System.Windows.Forms.Button()
        Me.btnStopChildProcess = New System.Windows.Forms.Button()
        Me.btnClearLogs = New System.Windows.Forms.Button()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblBatchFileSelector
        '
        Me.lblBatchFileSelector.AutoSize = True
        Me.lblBatchFileSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatchFileSelector.Location = New System.Drawing.Point(21, 123)
        Me.lblBatchFileSelector.Name = "lblBatchFileSelector"
        Me.lblBatchFileSelector.Size = New System.Drawing.Size(81, 17)
        Me.lblBatchFileSelector.TabIndex = 0
        Me.lblBatchFileSelector.Text = "Executable:"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(101, 122)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(464, 20)
        Me.tbFilePath.TabIndex = 1
        '
        'btnFileBrowser
        '
        Me.btnFileBrowser.Location = New System.Drawing.Point(571, 120)
        Me.btnFileBrowser.Name = "btnFileBrowser"
        Me.btnFileBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnFileBrowser.TabIndex = 2
        Me.btnFileBrowser.Text = "Browse"
        Me.btnFileBrowser.UseVisualStyleBackColor = True
        '
        'cbStopOnAwake
        '
        Me.cbStopOnAwake.AutoSize = True
        Me.cbStopOnAwake.Checked = True
        Me.cbStopOnAwake.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStopOnAwake.Location = New System.Drawing.Point(547, 149)
        Me.cbStopOnAwake.Name = "cbStopOnAwake"
        Me.cbStopOnAwake.Size = New System.Drawing.Size(99, 17)
        Me.cbStopOnAwake.TabIndex = 3
        Me.cbStopOnAwake.Text = "Stop on Awake"
        Me.cbStopOnAwake.UseVisualStyleBackColor = True
        '
        'lblEventLogs
        '
        Me.lblEventLogs.AutoSize = True
        Me.lblEventLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventLogs.Location = New System.Drawing.Point(20, 215)
        Me.lblEventLogs.Name = "lblEventLogs"
        Me.lblEventLogs.Size = New System.Drawing.Size(104, 24)
        Me.lblEventLogs.TabIndex = 4
        Me.lblEventLogs.Text = "Event Logs"
        '
        'lbEventLogs
        '
        Me.lbEventLogs.FormattingEnabled = True
        Me.lbEventLogs.HorizontalScrollbar = True
        Me.lbEventLogs.Location = New System.Drawing.Point(19, 244)
        Me.lbEventLogs.Name = "lbEventLogs"
        Me.lbEventLogs.Size = New System.Drawing.Size(627, 212)
        Me.lbEventLogs.TabIndex = 5
        '
        'btnStartChildProcess
        '
        Me.btnStartChildProcess.Location = New System.Drawing.Point(101, 145)
        Me.btnStartChildProcess.Name = "btnStartChildProcess"
        Me.btnStartChildProcess.Size = New System.Drawing.Size(78, 23)
        Me.btnStartChildProcess.TabIndex = 6
        Me.btnStartChildProcess.Text = "Start"
        Me.btnStartChildProcess.UseVisualStyleBackColor = True
        '
        'btnStopChildProcess
        '
        Me.btnStopChildProcess.Location = New System.Drawing.Point(185, 145)
        Me.btnStopChildProcess.Name = "btnStopChildProcess"
        Me.btnStopChildProcess.Size = New System.Drawing.Size(83, 23)
        Me.btnStopChildProcess.TabIndex = 7
        Me.btnStopChildProcess.Text = "Stop"
        Me.btnStopChildProcess.UseVisualStyleBackColor = True
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(130, 215)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(88, 23)
        Me.btnClearLogs.TabIndex = 8
        Me.btnClearLogs.Text = "Clear Logs"
        Me.btnClearLogs.UseVisualStyleBackColor = True
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(7, 9)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(631, 17)
        Me.lblDescription.TabIndex = 10
        Me.lblDescription.Text = "1. The selected .exe or .bat file will be run when this machine is locked or ente" &
    "rs screensaver mode"
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription2.Location = New System.Drawing.Point(7, 65)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(418, 17)
        Me.lblDescription2.TabIndex = 11
        Me.lblDescription2.Text = "3. This runner must remain open for these changes to take effect"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(649, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "2. When 'Stop on Awake' is active, the process will be killed automatically when " &
    "this machine wakes up"
        '
        'BackgroundTaskRunnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 475)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDescription2)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnClearLogs)
        Me.Controls.Add(Me.btnStopChildProcess)
        Me.Controls.Add(Me.btnStartChildProcess)
        Me.Controls.Add(Me.lbEventLogs)
        Me.Controls.Add(Me.lblEventLogs)
        Me.Controls.Add(Me.cbStopOnAwake)
        Me.Controls.Add(Me.btnFileBrowser)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.lblBatchFileSelector)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "BackgroundTaskRunnerForm"
        Me.Text = "Background Task Runner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblBatchFileSelector As Label
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnFileBrowser As Button
    Friend WithEvents cbStopOnAwake As CheckBox
    Friend WithEvents lblEventLogs As Label
    Friend WithEvents lbEventLogs As ListBox
    Friend WithEvents btnStartChildProcess As Button
    Friend WithEvents btnStopChildProcess As Button
    Friend WithEvents btnClearLogs As Button
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDescription2 As Label
    Friend WithEvents Label1 As Label
End Class
