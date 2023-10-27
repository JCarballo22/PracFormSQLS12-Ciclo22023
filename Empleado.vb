Imports System.Data.SqlClient


Public Class Empleado
    Dim conexion As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER; DataBase=BDEmpresa;Integrated Security=True")
    Dim conexion2 As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER;DataBase=BDEmpresa; User Id=Carmen;Password=12345")


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            Dim comando As New SqlCommand("Insert Into Empleado(Nombre,Apellido,sexo,Cargo) 
                                      Values('" & tbNombre.Text.Trim & "','" & tbApellido.Text.Trim & "','" & Me.lbSexo.SelectedValue & "','" & Me.cbCargo.SelectedValue & "')", conexion)
            conexion.Open()
            comando.ExecuteNonQuery()
            MsgBox("Se ha Guardado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conexion.Close()
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

    Sub CargarCargo()
        Try
            Dim consulta = "Select * From Cargo"
            Dim da As New SqlDataAdapter(consulta, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "Cargo")
            Me.cbCargo.DataSource = ds.Tables("Cargo")
            Me.cbCargo.DisplayMember = "Nombre"
            Me.cbCargo.ValueMember = "IdCargo"

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CargarSexo()
        Try
            Dim consulta = "Select * From Sexo"
            Dim da As New SqlDataAdapter(consulta, conexion)
            Dim ds As New DataSet
            da.Fill(ds, "Sexo")
            Me.lbSexo.DataSource = ds.Tables("Sexo")
            Me.lbSexo.DisplayMember = "Genero"
            Me.lbSexo.ValueMember = "IdSexo"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCargo()
        CargarSexo()
    End Sub
End Class
