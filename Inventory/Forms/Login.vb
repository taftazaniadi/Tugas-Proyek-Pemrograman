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
        txtUser.Text = ""
        txtPass.Text = ""
        Me.CenterToScreen()
    End Sub



    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If chkAdmin.Checked = True Then
            If txtUser.Text = "Admin" And txtPass.Text = "admin" Then
                Me.Hide()
                txtUser.Text = ""
                txtPass.Text = ""
                chkAdmin.Checked = False
                Form1.Show()
            Else
                MessageBox.Show("Username tidak dikenal!!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtUser.Text = ""
                txtPass.Text = ""
                chkAdmin.Checked = False
            End If
        Else
            Me.Hide()
            chkAdmin.Checked = False
            txtUser.Text = ""
            txtPass.Text = ""
            Member.Show()
        End If
    End Sub

    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged
        txtPass.isPassword = True
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class