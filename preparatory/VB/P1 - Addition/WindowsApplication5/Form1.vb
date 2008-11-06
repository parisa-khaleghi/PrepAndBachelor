Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        y = x + y
        TextBox1.Text = y.ToString
    End Sub
End Class
