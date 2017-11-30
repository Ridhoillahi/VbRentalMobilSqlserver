Imports System.Data.OleDb
Module koneksi
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String
    Public simpan As String
    Public ubah As String
    Public hapus As String
    '  Public status As Boolean
    'Dim strConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & System.Environment.CurrentDirectory & "\Karyawan.mdb"
    Public Sub koneksi1()
        Try
            lokasidata = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\dbcentral\central.mdb"
            conn = New OleDbConnection(lokasidata)
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox("hubungi admin 085271787497")
            conn.Close()

        End Try
        
    End Sub


End Module
