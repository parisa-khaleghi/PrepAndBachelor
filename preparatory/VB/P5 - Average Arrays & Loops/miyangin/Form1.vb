Public Class Form1
    Dim intarr() As Short
    Dim sum As Double
    Dim i As Object
    Dim j As Short
    Dim s As Short
    Dim n As Object
    Dim b As Object
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        intarr(i) = Val(TextBox1.Text)
        ListBox1.Items.Add(CStr(intarr(i)))
        i = i + 1
        ReDim intarr(i)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        For j = 0 To i - 1
            sum = sum + intarr(j)
        Next
        Label2.Text = sum
        Label3.Text = sum / i
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim intarr(1)
        i = 0
        b = 0
        n = 1
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim keyAscii As Short = Asc(e.KeyChar)
        If keyAscii = 13 Then
            intarr(i) = Val(TextBox1.Text)
            ListBox1.Items.Add(CStr(intarr(i)))
            i = i + 1
            ReDim intarr(i)
            TextBox1.Text = ""
            TextBox1.Focus()
        End If
        e.KeyChar = Chr(keyAscii)
        If keyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class
