Public Class Form1
    Dim message As String = "This message shown by variable message"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(message)
    End Sub
End Class
