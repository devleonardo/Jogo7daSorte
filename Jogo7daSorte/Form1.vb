Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        imagemResultado.Visible = False
        num1.Text = CStr(Int(Rnd() * 10)) 'Escolhe 1º número aleatório de 1 a 10
        num2.Text = CStr(Int(Rnd() * 10)) 'Escolhe 2º número aleatório de 1 a 10
        num3.Text = CStr(Int(Rnd() * 10)) 'Escolhe 3º número aleatório de 1 a 10
        'Se todos os numeros forem iguais a 7
        If (num1.Text = "7") And (num2.Text = "7") And (num3.Text = "7") Then
            imagemResultado.Image = Image.FromFile("C:\Users\leona\source\repos\Jogo7daSorte\img\GanhouMax.jpg")
            imagemResultado.Visible = True
            Beep()
            'Se um dos numeros forem iguais a 7
        ElseIf (num1.Text = "7") Or (num2.Text = "7") Or (num3.Text = "7") Then
            imagemResultado.Image = Image.FromFile("C:\Users\leona\source\repos\Jogo7daSorte\img\Ganhou.jpg")
            imagemResultado.Visible = True
            Beep()
            'Se nenhum numero for igual a 7
        Else
            imagemResultado.Image = Image.FromFile("C:\Users\leona\source\repos\Jogo7daSorte\img\Perdeu.jpg")
            imagemResultado.Visible = True
            Beep()
        End If

    End Sub
End Class
