<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsForm
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
        Me.UserInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ConfirmTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmLabel = New System.Windows.Forms.Label()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.HistoryGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.CountTextBox = New System.Windows.Forms.TextBox()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.UserInfoGroupBox.SuspendLayout()
        Me.HistoryGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserInfoGroupBox
        '
        Me.UserInfoGroupBox.Controls.Add(Me.ConfirmTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.ConfirmLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.PasswordTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.PasswordLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.LastNameLabel)
        Me.UserInfoGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.UserInfoGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.UserInfoGroupBox.Location = New System.Drawing.Point(13, 26)
        Me.UserInfoGroupBox.Name = "UserInfoGroupBox"
        Me.UserInfoGroupBox.Size = New System.Drawing.Size(227, 264)
        Me.UserInfoGroupBox.TabIndex = 0
        Me.UserInfoGroupBox.TabStop = False
        Me.UserInfoGroupBox.Text = "User Info"
        '
        'ConfirmTextBox
        '
        Me.ConfirmTextBox.Location = New System.Drawing.Point(10, 224)
        Me.ConfirmTextBox.Name = "ConfirmTextBox"
        Me.ConfirmTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.ConfirmTextBox.Size = New System.Drawing.Size(190, 20)
        Me.ConfirmTextBox.TabIndex = 7
        '
        'ConfirmLabel
        '
        Me.ConfirmLabel.AutoSize = True
        Me.ConfirmLabel.Location = New System.Drawing.Point(7, 207)
        Me.ConfirmLabel.Name = "ConfirmLabel"
        Me.ConfirmLabel.Size = New System.Drawing.Size(45, 13)
        Me.ConfirmLabel.TabIndex = 6
        Me.ConfirmLabel.Text = "Confirm:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(10, 171)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(190, 20)
        Me.PasswordTextBox.TabIndex = 5
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(7, 155)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(56, 13)
        Me.PasswordLabel.TabIndex = 4
        Me.PasswordLabel.Text = "Password:"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(10, 109)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.LastNameTextBox.TabIndex = 3
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(7, 93)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(61, 13)
        Me.LastNameLabel.TabIndex = 2
        Me.LastNameLabel.Text = "Last Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(10, 52)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(190, 20)
        Me.FirstNameTextBox.TabIndex = 1
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(7, 35)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        Me.FirstNameLabel.TabIndex = 0
        Me.FirstNameLabel.Text = "First Name:"
        '
        'HistoryGroupBox
        '
        Me.HistoryGroupBox.Controls.Add(Me.ClearButton)
        Me.HistoryGroupBox.Controls.Add(Me.CountTextBox)
        Me.HistoryGroupBox.Location = New System.Drawing.Point(265, 26)
        Me.HistoryGroupBox.Name = "HistoryGroupBox"
        Me.HistoryGroupBox.Size = New System.Drawing.Size(186, 198)
        Me.HistoryGroupBox.TabIndex = 1
        Me.HistoryGroupBox.TabStop = False
        Me.HistoryGroupBox.Text = "History"
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(57, 151)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(61, 23)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'CountTextBox
        '
        Me.CountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountTextBox.Location = New System.Drawing.Point(47, 52)
        Me.CountTextBox.Multiline = True
        Me.CountTextBox.Name = "CountTextBox"
        Me.CountTextBox.ReadOnly = True
        Me.CountTextBox.Size = New System.Drawing.Size(85, 77)
        Me.CountTextBox.TabIndex = 0
        Me.CountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OKButton
        '
        Me.OKButton.Location = New System.Drawing.Point(285, 267)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 2
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(377, 267)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelButton.TabIndex = 3
        Me.CancelButton.Text = "Cancel"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'SettingsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 302)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.HistoryGroupBox)
        Me.Controls.Add(Me.UserInfoGroupBox)
        Me.Name = "SettingsForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.UserInfoGroupBox.ResumeLayout(False)
        Me.UserInfoGroupBox.PerformLayout()
        Me.HistoryGroupBox.ResumeLayout(False)
        Me.HistoryGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserInfoGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ConfirmTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ConfirmLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents LastNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LastNameLabel As System.Windows.Forms.Label
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameLabel As System.Windows.Forms.Label
    Friend WithEvents HistoryGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents CountTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
End Class
