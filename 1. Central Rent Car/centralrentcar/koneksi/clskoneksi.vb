Imports System.Data
Imports System.Data.OleDb
Public Class clskoneksi
    Protected sql As String
    Protected Cn As OleDb.OleDbConnection
    Protected Cmd As OleDb.OleDbCommand
    Protected Da As OleDb.OleDbDataAdapter
    Protected Ds As DataSet
    Protected Dt As DataTable

    Public Function OpenConn() As Boolean
        Try
            lokasidata = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\dbcentral\central.mdb"
            Cn = New OleDbConnection(lokasidata)
            If Cn.State = ConnectionState.Closed Then
                Cn.Open()
            End If
        Catch ex As Exception
            FileClose()
        End Try

    End Function

    Public Sub CloseConn()
        If Not IsNothing(Cn) Then
            Cn.Close()
            Cn = Nothing
        End If
    End Sub

    Public Function ExecuteQuery(ByVal Query As String) As DataTable
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal1..!!", MsgBoxStyle.Critical, "Access Failed")
            Return Nothing
            Exit Function
        End If

        Cmd = New OleDb.OleDbCommand(Query, Cn)
        Da = New OleDb.OleDbDataAdapter
        Da.SelectCommand = Cmd

        Ds = New Data.DataSet
        Da.Fill(Ds)

        Dt = Ds.Tables(0)

        Return Dt

        Dt = Nothing
        Ds = Nothing
        Da = Nothing
        Cmd = Nothing

        CloseConn()

    End Function
    Public Sub ExecuteNonQuery(ByVal Query As String)
        If Not OpenConn() Then
            MsgBox("Koneksi Gagal..!!", MsgBoxStyle.Critical, "Access Failed..!!")
            Exit Sub
        End If
        Cmd = New OleDb.OleDbCommand
        Cmd.Connection = Cn
        Cmd.CommandType = CommandType.Text
        Cmd.CommandText = Query
        Cmd.ExecuteNonQuery()
        Cmd = Nothing
        CloseConn()
    End Sub

End Class
