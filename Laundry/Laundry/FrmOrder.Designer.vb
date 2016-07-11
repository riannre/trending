<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtAlamat = New System.Windows.Forms.TextBox()
        Me.BtnPelanggan = New System.Windows.Forms.Button()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.TxtTanggal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTTanggal = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmbPewangi = New System.Windows.Forms.ComboBox()
        Me.TxtJmlPakaian = New System.Windows.Forms.TextBox()
        Me.BtnJasa = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.TxtNomor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(111, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 1051
        Me.Label5.Text = "Telp : (021) 98989898"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(111, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 13)
        Me.Label4.TabIndex = 1050
        Me.Label4.Text = "Jl. Perintis Kemerdekaan No 70 Jakarta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(111, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 1049
        Me.Label3.Text = "Smart Laundry"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNama.Enabled = False
        Me.TxtNama.Location = New System.Drawing.Point(241, 130)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(158, 20)
        Me.TxtNama.TabIndex = 1046
        '
        'TxtAlamat
        '
        Me.TxtAlamat.BackColor = System.Drawing.SystemColors.Info
        Me.TxtAlamat.Enabled = False
        Me.TxtAlamat.Location = New System.Drawing.Point(155, 151)
        Me.TxtAlamat.Name = "TxtAlamat"
        Me.TxtAlamat.ReadOnly = True
        Me.TxtAlamat.Size = New System.Drawing.Size(244, 20)
        Me.TxtAlamat.TabIndex = 1045
        '
        'BtnPelanggan
        '
        Me.BtnPelanggan.Image = CType(resources.GetObject("BtnPelanggan.Image"), System.Drawing.Image)
        Me.BtnPelanggan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPelanggan.Location = New System.Drawing.Point(33, 147)
        Me.BtnPelanggan.Name = "BtnPelanggan"
        Me.BtnPelanggan.Size = New System.Drawing.Size(116, 23)
        Me.BtnPelanggan.TabIndex = 1044
        Me.BtnPelanggan.Text = "Daftar Pelanggan"
        Me.BtnPelanggan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPelanggan.UseVisualStyleBackColor = True
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKode.Enabled = False
        Me.TxtKode.Location = New System.Drawing.Point(155, 129)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(80, 20)
        Me.TxtKode.TabIndex = 1047
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(57, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 1043
        Me.Label6.Text = "Kode Pelanggan :"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1052
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(473, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 59)
        Me.Label7.TabIndex = 1054
        Me.Label7.Text = "Rp"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Red
        Me.LblTotal.Location = New System.Drawing.Point(556, 9)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(310, 59)
        Me.LblTotal.TabIndex = 1053
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TxtTanggal
        '
        Me.TxtTanggal.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTanggal.Enabled = False
        Me.TxtTanggal.Location = New System.Drawing.Point(555, 122)
        Me.TxtTanggal.Name = "TxtTanggal"
        Me.TxtTanggal.Size = New System.Drawing.Size(83, 20)
        Me.TxtTanggal.TabIndex = 1056
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(462, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1055
        Me.Label2.Text = "Tanggal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(415, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 1057
        Me.Label1.Text = "Tanggal Rencana Selesai"
        '
        'DTTanggal
        '
        Me.DTTanggal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTTanggal.Location = New System.Drawing.Point(555, 148)
        Me.DTTanggal.Name = "DTTanggal"
        Me.DTTanggal.Size = New System.Drawing.Size(83, 20)
        Me.DTTanggal.TabIndex = 1058
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(644, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1059
        Me.Label8.Text = "Pewangi :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(644, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 1060
        Me.Label9.Text = "Jumlah Pakaian :"
        '
        'CmbPewangi
        '
        Me.CmbPewangi.FormattingEnabled = True
        Me.CmbPewangi.Location = New System.Drawing.Point(738, 123)
        Me.CmbPewangi.Name = "CmbPewangi"
        Me.CmbPewangi.Size = New System.Drawing.Size(128, 21)
        Me.CmbPewangi.TabIndex = 1061
        '
        'TxtJmlPakaian
        '
        Me.TxtJmlPakaian.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtJmlPakaian.Location = New System.Drawing.Point(738, 145)
        Me.TxtJmlPakaian.Name = "TxtJmlPakaian"
        Me.TxtJmlPakaian.Size = New System.Drawing.Size(128, 20)
        Me.TxtJmlPakaian.TabIndex = 1062
        '
       
     
        'BtnJasa
        '
        Me.BtnJasa.Image = CType(resources.GetObject("BtnJasa.Image"), System.Drawing.Image)
        Me.BtnJasa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnJasa.Location = New System.Drawing.Point(15, 418)
        Me.BtnJasa.Name = "BtnJasa"
        Me.BtnJasa.Size = New System.Drawing.Size(123, 24)
        Me.BtnJasa.TabIndex = 1067
        Me.BtnJasa.Text = "Lihat Kode Jasa"
        Me.BtnJasa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnJasa.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(12, 205)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(854, 207)
        Me.DGV.TabIndex = 1064
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.BtnTutup)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 446)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(857, 62)
        Me.GroupBox2.TabIndex = 1068
        Me.GroupBox2.TabStop = False
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(759, 16)
        Me.BtnTutup.Name = "BtnTutup"
        Me.BtnTutup.Size = New System.Drawing.Size(86, 24)
        Me.BtnTutup.TabIndex = 168
        Me.BtnTutup.Text = "&Tutup"
        Me.BtnTutup.UseVisualStyleBackColor = True
        '
        'BtnSimpan
        '
        Me.BtnSimpan.Image = CType(resources.GetObject("BtnSimpan.Image"), System.Drawing.Image)
        Me.BtnSimpan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSimpan.Location = New System.Drawing.Point(578, 16)
        Me.BtnSimpan.Name = "BtnSimpan"
        Me.BtnSimpan.Size = New System.Drawing.Size(86, 24)
        Me.BtnSimpan.TabIndex = 167
        Me.BtnSimpan.Text = "&Simpan"
        Me.BtnSimpan.UseVisualStyleBackColor = True
        '
        'BtnBatal
        '
        Me.BtnBatal.Image = CType(resources.GetObject("BtnBatal.Image"), System.Drawing.Image)
        Me.BtnBatal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnBatal.Location = New System.Drawing.Point(667, 16)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(86, 24)
        Me.BtnBatal.TabIndex = 169
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'TxtNomor
        '
        Me.TxtNomor.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNomor.Enabled = False
        Me.TxtNomor.Location = New System.Drawing.Point(155, 94)
        Me.TxtNomor.Name = "TxtNomor"
        Me.TxtNomor.Size = New System.Drawing.Size(146, 20)
        Me.TxtNomor.TabIndex = 1070
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(74, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 20)
        Me.Label10.TabIndex = 1069
        Me.Label10.Text = "Nomor Order :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(461, 13)
        Me.Label11.TabIndex = 1052
        Me.Label11.Text = "- Masukkan Daftar Pelanggan, Tanggal Selesai, Pilih Pewangi, Serta masukkan Jumla" & _
    "h Pakaian"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(363, 13)
        Me.Label12.TabIndex = 1053
        Me.Label12.Text = "- Masukkan Kode Jasa di Kolom, Lalu [Enter], selanjutnya masukkan jumlah"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(7, 41)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(178, 13)
        Me.Label13.TabIndex = 1054
        Me.Label13.Text = "- Klik Simpan untuk menyimpan data"
        '
        'FrmOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(878, 520)
        Me.Controls.Add(Me.TxtNomor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnJasa)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.TxtJmlPakaian)
        Me.Controls.Add(Me.CmbPewangi)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DTTanggal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTanggal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.TxtAlamat)
        Me.Controls.Add(Me.BtnPelanggan)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Cucian ( Cucian Masuk )"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents TxtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents BtnPelanggan As System.Windows.Forms.Button
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents TxtTanggal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmbPewangi As System.Windows.Forms.ComboBox
    Friend WithEvents TxtJmlPakaian As System.Windows.Forms.TextBox
    Friend WithEvents BtnJasa As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents TxtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
