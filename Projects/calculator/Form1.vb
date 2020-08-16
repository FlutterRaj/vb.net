Public Class Form1
    Dim num1 As Integer
    Dim num2 As Integer
    Dim result As Integer
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 + num2
        MessageBox.Show(result)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 - num2
        MessageBox.Show(result)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 * num2
        MessageBox.Show(result)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num1 = TextBox1.Text
        num2 = TextBox2.Text
        result = num1 / num2
        MessageBox.Show(result)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class
