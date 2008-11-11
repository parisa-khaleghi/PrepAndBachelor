Public Class Form1
    Dim frm As New Form2
    Dim x As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = Convert.ToInt32(TextBox1.Text)
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim y As Integer
        y = Convert.ToInt32(TextBox1.Text)
        x = y + x
        TextBox1.Text = x.ToString
        frm.TextBox1.Text = TextBox1.Text
        frm.Show()
    End Sub
End Class
