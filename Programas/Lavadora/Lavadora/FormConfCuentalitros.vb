Public Class FormConfCuentalitros

    Private Sub FormConfCuentalitros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW0508"
        HhNumericDisplay1.Tooltip = "Litros actual"

        HhNumericDisplay1.ValorMaximo = 65535
        HhNumericDisplay1.AutoActualizar = True


        HhNumericDisplay2.Link = mMasterk
        HhNumericDisplay2.DireccionLectura = "DW0500"
        HhNumericDisplay2.Tooltip = "Pulsos cuentalitros"
        HhNumericDisplay2.ValorMaximo = 65535
        HhNumericDisplay2.AutoActualizar = True

        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionLectura = "DW0700"
        HhNumericEntry1.DireccionEscritura = "DW0700"
        HhNumericEntry1.Unidades = "lts"
        HhNumericEntry1.Tooltip = "Offset en llenado|(lts)"
        HhNumericEntry1.ValorMinimo = 0
        HhNumericEntry1.ValorMaximo = 1000
        HhNumericEntry1.AutoActualizar = True

        HhNumericEntry2.Link = mMasterk
        HhNumericEntry2.DireccionLectura = "DW0702"
        HhNumericEntry2.DireccionEscritura = "DW0702"
        HhNumericEntry2.Tooltip = "Divisor para calculo de|entrada de agua"
        HhNumericEntry2.ValorMinimo = 1
        HhNumericEntry2.ValorMaximo = 1000
        HhNumericEntry2.AutoActualizar = True

        HhNumericEntry3.Link = mMasterk
        HhNumericEntry3.DireccionLectura = "DW0704"
        HhNumericEntry3.DireccionEscritura = "DW0704"
        HhNumericEntry3.Tooltip = "Multiplo para calculo de|entrada de agua"
        HhNumericEntry3.ValorMinimo = 1
        HhNumericEntry3.ValorMaximo = 1000
        HhNumericEntry3.AutoActualizar = True


        HhNumericEntry4.Link = mMasterk
        HhNumericEntry4.DireccionLectura = "DW0706"
        HhNumericEntry4.DireccionEscritura = "DW0706"
        HhNumericEntry4.Unidades = "seg"
        HhNumericEntry4.Tooltip = "Tiempo de sopleteo|de sondas"
        HhNumericEntry4.ValorMinimo = 1
        HhNumericEntry4.ValorMaximo = 60
        HhNumericEntry4.AutoActualizar = True


        HhNumericEntry5.Link = mMasterk
        HhNumericEntry5.DireccionLectura = "DW0710"
        HhNumericEntry5.DireccionEscritura = "DW0710"
        HhNumericEntry5.Unidades = "lts"
        HhNumericEntry5.Tooltip = "Nivel de agua minimo|para comenzar|calentamiento"
        HhNumericEntry5.ValorMinimo = 0
        HhNumericEntry5.ValorMaximo = 10000
        HhNumericEntry5.AutoActualizar = True


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub HhNumericEntry2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericEntry2.TextChanged

    End Sub
End Class