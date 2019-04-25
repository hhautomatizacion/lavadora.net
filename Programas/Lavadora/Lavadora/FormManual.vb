Public Class FormManual



    Private Sub FormManual_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mMasterk.EstablecerBoolean("MX0001", False)

        HhMomentaryButton3.Link = mMasterk
        'dejar de utilizar direccion mx1000
        HhMomentaryButton3.DireccionEscritura = "MX1000"
        HhMomentaryButton3.DireccionLectura = "MX1801"
        HhMomentaryButton3.Etiqueta = "Rotacion"
        HhMomentaryButton3.AutoActualizar = True


        HhMomentaryButton2.Link = mMasterk
        'dejar de utilizar direccion mx1000
        HhMomentaryButton2.DireccionEscritura = "MX1000"
        HhMomentaryButton2.DireccionLectura = "MX1803"
        HhMomentaryButton2.Etiqueta = "Desague"
        HhMomentaryButton2.AutoActualizar = True

        HhMomentaryButton1.Link = mMasterk
        'dejar de utilizar direccion mx1000
        HhMomentaryButton1.DireccionEscritura = "MX1000"
        HhMomentaryButton1.DireccionLectura = "MX1800"
        HhMomentaryButton1.Etiqueta = "Llenado"
        HhMomentaryButton1.AutoActualizar = True

        HhMomentaryButton4.Link = mMasterk
        'dejar de utilizar direccion mx1000
        HhMomentaryButton4.DireccionEscritura = "MX1000"
        HhMomentaryButton4.DireccionLectura = "MX1802"
        HhMomentaryButton4.Etiqueta = "Mantenimiento"
        HhMomentaryButton4.AutoActualizar = True

        HhMomentaryButton5.Link = mMasterk
        'dejar de utilizar direccion mx1000
        HhMomentaryButton5.DireccionEscritura = "MX1000"
        HhMomentaryButton5.DireccionLectura = "MX1804"
        HhMomentaryButton5.Etiqueta = "Temperatura"
        HhMomentaryButton5.AutoActualizar = True

        HhMomentaryButton6.Link = mMasterk
        'dejar de utilizar direccion mx1000
        HhMomentaryButton6.DireccionEscritura = "MX1000"
        HhMomentaryButton6.DireccionLectura = "MX1807"
        HhMomentaryButton6.Etiqueta = "Aditivos"
        HhMomentaryButton6.AutoActualizar = True

        HhMomentaryButton7.Link = mMasterk
        HhMomentaryButton7.DireccionEscritura = "MX1000"
        HhMomentaryButton7.DireccionLectura = "MX1808"
        HhMomentaryButton7.Etiqueta = "Centrifuga"
        HhMomentaryButton7.AutoActualizar = True



        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW0030"
        HhNumericDisplay1.Etiqueta = "Temperatura"
        HhNumericDisplay1.Tooltip = "Temperatura actual"
        HhNumericDisplay1.ValorMaximo = 44
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
        HhNumericDisplay5.AutoActualizar = True

        HhNumericDisplay6.Link = mMasterk
        HhNumericDisplay6.DireccionLectura = "DW0020"
        HhNumericDisplay6.Etiqueta = "Set"
        HhNumericDisplay6.Tooltip = "Velocidad set"
        HhNumericDisplay6.AutoActualizar = True

        HhTimeCounterDisplay1.Link = mMasterk
        HhTimeCounterDisplay1.DireccionLectura = "DW0660"
        HhTimeCounterDisplay1.Etiqueta = "Tiempo paso"
        HhTimeCounterDisplay1.Tooltip = "Tiempo paso"
        HhTimeCounterDisplay1.AutoActualizar = True

        HhTimeCounterDisplay2.Link = mMasterk
        HhTimeCounterDisplay2.DireccionLectura = "DW0658"
        HhTimeCounterDisplay2.Etiqueta = "Duracion paso"
        HhTimeCounterDisplay2.Tooltip = "Duracion paso"
        HhTimeCounterDisplay2.AutoActualizar = True

        Button2.Etiqueta = "Mandos"

        Button1.Etiqueta = "Salir"

    End Sub


    Private Sub HhNumericDisplay6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay6.TextChanged
        HhNumericDisplay6.ValorMaximo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay6.ValorMinimo = Val(HhNumericDisplay6.Text)

        HhNumericDisplay5.ValorMaximo = Val(HhNumericDisplay6.Text) + 2
        HhNumericDisplay5.ValorMinimo = Val(HhNumericDisplay6.Text) - 2
    End Sub



    Private Sub HhNumericDisplay4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay4.TextChanged
        HhNumericDisplay4.ValorMaximo = Val(HhNumericDisplay4.Text)
        HhNumericDisplay4.ValorMinimo = Val(HhNumericDisplay4.Text)
        HhNumericDisplay3.ValorMaximo = Val(HhNumericDisplay4.Text) + 1
        HhNumericDisplay3.ValorMinimo = Val(HhNumericDisplay4.Text) - 1
    End Sub




    Private Sub HhMomentaryButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click
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
            fForm.HhNumericEntry1.DireccionEscritura = "DW0135"
            fForm.HhNumericEntry1.DireccionLectura = "DW0135"
            fForm.HhNumericEntry1.Etiqueta = "Cantidad agua"
            fForm.HhNumericEntry1.Unidades = "lts"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.AutoActualizar = True
            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.DireccionEscritura = "DW0134"
            fForm.HhNumericEntry2.DireccionLectura = "DW0134"
            fForm.HhNumericEntry2.Etiqueta = "Temperatura"
            fForm.HhNumericEntry2.Unidades = "°C"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True
            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1700"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"
            fForm.HhMomentaryButton2.Link = mMasterk
            fForm.HhMomentaryButton2.DireccionEscritura = "MX1810"
            fForm.HhMomentaryButton2.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using











    End Sub

    Private Sub HhMomentaryButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhMomentaryButton3.Click
        Using fForm As New FormRotacionAuto
            fForm.HhNumericEntry3.Link = mMasterk
            fForm.HhNumericEntry3.Unidades = "rev"
            fForm.HhNumericEntry3.Etiqueta = "Giros"
            fForm.HhNumericEntry3.Tooltip = "Cantidad de giros"
            fForm.HhNumericEntry3.DireccionEscritura = "DW0123"
            fForm.HhNumericEntry3.DireccionLectura = "DW0123"
            fForm.HhNumericEntry3.ValorMinimo = 1
            fForm.HhNumericEntry3.ValorMaximo = 1000
            fForm.HhNumericEntry3.AutoActualizar = True

            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.Unidades = "seg"
            fForm.HhNumericEntry2.Etiqueta = "Pausa"
            fForm.HhNumericEntry2.Tooltip = "Tiempo de pausa|(Segundos)"
            fForm.HhNumericEntry2.DireccionEscritura = "DW0127"
            fForm.HhNumericEntry2.DireccionLectura = "DW0127"
            fForm.HhNumericEntry2.ValorMinimo = 1
            fForm.HhNumericEntry2.ValorMaximo = 60
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.Unidades = "rpm"
            fForm.HhNumericEntry1.Etiqueta = "Velocidad"
            fForm.HhNumericEntry1.Tooltip = "Velocidad de rotacion|(rpm)"
            fForm.HhNumericEntry1.DireccionEscritura = "DW0126"
            fForm.HhNumericEntry1.DireccionLectura = "DW0126"
            fForm.HhNumericEntry1.ValorMinimo = 0
            '--cambiar
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1701"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"

            fForm.Button1.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton5.Click
        Using fForm As New FormCalefaccionManual
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0184"
            fForm.HhNumericEntry1.DireccionLectura = "DW0184"
            fForm.HhNumericEntry1.Unidades = "°C"
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
            fForm.HhNumericEntry2.DireccionEscritura = "DW0183"
            fForm.HhNumericEntry2.DireccionLectura = "DW0183"
            fForm.HhNumericEntry2.Etiqueta = "Gradiente (°C/min)"
            fForm.HhNumericEntry2.Unidades = "°C/min"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionEscritura = "MX1719"
            fForm.HhToggleButton2.DireccionLectura = "MX1719"
            fForm.HhToggleButton2.Etiqueta = "Con gradiente"
            fForm.HhToggleButton2.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1704"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"

            fForm.Button1.Link = mMasterk
            fForm.Button1.DireccionEscritura = "MX1814"
            fForm.Button1.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton4.Click
        Using fForm As New FormMantenimientoManual
         fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.Etiqueta = "Temperatura constante"
            fForm.HhToggleButton1.DireccionLectura = "MX1714"
            fForm.HhToggleButton1.DireccionEscritura = "MX1714"
            fForm.HhToggleButton1.AutoActualizar = True

            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.Unidades = "min"
            fForm.HhNumericEntry1.Etiqueta = "Tiempo"
            fForm.HhNumericEntry1.Tooltip = "Tiempo de trabajo|(Minutos)"
            fForm.HhNumericEntry1.DireccionLectura = "DW0198"
            fForm.HhNumericEntry1.DireccionEscritura = "DW0198"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 600
            fForm.HhNumericEntry1.AutoActualizar = True


            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.Unidades = "°C"
            fForm.HhNumericEntry2.Etiqueta = "Temperatura"
            fForm.HhNumericEntry2.Tooltip = "Temperatura|(°C)"
            fForm.HhNumericEntry2.DireccionEscritura = "DW0194"
            fForm.HhNumericEntry2.DireccionLectura = "DW0194"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1702"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"

            fForm.Button1.Link = mMasterk
            fForm.Button1.DireccionEscritura = "MX1812"
            fForm.Button1.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using




    End Sub



    Private Sub HhMomentaryButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton6.Click
        Using fForm As New FormAditivosAuto
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0153"
            fForm.HhNumericEntry1.DireccionLectura = "DW0153"
            fForm.HhNumericEntry1.Etiqueta = "Enjuagues"
            fForm.HhNumericEntry1.ValorMinimo = 1
            fForm.HhNumericEntry1.ValorMaximo = 10
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionEscritura = "MX18"
            fForm.HhToggleButton1.DireccionLectura = "MX18"
            fForm.HhToggleButton1.Etiqueta = "Cubeta 1"
            fForm.HhToggleButton1.AutoActualizar = True

            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionEscritura = "MX1A"
            fForm.HhToggleButton2.DireccionLectura = "MX1A"
            fForm.HhToggleButton2.Etiqueta = "A la izquierda"
            fForm.HhToggleButton2.AutoActualizar = True

            fForm.HhToggleButton3.Link = mMasterk
            fForm.HhToggleButton3.DireccionEscritura = "MX1B"
            fForm.HhToggleButton3.DireccionLectura = "MX1B"
            fForm.HhToggleButton3.Etiqueta = "A la derecha"
            fForm.HhToggleButton3.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1707"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"

            fForm.Button1.Link = mMasterk
            fForm.Button1.DireccionEscritura = "MX1817"
            fForm.Button1.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton2.Click
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
            fForm.HhNumericEntry1.DireccionEscritura = "DW0147"
            fForm.HhNumericEntry1.DireccionLectura = "DW0147"
            fForm.HhNumericEntry1.Etiqueta = "Tiempo (seg)"
            fForm.HhNumericEntry1.Unidades = "seg"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 300
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1703"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"

            fForm.Button1.Link = mMasterk
            fForm.Button1.DireccionEscritura = "MX1813"
            fForm.Button1.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using



    End Sub

    Private Sub HhMomentaryButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton7.Click
        Using fForm As New FormCentrifugaAuto
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0116"
            fForm.HhNumericEntry1.DireccionLectura = "DW0116"
            fForm.HhNumericEntry1.Unidades = "rpm"
            fForm.HhNumericEntry1.Etiqueta = "Velocidad"
            fForm.HhNumericEntry1.Tooltip = "Velocidad|(rpm)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            'cambiar
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.DireccionEscritura = "DW0118"
            fForm.HhNumericEntry2.DireccionLectura = "DW0118"
            fForm.HhNumericEntry2.Unidades = "min"
            fForm.HhNumericEntry2.Etiqueta = "Tiempo"
            fForm.HhNumericEntry2.Tooltip = "Tiempo|(Minutos)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 120
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX1708"
            fForm.HhMomentaryButton1.Etiqueta = "Aceptar"

            fForm.Button1.Link = mMasterk
            fForm.Button1.DireccionEscritura = "MX1818"
            fForm.Button1.Etiqueta = "Cancelar"

            fForm.ShowDialog()
        End Using


    End Sub


    Private Sub HhNumericDisplay2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay2.TextChanged
        HhNumericDisplay2.ValorMaximo = Val(HhNumericDisplay2.Text)
        HhNumericDisplay2.ValorMinimo = Val(HhNumericDisplay2.Text)
        If Val(HhNumericDisplay2.Text) = 0 Then
            HhNumericDisplay1.ValorMaximo = 44
            HhNumericDisplay1.ValorMinimo = 5
        Else
            HhNumericDisplay1.ValorMaximo = Val(HhNumericDisplay2.Text) + 1
            HhNumericDisplay1.ValorMinimo = Val(HhNumericDisplay2.Text) - 1
        End If
    End Sub

 
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using f As New FormMandos
            f.ShowDialog()
        End Using
    End Sub


    Private Sub HhTimeCounterDisplay2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhTimeCounterDisplay2.TextChanged
        HhTimeCounterDisplay1.ValorMaximo = HhTimeCounterDisplay2.Valor
        HhTimeCounterDisplay2.ValorMaximo = HhTimeCounterDisplay2.Valor
    End Sub



    Private Sub HhTimeCounterDisplay1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhTimeCounterDisplay1.TextChanged
        If HhTimeCounterDisplay2.Valor = 0 Then
            HhTimeCounterDisplay1.ValorMaximo = HhTimeCounterDisplay1.Valor
        End If
    End Sub

End Class