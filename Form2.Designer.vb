<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MAINFORM
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
        Panel2 = New Panel()
        BindingSource1 = New BindingSource(components)
        Button2 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Button4 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.DarkSlateGray
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1339, 34)
        Panel2.TabIndex = 14
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Lime
        Button2.Font = New Font("Rockwell Condensed", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(50, 53)
        Button2.Name = "Button2"
        Button2.Size = New Size(204, 40)
        Button2.TabIndex = 0
        Button2.Text = "FEES PAID"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.Lime
        Button3.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImageAlign = ContentAlignment.MiddleLeft
        Button3.Location = New Point(322, 53)
        Button3.Name = "Button3"
        Button3.Size = New Size(212, 40)
        Button3.TabIndex = 15
        Button3.Text = "ADMISSION"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.Lime
        Button1.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImageAlign = ContentAlignment.MiddleLeft
        Button1.Location = New Point(632, 53)
        Button1.Name = "Button1"
        Button1.Size = New Size(220, 40)
        Button1.TabIndex = 17
        Button1.Text = "EXAM ELIGIBILITY"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = Color.Lime
        Button4.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(957, 53)
        Button4.Name = "Button4"
        Button4.Size = New Size(175, 40)
        Button4.TabIndex = 18
        Button4.Text = "TIMETABLE"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Indigo
        Label1.Font = New Font("Rockwell", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Cornsilk
        Label1.Location = New Point(25, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 29)
        Label1.TabIndex = 19
        Label1.Text = "COURSES OFFERED"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = Color.DeepSkyBlue
        Label2.Location = New Point(166, 291)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 44)
        Label2.TabIndex = 20
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = Color.DeepSkyBlue
        Label3.Location = New Point(74, 247)
        Label3.Name = "Label3"
        Label3.Size = New Size(639, 44)
        Label3.TabIndex = 21
        Label3.Text = "TAMIL TYPEWRITTING - 6 MONTHS"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Stencil", 27.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = Color.DeepSkyBlue
        Label4.Location = New Point(74, 398)
        Label4.Name = "Label4"
        Label4.Size = New Size(686, 44)
        Label4.TabIndex = 22
        Label4.Text = "ENGLISH TYPEWRITTING - 6 MONTHS"' 
        ' MAINFORM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Indigo
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1339, 775)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button4)
        Controls.Add(Button1)
        Controls.Add(Panel2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Name = "MAINFORM"
        Text = "MAIN FORM"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
