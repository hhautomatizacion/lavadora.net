Public Class FormConfAditivos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormConfQuimicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionLectura = "DW0900"
        HhNumericEntry1.DireccionEscritura = "DW0900"
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.ValorMaximo = 600
        HhNumericEntry1.AutoActualizar = True

        HhNumericEntry2.Link = mMasterk
        HhNumericEntry2.DireccionLectura = "DW0902"
        HhNumericEntry2.DireccionEscritura = "DW0902"
        HhNumericEntry2.ValorMinimo = 1
        HhNumericEntry2.ValorMaximo = 600
        HhNumericEntry2.AutoActualizar = True

        HhNumericEntry3.Link = mMasterk
        HhNumericEntry3.DireccionLectura = "DW0908"
        HhNumericEntry3.DireccionEscritura = "DW0908"
        HhNumericEntry3.ValorMinimo = 1
        HhNumericEntry3.ValorMaximo = 6000
        HhNumericEntry3.Factor = 0.1
        HhNumericEntry3.Decimales = 1
        HhNumericEntry3.Unidades = "seg"
        HhNumericEntry3.AutoActualizar = True

        HhToggleButton2.Link = mMasterk
        HhToggleButton2.DireccionEscritura = "KX04"
        HhToggleButton2.DireccionLectura = "KX04"
        HhToggleButton2.AutoActualizar = True



        HhToggleButton4.Link = mMasterk
        HhToggleButton4.DireccionEscritura = "KX05"
        HhToggleButton4.DireccionLectura = "KX05"
        HhToggleButton4.AutoActualizar = True

        HhToggleButton1.Link = mMasterk
        HhToggleButton1.DireccionEscritura = "KX06"
        HhToggleButton1.DireccionLectura = "KX06"
        HhToggleButton1.AutoActualizar = True


        Button1.Texto = "Aceptar"
    End Sub
End Class