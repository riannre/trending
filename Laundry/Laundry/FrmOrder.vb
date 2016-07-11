Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class FrmOrder
    Sub NomorOtomatis()
        cmd = New OleDbCommand("Select * from Order_Pesanan where No_Order in (select max(No_Order) from Order_Pesanan) order by No_Order desc", Conn)
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
    Sub TampilPewangi()
        cmd = New OleDbCommand("Select * from Pewangi", Conn)
        rd = cmd.ExecuteReader
        CmbPewangi.Items.Clear()
        Do While rd.Read
            CmbPewangi.Items.Add(rd.Item(0))
        Loop
    End Sub

    Sub BersihkanText()
        LblTotal.Text = "0"
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        CmbPewangi.Text = ""
        TxtJmlPakaian.Text = ""
        TxtTanggal.Text = Format(Now, "dd/MM/yyyy")
        DTTanggal.Value = Format(Now, "yyyy/MM/dd")
        Call NomorOtomatis()
    End Sub

    Sub BuatKolomBaru()
        DGV.Columns.Add("Kode", "Kode Jasa")
        DGV.Columns.Add("Nama", "Nama Jasa")
        DGV.Columns.Add("Satuan", "Satuan")
        DGV.Columns.Add("Harga", "Harga")
        DGV.Columns.Add("Jumlah", "Jumlah")
        DGV.Columns.Add("Total", "SubTotal")
        Call AturLebarKolom()
    End Sub

    Sub AturLebarKolom()
        DGV.Columns(0).Width = 120
        DGV.Columns(1).Width = 300
        DGV.Columns(2).Width = 75
        DGV.Columns(3).Width = 120
        DGV.Columns(4).Width = 75
        DGV.Columns(5).Width = 120

        DGV.Columns(1).ReadOnly = True
        DGV.Columns(2).ReadOnly = True
        DGV.Columns(3).ReadOnly = True
        DGV.Columns(5).ReadOnly = True

    End Sub
    Sub TotalHarga()
        Dim HitungHarga As Integer = 0
        For I As Integer = 0 To DGV.Rows.Count - 1
            HitungHarga = HitungHarga + Val(DGV.Rows(I).Cells(5).Value)
            LblTotal.Text = Format(HitungHarga, "##,##")
        Next
    End Sub
    Private Sub FrmOrder_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call BuatKolomBaru()
        Call BersihkanText()
        Call TampilPewangi()
    End Sub

    Private Sub BtnPelanggan_Click(sender As System.Object, e As System.EventArgs) Handles BtnPelanggan.Click
        FrmDataPelanggan.ShowDialog()
        DTTanggal.Focus()
    End Sub

    Private Sub TxtJmlPakaian_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtJmlPakaian.KeyPress
        If e.KeyChar = Chr(13) Then
            DGV.Focus()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True
    End Sub

    Private Sub CmbPewangi_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CmbPewangi.SelectedIndexChanged
        TxtJmlPakaian.Focus()
    End Sub

    Private Sub DGV_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub DGV_CellEndEdit(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellEndEdit
        If e.ColumnIndex = 0 Then
            cmd = New OleDbCommand("select * from Jasa where Kode_Jasa='" & DGV.Rows(e.RowIndex).Cells(0).Value & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                DGV.Rows(e.RowIndex).Cells(0).Value = rd.Item(0)
                DGV.Rows(e.RowIndex).Cells(1).Value = rd.Item(1)
                DGV.Rows(e.RowIndex).Cells(2).Value = rd.Item(2)
                DGV.Rows(e.RowIndex).Cells(3).Value = rd.Item(3)
                DGV.Rows(e.RowIndex).Cells(4).Value = 1
                DGV.Rows(e.RowIndex).Cells(5).Value = DGV.Rows(e.RowIndex).Cells(3).Value * DGV.Rows(e.RowIndex).Cells(4).Value
                Call TotalHarga()
                'DGV.CurrentCell = DGV(3, 0)

            Else
                MsgBox("Kode barang tidak terdaftar")
                DGV.Rows(e.RowIndex).Cells(0).Value = ""
                DGV.Rows(e.RowIndex).Cells(1).Value = ""
                DGV.Rows(e.RowIndex).Cells(2).Value = ""
                DGV.Rows(e.RowIndex).Cells(3).Value = ""
                DGV.Rows(e.RowIndex).Cells(4).Value = ""
                DGV.Rows(e.RowIndex).Cells(5).Value = ""
                DGV.CurrentCell = DGV.Rows(0).Cells(0)
            End If
        End If

        If e.ColumnIndex = 4 Then
            DGV.Rows(e.RowIndex).Cells(5).Value = DGV.Rows(e.RowIndex).Cells(4).Value * DGV.Rows(e.RowIndex).Cells(3).Value
            Call TotalHarga()
        End If
    End Sub

    Private Sub BtnJasa_Click(sender As System.Object, e As System.EventArgs) Handles BtnJasa.Click
        FrmDataJasa.Show()
    End Sub

    Private Sub DGV_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DGV.KeyPress
        On Error Resume Next
        If e.KeyChar = Chr(13) Then
            Call TotalHarga()
        ElseIf e.KeyChar = Chr(27) Then
            Call BersihkanText()
            DGV.Columns.Clear()
            Call BuatKolomBaru()
            DGV.Focus()
            DGV.CurrentCell = DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub BtnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles BtnSimpan.Click
        If LblTotal.Text = "0" Or TxtKode.Text = "" Or TxtJmlPakaian.Text = "" Or CmbPewangi.Text = "" Then
            MsgBox("Data belum lengkap, tidak ada transaksi atau pembayaran masih kosong")
            Exit Sub
        End If


        'simpan ke tabel Order_Pesanan
        Dim simpanmaster As String = "Insert into Order_Pesanan(No_Order,Tgl_Order,Tgl_Rencana_Selesai,Jml_Pakaian,Total_Harga,Nama_Pewangi,Kode_Pelanggan,Nama_Pelanggan,kodePTG,namaPTG,Status_Cucian) values " & _
        "('" & TxtNomor.Text & "','" & Format(Now, "yyyy/MM/dd") & "','" & Format(DTTanggal.Value, "yyyy/MM/dd") & "','" & _
        Val(TxtJmlPakaian.Text) & "','" & Val(Replace(LblTotal.Text, ".", "")) & "','" & CmbPewangi.Text & "','" & _
        TxtKode.Text & "','" & TxtNama.Text & "','" & FrmMenuUtama.Panel1.Text & "','" & FrmMenuUtama.Panel2.Text & "','" & "Proses" & "')"
        cmd = New OleDbCommand(simpanmaster, Conn)
        cmd.ExecuteNonQuery()


        For baris As Integer = 0 To DGV.Rows.Count - 2
            'simpan ke tabel Order_Pesanan_Detail
            Dim sqlsimpan As String = "Insert into Order_Pesanan_Detail (No_Order,Kode_Jasa,Nama_Jasa,Satuan,Harga,Jumlah,Sub_Total) values " & _
            "('" & TxtNomor.Text & "','" & DGV.Rows(baris).Cells(0).Value & "','" & DGV.Rows(baris).Cells(1).Value & "','" & _
            DGV.Rows(baris).Cells(2).Value & "','" & DGV.Rows(baris).Cells(3).Value & "','" & DGV.Rows(baris).Cells(4).Value & "','" & _
            DGV.Rows(baris).Cells(5).Value & "')"
            cmd = New OleDbCommand(sqlsimpan, Conn)
            cmd.ExecuteNonQuery()
        Next baris

        FrmNotaOrder.CrystalReportViewer1.SelectionFormula = "{Query_Order.No_Order} ='" & TxtNomor.Text & "' "
        FrmNotaOrder.CrystalReportViewer1.RefreshReport()
        FrmNotaOrder.ShowDialog()

        DGV.Columns.Clear()
        Call BuatKolomBaru()
        Call NomorOtomatis()
        Call BersihkanText()
        BtnPelanggan.Focus()
    End Sub

    Private Sub BtnBatal_Click(sender As System.Object, e As System.EventArgs) Handles BtnBatal.Click
        DGV.Columns.Clear()
        Call BuatKolomBaru()
        Call NomorOtomatis()
        Call BersihkanText()
        BtnPelanggan.Focus()
    End Sub

    Private Sub BtnTutup_Click(sender As System.Object, e As System.EventArgs) Handles BtnTutup.Click
        Me.Close()
    End Sub
End Class