Imports System.Data.Odbc
Imports System.Data.Odbc.OdbcCommand
Imports System.Windows.Controls
Imports System.Drawing
Imports System.Net.NetworkInformation

Public Class DetailForm
    Dim Conn As OdbcConnection
    Dim StringDB As String
    Dim DSet As DataSet
    Dim DAdapter As OdbcDataAdapter
    Dim DReader As OdbcDataReader

    Public Sub BukaKoneksi()
        StringDB = "Driver={postgreSQL ANSI};database=worker;port=5432;server=localhost;uid=postgres;password=setiawanamb"
        Conn = New OdbcConnection(StringDB)
        Conn.Open()
    End Sub

    Public Sub DisplayDetails(Details As String())
        lblName.Text = ": " & Details(1)
        lblAge.Text = ": " & Details(2)
        lblGender.Text = ": " & Details(3)
        lblDOB.Text = ": " & Details(4)
        lblRoles.Text = ": " & Details(5)
        lblEmail.Text = ": " & Details(6)
        lblEmployment.Text = ": " & Details(7)
        lblDepartment.Text = ": " & Details(8)

    End Sub
    Private Sub Guna2HtmlLabel1_Click_1(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstWorker.SelectedIndexChanged

        Dim Name As String = lstWorker.SelectedItem.ToString()
        Dim query As String = "SELECT * FROM workers WHERE name LIKE '%" & name & "%'"
        BukaKoneksi()
        DAdapter = New OdbcDataAdapter(query, Conn)
        Dim dataTable As New DataTable("a")
        DAdapter.Fill(dataTable)
        Dim rowData(9) As String
        If dataTable.Rows.Count > 0 Then
            Dim row As DataRow = dataTable.Rows(0)
            For i As Integer = 0 To 9
                rowData(i) = row(i).ToString()
            Next
        End If

        DisplayDetails(rowData)
        Conn.Close()

        BukaKoneksi()
        Dim query2 As String = "SELECT *,EXTRACT(HOUR FROM (checkouthour - checkinhour)) FROM attendance WHERE workerid = " & CInt(rowData(0))
        Dim detailAdapter = New OdbcDataAdapter(query2, Conn)
        Dim detailTable As New DataTable("attendance")
        detailAdapter.Fill(detailTable)

        Dim numRows As Integer = detailTable.Rows.Count
        Dim numColumns As Integer = detailTable.Columns.Count
        Dim detalArr(numColumns - 1, numRows - 1) As String

        For i As Integer = 0 To numColumns - 1
            For j As Integer = 0 To numRows - 1
                detalArr(i, j) = detailTable.Rows(j)(i).ToString()
            Next
        Next
        Dim totalHrs As Integer
        Dim totalSlry As Integer
        Dim totalLate As Integer
        For i As Integer = 0 To numRows - 1
            Dim checkIn As String = detalArr(5, i)
            detailsGrid.Rows(0).Cells(i + 1).Value = detalArr(4, i)
            detailsGrid.Rows(1).Cells(i + 1).Value = checkIn
            detailsGrid.Rows(2).Cells(i + 1).Value = detalArr(6, i)
            detailsGrid.Rows(3).Cells(i + 1).Value = detalArr(7, i)
            detailsGrid.Rows(4).Cells(i + 1).Value = CInt(detalArr(7, i)) * CInt(rowData(9))
            totalHrs = totalHrs + CInt(detalArr(7, i))
            totalSlry = totalSlry + CInt(detalArr(7, i)) * CInt(rowData(9))

            Dim timeCheck As String = checkIn(1)
            Dim timeCheck2 As String = checkIn(3)

            If CInt(timeCheck) >= 8 And CInt(timeCheck2) > 0 Then
                detailsGrid.Rows(1).Cells(i + 1).Style.BackColor = Color.Red
                totalLate = totalLate + 1
            Else
                detailsGrid.Rows(1).Cells(i + 1).Style.BackColor = Color.White
            End If


        Next

        txtAmountSalary.Text = ": $" & totalSlry
        txtAmountWorking.Text = ": " & totalHrs
        txtLate.Text = ": " & totalLate

    End Sub


    Private Sub DetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        detailsGrid.RowCount = 5
        detailsGrid.ColumnCount = 31
        detailsGrid.Rows(0).Cells(0).Value = "Day"
        detailsGrid.Rows(1).Cells(0).Value = "Check In"
        detailsGrid.Rows(2).Cells(0).Value = "Check Out"
        detailsGrid.Rows(3).Cells(0).Value = "Working Hours"
        detailsGrid.Rows(4).Cells(0).Value = "Pay/Day"
        BukaKoneksi()
        DAdapter = New OdbcDataAdapter("SELECT id,name FROM workers", Conn)
        DSet = New DataSet
        Dim dataTable As New DataTable("workers")
        DAdapter.Fill(dataTable)
        Dim names(dataTable.Rows.Count - 1) As String
        For i As Integer = 0 To dataTable.Rows.Count - 1
            names(i) = dataTable.Rows(i)("name").ToString()
        Next
        lstWorker.Items.AddRange(names)
        lstWorker.ItemHeight = 10
        Conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub


End Class