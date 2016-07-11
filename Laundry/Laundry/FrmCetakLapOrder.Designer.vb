<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCetakLapOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCetakLapOrder))
        Me.CmbNo = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButton5 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPAkhir = New System.Windows.Forms.DateTimePicker()
        Me.DTPMulai = New System.Windows.Forms.DateTimePicker()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.BtnCetak = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbNo
        '
        Me.CmbNo.FormattingEnabled = True
        Me.CmbNo.Location = New System.Drawing.Point(161, 112)
        Me.CmbNo.Name = "CmbNo"
        Me.CmbNo.Size = New System.Drawing.Size(106, 21)
        Me.CmbNo.TabIndex = 158
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.CmbNo)
        Me.GroupBox2.Controls.Add(Me.RadioButton5)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.DTPAkhir)
        Me.GroupBox2.Controls.Add(Me.DTPMulai)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 210)
        Me.GroupBox2.TabIndex = 163
        Me.GroupBox2.TabStop = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(17, 83)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(129, 17)
        Me.RadioButton3.TabIndex = 161
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Cucian Sudah Diambil"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 51)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(127, 17)
        Me.RadioButton2.TabIndex = 160
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Cucian Belum Diambil"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(114, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 159
        Me.Label3.Text = "Dari :"
        '
        'RadioButton5
        '
        Me.RadioButton5.AutoSize = True
        Me.RadioButton5.Location = New System.Drawing.Point(17, 144)
        Me.RadioButton5.Name = "RadioButton5"
        Me.RadioButton5.Size = New System.Drawing.Size(80, 17)
        Me.RadioButton5.TabIndex = 157
        Me.RadioButton5.TabStop = True
        Me.RadioButton5.Text = "Per Periode"
        Me.RadioButton5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(112, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 156
        Me.Label1.Text = "Sampai :"
        '
        'DTPAkhir
        '
        Me.DTPAkhir.CustomFormat = "dd/MMMM/yyyy"
        Me.DTPAkhir.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPAkhir.Location = New System.Drawing.Point(162, 175)
        Me.DTPAkhir.Name = "DTPAkhir"
        Me.DTPAkhir.Size = New System.Drawing.Size(106, 20)
        Me.DTPAkhir.TabIndex = 155
        '
        'DTPMulai
        '
        Me.DTPMulai.CustomFormat = "dd/MMMM/yyyy"
        Me.DTPMulai.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPMulai.Location = New System.Drawing.Point(162, 144)
        Me.DTPMulai.Name = "DTPMulai"
        Me.DTPMulai.Size = New System.Drawing.Size(106, 20)
        Me.DTPMulai.TabIndex = 154
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(17, 112)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton4.TabIndex = 153
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "Per No. Order"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(16, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(58, 17)
        Me.RadioButton1.TabIndex = 152
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Semua"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'BtnCetak
        '
        Me.BtnCetak.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnCetak.Image = CType(resources.GetObject("BtnCetak.Image"), System.Drawing.Image)
        Me.BtnCetak.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCetak.Location = New System.Drawing.Point(204, 260)
        Me.BtnCetak.Name = "BtnCetak"
        Me.BtnCetak.Size = New System.Drawing.Size(99, 38)
        Me.BtnCetak.TabIndex = 150
        Me.BtnCetak.Text = "Cetak"
        Me.BtnCetak.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Cetak Laporan Berdasarkan :"
        '
        'FrmCetakLapOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(318, 314)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCetak)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCetakLapOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak Laporan Order"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbNo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton5 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DTPAkhir As System.Windows.Forms.DateTimePicker
    Friend WithEvents DTPMulai As System.Windows.Forms.DateTimePicker
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnCetak As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
End Class
