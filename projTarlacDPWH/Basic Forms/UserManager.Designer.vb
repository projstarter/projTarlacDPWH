<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserManager
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        chkactiveonly = New CheckBox()
        txtfind = New TextBox()
        Label2 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel6 = New Panel()
        btndelete = New Button()
        btnsave = New Button()
        btnNew = New Button()
        chkactive = New CheckBox()
        cborole = New ComboBox()
        Label8 = New Label()
        txtpassword = New TextBox()
        txtusername = New TextBox()
        txtlastname = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtfirstname = New TextBox()
        Label3 = New Label()
        Panel5 = New Panel()
        Panel7 = New Panel()
        dtg = New DataGridView()
        Panel8 = New Panel()
        Timer1 = New Timer(components)
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        Panel7.SuspendLayout()
        CType(dtg, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(10, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(789, 50)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(7, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(201, 25)
        Label1.TabIndex = 1
        Label1.Text = "USER MANAGEMENT"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.AliceBlue
        Panel2.Controls.Add(chkactiveonly)
        Panel2.Controls.Add(txtfind)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(10, 67)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(498, 42)
        Panel2.TabIndex = 1
        ' 
        ' chkactiveonly
        ' 
        chkactiveonly.AutoSize = True
        chkactiveonly.Checked = True
        chkactiveonly.CheckState = CheckState.Checked
        chkactiveonly.Font = New Font("Segoe UI", 9F)
        chkactiveonly.ForeColor = SystemColors.HotTrack
        chkactiveonly.Location = New Point(321, 12)
        chkactiveonly.Name = "chkactiveonly"
        chkactiveonly.Size = New Size(140, 19)
        chkactiveonly.TabIndex = 16
        chkactiveonly.Text = "Show active user only"
        chkactiveonly.UseVisualStyleBackColor = True
        ' 
        ' txtfind
        ' 
        txtfind.Location = New Point(52, 9)
        txtfind.Name = "txtfind"
        txtfind.Size = New Size(263, 25)
        txtfind.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = SystemColors.HotTrack
        Label2.Location = New Point(8, 11)
        Label2.Name = "Label2"
        Label2.Size = New Size(38, 19)
        Label2.TabIndex = 3
        Label2.Text = "Find:"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.DodgerBlue
        Panel3.Dock = DockStyle.Top
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(498, 3)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.AliceBlue
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(chkactive)
        Panel4.Controls.Add(cborole)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(txtpassword)
        Panel4.Controls.Add(txtusername)
        Panel4.Controls.Add(txtlastname)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtfirstname)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(512, 67)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(287, 441)
        Panel4.TabIndex = 5
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(btndelete)
        Panel6.Controls.Add(btnsave)
        Panel6.Controls.Add(btnNew)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 391)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(287, 50)
        Panel6.TabIndex = 16
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.DodgerBlue
        btndelete.FlatAppearance.BorderSize = 0
        btndelete.FlatStyle = FlatStyle.Flat
        btndelete.Font = New Font("Tahoma", 9F)
        btndelete.ForeColor = Color.White
        btndelete.Location = New Point(194, 9)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(85, 31)
        btndelete.TabIndex = 16
        btndelete.Text = "&Delete"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.DodgerBlue
        btnsave.FlatAppearance.BorderSize = 0
        btnsave.FlatStyle = FlatStyle.Flat
        btnsave.Font = New Font("Tahoma", 9F)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(102, 9)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(85, 31)
        btnsave.TabIndex = 15
        btnsave.Text = "&Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnNew
        ' 
        btnNew.BackColor = Color.DodgerBlue
        btnNew.FlatAppearance.BorderSize = 0
        btnNew.FlatStyle = FlatStyle.Flat
        btnNew.Font = New Font("Tahoma", 9F)
        btnNew.ForeColor = Color.White
        btnNew.Location = New Point(10, 9)
        btnNew.Name = "btnNew"
        btnNew.Size = New Size(85, 31)
        btnNew.TabIndex = 14
        btnNew.Text = "New"
        btnNew.UseVisualStyleBackColor = False
        ' 
        ' chkactive
        ' 
        chkactive.AutoSize = True
        chkactive.ForeColor = SystemColors.HotTrack
        chkactive.Location = New Point(100, 245)
        chkactive.Name = "chkactive"
        chkactive.Size = New Size(65, 23)
        chkactive.TabIndex = 15
        chkactive.Text = "Active"
        chkactive.UseVisualStyleBackColor = True
        ' 
        ' cborole
        ' 
        cborole.DropDownStyle = ComboBoxStyle.DropDownList
        cborole.FlatStyle = FlatStyle.System
        cborole.FormattingEnabled = True
        cborole.Items.AddRange(New Object() {"User", "Administrator", "Super Administrator"})
        cborole.Location = New Point(98, 208)
        cborole.Name = "cborole"
        cborole.Size = New Size(176, 25)
        cborole.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(13, 211)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 19)
        Label8.TabIndex = 13
        Label8.Text = "Role"
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(98, 171)
        txtpassword.Name = "txtpassword"
        txtpassword.PasswordChar = "*"c
        txtpassword.Size = New Size(176, 25)
        txtpassword.TabIndex = 12
        ' 
        ' txtusername
        ' 
        txtusername.Location = New Point(98, 134)
        txtusername.Name = "txtusername"
        txtusername.Size = New Size(176, 25)
        txtusername.TabIndex = 11
        ' 
        ' txtlastname
        ' 
        txtlastname.Location = New Point(98, 97)
        txtlastname.Name = "txtlastname"
        txtlastname.Size = New Size(176, 25)
        txtlastname.TabIndex = 10
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.HotTrack
        Label7.Location = New Point(10, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 19)
        Label7.TabIndex = 8
        Label7.Text = "Password"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(10, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(71, 19)
        Label6.TabIndex = 7
        Label6.Text = "Username"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(10, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 19)
        Label5.TabIndex = 6
        Label5.Text = "Lastname"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(10, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 19)
        Label4.TabIndex = 5
        Label4.Text = "Firstname"
        ' 
        ' txtfirstname
        ' 
        txtfirstname.Location = New Point(98, 60)
        txtfirstname.Name = "txtfirstname"
        txtfirstname.Size = New Size(176, 25)
        txtfirstname.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(10, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(155, 19)
        Label3.TabIndex = 3
        Label3.Text = "CREATE/UPDATE USER"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DodgerBlue
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(287, 3)
        Panel5.TabIndex = 2
        ' 
        ' Panel7
        ' 
        Panel7.BackColor = Color.AliceBlue
        Panel7.Controls.Add(dtg)
        Panel7.Controls.Add(Panel8)
        Panel7.Location = New Point(10, 115)
        Panel7.Name = "Panel7"
        Panel7.Size = New Size(496, 393)
        Panel7.TabIndex = 7
        ' 
        ' dtg
        ' 
        dtg.AllowUserToAddRows = False
        dtg.AllowUserToDeleteRows = False
        dtg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells
        dtg.BackgroundColor = Color.White
        dtg.BorderStyle = BorderStyle.None
        dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtg.Dock = DockStyle.Fill
        dtg.GridColor = SystemColors.ScrollBar
        dtg.Location = New Point(0, 3)
        dtg.Name = "dtg"
        dtg.ReadOnly = True
        dtg.RowHeadersVisible = False
        dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dtg.Size = New Size(496, 390)
        dtg.TabIndex = 7
        ' 
        ' Panel8
        ' 
        Panel8.BackColor = Color.DodgerBlue
        Panel8.Dock = DockStyle.Top
        Panel8.Location = New Point(0, 0)
        Panel8.Name = "Panel8"
        Panel8.Size = New Size(496, 3)
        Panel8.TabIndex = 2
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' UserManager
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(810, 520)
        Controls.Add(Panel7)
        Controls.Add(Panel4)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 10F)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "UserManager"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Manager"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel7.ResumeLayout(False)
        CType(dtg, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtfind As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents chkactive As CheckBox
    Friend WithEvents cborole As ComboBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents dtg As DataGridView
    Friend WithEvents Panel8 As Panel
    Friend WithEvents btndelete As Button
    Friend WithEvents chkactiveonly As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
