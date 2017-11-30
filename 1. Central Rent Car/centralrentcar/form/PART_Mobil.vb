Public Class PART_Mobil
    Private Sub Pengaturan()
        Select Case Status
            Case True
                SimpanTSB.Enabled = True
                '  UbahTSB.Enabled = False
                HapusTSB.Enabled = False
                BatalTSB.Enabled = False
                Call KosongkanIsiText(Me)
               
            Case False
                SimpanTSB.Enabled = False
                ' UbahTSB.Enabled = True
                HapusTSB.Enabled = True
                BatalTSB.Enabled = True
        End Select

        ' FrmBarang.Record()
    End Sub
    Private Sub Record()
        koneksi1()
        DA = New OleDb.OleDbDataAdapter("select * from dbo_part order by KODE_PART asc", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "dbo_part")
        DGBarang.DataSource = (DS.Tables("dbo_part"))


    End Sub



    Private Sub SimpanTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpanTSB.Click
        If TxtKdBarang.Text = "" Or
                TxtNmBarang.Text = "" Then
            MsgBox("data tidak boleh kosong")
        Else
            Try
                Dim simpan As String = "Insert Into dbo_part Values ('" & TxtKdBarang.Text & "','" & _
                        TxtNmBarang.Text & "')"
                CMD = New OleDb.OleDbCommand(simpan, conn)
                CMD.ExecuteNonQuery()
                MsgBox("data tersimpan")
                Call Pengaturan()

            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub

    Private Sub PART_Mobil_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Call Pengaturan()
        Call Record()
    End Sub

    Private Sub PART_Mobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        status = True
    End Sub

    Private Sub DGBarang_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBarang.CellContentClick

    End Sub

    Private Sub DGBarang_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGBarang.CellDoubleClick

    End Sub

    Private Sub HapusTSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HapusTSB.Click

    End Sub
End Class