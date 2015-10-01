' Project:          ISYS 3433 - Assignment #6
' Programmer:       Eduardo Felipe Zecca da Cruz
' Date:             11/9/2013
' Description:      This code is a login form for the calculator program

Option Strict On

Imports System.Data.OleDb

Public Class LoginForm

    Friend ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data source=" & Application.StartupPath &
"\EfzeccadCalculatorDatabase.accdb"

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim ErrorMessage As String = ""
        Try
            If AuthenticateUser(UsernameTextBox.Text, PasswordTextBox.Text, ErrorMessage) Then
                'User is authenticated                
                CalculatorForm.Show()
                Me.Close()
            Else
                MessageBox.Show(ErrorMessage)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Function AuthenticateUser(ByVal UsernameString As String, ByVal PasswordString As String, ByRef ErrorString As String) As Boolean
        'Function that authenticates the user on the database

        Dim dbFirstNameString As String
        Dim dbPasswordString As String
        Dim UserFoundBoolean As Boolean = False

        'Create a database connection object
        Dim con As New OleDbConnection(ConnectionString)

        'Create a command object
        Dim command As New OleDbCommand()

        'Since we are doing a SELECT, we need to declare a data reader object to hold our results
        Dim dr As OleDbDataReader

        'Set the connection for our command
        command.Connection = con

        'Set the text for our command
        command.CommandText = "SELECT password, firstname FROM users WHERE username = ?"

        'Insert the values in our command
        command.Parameters.AddWithValue("username", UsernameString)

        'Open the database
        con.Open()

        'Execute our command and store results in data reader
        dr = command.ExecuteReader()

        'Read the results from our data reader

        If UsernameString = "" And PasswordString = "" Then
            ErrorString = "Insert Username and Password"
        ElseIf dr.Read() Then
            'Validate password
            dbFirstNameString = dr("firstname").ToString()
            dbPasswordString = dr("password").ToString()
            If dbPasswordString = PasswordString Then
                UserFoundBoolean = True
                CalculatorForm.UsernameString = UsernameString
                CalculatorForm.Text = "Welcome Back, " & dr("firstname").ToString()
                'TODO - set the username for the CalculatorForm
            Else
                ErrorString = "Password invalid"
            End If

        Else
            ErrorString = "Username " & UsernameString & " not found"
        End If

        dr.Close()
        con.Close()

        Return UserFoundBoolean
    End Function

End Class
