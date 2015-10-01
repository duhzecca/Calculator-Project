' Project:          ISYS 3433 - Assignment #6
' Programmer:       Eduardo Felipe Zecca da Cruz
' Date:             12/1/2013
' Description:      This code is a history form for the calculator program

Imports System.Data.OleDb

Public Class HistoryForm
    Private Structure CalculationStructure
        Dim UserString As String
        Dim CalculationTimeString As String
        Dim CalculationString As String
        Dim ResultDecimal As Decimal
    End Structure

    Private Calculations As New ArrayList()

    Private Sub CloseButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub HistoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Clear the ArrayList
        Calculations.Clear()
        'Clear the DataGrid
        DataGridView1.Rows.Clear()

        'Define the number of columns for our datagrid
        DataGridView1.ColumnCount = 4

        'Set the titles for each column
        DataGridView1.Columns(0).Name = "User"
        DataGridView1.Columns(1).Name = "Calculation Time"
        DataGridView1.Columns(2).Name = "Calculation"
        DataGridView1.Columns(3).Name = "Result"

        LoadDataIntoGrid()
    End Sub

    Private Sub LoadDataIntoGrid()
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
        command.CommandText = "SELECT firstname, lastname, calculation, result, calculationts FROM users a," &
                    "calculations b WHERE a.username = ? AND a.username = b.username "

        'Add the Username that is using the calculator on the execution moment to get all the calculations that he/she has done
        command.Parameters.AddWithValue("username", CalculatorForm.UsernameString)

        Try
            'Open our database connection
            con.Open()

            'Execute our SQL
            dr = command.ExecuteReader()

            'Since this query has the possibility of returning more than one row, we need
            'to process the results using a loop
            Do While (dr.Read)
                DataGridView1.Rows.Add(New String() {dr(0).ToString() & " " & dr(1).ToString(), dr(4).ToString(), dr(2).ToString(), dr(3).ToString()})

                'Define a new instance of the structure
                Dim CalculationItem As CalculationStructure

                'Populate the structure from the fields read from the table
                CalculationItem.UserString = dr(0).ToString() & " " & dr(1).ToString()
                CalculationItem.CalculationTimeString = dr(4).ToString()
                CalculationItem.CalculationString = dr(2).ToString()
                CalculationItem.ResultDecimal = Decimal.Parse(dr(3).ToString())

                'Add structure to HistoryList ArrayList
                Calculations.Add(CalculationItem)

            Loop

            'Close the data reader
            dr.Close()
            'Close the database connection
            con.Close()
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim MyFont As New Font("Arial", 12)
        Dim VerticalLocation As Integer = e.MarginBounds.Top
        Dim TotalCalculations As Integer

        e.Graphics.DrawString(
            "Name".PadRight(35) & "Calculation Time".PadRight(35) & "Calculation".PadRight(35) & "Result",
            MyFont,
            Brushes.Black,
            e.MarginBounds.Left,
            VerticalLocation _
        )

        VerticalLocation += MyFont.GetHeight() + 25

        For Each CalculationItem As CalculationStructure In Calculations

            e.Graphics.DrawString( _
                CalculationItem.UserString.PadRight(35) & CalculationItem.CalculationTimeString.PadRight(35) & CalculationItem.CalculationString.PadRight(35) & CalculationItem.ResultDecimal,
                MyFont,
                Brushes.Black,
                e.MarginBounds.Left,
                VerticalLocation _
            )
            VerticalLocation += MyFont.GetHeight() + 8

            TotalCalculations += 1
        Next

        VerticalLocation += MyFont.GetHeight() + 17

        e.Graphics.DrawString(
            "Total Calculations: " & TotalCalculations.ToString(),
            MyFont,
            Brushes.Black,
            e.MarginBounds.Left,
            VerticalLocation _
        )


    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub
End Class