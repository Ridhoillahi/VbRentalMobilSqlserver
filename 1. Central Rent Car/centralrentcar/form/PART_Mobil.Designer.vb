<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PART_Mobil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PART_Mobil))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNmBarang = New System.Windows.Forms.TextBox()
        Me.TxtKdBarang = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SimpanTSB = New System.Windows.Forms.ToolStripButton()
        Me.HapusTSB = New System.Windows.Forms.ToolStripButton()
        Me.BatalTSB = New System.Windows.Forms.ToolStripButton()
        Me.TutupTSB = New System.Windows.Forms.ToolStripButton()
        Me.DGBarang = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(51, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(243, 24)
        Me.Label9.TabIndex = 134
        Me.Label9.Text = "MASTER SPAREPART"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 410)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "NAMA PART :"
        '
        'TxtNmBarang
        '
        Me.TxtNmBarang.Location = New System.Drawing.Point(106, 407)
        Me.TxtNmBarang.Name = "TxtNmBarang"
        Me.TxtNmBarang.Size = New System.Drawing.Size(237, 20)
        Me.TxtNmBarang.TabIndex = 132
        '
        'TxtKdBarang
        '
        Me.TxtKdBarang.Location = New System.Drawing.Point(106, 384)
        Me.TxtKdBarang.Name = "TxtKdBarang"
        Me.TxtKdBarang.Size = New System.Drawing.Size(86, 20)
        Me.TxtKdBarang.TabIndex = 129
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 131
        Me.Label1.Text = "KODE PART :"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.DarkGray
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimpanTSB, Me.HapusTSB, Me.BatalTSB, Me.TutupTSB})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 435)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(361, 25)
        Me.ToolStrip1.TabIndex = 130
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SimpanTSB
        '
        Me.SimpanTSB.Image = CType(resources.GetObject("SimpanTSB.Image"), System.Drawing.Image)
        Me.SimpanTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SimpanTSB.Name = "SimpanTSB"
        Me.SimpanTSB.Size = New System.Drawing.Size(68, 22)
        Me.SimpanTSB.Text = "Simpan"
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
        'TutupTSB
        '
        Me.TutupTSB.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TutupTSB.Image = CType(resources.GetObject("TutupTSB.Image"), System.Drawing.Image)
        Me.TutupTSB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TutupTSB.Name = "TutupTSB"
        Me.TutupTSB.Size = New System.Drawing.Size(61, 22)
        Me.TutupTSB.Text = "Tutup"
        '
        'DGBarang
        '
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.Location = New System.Drawing.Point(12, 63)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.Size = New System.Drawing.Size(336, 315)
        Me.DGBarang.TabIndex = 128
        '
        'PART_Mobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 460)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNmBarang)
        Me.Controls.Add(Me.TxtKdBarang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DGBarang)
        Me.Name = "PART_Mobil"
        Me.Text = "PART_Mobil"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNmBarang As System.Windows.Forms.TextBox
    Friend WithEvents TxtKdBarang As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents SimpanTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents HapusTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents BatalTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents TutupTSB As System.Windows.Forms.ToolStripButton
    Friend WithEvents DGBarang As System.Windows.Forms.DataGridView
End Class
