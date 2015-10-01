' Project:          ISYS 3433 - Assignment #6
' Programmer:       Eduardo Felipe Zecca da Cruz
' Date:             12/10/2013
' Description:      This code is a settings form for the calculator program

Imports System.Data.OleDb

Public Class SettingsForm

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub SettingsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        'Setup our database connection (needs System.Data.OleDb imported)
        Dim con As New OleDbConnection()

        'Setup the command object
        Dim command As New OleDbCommand()

        'Since we are reading data out of the database, we have to declare a data reader
        'to hold the values read
        Dim dr As OleDbDataReader

        'Set the connection string
        con.ConnectionString = LoginForm.ConnectionString

        'Tie the connection object to the command
        command.Connection = con

        'Setup our SELECT statement that joins tables
        command.CommandText = "SELECT password, firstname, lastname, (SELECT COUNT(*) FROM calculations WHERE username = ?) AS quantity FROM users WHERE username = ?"

        'Add the Username that is using the calculator on the execution moment to get his/her informations and count how many calculations he/she has done
        command.Parameters.AddWithValue("username", CalculatorForm.UsernameString)
        command.Parameters.AddWithValue("username", CalculatorForm.UsernameString)

        Try
            'Open our database connection
            con.Open()

            'Execute our SQL
            dr = command.ExecuteReader()

            'Put the informations about the user in the textboxes
            Do While (dr.Read)
                FirstNameTextBox.Text = dr("firstname").ToString()
                LastNameTextBox.Text = dr("lastname").ToString()
                PasswordTextBox.Text = dr("password").ToString()
                ConfirmTextBox.Text = dr("password").ToString()
                CountTextBox.Text = dr("quantity").ToString()
            Loop

            'Close the data reader
            dr.Close()
            'Close the database connection
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        'If the row count is zero, the clear button should be disabled.
        If CountTextBox.Text = "0" Then
            ClearButton.Enabled = False
        Else
            ClearButton.Enabled = True
        End If

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        Dim MessageResult As DialogResult

        MessageResult = MessageBox.Show("Are you sure?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If MessageResult = Windows.Forms.DialogResult.Yes Then
            'Setup our database connection (needs System.Data.OleDb imported)
            Dim con As New OleDbConnection()

            'Setup the command object
            Dim command As New OleDbCommand()

            'Since we are reading data out of the database, we have to declare a data reader
            'to hold the values read
            Dim dr As OleDbDataReader

            'Set the connection string
            con.ConnectionString = LoginForm.ConnectionString

            'Tie the connection object to the command
            command.Connection = con

            'Setup our SELECT statement that joins tables
            command.CommandText = "DELETE FROM calculations WHERE username = ?"

            'Add the Username that is using the calculator on the execution moment to delete all the calculations that he/she did
            command.Parameters.AddWithValue("username", CalculatorForm.UsernameString)


            Try
                'Open our database connection
                con.Open()

                'Execute our SQL
                dr = command.ExecuteReader()

                'Close the data reader
                dr.Close()
                'Close the database connection
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            'Update the CountTextBox to 0
            CountTextBox.Text = "0"

            'Disable the clear button
            ClearButton.Enabled = False

        End If
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        If FirstNameTextBox.Text = "" Or LastNameTextBox.Text = "" Or PasswordTextBox.Text = "" Or ConfirmTextBox.Text = "" Then
            'First check if there is a value entered in all the fields

            MessageBox.Show("There is one or more fields with no value")

        ElseIf PasswordTextBox.Text <> ConfirmTextBox.Text Then
            'The passwords don't match

            MessageBox.Show("The passwords entered don't match")

        Else
            'Update user's informations

            'Setup our database connection (needs System.Data.OleDb imported)
            Dim con As New OleDbConnection()

            'Setup the command object
            Dim command As New OleDbCommand()

            'Since we are reading data out of the database, we have to declare a data reader
            'to hold the values read
            Dim dr As OleDbDataReader

            'Set the connection string
            con.ConnectionString = LoginForm.ConnectionString

            'Tie the connection object to the command
            command.Connection = con

            'Setup our SELECT statement that joins tables
            command.CommandText = "UPDATE users SET [firstname] = ?, [lastname] = ?, [password] = ? WHERE [username] = ?"

            'Add the user's informations on the SQL statement
            command.Parameters.AddWithValue("[firstname]", FirstNameTextBox.Text)
            command.Parameters.AddWithValue("[lastname]", LastNameTextBox.Text)
            command.Parameters.AddWithValue("[password]", PasswordTextBox.Text)
            command.Parameters.AddWithValue("[username]", CalculatorForm.UsernameString)

            Try
                'Open our database connection
                con.Open()

                'Execute our SQL
                dr = command.ExecuteReader()

                'Close the data reader
                dr.Close()
                'Close the database connection
                con.Close()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            MessageBox.Show("The user's information were updated successfully")
            Me.Close()
        End If
    End Sub
End Class