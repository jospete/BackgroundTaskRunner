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
        Me.lblExecutableOptions = New System.Windows.Forms.Label()
        Me.tbFilePath = New System.Windows.Forms.TextBox()
        Me.btnFileBrowser = New System.Windows.Forms.Button()
        Me.cbStopOnAwake = New System.Windows.Forms.CheckBox()
        Me.lblEventLogs = New System.Windows.Forms.Label()
        Me.lbEventLogs = New System.Windows.Forms.ListBox()
        Me.btnStartRunnable = New System.Windows.Forms.Button()
        Me.btnStopRunnable = New System.Windows.Forms.Button()
        Me.btnClearLogs = New System.Windows.Forms.Button()
        Me.lblDescriptionPart1 = New System.Windows.Forms.Label()
        Me.lblDescriptionPart3 = New System.Windows.Forms.Label()
        Me.lblDescriptionPart2 = New System.Windows.Forms.Label()
        Me.lblDescriptionPart4 = New System.Windows.Forms.Label()
        Me.cbMinimizeOnStart = New System.Windows.Forms.CheckBox()
        Me.lblBackgroundTaskRunnerOptions = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExecutableOptions
        '
        Me.lblExecutableOptions.AutoSize = True
        Me.lblExecutableOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExecutableOptions.Location = New System.Drawing.Point(21, 177)
        Me.lblExecutableOptions.Name = "lblExecutableOptions"
        Me.lblExecutableOptions.Size = New System.Drawing.Size(134, 17)
        Me.lblExecutableOptions.TabIndex = 0
        Me.lblExecutableOptions.Text = "Executable Options:"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(24, 197)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(528, 20)
        Me.tbFilePath.TabIndex = 1
        '
        'btnFileBrowser
        '
        Me.btnFileBrowser.Location = New System.Drawing.Point(558, 195)
        Me.btnFileBrowser.Name = "btnFileBrowser"
        Me.btnFileBrowser.Size = New System.Drawing.Size(88, 23)
        Me.btnFileBrowser.TabIndex = 2
        Me.btnFileBrowser.Text = "Browse"
        Me.btnFileBrowser.UseVisualStyleBackColor = True
        '
        'cbStopOnAwake
        '
        Me.cbStopOnAwake.AutoSize = True
        Me.cbStopOnAwake.Location = New System.Drawing.Point(197, 224)
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
        Me.lblEventLogs.Location = New System.Drawing.Point(20, 268)
        Me.lblEventLogs.Name = "lblEventLogs"
        Me.lblEventLogs.Size = New System.Drawing.Size(104, 24)
        Me.lblEventLogs.TabIndex = 4
        Me.lblEventLogs.Text = "Event Logs"
        '
        'lbEventLogs
        '
        Me.lbEventLogs.FormattingEnabled = True
        Me.lbEventLogs.HorizontalScrollbar = True
        Me.lbEventLogs.Location = New System.Drawing.Point(24, 297)
        Me.lbEventLogs.Name = "lbEventLogs"
        Me.lbEventLogs.Size = New System.Drawing.Size(622, 212)
        Me.lbEventLogs.TabIndex = 5
        '
        'btnStartRunnable
        '
        Me.btnStartRunnable.Location = New System.Drawing.Point(24, 220)
        Me.btnStartRunnable.Name = "btnStartRunnable"
        Me.btnStartRunnable.Size = New System.Drawing.Size(78, 23)
        Me.btnStartRunnable.TabIndex = 6
        Me.btnStartRunnable.Text = "Start"
        Me.btnStartRunnable.UseVisualStyleBackColor = True
        '
        'btnStopRunnable
        '
        Me.btnStopRunnable.Location = New System.Drawing.Point(108, 220)
        Me.btnStopRunnable.Name = "btnStopRunnable"
        Me.btnStopRunnable.Size = New System.Drawing.Size(83, 23)
        Me.btnStopRunnable.TabIndex = 7
        Me.btnStopRunnable.Text = "Stop"
        Me.btnStopRunnable.UseVisualStyleBackColor = True
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(558, 271)
        Me.btnClearLogs.Name = "btnClearLogs"
        Me.btnClearLogs.Size = New System.Drawing.Size(88, 23)
        Me.btnClearLogs.TabIndex = 8
        Me.btnClearLogs.Text = "Clear Logs"
        Me.btnClearLogs.UseVisualStyleBackColor = True
        '
        'lblDescriptionPart1
        '
        Me.lblDescriptionPart1.AutoSize = True
        Me.lblDescriptionPart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart1.Location = New System.Drawing.Point(21, 25)
        Me.lblDescriptionPart1.Name = "lblDescriptionPart1"
        Me.lblDescriptionPart1.Size = New System.Drawing.Size(476, 17)
        Me.lblDescriptionPart1.TabIndex = 10
        Me.lblDescriptionPart1.Text = "1. Select an executable or batch file path in the ""Executable"" section below"
        '
        'lblDescriptionPart3
        '
        Me.lblDescriptionPart3.AutoSize = True
        Me.lblDescriptionPart3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart3.Location = New System.Drawing.Point(21, 59)
        Me.lblDescriptionPart3.Name = "lblDescriptionPart3"
        Me.lblDescriptionPart3.Size = New System.Drawing.Size(471, 17)
        Me.lblDescriptionPart3.TabIndex = 11
        Me.lblDescriptionPart3.Text = "3. Keep this box open to allow the executable to be run in the background"
        '
        'lblDescriptionPart2
        '
        Me.lblDescriptionPart2.AutoSize = True
        Me.lblDescriptionPart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart2.Location = New System.Drawing.Point(21, 42)
        Me.lblDescriptionPart2.Name = "lblDescriptionPart2"
        Me.lblDescriptionPart2.Size = New System.Drawing.Size(600, 17)
        Me.lblDescriptionPart2.TabIndex = 12
        Me.lblDescriptionPart2.Text = "2. Click ""Start"" to confirm that the executable runs correctly (click ""Stop"" to c" &
    "ancel the process)"
        '
        'lblDescriptionPart4
        '
        Me.lblDescriptionPart4.AutoSize = True
        Me.lblDescriptionPart4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart4.Location = New System.Drawing.Point(21, 76)
        Me.lblDescriptionPart4.Name = "lblDescriptionPart4"
        Me.lblDescriptionPart4.Size = New System.Drawing.Size(558, 17)
        Me.lblDescriptionPart4.TabIndex = 13
        Me.lblDescriptionPart4.Text = "4. The executable will start on screen lock (Windows+L) or when the Screensaver s" &
    "tarts"
        '
        'cbMinimizeOnStart
        '
        Me.cbMinimizeOnStart.AutoSize = True
        Me.cbMinimizeOnStart.Location = New System.Drawing.Point(27, 141)
        Me.cbMinimizeOnStart.Name = "cbMinimizeOnStart"
        Me.cbMinimizeOnStart.Size = New System.Drawing.Size(108, 17)
        Me.cbMinimizeOnStart.TabIndex = 14
        Me.cbMinimizeOnStart.Text = "Minimize On Start"
        Me.cbMinimizeOnStart.UseVisualStyleBackColor = True
        '
        'lblBackgroundTaskRunnerOptions
        '
        Me.lblBackgroundTaskRunnerOptions.AutoSize = True
        Me.lblBackgroundTaskRunnerOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackgroundTaskRunnerOptions.Location = New System.Drawing.Point(24, 121)
        Me.lblBackgroundTaskRunnerOptions.Name = "lblBackgroundTaskRunnerOptions"
        Me.lblBackgroundTaskRunnerOptions.Size = New System.Drawing.Size(227, 17)
        Me.lblBackgroundTaskRunnerOptions.TabIndex = 15
        Me.lblBackgroundTaskRunnerOptions.Text = "Background Task Runner Options:"
        '
        'BackgroundTaskRunnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 524)
        Me.Controls.Add(Me.lblBackgroundTaskRunnerOptions)
        Me.Controls.Add(Me.cbMinimizeOnStart)
        Me.Controls.Add(Me.lblDescriptionPart4)
        Me.Controls.Add(Me.lblDescriptionPart2)
        Me.Controls.Add(Me.lblDescriptionPart3)
        Me.Controls.Add(Me.lblDescriptionPart1)
        Me.Controls.Add(Me.btnClearLogs)
        Me.Controls.Add(Me.btnStopRunnable)
        Me.Controls.Add(Me.btnStartRunnable)
        Me.Controls.Add(Me.lbEventLogs)
        Me.Controls.Add(Me.lblEventLogs)
        Me.Controls.Add(Me.cbStopOnAwake)
        Me.Controls.Add(Me.btnFileBrowser)
        Me.Controls.Add(Me.tbFilePath)
        Me.Controls.Add(Me.lblExecutableOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "BackgroundTaskRunnerForm"
        Me.Text = "Background Task Runner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExecutableOptions As Label
    Friend WithEvents tbFilePath As TextBox
    Friend WithEvents btnFileBrowser As Button
    Friend WithEvents cbStopOnAwake As CheckBox
    Friend WithEvents lblEventLogs As Label
    Friend WithEvents lbEventLogs As ListBox
    Friend WithEvents btnStartRunnable As Button
    Friend WithEvents btnStopRunnable As Button
    Friend WithEvents btnClearLogs As Button
    Friend WithEvents lblDescriptionPart1 As Label
    Friend WithEvents lblDescriptionPart3 As Label
    Friend WithEvents lblDescriptionPart2 As Label
    Friend WithEvents lblDescriptionPart4 As Label
    Friend WithEvents cbMinimizeOnStart As CheckBox
    Friend WithEvents lblBackgroundTaskRunnerOptions As Label
End Class
