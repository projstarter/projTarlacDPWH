<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PortConfiguration
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
        Panel1 = New Panel()
        Label1 = New Label()
        Panel4 = New Panel()
        Panel6 = New Panel()
        btnexit = New Button()
        btnsave = New Button()
        cboportname = New ComboBox()
        Label8 = New Label()
        txtstopbits = New TextBox()
        txtbaudrate = New TextBox()
        txtreadtimeout = New TextBox()
        Label7 = New Label()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtdatabits = New TextBox()
        Label3 = New Label()
        Panel5 = New Panel()
        Panel1.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.AliceBlue
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(10, 11)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(453, 50)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.HotTrack
        Label1.Location = New Point(7, 11)
        Label1.Name = "Label1"
        Label1.Size = New Size(221, 25)
        Label1.TabIndex = 1
        Label1.Text = "PORT CONFIGURATION"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.AliceBlue
        Panel4.Controls.Add(Panel6)
        Panel4.Controls.Add(cboportname)
        Panel4.Controls.Add(Label8)
        Panel4.Controls.Add(txtstopbits)
        Panel4.Controls.Add(txtbaudrate)
        Panel4.Controls.Add(txtreadtimeout)
        Panel4.Controls.Add(Label7)
        Panel4.Controls.Add(Label6)
        Panel4.Controls.Add(Label5)
        Panel4.Controls.Add(Label4)
        Panel4.Controls.Add(txtdatabits)
        Panel4.Controls.Add(Label3)
        Panel4.Controls.Add(Panel5)
        Panel4.Location = New Point(10, 66)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(452, 372)
        Panel4.TabIndex = 6
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.AliceBlue
        Panel6.Controls.Add(btnexit)
        Panel6.Controls.Add(btnsave)
        Panel6.Dock = DockStyle.Bottom
        Panel6.Location = New Point(0, 322)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(452, 50)
        Panel6.TabIndex = 16
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.DodgerBlue
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.Font = New Font("Tahoma", 9F)
        btnexit.ForeColor = Color.White
        btnexit.Location = New Point(230, 10)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(85, 31)
        btnexit.TabIndex = 18
        btnexit.Text = "Exit"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.DodgerBlue
        btnsave.FlatAppearance.BorderSize = 0
        btnsave.FlatStyle = FlatStyle.Flat
        btnsave.Font = New Font("Tahoma", 9F)
        btnsave.ForeColor = Color.White
        btnsave.Location = New Point(138, 10)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(85, 31)
        btnsave.TabIndex = 17
        btnsave.Text = "&Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' cboportname
        ' 
        cboportname.DropDownStyle = ComboBoxStyle.DropDownList
        cboportname.FlatStyle = FlatStyle.System
        cboportname.FormattingEnabled = True
        cboportname.Items.AddRange(New Object() {"User", "Administrator", "Super Administrator"})
        cboportname.Location = New Point(107, 60)
        cboportname.Name = "cboportname"
        cboportname.Size = New Size(176, 23)
        cboportname.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.ForeColor = SystemColors.HotTrack
        Label8.Location = New Point(22, 211)
        Label8.Name = "Label8"
        Label8.Size = New Size(53, 15)
        Label8.TabIndex = 13
        Label8.Text = "Data Bits"
        ' 
        ' txtstopbits
        ' 
        txtstopbits.Location = New Point(107, 171)
        txtstopbits.Name = "txtstopbits"
        txtstopbits.ReadOnly = True
        txtstopbits.Size = New Size(176, 23)
        txtstopbits.TabIndex = 12
        txtstopbits.Text = "1"
        ' 
        ' txtbaudrate
        ' 
        txtbaudrate.Location = New Point(107, 134)
        txtbaudrate.Name = "txtbaudrate"
        txtbaudrate.ReadOnly = True
        txtbaudrate.Size = New Size(176, 23)
        txtbaudrate.TabIndex = 11
        txtbaudrate.Text = "9600"
        ' 
        ' txtreadtimeout
        ' 
        txtreadtimeout.Location = New Point(107, 97)
        txtreadtimeout.Name = "txtreadtimeout"
        txtreadtimeout.ReadOnly = True
        txtreadtimeout.Size = New Size(176, 23)
        txtreadtimeout.TabIndex = 10
        txtreadtimeout.Text = "10000"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.ForeColor = SystemColors.HotTrack
        Label7.Location = New Point(19, 174)
        Label7.Name = "Label7"
        Label7.Size = New Size(53, 15)
        Label7.TabIndex = 8
        Label7.Text = "Stop Bits"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.ForeColor = SystemColors.HotTrack
        Label6.Location = New Point(19, 137)
        Label6.Name = "Label6"
        Label6.Size = New Size(57, 15)
        Label6.TabIndex = 7
        Label6.Text = "BaudRate"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.HotTrack
        Label5.Location = New Point(19, 100)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 15)
        Label5.TabIndex = 6
        Label5.Text = "Read Timeout"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = SystemColors.HotTrack
        Label4.Location = New Point(19, 63)
        Label4.Name = "Label4"
        Label4.Size = New Size(64, 15)
        Label4.TabIndex = 5
        Label4.Text = "Port Name"
        ' 
        ' txtdatabits
        ' 
        txtdatabits.Location = New Point(107, 208)
        txtdatabits.Name = "txtdatabits"
        txtdatabits.ReadOnly = True
        txtdatabits.Size = New Size(176, 23)
        txtdatabits.TabIndex = 4
        txtdatabits.Text = "8"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.HotTrack
        Label3.Location = New Point(10, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 19)
        Label3.TabIndex = 3
        Label3.Text = "PORT INFORMATION"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.DodgerBlue
        Panel5.Dock = DockStyle.Top
        Panel5.Location = New Point(0, 0)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(452, 3)
        Panel5.TabIndex = 2
        ' 
        ' PortConfiguration
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(474, 450)
        ControlBox = False
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "PortConfiguration"
        Text = "Port Configuration"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents cboportname As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtstopbits As TextBox
    Friend WithEvents txtbaudrate As TextBox
    Friend WithEvents txtreadtimeout As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtdatabits As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnexit As Button
    Friend WithEvents btnsave As Button
End Class
