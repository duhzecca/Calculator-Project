' Project:          ISYS 3433 - Assignment #6
' Programmer:       Eduardo Felipe Zecca da Cruz
' Date:             11/9/2013
' Description:      This code is for a calculator

Option Strict On

Imports System.Data.OleDb

Public Class CalculatorForm

    Friend UsernameString As String

    Dim AcumulatorOperationsDecimal As Decimal 'Variable that will hold the result of the calculation
    Dim TrackOperationString As String 'Keep track of the last operation button that was pushed     
    Dim CalculateResultDisplayedBoolean As Boolean = False 'Keep track if a calcutalion is being displayed

    Private Sub DisplayResult(ByVal DecimalValue As Decimal)
        'function that displays the result on the EntryLabel
        Dim ResultString As String

        If CalculateResultDisplayedBoolean Then
            If TruncateResultsToolStripMenuItem.Checked Then
                ResultString = DecimalValue.ToString("N4")
            Else
                ResultString = DecimalValue.ToString()
            End If

            EntryLabel.Text = ResultString
        End If

    End Sub

    Private Function RemoveLastCharacter(ByVal EntryString As String) As String
        'function that remove the last character in a string
        Dim MyOutputString As String

        If EntryString.Length = 1 Then
            MyOutputString = "0"
        ElseIf EntryString(EntryString.Length - 2) = "." Then 'condition to remove the number and the . (dot)
            MyOutputString = EntryString.Substring(0, EntryString.Length - 2)
        Else
            MyOutputString = EntryString.Substring(0, EntryString.Length - 1)
        End If

        Return MyOutputString
    End Function

    Private Sub ClearButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearLabel.Click
        'ClearButton Click - Erase all the labels
        Dim MessageResult As DialogResult

        MessageResult = MessageBox.Show("Are you sure?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MessageResult = Windows.Forms.DialogResult.Yes Then
            CalculationLabel.Text = ""
            EntryLabel.Text = "0"
            AcumulatorOperationsDecimal = 0
            CalculateResultDisplayedBoolean = False
        End If
    End Sub

    Private Sub ClearEntryButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ClearEntryLabel.Click
        'ClearEntryButton Click - Erase just the EntryLabel
        EntryLabel.Text = "0"
    End Sub

    Private Sub OneButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OneButton.Click, TwoButton.Click, ThreeButton.Click, FourButton.Click, FiveButton.Click,
        SixButton.Click, SevenButton.Click, EightButton.Click, NineButton.Click, ZeroButton.Click, DecimalButton.Click
        'This method put the numbers (0-9) or the dot on the EntryLabel
        Dim MyButton As Button = CType(sender, Button) 'Variable that hands the button that will be clicked by the user

        If EntryLabel.Text = "0" Or TrackOperationString = "=" Then
            TrackOperationString = ""
            EntryLabel.Text = MyButton.Text
        Else
            EntryLabel.Text = EntryLabel.Text & MyButton.Text
        End If

    End Sub


    Private Sub AddButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles AddButton.Click, SubtractButton.Click, MultiplyButton.Click, DivideButton.Click,
        EqualsButton.Click
        'This method insert the number in the CalculationLabel and put the appropriate symbol (+,-,*,/) and clear the EntryLabel
        'Also this method do the calculation if the user press the equals button and clear the CalculationLabel and show the result in the EntryLabel
        Dim MyButton As Button = CType(sender, Button) 'Variable that hands the button that will be clicked by the user        

        Try
            If TrackOperationString = "+" Then
                AcumulatorOperationsDecimal += Decimal.Parse(EntryLabel.Text)
            ElseIf TrackOperationString = "-" Then
                AcumulatorOperationsDecimal -= Decimal.Parse(EntryLabel.Text)
            ElseIf TrackOperationString = "*" Then
                AcumulatorOperationsDecimal *= Decimal.Parse(EntryLabel.Text)
            ElseIf TrackOperationString = "/" Then
                AcumulatorOperationsDecimal /= Decimal.Parse(EntryLabel.Text)
            Else
                AcumulatorOperationsDecimal = Decimal.Parse(EntryLabel.Text)
            End If

            If Not MyButton.Text = "=" Then
                CalculationLabel.Text &= EntryLabel.Text & " " & MyButton.Text & " "
            Else
                CalculationLabel.Text &= EntryLabel.Text
            End If

            TrackOperationString = MyButton.Text
            EntryLabel.Text = ""

            If MyButton.Text = EqualsButton.Text Then
                'Add calculation information on database
                Try
                    AddCalculationEntry(UsernameString, CalculationLabel.Text, AcumulatorOperationsDecimal)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
                CalculateResultDisplayedBoolean = True
                CalculationLabel.Text = ""
                DisplayResult(AcumulatorOperationsDecimal)
                AcumulatorOperationsDecimal = 0
            End If
        Catch ex As Exception
            MessageBox.Show("You need to insert a value to the this operation")
        End Try

    End Sub

    Private Sub AddCalculationEntry(ByVal username As String, ByVal calculation As String, ByVal result As Decimal)
        'Insert the informations about a calculation on the database

        '1. Create a new database connection object
        Dim con As New OleDbConnection(LoginForm.ConnectionString)

        '2. Create a new command object
        Dim command As New OleDbCommand()

        '3. Create a variable to hold the current time
        Dim CurrentTime As String = DateTime.Now.ToString("MM/dd/yyyy HH:mm")

        '4. Set the connection for our command
        command.Connection = con

        '5. Set the text for our command
        'columns in transactions table are: username, transdate, taxamt, transamt
        command.CommandText = "INSERT INTO calculations (username, calculation, result, calculationts) VALUES (?, ?, ?, ?)"

        '6. Insert the values in our command
        command.Parameters.AddWithValue("username", username)
        command.Parameters.AddWithValue("calculation", calculation)
        command.Parameters.AddWithValue("result", result)
        command.Parameters.AddWithValue("calculationts", CurrentTime)

        '7. Open the database
        con.Open()

        '8. Execute our command and store results in data reader
        command.ExecuteNonQuery()

        '9. Close the connection
        con.Close()

    End Sub


    Private Sub CalculatorForm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        'MessageBox.Show("SUP BRO " & e.KeyChar.ToString())
        Dim MyButton As Button = New Button()

        MyButton.Text = e.KeyChar.ToString()

        Select Case e.KeyChar.ToString()
            Case "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "."
                If EntryLabel.Text = "0" And EntryLabel.Text <> "." Or TrackOperationString = "=" Then
                    TrackOperationString = ""
                    EntryLabel.Text = MyButton.Text
                Else
                    EntryLabel.Text &= MyButton.Text
                End If
            Case "+", "-", "*", "/", "="
                AddButton_Click(MyButton, System.Windows.Forms.MouseEventArgs.Empty)
        End Select



    End Sub

    Private Sub DeleteLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        EntryLabel.Text = RemoveLastCharacter(EntryLabel.Text)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ColorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColorToolStripMenuItem1.Click
        With ColorDialog1
            .Color = EntryLabel.BackColor
            .ShowDialog()
            EntryLabel.BackColor = .Color
            CalculationLabel.BackColor = .Color
        End With
    End Sub

    Private Sub FontToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FontToolStripMenuItem1.Click
        With FontDialog1
            .Font = EntryLabel.Font
            .ShowDialog()
            EntryLabel.Font = .Font
            CalculationLabel.Font = .Font
        End With
    End Sub

    Private Sub TruncateResultsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TruncateResultsToolStripMenuItem.Click
        TruncateResultsToolStripMenuItem.Checked = Not TruncateResultsToolStripMenuItem.Checked
        DisplayResult(Decimal.Parse(EntryLabel.Text))
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.Visible = True
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HistoryToolStripMenuItem.Click
        HistoryForm.ShowDialog()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SettingsToolStripMenuItem.Click
        SettingsForm.ShowDialog()
    End Sub
End Class
