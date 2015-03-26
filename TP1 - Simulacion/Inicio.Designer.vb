<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_generador = New System.Windows.Forms.Button()
        Me.cmd_chi = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Por favor, elija una opción:"
        '
        'cmd_generador
        '
        Me.cmd_generador.Location = New System.Drawing.Point(90, 138)
        Me.cmd_generador.Name = "cmd_generador"
        Me.cmd_generador.Size = New System.Drawing.Size(110, 69)
        Me.cmd_generador.TabIndex = 2
        Me.cmd_generador.Text = "Generador N° Aleatorio"
        Me.cmd_generador.UseVisualStyleBackColor = True
        '
        'cmd_chi
        '
        Me.cmd_chi.Location = New System.Drawing.Point(235, 138)
        Me.cmd_chi.Name = "cmd_chi"
        Me.cmd_chi.Size = New System.Drawing.Size(106, 69)
        Me.cmd_chi.TabIndex = 3
        Me.cmd_chi.Text = "Prueba de Chi Cuadrado"
        Me.cmd_chi.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(86, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Bienvenido al TP N° 1 de Simulación"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 259)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_chi)
        Me.Controls.Add(Me.cmd_generador)
        Me.Controls.Add(Me.Label1)
        Me.Location = New System.Drawing.Point(382, 158)
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_generador As System.Windows.Forms.Button
    Friend WithEvents cmd_chi As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
