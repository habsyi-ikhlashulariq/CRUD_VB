Imports System.Data.SqlClient
Public Class Form1

    Dim jk As String

    Sub kosongkanData()
        tx_nik.Text = ""
        tx_nama.Text = ""
        tx_pekerjaan.Text = ""
        tx_alamat.Text = ""
        tx_berlaku.Text = ""
        cb_agama.Text = "Pilih Agama"
    End Sub
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tbl_ktp", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tbl_ktp")
        DataGridView1.DataSource = (Ds.Tables("tbl_ktp"))

        Button1.Text = "INPUT"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        tx_nik.Enabled = False
        tx_nama.Enabled = False
        tx_pekerjaan.Enabled = False
        tx_alamat.Enabled = False
        DataGridView1.Enabled = False
        tx_ttl.Enabled = False
        tx_berlaku.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        cb_agama.Enabled = False

        kosongkanData()
    End Sub
    Sub siapIsi()
        tx_nik.Enabled = True
        tx_nama.Enabled = True
        tx_pekerjaan.Enabled = True
        tx_alamat.Enabled = True
        DataGridView1.Enabled = True
        tx_ttl.Enabled = True
        tx_berlaku.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        cb_agama.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If tx_nik.Text = "" Or tx_nama.Text = "" Or tx_alamat.Text = "" Or
            tx_pekerjaan.Text = "" Or tx_berlaku.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                If RadioButton1.Checked = True Then
                    jk = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    jk = RadioButton2.Text
                End If

                Call koneksi()
                Dim insertData As String = "INSERT INTO tbl_ktp VALUES ('" & tx_nik.Text & "',
                '" & tx_nama.Text & "', '" & tx_ttl.Text & "', '" & jk & "', '" & tx_alamat.Text & "',
                '" & cb_agama.Text & "', '" & tx_pekerjaan.Text & "', '" & tx_berlaku.Text & "')"
                Cmd = New SqlCommand(insertData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Insert Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub tx_nik_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_nik.KeyPress

        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New SqlCommand("SELECT * FROM tbl_ktp WHERE nik = '" & tx_nik.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then

                tx_nama.Text = Rd.Item("nama")
                tx_ttl.Text = Rd.Item("ttl")
                If Rd.Item("jk") = "Laki-Laki" Then
                    jk = RadioButton1.Checked
                ElseIf Rd.Item("jk") = "Perempuan" Then
                    jk = RadioButton2.Checked
                End If

                tx_alamat.Text = Rd.Item("alamat")
                cb_agama.Text = Rd.Item("agama")
                tx_pekerjaan.Text = Rd.Item("pekerjaan")
                tx_berlaku.Text = Rd.Item("berlaku")
            Else
                MsgBox("Data Tidak Ditemukan")
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "UPDATE" Then
            Button2.Text = "SIMPAN"
            Button1.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If tx_nik.Text = "" Or tx_nama.Text = "" Or tx_alamat.Text = "" Or
            tx_pekerjaan.Text = "" Or tx_berlaku.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                If RadioButton1.Checked = True Then
                    jk = RadioButton1.Text
                ElseIf RadioButton2.Checked = True Then
                    jk = RadioButton2.Text
                End If

                Call koneksi()
                Dim insertData As String = "UPDATE tbl_ktp set alamat='" & tx_alamat.Text & "'
                WHERE nik ='" & tx_nik.Text & "'"
                Cmd = New SqlCommand(insertData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Update Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button3.Text = "DELETE" Then
            Button3.Text = "SIMPAN"
            Button2.Enabled = False
            Button1.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If tx_nik.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim deleteData As String = "DELETE FROM tbl_ktp WHERE
                nik='" & tx_nik.Text & "'"
                Cmd = New SqlCommand(deleteData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Hapus Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "TUTUP" Then
            Me.Close()
        Else
            Call kondisiAwal()
        End If
    End Sub

    Private Sub tx_nik_TextChanged(sender As Object, e As EventArgs) Handles tx_nik.TextChanged

    End Sub
End Class
