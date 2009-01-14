Public Class Form1
    Dim g As Graphics
    Dim p1, p2, parr() As Point
    Dim i As Integer = 0
    Dim r, f As Rectangle
    Dim b As button
    Dim c As New ColorDialog

    Enum button
        Rectangle
        Ellipse
        Line
        Freehand
    End Enum

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g = Me.CreateGraphics()
        ToolTip1.SetToolTip(Me, " Paint Here ")
        ToolTip1.SetToolTip(Button1, " Draw Rectangle ")
        ToolTip1.SetToolTip(Button2, " Draw Ellipse ")
        ToolTip1.SetToolTip(Button3, " Draw Line ")
        ToolTip1.SetToolTip(Button4, " Free Hand ")
        ToolTip1.SetToolTip(Button5, " change Back Color Of Your Paint ")
        ToolTip1.SetToolTip(Button6, " Form Close ")
        ToolTip1.SetToolTip(Button7, " Turn OF Computer ")
        ToolTip1.SetToolTip(Button8, " Change Color Of Your Shap ")
    End Sub

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        p1 = New Point(e.X, e.Y)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If b = button.Rectangle And e.Button = Windows.Forms.MouseButtons.Left Then
            p2 = New Point(e.X, e.Y)
            r = New Rectangle(Math.Min(p2.X, p1.X), Math.Min(p2.Y, p1.Y), Math.Abs(p2.X - p1.X), Math.Abs(p2.Y - p1.Y))

            g.DrawRectangle(Pens.DodgerBlue, p1.X, p1.Y, MousePosition.X, MousePosition.Y)

        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
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

    Private Sub Form1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If i >= 2 Then
            g.DrawLines(Pens.Fuchsia, parr)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        b = button.Rectangle
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        b = button.Ellipse
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        b = button.Line
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        b = button.Freehand
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        c.ShowDialog()
        Me.BackColor = c.Color
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        My.Settings.Save()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Close()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        For Each proc As Process In Process.GetProcessesByName("Explorer")
            proc.CloseMainWindow()
        Next
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        c.ShowDialog()
        Dim p As Pen
        p = New Pen(c.Color)
        If b = button.Rectangle Then
            g.DrawRectangle(p, r)
        End If
        If b = button.Ellipse Then
            g.DrawEllipse(p, r)
        End If
        If b = button.Line Then
            g.DrawLine(p, p2, p1)
        End If
    End Sub
End Class
