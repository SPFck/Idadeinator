Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Regex.IsMatch(TextBox1.Text, "^[0-9 ]+$") Then
            MessageBox.Show("A sua idade é: " + TextBox1.Text)
        End If
    End Sub
End Class
