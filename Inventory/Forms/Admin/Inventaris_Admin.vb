Public Class Inventaris_Admin
    Private Sub Inventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
        Else
            Panel1.Width = 540
        End If
    End Sub

End Class