Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.SelectionStart = 4
        TextBox1.SelectionLength = Len(TextBox1.Text)
        TextBox1.Select()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox2.Select()
        TextBox2.Copy()
        TextBox1.Paste()
    End Sub
End Class
