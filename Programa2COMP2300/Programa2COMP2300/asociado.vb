Public Class asociado

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form_hojamatri.Show()

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        REM se inicializan las variables
        Form1.courses = 0
        Form1.total_valcred = 0
        Form1.price_credit = 0
        REM suma los cursos, creditos y el precio de los creditos dependiendo los cursos seleccionados en los checkboxes
        If CheckBox1.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.price_credit = Form1.price_credit + (3 * 150)
        End If
        If CheckBox2.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 4
            Form1.price_credit = Form1.price_credit + (4 * 150)
        End If
        If CheckBox3.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.price_credit = Form1.price_credit + (3 * 150)
        End If
        If CheckBox4.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.price_credit = Form1.price_credit + (3 * 150)
        End If
        If CheckBox5.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 5
            Form1.price_credit = Form1.price_credit + (5 * 150)
        End If
        If CheckBox6.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 2
            Form1.price_credit = Form1.price_credit + (2 * 150)
        End If
        Label1.Text = Form1.courses
        Label3.Text = Form1.total_valcred
        Label6.Text = FormatCurrency(Form1.price_credit, 2)


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class