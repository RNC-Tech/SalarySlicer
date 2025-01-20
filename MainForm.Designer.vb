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
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Hans", "Joshua", "Neo", "Rence", "Vence"})
        ComboBox1.Location = New Point(21, 32)
        ComboBox1.Margin = New Padding(10)
        ComboBox1.MaxDropDownItems = 5
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(105, 29)
        ComboBox1.TabIndex = 0
        ' 
        ' SalaryReceived
        ' 
        SalaryReceived.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        SalaryReceived.Location = New Point(139, 32)
        SalaryReceived.Name = "SalaryReceived"
        SalaryReceived.Size = New Size(236, 29)
        SalaryReceived.TabIndex = 1
        SalaryReceived.Text = "Salary Received"
        ' 
        ' RSECut
        ' 
        RSECut.AutoSize = True
        RSECut.Font = New Font("Museo Sans 500", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RSECut.Location = New Point(21, 90)
        RSECut.Name = "RSECut"
        RSECut.Size = New Size(26, 25)
        RSECut.TabIndex = 2
        RSECut.Text = "₱"
        ' 
        ' UserCut
        ' 
        UserCut.AutoSize = True
        UserCut.Font = New Font("Museo Sans 500", 15.7499981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UserCut.Location = New Point(180, 90)
        UserCut.Name = "UserCut"
        UserCut.Size = New Size(26, 25)
        UserCut.TabIndex = 3
        UserCut.Text = "₱"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Museo Sans 500", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(21, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 19)
        Label1.TabIndex = 4
        Label1.Text = "RSE Cut"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Museo Sans 500", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(180, 71)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 19)
        Label2.TabIndex = 5
        Label2.Text = "User Cut"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 138)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(UserCut)
        Controls.Add(RSECut)
        Controls.Add(SalaryReceived)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents SalaryReceived As TextBox
    Friend WithEvents RSECut As Label
    Friend WithEvents UserCut As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
