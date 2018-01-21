Imports System.IO
Public Class Form1
    Dim Leitor As StreamReader
    Public x As String = "C:\Supreme-Octo\Login"
    Dim z As String
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tempu, tempp, a As String
        If TextBox1.Text = Nothing Or
            TextBox2.Text = Nothing Then
            MsgBox("Insira um Username e\ou Password!")
        Else
            tempp = 0
            z = 0
            a = 0
            Leitor = File.OpenText(x)
            While a = 0 And Leitor.Peek <> -1
                z = Leitor.ReadLine()
                tempu = z
                z = Leitor.ReadLine()
                tempp = z
                If TextBox1.Text = tempu Then
                    a = 1
                End If
            End While
            If a = 1 Then
                If TextBox2.Text = tempp Then
                    MsgBox("O Login foi Realizado com Sucesso!")
                    Me.Hide()
                    Form3.Show()
                Else
                    TextBox2.Text = ""
                    MsgBox("Password Errada!")
                End If
            Else
                TextBox1.Text = ""
                TextBox2.Text = ""
                MsgBox("Username Nao Encontrado!(Antes de Fazer Login Confirme que ja se Registou)")
            End If
        End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not File.Exists(x) Then
            Dim y As FileStream
            y = File.Create(x)
            y.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub
End Class
