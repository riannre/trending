<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransaksi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTransaksi))
        Me.TxtNomor = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtKembali = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtDibayar = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnTutup = New System.Windows.Forms.Button()
        Me.BtnSimpan = New System.Windows.Forms.Button()
        Me.BtnBatal = New System.Windows.Forms.Button()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTglOrder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.BtnNoOrder = New System.Windows.Forms.Button()
        Me.TxtKode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTglRencana = New System.Windows.Forms.TextBox()
        Me.TxtJumlah = New System.Windows.Forms.TextBox()
        Me.TxtPewangi = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTglTransaksi = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtNomor
        '
        Me.TxtNomor.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNomor.Enabled = False
        Me.TxtNomor.Location = New System.Drawing.Point(100, 99)
        Me.TxtNomor.Name = "TxtNomor"
        Me.TxtNomor.Size = New System.Drawing.Size(105, 20)
        Me.TxtNomor.TabIndex = 1094
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(14, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 20)
        Me.Label10.TabIndex = 1093
        Me.Label10.Text = "No. Transaksi :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Controls.Add(Me.TxtKembali)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.TxtDibayar)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.BtnTutup)
        Me.GroupBox2.Controls.Add(Me.BtnSimpan)
        Me.GroupBox2.Controls.Add(Me.BtnBatal)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 423)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(851, 82)
        Me.GroupBox2.TabIndex = 1092
        Me.GroupBox2.TabStop = False
        '
        'TxtKembali
        '
        Me.TxtKembali.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKembali.Enabled = False
        Me.TxtKembali.Location = New System.Drawing.Point(704, 45)
        Me.TxtKembali.Name = "TxtKembali"
        Me.TxtKembali.Size = New System.Drawing.Size(132, 20)
        Me.TxtKembali.TabIndex = 1101
        Me.TxtKembali.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(643, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(50, 13)
        Me.Label15.TabIndex = 1100
        Me.Label15.Text = "Kembali :"
        '
        'TxtDibayar
        '
        Me.TxtDibayar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtDibayar.Location = New System.Drawing.Point(704, 19)
        Me.TxtDibayar.Name = "TxtDibayar"
        Me.TxtDibayar.Size = New System.Drawing.Size(132, 20)
        Me.TxtDibayar.TabIndex = 1099
        Me.TxtDibayar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(643, 22)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 1098
        Me.Label14.Text = "Dibayar :"
        '
        'BtnTutup
        '
        Me.BtnTutup.Image = CType(resources.GetObject("BtnTutup.Image"), System.Drawing.Image)
        Me.BtnTutup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnTutup.Location = New System.Drawing.Point(203, 30)
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
        Me.BtnSimpan.Location = New System.Drawing.Point(22, 30)
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
        Me.BtnBatal.Location = New System.Drawing.Point(111, 30)
        Me.BtnBatal.Name = "BtnBatal"
        Me.BtnBatal.Size = New System.Drawing.Size(86, 24)
        Me.BtnBatal.TabIndex = 169
        Me.BtnBatal.Text = "&Batal"
        Me.BtnBatal.UseVisualStyleBackColor = True
        '
        'DGV
        '
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(14, 210)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(854, 207)
        Me.DGV.TabIndex = 1090
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(687, 182)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 13)
        Me.Label9.TabIndex = 1087
        Me.Label9.Text = "Jumlah Pakaian :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(687, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 1086
        Me.Label8.Text = "Pewangi :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(437, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 20)
        Me.Label1.TabIndex = 1084
        Me.Label1.Text = "Tanggal Rencana Selesai"
        '
        'TxtTglOrder
        '
        Me.TxtTglOrder.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTglOrder.Enabled = False
        Me.TxtTglOrder.Location = New System.Drawing.Point(580, 154)
        Me.TxtTglOrder.Name = "TxtTglOrder"
        Me.TxtTglOrder.Size = New System.Drawing.Size(83, 20)
        Me.TxtTglOrder.TabIndex = 1083
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.Location = New System.Drawing.Point(650, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 20)
        Me.Label2.TabIndex = 1082
        Me.Label2.Text = "Tanggal"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(475, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(94, 59)
        Me.Label7.TabIndex = 1081
        Me.Label7.Text = "Rp"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblTotal
        '
        Me.LblTotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 39.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.ForeColor = System.Drawing.Color.Red
        Me.LblTotal.Location = New System.Drawing.Point(558, 14)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(310, 59)
        Me.LblTotal.TabIndex = 1080
        Me.LblTotal.Text = "0"
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1079
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(113, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 13)
        Me.Label5.TabIndex = 1078
        Me.Label5.Text = "Telp : (021) 98989898"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(113, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 13)
        Me.Label4.TabIndex = 1077
        Me.Label4.Text = "Jl. Perintis Kemerdekaan No 70 Jakarta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Crimson
        Me.Label3.Location = New System.Drawing.Point(113, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 1076
        Me.Label3.Text = "Smart Laundry"
        '
        'TxtNama
        '
        Me.TxtNama.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNama.Enabled = False
        Me.TxtNama.Location = New System.Drawing.Point(214, 180)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.ReadOnly = True
        Me.TxtNama.Size = New System.Drawing.Size(195, 20)
        Me.TxtNama.TabIndex = 1074
        '
        'BtnNoOrder
        '
        Me.BtnNoOrder.Image = CType(resources.GetObject("BtnNoOrder.Image"), System.Drawing.Image)
        Me.BtnNoOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNoOrder.Location = New System.Drawing.Point(292, 151)
        Me.BtnNoOrder.Name = "BtnNoOrder"
        Me.BtnNoOrder.Size = New System.Drawing.Size(97, 23)
        Me.BtnNoOrder.TabIndex = 1072
        Me.BtnNoOrder.Text = "Daftar Order"
        Me.BtnNoOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNoOrder.UseVisualStyleBackColor = True
        '
        'TxtKode
        '
        Me.TxtKode.BackColor = System.Drawing.SystemColors.Info
        Me.TxtKode.Enabled = False
        Me.TxtKode.Location = New System.Drawing.Point(100, 179)
        Me.TxtKode.Name = "TxtKode"
        Me.TxtKode.ReadOnly = True
        Me.TxtKode.Size = New System.Drawing.Size(105, 20)
        Me.TxtKode.TabIndex = 1075
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 180)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 1071
        Me.Label6.Text = "Pelanggan :"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Size = New System.Drawing.Size(881, 515)
        Me.ShapeContainer1.TabIndex = 1095
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 17
        Me.LineShape2.X2 = 862
        Me.LineShape2.Y1 = 128
        Me.LineShape2.Y2 = 128
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 16
        Me.LineShape1.X2 = 861
        Me.LineShape1.Y1 = 87
        Me.LineShape1.Y2 = 87
        '
        'TxtNoOrder
        '
        Me.TxtNoOrder.BackColor = System.Drawing.SystemColors.HighlightText
        Me.TxtNoOrder.Location = New System.Drawing.Point(100, 153)
        Me.TxtNoOrder.Name = "TxtNoOrder"
        Me.TxtNoOrder.Size = New System.Drawing.Size(105, 20)
        Me.TxtNoOrder.TabIndex = 1097
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 156)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 1096
        Me.Label11.Text = "Nomor Order :"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(438, 154)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(137, 20)
        Me.Label12.TabIndex = 1098
        Me.Label12.Text = "Tanggal Order"
        '
        'TxtTglRencana
        '
        Me.TxtTglRencana.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTglRencana.Enabled = False
        Me.TxtTglRencana.Location = New System.Drawing.Point(580, 179)
        Me.TxtTglRencana.Name = "TxtTglRencana"
        Me.TxtTglRencana.Size = New System.Drawing.Size(83, 20)
        Me.TxtTglRencana.TabIndex = 1099
        '
        'TxtJumlah
        '
        Me.TxtJumlah.BackColor = System.Drawing.SystemColors.Info
        Me.TxtJumlah.Enabled = False
        Me.TxtJumlah.Location = New System.Drawing.Point(783, 178)
        Me.TxtJumlah.Name = "TxtJumlah"
        Me.TxtJumlah.Size = New System.Drawing.Size(83, 20)
        Me.TxtJumlah.TabIndex = 1101
        '
        'TxtPewangi
        '
        Me.TxtPewangi.BackColor = System.Drawing.SystemColors.Info
        Me.TxtPewangi.Enabled = False
        Me.TxtPewangi.Location = New System.Drawing.Point(783, 153)
        Me.TxtPewangi.Name = "TxtPewangi"
        Me.TxtPewangi.Size = New System.Drawing.Size(83, 20)
        Me.TxtPewangi.TabIndex = 1100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.DarkRed
        Me.Label13.Location = New System.Drawing.Point(211, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 1102
        Me.Label13.Text = "[Enter] atau :"
        '
        'TxtTglTransaksi
        '
        Me.TxtTglTransaksi.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTglTransaksi.Enabled = False
        Me.TxtTglTransaksi.Location = New System.Drawing.Point(757, 96)
        Me.TxtTglTransaksi.Name = "TxtTglTransaksi"
        Me.TxtTglTransaksi.Size = New System.Drawing.Size(105, 20)
        Me.TxtTglTransaksi.TabIndex = 1104
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(653, 98)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(106, 20)
        Me.Label16.TabIndex = 1103
        Me.Label16.Text = "Tanggal Transaksi :"
        '
        'FrmTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(881, 515)
        Me.Controls.Add(Me.TxtTglTransaksi)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtJumlah)
        Me.Controls.Add(Me.TxtPewangi)
        Me.Controls.Add(Me.TxtTglRencana)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtNoOrder)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNomor)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTglOrder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LblTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.BtnNoOrder)
        Me.Controls.Add(Me.TxtKode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTransaksi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaksi ( Cucian Keluar )"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnTutup As System.Windows.Forms.Button
    Friend WithEvents BtnSimpan As System.Windows.Forms.Button
    Friend WithEvents BtnBatal As System.Windows.Forms.Button
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTglOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblTotal As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents BtnNoOrder As System.Windows.Forms.Button
    Friend WithEvents TxtKode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNoOrder As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTglRencana As System.Windows.Forms.TextBox
    Friend WithEvents TxtJumlah As System.Windows.Forms.TextBox
    Friend WithEvents TxtPewangi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtKembali As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtDibayar As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtTglTransaksi As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
