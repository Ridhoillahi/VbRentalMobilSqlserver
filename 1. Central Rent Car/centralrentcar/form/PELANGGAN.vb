Public Class PELANGGAN
    Public databaru As Boolean
    Private Sub Pengaturan()
        Select Case Status
            Case True
                SimpanTSB.Enabled = True
                UbahTSB.Enabled = False
                HapusTSB.Enabled = False
                BatalTSB.Enabled = False
                Call KosongkanIsiText(Me)
            Case False
                SimpanTSB.Enabled = False
                UbahTSB.Enabled = True
                HapusTSB.Enabled = True
                BatalTSB.Enabled = True
        End Select
    End Sub
    Private Sub Record()
        koneksi1()
        DA = New OleDb.OleDbDataAdapter("select * from dbo_pelanggan", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dbo_pelanggan")
        dgpelanggan.DataSource = (DS.Tables("dbo_pelanggan"))
    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Pengaturan()
        Call Record()
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status = True
    End Sub


    Private Sub NmPemasokTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NmPemasokTxt.TextChanged

    End Sub

    Private Sub SimpanTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanTSB.Click
        If txtkodebuyer.Text = "" _
         Or NmPemasokTxt.Text = "" _
         Or txtnpwp.Text = "" _
        Or AlmPemasokTxt.Text = "" _
        Or TlpPemasokTxt.Text = "" Then
            MsgBox("data tidak boleh kosong")

        Else
            Call koneksi1()
            Dim simpan As String = "Insert Into dbo_pelanggan Values ('" & txtkodebuyer.Text & "','" & _
                    NmPemasokTxt.Text & "','" & _
                    AlmPemasokTxt.Text & "','" & _
                    txtnpwp.Text & "','" & _
                    TlpPemasokTxt.Text & "','" & _
                    txtketerangan.Text & "','" & _
                    Format(datettl.Value, "MM/dd/yyyy") & "','" & _
                    txtumur.Text & "')"
            CMD = New OleDb.OleDbCommand(simpan, conn)
            CMD.ExecuteNonQuery()
            MsgBox("data tersimpan")
            Call Pengaturan()
        End If
    End Sub
    Private Sub dgpelanggan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgpelanggan.DoubleClick
        Try
            With dgpelanggan
                txtkodebuyer.Text = .SelectedCells(0).Value
                NmPemasokTxt.Text = .SelectedCells(1).Value
                AlmPemasokTxt.Text = .SelectedCells(2).Value
                txtnpwp.Text = .SelectedCells(3).Value
                TlpPemasokTxt.Text = .SelectedCells(4).Value
                txtketerangan.Text = .SelectedCells(5).Value

            End With
            Call Pengaturan()
            status = False
            'Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub


    Private Sub UbahTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahTSB.Click
        Call koneksi1()
        Dim edit As String = "Update dbo_pelanggan Set NAMA = '" & _
                NmPemasokTxt.Text & "', ALAMAT = '" & _
                AlmPemasokTxt.Text & "',NO_SIM = '" & _
                txtnpwp.Text & "',TLPN = '" & _
                TlpPemasokTxt.Text & "',KETERANGAN = '" & _
                txtketerangan.Text & "',TTL = '" & _
                Format(datettl.Value, "MM/dd/yyyy") & "',UMUR = '" & _
                txtumur.Text & "' where KODE_PELANGGAN = '" & _
                txtkodebuyer.Text & "'"
        CMD = New OleDb.OleDbCommand(edit, conn)
        CMD.ExecuteNonQuery()
        MsgBox("Data Berhasil diUpdate")
        status = True
        Call Pengaturan()
    End Sub

    Private Sub HapusTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusTSB.Click
        Call koneksi1()
        Try
            Dim hapus As String = "Delete From dbo_pelanggan Where KODE_PELANGGAN = '" & _
                txtkodebuyer.Text & "'"

            CMD = New OleDb.OleDbCommand(hapus, conn)
            CMD.ExecuteNonQuery()

            MessageBox.Show("Data telah dihapus..!!", _
                            "Penghapusan Sukses", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)

            'Memberi nilai variabel Status = True
            status = True

            'Panggil prosedur dengan nama Pengaturan
            Call Pengaturan()

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub

    Private Sub BatalTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalTSB.Click
        status = True
        Call Pengaturan()
    End Sub

    Private Sub TutupTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TutupTSB.Click
        Me.Close()
    End Sub
End Class
