Public Class Dashboard
    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Member
        btnSave.Visible = False
        btnCancel.Visible = False
        RefreshData_Member()
    End Sub

    Private Sub RefreshData_Member()
        txtNIM.Text = EntitasMember.NIMMember
        txtFull.Text = EntitasMember.NamaMember
        txtContact.Text = EntitasMember.ContactMember
        txtEmail.Text = EntitasMember.EmailMember
        txtJurusan.Text = EntitasMember.JurusanMember
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
        Else
            Panel1.Width = 540
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnEdit.Visible = False
        btnSave.Visible = True
        btnCancel.Visible = True
        txtFull.Enabled = True
        txtContact.Enabled = True
        txtEmail.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnEdit.Visible = True
        btnSave.Visible = False
        btnCancel.Visible = False
        txtFull.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False

        With EntitasMember
            .NamaMember = txtFull.Text
            .EmailMember = txtEmail.Text
            .ContactMember = txtContact.Text
        End With

        KontrolMember.updateData(EntitasMember)

        MsgBox("Data has been Updated..", MsgBoxStyle.Information, "Information")
        RefreshData_Member()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnEdit.Visible = True
        btnSave.Visible = False
        btnCancel.Visible = False
        txtFull.Enabled = False
        txtContact.Enabled = False
        txtEmail.Enabled = False
    End Sub
End Class