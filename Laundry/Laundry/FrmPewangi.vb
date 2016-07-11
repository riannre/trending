Imports System.Data.OleDb
Public Class FrmPewangi
    'Membuat prosedur dengan nama Bersih untuk membersihkan teks
    Sub Bersih()
        TxtNama.Enabled = True
        TxtNama.Text = ""
        BtnHapus.Enabled = False
        BtnSimpan.Enabled = True
    End Sub

    ' Membuat prosedur dengan nama TampilGrid untuk menampilkan data Pewangi-
    ' ke dalam Grid View
    Sub TampilGrid()
        da = New OleDbDataAdapter("Select * from Pewangi", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pewangi")
        DGV.DataSource = (ds.Tables("Pewangi"))
        DGV.ReadOnly = True
        DGV.Columns(0).Width = 260
    End Sub

    Private Sub BtnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSimpan.Click
        If TxtNama.Text = "" Then
            MsgBox("Nama Pewangi masih kosong")
            Exit Sub
        Else
            '## Cek Nama Pewangi apakah sudah ada sebelumnya..
            cmd = New OleDbCommand("Select * from Pewangi where Nama_Pewangi='" & _
                                   TxtNama.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()

            '## Jika Nama Pewangi Belum ada maka proses simpan 
            If Not rd.HasRows Then

                '## Proses Simpan :
                Dim sqltambah As String = "Insert into Pewangi(Nama_Pewangi) values " & _
                "('" & TxtNama.Text & "')"
                cmd = New OleDbCommand(sqltambah, Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtNama.Focus()
            Else
                '## Jika Nama Pewangi sudah ada maka tidak dapat menyimpan..
                MsgBox("Nama Pewangi telah ada sebelumnya", vbInformation + vbOKOnly, "Pesan")
                Call TampilGrid()
            End If
        End If
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        Call Bersih()
        Call TampilGrid()
        TxtNama.Focus()
    End Sub

    Private Sub BtnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHapus.Click
        If TxtNama.Text = "" Then
            MsgBox("Nama Masih Kosong")
            BtnBatal.Focus()
            Exit Sub
        Else
            '## Hapus data Pewangi berdasarkan Nama Pewangi..
            If MessageBox.Show("Yakin akan dihapus..?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                cmd = New OleDbCommand("Delete from Pewangi where Nama_Pewangi='" & _
                                       TxtNama.Text & "'", Conn)
                cmd.ExecuteNonQuery()
                Call Bersih()
                Call TampilGrid()
                TxtNama.Focus()
            Else
                Call Bersih()
                Call TampilGrid()
                TxtNama.Focus()
            End If
        End If
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        'Cari Pewangi berdasarkan nama Pewangi
        da = New OleDbDataAdapter("Select * from Pewangi where nama_Pewangi like '%" & TxtCari.Text & "%' order by nama_Pewangi asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pewangi")
        DGV.DataSource = (ds.Tables("Pewangi"))
        DGV.ReadOnly = True
    End Sub

    Private Sub TxtNama_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNama.KeyPress
        If e.KeyChar = Chr(13) Then
            ' Jika di Enter, maka proses cari Nama Pewangi
            cmd = New OleDbCommand("select * from Pewangi where Nama_Pewangi='" & TxtNama.Text & "'", Conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows = True Then
                'Jika Nama Pewangi ada, maka tampilkan data
                MsgBox("Data Ditemukan", vbInformation + vbOKOnly, "Pesan")
                TxtNama.Text = rd.Item("Nama_Pewangi")

                TxtNama.Enabled = False
                BtnSimpan.Enabled = False
                BtnHapus.Enabled = True
                BtnBatal.Focus()
            Else
                'Jika Nama Pewangi tidak ada maka cursor focus ke simpan
                BtnSimpan.Focus()
            End If
        End If
    End Sub

    Private Sub FrmPewangi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call TampilGrid()
        Call Bersih()
        TxtNama.Select()
    End Sub

End Class