<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.SuspendLayout()
        '
        'lblBatchFileSelector
        '
        Me.lblBatchFileSelector.AutoSize = True
        Me.lblBatchFileSelector.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatchFileSelector.Location = New System.Drawing.Point(14, 14)
        Me.lblBatchFileSelector.Name = "lblBatchFileSelector"
        Me.lblBatchFileSelector.Size = New System.Drawing.Size(81, 17)
        Me.lblBatchFileSelector.TabIndex = 0
        Me.lblBatchFileSelector.Text = "Executable:"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(94, 13)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(464, 20)
        Me.tbFilePath.TabIndex = 1
        '
        'btnFileBrowser
        '
        Me.btnFileBrowser.Location = New System.Drawing.Point(564, 11)
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
        Me.cbStopOnAwake.Location = New System.Drawing.Point(499, 42)
        Me.cbStopOnAwake.Name = "cbStopOnAwake"
        Me.cbStopOnAwake.Size = New System.Drawing.Size(140, 17)
        Me.cbStopOnAwake.TabIndex = 3
        Me.cbStopOnAwake.Text = "Stop Process on Awake"
        Me.cbStopOnAwake.UseVisualStyleBackColor = True
        '
        'lblEventLogs
        '
        Me.lblEventLogs.AutoSize = True
        Me.lblEventLogs.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEventLogs.Location = New System.Drawing.Point(13, 74)
        Me.lblEventLogs.Name = "lblEventLogs"
        Me.lblEventLogs.Size = New System.Drawing.Size(104, 24)
        Me.lblEventLogs.TabIndex = 4
        Me.lblEventLogs.Text = "Event Logs"
        '
        'lbEventLogs
        '
        Me.lbEventLogs.FormattingEnabled = True
        Me.lbEventLogs.HorizontalScrollbar = True
        Me.lbEventLogs.Location = New System.Drawing.Point(12, 103)
        Me.lbEventLogs.Name = "lbEventLogs"
        Me.lbEventLogs.Size = New System.Drawing.Size(627, 212)
        Me.lbEventLogs.TabIndex = 5
        '
        'btnStartChildProcess
        '
        Me.btnStartChildProcess.Location = New System.Drawing.Point(94, 36)
        Me.btnStartChildProcess.Name = "btnStartChildProcess"
        Me.btnStartChildProcess.Size = New System.Drawing.Size(106, 23)
        Me.btnStartChildProcess.TabIndex = 6
        Me.btnStartChildProcess.Text = "Start Child Process"
        Me.btnStartChildProcess.UseVisualStyleBackColor = True
        '
        'btnStopChildProcess
        '
        Me.btnStopChildProcess.Location = New System.Drawing.Point(206, 36)
        Me.btnStopChildProcess.Name = "btnStopChildProcess"
        Me.btnStopChildProcess.Size = New System.Drawing.Size(104, 23)
        Me.btnStopChildProcess.TabIndex = 7
        Me.btnStopChildProcess.Text = "Stop Child Process"
        Me.btnStopChildProcess.UseVisualStyleBackColor = True
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(316, 36)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(103, 23)
        Me.btnClearLogs.TabIndex = 8
        Me.btnClearLogs.Text = "Clear Logs"
        Me.btnClearLogs.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 327)
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
        Me.Name = "MainForm"
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
End Class
