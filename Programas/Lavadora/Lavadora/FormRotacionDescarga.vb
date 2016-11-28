Public Class FormRotacionDescarga

    Private Sub HhMomentaryButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton3.Click
        Me.Close()
    End Sub

    Private Sub FormRotacionDescarga_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX77"
        HhMomentaryButton1.DireccionLectura = "MX79"
        HhMomentaryButton1.AutoActualizar = True

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX78"
        HhMomentaryButton2.DireccionLectura = "MX7A"
        HhMomentaryButton2.AutoActualizar = True

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX35"
        HhMomentaryButton4.Link = mMasterk
        HhMomentaryButton4.DireccionEscritura = "MX2B"
    End Sub

    Private Sub HhMomentaryButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton2.Click

    End Sub

    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click

    End Sub
End Class