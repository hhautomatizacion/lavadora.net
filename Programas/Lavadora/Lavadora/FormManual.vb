Public Class FormManual

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Using fForm As New FormLlenadoAuto
            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionLectura = "MX1710"
            fForm.HhToggleButton1.DireccionEscritura = "MX1710"
            fForm.HhToggleButton1.Etiqueta = "Agua fria"
            fForm.HhToggleButton1.AutoActualizar = True
            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionLectura = "MX1711"
            fForm.HhToggleButton2.DireccionEscritura = "MX1711"
            fForm.HhToggleButton2.Etiqueta = "Agua caliente"
            fForm.HhToggleButton2.AutoActualizar = True
            fForm.HhToggleButton3.Link = mMasterk
            fForm.HhToggleButton3.DireccionLectura = "MX1712"
            fForm.HhToggleButton3.DireccionEscritura = "MX1712"
            fForm.HhToggleButton3.Etiqueta = "Rotacion"
            fForm.HhToggleButton3.AutoActualizar = True
            fForm.HhToggleButton4.Link = mMasterk
            fForm.HhToggleButton4.DireccionLectura = "MX1713"
            fForm.HhToggleButton4.DireccionEscritura = "MX1713"
            fForm.HhToggleButton4.Etiqueta = "Calefaccion"
            fForm.HhToggleButton4.AutoActualizar = True
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0085"
            fForm.HhNumericEntry1.DireccionLectura = "DW0085"
            fForm.HhNumericEntry1.Etiqueta = "Cantidad agua"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.AutoActualizar = True
            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.DireccionEscritura = "DW0084"
            fForm.HhNumericEntry2.DireccionLectura = "DW0084"
            fForm.HhNumericEntry2.Etiqueta = "Temperatura"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True
            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1700"
            fForm.ShowDialog()
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormManual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mMasterk.EstablecerBoolean("MX0001", False)

        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW0030"
        HhNumericDisplay1.Etiqueta = "Temperatura"
        HhNumericDisplay1.Tooltip = "Temperatura actual"
        HhNumericDisplay1.ValorMaximo = 80
        HhNumericDisplay1.ValorMinimo = 0
        HhNumericDisplay1.AutoActualizar = True

        HhNumericDisplay2.Link = mMasterk
        HhNumericDisplay2.DireccionLectura = "DW0084"
        HhNumericDisplay2.Etiqueta = "Set"
        HhNumericDisplay2.Tooltip = "Temperatura programada"
        HhNumericDisplay2.AutoActualizar = True

        HhNumericDisplay3.Link = mMasterk
        HhNumericDisplay3.DireccionLectura = "DW0508"
        HhNumericDisplay3.Etiqueta = "Litros"
        HhNumericDisplay3.Tooltip = "Litros actual"
        HhNumericDisplay3.ValorMaximo = 80
        HhNumericDisplay3.ValorMinimo = 0
        HhNumericDisplay3.AutoActualizar = True

        HhNumericDisplay4.Link = mMasterk
        HhNumericDisplay4.DireccionLectura = "DW0085"
        HhNumericDisplay4.Etiqueta = "Set"
        HhNumericDisplay4.Tooltip = "Litros set"
        HhNumericDisplay4.AutoActualizar = True

        HhNumericDisplay5.Link = mMasterk
        HhNumericDisplay5.DireccionLectura = "DW0514"
        HhNumericDisplay5.Etiqueta = "Velocidad"
        HhNumericDisplay5.Tooltip = "Velocidad actual"
        HhNumericDisplay5.ValorMaximo = 80
        HhNumericDisplay5.ValorMinimo = 0
        HhNumericDisplay5.AutoActualizar = True

        HhNumericDisplay6.Link = mMasterk
        HhNumericDisplay6.DireccionLectura = "DW0086"
        HhNumericDisplay6.Etiqueta = "Set"
        HhNumericDisplay6.Tooltip = "Velocidad set"
        HhNumericDisplay6.AutoActualizar = True

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using fForm As New FormDesagueAuto
            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionEscritura = "MX1715"
            fForm.HhToggleButton1.DireccionLectura = "MX1715"
            fForm.HhToggleButton1.Etiqueta = "Desague 1"
            fForm.HhToggleButton1.AutoActualizar = True
            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionEscritura = "MX1717"
            fForm.HhToggleButton2.DireccionLectura = "MX1717"
            fForm.HhToggleButton2.Etiqueta = "Rotacion"
            fForm.HhToggleButton2.AutoActualizar = True
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0087"
            fForm.HhNumericEntry1.DireccionLectura = "DW0087"
            fForm.HhNumericEntry1.Etiqueta = "Tiempo (seg)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 300
            fForm.HhNumericEntry1.AutoActualizar = True
            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1704"
            fForm.ShowDialog()
        End Using
    End Sub

    Private Sub HhNumericDisplay6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay6.Click

    End Sub

    Private Sub HhNumericDisplay6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay6.TextChanged
        HhNumericDisplay6.ValorMaximo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay6.ValorMinimo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay5.ValorMaximo = Val(HhNumericDisplay6.Text) + 2
        HhNumericDisplay5.ValorMinimo = Val(HhNumericDisplay6.Text) - 2
    End Sub

    Private Sub HhNumericDisplay4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay4.Click

    End Sub

    Private Sub HhNumericDisplay4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay4.TextChanged
        HhNumericDisplay4.ValorMaximo = Val(HhNumericDisplay4.Text)
        HhNumericDisplay4.ValorMinimo = Val(HhNumericDisplay4.Text)
        HhNumericDisplay3.ValorMaximo = Val(HhNumericDisplay4.Text) + 1
        HhNumericDisplay3.ValorMinimo = Val(HhNumericDisplay4.Text) - 1
    End Sub

    Private Sub HhNumericDisplay2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay2.Click

    End Sub

    Private Sub HhNumericDisplay2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay2.TextChanged
        HhNumericDisplay2.ValorMaximo = Val(HhNumericDisplay2.Text)
        HhNumericDisplay2.ValorMinimo = Val(HhNumericDisplay2.Text)
        HhNumericDisplay1.ValorMaximo = Val(HhNumericDisplay2.Text) + 1
        HhNumericDisplay1.ValorMinimo = Val(HhNumericDisplay2.Text) - 1
    End Sub

    
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using fForm As New FormCalefaccionManual
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0084"
            fForm.HhNumericEntry1.DireccionLectura = "DW0084"
            fForm.HhNumericEntry1.Etiqueta = "Temperatura final (°C)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 100
            fForm.HhNumericEntry1.AutoActualizar = True
            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionEscritura = "MX1716"
            fForm.HhToggleButton1.DireccionLectura = "MX1716"
            fForm.HhToggleButton1.Etiqueta = "Con rotacion"
            fForm.HhToggleButton1.AutoActualizar = True
            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.DireccionEscritura = "DW0083"
            fForm.HhNumericEntry2.DireccionLectura = "DW0083"
            fForm.HhNumericEntry2.Etiqueta = "Gradiente (°C/min)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 20
            fForm.HhNumericEntry2.AutoActualizar = True
            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionEscritura = "MX1719"
            fForm.HhToggleButton2.DireccionLectura = "MX1719"
            fForm.HhToggleButton2.Etiqueta = "Con gradiente"
            fForm.HhToggleButton2.AutoActualizar = True
            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1701"
            fForm.ShowDialog()
        End Using
    End Sub
End Class