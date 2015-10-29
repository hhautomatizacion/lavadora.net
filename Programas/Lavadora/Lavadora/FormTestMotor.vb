Public Class FormTestMotor

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub FormTestMotor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionEscritura = "DW48"
        HhNumericEntry1.DireccionLectura = "DW48"
        HhNumericEntry1.Unidades = "hz"
        HhNumericEntry1.ValorMinimo = 0
        HhNumericEntry1.ValorMaximo = mMasterk.ObtenerEntero("DW0814")
        HhNumericEntry1.AutoActualizar = True

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
        HhNumericDisplay1.AutoActualizar = True
    End Sub
End Class