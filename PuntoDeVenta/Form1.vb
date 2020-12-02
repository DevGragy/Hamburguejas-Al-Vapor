Imports System.ComponentModel

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton7.Checked = True Then
            TextBox1.Text = "Hamburguesa: Sencilla"
            PictureBox1.Image = My.Resources.sencilla
        ElseIf RadioButton8.Checked = True Then
            TextBox1.Text = "Hamburguesa: Doble"
            PictureBox1.Image = My.Resources.doble
        ElseIf RadioButton9.Checked = True Then
            TextBox1.Text = "Hamburguesa: Especial"
            PictureBox1.Image = My.Resources.especial
        End If

        If CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Lechuga, Jitomate y Queso"
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Lechuga y Jitomate"
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Lechuga y Queso"
        ElseIf CheckBox1.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Lechuga"
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Jitomate y Queso"
        ElseIf CheckBox2.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Jitomate"
        ElseIf CheckBox3.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Queso"
        Else
            TextBox1.Text = TextBox1.Text + vbCrLf + "Ingredientes: Sola"
        End If

        If RadioButton1.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Papas: A la Francesa"
            PictureBox2.Image = My.Resources.french
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Papas: Curveadas"
            PictureBox2.Image = My.Resources.curly
        ElseIf RadioButton3.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Papas: En Gajo"
            PictureBox2.Image = My.Resources.gajo
        End If

        If RadioButton4.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Refresco: Coca-Cola"
            PictureBox3.Image = My.Resources.coca
        ElseIf RadioButton5.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Refresco: Manzanita"
            PictureBox3.Image = My.Resources.manzana
        ElseIf RadioButton6.Checked = True Then
            TextBox1.Text = TextBox1.Text + vbCrLf + "Refresco: Fanta"
            PictureBox3.Image = My.Resources.fanta
        End If

    End Sub

    Private Sub BaseDeDatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BaseDeDatosToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Me.Hide()
        LoginForm1.Show()

    End Sub

    Dim mensaje As MsgBoxResult

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mensaje = CType(MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If mensaje = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
            SplashScreen1.Close()
        End If
    End Sub
End Class