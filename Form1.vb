Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As Double = txt1.Text
        Dim str2 As Double = txt2.Text
        Dim Result As String

        Dim str_bmi As String = str2 / (str1 * str1)

        txt3.Text = str_bmi


        If str_bmi < 18.5 Then
            MessageBox.Show(" Underweight ")

        ElseIf str_bmi <= 24.9 And str_bmi >= 18.5 Then
            MessageBox.Show(" Normal weight ")

        ElseIf str_bmi <= 29.9 And str_bmi >= 25 Then
            MessageBox.Show(" Overweight ")

        ElseIf str_bmi >= 30 Then
            MessageBox.Show(" Obesity ")

        Else
            MessageBox.Show("Please insert number")

        End If

    End Sub
End Class
