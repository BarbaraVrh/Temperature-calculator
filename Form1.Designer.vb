<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        txtWeek1 = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        txtWeek4 = New TextBox()
        txtWeek3 = New TextBox()
        txtWeek5 = New TextBox()
        txtWeek2 = New TextBox()
        Label6 = New Label()
        lblAverage = New Label()
        btnCalculate = New Button()
        btnClear = New Button()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(167, 76)
        Label1.Name = "Label1"
        Label1.Size = New Size(66, 20)
        Label1.TabIndex = 0
        Label1.Text = "Week #1"
        ' 
        ' txtWeek1
        ' 
        txtWeek1.BorderStyle = BorderStyle.FixedSingle
        txtWeek1.Location = New Point(274, 69)
        txtWeek1.Name = "txtWeek1"
        txtWeek1.Size = New Size(125, 27)
        txtWeek1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(167, 130)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 2
        Label2.Text = "Week #2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(167, 185)
        Label3.Name = "Label3"
        Label3.Size = New Size(68, 20)
        Label3.TabIndex = 3
        Label3.Text = "Week #3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(167, 238)
        Label4.Name = "Label4"
        Label4.Size = New Size(69, 20)
        Label4.TabIndex = 4
        Label4.Text = "Week #4"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(167, 292)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 20)
        Label5.TabIndex = 5
        Label5.Text = "Week #5"
        ' 
        ' txtWeek4
        ' 
        txtWeek4.BorderStyle = BorderStyle.FixedSingle
        txtWeek4.Location = New Point(274, 238)
        txtWeek4.Name = "txtWeek4"
        txtWeek4.Size = New Size(125, 27)
        txtWeek4.TabIndex = 6
        ' 
        ' txtWeek3
        ' 
        txtWeek3.BorderStyle = BorderStyle.FixedSingle
        txtWeek3.Location = New Point(274, 183)
        txtWeek3.Name = "txtWeek3"
        txtWeek3.Size = New Size(125, 27)
        txtWeek3.TabIndex = 7
        ' 
        ' txtWeek5
        ' 
        txtWeek5.BorderStyle = BorderStyle.FixedSingle
        txtWeek5.Location = New Point(274, 290)
        txtWeek5.Name = "txtWeek5"
        txtWeek5.Size = New Size(125, 27)
        txtWeek5.TabIndex = 8
        ' 
        ' txtWeek2
        ' 
        txtWeek2.BorderStyle = BorderStyle.FixedSingle
        txtWeek2.Location = New Point(274, 123)
        txtWeek2.Name = "txtWeek2"
        txtWeek2.Size = New Size(125, 27)
        txtWeek2.TabIndex = 9
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(167, 356)
        Label6.Name = "Label6"
        Label6.Size = New Size(70, 20)
        Label6.TabIndex = 10
        Label6.Text = "Average:"
        ' 
        ' lblAverage
        ' 
        lblAverage.BorderStyle = BorderStyle.Fixed3D
        lblAverage.Location = New Point(274, 347)
        lblAverage.Name = "lblAverage"
        lblAverage.Size = New Size(125, 38)
        lblAverage.TabIndex = 11
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(155, 439)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 12
        btnCalculate.Text = "C&alculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(305, 439)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 13
        btnClear.Text = "Clea&r"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(435, 439)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 14
        Button3.Text = "E&xit"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(603, 503)
        Controls.Add(Button3)
        Controls.Add(btnClear)
        Controls.Add(btnCalculate)
        Controls.Add(lblAverage)
        Controls.Add(Label6)
        Controls.Add(txtWeek2)
        Controls.Add(txtWeek5)
        Controls.Add(txtWeek3)
        Controls.Add(txtWeek4)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(txtWeek1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Weekly temperature average"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtWeek1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtWeek4 As TextBox
    Friend WithEvents txtWeek3 As TextBox
    Friend WithEvents txtWeek5 As TextBox
    Friend WithEvents txtWeek2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lblAverage As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Button3 As Button
End Class
