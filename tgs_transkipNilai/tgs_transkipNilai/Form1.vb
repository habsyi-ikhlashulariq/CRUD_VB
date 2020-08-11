Imports System.Data.SqlClient
Public Class Form1
    Sub kosongkanData()
        tx_kuis.Text = ""
        tx_kehadiran.Text = ""
        tx_npm.Text = ""
        tx_uts.Text = ""
        TextBox1.Text = ""
        lb_nilai_akhir.Text = "..."
        lb_grade.Text = "..."
        kd_matkul.Text = ""
        tx_uas.Text = ""
    End Sub
    Sub kondisiAwal()
        Call koneksi()
        Da = New SqlDataAdapter("SELECT * FROM tb_nilai", conn)
        Ds = New DataSet
        Ds.Clear()

        Da.Fill(Ds, "tb_nilai")
        DataGridView1.DataSource = (Ds.Tables("tb_nilai"))

        Button1.Text = "INPUT"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = False
        DataGridView1.Enabled = False
        tx_kehadiran.Enabled = False
        tx_kuis.Enabled = False
        tx_npm.Enabled = False
        tx_tugas.Enabled = False
        tx_uas.Enabled = False
        TextBox1.Enabled = False
        kd_matkul.Enabled = False
        tx_uts.Enabled = False
        kosongkanData()
    End Sub
    Sub siapIsi()
        DataGridView1.Enabled = True
        tx_kehadiran.Enabled = True
        tx_kuis.Enabled = True
        tx_npm.Enabled = True
        tx_tugas.Enabled = True
        tx_uas.Enabled = True
        TextBox1.Enabled = True
        kd_matkul.Enabled = True
        tx_uts.Enabled = True
        Button5.Enabled = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kondisiAwal()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New SqlCommand("SELECT * FROM tb_nilai WHERE id = '" & TextBox1.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                tx_npm.Text = Rd.Item("npm")
                kd_matkul.Text = Rd.Item("kd_matkul")
                tx_tugas.Text = Rd.Item("tugas")
                tx_kehadiran.Text = Rd.Item("kehadiran")
                tx_kuis.Text = Rd.Item("kuis")
                tx_uts.Text = Rd.Item("uts")
                tx_uas.Text = Rd.Item("uas")
                lb_nilai_akhir.Text = Rd.Item("nilai_akhir")
                lb_grade.Text = Rd.Item("grade")
            Else
                MsgBox("Data Tidak Ditemukan")
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "INPUT" Then
            Button1.Text = "SIMPAN"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "Batal"
            Call siapIsi()
        Else
            If TextBox1.Text = "" Or tx_npm.Text = "" Or kd_matkul.Text = "" Or tx_kehadiran.Text = "" Or tx_kuis.Text = "" Or
            tx_tugas.Text = "" Or tx_uas.Text = "" Or tx_uts.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim insertData As String = "INSERT INTO tb_nilai VALUES ('" & TextBox1.Text & "',
                '" & tx_npm.Text & "', '" & kd_matkul.Text & "',
                '" & tx_kuis.Text & "', '" & tx_tugas.Text & "',
                '" & tx_kehadiran.Text & "', '" & tx_uts.Text & "', '" & tx_uas.Text & "', 
                '" & lb_nilai_akhir.Text & "', '" & lb_grade.Text & "')"
                Cmd = New SqlCommand(insertData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Insert Data")
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

    Private Sub tx_npm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tx_npm.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()
            Cmd = New SqlCommand("SELECT * FROM tb_mhs WHERE npm = '" & tx_npm.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                lb_nm_mhs.Text = Rd.Item("nama")
            Else
                lb_nm_mhs.Text = "Tidak Diketahui"
            End If
        End If
    End Sub

    Private Sub kd_matkul_KeyDown(sender As Object, e As KeyEventArgs) Handles kd_matkul.KeyDown

    End Sub

    Private Sub kd_matkul_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kd_matkul.KeyPress
        If e.KeyChar = Chr(13) Then
            Call koneksi()

            Cmd = New SqlCommand("SELECT * FROM tb_matkul WHERE kd_matkul = '" & kd_matkul.Text & "'", conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                lb_nm_matkul.Text = Rd.Item("nama_matkul")
            Else
                lb_nm_matkul.Text = "Tidak Diketahui"
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
            If TextBox1.Text = "" Or tx_npm.Text = "" Or kd_matkul.Text = "" Or tx_kehadiran.Text = "" Or tx_kuis.Text = "" Or
            tx_tugas.Text = "" Or tx_uas.Text = "" Or tx_uts.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim insertData As String = "UPDATE tb_nilai SET npm ='" & tx_npm.Text & "',
                kd_matkul= '" & kd_matkul.Text & "', kuis= '" & tx_kuis.Text & "',
                tugas= '" & tx_tugas.Text & "',kehadiran= '" & tx_kehadiran.Text & "',
                uts= '" & tx_uts.Text & "',uas= '" & tx_uas.Text & "',
                nilai_akhir= '" & lb_nilai_akhir.Text & "',grade= '" & lb_grade.Text & "'
                WHERE id= '" & TextBox1.Text & "'"

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
            If TextBox1.Text = "" Or tx_npm.Text = "" Or kd_matkul.Text = "" Or tx_kehadiran.Text = "" Or tx_kuis.Text = "" Or
            tx_tugas.Text = "" Or tx_uas.Text = "" Or tx_uts.Text = "" Then
                MsgBox("Semua Field Harus Disi Semua")
            Else
                Call koneksi()
                Dim insertData As String = "DELETE FROM tb_nilai WHERE
            id='" & TextBox1.Text & "'"
                Cmd = New SqlCommand(insertData, conn)
                Cmd.ExecuteNonQuery()
                MsgBox("Berhasil Hapus Data")
                Call kondisiAwal()
                Call kosongkanData()
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim rata As Integer
        Dim tugas, kuis, uts, uas, presensi As Double
        Dim grade As String
        tugas = Val(tx_tugas.Text * 20 / 100)
        kuis = Val(tx_kuis.Text * 15 / 100)
        presensi = Val(tx_kehadiran.Text * 20 / 100)
        uts = Val(tx_uts.Text * 20 / 100)
        uas = Val(tx_uas.Text * 25 / 100)
        rata = tugas + kuis + uts + uas + presensi
        lb_nilai_akhir.Text = rata

        If rata >= 80 Then
            grade = "A"

        ElseIf rata >= 65 And rata < 80 Then
            grade = "B"

        ElseIf rata >= 55 And rata < 65 Then
            grade = "C"

        ElseIf rata >= 40 And rata < 55 Then
            grade = "D"

        Else
            grade = "E"


        End If
        lb_grade.Text = grade
    End Sub

    Private Sub tx_npm_TextChanged(sender As Object, e As EventArgs) Handles tx_npm.TextChanged

    End Sub
End Class
