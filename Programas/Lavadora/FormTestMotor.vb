Public Class FormTestMotor
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub FormTestMotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionEscritura = "DW48"
        HhNumericEntry1.DireccionLectura = "DW48"
        HhNumericEntry1.Unidades = "Hz"
        HhNumericEntry1.ValorMinimo = 0
        HhNumericEntry1.ValorMaximo = mMasterk.ObtenerEntero("DW0814")
        HhNumericEntry1.AutoActualizar = True
        HhNumericEntry1.Tooltip = "Frecuencia variador"
        HhNumericEntry1.Factor = 0.01
        HhNumericEntry1.Decimales = 2

        HhToggleButton1.Link = mMasterk
        HhToggleButton1.DireccionEscritura = "MX0130"
        HhToggleButton1.DireccionLectura = "MX0189"
        HhToggleButton1.AutoActualizar = True

        HhToggleButton2.Link = mMasterk
        HhToggleButton2.DireccionEscritura = "MX0131"
        HhToggleButton2.DireccionLectura = "MX0188"
        HhToggleButton2.AutoActualizar = True

        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW0514"
        HhNumericDisplay1.Tooltip = "Velocidad actual"
        HhNumericDisplay1.Unidades = "rpm"
        HhNumericDisplay1.AutoActualizar = True

        HhNumericDisplay2.Link = mMasterk
        HhNumericDisplay2.DireccionLectura = "DW24"
        HhNumericDisplay2.Unidades = "Hz"
        HhNumericDisplay2.Factor = 0.01
        HhNumericDisplay2.Decimales = 2
        HhNumericDisplay2.Tooltip = "Frecuencia actual"

        HhNumericDisplay2.AutoActualizar = True

        Button1.Texto = "Salir"
    End Sub
End Class