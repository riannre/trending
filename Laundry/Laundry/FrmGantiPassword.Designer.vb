<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGantiPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmGantiPassword))
        Me.TxtKonfirmasi = New System.Windows.Forms.TextBox()
        Me.OkBtn = New System.Windows.Forms.Button()
        Me.TxtPassBaru = New System.Windows.Forms.TextBox()
        Me.TxtPassLama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BatalBtn = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtKonfirmasi
        '
        Me.TxtKonfirmasi.Location = New System.Drawing.Point(187, 59)
        Me.TxtKonfirmasi.Name = "TxtKonfirmasi"
        Me.TxtKonfirmasi.Size = New System.Drawing.Size(144, 20)
        Me.TxtKonfirmasi.TabIndex = 157
        '
        'OkBtn
        '
        Me.OkBtn.Image = CType(resources.GetObject("OkBtn.Image"), System.Drawing.Image)
        Me.OkBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.OkBtn.Location = New System.Drawing.Point(167, 12)
        Me.OkBtn.Name = "OkBtn"
        Me.OkBtn.Size = New System.Drawing.Size(75, 30)
        Me.OkBtn.TabIndex = 24
        Me.OkBtn.Text = "Ok"
        Me.OkBtn.UseVisualStyleBackColor = True
        '
        'TxtPassBaru
        '
        Me.TxtPassBaru.Location = New System.Drawing.Point(187, 37)
        Me.TxtPassBaru.Name = "TxtPassBaru"
        Me.TxtPassBaru.Size = New System.Drawing.Size(144, 20)
        Me.TxtPassBaru.TabIndex = 156
        '
        'TxtPassLama
        '
        Me.TxtPassLama.Location = New System.Drawing.Point(187, 15)
        Me.TxtPassLama.Name = "TxtPassLama"
        Me.TxtPassLama.Size = New System.Drawing.Size(144, 20)
        Me.TxtPassLama.TabIndex = 155
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 13)
        Me.Label4.TabIndex = 154
        Me.Label4.Text = "Konfirmasi Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 152
        Me.Label2.Text = "Password Lama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Password Baru"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.TxtKonfirmasi)
        Me.GroupBox2.Controls.Add(Me.TxtPassBaru)
        Me.GroupBox2.Controls.Add(Me.TxtPassLama)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 87)
        Me.GroupBox2.TabIndex = 159
        Me.GroupBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 55)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 151
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Info
        Me.GroupBox1.Controls.Add(Me.BatalBtn)
        Me.GroupBox1.Controls.Add(Me.OkBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(340, 49)
        Me.GroupBox1.TabIndex = 158
        Me.GroupBox1.TabStop = False
        '
        'BatalBtn
        '
        Me.BatalBtn.Image = CType(resources.GetObject("BatalBtn.Image"), System.Drawing.Image)
        Me.BatalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BatalBtn.Location = New System.Drawing.Point(258, 12)
        Me.BatalBtn.Name = "BatalBtn"
        Me.BatalBtn.Size = New System.Drawing.Size(75, 30)
        Me.BatalBtn.TabIndex = 25
        Me.BatalBtn.Text = "Batal"
        Me.BatalBtn.UseVisualStyleBackColor = True
        '
        'FrmGantiPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 144)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmGantiPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ".: Ganti Password"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TxtKonfirmasi As System.Windows.Forms.TextBox
    Friend WithEvents OkBtn As System.Windows.Forms.Button
    Friend WithEvents TxtPassBaru As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassLama As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BatalBtn As System.Windows.Forms.Button
End Class
