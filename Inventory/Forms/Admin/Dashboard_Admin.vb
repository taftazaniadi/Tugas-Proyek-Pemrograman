Public Class Dashboard_Admin
    Private Sub Dashboard_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        btnSave.Visible = False
        btnCancel.Visible = False
        RefreshData_Admin()
    End Sub

    Private Sub RefreshData_Admin()
        txtUser.Text = EntitasAdmin.usernameAdmin
        txtFull.Text = EntitasAdmin.fullnameAdmin
        txtContact.Text = EntitasAdmin.contactAdmin
        txtEmail.Text = EntitasAdmin.emailAdmin
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
        Else
            Panel1.Width = 540
        End If
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Enabled = False
        btnSave.Visible = True
        btnSave.Enabled = True
        btnCancel.Visible = True
        btnCancel.Enabled = True
        txtUser.Enabled = True
        txtFull.Enabled = True
        txtContact.Enabled = True
        txtEmail.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnEdit.Visible = True
        btnEdit.Enabled = True
        btnSave.Visible = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnCancel.Visible = False
        txtUser.Enabled = False
        txtFull.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False

        With EntitasAdmin
            .usernameAdmin = txtUser.Text
            .fullnameAdmin = txtFull.Text
            .emailAdmin = txtEmail.Text
            .contactAdmin = txtContact.Text
        End With

        KontrolAdmin.updateData(EntitasAdmin)

        MsgBox("Data has been Updated..", MsgBoxStyle.Information, "Information")
        RefreshData_Admin()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnEdit.Visible = True
        btnEdit.Enabled = True
        btnSave.Visible = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnCancel.Visible = False
        txtUser.Enabled = False
        txtFull.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False
    End Sub

End Class