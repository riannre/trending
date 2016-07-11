Imports System.Data.OleDb
Public Class FrmLogin
    'Membuat fungsi untuk cek data pengguna
    Sub Login()
        Koneksi()
        'Cek nama dan password petugas
        cmd = New OleDbCommand("select * from Petugas where NamaPTG='" & TextBox1.Text & "' and PasswordPtg='" & TextBox2.Text & "'", Conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If rd.HasRows Then
            'Jika ada maka akan tampil data pada menu utama
            Dim Lvl_pengguna As String
            Lvl_pengguna = rd.GetString(3)
            FrmMenuUtama.Panel1.Text = rd.GetString(0)
            FrmMenuUtama.Panel2.Text = rd.GetString(1)
            FrmMenuUtama.Panel3.Text = rd.GetString(3)
            'cek level pengguna
            If Lvl_pengguna = "KASIR" Then
                FrmMenuUtama.MnuPewangi.Enabled = False
                FrmMenuUtama.MnuJasa.Enabled = False
                FrmMenuUtama.MnuPetugas.Enabled = False
                FrmMenuUtama.MnuPetugas.Enabled = False
                FrmMenuUtama.BtnPetugas.Enabled = False
                FrmMenuUtama.BtnPewangi.Enabled = False
                FrmMenuUtama.BtnJasa.Enabled = False
                FrmMenuUtama.Show()
                Me.Hide()
            Else
                FrmMenuUtama.MnuPewangi.Enabled = True
                FrmMenuUtama.MnuJasa.Enabled = True
                FrmMenuUtama.MnuPetugas.Enabled = True
                FrmMenuUtama.MnuPetugas.Enabled = True
                FrmMenuUtama.BtnPetugas.Enabled = True
                FrmMenuUtama.BtnPewangi.Enabled = True
                FrmMenuUtama.BtnJasa.Enabled = True
                
                FrmMenuUtama.Show()
                Me.Hide()
            End If
        Else
            MsgBox("login salah, periksan kembali user name dan password")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub FrmLogin_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TextBox1.Select()
        TextBox1.Focus()
    End Sub
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(13) Then
            If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
            If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
            Call Login()
        End If
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If TextBox1.Text = "" Then TextBox1.Focus() : Exit Sub
        If TextBox2.Text = "" Then TextBox2.Focus() : Exit Sub
        Call Login()
    End Sub

    Private Sub BtnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBatal.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub BtnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTutup.Click
        End
    End Sub
End Class