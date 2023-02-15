Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim sum As Double

        num1 = txtNum1.Text
        num2 = txtNum2.Text
        sum = num2 + num1

        output.Text = sum
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()

    End Sub
End Class
