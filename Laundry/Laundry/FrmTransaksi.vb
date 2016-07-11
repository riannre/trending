Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class FrmTransaksi
    Sub NomorOtomatis()
        cmd = New OleDbCommand("Select * from Transaksi where No_Transaksi in (select max(No_Transaksi) from Transaksi) order by No_Transaksi desc", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            TxtNomor.Text = Format(Now, "yyMMdd") + "0001"
        Else
            If Microsoft.VisualBasic.Left(rd.GetString(0), 6) <> Format(Now, "yyMMdd") Then
                TxtNomor.Text = Format(Now, "yyMMdd") + "0001"
            Else
                TxtNomor.Text = rd.GetString(0) + 1
            End If
        End If
    End Sub

    Sub BersihkanText()
        LblTotal.Text = "0"
        TxtTglTransaksi.Text = Format(Now, "dd/MM/yyyy")
        TxtNoOrder.Text = ""
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtTglOrder.Text = ""
        TxtTglRencana.Text = ""
        TxtPewangi.Text = ""
        TxtJumlah.Text = ""
        TxtDibayar.Text = ""
        TxtKembali.Text = ""
        DGV.Columns.Clear()
        TxtNoOrder.Enabled = True
        BtnSimpan.Enabled = False
        TxtDibayar.Enabled = True
        TxtKembali.Enabled = True
        TxtNoOrder.Select()
        Call NomorOtomatis()
    End Sub

    Private Sub FrmTransaksi_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BersihkanText()
        TxtNoOrder.Focus()
    End Sub

    Private Sub TxtNoOrder_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNoOrder.KeyPress
        If e.KeyChar = Chr(13) Then
            cmd = New OleDbCommand("select * from Order_Pesanan where No_Order='" & TxtNoOrder.Text & "' and Status_Cucian='" & "Proses" & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika nomor order ada, maka tampilkan data
                TxtKode.Text = rd.Item("Kode_Pelanggan")
                TxtNama.Text = rd.Item("Nama_Pelanggan")
                TxtTglOrder.Text = rd.Item("Tgl_Order")
                TxtTglRencana.Text = rd.Item("Tgl_Rencana_Selesai")
                TxtPewangi.Text = rd.Item("Nama_Pewangi")
                TxtJumlah.Text = rd.Item("jml_pakaian")
                LblTotal.Text = Format(rd.Item("Total_Harga"), "##,##")

                da = New OleDbDataAdapter("Select * from Order_Pesanan_Detail where No_Order='" & TxtNoOrder.Text & "' order by Kode_Jasa asc", Conn)
                ds = New DataSet
                ds.Clear()
                da.Fill(ds, "Order_Pesanan_Detail")
                DGV.DataSource = (ds.Tables("Order_Pesanan_Detail"))
                DGV.Columns(0).Width = 90
                DGV.Columns(1).Width = 90
                DGV.Columns(2).Width = 250
                DGV.Columns(3).Width = 90
                DGV.Columns(4).Width = 90
                DGV.Columns(5).Width = 90
                DGV.ReadOnly = True
                TxtNoOrder.Enabled = False
                TxtDibayar.Focus()
            Else
                '## Jika nomor order tidak ada maka keluar pesan
                MsgBox("Nomor order tidak ada", vbInformation + vbOKOnly, "Pesan")
                Call BersihkanText()
                TxtNoOrder.Focus()
            End If
        End If
    End Sub

    Private Sub TxtDibayar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDibayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(TxtDibayar.Text) < Val(Replace(LblTotal.Text, ".", "")) Then
                MsgBox("Pembayaran kurang")
                TxtKembali.Text = ""
                TxtDibayar.Focus()
                Exit Sub
            ElseIf Val(TxtDibayar.Text) = Val(Replace(LblTotal.Text, ".", "")) Then
                TxtKembali.Text = 0
                TxtDibayar.Text = Format(Val(TxtDibayar.Text), "##,##")
                TxtDibayar.Enabled = False
                BtnSimpan.Enabled = True
                BtnSimpan.Focus()
            Else
                TxtKembali.Text = Format(Val(TxtDibayar.Text) - Val(Replace(LblTotal.Text, ".", "")), "##,##")
                TxtDibayar.Text = Format(Val(TxtDibayar.Text), "##,##")
                TxtDibayar.Enabled = False
                BtnSimpan.Enabled = True
                BtnSimpan.Focus()
            End If

        End If
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub TxtDibayar_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDibayar.TextChanged

    End Sub

    Private Sub BtnBatal_Click(sender As System.Object, e As System.EventArgs) Handles BtnBatal.Click
        Call BersihkanText()
        TxtNoOrder.Focus()
    End Sub

    Private Sub BtnTutup_Click(sender As System.Object, e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub

    Private Sub BtnNoOrder_Click(sender As System.Object, e As System.EventArgs) Handles BtnNoOrder.Click
        FrmDataOrder.Show()
    End Sub

    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNoOrder.Text = "" Or LblTotal.Text = "0" Or TxtKode.Text = "" Or TxtDibayar.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            Exit Sub
        End If


        'simpan ke tabel Transaksi
        Dim simpanmaster As String = "Insert into Transaksi(No_Transaksi,Tgl_Transaksi,No_Order,Dibayar,Kembali,kodePTG,namaPTG) values " & _
        "('" & TxtNomor.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & TxtNoOrder.Text & "','" & _
        Val(Replace(TxtDibayar.Text, ".", "")) & "','" & Val(Replace(TxtKembali.Text, ".", "")) & "','" & _
        FrmMenuUtama.Panel1.Text & "','" & FrmMenuUtama.Panel2.Text & "')"
        cmd = New OleDbCommand(simpanmaster, Conn)
        cmd.ExecuteNonQuery()

        '" & frmMenuUtama.Panel1.Text & "',


        '## Ubah status Order berdasarkan nomor order ..
        cmd = New OleDbCommand("Update Order_Pesanan set Status_Cucian='" & "Sudah Diambil" & "' where No_Order='" & _
                               TxtNoOrder.Text & "'", Conn)
        cmd.ExecuteNonQuery()


        FrmNotaTransaksi.CrystalReportViewer1.SelectionFormula = "{Query_Transaksi.No_Transaksi} ='" & TxtNomor.Text & "' "
        FrmNotaTransaksi.CrystalReportViewer1.RefreshReport()
        FrmNotaTransaksi.ShowDialog()

        Call BersihkanText()
        TxtNoOrder.Focus()
    End Sub

    Private Sub TxtNoOrder_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNoOrder.TextChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class