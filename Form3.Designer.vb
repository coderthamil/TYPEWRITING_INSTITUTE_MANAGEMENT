<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMISSIONFORM
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
        Button1 = New Button()
        Label4 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        DataGridView1 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.BlueViolet
        Button1.Font = New Font("Rockwell", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Cornsilk
        Button1.Location = New Point(806, 573)
        Button1.Name = "Button1"
        Button1.Size = New Size(166, 54)
        Button1.TabIndex = 24
        Button1.Text = "ADMIT"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(0, 504)
        Label4.Name = "Label4"
        Label4.Size = New Size(279, 28)
        Label4.TabIndex = 20
        Label4.Text = "COURSE DURATION"' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(48, 409)
        Label2.Name = "Label2"
        Label2.Size = New Size(214, 28)
        Label2.TabIndex = 18
        Label2.Text = "COURSE NAME"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Rockwell Extra Bold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(48, 313)
        Label1.Name = "Label1"
        Label1.Size = New Size(231, 28)
        Label1.TabIndex = 17
        Label1.Text = "STUDENT NAME"' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(343, 504)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(395, 39)
        TextBox2.TabIndex = 15
        TextBox2.Text = "6 MONTHS"' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Rockwell", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(343, 305)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(395, 39)
        TextBox1.TabIndex = 14
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(343, 409)
        ComboBox1.Margin = New Padding(3, 2, 3, 2)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(395, 23)
        ComboBox1.TabIndex = 25
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToOrderColumns = True
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(80, 26)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(749, 204)
        DataGridView1.TabIndex = 26
        ' 
        ' ADMISSIONFORM
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(1024, 672)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox1)
        Controls.Add(Button1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Name = "ADMISSIONFORM"
        Text = "ADMISSION FORM"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
