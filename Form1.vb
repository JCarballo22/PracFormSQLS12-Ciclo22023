Imports System.Data.SqlClient

Public Class Form1
    Dim conexion As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER; DataBase=BDEmpresa;Integrated Security=True")

    Sub MostrarDatos()
        Try
            Dim consulta As String = "Select E.Nombre, E.Apellido,  S.Genero, C.Cargo
                                    From Empleado E
                                    Join Sexo S On S.IdSexo = E.Sexo
                                    Join Cargo C On C.IdCargo = E.Cargo;"
            Dim da As New SqlDataAdapter(consulta, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "Empleado")
            dgTabla.DataSource = ds.Tables("Empleado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrarDatos_Click(sender As Object, e As EventArgs) Handles btnMostrarDatos.Click
        MostrarDatos()
    End Sub
End Class