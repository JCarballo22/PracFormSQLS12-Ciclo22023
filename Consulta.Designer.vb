<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Consulta))
        Me.cbSeleccionar = New System.Windows.Forms.ComboBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellido = New System.Windows.Forms.TextBox()
        Me.tbSexo = New System.Windows.Forms.TextBox()
        Me.tbCargo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cbSeleccionar
        '
        Me.cbSeleccionar.FormattingEnabled = True
        Me.cbSeleccionar.Location = New System.Drawing.Point(60, 49)
        Me.cbSeleccionar.Name = "cbSeleccionar"
        Me.cbSeleccionar.Size = New System.Drawing.Size(225, 21)
        Me.cbSeleccionar.TabIndex = 0
        Me.cbSeleccionar.Text = "--Selecciones un Empleado--"
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(60, 120)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(225, 20)
        Me.tbNombre.TabIndex = 1
        '
        'tbApellido
        '
        Me.tbApellido.Location = New System.Drawing.Point(60, 158)
        Me.tbApellido.Name = "tbApellido"
        Me.tbApellido.Size = New System.Drawing.Size(225, 20)
        Me.tbApellido.TabIndex = 1
        '
        'tbSexo
        '
        Me.tbSexo.Location = New System.Drawing.Point(60, 194)
        Me.tbSexo.Name = "tbSexo"
        Me.tbSexo.Size = New System.Drawing.Size(37, 20)
        Me.tbSexo.TabIndex = 1
        '
        'tbCargo
        '
        Me.tbCargo.Location = New System.Drawing.Point(60, 239)
        Me.tbCargo.Name = "tbCargo"
        Me.tbCargo.Size = New System.Drawing.Size(134, 20)
        Me.tbCargo.TabIndex = 2
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 329)
        Me.Controls.Add(Me.tbCargo)
        Me.Controls.Add(Me.tbApellido)
        Me.Controls.Add(Me.tbSexo)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.cbSeleccionar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Consulta"
        Me.Text = "Consulta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbSeleccionar As ComboBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbApellido As TextBox
    Friend WithEvents tbSexo As TextBox
    Friend WithEvents tbCargo As TextBox
End Class
