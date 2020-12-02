Imports System.ComponentModel

Public Class Form2
    Private Sub ClientesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BimboDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BimboDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BimboDataSet.Clientes)

    End Sub

    Private Sub OrdenesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrdenesToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub CerrarSesionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesionToolStripMenuItem.Click
        Me.Hide()
        LoginForm1.Show()
    End Sub

    Dim mensaje As MsgBoxResult

    Private Sub Form2_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        mensaje = CType(MessageBox.Show("Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question), MsgBoxResult)
        If mensaje = MsgBoxResult.No Then
            e.Cancel = True
        Else
            e.Cancel = False
            SplashScreen1.Close()
        End If
    End Sub

End Class