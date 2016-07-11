Imports System.Data.OleDb
Public Class FrmDataOrder

    Private Sub FrmDataOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from Order_Pesanan where Status_Cucian='" & "Proses" & "' order by no_order asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Order_Pesanan")
        DGVData.DataSource = (ds.Tables("Order_Pesanan"))
        DGVData.ReadOnly = True
    End Sub

    Private Sub TxtCari_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCari.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
            'FrmOrder.DGV.Focus()
            'FrmOrder.DGV.CurrentCell = FrmOrder.DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub TxtCari_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCari.TextChanged
        da = New OleDbDataAdapter("Select * from Order_Pesanan where nama_Pelanggan like '%" & TxtCari.Text & "%' and Status_Cucian='" & "Proses" & "' order by No_Order asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Order_Pesanan")
        DGVData.DataSource = (ds.Tables("Order_Pesanan"))
        DGVData.ReadOnly = True
    End Sub

    Private Sub DGVData_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVData.CellContentClick

    End Sub

    Private Sub DGVData_DoubleClick(sender As Object, e As System.EventArgs) Handles DGVData.DoubleClick
        Try
            With DGVData
                cmd = New OleDbCommand("select * from Order_Pesanan where No_Order='" & .SelectedCells(0).Value & "' and Status_Cucian='" & "Proses" & "'", Conn)
                rd = cmd.ExecuteReader
                rd.Read()
                If rd.HasRows = True Then
                    'Jika nomor order ada, maka tampilkan data
                    FrmTransaksi.TxtNoOrder.Text = rd.Item("No_Order")
                    FrmTransaksi.TxtKode.Text = rd.Item("Kode_Pelanggan")
                    FrmTransaksi.TxtNama.Text = rd.Item("Nama_Pelanggan")
                    FrmTransaksi.TxtTglOrder.Text = rd.Item("Tgl_Order")
                    FrmTransaksi.TxtTglRencana.Text = rd.Item("Tgl_Rencana_Selesai")
                    FrmTransaksi.TxtPewangi.Text = rd.Item("Nama_Pewangi")
                    FrmTransaksi.TxtJumlah.Text = rd.Item("jml_pakaian")
                    FrmTransaksi.LblTotal.Text = Format(rd.Item("Total_Harga"), "##,##")

                    da = New OleDbDataAdapter("Select * from Order_Pesanan_Detail where No_Order='" & .SelectedCells(0).Value & "' order by Kode_Jasa asc", Conn)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "Order_Pesanan_Detail")
                    FrmTransaksi.DGV.DataSource = (ds.Tables("Order_Pesanan_Detail"))
                    FrmTransaksi.DGV.Columns(0).Width = 90
                    FrmTransaksi.DGV.Columns(1).Width = 90
                    FrmTransaksi.DGV.Columns(2).Width = 250
                    FrmTransaksi.DGV.Columns(3).Width = 90
                    FrmTransaksi.DGV.Columns(4).Width = 90
                    FrmTransaksi.DGV.Columns(5).Width = 90
                    FrmTransaksi.DGV.ReadOnly = True
                    FrmTransaksi.TxtNoOrder.Enabled = False
                    FrmTransaksi.TxtDibayar.Focus()
                Else
                    '## Jika nomor order tidak ada maka keluar pesan
                    MsgBox("Nomor order tidak ada", vbInformation + vbOKOnly, "Pesan")
                    
                End If

            End With

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub
End Class