<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengembalian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pengembalian))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DGKembali = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_pengembalian = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_peminjaman = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_pinjam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_kembali = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl_dikembalikan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DGKembali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderRadius = 5
        Me.Panel1.BottomSahddow = True
        Me.Panel1.color = System.Drawing.Color.Tomato
        Me.Panel1.Controls.Add(Me.DGKembali)
        Me.Panel1.LeftSahddow = False
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightSahddow = True
        Me.Panel1.ShadowDepth = 20
        Me.Panel1.Size = New System.Drawing.Size(540, 494)
        Me.Panel1.TabIndex = 0
        '
        'DGKembali
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGKembali.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGKembali.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGKembali.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGKembali.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGKembali.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGKembali.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGKembali.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.id_pengembalian, Me.id_peminjaman, Me.NIM, Me.tgl_pinjam, Me.tgl_kembali, Me.tgl_dikembalikan, Me.jumlah, Me.id_status})
        Me.DGKembali.DoubleBuffered = True
        Me.DGKembali.EnableHeadersVisualStyles = False
        Me.DGKembali.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DGKembali.HeaderForeColor = System.Drawing.Color.White
        Me.DGKembali.Location = New System.Drawing.Point(3, 7)
        Me.DGKembali.Name = "DGKembali"
        Me.DGKembali.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGKembali.Size = New System.Drawing.Size(534, 484)
        Me.DGKembali.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.ButtonText = "Add Data"
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.DisabledColor = System.Drawing.Color.Gray
        Me.btnAdd.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAdd.Iconimage = CType(resources.GetObject("btnAdd.Iconimage"), System.Drawing.Image)
        Me.btnAdd.Iconimage_right = Nothing
        Me.btnAdd.Iconimage_right_Selected = Nothing
        Me.btnAdd.Iconimage_Selected = Nothing
        Me.btnAdd.IconMarginLeft = 0
        Me.btnAdd.IconMarginRight = 0
        Me.btnAdd.IconRightVisible = True
        Me.btnAdd.IconRightZoom = 0R
        Me.btnAdd.IconVisible = True
        Me.btnAdd.IconZoom = 90.0R
        Me.btnAdd.IsTab = False
        Me.btnAdd.Location = New System.Drawing.Point(558, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnAdd.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAdd.selected = False
        Me.btnAdd.Size = New System.Drawing.Size(135, 48)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add Data"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'no
        '
        Me.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.no.HeaderText = "No."
        Me.no.Name = "no"
        Me.no.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.no.Width = 51
        '
        'id_pengembalian
        '
        Me.id_pengembalian.HeaderText = "ID Pengembalian"
        Me.id_pengembalian.Name = "id_pengembalian"
        '
        'id_peminjaman
        '
        Me.id_peminjaman.HeaderText = "ID Peminjaman"
        Me.id_peminjaman.Name = "id_peminjaman"
        '
        'NIM
        '
        Me.NIM.HeaderText = "NIM"
        Me.NIM.Name = "NIM"
        '
        'tgl_pinjam
        '
        Me.tgl_pinjam.HeaderText = "Tanggal Pinjam"
        Me.tgl_pinjam.Name = "tgl_pinjam"
        '
        'tgl_kembali
        '
        Me.tgl_kembali.HeaderText = "Tanggal Kembali"
        Me.tgl_kembali.Name = "tgl_kembali"
        '
        'tgl_dikembalikan
        '
        Me.tgl_dikembalikan.HeaderText = "Tanggal Dikembalikan"
        Me.tgl_dikembalikan.Name = "tgl_dikembalikan"
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah"
        Me.jumlah.Name = "jumlah"
        '
        'id_status
        '
        Me.id_status.HeaderText = "Status"
        Me.id_status.Name = "id_status"
        '
        'Pengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(705, 518)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pengembalian"
        Me.Text = "Pengembalian"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGKembali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DGKembali As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents id_pengembalian As DataGridViewTextBoxColumn
    Friend WithEvents id_peminjaman As DataGridViewTextBoxColumn
    Friend WithEvents NIM As DataGridViewTextBoxColumn
    Friend WithEvents tgl_pinjam As DataGridViewTextBoxColumn
    Friend WithEvents tgl_kembali As DataGridViewTextBoxColumn
    Friend WithEvents tgl_dikembalikan As DataGridViewTextBoxColumn
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents id_status As DataGridViewTextBoxColumn
End Class
