Imports System.Data.OleDb
Public Class FrmCetakLapOrder

    Private Sub FrmCetakLapOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        'Tampilkan No_Transaksi pada CmbNo
        cmd = New OleDbCommand("select * FROM Order_Pesanan order by No_Order desc", Conn)
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
        CmbNo.Enabled = False
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton4.CheckedChanged
        CmbNo.Enabled = True
        CmbNo.Text = ""
        DTPMulai.Value = Today
        DTPMulai.Enabled = False
        DTPAkhir.Value = Today
        DTPAkhir.Enabled = False
        CmbNo.Focus()
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
            FrmLapOrder.CrystalReportViewer1.SelectionFormula = ""
            FrmLapOrder.CrystalReportViewer1.RefreshReport()
            FrmLapOrder.ShowDialog()
        ElseIf RadioButton2.Checked = True Then
            'Cetak Laporan Berdasarkan cucian belum diambil
            FrmLapOrder.CrystalReportViewer1.SelectionFormula = "{Query_Order.Status_Cucian} ='" & "Proses" & "' "
            FrmLapOrder.CrystalReportViewer1.RefreshReport()
            FrmLapOrder.ShowDialog()
        ElseIf RadioButton3.Checked = True Then
            'Cetak Laporan Berdasarkan cucian belum diambil
            FrmLapOrder.CrystalReportViewer1.SelectionFormula = "{Query_Order.Status_Cucian} ='" & "Sudah Diambil" & "' "
            FrmLapOrder.CrystalReportViewer1.RefreshReport()
            FrmLapOrder.ShowDialog()
        ElseIf RadioButton4.Checked = True Then
            If CmbNo.Text = "" Then
                MsgBox("Silahkan pilih No No_Order terlebih dahulu", vbInformation + vbOKOnly, "Pesan")
                Exit Sub
            End If
            'Cetak Laporan Berdasarkan Nomor No_Transaksi
            FrmLapOrder.CrystalReportViewer1.SelectionFormula = "{Query_Order.No_Order} ='" & CmbNo.Text & "' "
            FrmLapOrder.CrystalReportViewer1.RefreshReport()
            FrmLapOrder.ShowDialog()
        ElseIf RadioButton5.Checked = True Then
            'Cetak Laporan Berdasarkan range tanggal
            FrmLapOrder.CrystalReportViewer1.SelectionFormula = "{Query_Order.Tgl_Order} >= date('" & _
                Format(DTPMulai.Value, "dd/MM/yyyy") & "') and {Query_Order.Tgl_Order} <= date('" & _
                Format(DTPAkhir.Value, "dd/MM/yyyy") & "')"
            FrmLapOrder.CrystalReportViewer1.RefreshReport()
            FrmLapOrder.Show()
        End If
    End Sub
End Class