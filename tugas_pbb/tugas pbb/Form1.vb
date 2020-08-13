Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class Form1
#Region "Handle Setting Form"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SETTINGGRID()
        BERSIHLAYAR()
    End Sub
    Private Sub Form1_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        btnNew.Focus()
    End Sub
#End Region
#Region "Handle Prosedur and Function Code"
    Private Sub SETTINGGRID()
        Dim judul() As String = {"Kode", "Keterangan", "NJOP TKP", "NJOP", "Tarif"}
        Dim lebar() As String = {45, 150, 90, 90, 60}
        grd.ColumnCount = 5
        For i As Integer = 0 To grd.ColumnCount - 1
            grd.Columns(i).Name = judul(i)
            grd.Columns(i).Width = lebar(i)
            If i < 2 Then
                grd.Columns(i).HeaderCell.Style.Alignment =DataGridViewContentAlignment.MiddleLeft
                grd.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Else
                grd.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grd.Columns(i).DefaultCellStyle.Alignment =
               DataGridViewContentAlignment.MiddleRight
            End If
            grd.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
    End Sub
    Private Sub BERSIHLAYAR()
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = ""
        TextBox4.Text = "" : TextBox5.Text = ""
        btnSave.Text = "Simpan" : btnSave.Enabled = True : btnDele.Enabled = True
    End Sub
    Private Sub HANDLEKEYPRESS(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            If sender.name = "TextBox1" Then CARIDATA()
            If sender.name = "TextBox2" Then TextBox3.Focus()
            If sender.name = "TextBox3" Then TextBox4.Focus()
            If sender.name = "TextBox4" Then TextBox5.Focus()
            If sender.name = "TextBox5" Then
                btnSave.Enabled = True
                btnSave.Focus()
            End If
            e.Handled = True
        End If
    End Sub
#End Region
#Region "Handle Componen Focus"
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        BERSIHLAYAR()
    End Sub
#End Region
#Region "Handle Componen Keypress"
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress,
        TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress,
       TextBox5.KeyPress
        HANDLEKEYPRESS(sender, e)
    End Sub
    Private Sub ISIGRID()
        bukakoneksi()
        grd.Rows.Clear()
        Dim str As String
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        str = "select kdkelas,keterangan,nilaitkp,nilainjop,nilaitarif from tblkelas order by kdkelas"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        cmd = New SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            grd.Rows.Add(rd!kdkelas, rd!keterangan, Format(rd!nilaitkp, "#,##0"), Format(rd!nilainjop, "#,##0"), rd!nilaitarif)
        Loop
        If grd.RowCount > 0 Then btnView.Enabled = True Else btnView.Enabled = False
        tutupkoneksi()
    End Sub
    Private Sub CARIDATA()
        bukakoneksi()
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        str = "select keterangan,nilainjop,nilaitarif,nilaitkp from tblkelas where kdkelas='" & TextBox1.Text.Trim & "'"
        cmd = New SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            If Not IsDBNull(rd!keterangan) Then TextBox2.Text = Trim(rd!keterangan)
            If IsNumeric(rd!nilaitkp) Then TextBox3.Text = Trim(rd!nilaitkp)
            If IsNumeric(rd!nilainjop) Then TextBox4.Text = Trim(rd!nilainjop)
            If IsNumeric(rd!nilaitarif) Then TextBox5.Text = Trim(rd!nilaitarif)
            btnSave.Text = "Update" : btnSave.Enabled = True : btnDele.Enabled =
           True
        End If
        tutupkoneksi()
        TextBox2.Focus()
    End Sub
    Private Sub SIMPANDATA()
        bukakoneksi()
        If btnSave.Text = "Simpan" Then
            sql = "insert into tblkelas(kdkelas,keterangan,nilaitkp,nilainjop,nilaitarif) values('" & TextBox1.Text.Trim & "','" & TextBox2.Text.Trim & "'," & Val(TextBox3.Text) & "," & Val(TextBox4.Text) & "," & Val(TextBox5.Text) & ")"
        Else
            sql = "update tblkelas set keterangan='" & TextBox2.Text.Trim & "',nilaitkp=" & Val(TextBox3.Text) & ",nilainjop=" & Val(TextBox4.Text) & ",nilaitarif=" & Val(TextBox5.Text) & "where kdkelas='" & TextBox1.Text.Trim & "'"
        End If
        comSQL = New SqlCommand(sql, conn)
        tutupkoneksi()
        ISIGRID()
        TextBox1.Focus()
    End Sub
    Private Sub HAPUSDATA()
        Dim tanya As Object
        tanya = MsgBox("Yakin Data Akan Di-HAPUS...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Hapus")
        If tanya = MsgBoxResult.No Then Exit Sub
        bukakoneksi()
        sql = "delete tblkelas where kdkelas='" & TextBox1.Text.Trim & "'"
        comSQL = New SqlCommand(sql, conn)
        tutupkoneksi()
        ISIGRID()
        TextBox1.Focus()
    End Sub
#End Region
#Region "Handle Componen Click"
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If btnNew.Text = "Buka" Then
            ISIGRID()
            btnNew.Text = "Baru"
        End If
        TextBox1.Focus()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        SIMPANDATA()
    End Sub
    Private Sub btnDele_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDele.Click
        HAPUSDATA()
    End Sub
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        frmCetak.TextBox1.Text = Application.StartupPath & "\kelas.txt"
        frmCetak.lblJudul.Text = "Daftar Kelas Pajak Bumi Dan Bangunan"
        frmCetak.Show()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dispose()
    End Sub
#End Region
End Class
