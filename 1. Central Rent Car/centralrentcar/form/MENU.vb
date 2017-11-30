Public Class MENU

    Private Sub BatalTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DATAKENDARAANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAKENDARAANToolStripMenuItem.Click
        DATA_KENDARAAN.Show()
    End Sub

    Private Sub DATAPELANGGANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATAPELANGGANToolStripMenuItem.Click
        PELANGGAN.Show()
    End Sub

    Private Sub DATASPAREPARTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATASPAREPARTToolStripMenuItem.Click
        PART_Mobil.Show()
    End Sub

    Private Sub TRANSAKSIRENTALToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRANSAKSIRENTALToolStripMenuItem.Click
        PEMINJAMAN.Show()
    End Sub
End Class