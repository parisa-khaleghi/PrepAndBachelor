Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.FileName = ""
        AxMediaPlayer1.FileName = ""
        OpenFileDialog1.ShowDialog()
        If Not OpenFileDialog1.FileName = "" Then
            Button1.Enabled = False
            AxMediaPlayer1.AutoStart = False
            AxMediaPlayer1.FileName = OpenFileDialog1.FileName
            Button1.Enabled = False
            Button2.Enabled = True
            AxMediaPlayer1.Play()
            Button3.Enabled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button2.Enabled = False
        Button3.Enabled = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        AxMediaPlayer1.Pause()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Button2.Enabled = False
        Button3.Enabled = False
        AxMediaPlayer1.Stop()
        AxMediaPlayer1.CurrentPosition = 0
        Button1.Enabled = True
    End Sub
End Class
