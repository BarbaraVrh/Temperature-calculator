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
        lblTempF = New Label()
        txtTempF = New TextBox()
        btnConvert = New Button()
        lblTempC = New Label()
        txtTempC = New TextBox()
        SuspendLayout()
        ' 
        ' lblTempF
        ' 
        lblTempF.AutoSize = True
        lblTempF.Location = New Point(117, 51)
        lblTempF.Name = "lblTempF"
        lblTempF.Size = New Size(174, 20)
        lblTempF.TabIndex = 0
        lblTempF.Text = "Temperature(Fahrenheit):"
        ' 
        ' txtTempF
        ' 
        txtTempF.Location = New Point(331, 48)
        txtTempF.Name = "txtTempF"
        txtTempF.Size = New Size(119, 27)
        txtTempF.TabIndex = 1
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(229, 103)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(171, 31)
        btnConvert.TabIndex = 2
        btnConvert.Text = "Convert to Celsius"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' lblTempC
        ' 
        lblTempC.AutoSize = True
        lblTempC.Location = New Point(117, 177)
        lblTempC.Name = "lblTempC"
        lblTempC.Size = New Size(151, 20)
        lblTempC.TabIndex = 3
        lblTempC.Text = "Temperature(Celsius):"
        ' 
        ' txtTempC
        ' 
        txtTempC.Location = New Point(331, 174)
        txtTempC.Name = "txtTempC"
        txtTempC.ReadOnly = True
        txtTempC.Size = New Size(119, 27)
        txtTempC.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(559, 219)
        Controls.Add(txtTempC)
        Controls.Add(lblTempC)
        Controls.Add(btnConvert)
        Controls.Add(txtTempF)
        Controls.Add(lblTempF)
        Name = "Form1"
        Text = "Temperature"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTempF As Label
    Friend WithEvents txtTempF As TextBox
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblTempC As Label
    Friend WithEvents txtTempC As TextBox
End Class
