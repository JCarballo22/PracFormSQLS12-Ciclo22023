<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgTabla = New System.Windows.Forms.DataGridView()
        Me.btnMostrarDatos = New System.Windows.Forms.Button()
        Me.tbExaminar = New System.Windows.Forms.TextBox()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.cbImagen = New System.Windows.Forms.ComboBox()
        Me.pbImagen = New System.Windows.Forms.PictureBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.dgTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnMostrarDatos.Location = New System.Drawing.Point(52, 44)
        Me.btnMostrarDatos.Name = "btnMostrarDatos"
        Me.btnMostrarDatos.Size = New System.Drawing.Size(98, 23)
        Me.btnMostrarDatos.TabIndex = 1
        Me.btnMostrarDatos.Text = "Mostrar Datos"
        Me.btnMostrarDatos.UseVisualStyleBackColor = True
        '
        'tbExaminar
        '
        Me.tbExaminar.Location = New System.Drawing.Point(169, 47)
        Me.tbExaminar.Name = "tbExaminar"
        Me.tbExaminar.Size = New System.Drawing.Size(162, 20)
        Me.tbExaminar.TabIndex = 2
        '
        'btnExaminar
        '
        Me.btnExaminar.Location = New System.Drawing.Point(52, 83)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(98, 23)
        Me.btnExaminar.TabIndex = 3
        Me.btnExaminar.Text = "Examinar"
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'cbImagen
        '
        Me.cbImagen.FormattingEnabled = True
        Me.cbImagen.Location = New System.Drawing.Point(169, 85)
        Me.cbImagen.Name = "cbImagen"
        Me.cbImagen.Size = New System.Drawing.Size(162, 21)
        Me.cbImagen.TabIndex = 4
        '
        'pbImagen
        '
        Me.pbImagen.BackColor = System.Drawing.Color.White
        Me.pbImagen.Location = New System.Drawing.Point(362, 32)
        Me.pbImagen.Name = "pbImagen"
        Me.pbImagen.Size = New System.Drawing.Size(135, 115)
        Me.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImagen.TabIndex = 5
        Me.pbImagen.TabStop = False
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(52, 124)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(98, 23)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 450)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.pbImagen)
        Me.Controls.Add(Me.cbImagen)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.tbExaminar)
        Me.Controls.Add(Me.btnMostrarDatos)
        Me.Controls.Add(Me.dgTabla)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgTabla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgTabla As DataGridView
    Friend WithEvents btnMostrarDatos As Button
    Friend WithEvents tbExaminar As TextBox
    Friend WithEvents btnExaminar As Button
    Friend WithEvents cbImagen As ComboBox
    Friend WithEvents pbImagen As PictureBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
