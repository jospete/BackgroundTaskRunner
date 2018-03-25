<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackgroundTaskRunnerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.cbMinimizeOnOpen = New System.Windows.Forms.CheckBox()
        Me.lblBackgroundTaskRunnerOptions = New System.Windows.Forms.Label()
        Me.lblSourceCode = New System.Windows.Forms.Label()
        Me.linkSourceCode = New System.Windows.Forms.LinkLabel()
        Me.lblDescriptionPart4a = New System.Windows.Forms.Label()
        Me.lblDescriptionPart4b = New System.Windows.Forms.Label()
        Me.lblDescriptionPart4c = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblExecutableOptions
        '
        Me.lblExecutableOptions.AutoSize = True
        Me.lblExecutableOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExecutableOptions.Location = New System.Drawing.Point(21, 246)
        Me.lblExecutableOptions.Name = "lblExecutableOptions"
        Me.lblExecutableOptions.Size = New System.Drawing.Size(134, 17)
        Me.lblExecutableOptions.TabIndex = 0
        Me.lblExecutableOptions.Text = "Executable Options:"
        '
        'tbFilePath
        '
        Me.tbFilePath.Location = New System.Drawing.Point(24, 266)
        Me.tbFilePath.Name = "tbFilePath"
        Me.tbFilePath.Size = New System.Drawing.Size(528, 20)
        Me.tbFilePath.TabIndex = 1
        '
        'btnFileBrowser
        '
        Me.btnFileBrowser.Location = New System.Drawing.Point(558, 264)
        Me.btnFileBrowser.Name = "btnFileBrowser"
        Me.btnFileBrowser.Size = New System.Drawing.Size(88, 23)
        Me.btnFileBrowser.TabIndex = 2
        Me.btnFileBrowser.Text = "Browse"
        Me.btnFileBrowser.UseVisualStyleBackColor = True
        '
        'cbStopOnAwake
        '
        Me.cbStopOnAwake.AutoSize = True
        Me.cbStopOnAwake.Location = New System.Drawing.Point(197, 293)
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
        Me.lblEventLogs.Location = New System.Drawing.Point(20, 337)
        Me.lblEventLogs.Name = "lblEventLogs"
        Me.lblEventLogs.Size = New System.Drawing.Size(104, 24)
        Me.lblEventLogs.TabIndex = 4
        Me.lblEventLogs.Text = "Event Logs"
        '
        'lbEventLogs
        '
        Me.lbEventLogs.FormattingEnabled = True
        Me.lbEventLogs.HorizontalScrollbar = True
        Me.lbEventLogs.Location = New System.Drawing.Point(24, 366)
        Me.lbEventLogs.Name = "lbEventLogs"
        Me.lbEventLogs.Size = New System.Drawing.Size(622, 212)
        Me.lbEventLogs.TabIndex = 5
        '
        'btnStartRunnable
        '
        Me.btnStartRunnable.Location = New System.Drawing.Point(24, 289)
        Me.btnStartRunnable.Name = "btnStartRunnable"
        Me.btnStartRunnable.Size = New System.Drawing.Size(78, 23)
        Me.btnStartRunnable.TabIndex = 6
        Me.btnStartRunnable.Text = "Start"
        Me.btnStartRunnable.UseVisualStyleBackColor = True
        '
        'btnStopRunnable
        '
        Me.btnStopRunnable.Location = New System.Drawing.Point(108, 289)
        Me.btnStopRunnable.Name = "btnStopRunnable"
        Me.btnStopRunnable.Size = New System.Drawing.Size(83, 23)
        Me.btnStopRunnable.TabIndex = 7
        Me.btnStopRunnable.Text = "Stop"
        Me.btnStopRunnable.UseVisualStyleBackColor = True
        '
        'btnClearLogs
        '
        Me.btnClearLogs.Location = New System.Drawing.Point(558, 340)
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
        Me.lblDescriptionPart1.Location = New System.Drawing.Point(21, 9)
        Me.lblDescriptionPart1.Name = "lblDescriptionPart1"
        Me.lblDescriptionPart1.Size = New System.Drawing.Size(476, 17)
        Me.lblDescriptionPart1.TabIndex = 10
        Me.lblDescriptionPart1.Text = "1. Select an executable or batch file path in the ""Executable"" section below"
        '
        'lblDescriptionPart3
        '
        Me.lblDescriptionPart3.AutoSize = True
        Me.lblDescriptionPart3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart3.Location = New System.Drawing.Point(21, 43)
        Me.lblDescriptionPart3.Name = "lblDescriptionPart3"
        Me.lblDescriptionPart3.Size = New System.Drawing.Size(451, 17)
        Me.lblDescriptionPart3.TabIndex = 11
        Me.lblDescriptionPart3.Text = "3. Keep this box open to allow the executable to run in the background"
        '
        'lblDescriptionPart2
        '
        Me.lblDescriptionPart2.AutoSize = True
        Me.lblDescriptionPart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart2.Location = New System.Drawing.Point(21, 26)
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
        Me.lblDescriptionPart4.Location = New System.Drawing.Point(21, 74)
        Me.lblDescriptionPart4.Name = "lblDescriptionPart4"
        Me.lblDescriptionPart4.Size = New System.Drawing.Size(200, 17)
        Me.lblDescriptionPart4.TabIndex = 13
        Me.lblDescriptionPart4.Text = "The executable will start when:"
        '
        'cbMinimizeOnOpen
        '
        Me.cbMinimizeOnOpen.AutoSize = True
        Me.cbMinimizeOnOpen.Location = New System.Drawing.Point(27, 192)
        Me.cbMinimizeOnOpen.Name = "cbMinimizeOnOpen"
        Me.cbMinimizeOnOpen.Size = New System.Drawing.Size(101, 17)
        Me.cbMinimizeOnOpen.TabIndex = 14
        Me.cbMinimizeOnOpen.Text = "Open Minimized"
        Me.cbMinimizeOnOpen.UseVisualStyleBackColor = True
        '
        'lblBackgroundTaskRunnerOptions
        '
        Me.lblBackgroundTaskRunnerOptions.AutoSize = True
        Me.lblBackgroundTaskRunnerOptions.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBackgroundTaskRunnerOptions.Location = New System.Drawing.Point(21, 163)
        Me.lblBackgroundTaskRunnerOptions.Name = "lblBackgroundTaskRunnerOptions"
        Me.lblBackgroundTaskRunnerOptions.Size = New System.Drawing.Size(227, 17)
        Me.lblBackgroundTaskRunnerOptions.TabIndex = 15
        Me.lblBackgroundTaskRunnerOptions.Text = "Background Task Runner Options:"
        '
        'lblSourceCode
        '
        Me.lblSourceCode.AutoSize = True
        Me.lblSourceCode.Location = New System.Drawing.Point(21, 593)
        Me.lblSourceCode.Name = "lblSourceCode"
        Me.lblSourceCode.Size = New System.Drawing.Size(44, 13)
        Me.lblSourceCode.TabIndex = 16
        Me.lblSourceCode.Text = "Source:"
        '
        'linkSourceCode
        '
        Me.linkSourceCode.AutoSize = True
        Me.linkSourceCode.Location = New System.Drawing.Point(71, 593)
        Me.linkSourceCode.Name = "linkSourceCode"
        Me.linkSourceCode.Size = New System.Drawing.Size(256, 13)
        Me.linkSourceCode.TabIndex = 17
        Me.linkSourceCode.TabStop = True
        Me.linkSourceCode.Text = "https://github.com/jospete/BackgroundTaskRunner"
        '
        'lblDescriptionPart4a
        '
        Me.lblDescriptionPart4a.AutoSize = True
        Me.lblDescriptionPart4a.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart4a.Location = New System.Drawing.Point(38, 91)
        Me.lblDescriptionPart4a.Name = "lblDescriptionPart4a"
        Me.lblDescriptionPart4a.Size = New System.Drawing.Size(271, 17)
        Me.lblDescriptionPart4a.TabIndex = 18
        Me.lblDescriptionPart4a.Text = "- Screen Lock Event Occurs (Windows+L)"
        '
        'lblDescriptionPart4b
        '
        Me.lblDescriptionPart4b.AutoSize = True
        Me.lblDescriptionPart4b.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart4b.Location = New System.Drawing.Point(38, 108)
        Me.lblDescriptionPart4b.Name = "lblDescriptionPart4b"
        Me.lblDescriptionPart4b.Size = New System.Drawing.Size(220, 17)
        Me.lblDescriptionPart4b.TabIndex = 19
        Me.lblDescriptionPart4b.Text = "- Screensaver Start Event Occurs"
        '
        'lblDescriptionPart4c
        '
        Me.lblDescriptionPart4c.AutoSize = True
        Me.lblDescriptionPart4c.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescriptionPart4c.Location = New System.Drawing.Point(38, 125)
        Me.lblDescriptionPart4c.Name = "lblDescriptionPart4c"
        Me.lblDescriptionPart4c.Size = New System.Drawing.Size(224, 17)
        Me.lblDescriptionPart4c.TabIndex = 20
        Me.lblDescriptionPart4c.Text = "- Power Mode Sleep Event Occurs"
        '
        'BackgroundTaskRunnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 614)
        Me.Controls.Add(Me.lblDescriptionPart4c)
        Me.Controls.Add(Me.lblDescriptionPart4b)
        Me.Controls.Add(Me.lblDescriptionPart4a)
        Me.Controls.Add(Me.linkSourceCode)
        Me.Controls.Add(Me.lblSourceCode)
        Me.Controls.Add(Me.lblBackgroundTaskRunnerOptions)
        Me.Controls.Add(Me.cbMinimizeOnOpen)
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
    Friend WithEvents cbMinimizeOnOpen As CheckBox
    Friend WithEvents lblBackgroundTaskRunnerOptions As Label
    Friend WithEvents lblSourceCode As Label
    Friend WithEvents linkSourceCode As LinkLabel
    Friend WithEvents lblDescriptionPart4a As Label
    Friend WithEvents lblDescriptionPart4b As Label
    Friend WithEvents lblDescriptionPart4c As Label
End Class
