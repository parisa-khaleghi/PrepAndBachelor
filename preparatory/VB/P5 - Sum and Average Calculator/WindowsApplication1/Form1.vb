Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim IntArr() As Short
    Dim Sum As Double
    Dim i As Object
    Dim j As Short
    Dim s As Short

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        IntArr(i) = Val(TextBox1.Text)
        ListBox1.Items.Add(CStr(IntArr(i)))
        i = i + 1
        ReDim Preserve IntArr(i)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For j = 0 To i - 1
            Sum = Sum + IntArr(j)
        Next
        Label1.Text = "Sum:" & Sum
        Label2.Text = "Average:" & Sum / i
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
        TextBox1.Focus()
        Label1.Text = "Sum:0"
        Label2.Text = "Average:0"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = 13 Then
            IntArr(i) = Val(TextBox1.Text)
            ListBox1.Items.Add(CStr(IntArr(i)))
            i = i + 1
            ReDim Preserve IntArr(i)
            TextBox1.Text = ""
            TextBox1.Focus()
        End If

        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If KeyAscii = System.Windows.Forms.Keys.Back Then
            e.KeyChar = Chr(KeyAscii)
        End If
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n As Object
        Dim b As Object
        ReDim Preserve IntArr(1)
        i = 0
        b = 0
        n = 1
        ToolTip1.SetToolTip(TextBox1, "Input Your Number")
        ToolTip1.SetToolTip(Button1, "Give And Save Your Number For Average")
        ToolTip1.SetToolTip(Button2, "Mathematical")
        ToolTip1.SetToolTip(Button3, "Great A New Average")
        ToolTip1.SetToolTip(Button4, "Program Exit")
        ToolTip1.SetToolTip(ListBox1, "Your Number Save In This Part")
        ToolTip1.SetToolTip(Label1, "Show Sum")
        ToolTip1.SetToolTip(Label2, "Show Average")
        ToolTip1.SetToolTip(CheckBox1, "Show And Hide Sum")
        ToolTip1.SetToolTip(CheckBox2, "Show And Hide Average")
        ToolTip1.SetToolTip(CheckBox3, "Change Color Of This Part")
        ToolTip1.SetToolTip(Button5, "Open Picture")
        ToolTip1.SetToolTip(PictureBox1, "Privew Of Picture")
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Label1.Text = " "
        Else
            Label1.Text = "Sum:" & Sum
        End If
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Label2.Text = " "
        Else
            Label2.Text = "Average:" & Sum / i
        End If
        TextBox1.Focus()
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Button1.ForeColor = Color.Red
            Button2.ForeColor = Color.Red
            Button3.ForeColor = Color.Red
            Button4.ForeColor = Color.Red
            Label1.ForeColor = Color.BlueViolet
            Label2.ForeColor = Color.BlueViolet
            Label3.ForeColor = Color.BlueViolet
            Label4.ForeColor = Color.BlueViolet
            TextBox1.ForeColor = Color.Firebrick
            ListBox1.ForeColor = Color.Firebrick
            CheckBox1.ForeColor = Color.Peru
            CheckBox2.ForeColor = Color.Peru
            CheckBox3.ForeColor = Color.Fuchsia
        Else
            Button1.ForeColor = Color.Black
            Button2.ForeColor = Color.Black
            Button3.ForeColor = Color.Black
            Button4.ForeColor = Color.Black
            Label1.ForeColor = Color.Black
            Label2.ForeColor = Color.Black
            Label3.ForeColor = Color.Black
            Label4.ForeColor = Color.Black
            TextBox1.ForeColor = Color.Black
            ListBox1.ForeColor = Color.Black
            CheckBox1.ForeColor = Color.Black
            CheckBox2.ForeColor = Color.Black
            CheckBox3.ForeColor = Color.Black
        End If
        TextBox1.Focus()
    End Sub
    Dim sx As Integer
    Dim tx As Integer
    Dim gx As Integer
    Dim zx As Integer
    Dim vx As Integer
    Dim dx As Integer
    Dim sy As Boolean
    Dim ty As Boolean
    Dim gy As Boolean
    Dim zy As Boolean
    Dim vy As Boolean
    Dim dy As Boolean

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        tx = Convert.ToInt32(TextBox2.Text)
        TextBox2.Text = ""
        ty = True
        sy = False
        gy = False
        zy = False
        vy = False
        dy = False
        TextBox2.Focus()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        sx = Convert.ToInt32(TextBox2.Text)
        TextBox2.Text = ""
        sy = True
        ty = False
        gy = False
        zy = False
        vy = False
        dy = False
        TextBox2.Focus()

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        zx = Convert.ToInt32(TextBox2.Text)
        TextBox2.Text = ""
        ty = False
        sy = False
        gy = False
        zy = True
        vy = False
        dy = False
        TextBox2.Focus()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        gx = Convert.ToInt32(TextBox2.Text)
        TextBox2.Text = ""
        ty = False
        sy = False
        gy = True
        zy = False
        vy = False
        dy = False
        TextBox2.Focus()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        vx = Convert.ToInt32(TextBox2.Text)
        TextBox2.Text = ""
        ty = False
        sy = False
        gy = False
        zy = False
        vy = True
        dy = False
        TextBox2.Focus()
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        dx = Convert.ToInt32(TextBox2.Text)
        TextBox2.Text = ""
        ty = False
        sy = False
        gy = False
        zy = False
        vy = False
        dy = True
        TextBox2.Focus()
    End Sub

    Private Sub Button22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button22.Click
        If sy = True Then
            Dim sy As Integer
            sy = Convert.ToInt32(TextBox2.Text)
            TextBox2.Text = sx + sy.ToString
        End If
        If ty = True Then
            Dim ty As Integer
            ty = Convert.ToInt32(TextBox2.Text)
            TextBox2.Text = tx - ty.ToString
        End If
        If zy = True Then
            Dim zy As Integer
            zy = Convert.ToInt32(TextBox2.Text)
            TextBox2.Text = zx * zy.ToString
        End If
        If gy = True Then
            Dim gy As Integer
            gy = Convert.ToInt32(TextBox2.Text)
            TextBox2.Text = gx / gy.ToString
        End If
        If vy = True Then
            Dim vy As Integer
            vy = Convert.ToInt32(TextBox2.Text)
            TextBox2.Text = vx ^ vy.ToString
        End If
        If dy = True Then
            Dim dy As Integer
            dy = Convert.ToInt32(TextBox2.Text)
            TextBox2.Text = dx * (dy / 100).ToString
        End If
    End Sub

    Private Sub Button23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button23.Click
        TextBox2.Text = ""
        TextBox2.Focus()
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        TextBox2.Text = TextBox2.Text + "0"
    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        TextBox2.Text = TextBox2.Text + "1"
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        TextBox2.Text = TextBox2.Text + "2"
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        TextBox2.Text = TextBox2.Text + "3"
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        TextBox2.Text = TextBox2.Text + "4"
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        TextBox2.Text = TextBox2.Text + "5"
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        TextBox2.Text = TextBox2.Text + "6"
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        TextBox2.Text = TextBox2.Text + "7"
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        TextBox2.Text = TextBox2.Text + "8"
    End Sub

    Private Sub Button21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button21.Click
        TextBox2.Text = TextBox2.Text + "9"
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = 13 Then
            IntArr(i) = Val(TextBox1.Text)
            ListBox1.Items.Add(CStr(IntArr(i)))
            i = i + 1
            ReDim Preserve IntArr(i)
            TextBox1.Text = ""
            TextBox1.Focus()
        End If

        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
        If KeyAscii = System.Windows.Forms.Keys.Back Then
            e.KeyChar = Chr(KeyAscii)
        End If
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then
            KeyAscii = 0
        End If
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub AverageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AverageToolStripMenuItem.Click
        TextBox1.Text = ""
        ListBox1.Items.Clear()
        TextBox1.Focus()
        Label1.Text = "Sum:0"
        Label2.Text = "Average:0"
    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        TextBox2.Text = ""
        TextBox2.Focus()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripMenuItem.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        MsgBox("Do you want close the program?", MsgBoxStyle.YesNo)
        If MsgBox("Do you want close the program?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class
