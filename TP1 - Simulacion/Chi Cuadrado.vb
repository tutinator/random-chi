Public Class Form2

    Private Sub cmd_generar_Click(sender As System.Object, e As System.EventArgs) Handles cmd_generar.Click
        Me.Size = New System.Drawing.Size(1242, 544)
        ChiCuadrado()
        chart.Visible = True


    End Sub
    Private Function Mixto(raiz As Integer, cte As Integer, mult As Integer) As Double()
        Dim salida(2) As Double
        Dim calculo = (mult * raiz + cte) Mod 1234
        salida(0) = calculo ' devuelve Xn+1
        salida(1) = calculo / 1234 'devuelve RND
        Return salida

    End Function
    Private Sub ChiCuadrado()
        grilla.Rows.Clear()

        Dim cantidad_intervalos As Integer = txt_intervalos.Text
        Dim tamaño_muestra As Integer = txt_cantidad.Text
        Dim long_intervalo As Double = 1 / cantidad_intervalos
        Dim frec_esperada As Double = tamaño_muestra / cantidad_intervalos
        Randomize()
        Dim vector_intervalos(cantidad_intervalos) As Double
        Dim vector_nombres(cantidad_intervalos) As Integer

        'Genera random y suma frecuencia aparicion en el intervalo correspondiente
        If rb_mixto.Checked Then
            Dim raiz As Integer = txt_semilla.Text
            For i As Integer = 1 To tamaño_muestra
                Dim supervector = Mixto(raiz, txt_constante.Text, txt_multiplicador.Text)
                Dim value As Double = supervector(1)
                raiz = supervector(0)
                Dim intervalo_elegido As Double = Math.Truncate(value / long_intervalo)
                vector_intervalos(intervalo_elegido) += 1
            Next

        Else
            For i As Integer = 1 To tamaño_muestra
                Dim value As Double = Rnd()
                Dim intervalo_elegido As Double = Math.Truncate(value / long_intervalo)
                vector_intervalos(intervalo_elegido) += 1
            Next
        End If
        'Llenado de grilla
        Dim desde As Double = 0
        Dim amplitud_intervalo = 1 / txt_intervalos.Text
        Dim vector_terminos(cantidad_intervalos) As Double

        For i As Integer = 0 To txt_intervalos.Text - 1
            grilla.Rows.Add()
            grilla.Item(0, i).Value = i + 1
            grilla.Item(1, i).Value = desde
            grilla.Item(2, i).Value = desde + amplitud_intervalo
            grilla.Item(3, i).Value = vector_intervalos(i)
            grilla.Item(4, i).Value = frec_esperada
            vector_terminos(i) = (frec_esperada - vector_intervalos(i)) ^ 2 / frec_esperada
            grilla.Item(5, i).Value = vector_terminos(i)
            desde += amplitud_intervalo

        Next
        ' Suma los terminos de chi cuadrado
        Dim suma_chi As Double = 0
        For Each i As Double In vector_terminos
            suma_chi += i
        Next
        lbl_chi.Text = suma_chi
        lbl_chi.Visible = True
        lbl_chitxt.Visible = True
        ' Suma de frecuencias de cada intervalo
        Dim suma As Integer = 0
        For Each i As Integer In vector_intervalos
            suma += i
        Next

        grilla.Rows.Add()
        grilla.Item(0, grilla.Rows.Count - 1).Value = "TOTAL"
        grilla.Item(3, grilla.Rows.Count - 1).Value = suma
        grilla.Item(5, grilla.Rows.Count - 1).Value = suma_chi

        ' Determina nombre de eje x 
        For i As Integer = 1 To txt_intervalos.Text
            vector_nombres(i - 1) = i
        Next

        ' Datos para generar el gráfico
        Dim yValues As Double() = vector_intervalos
        Dim xValues As Integer() = vector_nombres
        chart.Series(0).Points.DataBindXY(xValues, yValues)
        chart.Series.Add("Frecuencia Esperada")
        For i As Integer = 1 To txt_intervalos.Text
            vector_intervalos(i - 1) = tamaño_muestra / cantidad_intervalos
        Next
        yValues = vector_intervalos
        chart.Series(1).Points.DataBindXY(xValues, yValues)
        chart.Visible = True

        grilla.Update()
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        chart.Visible = False
        lbl_constante.Visible = False
        lbl_multiplicador.Visible = False
        txt_multiplicador.Visible = False
        txt_constante.Visible = False
        rb_gen.Checked = True
        lbl_chi.Visible = False
        lbl_chitxt.Visible = False
        Me.Size = New System.Drawing.Size(588, 544)

    End Sub

    Private Sub cmd_reiniciar_Click(sender As System.Object, e As System.EventArgs) Handles cmd_reiniciar.Click

        chart.Visible = False
        txt_cantidad.Clear()
        txt_intervalos.Clear()
        grilla.Rows.Clear()
        chart.Series.Clear()
        chart.Update()
        chart.Series.Add("Frecuencia Observada")
        rb_gen.Checked = True
        txt_constante.Visible = False
        lbl_constante.Visible = False
        txt_multiplicador.Visible = False
        lbl_multiplicador.Visible = False
        txt_semilla.Visible = False
        lbl_semilla.Visible = False
        lbl_chi.Visible = False
        lbl_chitxt.Visible = False
        Me.Size = New System.Drawing.Size(588, 544)

    End Sub

    Private Sub cmd_mixto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_mixto.CheckedChanged
        lbl_constante.Visible = True
        lbl_multiplicador.Visible = True
        txt_multiplicador.Visible = True
        txt_constante.Visible = True

    End Sub

    
    Private Sub rb_gen_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_gen.CheckedChanged
        If rb_gen.Checked Then
            txt_constante.Visible = False
            lbl_constante.Visible = False
            txt_multiplicador.Visible = False
            lbl_multiplicador.Visible = False
            txt_semilla.Visible = False
            lbl_semilla.Visible = False
        Else
            txt_constante.Visible = True
            lbl_constante.Visible = True
            txt_multiplicador.Visible = True
            lbl_multiplicador.Visible = True
            txt_semilla.Visible = True
            lbl_semilla.Visible = True
        End If
    End Sub

 

 
    
End Class