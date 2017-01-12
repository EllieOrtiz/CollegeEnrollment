Public Class maestria

    Private Sub maestria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBox2.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM presenta cursos de requisito
        GroupBox2.Visible = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form_hojamatri.Visible = True

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        REM se inicializan las variables
        Form1.courses = 0
        Form1.total_valcred = 0
        Form1.require = 0
        Form1.price_credit = 0

        REM suma los cursos, creditos y el precio de los creditos dependiendo los cursos seleccionados en los checkboxes
        If CheckBox1.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 4
            Form1.price_credit = Form1.price_credit + (4 * 200)
        End If
        If CheckBox2.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.price_credit = Form1.price_credit + (3 * 200)
        End If
        If CheckBox3.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.price_credit = Form1.price_credit + (3 * 200)
        End If
        If CheckBox4.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 2
            Form1.price_credit = Form1.price_credit + (2 * 200)
        End If
        If CheckBox5.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.price_credit = Form1.price_credit + (3 * 200)
        End If
        If CheckBox6.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 4
            Form1.price_credit = Form1.price_credit + (4 * 200)
        End If
        REM precio cambia ya que los precios de los prerequisitos son de bachillerato
        If CheckBox7.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 3
            Form1.require = Form1.require + (3 * 175)
        End If
        If CheckBox8.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 4
            Form1.require = Form1.require + (4 * 175)
        End If
        If CheckBox9.Checked = True Then
            Form1.courses = Form1.courses + 1
            Form1.total_valcred = Form1.total_valcred + 4
            Form1.require = Form1.require + (4 * 175)
        End If

        REM presenta el total de cursos, creditos y precio total de los creditos
        Label2.Text = Form1.courses
        Label4.Text = Form1.total_valcred
        Label6.Text = FormatCurrency(Form1.price_credit + Form1.require, 2)
    End Sub
End Class