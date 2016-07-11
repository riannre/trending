<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJasa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmJasa))
        Me.RbKode = New System.Windows.Forms.RadioButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSatuan = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BtnUbah = New System.Windows.Forms.Button()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.TxtHarga = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.RbNama = New System.Windows.Forms.RadioButton()
        Me.TxtCari = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RbKode
        '
        Me.RbKode.AutoSize = True
        Me.RbKode.Location = New System.Drawing.Point(154, 16)
        Me.RbKode.Name = "RbKode"
        Me.RbKode.Size = New System.Drawing.Size(87, 17)
        Me.RbKode.TabIndex = 135
        Me.RbKode.TabStop = True
        Me.RbKode.Text = "Kode Barang"
        Me.RbKode.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(13, 64)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(140, 20)
        Me.Label15.TabIndex = 160
        Me.Label15.Text = "* [Enter] untuk melanjutkan"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSatuan)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.TxtHarga)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtKode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(541, 152)
        Me.GroupBox1.TabIndex = 159
        Me.GroupBox1.TabStop = False
        '
        'TxtSatuan
        '
        Me.TxtSatuan.Location = New System.Drawing.Point(352, 19)
        Me.TxtSatuan.Name = "TxtSatuan"
        Me.TxtSatuan.Size = New System.Drawing.Size(154, 20)
        Me.TxtSatuan.TabIndex = 161
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox5.Controls.Add(Me.BtnUbah)
        Me.GroupBox5.Controls.Add(Me.BtnHapus)
        Me.GroupBox5.Controls.Add(Me.BtnBatal)
        Me.GroupBox5.Controls.Add(Me.BtnSimpan)
        Me.GroupBox5.Location = New System.Drawing.Point(4, 87)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(533, 55)
        Me.GroupBox5.TabIndex = 159
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "  Proses"
        '
        'BtnUbah
        '
        Me.BtnUbah.Image = CType(resources.GetObject("BtnUbah.Image"), System.Drawing.Image)
        Me.BtnUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUbah.Location = New System.Drawing.Point(193, 19)
        Me.BtnUbah.Name = "BtnUbah"
        Me.BtnUbah.Size = New System.Drawing.Size(86, 24)
        Me.BtnUbah.TabIndex = 150
        Me.BtnUbah.Text = "&Ubah"
        Me.BtnUbah.UseVisualStyleBackColor = True
        '
        'BtnHapus
        '
        Me.BtnHapus.Image = CType(resources.GetObject("BtnHapus.Image"), System.Drawing.Image)
        Me.BtnHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnHapus.Location = New System.Drawing.Point(283, 19)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(86, 24)
        Me.BtnHapus.TabIndex = 148
        Me.BtnHapus.Text = "&Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(103, 19)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(86, 24)
        Me.BtnBatal.TabIndex = 149
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(12, 19)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(86, 24)
        Me.BtnSimpan.TabIndex = 147
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'TxtHarga
        '
        Me.TxtHarga.Location = New System.Drawing.Point(352, 41)
        Me.TxtHarga.MaxLength = 6
        Me.TxtHarga.Name = "TxtHarga"
        Me.TxtHarga.Size = New System.Drawing.Size(154, 20)
        Me.TxtHarga.TabIndex = 149
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(307, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 147
        Me.Label11.Text = "Harga"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(307, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 22)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Satuan"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(11, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 22)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Nama :"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(138, 40)
        Me.TxtNama.MaxLength = 25
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(158, 20)
        Me.TxtNama.TabIndex = 139
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 30)
        Me.Label2.TabIndex = 138
        Me.Label2.Text = "Kode Jasa"
        '
        'TxtKode
        '
        Me.TxtKode.Location = New System.Drawing.Point(138, 19)
        Me.TxtKode.MaxLength = 25
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.Size = New System.Drawing.Size(158, 20)
        Me.TxtKode.TabIndex = 137
        '
        'RbNama
        '
        Me.RbNama.AutoSize = True
        Me.RbNama.Location = New System.Drawing.Point(56, 16)
        Me.RbNama.Name = "RbNama"
        Me.RbNama.Size = New System.Drawing.Size(90, 17)
        Me.RbNama.TabIndex = 134
        Me.RbNama.TabStop = True
        Me.RbNama.Text = "Nama Barang"
        Me.RbNama.UseVisualStyleBackColor = True
        '
        'TxtCari
        '
        Me.TxtCari.Location = New System.Drawing.Point(56, 43)
        Me.TxtCari.Name = "TxtCari"
        Me.TxtCari.Size = New System.Drawing.Size(187, 20)
        Me.TxtCari.TabIndex = 132
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 133
        Me.Label10.Text = "Cari :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RbKode)
        Me.GroupBox2.Controls.Add(Me.RbNama)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TxtCari)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 176)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(541, 81)
        Me.GroupBox2.TabIndex = 158
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "  Cara Data Berdasarkan : "
        '
        'DGV
        '
        Me.DGV.AllowUserToAddRows = False
        Me.DGV.AllowUserToDeleteRows = False
        Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 263)
        Me.DGV.Name = "DGV"
        Me.DGV.ReadOnly = True
        Me.DGV.Size = New System.Drawing.Size(541, 232)
        Me.DGV.TabIndex = 157
        '
        'FrmJasa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(566, 511)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmJasa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Data Jasa"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RbKode As System.Windows.Forms.RadioButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUbah As System.Windows.Forms.Button
    Friend WithEvents BtnHapus As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents TxtHarga As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents RbNama As System.Windows.Forms.RadioButton
    Friend WithEvents TxtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents TxtSatuan As System.Windows.Forms.TextBox
End Class
