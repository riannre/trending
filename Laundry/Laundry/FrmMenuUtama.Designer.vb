<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenuUtama))
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuGantiPassword = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuMaster = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuPewangi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuJasa = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuPetugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuTransaksi = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCucianMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCucianKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuLaporan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLapPelanggan = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLapJasa = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLapCucianMasuk = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLapCucianKeluar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnGantiPass = New System.Windows.Forms.Button()
        Me.BtnJasa = New System.Windows.Forms.Button()
        Me.BtnPewangi = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Panel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BtnPelanggan = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnLogOut = New System.Windows.Forms.Button()
        Me.BtnKeluar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnPetugas = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BtnCucianKeluar = New System.Windows.Forms.Button()
        Me.BtnCucianMasuk = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(179, 6)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuFile, Me.MnuMaster, Me.MnuTransaksi, Me.MnuLaporan, Me.MnuExit})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(947, 24)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MnuFile
        '
        Me.MnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuGantiPassword, Me.MnuLogOut, Me.MnuKeluar})
        Me.MnuFile.Image = CType(resources.GetObject("MnuFile.Image"), System.Drawing.Image)
        Me.MnuFile.Name = "MnuFile"
        Me.MnuFile.Size = New System.Drawing.Size(53, 20)
        Me.MnuFile.Text = "File"
        '
        'MnuGantiPassword
        '
        Me.MnuGantiPassword.Image = CType(resources.GetObject("MnuGantiPassword.Image"), System.Drawing.Image)
        Me.MnuGantiPassword.Name = "MnuGantiPassword"
        Me.MnuGantiPassword.Size = New System.Drawing.Size(155, 22)
        Me.MnuGantiPassword.Text = "Ganti Password"
        '
        'MnuLogOut
        '
        Me.MnuLogOut.Image = CType(resources.GetObject("MnuLogOut.Image"), System.Drawing.Image)
        Me.MnuLogOut.Name = "MnuLogOut"
        Me.MnuLogOut.Size = New System.Drawing.Size(155, 22)
        Me.MnuLogOut.Text = "Log Out"
        '
        'MnuKeluar
        '
        Me.MnuKeluar.Image = CType(resources.GetObject("MnuKeluar.Image"), System.Drawing.Image)
        Me.MnuKeluar.Name = "MnuKeluar"
        Me.MnuKeluar.Size = New System.Drawing.Size(155, 22)
        Me.MnuKeluar.Text = "Keluar"
        '
        'MnuMaster
        '
        Me.MnuMaster.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuPelanggan, Me.ToolStripMenuItem1, Me.MnuPewangi, Me.MnuJasa, Me.ToolStripMenuItem2, Me.MnuPetugas})
        Me.MnuMaster.Image = CType(resources.GetObject("MnuMaster.Image"), System.Drawing.Image)
        Me.MnuMaster.Name = "MnuMaster"
        Me.MnuMaster.Size = New System.Drawing.Size(71, 20)
        Me.MnuMaster.Text = "Master"
        '
        'MnuPelanggan
        '
        Me.MnuPelanggan.Image = CType(resources.GetObject("MnuPelanggan.Image"), System.Drawing.Image)
        Me.MnuPelanggan.Name = "MnuPelanggan"
        Me.MnuPelanggan.Size = New System.Drawing.Size(130, 22)
        Me.MnuPelanggan.Text = "Pelanggan"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(127, 6)
        '
        'MnuPewangi
        '
        Me.MnuPewangi.Image = CType(resources.GetObject("MnuPewangi.Image"), System.Drawing.Image)
        Me.MnuPewangi.Name = "MnuPewangi"
        Me.MnuPewangi.Size = New System.Drawing.Size(130, 22)
        Me.MnuPewangi.Text = "Pewangi"
        '
        'MnuJasa
        '
        Me.MnuJasa.Image = CType(resources.GetObject("MnuJasa.Image"), System.Drawing.Image)
        Me.MnuJasa.Name = "MnuJasa"
        Me.MnuJasa.Size = New System.Drawing.Size(130, 22)
        Me.MnuJasa.Text = "Jasa"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(127, 6)
        '
        'MnuPetugas
        '
        Me.MnuPetugas.Image = CType(resources.GetObject("MnuPetugas.Image"), System.Drawing.Image)
        Me.MnuPetugas.Name = "MnuPetugas"
        Me.MnuPetugas.Size = New System.Drawing.Size(130, 22)
        Me.MnuPetugas.Text = "Petugas"
        '
        'MnuTransaksi
        '
        Me.MnuTransaksi.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCucianMasuk, Me.MnuCucianKeluar, Me.ToolStripMenuItem4})
        Me.MnuTransaksi.Image = CType(resources.GetObject("MnuTransaksi.Image"), System.Drawing.Image)
        Me.MnuTransaksi.Name = "MnuTransaksi"
        Me.MnuTransaksi.Size = New System.Drawing.Size(84, 20)
        Me.MnuTransaksi.Text = "Transaksi"
        '
        'MnuCucianMasuk
        '
        Me.MnuCucianMasuk.Image = CType(resources.GetObject("MnuCucianMasuk.Image"), System.Drawing.Image)
        Me.MnuCucianMasuk.Name = "MnuCucianMasuk"
        Me.MnuCucianMasuk.Size = New System.Drawing.Size(182, 22)
        Me.MnuCucianMasuk.Text = "Order Cucian Masuk"
        '
        'MnuCucianKeluar
        '
        Me.MnuCucianKeluar.Image = CType(resources.GetObject("MnuCucianKeluar.Image"), System.Drawing.Image)
        Me.MnuCucianKeluar.Name = "MnuCucianKeluar"
        Me.MnuCucianKeluar.Size = New System.Drawing.Size(182, 22)
        Me.MnuCucianKeluar.Text = "Cucian Keluar"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(179, 6)
        '
        'MnuLaporan
        '
        Me.MnuLaporan.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuLapPelanggan, Me.MnuLapJasa, Me.ToolStripMenuItem3, Me.MnuLapCucianMasuk, Me.MnuLapCucianKeluar, Me.ToolStripMenuItem5})
        Me.MnuLaporan.Image = CType(resources.GetObject("MnuLaporan.Image"), System.Drawing.Image)
        Me.MnuLaporan.Name = "MnuLaporan"
        Me.MnuLaporan.Size = New System.Drawing.Size(78, 20)
        Me.MnuLaporan.Text = "Laporan"
        '
        'MnuLapPelanggan
        '
        Me.MnuLapPelanggan.Image = CType(resources.GetObject("MnuLapPelanggan.Image"), System.Drawing.Image)
        Me.MnuLapPelanggan.Name = "MnuLapPelanggan"
        Me.MnuLapPelanggan.Size = New System.Drawing.Size(182, 22)
        Me.MnuLapPelanggan.Text = "Data Pelanggan"
        '
        'MnuLapJasa
        '
        Me.MnuLapJasa.Image = CType(resources.GetObject("MnuLapJasa.Image"), System.Drawing.Image)
        Me.MnuLapJasa.Name = "MnuLapJasa"
        Me.MnuLapJasa.Size = New System.Drawing.Size(182, 22)
        Me.MnuLapJasa.Text = "Data Jasa"
        '
        'MnuLapCucianMasuk
        '
        Me.MnuLapCucianMasuk.Image = CType(resources.GetObject("MnuLapCucianMasuk.Image"), System.Drawing.Image)
        Me.MnuLapCucianMasuk.Name = "MnuLapCucianMasuk"
        Me.MnuLapCucianMasuk.Size = New System.Drawing.Size(182, 22)
        Me.MnuLapCucianMasuk.Text = "Order Cucian Masuk"
        '
        'MnuLapCucianKeluar
        '
        Me.MnuLapCucianKeluar.Image = CType(resources.GetObject("MnuLapCucianKeluar.Image"), System.Drawing.Image)
        Me.MnuLapCucianKeluar.Name = "MnuLapCucianKeluar"
        Me.MnuLapCucianKeluar.Size = New System.Drawing.Size(182, 22)
        Me.MnuLapCucianKeluar.Text = "Cucian Keluar"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(179, 6)
        '
        'MnuExit
        '
        Me.MnuExit.Image = CType(resources.GetObject("MnuExit.Image"), System.Drawing.Image)
        Me.MnuExit.Name = "MnuExit"
        Me.MnuExit.Size = New System.Drawing.Size(68, 20)
        Me.MnuExit.Text = "Keluar"
        '
        'BtnGantiPass
        '
        Me.BtnGantiPass.AutoSize = True
        Me.BtnGantiPass.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnGantiPass.FlatAppearance.BorderSize = 0
        Me.BtnGantiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGantiPass.Image = CType(resources.GetObject("BtnGantiPass.Image"), System.Drawing.Image)
        Me.BtnGantiPass.Location = New System.Drawing.Point(3, 16)
        Me.BtnGantiPass.Name = "BtnGantiPass"
        Me.BtnGantiPass.Size = New System.Drawing.Size(91, 63)
        Me.BtnGantiPass.TabIndex = 4
        Me.BtnGantiPass.Text = "Ganti Password"
        Me.BtnGantiPass.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGantiPass.UseVisualStyleBackColor = True
        '
        'BtnJasa
        '
        Me.BtnJasa.AutoSize = True
        Me.BtnJasa.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnJasa.FlatAppearance.BorderSize = 0
        Me.BtnJasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnJasa.Image = CType(resources.GetObject("BtnJasa.Image"), System.Drawing.Image)
        Me.BtnJasa.Location = New System.Drawing.Point(227, 16)
        Me.BtnJasa.Name = "BtnJasa"
        Me.BtnJasa.Size = New System.Drawing.Size(68, 61)
        Me.BtnJasa.TabIndex = 7
        Me.BtnJasa.Text = "Jasa"
        Me.BtnJasa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnJasa.UseVisualStyleBackColor = True
        '
        'BtnPewangi
        '
        Me.BtnPewangi.AutoSize = True
        Me.BtnPewangi.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPewangi.FlatAppearance.BorderSize = 0
        Me.BtnPewangi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPewangi.Image = CType(resources.GetObject("BtnPewangi.Image"), System.Drawing.Image)
        Me.BtnPewangi.Location = New System.Drawing.Point(139, 16)
        Me.BtnPewangi.Name = "BtnPewangi"
        Me.BtnPewangi.Size = New System.Drawing.Size(88, 61)
        Me.BtnPewangi.TabIndex = 6
        Me.BtnPewangi.Text = "Pewangi"
        Me.BtnPewangi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPewangi.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.SystemColors.Info
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Panel1, Me.Panel2, Me.Panel3, Me.Panel4, Me.Panel5})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 426)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(947, 22)
        Me.StatusStrip1.TabIndex = 21
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(0, 17)
        '
        'Panel2
        '
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(0, 17)
        '
        'Panel3
        '
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(0, 17)
        '
        'Panel4
        '
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(121, 17)
        Me.Panel4.Text = "ToolStripStatusLabel1"
        '
        'Panel5
        '
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(121, 17)
        Me.Panel5.Text = "ToolStripStatusLabel2"
        '
        'BtnPelanggan
        '
        Me.BtnPelanggan.AutoSize = True
        Me.BtnPelanggan.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPelanggan.FlatAppearance.BorderSize = 0
        Me.BtnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPelanggan.Image = CType(resources.GetObject("BtnPelanggan.Image"), System.Drawing.Image)
        Me.BtnPelanggan.Location = New System.Drawing.Point(71, 16)
        Me.BtnPelanggan.Name = "BtnPelanggan"
        Me.BtnPelanggan.Size = New System.Drawing.Size(68, 61)
        Me.BtnPelanggan.TabIndex = 4
        Me.BtnPelanggan.Text = "Pelanggan"
        Me.BtnPelanggan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPelanggan.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BtnLogOut
        '
        Me.BtnLogOut.AutoSize = True
        Me.BtnLogOut.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnLogOut.FlatAppearance.BorderSize = 0
        Me.BtnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogOut.Image = CType(resources.GetObject("BtnLogOut.Image"), System.Drawing.Image)
        Me.BtnLogOut.Location = New System.Drawing.Point(94, 16)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.Size = New System.Drawing.Size(63, 63)
        Me.BtnLogOut.TabIndex = 5
        Me.BtnLogOut.Text = "LogOut"
        Me.BtnLogOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnLogOut.UseVisualStyleBackColor = True
        '
        'BtnKeluar
        '
        Me.BtnKeluar.AutoSize = True
        Me.BtnKeluar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnKeluar.FlatAppearance.BorderSize = 0
        Me.BtnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKeluar.Image = CType(resources.GetObject("BtnKeluar.Image"), System.Drawing.Image)
        Me.BtnKeluar.Location = New System.Drawing.Point(157, 16)
        Me.BtnKeluar.Name = "BtnKeluar"
        Me.BtnKeluar.Size = New System.Drawing.Size(51, 63)
        Me.BtnKeluar.TabIndex = 6
        Me.BtnKeluar.Text = "Keluar"
        Me.BtnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnKeluar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox2.Controls.Add(Me.BtnKeluar)
        Me.GroupBox2.Controls.Add(Me.BtnLogOut)
        Me.GroupBox2.Controls.Add(Me.BtnGantiPass)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox2.Location = New System.Drawing.Point(6, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 82)
        Me.GroupBox2.TabIndex = 18
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "File"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox1.Controls.Add(Me.BtnJasa)
        Me.GroupBox1.Controls.Add(Me.BtnPewangi)
        Me.GroupBox1.Controls.Add(Me.BtnPelanggan)
        Me.GroupBox1.Controls.Add(Me.BtnPetugas)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Location = New System.Drawing.Point(226, 19)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 80)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Master"
        '
        'BtnPetugas
        '
        Me.BtnPetugas.AutoSize = True
        Me.BtnPetugas.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnPetugas.FlatAppearance.BorderSize = 0
        Me.BtnPetugas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPetugas.Image = CType(resources.GetObject("BtnPetugas.Image"), System.Drawing.Image)
        Me.BtnPetugas.Location = New System.Drawing.Point(3, 16)
        Me.BtnPetugas.Name = "BtnPetugas"
        Me.BtnPetugas.Size = New System.Drawing.Size(68, 61)
        Me.BtnPetugas.TabIndex = 3
        Me.BtnPetugas.Text = "Petugas"
        Me.BtnPetugas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnPetugas.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox3.Controls.Add(Me.BtnCucianKeluar)
        Me.GroupBox3.Controls.Add(Me.BtnCucianMasuk)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Info
        Me.GroupBox3.Location = New System.Drawing.Point(542, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(212, 82)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaksi"
        '
        'BtnCucianKeluar
        '
        Me.BtnCucianKeluar.AutoSize = True
        Me.BtnCucianKeluar.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCucianKeluar.FlatAppearance.BorderSize = 0
        Me.BtnCucianKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCucianKeluar.Image = CType(resources.GetObject("BtnCucianKeluar.Image"), System.Drawing.Image)
        Me.BtnCucianKeluar.Location = New System.Drawing.Point(117, 16)
        Me.BtnCucianKeluar.Name = "BtnCucianKeluar"
        Me.BtnCucianKeluar.Size = New System.Drawing.Size(84, 63)
        Me.BtnCucianKeluar.TabIndex = 6
        Me.BtnCucianKeluar.Text = "Cucian Keluar"
        Me.BtnCucianKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCucianKeluar.UseVisualStyleBackColor = True
        '
        'BtnCucianMasuk
        '
        Me.BtnCucianMasuk.AutoSize = True
        Me.BtnCucianMasuk.Dock = System.Windows.Forms.DockStyle.Left
        Me.BtnCucianMasuk.FlatAppearance.BorderSize = 0
        Me.BtnCucianMasuk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCucianMasuk.Image = CType(resources.GetObject("BtnCucianMasuk.Image"), System.Drawing.Image)
        Me.BtnCucianMasuk.Location = New System.Drawing.Point(3, 16)
        Me.BtnCucianMasuk.Name = "BtnCucianMasuk"
        Me.BtnCucianMasuk.Size = New System.Drawing.Size(114, 63)
        Me.BtnCucianMasuk.TabIndex = 5
        Me.BtnCucianMasuk.Text = "Order Cucian Masuk"
        Me.BtnCucianMasuk.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnCucianMasuk.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GrayText
        Me.GroupBox4.Controls.Add(Me.GroupBox3)
        Me.GroupBox4.Controls.Add(Me.GroupBox1)
        Me.GroupBox4.Controls.Add(Me.GroupBox2)
        Me.GroupBox4.Location = New System.Drawing.Point(0, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1028, 105)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 448)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMenuUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laundry System Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuGantiPassword As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLogOut As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuMaster As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuPelanggan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuPewangi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuJasa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuPetugas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuTransaksi As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCucianKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCucianMasuk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuLaporan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLapPelanggan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLapJasa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLapCucianMasuk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLapCucianKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BtnGantiPass As System.Windows.Forms.Button
    Friend WithEvents BtnJasa As System.Windows.Forms.Button
    Friend WithEvents BtnPewangi As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel5 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BtnPelanggan As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnLogOut As System.Windows.Forms.Button
    Friend WithEvents BtnKeluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnPetugas As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnCucianKeluar As System.Windows.Forms.Button
    Friend WithEvents BtnCucianMasuk As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
End Class
