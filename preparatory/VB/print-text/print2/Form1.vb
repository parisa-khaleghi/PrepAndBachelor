Imports System.IO
Public Class Form1

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim txtfont As New Font("Arial", 10)
        Dim lmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Left
        Dim tmargin As Integer = PrintDocument1.DefaultPageSettings.Margins.Top
        Dim txth As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Height - PrintDocument1.DefaultPageSettings.Margins.Top - PrintDocument1.DefaultPageSettings.Margins.Bottom
        Dim txtw As Integer = PrintDocument1.DefaultPageSettings.PaperSize.Width - PrintDocument1.DefaultPageSettings.Margins.Left - PrintDocument1.DefaultPageSettings.Margins.Right
        Dim linesperpage As Integer = e.MarginBounds.Height / txtfont.GetHeight(e.Graphics)
        Dim R As New RectangleF(lmargin, tmargin, txtw, txth)
        Static line As String
        Dim word As String
        Dim cols, lines As Integer
        word = GetNextWord()
        While word <> "" And line < linesperpage
            line = line & word
            word = GetNextWord()
            e.Graphics.MeasureString(line & word, txtfont, New SizeF(txtw, txth), New StringFormat(), cols, lines)
        End While
        If word = "" And Trim(line) <> "" Then
            e.Graphics.DrawString(line, txtfont, Brushes.Black, R, New StringFormat())
            e.HasMorePages = False
            Exit Sub
        End If
        e.Graphics.DrawString(line, txtfont, Brushes.Black, R, New StringFormat())
        e.HasMorePages = True
        line = word
    End Sub
    Function GetNextWord(optioal ByVal reset as boolean = false)as String
        Static currpos As Integer
        Dim word As String
        If Reset() Then currpos = 0
        If currpos >= TextBox1.Text.Length Then Return ""
        While Not System.Char.IsLetterOrDigit(TextBox1.Text.Chars(currpos))
            word = word & TextBox1.Text.Chars(currpos)
            currpos = currpos + 1
            If currpos >= TextBox1.Text.Length Then Return word
        End While
        While Not (System.Char.IsWhiteSpace(TextBox1.Text.Chars(currpos)))
            word = word & TextBox1.Text.Chars(currpos)
            currpos = currpos + 1
            If currpos >= TextBox1.Text.Length Then Return word
        End While
        Return word
    End Function
    Dim texttoprint As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        texttoprint = TextBox1.Text
        PageSetupDialog1.PageSettings = PrintDocument1.DefaultPageSettings
        If PageSetupDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.DefaultPageSettings = PageSetupDialog1.PageSettings
        End If
        Try
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
        Catch ex As Exception
            MsgBox(("Print Operation Failed" & vbCrLf & exc.Message))
        End Try
    End Sub
End Class
