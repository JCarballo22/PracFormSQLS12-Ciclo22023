Imports System.Data.SqlClient

Public Class Consulta
    Dim conexion As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER; DataBase=BDEmpresa;Integrated Security=True")

    Private Sub Consulta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarSeleccion()
    End Sub

    Sub CargarSeleccion()
        Dim consulta = "Select * From Empleado Order By IdCodigo"
        Dim da As New SqlDataAdapter(consulta, conexion)
        Dim dt = New DataTable
        da.Fill(dt)
        With cbSeleccionar
            .DataSource = dt
            .DisplayMember = "Nombre"
            .ValueMember = "IdCodigo"
        End With

    End Sub

    Private Sub cbSeleccionar_TextChanged(sender As Object, e As EventArgs) Handles cbSeleccionar.TextChanged
        Try
            If cbSeleccionar.ValueMember.ToString <> "" Then
                ''Dim consulta = "Select * From Empleado 
                '            Where IdCodigo =" + cbSeleccionar.SelectedValue.ToString + ""
                Dim consulta = "Select E.IdCodigo, E.Nombre, E.Apellido,  S.Genero, C.Cargo
                                From Empleado E
                                Join Sexo S On S.IdSexo = E.Sexo
                                Join Cargo C On C.IdCargo = E.Cargo Where IdCodigo =" + cbSeleccionar.SelectedValue.ToString + ""

                Dim da = New SqlDataAdapter(consulta, conexion)
                Dim dt = New DataTable
                da.Fill(dt)
                For Each fila As DataRow In dt.Rows
                    tbNombre.Text = fila("Nombre").ToString
                    tbApellido.Text = fila("Apellido").ToString
                    tbSexo.Text = fila("Genero").ToString
                    tbCargo.Text = fila("Cargo").ToString
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Dim mensajeError = ""
        If tbNombre.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Nombre"
        End If
        If tbApellido.Text = "" Then
            mensajeError = mensajeError & "Falta Ingresar el Apellido"
        End If

        Try
            Dim consulta = "Update Empleado 
                            set Nombre ='" & tbNombre.Text & "', 
                            Apellido = '" & tbApellido.Text & "'
                            Where IdCodigo =" & cbSeleccionar.SelectedValue.ToString & ";"
            Dim comando As New SqlCommand(consulta, conexion)
            conexion.Open()
            Dim leer = comando.ExecuteReader()
            leer.Close()
            MsgBox("Se ha actualizado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarSeleccion()
        tbNombre.Text = ""
        tbApellido.Text = ""
        tbSexo.Text = ""
        tbCargo.Text = ""

    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim consulta As New SqlCommand("Delete From Empleado 
                                            Where IdCodigo = " & cbSeleccionar.SelectedValue.ToString & ";", conexion)
            conexion.Open()
            consulta.ExecuteNonQuery()
            conexion.Close()
            MsgBox("Se ha eliminado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        CargarSeleccion()
        tbNombre.Text = ""
        tbApellido.Text = ""
        tbSexo.Text = ""
        tbCargo.Text = ""

    End Sub
End Class