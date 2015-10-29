Public Class FormMandos

    Private Sub Mandos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX0002"

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX0003"

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX002B"

        HhMomentaryButton4.Link = mMasterk
        HhMomentaryButton4.DireccionEscritura = "MX002D"

        HhMomentaryButton5.Link = mMasterk
        HhMomentaryButton5.DireccionEscritura = "MX0035"

        HhMomentaryButton6.Link = mMasterk
        HhMomentaryButton6.DireccionEscritura = "MX002E"

        HhMomentaryButton7.Link = mMasterk
        HhMomentaryButton7.DireccionEscritura = "MX0087"

        CambiarLetra(Me)


    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class