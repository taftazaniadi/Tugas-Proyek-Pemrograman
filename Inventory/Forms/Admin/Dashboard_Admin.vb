Public Class Dashboard_Admin
    Private Sub Dashboard_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        btnSave.Visible = False
        btnCancel.Visible = False
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
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        btnEdit.Visible = True
        btnEdit.Enabled = True
        btnSave.Visible = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnCancel.Visible = False
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnEdit.Visible = True
        btnEdit.Enabled = True
        btnSave.Visible = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnCancel.Visible = False
    End Sub

End Class