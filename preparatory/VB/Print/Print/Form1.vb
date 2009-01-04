Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Dim pfont As Font
        pfont = New Font("Comic Sans MS", 20)
        e.Graphics.DrawString(TextBox1.Text, pfont, Brushes.Black, 0, 0)
        Dim Lmargin, Rmargin, Tmargin, BMargin As Integer
        With PrintDocument1.DefaultPageSettings.Margins
            Lmargin = .Left
            Rmargin = .Right
            Tmargin = .Top
            BMargin = .Bottom
        End With
        Dim printwidth, Printheight As Integer
        With PrintDocument1.DefaultPageSettings.PaperSize
            printwidth = .Width - Lmargin - Rmargin
            Printheight = .Height - Tmargin - BMargin
        End With
        Dim R As Rectangle
        R = New Rectangle(Lmargin, Tmargin, printwidth, Printheight)
        e.Graphics.DrawRectangle(Pens.Black, R)
    End Sub
End Class
