Public Class FormConfQuimicos

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
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
    End Sub
End Class