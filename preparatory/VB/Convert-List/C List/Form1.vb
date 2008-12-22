Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For a As Integer = 0 To 10
            CheckedListBox1.Items.Add(a, True)
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        For b As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(b) = True Then
                ListBox1.Items.Add(CheckedListBox1.Items(b))
            End If
        Next
    End Sub
End Class
