<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEES_STATUS
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
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        TextBox1 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Label2 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Blue
        Label1.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.Info
        Label1.Location = New Point(327, 111)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 25)
        Label1.TabIndex = 0
        Label1.Text = "STUDENT NAME"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Blue
        Label3.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.Info
        Label3.Location = New Point(303, 204)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 25)
        Label3.TabIndex = 2
        Label3.Text = "COURSE NAME"' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Blue
        Label4.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.Info
        Label4.Location = New Point(292, 308)
        Label4.Name = "Label4"
        Label4.Size = New Size(204, 25)
        Label4.TabIndex = 3
        Label4.Text = "ADMISSION DATE"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(626, 106)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(247, 35)
        TextBox1.TabIndex = 5
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(636, 403)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(247, 35)
        TextBox4.TabIndex = 8
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(636, 515)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(247, 35)
        TextBox5.TabIndex = 9
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Microsoft YaHei", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"TAMIL ", "ENGLISH"})
        ComboBox1.Location = New Point(636, 199)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(195, 36)
        ComboBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(1072, 692)
        Button1.Name = "Button1"
        Button1.Size = New Size(106, 53)
        Button1.TabIndex = 11
        Button1.Text = "SAVE"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Blue
        Label2.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.Info
        Label2.Location = New Point(384, 403)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 25)
        Label2.TabIndex = 12
        Label2.Text = "ADDRESS"' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Blue
        Label6.Font = New Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.Info
        Label6.Location = New Point(384, 515)
        Label6.Name = "Label6"
        Label6.Size = New Size(130, 25)
        Label6.TabIndex = 13
        Label6.Text = "DURATION"' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(636, 310)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(210, 23)
        DateTimePicker1.TabIndex = 14
        ' 
        ' FEES_STATUS
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Blue
        ClientSize = New Size(1223, 774)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        ForeColor = SystemColors.InactiveCaptionText
        Name = "FEES_STATUS"
        Text = "ADMISSION"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
