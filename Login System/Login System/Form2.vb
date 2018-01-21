Imports System.IO

Public Class Form2
    Dim Leitor As StreamReader
    Public x As String = "C:\Supreme-Octo\Login"

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Text = Nothing Or
            TextBox2.Text = Nothing Then
            MsgBox("Insira um Username e uma Password!")
        Else
            File.AppendAllText(x, TextBox1.Text & vbCrLf)
            File.AppendAllText(x, TextBox2.Text & vbCrLf)
            TextBox1.Text = ""
            TextBox2.Text = ""
            MsgBox("Dados Guardados!")
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(x) Then
            Dim y As FileStream
            y = File.Create(x)
            y.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class