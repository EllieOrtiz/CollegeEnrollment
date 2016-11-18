REM Elizabeth M Ortiz
REM Este programa es una simulacion del proceso de matricula dependiendo el nivel del estudiante: asociado, bachillerato o maestria. 

Public Class Form1

    Dim num_random As New Random   REM Al comenzar el programa el mismo selecciona imagen random
    Dim num_rdm As Integer

    Public student_name As String      REM variables para nombre y numero de estuiante
    Public student_num As String

    Public courses As Integer
    Public total_valcred As Integer
    Public price_credit As Double
    Public require As Double

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Visible = True

        num_rdm = num_random.Next(0, 3)     REM seleccion random de imagen con parametro (0,3) ya que hay 4 imagenes
        REM dependiendo el numero que seleccione el programa es la imagen que presenta
        If num_rdm = 0 Then
            PictureBox1.Image = Image.FromFile("imagen1.jpg")
        End If
        If num_rdm = 1 Then
            PictureBox1.Image = Image.FromFile("imagen2.jpg")
        End If
        If num_rdm = 2 Then
            PictureBox1.Image = Image.FromFile("imagen3.jpg")
        End If
        If num_rdm = 3 Then
            PictureBox1.Image = Image.FromFile("imagen4.jpg")
        End If

        student_name = InputBox("Student Name")        REM inputbox para entrar nombre y numero de estudiante
        student_num = InputBox("Student ID Number")

        Label3.Text = student_name
        Label4.Text = student_num
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        REM en caso de que uno de los labels este vacio, el programa vuelve a preguntar la informacion que falta
        If Label3.Text = "" Then
            MsgBox("Student Name Missing")
            Label3.Text = InputBox("Please Enter Student Name")
        ElseIf Label4.Text = "" Then
            MsgBox("Student ID Number Missing")
            Label4.Text = InputBox("Please Enter Student ID Number")
        End If

        REM dependiendo el grado para el que el estudiante desee matricularse, el programa abre la forma del grado.
        If RadioButton1.Checked = True Then
            asociado.Show()
        ElseIf RadioButton2.Checked = True Then
            bachillerato.Show()
        ElseIf RadioButton3.Checked = True Then
            maestria.Show()
        End If


    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
