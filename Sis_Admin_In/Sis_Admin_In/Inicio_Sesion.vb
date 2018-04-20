Imports System.Data.SqlClient
Public Class Inicio_Sesion
    'Dim conexionsql As New SqlConnection("Data Source ='CARDENAS-PC'; Initial Catalog = 'INVENTARIO_DB'; Integrated security = true")
    Dim comando As SqlCommand = conexionsql.CreateCommand
    Dim lector As SqlDataReader
    Private Sub Inicio_Sesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexionsql.Open()
    End Sub

    Public Sub btn_aceptar_Click(sender As Object, e As EventArgs) Handles btn_aceptar.Click
        If txt_usuario.Text = "" Or txt_cusuario.Text = "" Then
            MessageBox.Show("Llene el campo vacio", "¡Error Campo Vacio!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If txt_usuario.Text = "" Then
                txt_usuario.Focus()
            Else
                txt_cusuario.Focus()
            End If
        Else
            Dim usuario, pass, u, c As String
            usuario = txt_usuario.Text
            pass = txt_cusuario.Text
            Try
                comando.CommandText = "SELECT nUsuario,cUsuario FROM USUARIOS WHERE nusuario = '" & usuario & "'"
                lector = comando.ExecuteReader
                lector.Read()
                u = lector(0).ToString
                c = lector(1).ToString
                lector.Close()
                If usuario = u And pass = c Then
                    Visible = False
                    conexionsql.Dispose()
                    conexionsql.Close()
                    SqlConnection.ClearAllPools()
                    Principal.Show()
                Else
                    MessageBox.Show("Usuario o Contraseña Incorrecto", "¡Error De Informacion!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Dispose()
    End Sub

    Private Sub txt_cusuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cusuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            btn_aceptar.PerformClick()
        End If
    End Sub

    Private Sub txt_usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_usuario.KeyPress
        If Asc(e.KeyChar) = 13 Then
            txt_cusuario.Focus()
        End If
    End Sub
End Class