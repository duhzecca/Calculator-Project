<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CalculatorForm
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
        Me.EntryLabel = New System.Windows.Forms.Label()
        Me.SevenButton = New System.Windows.Forms.Button()
        Me.EightButton = New System.Windows.Forms.Button()
        Me.NineButton = New System.Windows.Forms.Button()
        Me.MultiplyButton = New System.Windows.Forms.Button()
        Me.SubtractButton = New System.Windows.Forms.Button()
        Me.SixButton = New System.Windows.Forms.Button()
        Me.FiveButton = New System.Windows.Forms.Button()
        Me.FourButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ThreeButton = New System.Windows.Forms.Button()
        Me.TwoButton = New System.Windows.Forms.Button()
        Me.OneButton = New System.Windows.Forms.Button()
        Me.EqualsButton = New System.Windows.Forms.Button()
        Me.ZeroButton = New System.Windows.Forms.Button()
        Me.DecimalButton = New System.Windows.Forms.Button()
        Me.DivideButton = New System.Windows.Forms.Button()
        Me.ClearEntryLabel = New System.Windows.Forms.Button()
        Me.ClearLabel = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.CalculationLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TruncateResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EntryLabel
        '
        Me.EntryLabel.BackColor = System.Drawing.Color.White
        Me.EntryLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryLabel.Location = New System.Drawing.Point(6, 70)
        Me.EntryLabel.Name = "EntryLabel"
        Me.EntryLabel.Size = New System.Drawing.Size(328, 31)
        Me.EntryLabel.TabIndex = 1
        Me.EntryLabel.Text = "0"
        Me.EntryLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SevenButton
        '
        Me.SevenButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SevenButton.Location = New System.Drawing.Point(10, 189)
        Me.SevenButton.Name = "SevenButton"
        Me.SevenButton.Size = New System.Drawing.Size(66, 60)
        Me.SevenButton.TabIndex = 2
        Me.SevenButton.Text = "7"
        Me.SevenButton.UseVisualStyleBackColor = True
        '
        'EightButton
        '
        Me.EightButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EightButton.Location = New System.Drawing.Point(98, 189)
        Me.EightButton.Name = "EightButton"
        Me.EightButton.Size = New System.Drawing.Size(66, 60)
        Me.EightButton.TabIndex = 3
        Me.EightButton.Text = "8"
        Me.EightButton.UseVisualStyleBackColor = True
        '
        'NineButton
        '
        Me.NineButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NineButton.Location = New System.Drawing.Point(184, 189)
        Me.NineButton.Name = "NineButton"
        Me.NineButton.Size = New System.Drawing.Size(66, 60)
        Me.NineButton.TabIndex = 4
        Me.NineButton.Text = "9"
        Me.NineButton.UseVisualStyleBackColor = True
        '
        'MultiplyButton
        '
        Me.MultiplyButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplyButton.Location = New System.Drawing.Point(270, 189)
        Me.MultiplyButton.Name = "MultiplyButton"
        Me.MultiplyButton.Size = New System.Drawing.Size(66, 60)
        Me.MultiplyButton.TabIndex = 5
        Me.MultiplyButton.Text = "*"
        Me.MultiplyButton.UseVisualStyleBackColor = True
        '
        'SubtractButton
        '
        Me.SubtractButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractButton.Location = New System.Drawing.Point(270, 255)
        Me.SubtractButton.Name = "SubtractButton"
        Me.SubtractButton.Size = New System.Drawing.Size(66, 60)
        Me.SubtractButton.TabIndex = 9
        Me.SubtractButton.Text = "-"
        Me.SubtractButton.UseVisualStyleBackColor = True
        '
        'SixButton
        '
        Me.SixButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SixButton.Location = New System.Drawing.Point(184, 255)
        Me.SixButton.Name = "SixButton"
        Me.SixButton.Size = New System.Drawing.Size(66, 60)
        Me.SixButton.TabIndex = 8
        Me.SixButton.Text = "6"
        Me.SixButton.UseVisualStyleBackColor = True
        '
        'FiveButton
        '
        Me.FiveButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiveButton.Location = New System.Drawing.Point(98, 255)
        Me.FiveButton.Name = "FiveButton"
        Me.FiveButton.Size = New System.Drawing.Size(66, 60)
        Me.FiveButton.TabIndex = 7
        Me.FiveButton.Text = "5"
        Me.FiveButton.UseVisualStyleBackColor = True
        '
        'FourButton
        '
        Me.FourButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FourButton.Location = New System.Drawing.Point(10, 255)
        Me.FourButton.Name = "FourButton"
        Me.FourButton.Size = New System.Drawing.Size(66, 60)
        Me.FourButton.TabIndex = 6
        Me.FourButton.Text = "4"
        Me.FourButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.Location = New System.Drawing.Point(270, 321)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(66, 60)
        Me.AddButton.TabIndex = 13
        Me.AddButton.Text = "+"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ThreeButton
        '
        Me.ThreeButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThreeButton.Location = New System.Drawing.Point(184, 321)
        Me.ThreeButton.Name = "ThreeButton"
        Me.ThreeButton.Size = New System.Drawing.Size(66, 60)
        Me.ThreeButton.TabIndex = 12
        Me.ThreeButton.Text = "3"
        Me.ThreeButton.UseVisualStyleBackColor = True
        '
        'TwoButton
        '
        Me.TwoButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TwoButton.Location = New System.Drawing.Point(98, 321)
        Me.TwoButton.Name = "TwoButton"
        Me.TwoButton.Size = New System.Drawing.Size(66, 60)
        Me.TwoButton.TabIndex = 11
        Me.TwoButton.Text = "2"
        Me.TwoButton.UseVisualStyleBackColor = True
        '
        'OneButton
        '
        Me.OneButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OneButton.Location = New System.Drawing.Point(10, 321)
        Me.OneButton.Name = "OneButton"
        Me.OneButton.Size = New System.Drawing.Size(66, 60)
        Me.OneButton.TabIndex = 10
        Me.OneButton.Text = "1"
        Me.OneButton.UseVisualStyleBackColor = True
        '
        'EqualsButton
        '
        Me.EqualsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EqualsButton.Location = New System.Drawing.Point(270, 387)
        Me.EqualsButton.Name = "EqualsButton"
        Me.EqualsButton.Size = New System.Drawing.Size(66, 60)
        Me.EqualsButton.TabIndex = 17
        Me.EqualsButton.Text = "="
        Me.EqualsButton.UseVisualStyleBackColor = True
        '
        'ZeroButton
        '
        Me.ZeroButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZeroButton.Location = New System.Drawing.Point(10, 387)
        Me.ZeroButton.Name = "ZeroButton"
        Me.ZeroButton.Size = New System.Drawing.Size(154, 60)
        Me.ZeroButton.TabIndex = 14
        Me.ZeroButton.Text = "0"
        Me.ZeroButton.UseVisualStyleBackColor = True
        '
        'DecimalButton
        '
        Me.DecimalButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecimalButton.Location = New System.Drawing.Point(184, 387)
        Me.DecimalButton.Name = "DecimalButton"
        Me.DecimalButton.Size = New System.Drawing.Size(66, 60)
        Me.DecimalButton.TabIndex = 16
        Me.DecimalButton.Text = "."
        Me.DecimalButton.UseVisualStyleBackColor = True
        '
        'DivideButton
        '
        Me.DivideButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivideButton.Location = New System.Drawing.Point(270, 123)
        Me.DivideButton.Name = "DivideButton"
        Me.DivideButton.Size = New System.Drawing.Size(66, 60)
        Me.DivideButton.TabIndex = 21
        Me.DivideButton.Text = "/"
        Me.DivideButton.UseVisualStyleBackColor = True
        '
        'ClearEntryLabel
        '
        Me.ClearEntryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearEntryLabel.Location = New System.Drawing.Point(184, 123)
        Me.ClearEntryLabel.Name = "ClearEntryLabel"
        Me.ClearEntryLabel.Size = New System.Drawing.Size(66, 60)
        Me.ClearEntryLabel.TabIndex = 20
        Me.ClearEntryLabel.Text = "CE"
        Me.ClearEntryLabel.UseVisualStyleBackColor = True
        '
        'ClearLabel
        '
        Me.ClearLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearLabel.Location = New System.Drawing.Point(98, 123)
        Me.ClearLabel.Name = "ClearLabel"
        Me.ClearLabel.Size = New System.Drawing.Size(66, 60)
        Me.ClearLabel.TabIndex = 19
        Me.ClearLabel.Text = "C"
        Me.ClearLabel.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.Location = New System.Drawing.Point(10, 123)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(66, 60)
        Me.DeleteButton.TabIndex = 18
        Me.DeleteButton.Text = "Del"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'CalculationLabel
        '
        Me.CalculationLabel.BackColor = System.Drawing.Color.White
        Me.CalculationLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculationLabel.Location = New System.Drawing.Point(6, 39)
        Me.CalculationLabel.Name = "CalculationLabel"
        Me.CalculationLabel.Size = New System.Drawing.Size(328, 31)
        Me.CalculationLabel.TabIndex = 22
        Me.CalculationLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(341, 24)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HistoryToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.HistoryToolStripMenuItem.Text = "&History"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem1, Me.FontToolStripMenuItem1, Me.TruncateResultsToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'ColorToolStripMenuItem1
        '
        Me.ColorToolStripMenuItem1.Name = "ColorToolStripMenuItem1"
        Me.ColorToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.ColorToolStripMenuItem1.Text = "&Color"
        '
        'FontToolStripMenuItem1
        '
        Me.FontToolStripMenuItem1.Name = "FontToolStripMenuItem1"
        Me.FontToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.FontToolStripMenuItem1.Text = "&Font"
        '
        'TruncateResultsToolStripMenuItem
        '
        Me.TruncateResultsToolStripMenuItem.Name = "TruncateResultsToolStripMenuItem"
        Me.TruncateResultsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.TruncateResultsToolStripMenuItem.Text = "&Truncate Results"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'CalculatorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(341, 459)
        Me.Controls.Add(Me.CalculationLabel)
        Me.Controls.Add(Me.DivideButton)
        Me.Controls.Add(Me.ClearEntryLabel)
        Me.Controls.Add(Me.ClearLabel)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.EqualsButton)
        Me.Controls.Add(Me.DecimalButton)
        Me.Controls.Add(Me.ZeroButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.ThreeButton)
        Me.Controls.Add(Me.TwoButton)
        Me.Controls.Add(Me.OneButton)
        Me.Controls.Add(Me.SubtractButton)
        Me.Controls.Add(Me.SixButton)
        Me.Controls.Add(Me.FiveButton)
        Me.Controls.Add(Me.FourButton)
        Me.Controls.Add(Me.MultiplyButton)
        Me.Controls.Add(Me.NineButton)
        Me.Controls.Add(Me.EightButton)
        Me.Controls.Add(Me.SevenButton)
        Me.Controls.Add(Me.EntryLabel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "CalculatorForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator - [efzeccad]"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EntryLabel As System.Windows.Forms.Label
    Friend WithEvents SevenButton As System.Windows.Forms.Button
    Friend WithEvents EightButton As System.Windows.Forms.Button
    Friend WithEvents NineButton As System.Windows.Forms.Button
    Friend WithEvents MultiplyButton As System.Windows.Forms.Button
    Friend WithEvents SubtractButton As System.Windows.Forms.Button
    Friend WithEvents SixButton As System.Windows.Forms.Button
    Friend WithEvents FiveButton As System.Windows.Forms.Button
    Friend WithEvents FourButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents ThreeButton As System.Windows.Forms.Button
    Friend WithEvents TwoButton As System.Windows.Forms.Button
    Friend WithEvents OneButton As System.Windows.Forms.Button
    Friend WithEvents EqualsButton As System.Windows.Forms.Button
    Friend WithEvents ZeroButton As System.Windows.Forms.Button
    Friend WithEvents DecimalButton As System.Windows.Forms.Button
    Friend WithEvents DivideButton As System.Windows.Forms.Button
    Friend WithEvents ClearEntryLabel As System.Windows.Forms.Button
    Friend WithEvents ClearLabel As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents CalculationLabel As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TruncateResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem


End Class
