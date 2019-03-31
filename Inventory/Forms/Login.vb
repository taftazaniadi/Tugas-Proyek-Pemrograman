Public Class Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure to Exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmation") = MsgBoxResult.Yes Then
            Environment.Exit(1)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        logo.Hide()
        amcc.Hide()
        Label2.Hide()
        Garis1.Hide()
        Garis2.Hide()
        logoAnimator.Show(amcc)
        logoAnimator.Show(Label2)
        logoAnimator.Show(Garis1)
        logoAnimator.Show(Garis2)
        logoAnimator.Show(logo)
        Me.CenterToScreen()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        DTGrid = KontrolAdmin.LoginAdmin(txtUser.Text, txtPass.Text).ToTable

        If DTGrid.Rows.Count > 0 Then
            EntitasAdmin.id_personalAdmin = DTGrid.Rows(0).Item(0)
            EntitasAdmin.tipeAdmin = DTGrid.Rows(0).Item(1)
            EntitasAdmin.namaAdmin = DTGrid.Rows(0).Item(2)
            EntitasAdmin.emailAdmin = DTGrid.Rows(0).Item(3)
            EntitasAdmin.contactAdmin = DTGrid.Rows(0).Item(4)
            EntitasAdmin.jurusanAdmin = DTGrid.Rows(0).Item(5)
            EntitasAdmin.passwordAdmin = DTGrid.Rows(0).Item(6)
            EntitasAdmin.usernameAdmin = DTGrid.Rows(0).Item(7)

            If txtPass.Text = EntitasAdmin.passwordAdmin Then
                Form1.Show()
                txtUser.Text = ""
                txtPass.Text = ""
                Me.Hide()
            Else
                MessageBox.Show("Password Anda SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPass.Text = ""
                txtPass.Focus()
            End If
        Else
            MessageBox.Show("Username tidak dikenal!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPass.Text = ""
            txtUser.Text = ""
            txtUser.Focus()
        End If
    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged
        txtPass.isPassword = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        System.Diagnostics.Process.Start("http://amcc-inventory.000webhostapp.com/")
    End Sub
End Class