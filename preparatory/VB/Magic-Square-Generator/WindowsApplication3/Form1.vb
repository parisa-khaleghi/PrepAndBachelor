Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ary(TextBox1.Text, TextBox1.Text) As Integer, i As Integer, j As Integer
        Dim k As Integer, n As Integer
        n = TextBox1.Text
        For i = 0 To i - 1
            For j = 0 To n - 1
                ary(i, j) = 0
            Next
        Next
        i = 0
        j = (n \ 2)
        For k = 1 To n ^ 2
            If ary(i, j) = 0 Then
                ary(i, j) = k
            Else
            i = i + 2
            j = j + 1
                If i > (n - 1) Then i = 0
                If j > (n - 1) Then j = 0
                If i = 0 Then i = i + 1
                If j = 0 Then j = j
                ary(i, j) = k
            End If
            MsgBox("  i = " & CStr(i) & "   j = " & CStr(j) & "      num = " & CStr(ary(i, j)))
            i = i - 1
            j = j - 1
            If i < 0 Then i = n - 1
            If j < 0 Then j = n - 1
        Next
    End Sub
End Class
