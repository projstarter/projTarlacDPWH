<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jadever
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(jadever))
        Version = New Label()
        Panel2 = New Panel()
        Label1 = New Label()
        ApplicationTitle = New Label()
        Panel1 = New Panel()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Version
        ' 
        Version.Anchor = AnchorStyles.None
        Version.AutoSize = True
        Version.BackColor = Color.Transparent
        Version.Font = New Font("Tahoma", 9F)
        Version.ForeColor = Color.White
        Version.Location = New Point(14, 39)
        Version.Margin = New Padding(2, 0, 2, 0)
        Version.Name = "Version"
        Version.Size = New Size(111, 14)
        Version.TabIndex = 4
        Version.Text = "Version {0}.{1:00}"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Black
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(ApplicationTitle)
        Panel2.Controls.Add(Version)
        Panel2.Dock = DockStyle.Bottom
        Panel2.Location = New Point(0, 712)
        Panel2.Margin = New Padding(2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(769, 66)
        Panel2.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.Dock = DockStyle.Right
        Label1.Font = New Font("Tahoma", 9F)
        Label1.ForeColor = Color.DimGray
        Label1.Location = New Point(650, 0)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 66)
        Label1.TabIndex = 6
        Label1.Text = "Release 2021" & vbCrLf & "© 2021 CONLOGIC SOLUTION" & vbCrLf & "All rights reserved."
        Label1.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' ApplicationTitle
        ' 
        ApplicationTitle.Anchor = AnchorStyles.None
        ApplicationTitle.AutoSize = True
        ApplicationTitle.BackColor = Color.Transparent
        ApplicationTitle.Font = New Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ApplicationTitle.ForeColor = Color.White
        ApplicationTitle.Location = New Point(11, 9)
        ApplicationTitle.Margin = New Padding(2, 0, 2, 0)
        ApplicationTitle.Name = "ApplicationTitle"
        ApplicationTitle.Size = New Size(320, 25)
        ApplicationTitle.TabIndex = 5
        ApplicationTitle.Text = "JAAM WEIGHSCALE TRADING APP"
        ApplicationTitle.TextAlign = ContentAlignment.BottomLeft
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(769, 712)
        Panel1.TabIndex = 2
        ' 
        ' jadever
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(769, 778)
        ControlBox = False
        Controls.Add(Panel1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(2)
        MaximizeBox = False
        MinimizeBox = False
        Name = "jadever"
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterScreen
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)

    End Sub
    Friend WithEvents Version As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ApplicationTitle As Label
    Friend WithEvents Panel1 As Panel

End Class
