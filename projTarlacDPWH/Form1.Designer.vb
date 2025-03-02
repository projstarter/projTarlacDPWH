<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        ListBox2 = New ListBox()
        txtNoofAxel = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Timer1 = New Timer(components)
        Label3 = New Label()
        ListBox1 = New ListBox()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 25
        ListBox2.Location = New Point(35, 145)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(449, 304)
        ListBox2.TabIndex = 1
        ' 
        ' txtNoofAxel
        ' 
        txtNoofAxel.Location = New Point(145, 26)
        txtNoofAxel.Name = "txtNoofAxel"
        txtNoofAxel.Size = New Size(150, 31)
        txtNoofAxel.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(104, 25)
        Label1.TabIndex = 3
        Label1.Text = "No. of Axel:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(671, 187)
        Label2.Name = "Label2"
        Label2.Size = New Size(166, 65)
        Label2.TabIndex = 4
        Label2.Text = "Label2"
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(466, 571)
        Label3.Name = "Label3"
        Label3.Size = New Size(166, 65)
        Label3.TabIndex = 5
        Label3.Text = "Label3"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Location = New Point(35, 467)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(449, 304)
        ListBox1.TabIndex = 6
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(703, 377)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 545)
        TextBox1.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1220, 1004)
        Controls.Add(TextBox1)
        Controls.Add(ListBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtNoofAxel)
        Controls.Add(ListBox2)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents txtNoofAxel As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox1 As TextBox

End Class
