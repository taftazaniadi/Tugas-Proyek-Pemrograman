<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inventaris_Admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inventaris_Admin))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Panel1 = New Bunifu.Framework.UI.BunifuCards()
        Me.DGBarang = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnDelete = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnEdit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCancel = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.cbTempat = New System.Windows.Forms.ComboBox()
        Me.cbKet = New System.Windows.Forms.ComboBox()
        Me.cbSatuan = New System.Windows.Forms.ComboBox()
        Me.cbJenis = New System.Windows.Forms.ComboBox()
        Me.BunifuCustomLabel8 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel7 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel6 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtStock = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNama = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtKode = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnPrint = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.Panel1.Controls.Add(Me.DGBarang)
        Me.Panel1.LeftSahddow = False
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.RightSahddow = True
        Me.Panel1.ShadowDepth = 20
        Me.Panel1.Size = New System.Drawing.Size(540, 247)
        Me.Panel1.TabIndex = 0
        '
        'DGBarang
        '
        Me.DGBarang.AllowUserToAddRows = False
        Me.DGBarang.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGBarang.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGBarang.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DGBarang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGBarang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGBarang.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGBarang.DoubleBuffered = True
        Me.DGBarang.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DGBarang.EnableHeadersVisualStyles = False
        Me.DGBarang.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.DGBarang.HeaderForeColor = System.Drawing.Color.White
        Me.DGBarang.Location = New System.Drawing.Point(3, 6)
        Me.DGBarang.Name = "DGBarang"
        Me.DGBarang.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGBarang.Size = New System.Drawing.Size(534, 238)
        Me.DGBarang.TabIndex = 1
        '
        'btnDelete
        '
        Me.btnDelete.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.BorderRadius = 0
        Me.btnDelete.ButtonText = "Delete"
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.DisabledColor = System.Drawing.Color.Gray
        Me.btnDelete.Iconcolor = System.Drawing.Color.Transparent
        Me.btnDelete.Iconimage = CType(resources.GetObject("btnDelete.Iconimage"), System.Drawing.Image)
        Me.btnDelete.Iconimage_right = Nothing
        Me.btnDelete.Iconimage_right_Selected = Nothing
        Me.btnDelete.Iconimage_Selected = Nothing
        Me.btnDelete.IconMarginLeft = 0
        Me.btnDelete.IconMarginRight = 0
        Me.btnDelete.IconRightVisible = True
        Me.btnDelete.IconRightZoom = 0R
        Me.btnDelete.IconVisible = True
        Me.btnDelete.IconZoom = 90.0R
        Me.btnDelete.IsTab = False
        Me.btnDelete.Location = New System.Drawing.Point(558, 228)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnDelete.OnHoverTextColor = System.Drawing.Color.White
        Me.btnDelete.selected = False
        Me.btnDelete.Size = New System.Drawing.Size(135, 48)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Textcolor = System.Drawing.Color.White
        Me.btnDelete.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnEdit
        '
        Me.btnEdit.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.BorderRadius = 0
        Me.btnEdit.ButtonText = "Update"
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.DisabledColor = System.Drawing.Color.Gray
        Me.btnEdit.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEdit.Iconimage = CType(resources.GetObject("btnEdit.Iconimage"), System.Drawing.Image)
        Me.btnEdit.Iconimage_right = Nothing
        Me.btnEdit.Iconimage_right_Selected = Nothing
        Me.btnEdit.Iconimage_Selected = Nothing
        Me.btnEdit.IconMarginLeft = 0
        Me.btnEdit.IconMarginRight = 0
        Me.btnEdit.IconRightVisible = True
        Me.btnEdit.IconRightZoom = 0R
        Me.btnEdit.IconVisible = True
        Me.btnEdit.IconZoom = 90.0R
        Me.btnEdit.IsTab = False
        Me.btnEdit.Location = New System.Drawing.Point(558, 66)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnEdit.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEdit.selected = False
        Me.btnEdit.Size = New System.Drawing.Size(135, 48)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Update"
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEdit.Textcolor = System.Drawing.Color.White
        Me.btnEdit.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCancel
        '
        Me.btnCancel.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.BorderRadius = 0
        Me.btnCancel.ButtonText = "Cancel"
        Me.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancel.DisabledColor = System.Drawing.Color.Gray
        Me.btnCancel.Enabled = False
        Me.btnCancel.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCancel.Iconimage = CType(resources.GetObject("btnCancel.Iconimage"), System.Drawing.Image)
        Me.btnCancel.Iconimage_right = Nothing
        Me.btnCancel.Iconimage_right_Selected = Nothing
        Me.btnCancel.Iconimage_Selected = Nothing
        Me.btnCancel.IconMarginLeft = 0
        Me.btnCancel.IconMarginRight = 0
        Me.btnCancel.IconRightVisible = True
        Me.btnCancel.IconRightZoom = 0R
        Me.btnCancel.IconVisible = True
        Me.btnCancel.IconZoom = 90.0R
        Me.btnCancel.IsTab = False
        Me.btnCancel.Location = New System.Drawing.Point(558, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnCancel.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnCancel.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCancel.selected = False
        Me.btnCancel.Size = New System.Drawing.Size(135, 48)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Textcolor = System.Drawing.Color.White
        Me.btnCancel.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 0
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Enabled = False
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = CType(resources.GetObject("btnSave.Iconimage"), System.Drawing.Image)
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 90.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(558, 120)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(135, 48)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Textcolor = System.Drawing.Color.White
        Me.btnSave.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAdd
        '
        Me.btnAdd.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdd.BorderRadius = 0
        Me.btnAdd.ButtonText = "Add"
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
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Textcolor = System.Drawing.Color.White
        Me.btnAdd.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbStatus)
        Me.GroupBox1.Controls.Add(Me.cbTempat)
        Me.GroupBox1.Controls.Add(Me.cbKet)
        Me.GroupBox1.Controls.Add(Me.cbSatuan)
        Me.GroupBox1.Controls.Add(Me.cbJenis)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel8)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel7)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel6)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel5)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel4)
        Me.GroupBox1.Controls.Add(Me.txtStock)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel3)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel2)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.BunifuCustomLabel1)
        Me.GroupBox1.Controls.Add(Me.txtKode)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 255)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 251)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'cbStatus
        '
        Me.cbStatus.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"-- Pilih Status Barang --", "Baik", "Rusak", "Masih bisa digunakan"})
        Me.cbStatus.Location = New System.Drawing.Point(138, 223)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(373, 21)
        Me.cbStatus.TabIndex = 31
        '
        'cbTempat
        '
        Me.cbTempat.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTempat.FormattingEnabled = True
        Me.cbTempat.Items.AddRange(New Object() {"-- Pilih Tempat Barang --", "Sekre", "Camp", "Gudang"})
        Me.cbTempat.Location = New System.Drawing.Point(138, 195)
        Me.cbTempat.Name = "cbTempat"
        Me.cbTempat.Size = New System.Drawing.Size(373, 21)
        Me.cbTempat.TabIndex = 30
        '
        'cbKet
        '
        Me.cbKet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbKet.FormattingEnabled = True
        Me.cbKet.Items.AddRange(New Object() {"-- Pilih Keterangan --", "Dipinjam", "Tersedia"})
        Me.cbKet.Location = New System.Drawing.Point(138, 169)
        Me.cbKet.Name = "cbKet"
        Me.cbKet.Size = New System.Drawing.Size(373, 21)
        Me.cbKet.TabIndex = 29
        '
        'cbSatuan
        '
        Me.cbSatuan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSatuan.FormattingEnabled = True
        Me.cbSatuan.Items.AddRange(New Object() {"-- Pilih Satuan Barang --", "Pcs", "Kg", "Packs"})
        Me.cbSatuan.Location = New System.Drawing.Point(138, 142)
        Me.cbSatuan.Name = "cbSatuan"
        Me.cbSatuan.Size = New System.Drawing.Size(373, 21)
        Me.cbSatuan.TabIndex = 28
        '
        'cbJenis
        '
        Me.cbJenis.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbJenis.FormattingEnabled = True
        Me.cbJenis.Items.AddRange(New Object() {"-- Pilih Jenis Barang --", "Kayu", "Besi", "Aluminium", "Plastik", "Lain-lain"})
        Me.cbJenis.Location = New System.Drawing.Point(138, 85)
        Me.cbJenis.Name = "cbJenis"
        Me.cbJenis.Size = New System.Drawing.Size(373, 21)
        Me.cbJenis.TabIndex = 27
        '
        'BunifuCustomLabel8
        '
        Me.BunifuCustomLabel8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel8.AutoSize = True
        Me.BunifuCustomLabel8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel8.Location = New System.Drawing.Point(31, 196)
        Me.BunifuCustomLabel8.Name = "BunifuCustomLabel8"
        Me.BunifuCustomLabel8.Size = New System.Drawing.Size(61, 16)
        Me.BunifuCustomLabel8.TabIndex = 26
        Me.BunifuCustomLabel8.Text = "Tempat"
        '
        'BunifuCustomLabel7
        '
        Me.BunifuCustomLabel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel7.AutoSize = True
        Me.BunifuCustomLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel7.Location = New System.Drawing.Point(32, 170)
        Me.BunifuCustomLabel7.Name = "BunifuCustomLabel7"
        Me.BunifuCustomLabel7.Size = New System.Drawing.Size(87, 16)
        Me.BunifuCustomLabel7.TabIndex = 24
        Me.BunifuCustomLabel7.Text = "Keterangan"
        '
        'BunifuCustomLabel6
        '
        Me.BunifuCustomLabel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel6.AutoSize = True
        Me.BunifuCustomLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel6.Location = New System.Drawing.Point(31, 143)
        Me.BunifuCustomLabel6.Name = "BunifuCustomLabel6"
        Me.BunifuCustomLabel6.Size = New System.Drawing.Size(56, 16)
        Me.BunifuCustomLabel6.TabIndex = 22
        Me.BunifuCustomLabel6.Text = "Satuan"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(34, 224)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(51, 16)
        Me.BunifuCustomLabel5.TabIndex = 19
        Me.BunifuCustomLabel5.Text = "Status"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(30, 116)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(47, 16)
        Me.BunifuCustomLabel4.TabIndex = 18
        Me.BunifuCustomLabel4.Text = "Stock"
        '
        'txtStock
        '
        Me.txtStock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStock.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStock.HintForeColor = System.Drawing.Color.Empty
        Me.txtStock.HintText = ""
        Me.txtStock.isPassword = False
        Me.txtStock.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtStock.LineIdleColor = System.Drawing.Color.Gray
        Me.txtStock.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtStock.LineThickness = 3
        Me.txtStock.Location = New System.Drawing.Point(138, 99)
        Me.txtStock.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(368, 33)
        Me.txtStock.TabIndex = 17
        Me.txtStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(28, 86)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(99, 16)
        Me.BunifuCustomLabel3.TabIndex = 16
        Me.BunifuCustomLabel3.Text = "Jenis Barang"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(28, 56)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(103, 16)
        Me.BunifuCustomLabel2.TabIndex = 15
        Me.BunifuCustomLabel2.Text = "Nama Barang"
        '
        'txtNama
        '
        Me.txtNama.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNama.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNama.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNama.HintForeColor = System.Drawing.Color.Empty
        Me.txtNama.HintText = ""
        Me.txtNama.isPassword = False
        Me.txtNama.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtNama.LineIdleColor = System.Drawing.Color.Gray
        Me.txtNama.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtNama.LineThickness = 3
        Me.txtNama.Location = New System.Drawing.Point(138, 41)
        Me.txtNama.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(368, 33)
        Me.txtNama.TabIndex = 14
        Me.txtNama.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(28, 24)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(98, 16)
        Me.BunifuCustomLabel1.TabIndex = 13
        Me.BunifuCustomLabel1.Text = "Kode Barang"
        '
        'txtKode
        '
        Me.txtKode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKode.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtKode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtKode.HintForeColor = System.Drawing.Color.Empty
        Me.txtKode.HintText = ""
        Me.txtKode.isPassword = False
        Me.txtKode.LineFocusedColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKode.LineIdleColor = System.Drawing.Color.Gray
        Me.txtKode.LineMouseHoverColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtKode.LineThickness = 3
        Me.txtKode.Location = New System.Drawing.Point(138, 8)
        Me.txtKode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Size = New System.Drawing.Size(368, 33)
        Me.txtKode.TabIndex = 12
        Me.txtKode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnPrint
        '
        Me.btnPrint.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPrint.BorderRadius = 0
        Me.btnPrint.ButtonText = "Print"
        Me.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPrint.DisabledColor = System.Drawing.Color.Gray
        Me.btnPrint.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPrint.Iconimage = CType(resources.GetObject("btnPrint.Iconimage"), System.Drawing.Image)
        Me.btnPrint.Iconimage_right = Nothing
        Me.btnPrint.Iconimage_right_Selected = Nothing
        Me.btnPrint.Iconimage_Selected = Nothing
        Me.btnPrint.IconMarginLeft = 0
        Me.btnPrint.IconMarginRight = 0
        Me.btnPrint.IconRightVisible = True
        Me.btnPrint.IconRightZoom = 0R
        Me.btnPrint.IconVisible = True
        Me.btnPrint.IconZoom = 90.0R
        Me.btnPrint.IsTab = False
        Me.btnPrint.Location = New System.Drawing.Point(558, 458)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnPrint.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnPrint.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPrint.selected = False
        Me.btnPrint.Size = New System.Drawing.Size(135, 48)
        Me.btnPrint.TabIndex = 18
        Me.btnPrint.Text = "Print"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Textcolor = System.Drawing.Color.White
        Me.btnPrint.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Inventaris_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(705, 518)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Inventaris_Admin"
        Me.Text = "Inventaris"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DGBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Panel1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents btnDelete As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnEdit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCancel As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents DGBarang As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtStock As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNama As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtKode As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel6 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel8 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel7 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnPrint As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbTempat As ComboBox
    Friend WithEvents cbKet As ComboBox
    Friend WithEvents cbSatuan As ComboBox
    Friend WithEvents cbJenis As ComboBox
End Class
