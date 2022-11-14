
Imports IniFileVb

Public Class FormAutomatico

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        UnAttach(Me)
        Me.Close()
    End Sub

    Private Sub FormAutomatico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormAutomatico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sRecetaNombre As String
        Dim sRecetaDescripcion As String

        mMasterk.EstablecerBoolean("MX0001", True)

        HhNumericDisplay1.Link = mMasterk
        HhNumericDisplay1.DireccionLectura = "DW0030"
        HhNumericDisplay1.Tooltip = "Temperatura actual"
        HhNumericDisplay1.ValorMaximo = 44
        HhNumericDisplay1.ValorMinimo = 5
        HhNumericDisplay1.AutoActualizar = True

        HhNumericDisplay2.Link = mMasterk
        HhNumericDisplay2.DireccionLectura = "DW0560"
        HhNumericDisplay2.Tooltip = "Temperatura programada"
        HhNumericDisplay2.AutoActualizar = True

        HhNumericDisplay3.Link = mMasterk
        HhNumericDisplay3.DireccionLectura = "DW0508"
        HhNumericDisplay3.Tooltip = "Litros actual"
        HhNumericDisplay3.AutoActualizar = True

        HhNumericDisplay4.Link = mMasterk
        HhNumericDisplay4.DireccionLectura = "DW0512"
        HhNumericDisplay4.Tooltip = "Litros programados"
        HhNumericDisplay4.AutoActualizar = True

        HhNumericDisplay5.Link = mMasterk
        HhNumericDisplay5.DireccionLectura = "DW0514"
        HhNumericDisplay5.Tooltip = "Velocidad actual"
        HhNumericDisplay5.AutoActualizar = True

        HhNumericDisplay6.Link = mMasterk
        HhNumericDisplay6.DireccionLectura = "DW0020"
        HhNumericDisplay6.Tooltip = "Velocidad programada"
        HhNumericDisplay6.AutoActualizar = True

        HhTimeCounterDisplay1.Link = mMasterk
        HhTimeCounterDisplay1.DireccionLectura = "DW0660"
        HhTimeCounterDisplay1.Tooltip = "Tiempo paso"
        HhTimeCounterDisplay1.AutoActualizar = True

        HhTimeCounterDisplay2.Link = mMasterk
        HhTimeCounterDisplay2.DireccionLectura = "DW0658"
        HhTimeCounterDisplay2.Tooltip = "Duracion paso"
        HhTimeCounterDisplay2.AutoActualizar = True

        HhTimeCounterDisplay3.Link = mMasterk
        HhTimeCounterDisplay3.DireccionLectura = "DW0650"
        HhTimeCounterDisplay3.Tooltip = "Tiempo receta"
        HhTimeCounterDisplay3.AutoActualizar = True

        HhTimeCounterDisplay4.Tooltip = "Duracion receta"
        HhTimeCounterDisplay4.AutoActualizar = False

        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX0B"
        HhMomentaryButton1.DireccionLectura = "MX0100"
        HhMomentaryButton1.Texto = "Play"
        HhMomentaryButton1.AutoActualizar = True

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX0243"
        HhMomentaryButton2.DireccionLectura = "MX0241"
        HhMomentaryButton2.Texto = "Pause"
        HhMomentaryButton2.AutoActualizar = True

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX0C"
        HhMomentaryButton3.Texto = "Stop"

        HhMomentaryButton4.Link = mMasterk
        HhMomentaryButton4.DireccionEscritura = "MX0075"
        HhMomentaryButton4.Texto = "Editar"

        Button1.Texto = "Salir"
        Button3.Texto = "Salta paso"
        Button4.Texto = "Recetas"
        Button5.Texto = "Mandos"


        sRecetaNombre = ObtenerCadenaLarga("DW1930", 40)
        sRecetaDescripcion = ObtenerCadenaLarga("DW1950", 100)

        HhCharacterDisplay1.LongitudTexto = 40
        HhCharacterDisplay1.Texto = sRecetaNombre

        HhCharacterDisplay2.LongitudTexto = 100
        HhCharacterDisplay2.Texto = sRecetaDescripcion

        HhGridDisplay1.RecetaNombre = sRecetaNombre
        HhGridDisplay1.RecetaDescripcion = sRecetaDescripcion
        HhGridDisplay1.Link = mMasterk
        HhGridDisplay1.DireccionLectura = "DW2000"
        HhGridDisplay1.DireccionPaso = "DW0600"
        HhGridDisplay1.LongitudPaso = 10
        HhGridDisplay1.LongitudReceta = 200
        HhGridDisplay1.MostrarSeleccion = True
        HhGridDisplay1.EscribirPaso = False
        HhGridDisplay1.AutoActualizar = True
        HhGridDisplay1.RecibirReceta()
    End Sub
    Private Sub HhNumericDisplay6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay6.TextChanged
        HhNumericDisplay6.ValorMaximo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay6.ValorMinimo = Val(HhNumericDisplay6.Text)
        HhNumericDisplay5.ValorMaximo = Val(HhNumericDisplay6.Text) + 1
        HhNumericDisplay5.ValorMinimo = Val(HhNumericDisplay6.Text) - 1
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim bPasswordOk As Boolean
        Dim iNivelPasswordMinimo As Integer
        iNivelPasswordMinimo = Val(GetSetting("Lavadora", "Permisos", "NivelSaltaPaso"))
        If iNivelPasswordMinimo = 0 Then
            bPasswordOk = True
        End If
        If iNivelPasswordMinimo > 0 Then
            Using p As New hhPasswordEntry.hhPasswordEntry
                p.Aplicacion = "Lavadora"
                p.Seccion = "Permisos"
                If p.ShowDialog = vbOK Then
                    If p.NivelDeAutorizacion >= iNivelPasswordMinimo Then
                        bPasswordOk = True
                    End If
                End If
            End Using
        End If
        If bPasswordOk Then
            Using f As New FormCambiaPaso
                mMasterk.EstablecerEntero("DW50", HhGridDisplay1.PasoActual)
                f.HhGridDisplay1.Receta = HhGridDisplay1.Receta
                f.HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual
                f.HhGridDisplay1.Actualizar()
                f.ShowDialog()
            End Using
        End If
    End Sub
    Private Sub HhTimeCounterDisplay2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhTimeCounterDisplay2.TextChanged
        HhTimeCounterDisplay1.ValorMaximo = HhTimeCounterDisplay2.Valor
        HhTimeCounterDisplay2.ValorMaximo = HhTimeCounterDisplay2.Valor
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim bArchivoExiste As Boolean
        Dim sRecetaDescripcion As String
        Dim sRecetaNombre As String
        Dim cPasos As New Collection
        Dim i As New IniFileVb.IniFileVb
        Dim iContador As Integer
        Dim pPaso As LavadoraLib.Receta.Paso

        HhDialogoArchivos1.Unidad = Environment.CurrentDirectory
        HhDialogoArchivos1.Extension = "*.REC"
        HhDialogoArchivos1.Longitud = 40
        HhDialogoArchivos1.ShowDialog()

        If Len(HhDialogoArchivos1.NombreCompleto) Then
            Try
                If My.Computer.FileSystem.FileExists(HhDialogoArchivos1.NombreCompleto) Then
                    bArchivoExiste = True
                End If
            Catch ex As Exception
                Exit Sub
            End Try
            If bArchivoExiste Then
                i.Load(HhDialogoArchivos1.NombreCompleto)
                For iContador = 1 To 200
                    pPaso = New LavadoraLib.Receta.Paso

                    pPaso.IdPaso = Val(i.GetKeyValue("Paso" & iContador.ToString, "IdPaso"))
                    pPaso.ParametroAuxiliar = Val(i.GetKeyValue("Paso" & iContador.ToString, "ParametroAuxiliar"))
                    pPaso.Centigrados = Val(i.GetKeyValue("Paso" & iContador.ToString, "Centigrados"))
                    pPaso.Litros = Val(i.GetKeyValue("Paso" & iContador.ToString, "Litros"))
                    pPaso.RPM = Val(i.GetKeyValue("Paso" & iContador.ToString, "RPM"))
                    pPaso.Segundos = Val(i.GetKeyValue("Paso" & iContador.ToString, "Segundos"))
                    pPaso.Minutos = Val(i.GetKeyValue("Paso" & iContador.ToString, "Minutos"))
                    pPaso.Argumentos = Val(i.GetKeyValue("Paso" & iContador.ToString, "Argumentos"))
                    If pPaso.IdPaso <> 0 Then
                        cPasos.Add(pPaso)
                    End If
                Next
                sRecetaNombre = i.GetKeyValue("Receta", "Nombre").PadRight(40)
                sRecetaDescripcion = i.GetKeyValue("Receta", "Descripcion").PadRight(100)
                mMasterk.EstablecerCadena("DW1930", sRecetaNombre)
                mMasterk.EstablecerCadena("DW1950", sRecetaDescripcion)

                HhCharacterDisplay1.Texto = sRecetaNombre
                HhCharacterDisplay1.LongitudTexto = 40
                HhCharacterDisplay2.Texto = sRecetaDescripcion
                HhCharacterDisplay2.LongitudTexto = 100
                HhGridDisplay1.RecetaNombre = sRecetaNombre
                HhGridDisplay1.RecetaDescripcion = sRecetaDescripcion
                HhGridDisplay1.Receta = cPasos
                HhGridDisplay1.EnviarReceta()
                HhGridDisplay1.Actualizar()
            End If
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Using fForm As New FormMandos
            If mMasterk.ObtenerBoolean("MX0100") Then
                Using m As New hhMsgBox.hhMsgBox
                    m.Mensaje = "La maquina esta trabajando. Parar la maquina?"
                    m.Link = mMasterk
                    m.Tamanio = 50
                    m.Imagen = My.Resources.traffic_lights_green
                    m.TextoOk = ""
                    m.TextoCancel = ""
                    m.ImagenOk = My.Resources.control_stop_blue
                    m.ImagenCancel = My.Resources.cross
                    m.DireccionOk = "MX0C"
                    m.DireccionCancel = "FX14"
                    m.ShowDialog()
                    If m.Resultado = Windows.Forms.DialogResult.OK Then
                        fForm.ShowDialog()
                    End If
                End Using
            Else
                fForm.ShowDialog()
            End If
        End Using
    End Sub

    Private Sub HhNumericDisplay4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhNumericDisplay4.TextChanged
        Dim iValue As Integer
        iValue = Val(HhNumericDisplay4.Text)
        HhNumericDisplay4.ValorMaximo = iValue
        HhNumericDisplay4.ValorMinimo = iValue
        HhNumericDisplay3.ValorMaximo = iValue + 2
        HhNumericDisplay3.ValorMinimo = iValue - 2
    End Sub

    Private Sub HhNumericDisplay2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhNumericDisplay2.TextChanged
        Dim iValue As Integer
        iValue = Val(HhNumericDisplay2.Text)
        HhNumericDisplay2.ValorMaximo = iValue
        HhNumericDisplay2.ValorMinimo = iValue
        If iValue = 0 Then
            HhNumericDisplay1.ValorMaximo = 44
            HhNumericDisplay1.ValorMinimo = 5
        Else
            HhNumericDisplay1.ValorMaximo = iValue + 2
            HhNumericDisplay1.ValorMinimo = iValue - 2
        End If
    End Sub

    Private Sub HhTimeCounterDisplay4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhTimeCounterDisplay4.TextChanged
        HhTimeCounterDisplay4.ValorMaximo = HhTimeCounterDisplay4.Valor
    End Sub

    Private Sub HhMomentaryButton4_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton4.Click
        Dim bPasswordOk As Boolean
        Dim iNivelPasswordMinimo As Integer
        iNivelPasswordMinimo = Val(GetSetting("Lavadora", "Permisos", "NivelEditarReceta"))
        If iNivelPasswordMinimo = 0 Then
            bPasswordOk = True
        End If
        If iNivelPasswordMinimo > 0 Then
            Using p As New hhPasswordEntry.hhPasswordEntry
                p.Aplicacion = "Lavadora"
                p.Seccion = "Permisos"
                If p.ShowDialog = vbOK Then
                    If p.NivelDeAutorizacion >= iNivelPasswordMinimo Then
                        bPasswordOk = True
                    End If
                End If
            End Using
        End If
        If bPasswordOk Then
            Using f As New FormEditorAuto
                f.HhGridDisplay1.Receta = HhGridDisplay1.Receta
                f.HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual
                f.HhGridDisplay1.RecetaNombre = HhGridDisplay1.RecetaNombre
                f.HhGridDisplay1.RecetaDescripcion = HhGridDisplay1.RecetaDescripcion
                f.HhCharacterDisplay1.LongitudTexto = 40
                f.HhCharacterDisplay1.Texto = HhGridDisplay1.RecetaNombre
                f.HhCharacterDisplay2.LongitudTexto = 100
                f.HhCharacterDisplay2.Texto = HhGridDisplay1.RecetaDescripcion
                If f.ShowDialog() = DialogResult.OK Then
                    HhGridDisplay1.Receta = f.HhGridDisplay1.Receta
                    HhGridDisplay1.EnviarReceta()
                    HhGridDisplay1.Actualizar()
                End If
            End Using
        End If
    End Sub
    Private Sub HhGridDisplay1_CambioDeReceta(sender As Object, e As EventArgs) Handles HhGridDisplay1.CambioDeReceta
        HhTimeCounterDisplay4.Valor = HhGridDisplay1.RecetaDuracion
        HhTimeCounterDisplay3.ValorMaximo = HhTimeCounterDisplay4.Valor
    End Sub
End Class