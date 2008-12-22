Public Class Form1
    Dim a, b As Integer
    Dim d As Bitmap
    Dim c As Color
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        d = New Bitmap(" E:\Audio Music\show\aks\2\22.JPG")
        PictureBox1.Image = d
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        a = (e.X)
        b = (e.Y)
        d.GetPixel(a, b)
        c = d.GetPixel(a, b)
        Label1.Text = " X : " & a
        Label2.Text = " Y : " & b
        Label3.Text = " R : " & c.R
        Label4.Text = " G : " & c.G
        Label5.Text = " G : " & c.B
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        Label1.Text = " X : "
        Label2.Text = " Y : "
        Label3.Text = " R : "
        Label4.Text = " G : "
        Label5.Text = " G : "
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        d = New Bitmap(" E:\Audio Music\show\aks\2\22.JPG")
        PictureBox1.Image = d
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
