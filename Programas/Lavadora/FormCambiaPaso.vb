Public Class FormCambiaPaso
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UnAttach(Me)
        Me.Close()
    End Sub
    Private Sub FormCambiaPaso_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        UnAttach(Me)
        Me.Dispose()
    End Sub
    Private Sub FormCambiaPaso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.Tag = "# Paso"
        HhNumericEntry1.Tooltip = "Paso al cual brincar"
        HhNumericEntry1.DireccionEscritura = "DW50"
        HhNumericEntry1.DireccionLectura = "DW50"
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.ValorMaximo = 99
        HhNumericEntry1.AutoActualizar = True
        HhNumericEntry1.Actualizar()


        HhGridDisplay1.Link = mMasterk
        HhGridDisplay1.DireccionPaso = "DW50"
        HhGridDisplay1.EscribirPaso = True

        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX0240"
        HhMomentaryButton1.Texto = "Aceptar"

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX0244"
        HhMomentaryButton2.Texto = "Anterior"

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX0245"
        HhMomentaryButton3.Texto = "Siguiente"

        Button2.Texto = "Cancelar"
    End Sub
    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click
        UnAttach(Me)
        Me.Close()
    End Sub
    Private Sub HhMomentaryButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton2.Click
        UnAttach(Me)
        Me.Close()
    End Sub
    Private Sub HhMomentaryButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton3.Click
        UnAttach(Me)
        Me.Close()
    End Sub
End Class