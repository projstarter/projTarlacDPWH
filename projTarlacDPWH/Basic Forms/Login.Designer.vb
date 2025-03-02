<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        ApplicationTitle = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label4 = New Label()
        btnlogin = New Button()
        btnexit = New Button()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(333, 325)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Light", 13F)
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(339, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 25)
        Label1.TabIndex = 1
        Label1.Text = "Sign in ... "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Light", 9F)
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(349, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 2
        Label2.Text = "USERNAME"
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Segoe UI Light", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ApplicationTitle.ForeColor = Color.DimGray
        ApplicationTitle.Location = New Point(338, 6)
        ApplicationTitle.Margin = New Padding(2, 0, 2, 0)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(237, 65)
        ApplicationTitle.TabIndex = 6
        ApplicationTitle.Text = "JAAM WEIGHING" & vbCrLf & "SCALE TRADING"
        ApplicationTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtUsername
        ' 
        txtUsername.BorderStyle = BorderStyle.FixedSingle
        txtUsername.Location = New Point(353, 143)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(209, 23)
        txtUsername.TabIndex = 7
        ' 
        ' txtPassword
        ' 
        txtPassword.BorderStyle = BorderStyle.FixedSingle
        txtPassword.Location = New Point(353, 198)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(209, 23)
        txtPassword.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Light", 9F)
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(349, 178)
        Label4.Name = "Label4"
        Label4.Size = New Size(68, 15)
        Label4.TabIndex = 8
        Label4.Text = "PASSWORD"
        ' 
        ' btnlogin
        ' 
        btnlogin.BackColor = Color.DodgerBlue
        btnlogin.FlatAppearance.BorderSize = 0
        btnlogin.FlatStyle = FlatStyle.Flat
        btnlogin.Font = New Font("Tahoma", 9F)
        btnlogin.ForeColor = Color.White
        btnlogin.Location = New Point(353, 241)
        btnlogin.Name = "btnlogin"
        btnlogin.Size = New Size(209, 31)
        btnlogin.TabIndex = 10
        btnlogin.Text = "LOGIN"
        btnlogin.UseVisualStyleBackColor = False
        ' 
        ' btnexit
        ' 
        btnexit.BackColor = Color.DodgerBlue
        btnexit.FlatAppearance.BorderSize = 0
        btnexit.FlatStyle = FlatStyle.Flat
        btnexit.Font = New Font("Tahoma", 9F)
        btnexit.ForeColor = Color.White
        btnexit.Location = New Point(353, 281)
        btnexit.Name = "btnexit"
        btnexit.Size = New Size(209, 31)
        btnexit.TabIndex = 11
        btnexit.Text = "EXIT"
        btnexit.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Azure
        ClientSize = New Size(581, 325)
        ControlBox = False
        Controls.Add(btnexit)
        Controls.Add(btnlogin)
        Controls.Add(txtPassword)
        Controls.Add(Label4)
        Controls.Add(txtUsername)
        Controls.Add(ApplicationTitle)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button
End Class
