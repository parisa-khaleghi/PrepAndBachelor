Public Class Form1
    Dim mypen As Pen

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox4.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Show()
        ToolTip1.SetToolTip(Button5, "Change BackColor Of Form")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PictureBox1.Show()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        mypen = New Pen(Color.Ivory)
        e.Graphics.DrawRectangle(mypen, 50, 54, 68, 45)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PictureBox2.Show()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox1.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox2.Paint
        mypen = New Pen(Color.DeepPink)
        e.Graphics.DrawEllipse(mypen, 40, 40, 80, 80)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox3.Show()
        PictureBox1.Hide()
        PictureBox4.Hide()
        PictureBox2.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox3_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox3.Paint
        mypen = New Pen(Color.Blue)
        e.Graphics.DrawEllipse(mypen, 40, 80, 50, 60)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox4.Show()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox4_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox4.Paint
        mypen = New Pen(Color.Green)
        e.Graphics.DrawLine(mypen, 10, 40, 50, 90)
        e.Graphics.DrawLine(mypen, 10, 40, 5, 90)
        e.Graphics.DrawLine(mypen, 6, 90, 50, 90)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Show()
        PictureBox6.Hide()
        PictureBox7.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox5_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox5.Paint
        mypen = New Pen(Color.Orange)
        Dim mypoint(2) As Point
        mypoint(0).X = 150
        mypoint(0).Y = 150
        mypoint(1).X = 150
        mypoint(1).Y = 200
        mypoint(2).X = 50
        mypoint(2).Y = 120
        e.Graphics.DrawPolygon(mypen, mypoint)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Show()
        PictureBox7.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox6_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox6.Paint
        mypen = New Pen(Color.Black)
        e.Graphics.DrawIcon(Me.Icon, 120, 50)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        PictureBox6.Hide()
        PictureBox7.Show()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox7_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox7.Paint
        e.Graphics.FillEllipse(Brushes.Yellow, 0, 0, 99, 99)
        e.Graphics.DrawEllipse(Pens.Black, 0, 0, 99, 99)
        e.Graphics.DrawArc(Pens.Black, 20, 20, 60, 60, 0, 180)
        e.Graphics.FillEllipse(Brushes.Black, 40, 40, 20, 25)
        e.Graphics.FillEllipse(Brushes.White, 25, 15, 20, 25)
        e.Graphics.DrawEllipse(Pens.Black, 25, 15, 20, 25)
        e.Graphics.FillEllipse(Brushes.Black, 35, 20, 10, 15)
        e.Graphics.FillEllipse(Brushes.White, 55, 15, 20, 25)
        e.Graphics.DrawEllipse(Pens.Black, 55, 15, 20, 25)
        e.Graphics.FillEllipse(Brushes.Black, 65, 20, 10, 15)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim c As New ColorDialog
        c.ShowDialog()
        Me.BackColor = c.Color
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

End Class
