Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim x As Integer
        Dim y As Integer
        x = Convert.ToInt32(TextBox1.Text)
        y = Convert.ToInt32(TextBox2.Text)
        x = x + y
        TextBox1.Text = x.ToString
    End Sub
    Dim x As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        x = Convert.ToInt32(TextBox3.Text)
        TextBox3.Text = ""
        TextBox3.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim y As Integer
        y = Convert.ToInt32(TextBox3.Text)
        x = x + y
        TextBox3.Text = x.ToString
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox4.Clear()
        TextBox4.Focus()
    End Sub

    Dim sx, tx, gx, zx, vx, dx As Integer
    Dim sy, ty, gy, zy, vy, dy As Boolean

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        sx = Convert.ToInt32(TextBox4.Text)
        TextBox4.Text = ""
        sy = True
        ty = False
        gy = False
        zy = False
        vy = False
        dy = False
        TextBox4.Focus()
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        tx = Convert.ToInt32(TextBox4.Text)
        TextBox4.Text = ""
        ty = True
        sy = False
        gy = False
        zy = False
        vy = False
        dy = False
        TextBox4.Focus()
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        zx = Convert.ToInt32(TextBox4.Text)
        TextBox4.Text = ""
        ty = False
        sy = False
        gy = False
        zy = True
        vy = False
        dy = False
        TextBox4.Focus()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        gx = Convert.ToInt32(TextBox4.Text)
        TextBox4.Text = ""
        ty = False
        sy = False
        gy = True
        zy = False
        vy = False
        dy = False
        TextBox4.Focus()
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        vx = Convert.ToInt32(TextBox4.Text)
        TextBox4.Text = ""
        ty = False
        sy = False
        gy = False
        zy = False
        vy = True
        dy = False
        TextBox4.Focus()
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        dx = Convert.ToInt32(TextBox4.Text)
        TextBox4.Text = ""
        ty = False
        sy = False
        gy = False
        zy = False
        vy = False
        dy = True
        TextBox4.Focus()
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        If sy = True Then
            Dim sy As Integer
            sy = Convert.ToInt32(TextBox4.Text)
            TextBox4.Text = sx + sy.ToString
        End If
        If ty = True Then
            Dim ty As Integer
            ty = Convert.ToInt32(TextBox4.Text)
            TextBox4.Text = tx - ty.ToString
        End If
        If zy = True Then
            Dim zy As Integer
            zy = Convert.ToInt32(TextBox4.Text)
            TextBox4.Text = zx * zy.ToString
        End If
        If gy = True Then
            Dim gy As Integer
            gy = Convert.ToInt32(TextBox4.Text)
            TextBox4.Text = gx / gy.ToString
        End If
        If vy = True Then
            Dim vy As Integer
            vy = Convert.ToInt32(TextBox4.Text)
            TextBox4.Text = vx ^ vy.ToString
        End If
        If dy = True Then
            Dim dy As Integer
            dy = Convert.ToInt32(TextBox4.Text)
            TextBox4.Text = dx * (dy / 100).ToString
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox4.Text = TextBox4.Text + "0"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        TextBox4.Text = TextBox4.Text + "1"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox4.Text = TextBox4.Text + "2"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox4.Text = TextBox4.Text + "3"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox4.Text = TextBox4.Text + "4"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox4.Text = TextBox4.Text + "5"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox4.Text = TextBox4.Text + "6"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox4.Text = TextBox4.Text + "7"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox4.Text = TextBox4.Text + "8"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox4.Text = TextBox4.Text + "9"
    End Sub

    Dim frm As New Form2

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        frm.TextBox1.Text = TextBox5.Text
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        frm.Show()
    End Sub

    Dim intarr() As Short
    Dim i, j As Integer
    Dim sum As Double
    Private Sub Button24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button24.Click
        intarr(i) = Val(TextBox6.Text)
        ListBox1.Items.Add(CStr(intarr(i)))
        i = i + 1
        ReDim Preserve intarr(i)
        TextBox6.Text = ""
        TextBox6.Focus()
    End Sub

    Private Sub Button25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button25.Click
        For j = 0 To i - 1
            sum = sum + intarr(j)
        Next
        Label1.Text = "Sum" & sum
        Label2.Text = "Average" & sum / i
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n As Integer
        Dim b As Integer
        ReDim Preserve intarr(1)
        i = 0
        b = 0
        n = 1
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
        g = TabPage7.CreateGraphics()
        d = New Bitmap(" E:\Audio Music\show\aks\2\22.JPG")
        PictureBox6.Image = d
        ToolTip1.SetToolTip(TabPage1, " Sum ")
        ToolTip1.SetToolTip(TabPage2, " Sum & = ")
        ToolTip1.SetToolTip(TabPage3, " Calculator ")
        ToolTip1.SetToolTip(TabPage4, " 2Forms & I/O ")
        ToolTip1.SetToolTip(TabPage5, " Average ")
        ToolTip1.SetToolTip(TabPage6, " Shap ")
        ToolTip1.SetToolTip(TabPage7, " Shap (Mouse) ")
        ToolTip1.SetToolTip(TabPage8, " Info ")
        ToolTip1.SetToolTip(TabPage9, " Read & Write Stream ")
    End Sub

    Private Sub Button26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button26.Click
        TextBox6.Text = ""
        ListBox1.Items.Clear()
        TextBox6.Focus()
        Label1.Text = "Sum:0"
        Label2.Text = "Average:0"
    End Sub

    Private Sub Button27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button27.Click
        TextBox6.Text = ""
        TextBox6.Focus()
    End Sub

    Dim mypen As Pen
    Private Sub Button28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button28.Click
        PictureBox1.Show()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        mypen = New Pen(Color.Ivory)
        e.Graphics.DrawRectangle(mypen, 50, 54, 68, 45)
    End Sub

    Private Sub Button29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button29.Click
        PictureBox2.Show()
        PictureBox3.Hide()
        PictureBox4.Hide()
        PictureBox1.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox2.Paint
        mypen = New Pen(Color.DeepPink)
        e.Graphics.DrawEllipse(mypen, 40, 40, 80, 80)
    End Sub

    Private Sub Button30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button30.Click
        PictureBox3.Show()
        PictureBox1.Hide()
        PictureBox4.Hide()
        PictureBox2.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox3_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox3.Paint
        mypen = New Pen(Color.Blue)
        e.Graphics.DrawEllipse(mypen, 40, 80, 50, 60)
    End Sub

    Private Sub Button31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button31.Click
        PictureBox4.Show()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox4_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox4.Paint
        mypen = New Pen(Color.Green)
        e.Graphics.DrawLine(mypen, 10, 40, 50, 90)
        e.Graphics.DrawLine(mypen, 10, 40, 5, 90)
        e.Graphics.DrawLine(mypen, 6, 90, 50, 90)
    End Sub

    Private Sub Button32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button32.Click
        PictureBox4.Hide()
        PictureBox1.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        PictureBox5.Show()
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

    Dim g As Graphics
    Dim p1, p2, parr() As Point
    Dim k As Integer = 0
    Dim r As Rectangle
    Dim b As Button
    Enum button
        Rectangle
        Ellipse
        Line
        Freehand
    End Enum

    Private Sub TabPage7_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPage7.MouseDown
        p1 = New Point(e.X, e.Y)
    End Sub

    Private Sub TabPage7_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPage7.MouseMove
        If b = button.Freehand And e.Button = Windows.Forms.MouseButtons.Left Then
            Dim p3 As New Point(e.X, e.Y)
            ReDim Preserve parr(k)
            parr(k) = p3
            k += 1
            If k >= 2 Then
                g.DrawLines(Pens.Fuchsia, parr)
            End If
        End If
    End Sub

    Private Sub TabPage7_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPage7.MouseUp
        p2 = New Point(e.X, e.Y)
        r = New Rectangle(Math.Min(p2.X, p1.X), Math.Min(p2.Y, p1.Y), Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y))
        Select Case b
            Case button.Rectangle
                g.DrawRectangle(Pens.DodgerBlue, r)
            Case button.Ellipse
                g.DrawEllipse(Pens.LimeGreen, r)
            Case button.Line
                g.DrawLine(Pens.Orange, p2, p1)
        End Select
    End Sub

    Private Sub TabPage7_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles TabPage7.Paint
        If k >= 2 Then
            g.DrawLines(Pens.Fuchsia, parr)
        End If
    End Sub

    Private Sub Button33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button33.Click
        b = button.Rectangle
    End Sub

    Private Sub Button34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button34.Click
        b = button.Ellipse
    End Sub

    Private Sub Button35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button35.Click
        b = button.Line
    End Sub

    Private Sub Button36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button36.Click
        b = button.Freehand
    End Sub

    Dim m, n As Integer
    Dim d As Bitmap
    Dim c As Color

    Private Sub PictureBox6_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox6.MouseMove
        m = (e.X)
        n = (e.Y)
        d.GetPixel(m, n)
        c = d.GetPixel(m, n)
        Label5.Text = " X : " & m
        Label6.Text = " Y : " & n
        Label7.Text = " R : " & c.R
        Label8.Text = " G : " & c.G
        Label9.Text = " G : " & c.B
    End Sub

    Private Sub TabPage8_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabPage8.MouseMove
        Label5.Text = " X : "
        Label6.Text = " Y : "
        Label7.Text = " R : "
        Label8.Text = " G : "
        Label9.Text = " G : "
    End Sub

    Private Sub Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button37.Click
        Dim f As New IO.FileStream("file.txt", IO.FileMode.Create, IO.FileAccess.Write)
        Dim w As New IO.StreamWriter(f)
        Try
            w.WriteLine("I eat breakfast")
            w.Write("Hello" & ControlChars.CrLf)
            w.WriteLine("Read The Text")
            w.Close()
            MsgBox("wrote text")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button38.Click
        Dim f As New IO.FileStream("file.txt", IO.FileMode.Open, IO.FileAccess.ReadWrite)
        Dim r As New IO.StreamReader(f)
        Try
            r.BaseStream.Seek(0, IO.SeekOrigin.Begin)
            While r.Peek() > -1
                RichTextBox1.Text &= r.ReadLine() & ControlChars.CrLf
            End While
            r.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
