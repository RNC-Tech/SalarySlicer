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
        ComboBox1 = New ComboBox()
        SalaryReceived = New TextBox()
        RSECut = New Label()
        UserCut = New Label()
        ConvertBtn = New Button()
        Label3 = New Label()
        Label4 = New Label()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Hans", "Joshua", "Neo", "Rence", "Vence"})
        ComboBox1.Location = New Point(21, 255)
        ComboBox1.Margin = New Padding(10)
        ComboBox1.MaxDropDownItems = 5
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(105, 29)
        ComboBox1.TabIndex = 0
        ' 
        ' SalaryReceived
        ' 
        SalaryReceived.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SalaryReceived.Location = New Point(132, 255)
        SalaryReceived.Name = "SalaryReceived"
        SalaryReceived.Size = New Size(295, 29)
        SalaryReceived.TabIndex = 1
        ' 
        ' RSECut
        ' 
        RSECut.AutoSize = True
        RSECut.Dock = DockStyle.Fill
        RSECut.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        RSECut.Location = New Point(3, 19)
        RSECut.Name = "RSECut"
        RSECut.Size = New Size(0, 24)
        RSECut.TabIndex = 2
        RSECut.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' UserCut
        ' 
        UserCut.AutoSize = True
        UserCut.Dock = DockStyle.Fill
        UserCut.Font = New Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UserCut.Location = New Point(3, 19)
        UserCut.Name = "UserCut"
        UserCut.RightToLeft = RightToLeft.No
        UserCut.Size = New Size(0, 24)
        UserCut.TabIndex = 3
        UserCut.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' ConvertBtn
        ' 
        ConvertBtn.FlatStyle = FlatStyle.System
        ConvertBtn.Location = New Point(21, 176)
        ConvertBtn.Name = "ConvertBtn"
        ConvertBtn.Size = New Size(406, 39)
        ConvertBtn.TabIndex = 6
        ConvertBtn.Text = "Convert"
        ConvertBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(65, 16)
        Label3.TabIndex = 7
        Label3.Text = "Employee"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(132, 232)
        Label4.Name = "Label4"
        Label4.Size = New Size(100, 16)
        Label4.TabIndex = 8
        Label4.Text = "Salary Received"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(UserCut)
        GroupBox1.Location = New Point(227, 297)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(200, 52)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "Employee's Cut"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(RSECut)
        GroupBox2.Location = New Point(21, 297)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(200, 52)
        GroupBox2.TabIndex = 10
        GroupBox2.TabStop = False
        GroupBox2.Text = "RSE Cut"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._462569004_909656427938993_3389220956370176716_n
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(413, 158)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 11
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(437, 359)
        Controls.Add(PictureBox1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(ConvertBtn)
        Controls.Add(SalaryReceived)
        Controls.Add(ComboBox1)
        MaximizeBox = False
        MaximumSize = New Size(453, 398)
        MinimumSize = New Size(453, 398)
        Name = "Form1"
        ShowIcon = False
        StartPosition = FormStartPosition.CenterScreen
        Text = "SalarySlicer"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SalaryReceived As TextBox
    Friend WithEvents RSECut As Label
    Friend WithEvents UserCut As Label
    Friend WithEvents ConvertBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox

End Class
