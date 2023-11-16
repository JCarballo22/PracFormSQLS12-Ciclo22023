<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgTabla = New System.Windows.Forms.DataGridView()
        Me.btnMostrarDatos = New System.Windows.Forms.Button()
        CType(Me.dgTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgTabla
        '
        Me.dgTabla.AllowUserToAddRows = False
        Me.dgTabla.AllowUserToDeleteRows = False
        Me.dgTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgTabla.Location = New System.Drawing.Point(38, 168)
        Me.dgTabla.Name = "dgTabla"
        Me.dgTabla.ReadOnly = True
        Me.dgTabla.Size = New System.Drawing.Size(469, 258)
        Me.dgTabla.TabIndex = 0
        '
        'btnMostrarDatos
        '
        Me.btnMostrarDatos.Location = New System.Drawing.Point(213, 92)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(98, 23)
        Me.btnMostrarDatos.TabIndex = 1
        Me.btnMostrarDatos.Text = "Mostrar Datos"
        Me.btnMostrarDatos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 450)
        Me.Controls.Add(Me.btnMostrarDatos)
        Me.Controls.Add(Me.dgTabla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgTabla As DataGridView
    Friend WithEvents btnMostrarDatos As Button
End Class
