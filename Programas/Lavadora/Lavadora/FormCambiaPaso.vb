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
        HhNumericEntry1.Etiqueta = "# Paso"
        HhNumericEntry1.Tooltip = "Paso al cual brincar"
        HhNumericEntry1.DireccionEscritura = "DW050"
        HhNumericEntry1.DireccionLectura = "DW050"
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.ValorMaximo = 99
        HhNumericEntry1.AutoActualizar = True
        HhNumericEntry1.Actualizar()

        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX240"

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX244"

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX245"



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