Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Declare a variable for the calculations.
        Dim decAverage As Decimal     ' Average of the temperatures     
        Try
            ' Calculate and display the temperature average.
            decAverage = (CDec(txtWeek1.Text) + CDec(txtWeek2.Text) + CDec(txtWeek3.Text) + CDec(txtWeek4.Text) + CDec(txtWeek5.Text)) / 5
            lblAverage.Text = decAverage.ToString("n")
        Catch
            ' Error message
            MessageBox.Show("All input must be valid numeric values.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the weekly temperature fields.
        txtWeek1.Clear()
        txtWeek2.Clear()
        txtWeek3.Clear()
        txtWeek4.Clear()
        txtWeek5.Clear()

        ' Clear the decAverage field.
        lblAverage.Text() = String.Empty

        ' Reset the focus to the first field.
        txtWeek1.Focus()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Close the form'
        Me.Close()
    End Sub
End Class
