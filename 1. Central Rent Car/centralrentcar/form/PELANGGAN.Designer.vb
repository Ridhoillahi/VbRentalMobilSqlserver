<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PELANGGAN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PELANGGAN))
        Me.TSTombol = New System.Windows.Forms.ToolStrip()
        Me.SimpanTSB = New System.Windows.Forms.ToolStripButton()
        Me.UbahTSB = New System.Windows.Forms.ToolStripButton()
        Me.HapusTSB = New System.Windows.Forms.ToolStripButton()
        Me.BatalTSB = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TutupTSB = New System.Windows.Forms.ToolStripButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtumur = New System.Windows.Forms.TextBox()
        Me.datettl = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CariTxt = New System.Windows.Forms.TextBox()
        Me.txtkodebuyer = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnpwp = New System.Windows.Forms.TextBox()
        Me.txtketerangan = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TlpPemasokTxt = New System.Windows.Forms.TextBox()
        Me.AlmPemasokTxt = New System.Windows.Forms.TextBox()
        Me.NmPemasokTxt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgpelanggan = New System.Windows.Forms.DataGridView()
        Me.TSTombol.SuspendLayout()
        CType(Me.dgpelanggan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TSTombol
        '
        Me.TSTombol.BackColor = System.Drawing.Color.DarkGray
        Me.TSTombol.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TSTombol.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSTombol.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpanTSB, Me.UbahTSB, Me.HapusTSB, Me.BatalTSB, Me.ToolStripSeparator1, Me.TutupTSB})
        Me.TSTombol.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.TSTombol.Location = New System.Drawing.Point(0, 438)
        Me.TSTombol.Name = "TSTombol"
        Me.TSTombol.Size = New System.Drawing.Size(823, 25)
        Me.TSTombol.TabIndex = 56
        '
        'SimpanTSB
        '
        Me.SimpanTSB.Image = CType(resources.GetObject("SimpanTSB.Image"), System.Drawing.Image)
        Me.SimpanTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SimpanTSB.Name = "SimpanTSB"
        Me.SimpanTSB.Size = New System.Drawing.Size(68, 22)
        Me.SimpanTSB.Text = "Simpan"
        '
        'UbahTSB
        '
        Me.UbahTSB.Image = CType(resources.GetObject("UbahTSB.Image"), System.Drawing.Image)
        Me.UbahTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UbahTSB.Name = "UbahTSB"
        Me.UbahTSB.Size = New System.Drawing.Size(56, 22)
        Me.UbahTSB.Text = "Ubah"
        '
        'HapusTSB
        '
        Me.HapusTSB.Image = CType(resources.GetObject("HapusTSB.Image"), System.Drawing.Image)
        Me.HapusTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HapusTSB.Name = "HapusTSB"
        Me.HapusTSB.Size = New System.Drawing.Size(61, 22)
        Me.HapusTSB.Text = "Hapus"
        '
        'BatalTSB
        '
        Me.BatalTSB.Image = CType(resources.GetObject("BatalTSB.Image"), System.Drawing.Image)
        Me.BatalTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BatalTSB.Name = "BatalTSB"
        Me.BatalTSB.Size = New System.Drawing.Size(56, 22)
        Me.BatalTSB.Text = "Batal"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TutupTSB
        '
        Me.TutupTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TutupTSB.Image = CType(resources.GetObject("TutupTSB.Image"), System.Drawing.Image)
        Me.TutupTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TutupTSB.Name = "TutupTSB"
        Me.TutupTSB.Size = New System.Drawing.Size(61, 22)
        Me.TutupTSB.Text = "Tutup"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(439, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 143
        Me.Label7.Text = "UMUR :"
        '
        'txtumur
        '
        Me.txtumur.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtumur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtumur.Location = New System.Drawing.Point(558, 86)
        Me.txtumur.Name = "txtumur"
        Me.txtumur.ReadOnly = True
        Me.txtumur.Size = New System.Drawing.Size(124, 20)
        Me.txtumur.TabIndex = 142
        '
        'datettl
        '
        Me.datettl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datettl.Location = New System.Drawing.Point(558, 57)
        Me.datettl.Name = "datettl"
        Me.datettl.Size = New System.Drawing.Size(165, 20)
        Me.datettl.TabIndex = 141
        Me.datettl.Value = New Date(1990, 1, 21, 20, 11, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(439, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 140
        Me.Label2.Text = "TANGGAL LAHIR:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(22, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 13)
        Me.Label10.TabIndex = 139
        Me.Label10.Text = "*Cari Data Berdasarkan Nama"
        '
        'CariTxt
        '
        Me.CariTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CariTxt.Location = New System.Drawing.Point(203, 185)
        Me.CariTxt.Name = "CariTxt"
        Me.CariTxt.Size = New System.Drawing.Size(170, 20)
        Me.CariTxt.TabIndex = 138
        '
        'txtkodebuyer
        '
        Me.txtkodebuyer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtkodebuyer.Location = New System.Drawing.Point(161, 34)
        Me.txtkodebuyer.Name = "txtkodebuyer"
        Me.txtkodebuyer.Size = New System.Drawing.Size(95, 20)
        Me.txtkodebuyer.TabIndex = 137
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(16, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 136
        Me.Label1.Text = "NO SIM / KTP :"
        '
        'txtnpwp
        '
        Me.txtnpwp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnpwp.Location = New System.Drawing.Point(161, 60)
        Me.txtnpwp.Name = "txtnpwp"
        Me.txtnpwp.Size = New System.Drawing.Size(212, 20)
        Me.txtnpwp.TabIndex = 135
        '
        'txtketerangan
        '
        Me.txtketerangan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtketerangan.Location = New System.Drawing.Point(161, 112)
        Me.txtketerangan.Multiline = True
        Me.txtketerangan.Name = "txtketerangan"
        Me.txtketerangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtketerangan.Size = New System.Drawing.Size(212, 67)
        Me.txtketerangan.TabIndex = 133
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(16, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 134
        Me.Label8.Text = "KETERANGAN :"
        '
        'TlpPemasokTxt
        '
        Me.TlpPemasokTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TlpPemasokTxt.Location = New System.Drawing.Point(161, 86)
        Me.TlpPemasokTxt.Name = "TlpPemasokTxt"
        Me.TlpPemasokTxt.Size = New System.Drawing.Size(95, 20)
        Me.TlpPemasokTxt.TabIndex = 128
        '
        'AlmPemasokTxt
        '
        Me.AlmPemasokTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlmPemasokTxt.Location = New System.Drawing.Point(558, 112)
        Me.AlmPemasokTxt.MaxLength = 50
        Me.AlmPemasokTxt.Multiline = True
        Me.AlmPemasokTxt.Name = "AlmPemasokTxt"
        Me.AlmPemasokTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.AlmPemasokTxt.Size = New System.Drawing.Size(241, 84)
        Me.AlmPemasokTxt.TabIndex = 127
        '
        'NmPemasokTxt
        '
        Me.NmPemasokTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NmPemasokTxt.Location = New System.Drawing.Point(558, 26)
        Me.NmPemasokTxt.Name = "NmPemasokTxt"
        Me.NmPemasokTxt.Size = New System.Drawing.Size(241, 20)
        Me.NmPemasokTxt.TabIndex = 126
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(16, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 132
        Me.Label6.Text = "TELEPHONE :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(439, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 131
        Me.Label5.Text = "ALAMAT :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(439, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "NAMA :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(16, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 13)
        Me.Label3.TabIndex = 129
        Me.Label3.Text = "KODE PELANGGAN :"
        '
        'dgpelanggan
        '
        Me.dgpelanggan.AllowUserToAddRows = False
        Me.dgpelanggan.AllowUserToDeleteRows = False
        Me.dgpelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpelanggan.GridColor = System.Drawing.SystemColors.ControlLight
        Me.dgpelanggan.Location = New System.Drawing.Point(25, 211)
        Me.dgpelanggan.Name = "dgpelanggan"
        Me.dgpelanggan.ReadOnly = True
        Me.dgpelanggan.Size = New System.Drawing.Size(774, 208)
        Me.dgpelanggan.TabIndex = 144
        '
        'PELANGGAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 463)
        Me.Controls.Add(Me.dgpelanggan)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtumur)
        Me.Controls.Add(Me.datettl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CariTxt)
        Me.Controls.Add(Me.txtkodebuyer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtnpwp)
        Me.Controls.Add(Me.txtketerangan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TlpPemasokTxt)
        Me.Controls.Add(Me.AlmPemasokTxt)
        Me.Controls.Add(Me.NmPemasokTxt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TSTombol)
        Me.Name = "PELANGGAN"
        Me.Text = "DATA PELANGGAN"
        Me.TSTombol.ResumeLayout(False)
        Me.TSTombol.PerformLayout()
        CType(Me.dgpelanggan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSTombol As System.Windows.Forms.ToolStrip
    Friend WithEvents SimpanTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents UbahTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents HapusTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents BatalTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TutupTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtumur As System.Windows.Forms.TextBox
    Friend WithEvents datettl As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CariTxt As System.Windows.Forms.TextBox
    Friend WithEvents txtkodebuyer As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtnpwp As System.Windows.Forms.TextBox
    Friend WithEvents txtketerangan As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TlpPemasokTxt As System.Windows.Forms.TextBox
    Friend WithEvents AlmPemasokTxt As System.Windows.Forms.TextBox
    Friend WithEvents NmPemasokTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgpelanggan As System.Windows.Forms.DataGridView

End Class
