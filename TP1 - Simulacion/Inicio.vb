Public Class Inicio

    Private Sub cmd_generador_Click(sender As System.Object, e As System.EventArgs) Handles cmd_generador.Click
        Dim Gen As New Form1()
        Gen.Show()
    End Sub

    Private Sub cmd_chi_Click(sender As System.Object, e As System.EventArgs) Handles cmd_chi.Click
        Dim Chi As New Form2()
        Chi.Show()
    End Sub
End Class