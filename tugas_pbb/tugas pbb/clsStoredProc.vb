Imports System.Data.SqlClient
Public Class clsStoredProc
    Dim strProc As String = "data source = DESKTOP-QV18P4F\SQLEXPRESS;initial catalog = dbsPBB;integrated security=True;UID= my user;PWD=123"
    Dim db As New SqlConnection(), cm As New SqlCommand
    Dim aPROC As String
    Public Sub STORED_KELAS(ByVal oJENIS As String)
        bukakoneksi()
        If oJENIS = "S" Then
            aPROC = "IF NOT EXISTs (SELECT * FROM SysObjects WHERE Name='klsTAMPIL') BEGIN "
            aPROC = aPROC & "EXEC('CREATE PROC klsTAMPIL AS SELECT * FROM tblKelas ORDER BY kdkelas')END"
        ElseIf oJENIS = "U" Then
            aPROC = "IF NOT EXISTs (SELECT * FROM SysObjects WHERE Name='klsUBAH') BEGIN "
            aPROC = aPROC & "EXEC('CREATE PROC klsUBAH @kdkelas char(3),@keterangan varchar(50),@nilainjop int,@nilaitkp int,@nilaitarif smallint "
            aPROC = aPROC & "AS UPDATE tblkelas SET keterangan= @keterangan, nilainjop= @nilainjop, nilaitkp=@nilaitkp, nilaitarif= @nilaitarif "
            aPROC = aPROC & "WHERE kdKelas=@kdkelas') END"
        ElseIf oJENIS = "D" Then
            aPROC = "IF NOT EXISTs (SELECT * FROM SysObjects WHERE Name='klsHAPUS') BEGIN "
            aPROC = aPROC & "EXEC('CREATE PROC klsHAPUS @kdkelas char(3) AS DELETE TBLKELAS WHERE kdKelas=@kdkelas') END"
        ElseIf oJENIS = "I" Then
            aPROC = "IF NOT EXISTs (SELECT * FROM SysObjects WHERE Name='klsTAMBAH') BEGIN "
            aPROC = aPROC & "EXEC('CREATE PROC klsTAMBAH @kdkelas char(3),@keterangan varchar(50),@nilainjop int,@nilaitkp int,	@nilaitarif smallint "
            aPROC = aPROC & "AS INSERT INTO tblkelas VALUES(@kdkelas,@keterangan, @nilainjop, @nilaitkp, @nilaitarif) ') END"
        ElseIf oJENIS = "C" Then
            aPROC = "IF NOT EXISTs (SELECT * FROM SysObjects WHERE Name='klsCARI') BEGIN "
            aPROC = aPROC & "EXEC('CREATE PROC klsCARI @kdkelas char(3) AS SELECT * FROM tblkelas WHERE kdKelas=@kdkelas') END"
        End If
        cm.CommandText = aPROC
        comSQL = New SqlCommand(sql, conn)
        tutupkoneksi()
    End Sub
End Class