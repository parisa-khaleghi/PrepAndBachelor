# Print Text Application

This is a simple VB.NET application that prints text entered into a textbox control.

# Features
<ul>
  <li>Allows the user to enter text into a textbox control</li>
  <li>Prints the text using the default printer</li>
  <li>Supports page setup and preview before printing</li>
</ul>

# Usage
<ol>
  <li>Type or paste text into the textbox control</li>
  <li>Click on the "Print" button to bring up the page setup dialog</li>
  <li>Choose your printer and adjust any print settings as necessary</li>
  <li>Click on "Print" to print your text</li>
</ol>

# Code Explanation
The 'PrintDocument1_PrintPage' event handler is responsible for rendering the text on the printer. It measures the height and width of the page, determines the number of lines that can fit on a page, and draws each line of text on the page.

The 'GetNextWord' function is used to split the text into individual words for rendering on the page. It skips any non-letter or non-digit characters and returns each word as it is encountered.

The 'Button1_Click' event handler is called when the user clicks the "Print" button. It sets the default page settings using the PageSetupDialog, then displays the PrintPreviewDialog to allow the user to preview and adjust the print layout before printing. If an error occurs during printing, an error message will be displayed.
