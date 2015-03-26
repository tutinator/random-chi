Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    'Private Function Multiplicativo(raiz As Integer) As Integer
    '    Dim num As Integer
    '    num = raiz * raiz
    '    Dim cadena As String
    '    cadena = Convert.ToString(num)
    '    Dim index As Integer = (cadena.Length / 2) - 2
    '    Dim salida As String = cadena.Substring(index, 4)
    '    Return Convert.ToInt32(salida)

    'End Function

    Private Function Mult(raiz As Integer, multiplicador As Integer) As Integer()
        Return Mixto(raiz, 0, multiplicador)
    End Function

    Private Function Mixto(raiz As Integer, cte As Integer, mult As Integer) As Integer()
        Dim salida(2) As Integer
        Dim calculo = (mult * raiz + cte) Mod 1234
        salida(0) = calculo / 1234 * 10000
        salida(1) = calculo
        Return salida

    End Function

    Private Sub probando_Click(sender As System.Object, e As System.EventArgs) Handles cmd_generar.Click
        If rb_multi.Checked Then

            Dim raiz = txt_semilla.Text
            Dim multiplicador = txt_multiplicador.Text
            For i As Integer = 0 To 19
                Dim vector() As Integer = Mult(raiz, multiplicador)
                raiz = vector(1)
                grilla.Rows.Add()
                grilla.Item(0, i).Value = i + 1
                grilla.Item(1, i).Value = vector(0)

                'raiz = Multiplicativo(raiz)
                'grilla.Rows.Add()
                'grilla.Item(0, i).Value = i + 1
                'grilla.Item(1, i).Value = raiz

            Next

        Else

            Dim raiz = txt_semilla.Text
            Dim constante = txt_constante.Text
            Dim multiplicador = txt_multiplicador.Text
            For i As Integer = 0 To 19

                Dim vector() As Integer = Mixto(raiz, constante, multiplicador)
                raiz = vector(1)
                grilla.Rows.Add()
                grilla.Item(0, i).Value = i + 1
                grilla.Item(1, i).Value = vector(0)

            Next

        End If




    End Sub

    
  
    Private Sub rb_multi_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_multi.CheckedChanged
        If rb_multi.Checked Then
            txt_constante.Visible = False
            lbl_constante.Visible = False
            txt_multiplicador.Visible = True
            lbl_multiplicador.Visible = True
        End If


    End Sub

    Private Sub rb_mixto_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rb_mixto.CheckedChanged
        If rb_multi.Checked = False Then
            txt_constante.Visible = True
            lbl_constante.Visible = True
            txt_multiplicador.Visible = True
            lbl_multiplicador.Visible = True

        End If
    End Sub

    Private Sub cmd_nuevo_numero_Click(sender As System.Object, e As System.EventArgs) Handles cmd_nuevo_numero.Click
        If rb_multi.Checked Then

            Dim i As Integer = grilla.Rows.Count - 1
            Dim raiz = grilla.Item(1, i).Value
            Dim multiplicador = txt_multiplicador.Text
            Dim vector() As Integer = Mult(raiz, multiplicador)
            raiz = vector(1)
            grilla.Rows.Add()
            grilla.Item(0, i + 1).Value = i + 2
            grilla.Item(1, i + 1).Value = vector(0)
            'raiz = Multiplicativo(raiz)
            'grilla.Rows.Add()
            'grilla.Item(0, i + 1).Value = i + 2
            'grilla.Item(1, i + 1).Value = raiz

        Else
            Dim i As Integer = grilla.Rows.Count - 1
            Dim raiz = grilla.Item(1, i).Value
            Dim constante = txt_constante.Text
            Dim multiplicador = txt_multiplicador.Text

            Dim vector() As Integer = Mixto(raiz, constante, multiplicador)
            raiz = vector(1)
            grilla.Rows.Add()
            grilla.Item(0, i + 1).Value = i + 2
            grilla.Item(1, i + 1).Value = vector(0)

        End If

    End Sub

    Private Sub cmd_reiniciar_Click(sender As System.Object, e As System.EventArgs) Handles cmd_reiniciar.Click
        grilla.Rows.Clear()
        txt_constante.Clear()
        txt_multiplicador.Clear()
        txt_semilla.Clear()
        If rb_mixto.Checked Then
            rb_mixto.Checked = False
        Else
            rb_multi.Checked = False

        End If
    End Sub

  
End Class
