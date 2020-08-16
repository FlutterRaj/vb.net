Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "1" Then
            Label3.Text = "you entered 1"
        End If
        If TextBox1.Text = "2" Then
            Label3.Text = "you entered 2"
        End If
        If TextBox1.Text = "3" Then
            Label3.Text = "you entered 3"
        End If
        If TextBox1.Text = "4" Then
            Label3.Text = "you entered 4"
        End If
        If TextBox1.Text = "5" Then
            Label3.Text = "you entered 5"
        End If
    End Sub
End Class
