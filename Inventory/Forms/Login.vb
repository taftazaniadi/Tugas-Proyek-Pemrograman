Public Class Login
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Environment.Exit(1)
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
        If chkAdmin.Checked = True Then
            DTGrid = KontrolAdmin.LoginAdmin(txtUser.Text).ToTable

            If DTGrid.Rows.Count > 0 Then
                EntitasAdmin.id_adminAdmin = DTGrid.Rows(0).Item(0)
                EntitasAdmin.usernameAdmin = DTGrid.Rows(0).Item(1)
                EntitasAdmin.passwordAdmin = DTGrid.Rows(0).Item(2)
                EntitasAdmin.fullnameAdmin = DTGrid.Rows(0).Item(3)
                EntitasAdmin.emailAdmin = DTGrid.Rows(0).Item(4)
                EntitasAdmin.contactAdmin = DTGrid.Rows(0).Item(5)

                If txtPass.Text = EntitasAdmin.passwordAdmin And chkAdmin.Checked = True Then
                    Form1.Show()
                    txtPass.Text = ""
                    txtUser.Text = ""
                Else
                    MessageBox.Show("Password Anda SALAH!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtPass.Text = ""
                    chkAdmin.Checked = False
                    txtPass.Focus()
                End If
            Else
                MessageBox.Show("Username tidak dikenal!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtPass.Text = ""
                txtUser.Text = ""
                txtUser.Focus()
            End If
        Else
            DTGrid = KontrolMember.LoginMember(txtUser.Text).ToTable

            If DTGrid.Rows.Count > 0 Then
                EntitasMember.NIMMember = DTGrid.Rows(0).Item(0)
                EntitasMember.NamaMember = DTGrid.Rows(0).Item(1)
                EntitasMember.PasswordMember = DTGrid.Rows(0).Item(2)
                EntitasMember.EmailMember = DTGrid.Rows(0).Item(3)
                EntitasMember.ContactMember = DTGrid.Rows(0).Item(4)
                EntitasMember.JurusanMember = DTGrid.Rows(0).Item(5)

                If txtPass.Text = EntitasMember.PasswordMember Then
                    Member.Show()
                    txtPass.Text = ""
                    txtUser.Text = ""
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
        End If
        Me.Hide()
    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged
        txtPass.isPassword = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class