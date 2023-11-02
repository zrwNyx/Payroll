Imports System.Data.Odbc
Imports System.Windows.Forms.DataVisualization.Charting

Public Class HomeForm
    Dim Conn As OdbcConnection
    Dim StringDB As String
    Dim DAdapter As OdbcDataAdapter
    Dim SAdapter As OdbcDataAdapter
    Public Sub BukaKoneksi()
        StringDB = "Driver={postgreSQL ANSI};database=worker;port=5432;server=localhost;uid=postgres;password=setiawanamb"
        Conn = New OdbcConnection(StringDB)
        Conn.Open()
    End Sub


    Public Sub DisplayChart(query As String, tableName As DataTable, chart As Chart, label As Guna.UI2.WinForms.Guna2HtmlLabel, Series As String, adapter As OdbcDataAdapter, scale As Integer())

        adapter = New OdbcDataAdapter(query, Conn)

        adapter.Fill(tableName)

        Dim numRows As Integer = tableName.Rows.Count
        Dim numColumns As Integer = tableName.Columns.Count

        Dim arrProd(numColumns - 1, numRows - 1) As String
        For i As Integer = 0 To numColumns - 1
            For j As Integer = 0 To numRows - 1
                arrProd(i, j) = tableName.Rows(j)(i).ToString()
            Next
        Next

        label.Text = arrProd(0, 0).ToString()

        With chart
            .Series.Clear()
            .Series.Add(Series)
            .ChartAreas(0).AxisY.Minimum = scale(0)
            .ChartAreas(0).AxisY.Maximum = scale(1)
            .ChartAreas(0).AxisY.Interval = scale(2)
            .ChartAreas(0).AxisY.LabelStyle.IsEndLabelVisible = True
            .ChartAreas(0).AxisX.Interval = 2
            .ChartAreas(0).AxisX.IntervalOffset = 1


            For i As Integer = 0 To numRows - 1
                .Series(Series).Points.AddXY(arrProd(0, i), arrProd(1, i))
            Next

        End With

    End Sub
    Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT a.name, SUM(CAST(EXTRACT(EPOCH FROM (checkouthour - checkinhour)) / 60 AS INTEGER)) FROM attendance b JOIN workers a ON a.id = b.workerid GROUP BY a.name ORDER BY 2 DESC"
        Dim query2 As String = "SELECT a.name, CAST(SUM(EXTRACT(HOUR FROM (b.checkouthour - b.checkinhour)) * a.salary_per_hour) AS INTEGER)FROM attendance b JOIN workers a ON a.id = b.workerid GROUP BY a.name ORDER BY 2 DESC"
        Dim query3 As String = "SELECT CAST(SUM(EXTRACT(HOUR FROM (b.checkouthour - b.checkinhour)) * a.salary_per_hour) AS INTEGER)FROM attendance b JOIN workers a ON a.id = b.workerid "
        Dim dataTable As New DataTable("b")
        Dim dataTable2 As New DataTable("c")
        Dim scale1() As Integer = {15000, 16500, 200}
        Dim scale2() As Integer = {4300, 9500, 1000}
        BukaKoneksi()
        DisplayChart(query, dataTable, chartProd, lblName1, "Working Minutes Total", DAdapter, scale1)
        DisplayChart(query2, dataTable2, salaryChart, lblName2, "Salary Total", SAdapter, scale2)
        Dim command As New OdbcCommand(query3, Conn)
        Dim totalPaid As Object = command.ExecuteScalar()
        lblTotalSal.Text = "$ " & totalPaid.ToString()





    End Sub


End Class