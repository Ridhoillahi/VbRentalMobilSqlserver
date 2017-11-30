Imports System.Data.OleDb
Public Class PEMINJAMAN
    Private Sub txtbpkb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbpkb.TextChanged

    End Sub

    Private Sub PEMINJAMAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Status = True
        txtkodetransaksi.Text = Kode.Generate("dbo_transaksi", _
                     "KODE_TRANSAKSI")
    End Sub
End Class