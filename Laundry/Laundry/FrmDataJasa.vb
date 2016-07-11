Imports System.Data.OleDb
Public Class FrmDataJasa
    Sub Tampilkan()
        da = New OleDbDataAdapter("Select * from Jasa order by Kode_Jasa asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Jasa")
        DGV.DataSource = (ds.Tables("Jasa"))
        DGV.ReadOnly = True
    End Sub

    Private Sub FrmDataJasa_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call Tampilkan()
    End Sub

    Private Sub TxtCari_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCari.TextChanged
        da = New OleDbDataAdapter("Select * from Jasa where Nama_Jasa like '%" & TxtCari.Text & "%' order by Nama_Jasa asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Jasa")
        DGV.DataSource = (ds.Tables("Jasa"))
        DGV.ReadOnly = True
    End Sub
End Class