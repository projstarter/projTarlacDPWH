<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        MenuStrip1 = New MenuStrip()
        ProgramToolStripMenuItem1 = New ToolStripMenuItem()
        NewEntryToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        DeleteToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        InfoToolStripMenuItem = New ToolStripMenuItem()
        ProgramToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        UserAccountsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator6 = New ToolStripSeparator()
        PermittedWeightPerAxleToolStripMenuItem = New ToolStripMenuItem()
        SerialNumberToolStripMenuItem = New ToolStripMenuItem()
        CalibrationNumberToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        lblUser = New ToolStripStatusLabel()
        lblPortStatus = New ToolStripStatusLabel()
        lblmode = New ToolStripStatusLabel()
        lblStatus = New ToolStripStatusLabel()
        Panel1 = New Panel()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label7 = New Label()
        PictureBox1 = New PictureBox()
        ImageList2 = New ImageList(components)
        Panel2 = New Panel()
        Panel4 = New Panel()
        dgtransaction = New DataGridView()
        Panel11 = New Panel()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        txtsearch = New ToolStripTextBox()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripButton1 = New ToolStripButton()
        Panel5 = New Panel()
        Panel15 = New Panel()
        Button3 = New Button()
        ImageList1 = New ImageList(components)
        Panel6 = New Panel()
        Button1 = New Button()
        Panel14 = New Panel()
        Panel3 = New Panel()
        Panel12 = New Panel()
        Label3 = New Label()
        dtpto = New DateTimePicker()
        dtpfrom = New DateTimePicker()
        Label2 = New Label()
        Label1 = New Label()
        Panel7 = New Panel()
        lblindicator = New Label()
        txtmaxweight = New TextBox()
        Label4 = New Label()
        Panel9 = New Panel()
        Label5 = New Label()
        btntoggle = New Button()
        lbldisplaymode = New Label()
        Panel10 = New Panel()
        chkenableSaveandPrint = New CheckBox()
        Button2 = New Button()
        btnsaveandprint = New Button()
        btnprint = New Button()
        btnsave = New Button()
        Panel13 = New Panel()
        dtgReadings = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        manualCapture = New DataGridViewButtonColumn()
        txtsn = New TextBox()
        Label12 = New Label()
        txtdrivername = New TextBox()
        txtplateno = New TextBox()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        cbocode = New ComboBox()
        txtcodedescription = New TextBox()
        Label8 = New Label()
        Label6 = New Label()
        Panel8 = New Panel()
        lblreading = New Label()
        Timer1 = New Timer(components)
        SIMULATION = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        CType(dgtransaction, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel15.SuspendLayout()
        Panel6.SuspendLayout()
        Panel3.SuspendLayout()
        Panel7.SuspendLayout()
        Panel9.SuspendLayout()
        Panel10.SuspendLayout()
        CType(dtgReadings, ComponentModel.ISupportInitialize).BeginInit()
        Panel8.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("Tahoma", 9.0F)
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ProgramToolStripMenuItem1, InfoToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(4, 1, 0, 1)
        MenuStrip1.Size = New Size(1296, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ProgramToolStripMenuItem1
        ' 
        ProgramToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {NewEntryToolStripMenuItem, ToolStripSeparator3, ToolStripMenuItem1, ToolStripSeparator4, DeleteToolStripMenuItem, ToolStripSeparator5, ExitToolStripMenuItem})
        ProgramToolStripMenuItem1.Name = "ProgramToolStripMenuItem1"
        ProgramToolStripMenuItem1.Size = New Size(78, 22)
        ProgramToolStripMenuItem1.Text = "Hot Key(s)"
        ' 
        ' NewEntryToolStripMenuItem
        ' 
        NewEntryToolStripMenuItem.Image = CType(resources.GetObject("NewEntryToolStripMenuItem.Image"), Image)
        NewEntryToolStripMenuItem.Name = "NewEntryToolStripMenuItem"
        NewEntryToolStripMenuItem.ShortcutKeys = Keys.F3
        NewEntryToolStripMenuItem.Size = New Size(160, 30)
        NewEntryToolStripMenuItem.Text = "New Entry"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(157, 6)
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), Image)
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.ShortcutKeys = Keys.F5
        ToolStripMenuItem1.Size = New Size(160, 30)
        ToolStripMenuItem1.Text = "Refresh"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(157, 6)
        ' 
        ' DeleteToolStripMenuItem
        ' 
        DeleteToolStripMenuItem.Image = CType(resources.GetObject("DeleteToolStripMenuItem.Image"), Image)
        DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        DeleteToolStripMenuItem.ShortcutKeys = Keys.Delete
        DeleteToolStripMenuItem.Size = New Size(160, 30)
        DeleteToolStripMenuItem.Text = "Delete"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(157, 6)
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(160, 30)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' InfoToolStripMenuItem
        ' 
        InfoToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ProgramToolStripMenuItem, ToolStripSeparator1, UserAccountsToolStripMenuItem, ToolStripSeparator6, PermittedWeightPerAxleToolStripMenuItem, SerialNumberToolStripMenuItem, CalibrationNumberToolStripMenuItem})
        InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        InfoToolStripMenuItem.Size = New Size(59, 22)
        InfoToolStripMenuItem.Text = "System"
        ' 
        ' ProgramToolStripMenuItem
        ' 
        ProgramToolStripMenuItem.Image = CType(resources.GetObject("ProgramToolStripMenuItem.Image"), Image)
        ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        ProgramToolStripMenuItem.Size = New Size(229, 30)
        ProgramToolStripMenuItem.Text = "Port Configuration"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(226, 6)
        ' 
        ' UserAccountsToolStripMenuItem
        ' 
        UserAccountsToolStripMenuItem.Image = CType(resources.GetObject("UserAccountsToolStripMenuItem.Image"), Image)
        UserAccountsToolStripMenuItem.Name = "UserAccountsToolStripMenuItem"
        UserAccountsToolStripMenuItem.Size = New Size(229, 30)
        UserAccountsToolStripMenuItem.Text = "User Accounts"
        ' 
        ' ToolStripSeparator6
        ' 
        ToolStripSeparator6.Name = "ToolStripSeparator6"
        ToolStripSeparator6.Size = New Size(226, 6)
        ' 
        ' PermittedWeightPerAxleToolStripMenuItem
        ' 
        PermittedWeightPerAxleToolStripMenuItem.Image = CType(resources.GetObject("PermittedWeightPerAxleToolStripMenuItem.Image"), Image)
        PermittedWeightPerAxleToolStripMenuItem.Name = "PermittedWeightPerAxleToolStripMenuItem"
        PermittedWeightPerAxleToolStripMenuItem.Size = New Size(229, 30)
        PermittedWeightPerAxleToolStripMenuItem.Text = "Permitted Weight per Axle"
        ' 
        ' SerialNumberToolStripMenuItem
        ' 
        SerialNumberToolStripMenuItem.Image = CType(resources.GetObject("SerialNumberToolStripMenuItem.Image"), Image)
        SerialNumberToolStripMenuItem.Name = "SerialNumberToolStripMenuItem"
        SerialNumberToolStripMenuItem.Size = New Size(229, 30)
        SerialNumberToolStripMenuItem.Text = "Serial Number"
        ' 
        ' CalibrationNumberToolStripMenuItem
        ' 
        CalibrationNumberToolStripMenuItem.Image = CType(resources.GetObject("CalibrationNumberToolStripMenuItem.Image"), Image)
        CalibrationNumberToolStripMenuItem.Name = "CalibrationNumberToolStripMenuItem"
        CalibrationNumberToolStripMenuItem.Size = New Size(229, 30)
        CalibrationNumberToolStripMenuItem.Text = "Calibration Number"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.Font = New Font("Segoe UI", 10.0F)
        StatusStrip1.ImageScalingSize = New Size(24, 24)
        StatusStrip1.Items.AddRange(New ToolStripItem() {lblUser, lblPortStatus, lblmode, lblStatus})
        StatusStrip1.Location = New Point(0, 681)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Padding = New Padding(1, 0, 10, 0)
        StatusStrip1.Size = New Size(1296, 28)
        StatusStrip1.TabIndex = 2
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' lblUser
        ' 
        lblUser.BorderSides = ToolStripStatusLabelBorderSides.Right
        lblUser.Name = "lblUser"
        lblUser.Size = New Size(144, 23)
        lblUser.Text = "ToolStripStatusLabel1"
        ' 
        ' lblPortStatus
        ' 
        lblPortStatus.BorderSides = ToolStripStatusLabelBorderSides.Right
        lblPortStatus.Name = "lblPortStatus"
        lblPortStatus.Size = New Size(144, 23)
        lblPortStatus.Text = "ToolStripStatusLabel1"
        ' 
        ' lblmode
        ' 
        lblmode.BorderSides = ToolStripStatusLabelBorderSides.Right
        lblmode.Name = "lblmode"
        lblmode.Size = New Size(95, 23)
        lblmode.Text = "W-Mode : {0}"
        ' 
        ' lblStatus
        ' 
        lblStatus.Name = "lblStatus"
        lblStatus.Size = New Size(140, 23)
        lblStatus.Text = "ToolStripStatusLabel1"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Label15)
        Panel1.Controls.Add(Label14)
        Panel1.Controls.Add(Label13)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 24)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1296, 103)
        Panel1.TabIndex = 3
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Tahoma", 9.0F, FontStyle.Bold)
        Label15.ForeColor = Color.Navy
        Label15.Location = New Point(117, 69)
        Label15.Margin = New Padding(2, 0, 2, 0)
        Label15.Name = "Label15"
        Label15.Size = New Size(168, 14)
        Label15.TabIndex = 9
        Label15.Text = "DOLORES CAPAS, TARLAC"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Tahoma", 9.0F, FontStyle.Bold)
        Label14.ForeColor = Color.Navy
        Label14.Location = New Point(117, 53)
        Label14.Margin = New Padding(2, 0, 2, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(197, 14)
        Label14.TabIndex = 8
        Label14.Text = "CAPAS WEIGHBRIDGE STATION"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Tahoma", 9.0F, FontStyle.Bold)
        Label13.ForeColor = Color.Navy
        Label13.Location = New Point(117, 37)
        Label13.Margin = New Padding(2, 0, 2, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(276, 14)
        Label13.TabIndex = 7
        Label13.Text = "TARLAC 2ND DISTRICT ENGINEERING OFFICE"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Tahoma", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.Navy
        Label7.Location = New Point(117, 13)
        Label7.Margin = New Padding(2, 0, 2, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(420, 19)
        Label7.TabIndex = 6
        Label7.Text = "DEPARTMENT OF PUBLIC WORKS AND HIGHWAYS"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 7)
        PictureBox1.Margin = New Padding(2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(101, 82)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' ImageList2
        ' 
        ImageList2.ColorDepth = ColorDepth.Depth32Bit
        ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), ImageListStreamer)
        ImageList2.TransparentColor = Color.Transparent
        ImageList2.Images.SetKeyName(0, "dynamic.png")
        ImageList2.Images.SetKeyName(1, "static.png")
        ImageList2.Images.SetKeyName(2, "start.png")
        ImageList2.Images.SetKeyName(3, "stop.png")
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(ToolStrip1)
        Panel2.Controls.Add(Panel5)
        Panel2.Controls.Add(Panel3)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 127)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(604, 554)
        Panel2.TabIndex = 6
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(dgtransaction)
        Panel4.Controls.Add(Panel11)
        Panel4.Dock = DockStyle.Fill
        Panel4.Font = New Font("Tahoma", 10.0F)
        Panel4.Location = New Point(0, 117)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(604, 390)
        Panel4.TabIndex = 9
        ' 
        ' dgtransaction
        ' 
        dgtransaction.AllowUserToAddRows = False
        dgtransaction.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = Color.Azure
        dgtransaction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgtransaction.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dgtransaction.BackgroundColor = SystemColors.ButtonHighlight
        dgtransaction.BorderStyle = BorderStyle.None
        dgtransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgtransaction.Dock = DockStyle.Fill
        dgtransaction.GridColor = SystemColors.ButtonFace
        dgtransaction.Location = New Point(0, 3)
        dgtransaction.Margin = New Padding(2)
        dgtransaction.Name = "dgtransaction"
        dgtransaction.RowHeadersVisible = False
        dgtransaction.RowHeadersWidth = 62
        dgtransaction.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgtransaction.Size = New Size(604, 387)
        dgtransaction.TabIndex = 12
        ' 
        ' Panel11
        ' 
        Panel11.BackColor = Color.DodgerBlue
        Panel11.Dock = DockStyle.Top
        Panel11.Location = New Point(0, 0)
        Panel11.Name = "Panel11"
        Panel11.Size = New Size(604, 3)
        Panel11.TabIndex = 11
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.Font = New Font("Tahoma", 9.0F)
        ToolStrip1.GripStyle = ToolStripGripStyle.Hidden
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, txtsearch, ToolStripSeparator2, ToolStripButton1})
        ToolStrip1.Location = New Point(0, 69)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Padding = New Padding(0, 0, 2, 0)
        ToolStrip1.RightToLeft = RightToLeft.No
        ToolStrip1.Size = New Size(604, 48)
        ToolStrip1.TabIndex = 8
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Font = New Font("Tahoma", 10.0F)
        ToolStripLabel1.Margin = New Padding(10, 1, 0, 2)
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(33, 45)
        ToolStripLabel1.Text = "Find"
        ToolStripLabel1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtsearch
        ' 
        txtsearch.AutoSize = False
        txtsearch.BorderStyle = BorderStyle.FixedSingle
        txtsearch.Font = New Font("Segoe UI", 10.0F)
        txtsearch.Margin = New Padding(7)
        txtsearch.Name = "txtsearch"
        txtsearch.RightToLeft = RightToLeft.No
        txtsearch.Size = New Size(300, 25)
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 48)
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), Image)
        ToolStripButton1.ImageAlign = ContentAlignment.MiddleLeft
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Margin = New Padding(5)
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Padding = New Padding(10, 0, 10, 10)
        ToolStripButton1.Size = New Size(80, 38)
        ToolStripButton1.Text = "  Refresh"
        ToolStripButton1.TextAlign = ContentAlignment.MiddleRight
        ToolStripButton1.TextImageRelation = TextImageRelation.Overlay
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.AliceBlue
        Panel5.Controls.Add(Panel15)
        Panel5.Controls.Add(Panel6)
        Panel5.Controls.Add(Panel14)
        Panel5.Dock = DockStyle.Bottom
        Panel5.Font = New Font("Tahoma", 9.0F)
        Panel5.Location = New Point(0, 507)
        Panel5.Margin = New Padding(2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(604, 47)
        Panel5.TabIndex = 6
        ' 
        ' Panel15
        ' 
        Panel15.Controls.Add(Button3)
        Panel15.Dock = DockStyle.Left
        Panel15.Location = New Point(0, 3)
        Panel15.Margin = New Padding(2)
        Panel15.Name = "Panel15"
        Panel15.Size = New Size(155, 44)
        Panel15.TabIndex = 9
        ' 
        ' Button3
        ' 
        Button3.Cursor = Cursors.Hand
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Tahoma", 9.0F)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.ImageKey = "delete.png"
        Button3.ImageList = ImageList1
        Button3.Location = New Point(11, 9)
        Button3.Margin = New Padding(2)
        Button3.Name = "Button3"
        Button3.Size = New Size(122, 25)
        Button3.TabIndex = 0
        Button3.Text = "Delete Record "
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth32Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "refresh.png")
        ImageList1.Images.SetKeyName(1, "dynamic.png")
        ImageList1.Images.SetKeyName(2, "static.png")
        ImageList1.Images.SetKeyName(3, "static.png")
        ImageList1.Images.SetKeyName(4, "start.png")
        ImageList1.Images.SetKeyName(5, "stop.png")
        ImageList1.Images.SetKeyName(6, "print1.png")
        ImageList1.Images.SetKeyName(7, "saveandprint.png")
        ImageList1.Images.SetKeyName(8, "save.png")
        ImageList1.Images.SetKeyName(9, "new.png")
        ImageList1.Images.SetKeyName(10, "delete.png")
        ImageList1.Images.SetKeyName(11, "excel.png")
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(Button1)
        Panel6.Dock = DockStyle.Right
        Panel6.Location = New Point(449, 3)
        Panel6.Margin = New Padding(2)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(155, 44)
        Panel6.TabIndex = 8
        ' 
        ' Button1
        ' 
        Button1.Cursor = Cursors.Hand
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Tahoma", 9.0F)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.ImageKey = "excel.png"
        Button1.ImageList = ImageList1
        Button1.Location = New Point(11, 9)
        Button1.Margin = New Padding(2)
        Button1.Name = "Button1"
        Button1.Size = New Size(127, 25)
        Button1.TabIndex = 0
        Button1.Text = "Export to Excel"
        Button1.TextAlign = ContentAlignment.MiddleRight
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel14
        ' 
        Panel14.BackColor = Color.DodgerBlue
        Panel14.Dock = DockStyle.Top
        Panel14.Location = New Point(0, 0)
        Panel14.Name = "Panel14"
        Panel14.Size = New Size(604, 3)
        Panel14.TabIndex = 7
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.AliceBlue
        Panel3.Controls.Add(Panel12)
        Panel3.Controls.Add(Label3)
        Panel3.Controls.Add(dtpto)
        Panel3.Controls.Add(dtpfrom)
        Panel3.Controls.Add(Label2)
        Panel3.Controls.Add(Label1)
        Panel3.Dock = DockStyle.Top
        Panel3.Font = New Font("Segoe UI", 10.0F)
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(604, 69)
        Panel3.TabIndex = 4
        ' 
        ' Panel12
        ' 
        Panel12.BackColor = Color.DodgerBlue
        Panel12.Dock = DockStyle.Bottom
        Panel12.Location = New Point(0, 66)
        Panel12.Name = "Panel12"
        Panel12.Size = New Size(604, 3)
        Panel12.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F)
        Label3.Location = New Point(248, 38)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 17)
        Label3.TabIndex = 4
        Label3.Text = "to"
        ' 
        ' dtpto
        ' 
        dtpto.Format = DateTimePickerFormat.Short
        dtpto.Location = New Point(274, 34)
        dtpto.Margin = New Padding(2)
        dtpto.Name = "dtpto"
        dtpto.Size = New Size(129, 25)
        dtpto.TabIndex = 3
        ' 
        ' dtpfrom
        ' 
        dtpfrom.Format = DateTimePickerFormat.Short
        dtpfrom.Location = New Point(113, 34)
        dtpfrom.Margin = New Padding(2)
        dtpfrom.Name = "dtpfrom"
        dtpfrom.Size = New Size(129, 25)
        dtpfrom.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F)
        Label2.Location = New Point(12, 38)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(106, 17)
        Label2.TabIndex = 1
        Label2.Text = "Date Coverage : "
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 10.0F, FontStyle.Bold)
        Label1.ForeColor = Color.Navy
        Label1.Location = New Point(8, 10)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(136, 17)
        Label1.TabIndex = 0
        Label1.Text = "TRANSACTION(S)"
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.AliceBlue
        Panel7.BorderStyle = BorderStyle.Fixed3D
        Panel7.Controls.Add(lblindicator)
        Panel7.Controls.Add(txtmaxweight)
        Panel7.Controls.Add(Label4)
        Panel7.Controls.Add(Panel9)
        Panel7.Controls.Add(Panel10)
        Panel7.Controls.Add(dtgReadings)
        Panel7.Controls.Add(txtsn)
        Panel7.Controls.Add(Label12)
        Panel7.Controls.Add(txtdrivername)
        Panel7.Controls.Add(txtplateno)
        Panel7.Controls.Add(Label11)
        Panel7.Controls.Add(Label10)
        Panel7.Controls.Add(Label9)
        Panel7.Controls.Add(cbocode)
        Panel7.Controls.Add(txtcodedescription)
        Panel7.Controls.Add(Label8)
        Panel7.Controls.Add(Label6)
        Panel7.Controls.Add(Panel8)
        Panel7.Dock = DockStyle.Right
        Panel7.Font = New Font("Tahoma", 9.0F)
        Panel7.Location = New Point(604, 127)
        Panel7.Margin = New Padding(2)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(692, 554)
        Panel7.TabIndex = 2
        ' 
        ' lblindicator
        ' 
        lblindicator.AutoSize = True
        lblindicator.Font = New Font("Calibri", 12.0F, FontStyle.Bold)
        lblindicator.ForeColor = Color.Blue
        lblindicator.Location = New Point(407, 492)
        lblindicator.Margin = New Padding(2, 0, 2, 0)
        lblindicator.Name = "lblindicator"
        lblindicator.Size = New Size(88, 19)
        lblindicator.TabIndex = 31
        lblindicator.Text = "Completed!"
        lblindicator.TextAlign = ContentAlignment.MiddleLeft
        lblindicator.Visible = False
        ' 
        ' txtmaxweight
        ' 
        txtmaxweight.BackColor = Color.FloralWhite
        txtmaxweight.Font = New Font("Tahoma", 10.0F)
        txtmaxweight.Location = New Point(407, 371)
        txtmaxweight.Margin = New Padding(2)
        txtmaxweight.Name = "txtmaxweight"
        txtmaxweight.ReadOnly = True
        txtmaxweight.Size = New Size(260, 24)
        txtmaxweight.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9.75F)
        Label4.Location = New Point(310, 374)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(84, 17)
        Label4.TabIndex = 27
        Label4.Text = "Max Weight :"
        Label4.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel9
        ' 
        Panel9.BackColor = Color.RoyalBlue
        Panel9.Controls.Add(Label5)
        Panel9.Controls.Add(btntoggle)
        Panel9.Controls.Add(lbldisplaymode)
        Panel9.Dock = DockStyle.Top
        Panel9.Location = New Point(0, 124)
        Panel9.Name = "Panel9"
        Panel9.Size = New Size(688, 47)
        Panel9.TabIndex = 24
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = Color.White
        Label5.Location = New Point(391, 14)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(134, 17)
        Label5.TabIndex = 23
        Label5.Text = "CAPTURE MODE : "
        Label5.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' btntoggle
        ' 
        btntoggle.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btntoggle.AutoSize = True
        btntoggle.BackColor = Color.White
        btntoggle.Cursor = Cursors.Hand
        btntoggle.FlatAppearance.BorderSize = 0
        btntoggle.ImageKey = "static.png"
        btntoggle.ImageList = ImageList2
        btntoggle.Location = New Point(631, 4)
        btntoggle.Margin = New Padding(2)
        btntoggle.Name = "btntoggle"
        btntoggle.Size = New Size(43, 39)
        btntoggle.TabIndex = 21
        btntoggle.TextAlign = ContentAlignment.MiddleLeft
        btntoggle.UseVisualStyleBackColor = False
        ' 
        ' lbldisplaymode
        ' 
        lbldisplaymode.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lbldisplaymode.Font = New Font("Tahoma", 10.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        lbldisplaymode.ForeColor = Color.Azure
        lbldisplaymode.Location = New Point(525, 8)
        lbldisplaymode.Margin = New Padding(2, 0, 2, 0)
        lbldisplaymode.Name = "lbldisplaymode"
        lbldisplaymode.Size = New Size(92, 29)
        lbldisplaymode.TabIndex = 22
        lbldisplaymode.Text = "STATIC"
        lbldisplaymode.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel10
        ' 
        Panel10.BackColor = Color.AliceBlue
        Panel10.Controls.Add(chkenableSaveandPrint)
        Panel10.Controls.Add(Button2)
        Panel10.Controls.Add(btnsaveandprint)
        Panel10.Controls.Add(btnprint)
        Panel10.Controls.Add(btnsave)
        Panel10.Controls.Add(Panel13)
        Panel10.Dock = DockStyle.Bottom
        Panel10.Font = New Font("Tahoma", 9.0F)
        Panel10.Location = New Point(0, 441)
        Panel10.Margin = New Padding(2)
        Panel10.Name = "Panel10"
        Panel10.Size = New Size(688, 109)
        Panel10.TabIndex = 21
        ' 
        ' chkenableSaveandPrint
        ' 
        chkenableSaveandPrint.AutoSize = True
        chkenableSaveandPrint.Font = New Font("Tahoma", 9.0F, FontStyle.Underline)
        chkenableSaveandPrint.ForeColor = Color.FromArgb(CByte(0), CByte(0), CByte(192))
        chkenableSaveandPrint.Location = New Point(125, 83)
        chkenableSaveandPrint.Name = "chkenableSaveandPrint"
        chkenableSaveandPrint.Size = New Size(446, 18)
        chkenableSaveandPrint.TabIndex = 20
        chkenableSaveandPrint.Text = "Enable Save and Print when STATIC mode, otherwise SAVE only by default."
        chkenableSaveandPrint.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Ivory
        Button2.Cursor = Cursors.Hand
        Button2.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Tahoma", 9.0F)
        Button2.ImageAlign = ContentAlignment.TopCenter
        Button2.ImageKey = "new.png"
        Button2.ImageList = ImageList1
        Button2.Location = New Point(167, 9)
        Button2.Margin = New Padding(2)
        Button2.Name = "Button2"
        Button2.Padding = New Padding(0, 5, 0, 5)
        Button2.Size = New Size(80, 68)
        Button2.TabIndex = 19
        Button2.Text = "New Entry"
        Button2.TextAlign = ContentAlignment.BottomCenter
        Button2.UseVisualStyleBackColor = False
        ' 
        ' btnsaveandprint
        ' 
        btnsaveandprint.BackColor = Color.Ivory
        btnsaveandprint.Cursor = Cursors.Hand
        btnsaveandprint.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnsaveandprint.FlatStyle = FlatStyle.Flat
        btnsaveandprint.Font = New Font("Tahoma", 9.0F)
        btnsaveandprint.ImageAlign = ContentAlignment.TopCenter
        btnsaveandprint.ImageKey = "saveandprint.png"
        btnsaveandprint.ImageList = ImageList1
        btnsaveandprint.Location = New Point(337, 9)
        btnsaveandprint.Margin = New Padding(2)
        btnsaveandprint.Name = "btnsaveandprint"
        btnsaveandprint.Padding = New Padding(0, 5, 0, 5)
        btnsaveandprint.Size = New Size(100, 68)
        btnsaveandprint.TabIndex = 18
        btnsaveandprint.Text = "Save and Print"
        btnsaveandprint.TextAlign = ContentAlignment.BottomCenter
        btnsaveandprint.UseVisualStyleBackColor = False
        ' 
        ' btnprint
        ' 
        btnprint.BackColor = Color.Ivory
        btnprint.Cursor = Cursors.Hand
        btnprint.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnprint.FlatStyle = FlatStyle.Flat
        btnprint.Font = New Font("Tahoma", 9.0F)
        btnprint.ImageAlign = ContentAlignment.TopCenter
        btnprint.ImageKey = "print1.png"
        btnprint.ImageList = ImageList1
        btnprint.Location = New Point(442, 9)
        btnprint.Margin = New Padding(2)
        btnprint.Name = "btnprint"
        btnprint.Padding = New Padding(0, 5, 0, 5)
        btnprint.Size = New Size(80, 68)
        btnprint.TabIndex = 17
        btnprint.Text = "Print"
        btnprint.TextAlign = ContentAlignment.BottomCenter
        btnprint.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.Ivory
        btnsave.Cursor = Cursors.Hand
        btnsave.FlatAppearance.BorderColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        btnsave.FlatStyle = FlatStyle.Flat
        btnsave.Font = New Font("Tahoma", 9.0F)
        btnsave.ImageAlign = ContentAlignment.TopCenter
        btnsave.ImageKey = "save.png"
        btnsave.ImageList = ImageList1
        btnsave.Location = New Point(252, 9)
        btnsave.Margin = New Padding(2)
        btnsave.Name = "btnsave"
        btnsave.Padding = New Padding(0, 5, 0, 5)
        btnsave.Size = New Size(80, 68)
        btnsave.TabIndex = 16
        btnsave.Text = "Save"
        btnsave.TextAlign = ContentAlignment.BottomCenter
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' Panel13
        ' 
        Panel13.BackColor = Color.DodgerBlue
        Panel13.Dock = DockStyle.Top
        Panel13.Location = New Point(0, 0)
        Panel13.Name = "Panel13"
        Panel13.Size = New Size(688, 3)
        Panel13.TabIndex = 10
        ' 
        ' dtgReadings
        ' 
        dtgReadings.AllowUserToAddRows = False
        dtgReadings.AllowUserToDeleteRows = False
        dtgReadings.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        dtgReadings.BackgroundColor = SystemColors.ButtonHighlight
        dtgReadings.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical
        dtgReadings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgReadings.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1, DataGridViewTextBoxColumn2, manualCapture})
        dtgReadings.GridColor = Color.White
        dtgReadings.Location = New Point(13, 230)
        dtgReadings.Margin = New Padding(2)
        dtgReadings.Name = "dtgReadings"
        dtgReadings.ReadOnly = True
        dtgReadings.RowHeadersVisible = False
        dtgReadings.RowHeadersWidth = 62
        dtgReadings.Size = New Size(288, 209)
        dtgReadings.TabIndex = 4
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Particular(s)"
        DataGridViewTextBoxColumn1.MinimumWidth = 8
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.ReadOnly = True
        DataGridViewTextBoxColumn1.Width = 180
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Weight"
        DataGridViewTextBoxColumn2.MinimumWidth = 8
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.ReadOnly = True
        DataGridViewTextBoxColumn2.Width = 120
        ' 
        ' manualCapture
        ' 
        manualCapture.HeaderText = ""
        manualCapture.MinimumWidth = 8
        manualCapture.Name = "manualCapture"
        manualCapture.ReadOnly = True
        manualCapture.Width = 80
        ' 
        ' txtsn
        ' 
        txtsn.Font = New Font("Tahoma", 10.0F)
        txtsn.Location = New Point(407, 227)
        txtsn.Margin = New Padding(2)
        txtsn.Name = "txtsn"
        txtsn.ReadOnly = True
        txtsn.Size = New Size(260, 24)
        txtsn.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9.75F)
        Label12.Location = New Point(357, 230)
        Label12.Margin = New Padding(2, 0, 2, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(37, 17)
        Label12.TabIndex = 17
        Label12.Text = "S/N :"
        Label12.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' txtdrivername
        ' 
        txtdrivername.Font = New Font("Tahoma", 10.0F)
        txtdrivername.Location = New Point(407, 419)
        txtdrivername.Margin = New Padding(2)
        txtdrivername.Name = "txtdrivername"
        txtdrivername.Size = New Size(260, 24)
        txtdrivername.TabIndex = 2
        ' 
        ' txtplateno
        ' 
        txtplateno.Font = New Font("Tahoma", 10.0F)
        txtplateno.Location = New Point(407, 452)
        txtplateno.Margin = New Padding(2)
        txtplateno.Name = "txtplateno"
        txtplateno.Size = New Size(260, 24)
        txtplateno.TabIndex = 3
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 9.75F)
        Label11.Location = New Point(326, 455)
        Label11.Margin = New Padding(2, 0, 2, 0)
        Label11.Name = "Label11"
        Label11.Size = New Size(68, 17)
        Label11.TabIndex = 14
        Label11.Text = "Plate No. :"
        Label11.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 9.75F)
        Label10.Location = New Point(305, 422)
        Label10.Margin = New Padding(2, 0, 2, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 17)
        Label10.TabIndex = 13
        Label10.Text = "Driver Name :"
        Label10.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 9.75F)
        Label9.Location = New Point(313, 301)
        Label9.Margin = New Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(81, 17)
        Label9.TabIndex = 12
        Label9.Text = "Description :"
        Label9.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' cbocode
        ' 
        cbocode.DropDownStyle = ComboBoxStyle.DropDownList
        cbocode.Font = New Font("Tahoma", 10.0F)
        cbocode.FormattingEnabled = True
        cbocode.Location = New Point(407, 264)
        cbocode.Margin = New Padding(2)
        cbocode.Name = "cbocode"
        cbocode.Size = New Size(260, 24)
        cbocode.TabIndex = 1
        ' 
        ' txtcodedescription
        ' 
        txtcodedescription.BackColor = Color.FloralWhite
        txtcodedescription.Font = New Font("Tahoma", 10.0F)
        txtcodedescription.Location = New Point(407, 302)
        txtcodedescription.Margin = New Padding(2)
        txtcodedescription.Multiline = True
        txtcodedescription.Name = "txtcodedescription"
        txtcodedescription.ReadOnly = True
        txtcodedescription.Size = New Size(260, 59)
        txtcodedescription.TabIndex = 10
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 9.75F)
        Label8.Location = New Point(348, 266)
        Label8.Margin = New Padding(2, 0, 2, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(46, 17)
        Label8.TabIndex = 9
        Label8.Text = "Code :"
        Label8.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Tahoma", 10.0F, FontStyle.Bold)
        Label6.ForeColor = Color.Navy
        Label6.Location = New Point(13, 185)
        Label6.Margin = New Padding(2, 0, 2, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(199, 17)
        Label6.TabIndex = 8
        Label6.Text = "DETAILS OF THE WEIGHIN"
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.White
        Panel8.Controls.Add(lblreading)
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 0)
        Panel8.Margin = New Padding(2)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(688, 124)
        Panel8.TabIndex = 7
        ' 
        ' lblreading
        ' 
        lblreading.BackColor = Color.Black
        lblreading.Font = New Font("Segoe UI", 60.0F)
        lblreading.ForeColor = Color.Lime
        lblreading.Location = New Point(6, 5)
        lblreading.Margin = New Padding(2, 0, 2, 0)
        lblreading.Name = "lblreading"
        lblreading.Size = New Size(675, 114)
        lblreading.TabIndex = 0
        lblreading.Text = "5"
        lblreading.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' SIMULATION
        ' 
        SIMULATION.Interval = 1000
        ' 
        ' frmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1296, 709)
        Controls.Add(Panel2)
        Controls.Add(Panel7)
        Controls.Add(Panel1)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        Name = "frmMain"
        Text = "JAAM Weigh Scale System"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        CType(dgtransaction, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel15.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel7.ResumeLayout(False)
        Panel7.PerformLayout()
        Panel9.ResumeLayout(False)
        Panel9.PerformLayout()
        Panel10.ResumeLayout(False)
        Panel10.PerformLayout()
        CType(dtgReadings, ComponentModel.ISupportInitialize).EndInit()
        Panel8.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserAccountsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblUser As ToolStripStatusLabel
    Friend WithEvents lblPortStatus As ToolStripStatusLabel
    Friend WithEvents lblStatus As ToolStripStatusLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpto As DateTimePicker
    Friend WithEvents dtpfrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblreading As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents txtdrivername As TextBox
    Friend WithEvents txtplateno As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cbocode As ComboBox
    Friend WithEvents txtcodedescription As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtsn As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dtgReadings As DataGridView
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents txtsearch As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents lblmode As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel4 As Panel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents manualCapture As DataGridViewButtonColumn
    Friend WithEvents Panel10 As Panel
    Friend WithEvents dgtransaction As DataGridView
    Friend WithEvents Panel11 As Panel
    Friend WithEvents Panel12 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel14 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents btntoggle As Button
    Friend WithEvents lbldisplaymode As Label
    Friend WithEvents Panel13 As Panel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Button2 As Button
    Friend WithEvents btnsaveandprint As Button
    Friend WithEvents btnprint As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents Panel15 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents SIMULATION As Timer
    Friend WithEvents txtmaxweight As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblindicator As Label
    Friend WithEvents PermittedWeightPerAxleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chkenableSaveandPrint As CheckBox
    Friend WithEvents ProgramToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents NewEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents SerialNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalibrationNumberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
