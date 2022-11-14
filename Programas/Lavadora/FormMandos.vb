Imports MasterKlib

Public Class FormMandos
    Private Sub Mandos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.AutoActualizar = True
        HhMomentaryButton1.DireccionEscritura = "MX77"
        HhMomentaryButton1.DireccionLectura = "MX79"
        HhMomentaryButton1.Texto = "Izquierda"

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.AutoActualizar = True
        HhMomentaryButton2.DireccionEscritura = "MX78"
        HhMomentaryButton2.DireccionLectura = "MX7A"
        HhMomentaryButton2.Texto = "Derecha"

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX2B"
        HhMomentaryButton3.Texto = "Detener"

        HhMomentaryButton4.Link = mMasterk
        HhMomentaryButton4.DireccionEscritura = "MX2D"
        HhMomentaryButton4.DireccionLectura = "MX2F"
        HhMomentaryButton4.Texto = "Arriba"
        HhMomentaryButton4.AutoActualizar = True

        HhMomentaryButton5.Link = mMasterk
        HhMomentaryButton5.DireccionEscritura = "MX35"
        HhMomentaryButton5.DireccionLectura = "MX36"
        HhMomentaryButton5.Texto = "Horizontal"
        HhMomentaryButton5.AutoActualizar = True

        HhMomentaryButton6.Link = mMasterk
        HhMomentaryButton6.DireccionEscritura = "MX2E"
        HhMomentaryButton6.DireccionLectura = "MX34"
        HhMomentaryButton6.Texto = "Abajo"
        HhMomentaryButton6.AutoActualizar = True

        Button1.Texto = "Salir"
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class