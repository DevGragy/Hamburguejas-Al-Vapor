Imports System.ComponentModel

Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "root" Then
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
            Me.Hide()
            Form1.Show()
        Else
            MessageBox.Show("Usuario y Contraseña incorrectos")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim mensaje As MsgBoxResult

    Private Sub LoginForm1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mensaje = CType(MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If mensaje = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
            SplashScreen1.Close()
        End If
    End Sub
End Class
