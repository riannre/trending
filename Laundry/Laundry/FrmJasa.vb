Imports System.Data.OleDb
Public Class FrmJasa
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Bersih()
        TxtKode.Text = ""
        TxtNama.Text = ""
        TxtSatuan.Text = ""
        TxtHarga.Text = ""
        TxtKode.Enabled = True
        BtnUbah.Enabled = False
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
        TxtKode.Select()
    End Sub

    ' Membuat prosedur dengan nama TampilGrid untuk menampilkan data Jasa-
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Jasa", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Jasa")
        DGV.DataSource = (ds.Tables("Jasa"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 100
        DGV.Columns(1).Width = 195
        DGV.Columns(2).Width = 100
        DGV.Columns(3).Width = 100
    End Sub

    Private Sub txtharga_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            If BtnSimpan.Enabled = True Then
                BtnSimpan.Focus()
            Else
                BtnUbah.Focus()
            End If
        End If
        'untuk input hanya angka saja
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled() = True

    End Sub


    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtKode.Text = "" Or TxtNama.Text = "" Then
            MsgBox("Kode / Nama Jasa masih ada yang kosong")
            Exit Sub
        Else
            '## Cek kode Jasa apakah sudah ada sebelumnya..
            cmd = New OleDbCommand("Select * from Jasa where Kode_Jasa='" & _
                                   TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()

            '## Jika kode Jasa ada maka proses simpan 
            If Not rd.HasRows Then

                '## Proses Simpan :
                Dim sqltambah As String = "Insert into Jasa(Kode_Jasa,Nama_Jasa,Satuan,Harga) values " & _
                "('" & TxtKode.Text & "','" & TxtNama.Text & "','" & _
                TxtSatuan.Text & "','" & Val(TxtHarga.Text) & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                '## Jika kode Jasa sudah ada maka tidak dapat menyimpan..
                MsgBox("Kode Jasa telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                Call TampilGrid()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Bersih()
        Call TampilGrid()
        TxtKode.Focus()
    End Sub

    Private Sub BtnUbah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUbah.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            BtnBatal.Focus()
            Exit Sub
        Else

            '## Ubah data Jasa berdasarkan kode Jasa ..
            cmd = New OleDbCommand("Update Jasa set Nama_Jasa='" & _
                                   TxtNama.Text & "',satuan='" & _
                                   TxtSatuan.Text & "',Harga='" & _
                                   Val(TxtHarga.Text) & "' where Kode_Jasa='" & _
                                   TxtKode.Text & "'", Conn)
            cmd.ExecuteNonQuery()
            Call Bersih()
            Call TampilGrid()
            TxtKode.Focus()
        End If

    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TxtKode.Text = "" Then
            MsgBox("Kode Masih Kosong")
            BtnBatal.Focus()
            Exit Sub
        Else
            '## Hapus data Jasa berdasarkan kode Jasa..
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Jasa where Kode_Jasa='" & _
                                       TxtKode.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            Else
                Call Bersih()
                Call TampilGrid()
                TxtKode.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        If RbNama.Checked = True Then
            'Cari Jasa berdasarkan nama Jasa
            da = New OleDbDataAdapter("Select * from Jasa where nama_Jasa like '%" & TxtCari.Text & "%' order by nama_Jasa asc", Conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Jasa")
            DGV.DataSource = (ds.Tables("Jasa"))
            DGV.ReadOnly = True
        ElseIf RbKode.Checked = True Then
            'Cari Jasa Berdasarkan Kode Jasa
            da = New OleDbDataAdapter("Select * from Jasa where kode_Jasa like '%" & TxtCari.Text & "%' order by kode_Jasa asc", Conn)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Jasa")
            DGV.DataSource = (ds.Tables("Jasa"))
            DGV.ReadOnly = True
        End If
    End Sub

    Private Sub TxtKode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            ' Jika di Enter, maka proses cari kode Jasa
            cmd = New OleDbCommand("select * from Jasa where Kode_Jasa='" & TxtKode.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika kode Jasa ada, maka tampilkan data
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtKode.Text = rd.Item("Kode_Jasa")
                TxtNama.Text = rd.Item("Nama_Jasa")
                TxtSatuan.Text = rd.Item("Satuan")
                TxtHarga.Text = rd.Item("Harga")

                TxtKode.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnUbah.Enabled = True
                BtnBatal.Focus()
            Else
                'Jika kode Jasa tidak ada maka cursor focus ke txtnama
                TxtNama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtSatuan.Focus()
        End If
    End Sub

    Private Sub FrmJasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Bersih()
    End Sub

    Private Sub TxtSatuan_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtSatuan.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtHarga.Focus()
        End If
    End Sub

    Private Sub TxtSatuan_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtSatuan.TextChanged

    End Sub

    Private Sub TxtHarga_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtHarga.TextChanged

    End Sub
End Class