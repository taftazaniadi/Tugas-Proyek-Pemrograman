Imports System.Data.OleDb

Public Class Info_Member

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub Info_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Form1
        RefreshGrid()
        txtNIM.Enabled = False
    End Sub

    Private Sub AturButton(st As Boolean)
        txtNama.Enabled = st
        txtPass.Enabled = st
        txtEmail.Enabled = st
        txtKontak.Enabled = st
        txtJurusan.Enabled = st
        btnAdd.Enabled = Not st
        btnEdit.Enabled = Not st
        btnCancel.Enabled = st
        btnDelete.Enabled = st
        btnSave.Enabled = st
    End Sub

    Private Sub IsiBox(br As Integer)
        If br < DTGrid.Rows.Count Then
            With DGMember.Rows(br)
                txtID.Text = .Cells(0).Value.ToString
                txtNIM.Text = .Cells(1).Value.ToString
                txtNama.Text = .Cells(2).Value.ToString
                txtPass.Text = .Cells(3).Value.ToString
                txtEmail.Text = .Cells(4).Value.ToString
                txtKontak.Text = .Cells(5).Value.ToString
                txtJurusan.Text = .Cells(6).Value.ToString
            End With
        End If
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolMember.tampilData.ToTable
        DGMember.DataSource = DTGrid

        If DTGrid.Rows.Count > 0 Then
            baris = DTGrid.Rows.Count - 1
            DGMember.Rows(DTGrid.Rows.Count - 1).Selected = True
            DGMember.CurrentCell = DGMember.Item(1, baris)
            AturButton(False)
            IsiBox(baris)
        End If
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
        If MsgBox("Apakah Anda yakin akan menghapus " & txtNIM.Text & " - " & txtNama.Text & " ? ", MsgBoxStyle.Question + 
                  MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
            KontrolMember.deleteData(txtNIM.Text)
        End If
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AturButton(True)
        modeProses = 1
        txtNIM.Enabled = True
        txtNIM.Text = ""
        txtNama.Text = ""
        txtPass.Text = ""
        txtEmail.Text = ""
        txtKontak.Text = ""
        txtJurusan.Text = ""
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        AturButton(True)
        modeProses = 2
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasMember
            .id_personalMember = txtID.Text + 1
            .NIMMember = txtNIM.Text
            .namaMember = txtNama.Text
            .passwordMember = txtPass.Text
            .emailMember = txtEmail.Text
            .contactMember = txtKontak.Text
            .jurusanMember = txtJurusan.Text
        End With

        txtNIM.Enabled = False
        If modeProses = 1 Then
            KontrolMember.InsertData(EntitasMember)
        ElseIf modeProses = 2 Then
            KontrolMember.updateData(EntitasMember)
        End If

        MsgBox("Data has been saved..", MsgBoxStyle.Information, "Information")
        RefreshGrid()
        modeProses = 0
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        AturButton(False)
        modeProses = 0
        RefreshGrid()
        txtNIM.Enabled = False
    End Sub

    Private Sub DGMember_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGMember.CellClick
        If modeProses = 0 Then
            baris = e.RowIndex
            DGMember.Rows(baris).Selected = True
            IsiBox(baris)
        End If
    End Sub

End Class