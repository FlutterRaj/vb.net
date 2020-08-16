Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text Mod 2 = 0 Then
            MessageBox.Show("EVEN")
        End If
        If TextBox1.Text Mod 2 > 0 Then
            MessageBox.Show("ODD")
        End If
    End Sub
End Class
