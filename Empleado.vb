Imports System.Data.SqlClient


Public Class Empleado
    Dim conexion As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER; DataBase=BDEmpresa;Integrated Security=True")
    Dim conexion2 As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER;DataBase=BDEmpresa; User Id=sa;Password=123456")


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim comando As New SqlCommand("Insert Into Empleado(Nombre,Apellido,sexo,Cargo) 
                                      Values('" & tbNombre.Text.Trim & "','" & tbApellido.Text.Trim & "','" & Me.lbSexo.Text.Trim & "','" & Me.cbCargo.Text.Trim & "')", conexion2)
            conexion2.Open()
            comando.ExecuteNonQuery()
            MsgBox("Se ha Guardado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion2.Close()
            MsgBox("Se Cerro la conexión")
            tbNombre.Text = ""
            tbApellido.Text = ""
            lbSexo.Text = ""
            cbCargo.Text = "Seleccione..."
        End Try





    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
