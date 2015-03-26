<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.grilla = New System.Windows.Forms.DataGridView()
        Me.numero_intervalo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desde = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hasta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.frecuencia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_frec_esperada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_termino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_cantidad = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.TextBox()
        Me.lbl_intervalos = New System.Windows.Forms.Label()
        Me.txt_intervalos = New System.Windows.Forms.TextBox()
        Me.cmd_generar = New System.Windows.Forms.Button()
        Me.chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cmd_reiniciar = New System.Windows.Forms.Button()
        Me.rb_gen = New System.Windows.Forms.RadioButton()
        Me.rb_mixto = New System.Windows.Forms.RadioButton()
        Me.lbl_multiplicador = New System.Windows.Forms.Label()
        Me.lbl_constante = New System.Windows.Forms.Label()
        Me.txt_multiplicador = New System.Windows.Forms.TextBox()
        Me.txt_constante = New System.Windows.Forms.TextBox()
        Me.lbl_semilla = New System.Windows.Forms.Label()
        Me.txt_semilla = New System.Windows.Forms.TextBox()
        Me.lbl_chitxt = New System.Windows.Forms.Label()
        Me.lbl_chi = New System.Windows.Forms.Label()
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grilla
        '
        Me.grilla.AllowUserToAddRows = False
        Me.grilla.AllowUserToDeleteRows = False
        Me.grilla.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_intervalo, Me.desde, Me.hasta, Me.frecuencia, Me.col_frec_esperada, Me.col_termino})
        Me.grilla.Location = New System.Drawing.Point(15, 123)
        Me.grilla.Name = "grilla"
        Me.grilla.ReadOnly = True
        Me.grilla.Size = New System.Drawing.Size(498, 338)
        Me.grilla.TabIndex = 9
        '
        'numero_intervalo
        '
        Me.numero_intervalo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.numero_intervalo.HeaderText = "Numero"
        Me.numero_intervalo.Name = "numero_intervalo"
        Me.numero_intervalo.ReadOnly = True
        Me.numero_intervalo.Width = 69
        '
        'desde
        '
        Me.desde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.desde.HeaderText = "Desde"
        Me.desde.Name = "desde"
        Me.desde.ReadOnly = True
        Me.desde.Width = 63
        '
        'hasta
        '
        Me.hasta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.hasta.HeaderText = "Hasta"
        Me.hasta.Name = "hasta"
        Me.hasta.ReadOnly = True
        Me.hasta.Width = 60
        '
        'frecuencia
        '
        Me.frecuencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.frecuencia.HeaderText = "F. Observada"
        Me.frecuencia.Name = "frecuencia"
        Me.frecuencia.ReadOnly = True
        Me.frecuencia.Width = 96
        '
        'col_frec_esperada
        '
        Me.col_frec_esperada.HeaderText = "F. Esperada"
        Me.col_frec_esperada.Name = "col_frec_esperada"
        Me.col_frec_esperada.ReadOnly = True
        '
        'col_termino
        '
        Me.col_termino.HeaderText = "Estadístico "
        Me.col_termino.Name = "col_termino"
        Me.col_termino.ReadOnly = True
        '
        'lbl_cantidad
        '
        Me.lbl_cantidad.AutoSize = True
        Me.lbl_cantidad.Location = New System.Drawing.Point(12, 21)
        Me.lbl_cantidad.Name = "lbl_cantidad"
        Me.lbl_cantidad.Size = New System.Drawing.Size(104, 13)
        Me.lbl_cantidad.TabIndex = 13
        Me.lbl_cantidad.Text = "Tamaño de muestra:"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(122, 18)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(100, 20)
        Me.txt_cantidad.TabIndex = 0
        '
        'lbl_intervalos
        '
        Me.lbl_intervalos.AutoSize = True
        Me.lbl_intervalos.Location = New System.Drawing.Point(12, 55)
        Me.lbl_intervalos.Name = "lbl_intervalos"
        Me.lbl_intervalos.Size = New System.Drawing.Size(56, 13)
        Me.lbl_intervalos.TabIndex = 17
        Me.lbl_intervalos.Text = "Intervalos:"
        '
        'txt_intervalos
        '
        Me.txt_intervalos.Location = New System.Drawing.Point(122, 52)
        Me.txt_intervalos.Name = "txt_intervalos"
        Me.txt_intervalos.Size = New System.Drawing.Size(100, 20)
        Me.txt_intervalos.TabIndex = 1
        '
        'cmd_generar
        '
        Me.cmd_generar.Location = New System.Drawing.Point(488, 18)
        Me.cmd_generar.Name = "cmd_generar"
        Me.cmd_generar.Size = New System.Drawing.Size(74, 39)
        Me.cmd_generar.TabIndex = 7
        Me.cmd_generar.Text = "GENERAR"
        Me.cmd_generar.UseVisualStyleBackColor = True
        '
        'chart
        '
        Me.chart.Anchor = System.Windows.Forms.AnchorStyles.None
        ChartArea2.Name = "ChartArea1"
        Me.chart.ChartAreas.Add(ChartArea2)
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Name = "Legend1"
        Me.chart.Legends.Add(Legend2)
        Me.chart.Location = New System.Drawing.Point(568, 18)
        Me.chart.Name = "chart"
        Me.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Frecuencia Observada"
        Me.chart.Series.Add(Series2)
        Me.chart.Size = New System.Drawing.Size(646, 430)
        Me.chart.TabIndex = 12
        Me.chart.Text = "Chart1"
        Title2.Name = "Title1"
        Me.chart.Titles.Add(Title2)
        '
        'cmd_reiniciar
        '
        Me.cmd_reiniciar.Location = New System.Drawing.Point(488, 74)
        Me.cmd_reiniciar.Name = "cmd_reiniciar"
        Me.cmd_reiniciar.Size = New System.Drawing.Size(74, 39)
        Me.cmd_reiniciar.TabIndex = 8
        Me.cmd_reiniciar.Text = "REINICIAR"
        Me.cmd_reiniciar.UseVisualStyleBackColor = True
        '
        'rb_gen
        '
        Me.rb_gen.AutoSize = True
        Me.rb_gen.Location = New System.Drawing.Point(242, 19)
        Me.rb_gen.Name = "rb_gen"
        Me.rb_gen.Size = New System.Drawing.Size(139, 17)
        Me.rb_gen.TabIndex = 2
        Me.rb_gen.TabStop = True
        Me.rb_gen.Text = "Generador del Lenguaje"
        Me.rb_gen.UseVisualStyleBackColor = True
        '
        'rb_mixto
        '
        Me.rb_mixto.AutoSize = True
        Me.rb_mixto.Location = New System.Drawing.Point(242, 51)
        Me.rb_mixto.Name = "rb_mixto"
        Me.rb_mixto.Size = New System.Drawing.Size(50, 17)
        Me.rb_mixto.TabIndex = 3
        Me.rb_mixto.TabStop = True
        Me.rb_mixto.Text = "Mixto"
        Me.rb_mixto.UseVisualStyleBackColor = True
        '
        'lbl_multiplicador
        '
        Me.lbl_multiplicador.AutoSize = True
        Me.lbl_multiplicador.Location = New System.Drawing.Point(299, 77)
        Me.lbl_multiplicador.Name = "lbl_multiplicador"
        Me.lbl_multiplicador.Size = New System.Drawing.Size(66, 13)
        Me.lbl_multiplicador.TabIndex = 12
        Me.lbl_multiplicador.Text = "Multiplicador"
        '
        'lbl_constante
        '
        Me.lbl_constante.AutoSize = True
        Me.lbl_constante.Location = New System.Drawing.Point(299, 103)
        Me.lbl_constante.Name = "lbl_constante"
        Me.lbl_constante.Size = New System.Drawing.Size(55, 13)
        Me.lbl_constante.TabIndex = 17
        Me.lbl_constante.Text = "Constante"
        '
        'txt_multiplicador
        '
        Me.txt_multiplicador.Location = New System.Drawing.Point(370, 74)
        Me.txt_multiplicador.Name = "txt_multiplicador"
        Me.txt_multiplicador.Size = New System.Drawing.Size(100, 20)
        Me.txt_multiplicador.TabIndex = 5
        '
        'txt_constante
        '
        Me.txt_constante.Location = New System.Drawing.Point(370, 100)
        Me.txt_constante.Name = "txt_constante"
        Me.txt_constante.Size = New System.Drawing.Size(100, 20)
        Me.txt_constante.TabIndex = 6
        '
        'lbl_semilla
        '
        Me.lbl_semilla.AutoSize = True
        Me.lbl_semilla.Location = New System.Drawing.Point(299, 51)
        Me.lbl_semilla.Name = "lbl_semilla"
        Me.lbl_semilla.Size = New System.Drawing.Size(40, 13)
        Me.lbl_semilla.TabIndex = 14
        Me.lbl_semilla.Text = "Semilla"
        '
        'txt_semilla
        '
        Me.txt_semilla.Location = New System.Drawing.Point(370, 48)
        Me.txt_semilla.Name = "txt_semilla"
        Me.txt_semilla.Size = New System.Drawing.Size(100, 20)
        Me.txt_semilla.TabIndex = 4
        '
        'lbl_chitxt
        '
        Me.lbl_chitxt.AutoSize = True
        Me.lbl_chitxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chitxt.Location = New System.Drawing.Point(57, 473)
        Me.lbl_chitxt.Name = "lbl_chitxt"
        Me.lbl_chitxt.Size = New System.Drawing.Size(191, 25)
        Me.lbl_chitxt.TabIndex = 13
        Me.lbl_chitxt.Text = "CHI CUADRADO:"
        '
        'lbl_chi
        '
        Me.lbl_chi.AutoSize = True
        Me.lbl_chi.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_chi.Location = New System.Drawing.Point(254, 473)
        Me.lbl_chi.Name = "lbl_chi"
        Me.lbl_chi.Size = New System.Drawing.Size(0, 25)
        Me.lbl_chi.TabIndex = 13
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1226, 505)
        Me.Controls.Add(Me.lbl_chi)
        Me.Controls.Add(Me.lbl_chitxt)
        Me.Controls.Add(Me.txt_constante)
        Me.Controls.Add(Me.txt_semilla)
        Me.Controls.Add(Me.txt_multiplicador)
        Me.Controls.Add(Me.lbl_semilla)
        Me.Controls.Add(Me.lbl_constante)
        Me.Controls.Add(Me.lbl_multiplicador)
        Me.Controls.Add(Me.rb_mixto)
        Me.Controls.Add(Me.rb_gen)
        Me.Controls.Add(Me.cmd_reiniciar)
        Me.Controls.Add(Me.chart)
        Me.Controls.Add(Me.cmd_generar)
        Me.Controls.Add(Me.txt_intervalos)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.lbl_intervalos)
        Me.Controls.Add(Me.lbl_cantidad)
        Me.Controls.Add(Me.grilla)
        Me.Location = New System.Drawing.Point(382, 158)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test de Chi Cuadrado"
        CType(Me.grilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grilla As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_cantidad As System.Windows.Forms.Label
    Friend WithEvents txt_cantidad As System.Windows.Forms.TextBox
    Friend WithEvents lbl_intervalos As System.Windows.Forms.Label
    Friend WithEvents txt_intervalos As System.Windows.Forms.TextBox
    Friend WithEvents cmd_generar As System.Windows.Forms.Button
    Friend WithEvents chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cmd_reiniciar As System.Windows.Forms.Button
    Friend WithEvents rb_gen As System.Windows.Forms.RadioButton
    Friend WithEvents rb_mixto As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_multiplicador As System.Windows.Forms.Label
    Friend WithEvents lbl_constante As System.Windows.Forms.Label
    Friend WithEvents txt_multiplicador As System.Windows.Forms.TextBox
    Friend WithEvents txt_constante As System.Windows.Forms.TextBox
    Friend WithEvents numero_intervalo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents desde As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hasta As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents frecuencia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_frec_esperada As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents col_termino As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lbl_semilla As System.Windows.Forms.Label
    Friend WithEvents txt_semilla As System.Windows.Forms.TextBox
    Friend WithEvents lbl_chitxt As System.Windows.Forms.Label
    Friend WithEvents lbl_chi As System.Windows.Forms.Label
End Class
