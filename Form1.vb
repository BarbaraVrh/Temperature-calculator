Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim fahrenheitTemp, celsiusTemp As Double
        fahrenheitTemp = CDbl(txtTempF.Text)
        celsiusTemp = FtoC(fahrenheitTemp)
        txtTempC.Text = CStr(celsiusTemp)

    End Sub
    Function FtoC(t As Double) As Double
        Return Math.Round((5 / 9) * (t - 32), 2)
    End Function

    Private Sub frmConvert_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtTempF_TextChanged(sender As Object, e As EventArgs) Handles txtTempF.TextChanged

    End Sub
End Class
