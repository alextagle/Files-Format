Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If

        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace

        If e.KeyChar = Chr(13) Then TextBox2.Focus() 'Enter key moves to specified control
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsLetter(e.KeyChar) Then
            e.Handled = True
        End If


        If e.KeyChar = Chr(8) Then e.Handled = False 'allow Backspace

        If e.KeyChar = Chr(13) Then TextBox2.Focus() 'Enter key moves to specified control
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Creating .txt file with file path
        Dim path As String = "c:\temp\Text Format.txt"
        Dim fs As FileStream = File.Create(path)
        Dim name, age, address As String

        'Getting entered info
        name = TextBox1.Text
        age = TextBox2.Text
        address = TextBox3.Text

        'Writing the entered info into the txt file
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("Name: " + name + vbCrLf + "Age: " + age + vbCrLf + "Address: " + address)
        fs.Write(info, 0, info.Length)
        MsgBox("Successfully created Text file!" + vbCrLf + "Saved in C:\Temp\Text Format.txt", MsgBoxStyle.Information, "Txt File")
        fs.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Creating .txt file with file path
        Dim path As String = "c:\temp\XML Format.xml"
        Dim fs As FileStream = File.Create(path)
        Dim name, age, address As String

        'Getting entered info
        name = TextBox1.Text
        age = TextBox2.Text
        address = TextBox3.Text

        'Writing the entered info into the xml file
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("<article lang=''''>" + vbCrLf + "     <para>Name: " + name + "</para>" + vbCrLf +
              "     <para>Age: " + age + "</para>" + vbCrLf + "     <para>Address: " + address + "</para>" +
               vbCrLf + "</article>")
        fs.Write(info, 0, info.Length)
        MsgBox("Successfully created XML file!" + vbCrLf + "Saved in C:\Temp\XML Format.xml", MsgBoxStyle.Information, "XML File")
        fs.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Creating .txt file with file path
        Dim path As String = "c:\temp\JSON Format.json"
        Dim fs As FileStream = File.Create(path)
        Dim name, age, address As String

        'Getting entered info
        name = TextBox1.Text
        age = TextBox2.Text
        address = TextBox3.Text

        'Writing the entered info into the json file
        Dim info As Byte() = New UTF8Encoding(True).GetBytes("{" + vbCrLf + "'Name:' " + "'" + name + "'" + "," + vbCrLf + "'Age:' " + "'" + age + "'" + "," + vbCrLf + "'Address:' " + "'" + address + "'" + vbCrLf + "}")
        fs.Write(info, 0, info.Length)
        MsgBox("Successfully created JSON file" + vbCrLf + "Saved in C:\Temp\JSON Format.json", MsgBoxStyle.Information, "JSON File")
        fs.Close()
    End Sub
End Class
