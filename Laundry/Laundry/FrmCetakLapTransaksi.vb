Imports System.Data.OleDb
Public Class FrmCetakLapTransaksi

    Private Sub FrmCetakLapTransaksi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        'Tampilkan No_Transaksi pada CmbNo
        cmd = New OleDbCommand("select * FROM Transaksi order by No_Transaksi desc", Conn)
        rd = cmd.ExecuteReader
        Do While rd.Read
            CmbNo.Items.Add(rd.Item(0))
        Loop

        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
        BtnCetak.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton3.CheckedChanged
        CmbNo.Enabled = True
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
        CmbNo.Focus()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = True
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = True
        DTPMulai.Focus()
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton5.CheckedChanged
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = True
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = True
        DTPMulai.Focus()
    End Sub

    Private Sub BtnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCetak.Click
        If RadioButton1.Checked = True Then
            'Cetak Semua Data
            FrmLapTransaksi.CrystalReportViewer1.SelectionFormula = ""
            FrmLapTransaksi.CrystalReportViewer1.RefreshReport()
            FrmLapTransaksi.ShowDialog()
        ElseIf RadioButton2.Checked = True Then
            'Cetak Semua Data [Rekap]
            FrmLapTransaksiRekap.CrystalReportViewer1.SelectionFormula = ""
            FrmLapTransaksiRekap.CrystalReportViewer1.RefreshReport()
            FrmLapTransaksiRekap.ShowDialog()
        ElseIf RadioButton3.Checked = True Then
            If CmbNo.Text = "" Then
                MsgBox("Silahkan pilih No Transaksi terlebih dahulu", vbInformation + vbOKOnly, "Pesan")
                Exit Sub
            End If
            'Cetak Laporan Berdasarkan Nomor No_Transaksi
            FrmLapTransaksi.CrystalReportViewer1.SelectionFormula = "{Query_Transaksi.No_Transaksi} ='" & CmbNo.Text & "' "
            FrmLapTransaksi.CrystalReportViewer1.RefreshReport()
            FrmLapTransaksi.ShowDialog()
        ElseIf RadioButton4.Checked = True Then
            'Cetak Laporan Berdasarkan range tanggal
            FrmLapTransaksi.CrystalReportViewer1.SelectionFormula = "{Query_Transaksi.Tgl_Transaksi} >= date('" & _
                Format(DTPMulai.Value, "dd/MM/yyyy") & "') and {Query_Transaksi.Tgl_Transaksi} <= date('" & _
                Format(DTPAkhir.Value, "dd/MM/yyyy") & "')"
            FrmLapTransaksi.CrystalReportViewer1.RefreshReport()
            FrmLapTransaksi.Show()
        ElseIf RadioButton5.Checked = True Then
            'Cetak Laporan Berdasarkan range tanggal
            FrmLapTransaksiRekap.CrystalReportViewer1.SelectionFormula = "{Transaksi.Tgl_Transaksi} >= date('" & _
                Format(DTPMulai.Value, "dd/MM/yyyy") & "') and {Transaksi.Tgl_Transaksi} <= date('" & _
                Format(DTPAkhir.Value, "dd/MM/yyyy") & "')"
            FrmLapTransaksiRekap.CrystalReportViewer1.RefreshReport()
            FrmLapTransaksiRekap.Show()
        End If
    End Sub
End Class