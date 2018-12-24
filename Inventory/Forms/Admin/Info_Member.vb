Public Class Info_Member
    Private Sub Info_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolMember.tampilData.ToTable
        DGMember.DataSource = DTGrid
    End Sub

    Private Sub BunifuCards1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        If Me.Width = 855 Then
            Panel1.Width = 540 + 150
            DGMember.Width = 534 + 150
            GroupBox1.Width = 534 + 150
        Else
            Panel1.Width = 540
            DGMember.Width = 534
            GroupBox1.Width = 534
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim status_referensi As Boolean
        status_referensi = KontrolBarang.cekBarangDireferensi(txtNIM.Text)

        If status_referensi Then
            MsgBox("Data masih digunakan, tidak boleh dihapus", MsgBoxStyle.Exclamation, "Peringatan")
            Exit Sub
        End If

        If MsgBox("Apakah Anda yakin akan menghapus " & txtNIM.Text & " - " & txtNama.Text & " ? ", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolBarang.deleteData(txtNIM.Text)
        End If
        RefreshGrid()
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGMember.Rows(br)
                txtNIM.Text = .Cells(0).Value.ToString
                txtNama.Text = .Cells(1).Value.ToString
                txtPass.Text = .Cells(2).Value.ToString
                txtEmail.Text = .Cells(3).Value.ToString
                txtKontak.Text = .Cells(4).Value.ToString
                txtJurusan.Text = .Cells(5).Value.ToString
            End With
        End If
    End Sub
End Class