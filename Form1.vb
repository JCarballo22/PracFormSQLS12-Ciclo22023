Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Security.Cryptography


Public Class Form1
    Dim conexion As New SqlConnection("Server=LAPTOP-ENVY-PC\SQLSERVER; DataBase=BDEmpresa;Integrated Security=True")
    ' Dim conexion As New SqlConnection("DataSource=LAPTOP-ENVY-PC\SQLSERVER;Initial Catalog=BDEmpresa;Integrated Security=True")
    ' Dim OpenFileDialog1 As Object
    Dim comando As New SqlCommand
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



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.Filter = "Todos(*.Jpg,*.Png,*.Giff,*.Tiff,*.Jpeg,*.Bmp)|*.Jpg;*.Png;*.Giff;*.Tiff;*.Jpeg;*.Bmp"
        ExtraerImagen()
    End Sub

    Private Sub btnExaminar_Click(sender As Object, e As EventArgs) Handles btnExaminar.Click
        Try
            OpenFileDialog1.ShowDialog()
            tbExaminar.Text = OpenFileDialog1.FileName.ToString
            pbImagen.Image = System.Drawing.Image.FromFile(tbExaminar.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub ExtraerImagen()
        Try
            Dim consulta = "Select * From Imagen;"
            Dim da As New SqlDataAdapter(consulta, conexion)
            Dim dt As New DataTable
            da.Fill(dt)
            With cbImagen
                .DataSource = dt
                .DisplayMember = "IdImagen"
                .ValueMember = "IdImagen"
            End With
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Try
            conexion.Open()
            Dim arrFilename() As String = Split(Text, "\")
            Array.Reverse(arrFilename)
            Dim ms As New MemoryStream
            pbImagen.Image.Save(ms, pbImagen.Image.RawFormat)
            Dim ArrImage() As Byte = ms.GetBuffer
            With comando
                .CommandType = CommandType.Text
                .CommandText = "Insert Into Imagen(Imagen)
                                Values(@Imagen)"
                .Connection = conexion
                .Parameters.Add(New SqlParameter("@Imagen", SqlDbType.Image)).Value = ArrImage
            End With
            MessageBox.Show("Imagen Registrada")
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            comando.Parameters.Clear()
            conexion.Close()
            ExtraerImagen()
        End Try

    End Sub

    Function ExtraerImagen(ByVal Foto As Integer) As Byte()
        Dim comando As New SqlCommand
        With comando
            .CommandType = CommandType.Text
            .CommandText = "Select Imagen From Imagen Where IdImagen = " & Foto
            .Connection = conexion
        End With
        With conexion
            .Open()
            Dim MiFoto() As Byte = CType(comando.ExecuteScalar(), Byte())
            .Close()
            Return MiFoto
        End With
    End Function

    Private Sub cbImagen_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbImagen.SelectedValueChanged
        Try
            Dim ms As New MemoryStream(ExtraerImagen(cbImagen.SelectedValue.ToString))
            pbImagen.Image = Image.FromStream(ms)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class