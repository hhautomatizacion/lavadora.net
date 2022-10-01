Public Class FormConfVolquete

    Private Sub FormConfVolquete_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionLectura = "DW1000"
        HhNumericEntry1.DireccionEscritura = "DW1000"
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.ValorMaximo = 60
        HhNumericEntry1.Unidades = "seg"
        HhNumericEntry1.AutoActualizar = True

        HhNumericEntry2.Link = mMasterk
        HhNumericEntry2.DireccionLectura = "DW1004"
        HhNumericEntry2.DireccionEscritura = "DW1004"
        HhNumericEntry2.ValorMinimo = 1
        HhNumericEntry2.ValorMaximo = 600
        HhNumericEntry2.Unidades = "seg"
        HhNumericEntry2.AutoActualizar = True

        HhToggleButton21.Link = mMasterk
        HhToggleButton21.DireccionEscritura = "KX0100"
        HhToggleButton21.DireccionLectura = "KX0100"
        HhToggleButton21.AutoActualizar = True

        Button1.Texto = "Aceptar"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()

    End Sub

    Private Sub HhNumericEntry1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericEntry1.TextChanged

    End Sub

    Private Sub HhNumericEntry2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericEntry2.TextChanged

    End Sub
End Class