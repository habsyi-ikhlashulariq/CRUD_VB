Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Public Class Form2
    Dim _sp As New clsStoredProc
#Region "Handle Prosedur and Function Code"
    Public Function DIFORMAT(ByVal strInput, ByVal intPanjang, ByVal ratake)
        Dim STRCETAK, PJGCETAK
        If IsDBNull(strInput) Then
            DIFORMAT = Space(intPanjang)
        Else
            STRCETAK = Trim(strInput)
            PJGCETAK = Len(STRCETAK)
            If PJGCETAK >= intPanjang Then
                DIFORMAT = Strings.Left(STRCETAK, intPanjang)
            Else
                If ratake = 1 Then 'rata kiri
                    DIFORMAT = STRCETAK & Space(intPanjang - PJGCETAK)
                ElseIf ratake = 2 Then 'rata kanan
                    DIFORMAT = Space(intPanjang - PJGCETAK) & STRCETAK
                Else 'rata tengah
                    DIFORMAT = Space((intPanjang - PJGCETAK) \ 2) & STRCETAK & Space((intPanjang -
                   PJGCETAK) \ 2)
                End If
            End If
        End If
    End Function
    Private Sub SETTINGGRID()
        Dim judul() As String = {"Kode", "Keterangan", "NJOP TKP", "NJOP", "Tarif"}
        Dim lebar() As String = {45, 150, 90, 90, 60}
        grd.ColumnCount = 5
        For i As Integer = 0 To grd.ColumnCount - 1
            grd.Columns(i).Name = judul(i)
            grd.Columns(i).Width = lebar(i)
            If i < 2 Then
                grd.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                grd.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            Else
                grd.Columns(i).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
                grd.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            grd.Columns(i).SortMode = DataGridViewColumnSortMode.NotSortable
        Next
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
    Private Sub BERSIHLAYAR()
        TextBox1.Text = "" : TextBox2.Text = "" : TextBox3.Text = "" : TextBox4.Text = ""
        TextBox5.Text = ""
        btnSave.Text = "Simpan" : btnSave.Enabled = True : btnDele.Enabled = False
    End Sub
    Private Sub ISIGRID()
        bukakoneksi()
        grd.Rows.Clear()
        Dim str As String
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        _sp.STORED_KELAS("S")
        str = "exec klsTAMPIL"
        Dim da As New SqlDataAdapter(sql, conn)
        Dim ds As New DataSet
        da.Fill(ds)
        cmd = New SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            grd.Rows.Add(rd!kdkelas, rd!keterangan, Format(rd!nilaitkp, "#,##0"), Format(rd!nilainjop, "#,##0"), rd!nilaitarif)
        Loop
        tutupkoneksi()
        If grd.RowCount > 0 Then btnView.Enabled = True Else btnView.Enabled = False
    End Sub
    Private Sub CARIDATA()
        bukakoneksi()
        Dim cmd As SqlCommand
        Dim rd As SqlDataReader
        _sp.STORED_KELAS("C")
        str = "exec klsCARI '" & TextBox1.Text.Trim & "'"
        cmd = New SqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.Read Then
            If Not IsDBNull(rd!keterangan) Then TextBox2.Text = Trim(rd!keterangan)
            If IsNumeric(rd!nilaitkp) Then TextBox3.Text = Trim(rd!nilaitkp)
            If IsNumeric(rd!nilainjop) Then TextBox4.Text = Trim(rd!nilainjop)
            If IsNumeric(rd!nilaitarif) Then TextBox5.Text = Trim(rd!nilaitarif)
            btnSave.Text = "Update" : btnSave.Enabled = True : btnDele.Enabled = True
        End If
        tutupkoneksi()
        TextBox2.Focus()
    End Sub
    Private Sub SIMPANDATA()
        bukakoneksi()
        If btnSave.Text = "Simpan" Then
            _sp.STORED_KELAS("I")
            sql = "exec klsTAMBAH '" & TextBox1.Text.Trim & "','" & TextBox2.Text.Trim & "'," & Val(TextBox3.Text) & "," & Val(TextBox4.Text) & "," & Val(TextBox5.Text)
        Else
            _sp.STORED_KELAS("U")
            sql = "exec klsUBAH '" & TextBox1.Text.Trim & "','" & TextBox2.Text.Trim & "'," & Val(TextBox3.Text) & "," & Val(TextBox4.Text) & "," & Val(TextBox5.Text)
        End If
        comSQL = New SqlCommand(sql, conn)
        tutupkoneksi()
        ISIGRID()
        TextBox1.Focus()
    End Sub
    Private Sub TAMPILDATA()
        Dim mulai As Boolean = True, BRS As Integer = 0, P As StreamWriter, aFile As String
        Dim oKODE As String, oKET As String, oTKP As String, oNJOP As String, oTARIF As String
        aFile = Application.StartupPath & "\kelas.txt"
        If File.Exists(aFile) Then File.Delete(aFile)
        P = New StreamWriter(aFile, True, Encoding.Unicode)
        For i As Integer = 0 To grd.RowCount - 1
            If BRS > 65 Or mulai = True Then
                If BRS > 65 Then P.WriteLine(Chr(12))
                mulai = False
                P.WriteLine("DAFTAR NILAI JUAL OBJEK PAJAK DAN TARIF PAJAK")
                P.WriteLine("")
                P.WriteLine("Tanggal cetak : " & Format(CDate(Now), "dd/MM/yyyy hh:mm:ss"))

                P.WriteLine("========================================================================")
                P.WriteLine("Kode Keterangan NJOP TKP NJOP TARIF")
                P.WriteLine("---- ----------------------------------- ------------ ------------ -----")
                ' 1234 12345678901234567890123456789012345 123456789012 123456789012 12345
                BRS = 6
            End If
            oKODE = Trim(grd.Item(0, i).Value)
            oKET = Trim(grd.Item(1, i).Value)
            oTKP = Trim(grd.Item(2, i).Value)
            oNJOP = Trim(grd.Item(3, i).Value)
            oTARIF = Trim(grd.Item(4, i).Value)
            P.WriteLine(DIFORMAT(oKODE, 4, 1) & Space(1) & DIFORMAT(oKET, 35, 1) & Space(1) &
           DIFORMAT(oTKP, 12, 2) & Space(1) & _
            DIFORMAT(oNJOP, 12, 2) & Space(1) & DIFORMAT(oTARIF, 5, 2))
            BRS = BRS + 1
        Next
        P.WriteLine("------------------------------------------------------------------------")
        P.WriteLine(Chr(12))
        P.Close()
    End Sub
    Private Sub HAPUSDATA()
        Dim tanya As Object
        tanya = MsgBox("Yakin Data Akan Di-HAPUS...?", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Hapus")
        If tanya = MsgBoxResult.No Then Exit Sub
        _sp.STORED_KELAS("D")
        sql = "exec klsHAPUS '" & TextBox1.Text.Trim & "'"
        comSQL = New SqlCommand(sql, conn)
        tutupkoneksi()
        ISIGRID()
        TextBox1.Focus()
    End Sub
#End Region
#Region "Handle Setting Form"
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bukakoneksi()
        SETTINGGRID()
        BERSIHLAYAR()
        tutupkoneksi()
    End Sub
    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        btnNew.Focus()
    End Sub
#End Region
#Region "Handle Componen Focus"
    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        BERSIHLAYAR()
    End Sub
#End Region
#Region "Handle Componen Keypress"
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress, TextBox2.KeyPress, TextBox3.KeyPress, TextBox4.KeyPress, TextBox5.KeyPress
        HANDLEKEYPRESS(sender, e)
    End Sub
#End Region
#Region "Handle Componen Click"
    Private Sub grd_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grd.CellContentClick
        TextBox1.Text = grd.Item(0, grd.CurrentRow.Index).Value
        CARIDATA()
    End Sub

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
        bukakoneksi()
        TAMPILDATA()
        frmCetak.TextBox1.Text = Application.StartupPath & "\kelas.txt"
        frmCetak.lblJudul.Text = "Daftar Kelas Pajak Bumi Dan Bangunan"
        frmCetak.Show()
    End Sub
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Dispose()
    End Sub
#End Region
End Class