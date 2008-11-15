Public Class Form1
    Dim IntArr() As Short
    Dim sum As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If IsNumeric(TextBox1.Text) Then
            ReDim Preserve IntArr(UBound(IntArr) + 1)
            IntArr(UBound(IntArr)) = CShort(Trim(TextBox1.Text))
            sum = sum + Val(Trim(TextBox1.Text))
            Label1.Text = "tedad: " & UBound(IntArr) & vbNewLine
            Label1.Text = Label1.Text & "Sum : " & sum & vbNewLine
            Label1.Text = Label1.Text & "Average : " & sum / UBound(IntArr)
            TextBox1.Text = ""
            TextBox1.Focus()
        Else
            MsgBox("Textbox Is Empty")
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ReDim Preserve IntArr(0)
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Back Then
            GoTo EventExitSub
        End If
        If KeyAscii < Asc("0") Or KeyAscii > Asc("9") Then
            KeyAscii = 0
        End If
EventExitSub:
        e.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            e.Handled = True
        End If
    End Sub
End Class
