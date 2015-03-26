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
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.NumA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.txt_constante = New System.Windows.Forms.TextBox()
        Me.rb_multi = New System.Windows.Forms.RadioButton()
        Me.rb_mixto = New System.Windows.Forms.RadioButton()
        Me.lbl_raiz = New System.Windows.Forms.Label()
        Me.lbl_constante = New System.Windows.Forms.Label()
        Me.cmd_nuevo_numero = New System.Windows.Forms.Button()
        Me.txt_multiplicador = New System.Windows.Forms.TextBox()
        Me.lbl_multiplicador = New System.Windows.Forms.Label()
        Me.cmd_reiniciar = New System.Windows.Forms.Button()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(30, 226)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(86, 47)
        Me.cmd_generar.TabIndex = 5
        Me.cmd_generar.Text = "GENERAR"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grilla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NumA, Me.Column2})
        Me.grilla.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.grilla.Location = New System.Drawing.Point(351, 12)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(246, 376)
        Me.grilla.TabIndex = 9
        '
        'NumA
        '
        Me.NumA.HeaderText = "Orden"
        Me.NumA.Name = "NumA"
        Me.NumA.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "N° Aleatorio"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'txt_semilla
        '
        Me.txt_semilla.Location = New System.Drawing.Point(149, 37)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(100, 20)
        Me.txt_semilla.TabIndex = 0
        '
        'txt_constante
        '
        Me.txt_constante.Location = New System.Drawing.Point(149, 174)
        Me.txt_constante.Name = "txt_constante"
        Me.txt_constante.Size = New System.Drawing.Size(100, 20)
        Me.txt_constante.TabIndex = 4
        Me.txt_constante.Visible = False
        '
        'rb_multi
        '
        Me.rb_multi.AutoSize = True
        Me.rb_multi.Location = New System.Drawing.Point(30, 75)
        Me.rb_multi.Name = "rb_multi"
        Me.rb_multi.Size = New System.Drawing.Size(86, 17)
        Me.rb_multi.TabIndex = 1
        Me.rb_multi.TabStop = True
        Me.rb_multi.Text = "Multiplicativo"
        Me.rb_multi.UseVisualStyleBackColor = True
        '
        'rb_mixto
        '
        Me.rb_mixto.AutoSize = True
        Me.rb_mixto.Location = New System.Drawing.Point(30, 110)
        Me.rb_mixto.Name = "rb_mixto"
        Me.rb_mixto.Size = New System.Drawing.Size(50, 17)
        Me.rb_mixto.TabIndex = 2
        Me.rb_mixto.TabStop = True
        Me.rb_mixto.Text = "Mixto"
        Me.rb_mixto.UseVisualStyleBackColor = True
        '
        'lbl_raiz
        '
        Me.lbl_raiz.AutoSize = True
        Me.lbl_raiz.Location = New System.Drawing.Point(27, 37)
        Me.lbl_raiz.Name = "lbl_raiz"
        Me.lbl_raiz.Size = New System.Drawing.Size(33, 13)
        Me.lbl_raiz.TabIndex = 8
        Me.lbl_raiz.Text = "Raíz:"
        '
        'lbl_constante
        '
        Me.lbl_constante.AutoSize = True
        Me.lbl_constante.Location = New System.Drawing.Point(27, 174)
        Me.lbl_constante.Name = "lbl_constante"
        Me.lbl_constante.Size = New System.Drawing.Size(58, 13)
        Me.lbl_constante.TabIndex = 11
        Me.lbl_constante.Text = "Constante:"
        Me.lbl_constante.Visible = False
        '
        'cmd_nuevo_numero
        '
        Me.cmd_nuevo_numero.Location = New System.Drawing.Point(122, 226)
        Me.cmd_nuevo_numero.Name = "cmd_nuevo_numero"
        Me.cmd_nuevo_numero.Size = New System.Drawing.Size(83, 47)
        Me.cmd_nuevo_numero.TabIndex = 6
        Me.cmd_nuevo_numero.Text = "NUEVO NUMERO"
        Me.cmd_nuevo_numero.UseVisualStyleBackColor = True
        '
        'txt_multiplicador
        '
        Me.txt_multiplicador.Location = New System.Drawing.Point(149, 144)
        Me.txt_multiplicador.Name = "txt_multiplicador"
        Me.txt_multiplicador.Size = New System.Drawing.Size(100, 20)
        Me.txt_multiplicador.TabIndex = 3
        Me.txt_multiplicador.Visible = False
        '
        'lbl_multiplicador
        '
        Me.lbl_multiplicador.AutoSize = True
        Me.lbl_multiplicador.Location = New System.Drawing.Point(27, 144)
        Me.lbl_multiplicador.Name = "lbl_multiplicador"
        Me.lbl_multiplicador.Size = New System.Drawing.Size(69, 13)
        Me.lbl_multiplicador.TabIndex = 10
        Me.lbl_multiplicador.Text = "Multiplicador:"
        Me.lbl_multiplicador.Visible = False
        '
        'cmd_reiniciar
        '
        Me.cmd_reiniciar.Location = New System.Drawing.Point(211, 226)
        Me.cmd_reiniciar.Name = "cmd_reiniciar"
        Me.cmd_reiniciar.Size = New System.Drawing.Size(80, 47)
        Me.cmd_reiniciar.TabIndex = 7
        Me.cmd_reiniciar.Text = "REINICIAR"
        Me.cmd_reiniciar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 391)
        Me.Controls.Add(Me.cmd_reiniciar)
        Me.Controls.Add(Me.lbl_multiplicador)
        Me.Controls.Add(Me.lbl_constante)
        Me.Controls.Add(Me.lbl_raiz)
        Me.Controls.Add(Me.rb_mixto)
        Me.Controls.Add(Me.txt_multiplicador)
        Me.Controls.Add(Me.rb_multi)
        Me.Controls.Add(Me.txt_constante)
        Me.Controls.Add(Me.txt_semilla)
        Me.Controls.Add(Me.grilla)
        Me.Controls.Add(Me.cmd_nuevo_numero)
        Me.Controls.Add(Me.cmd_generar)
        Me.Location = New System.Drawing.Point(382, 158)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generador de Numeros Aleatorios Congruencial"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_generar As System.Windows.Forms.Button
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents NumA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_semilla As System.Windows.Forms.TextBox
    Friend WithEvents txt_constante As System.Windows.Forms.TextBox
    Friend WithEvents rb_multi As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mixto As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_raiz As System.Windows.Forms.Label
    Friend WithEvents lbl_constante As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo_numero As System.Windows.Forms.Button
    Friend WithEvents txt_multiplicador As System.Windows.Forms.TextBox
    Friend WithEvents lbl_multiplicador As System.Windows.Forms.Label
    Friend WithEvents cmd_reiniciar As System.Windows.Forms.Button

End Class
