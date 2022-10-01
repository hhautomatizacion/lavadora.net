Public Class FormMandos

    Private Sub Mandos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX02"
        HhMomentaryButton1.DireccionLectura = "MX04"
        HhMomentaryButton1.Texto = "Abrir"
        HhMomentaryButton1.AutoActualizar = True

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX03"
        HhMomentaryButton2.DireccionLectura = "MX8D"
        HhMomentaryButton2.Texto = "Cerrar"
        HhMomentaryButton2.AutoActualizar = True

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

        HhMomentaryButton7.Link = mMasterk
        HhMomentaryButton7.DireccionEscritura = "MX87"
        HhMomentaryButton7.DireccionLectura = "MX84"
        HhMomentaryButton7.Texto = "Despedrado"
        HhMomentaryButton7.AutoActualizar = True

        Button1.Texto = "Salir"
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click

    End Sub
End Class