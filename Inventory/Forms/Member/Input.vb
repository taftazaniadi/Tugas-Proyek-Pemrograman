Public Class Input

    Dim modeProses As Integer
    Dim baris As Integer

    Private Sub AturButton(st As Boolean)
        cbNama.Enabled = st
        dtPinjam.Enabled = st
        dtKembali.Enabled = st
        txtJumlah.Enabled = st
        txtDesk.Enabled = st
        btnAdd.Enabled = Not st
        btnSave.Enabled = st
    End Sub

    Private Sub FillCOmbo()
        Try
            Dim query As String = ("SELECT * FROM barang")
            Dim da As New OleDb.OleDbDataAdapter(query, koneksi)
            Dim ds As New DataSet

            da.Fill(ds)
            cbNama.DisplayMember = "nama_barang"
            cbNama.ValueMember = "id_barang"
            cbNama.DataSource = ds.Tables(0)
            cbNama.SelectedValue = 0
        Catch ex As Exception
            MsgBox("ERORR : " & ex.Message.ToString)
        End Try
    End Sub

    Private Sub RefreshGrid()
        DTGrid = KontrolBarang.tampilData.ToTable
        DGBarang.DataSource = DTGrid
        txtNIM.Text = EntitasMember.NIMMember.ToString
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        RefreshGrid()
        AturButton(False)
    End Sub

    Private Sub Input_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
        AturButton(False)
        txtNIM.Enabled = False
        FillCOmbo()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AturButton(True)
        modeProses = 1
        cbNama.SelectedValue = 0
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        With EntitasTransaksi
            .id_transaksiDetail = KontrolTransaksi.kodeBaru
            .id_personalDetail = EntitasMember.id_personalMember.ToString
            .id_barangDetail = cbNama.SelectedValue
            .tgl_pinjamDetail = dtPinjam.Value.Date
            .tgl_kembaliDetail = dtKembali.Value.Date
            .jumlahDetail = txtJumlah.Text
            .deskripsiDetail = txtDesk.Text
            .suratDetail = ""
            .status_transaksiDetail = "Menunggu"
        End With

        If modeProses = 1 Then
            KontrolTransaksi.InsertData(EntitasTransaksi)
        End If

        MsgBox("Data has been Saved..", MsgBoxStyle.Information, "Information")
        RefreshGrid()
        AturButton(False)
        modeProses = 0
        Me.Hide()
    End Sub

End Class