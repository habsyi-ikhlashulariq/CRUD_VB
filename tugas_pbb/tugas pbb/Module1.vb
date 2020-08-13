Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Module Module1
    Public comSQL As New SqlClient.SqlCommand
    Public sql As String
    Public conn As New SqlConnection
    Public str As String = "data source = DESKTOP-QV18P4F\SQLEXPRESS;initial catalog = dbsPBB;integrated security=True;UID= my user;PWD=123"
    Public Sub bukakoneksi()
        If conn.State = ConnectionState.Closed Then
            conn.ConnectionString = str

            Try
                conn.Open()
                MsgBox("koneksi berhasil")

            Catch ex As Exception

                MsgBox("koneksi gagal: " & ex.ToString)

            End Try
        End If

    End Sub
    Public Sub tutupkoneksi()
        If conn.State = ConnectionState.Open Then
            Try
                conn.Close()
            Catch ex As Exception
                MsgBox("gagal menutup koneksi: " & ex.ToString)
            End Try
        End If
    End Sub
End Module
