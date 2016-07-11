Public Class FrmMenuUtama
    Private Sub FrmMenuUtama_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        End
    End Sub

    Private Sub FrmMenuUtama_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Panel4.Text = Format(Now, "dddd, dd-MMMM-yyyy")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Panel5.Text = Format(Now, "hh:mm:ss")
    End Sub

    Private Sub MnuGantiPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGantiPassword.Click
        FrmGantiPassword.Show()
    End Sub

    Private Sub MnuLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLogOut.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub MnuKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Ingin Keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub
    
    Private Sub MnuPelanggan_Click(sender As System.Object, e As System.EventArgs) Handles MnuPelanggan.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub MnuPewangi_Click(sender As System.Object, e As System.EventArgs) Handles MnuPewangi.Click
        FrmPewangi.Show()
    End Sub

    Private Sub MnuJasa_Click(sender As System.Object, e As System.EventArgs) Handles MnuJasa.Click
        FrmJasa.Show()
    End Sub

    Private Sub MnuPetugas_Click(sender As System.Object, e As System.EventArgs) Handles MnuPetugas.Click
        FrmPetugas.Show()
    End Sub

    Private Sub MnuCucianMasuk_Click(sender As System.Object, e As System.EventArgs) Handles MnuCucianMasuk.Click
        FrmOrder.Show()
    End Sub

    Private Sub MnuCucianKeluar_Click(sender As System.Object, e As System.EventArgs) Handles MnuCucianKeluar.Click
        FrmTransaksi.Show()
    End Sub

    Private Sub MnuLapPelanggan_Click(sender As System.Object, e As System.EventArgs) Handles MnuLapPelanggan.Click
        FrmLapPelanggan.CrystalReportViewer1.SelectionFormula = ""
        FrmLapPelanggan.CrystalReportViewer1.RefreshReport()
        FrmLapPelanggan.ShowDialog()
    End Sub

    Private Sub MnuLapJasa_Click(sender As System.Object, e As System.EventArgs) Handles MnuLapJasa.Click
        FrmLapJasa.CrystalReportViewer1.SelectionFormula = ""
        FrmLapJasa.CrystalReportViewer1.RefreshReport()
        FrmLapJasa.ShowDialog()
    End Sub

    Private Sub MnuLapCucianMasuk_Click(sender As System.Object, e As System.EventArgs) Handles MnuLapCucianMasuk.Click
        FrmCetakLapOrder.Show()
    End Sub

    Private Sub MnuLapCucianKeluar_Click(sender As System.Object, e As System.EventArgs) Handles MnuLapCucianKeluar.Click
        FrmCetakLapTransaksi.Show()
    End Sub

    Private Sub MnuExit_Click(sender As System.Object, e As System.EventArgs) Handles MnuExit.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Ingin Keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub BtnGantiPass_Click(sender As System.Object, e As System.EventArgs) Handles BtnGantiPass.Click
        FrmGantiPassword.Show()
    End Sub

    Private Sub BtnLogOut_Click(sender As System.Object, e As System.EventArgs) Handles BtnLogOut.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub BtnKeluar_Click(sender As System.Object, e As System.EventArgs) Handles BtnKeluar.Click
        Dim pesan As String
        pesan = MsgBox("Yakin Ingin Keluar ??", vbInformation + vbYesNo, "Konfirmasi")
        If pesan = vbYes Then
            End
        End If
    End Sub

    Private Sub BtnPetugas_Click(sender As System.Object, e As System.EventArgs) Handles BtnPetugas.Click
        FrmPetugas.Show()
    End Sub

    Private Sub BtnPelanggan_Click(sender As System.Object, e As System.EventArgs) Handles BtnPelanggan.Click
        FrmPelanggan.Show()
    End Sub

    Private Sub BtnPewangi_Click(sender As System.Object, e As System.EventArgs) Handles BtnPewangi.Click
        FrmPewangi.Show()
    End Sub

    Private Sub BtnJasa_Click(sender As System.Object, e As System.EventArgs) Handles BtnJasa.Click
        FrmJasa.Show()
    End Sub

    Private Sub BtnCucianMasuk_Click(sender As System.Object, e As System.EventArgs) Handles BtnCucianMasuk.Click
        FrmOrder.Show()
    End Sub

    Private Sub BtnCucianKeluar_Click(sender As System.Object, e As System.EventArgs) Handles BtnCucianKeluar.Click
        FrmTransaksi.Show()
    End Sub
End Class