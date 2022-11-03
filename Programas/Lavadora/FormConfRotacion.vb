Public Class FormConfRotacion

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormConfRotacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        HhNumericEntry5.Link = mMasterk
        HhNumericEntry5.DireccionLectura = "DW0810"
        HhNumericEntry5.DireccionEscritura = "DW0810"
        HhNumericEntry5.Tag = "Registro control"
        HhNumericEntry5.Tooltip = "Registro en el|variador para señal|arranque/paro"
        HhNumericEntry5.ValorMinimo = 0
        HhNumericEntry5.ValorMaximo = 1
        HhNumericEntry5.AutoActualizar = True

        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionLectura = "DW0800"
        HhNumericEntry1.DireccionEscritura = "DW0800"
        HhNumericEntry1.Unidades = "rpm"
        HhNumericEntry1.Tag = "RPM a 60Hz"
        HhNumericEntry1.Tooltip = "Numero de|RPM a 60Hz"
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.ValorMaximo = 3000
        HhNumericEntry1.AutoActualizar = True

        HhNumericEntry2.Link = mMasterk
        HhNumericEntry2.DireccionLectura = "DW0802"
        HhNumericEntry2.DireccionEscritura = "DW0802"
        HhNumericEntry2.Unidades = "hz"
        HhNumericEntry2.Tag = "Frec maxima"
        HhNumericEntry2.Tooltip = "Frecuencia maxima|del variador|(Hz)"
        HhNumericEntry2.ValorMinimo = 1
        HhNumericEntry2.ValorMaximo = 300
        HhNumericEntry2.AutoActualizar = True


        HhNumericEntry3.Link = mMasterk
        HhNumericEntry3.DireccionLectura = "DW0804"
        HhNumericEntry3.DireccionEscritura = "DW0804"
        HhNumericEntry3.Unidades = "hz"
        HhNumericEntry3.Tag = "Vel descarga"
        HhNumericEntry3.Tooltip = "Velocidad de rotacion|en descarga"
        HhNumericEntry3.ValorMinimo = 1
        HhNumericEntry3.ValorMaximo = 6000
        HhNumericEntry3.AutoActualizar = True
        HhNumericEntry3.Factor = 0.01
        HhNumericEntry3.Decimales = 2

        HhNumericEntry4.Link = mMasterk
        HhNumericEntry4.DireccionLectura = "DW0806"
        HhNumericEntry4.DireccionEscritura = "DW0806"
        HhNumericEntry4.Unidades = "seg"
        HhNumericEntry4.Tag = "Tiempo descarga"
        HhNumericEntry4.Tooltip = "Tiempo de rotacion|en descarga|(seg)"
        HhNumericEntry4.ValorMinimo = 1
        HhNumericEntry4.ValorMaximo = 120
        HhNumericEntry4.AutoActualizar = True

        HhNumericEntry6.Link = mMasterk
        HhNumericEntry6.DireccionLectura = "DW0808"
        HhNumericEntry6.DireccionEscritura = "DW0808"
        HhNumericEntry6.Unidades = "hz"
        HhNumericEntry6.Tag = "Vel despedrado"
        HhNumericEntry6.Tooltip = "Velocidad de rotacion|en despedrado"
        HhNumericEntry6.ValorMinimo = 1
        HhNumericEntry6.ValorMaximo = 6000
        HhNumericEntry6.AutoActualizar = True
        HhNumericEntry6.Factor = 0.01
        HhNumericEntry6.Decimales = 2


        HhNumericEntry7.Link = mMasterk
        HhNumericEntry7.DireccionLectura = "DW0812"
        HhNumericEntry7.DireccionEscritura = "DW0812"
        HhNumericEntry7.Unidades = "hz/seg"
        HhNumericEntry7.Tag = "Aceleracion rotacion"
        HhNumericEntry7.Tooltip = ""
        HhNumericEntry7.ValorMinimo = 0
        HhNumericEntry7.ValorMaximo = 1000
        HhNumericEntry7.AutoActualizar = True
        HhNumericEntry7.Factor = 0.1
        HhNumericEntry7.Decimales = 1

        HhNumericEntry8.Link = mMasterk
        HhNumericEntry8.ValorMinimo = 1
        HhNumericEntry8.ValorMaximo = 1000
        HhNumericEntry8.AutoActualizar = True

        Button1.Texto = "Aceptar"
    End Sub

    Private Sub HhNumericEntry3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericEntry3.TextChanged

    End Sub
End Class
