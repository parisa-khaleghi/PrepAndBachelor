Public Class Form1
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

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim n As Object
        Dim b As Object
        ReDim Preserve IntArr(1)
        i = 0
        b = 0
        n = 1

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

    End Sub
End Class
