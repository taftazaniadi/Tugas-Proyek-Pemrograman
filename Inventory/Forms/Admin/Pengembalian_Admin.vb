Public Class Pengembalian_Admin

    Private Sub Pengembalian_Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            Tabel.Width = 534 + 150
        Else
            Panel1.Width = 540
            Tabel.Width = 534
        End If
    End Sub
End Class