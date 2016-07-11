Imports System.Data.OleDb
Public Class FrmDataPelanggan
    Private Sub FrmDataPelanggan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        da = New OleDbDataAdapter("Select * from Pelanggan", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DGVPelanggan.DataSource = (ds.Tables("Pelanggan"))
        DGVPelanggan.ReadOnly = True
    End Sub

    Private Sub TxtCari_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCari.KeyPress
        If e.KeyChar = Chr(27) Then
            Me.Close()
            FrmOrder.DGV.Focus()
            frmorder.DGV.CurrentCell = frmorder.DGV.Rows(0).Cells(0)
        End If
    End Sub

    Private Sub TxtCari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCari.TextChanged
        da = New OleDbDataAdapter("Select * from Pelanggan where nama_Pelanggan like '%" & TxtCari.Text & "%' order by nama_Pelanggan asc", Conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "Pelanggan")
        DGVPelanggan.DataSource = (ds.Tables("Pelanggan"))
        DGVPelanggan.ReadOnly = True
    End Sub

    Private Sub DGVPelanggan_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVPelanggan.CellContentClick

    End Sub

    Private Sub DGVPelanggan_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DGVPelanggan.DoubleClick
        Try
            With DGVPelanggan

                frmorder.TxtKode.Text = .SelectedCells(0).Value
                frmorder.TxtNama.Text = .SelectedCells(1).Value
                FrmOrder.TxtAlamat.Text = .SelectedCells(2).Value

            End With

            Me.Close()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub DGVPelanggan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles DGVPelanggan.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub DGVPelanggan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGVPelanggan.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                With DGVPelanggan
                    FrmOrder.TxtKode.Text = .SelectedCells(0).Value
                    frmorder.TxtNama.Text = .SelectedCells(1).Value
                    frmorder.TxtAlamat.Text = .SelectedCells(2).Value
                End With

                Me.Close()
            Catch ex As Exception
                MsgBox(ex.ToString())
            End Try
        End If
    End Sub
End Class