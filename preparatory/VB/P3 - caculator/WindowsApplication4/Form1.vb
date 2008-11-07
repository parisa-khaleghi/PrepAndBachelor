Public Class Form1
    Dim sx As Integer
    Dim tx As Integer
    Dim gx As Integer
    Dim zx As Integer
    Dim sy As Boolean
    Dim ty As Boolean
    Dim gy As Boolean
    Dim zy As Boolean
   Private Sub Buttons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttons.Click
        sx = Convert.ToInt32(TextBox1.Text)
        TextBox1.Text = ""
        sy = True
        ty = False
        gy = False
        zy = False
    End Sub

    Private Sub Buttonm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonm.Click
        tx = Convert.ToInt32(TextBox1.Text)
        TextBox1.Text = ""
        ty = True
        sy = False
        gy = False
        zy = False
    End Sub


    Private Sub Buttonb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonb.Click
        If sy = True Then
            Dim sy As Integer
            sy = Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = sx + sy.ToString
        End If
        If ty = True Then
            Dim ty As Integer
            ty = Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = tx - ty.ToString
        End If
        If zy = True Then
            Dim zy As Integer
            zy = Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = zx * zy.ToString
        End If
        If gy = True Then
            Dim gy As Integer
            gy = Convert.ToInt32(TextBox1.Text)
            TextBox1.Text = gx / gy.ToString
        End If
    End Sub

    Private Sub Buttonz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttonz.Click
        zx = Convert.ToInt32(TextBox1.Text)
        TextBox1.Text = ""
        ty = False
        sy = False
        gy = False
        zy = True
    End Sub

    Private Sub Buttont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Buttont.Click
        gx = Convert.ToInt32(TextBox1.Text)
        TextBox1.Text = ""
        ty = False
        sy = False
        gy = True
        zy = False
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text + "00"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TextBox1.Text = TextBox1.Text + "."
    End Sub
End Class
