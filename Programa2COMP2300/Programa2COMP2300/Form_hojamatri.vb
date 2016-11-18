Public Class Form_hojamatri

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        REM presenta nombre y numero de estudiante
        Label20.Text = Form1.student_name
        Label19.Text = Form1.student_num
        REM presenta nivel de estudio
        If Form1.RadioButton1.Checked = True Then
            Label18.Text = "Asociado"
        ElseIf Form1.RadioButton2.Checked = True Then
            Label18.Text = "Bachillerato"
        ElseIf Form1.RadioButton3.Checked = True Then
            Label18.Text = "Maestría"
        End If
        REM presenta precios de matricula y total
        Label7.Text = FormatCurrency(Form1.price_credit, 2)
        Label8.Text = FormatCurrency(Form1.require, 2)
        Label9.Text = FormatCurrency(75, 2)
        Label10.Text = FormatCurrency(50, 2)
        Label21.Text = FormatCurrency(15, 2)
        Label15.Text = FormatCurrency(Form1.price_credit + 75 + 50 + 15 + Form1.require, 2)

    End Sub
End Class