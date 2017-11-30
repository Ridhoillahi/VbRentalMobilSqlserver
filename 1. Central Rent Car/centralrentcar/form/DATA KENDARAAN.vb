Public Class DATA_KENDARAAN

    Private Sub Record()
        koneksi1()
        DA = New OleDb.OleDbDataAdapter("select * from dbo_mobil", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dbo_mobil")
        dgmobil.DataSource = (DS.Tables("dbo_mobil"))
    End Sub
    Private Sub Pengaturan()
        Select Case Status
            Case True
                SimpanTSB.Enabled = True
                UbahTSB.Enabled = False
                HapusTSB.Enabled = False
                BatalTSB.Enabled = False
                Call KosongkanIsiText(Me)

                'Kode pemasok otomatis
                '     txtkodebuyer.Text = Kode.Generate("pelanggan", _
                '          "KODE_PELANGGAN")
            Case False
                SimpanTSB.Enabled = False
                UbahTSB.Enabled = True
                HapusTSB.Enabled = True
                BatalTSB.Enabled = True
        End Select

    End Sub

    Private Sub DATA_KENDARAAN_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Pengaturan()
        Call record()
    End Sub

    Private Sub DATA_KENDARAAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status = True
    End Sub

    Private Sub SimpanTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanTSB.Click
        If txtplat.Text = "" _
        Or txtnama.Text = "" _
        Or txtalamat.Text = "" _
        Or txtmerk.Text = "" _
        Or txttype.Text = "" _
        Or txtjenis.Text = "" _
        Or txtwarna.Text = "" _
        Or txtbahanbakar.Text = "" _
        Or txttahun.Text = "" _
        Or txtnorangka.Text = "" _
        Or txtnomesin.Text = "" _
        Or txtnobpkb.Text = "" Then
            MsgBox("data tidak boleh kosong")
        Else
            Call koneksi1()
            Dim simpan As String = "Insert Into dbo_mobil Values ('" & txtplat.Text & "','" & _
                    txtnama.Text & "','" & txtalamat.Text & "','" & txtmerk.Text & "','" & _
                    txttype.Text & "','" & txtjenis.Text & "','" & txtwarna.Text & "','" & txtbahanbakar.Text & "', '" & _
                    txttahun.Text & "','" & txtnorangka.Text & "','" & txtnomesin.Text & "','" & txtnobpkb.Text & "')"
            CMD = New OleDb.OleDbCommand(simpan, conn)
            CMD.ExecuteNonQuery()
            MsgBox("data tersimpan")
            Call Pengaturan()

        End If
    End Sub

    Private Sub dgmobil_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgmobil.CellContentClick

    End Sub

    Private Sub dgmobil_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgmobil.CellDoubleClick
        Try
            With dgmobil
                txtplat.Text = .SelectedCells(0).Value
                txtnama.Text = .SelectedCells(1).Value
                txtalamat.Text = .SelectedCells(2).Value
                txtmerk.Text = .SelectedCells(3).Value
                txttype.Text = .SelectedCells(4).Value
                txtjenis.Text = .SelectedCells(5).Value
                txtwarna.Text = .SelectedCells(6).Value
                txtbahanbakar.Text = .SelectedCells(7).Value
                txttahun.Text = .SelectedCells(8).Value
                txtnorangka.Text = .SelectedCells(9).Value
                txtnomesin.Text = .SelectedCells(10).Value
                txtnobpkb.Text = .SelectedCells(11).Value
            End With
            Call Pengaturan()
            status = False
            'Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub UbahTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UbahTSB.Click
        If txtplat.Text = "" _
        Or txtnama.Text = "" _
        Or txtalamat.Text = "" _
        Or txtmerk.Text = "" _
        Or txttype.Text = "" _
        Or txtjenis.Text = "" _
        Or txtwarna.Text = "" _
        Or txtbahanbakar.Text = "" _
        Or txttahun.Text = "" _
        Or txtnorangka.Text = "" _
        Or txtnomesin.Text = "" _
        Or txtnobpkb.Text = "" Then
            MsgBox("data tidak boleh kosong")
        Else
            Dim update As String = "Update dbo_mobil Set NAMA = '" & _
                    txtnama.Text & "',ALAMAT = '" & _
                    txtalamat.Text & "',MERK = '" & _
                    txtmerk.Text & "',TYPE = '" & _
                    txttype.Text & "',JENIS = '" & _
                    txtjenis.Text & "',WARNA = '" & _
                    txtwarna.Text & "',BAHAN_BAKAR = '" & _
                    txtbahanbakar.Text & "',TAHUN = '" & _
                    txttahun.Text & "',NO_RANGKA = '" & _
                    txtnorangka.Text & "',NO_MESIN = '" & _
                    txtnomesin.Text & "',NO_BPKB = '" & _
                    txtnobpkb.Text & "' where BM = '" & _
                    txtplat.Text & "'"
            CMD = New OleDb.OleDbCommand(update, conn)
            CMD.ExecuteNonQuery()
            MessageBox.Show("Data telah diubah..!!", _
                            "Perubahan Data Sukses", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)
            status = True
            Call Pengaturan()

        End If

    End Sub

    Private Sub BatalTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BatalTSB.Click
        status = True
        Call Pengaturan()
    End Sub

    Private Sub HapusTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusTSB.Click
        Dim delete As String = "Delete From dbo_mobil Where BM = '" & _
                txtplat.Text & "'"
        CMD = New OleDb.OleDbCommand(delete, conn)
        CMD.ExecuteNonQuery()

        MessageBox.Show("Data telah dihapus..!!", _
                        "Penghapusan Sukses", _
                        MessageBoxButtons.OK, _
                        MessageBoxIcon.Information)

        'Memberi nilai variabel Status = True
        status = True

        'Panggil prosedur dengan nama Pengaturan
        Call Pengaturan()
    End Sub
End Class