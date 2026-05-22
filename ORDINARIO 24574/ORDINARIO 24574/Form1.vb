Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = "Subtotal: $" & TextBox1.Text * TextBox2.Text
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim textote As String = TextBox2.Text
        textote += 1
        TextBox2.Text = textote
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim textito As String = TextBox2.Text
        If textito > 0 Then
            textito -= 1
        ElseIf textito = 0 Then
            textito = 0
        End If
        TextBox2.Text = textito
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label5.Text = "IVA (16%): $" & TextBox1.Text * TextBox2.Text * 0.16
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label6.Text = "TOTAL: $" & TextBox1.Text * TextBox2.Text * 1.16
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = 0
        TextBox2.Text = 0
        Label5.Text = "IVA (16%): $" & TextBox1.Text * TextBox2.Text * 0.16
        Label6.Text = "TOTAL: $" & TextBox1.Text * TextBox2.Text * 1.16
        Label4.Text = "Subtotal: $" & TextBox1.Text * TextBox2.Text
    End Sub

    'agregue un boton de reset para mejorar la posible experiencia de usuario :) y porque está padre programar, solo expanda la ventana hacía abajo
End Class
