Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Public Class frmCetak
    Private Sub frmCetak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tampil()
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim strData As String
        strData = Trim(TextBox1.Text)
        Dim oReader As StreamReader = New StreamReader(strData)
        dgv.Text = oReader.ReadToEnd
        oReader.Close()
        oReader = Nothing
    End Sub
    Private Sub imaClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imaClose.Click
        Dispose()
    End Sub
    Private Sub tampil()
        bukakoneksi()
        sql = "select kdkelas,keterangan,nilaitkp,nilainjop,nilaitarif from tblkelas order by kdkelas"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        Dim dt As New DataTable
        For Each dt In ds.Tables
            dgv.DataSource = dt

        Next
        tutupkoneksi()
    End Sub
End Class
