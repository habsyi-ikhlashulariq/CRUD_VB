Imports System.Data.SqlClient
Module Module1

    Public conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Cmd As SqlCommand
    Public Rd As SqlDataReader
    Public Ds As DataSet

    Dim myDB As String

    Sub koneksi()
        myDB = "data source=User-PC;initial catalog=dbsNilai;integrated security=true"
        conn = New SqlConnection(myDB)

        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

End Module
