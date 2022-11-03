Imports LavadoraLib
Imports LavadoraLib.Receta

Public Class FormEditorAuto
    Dim pPasoLlenado As New LavadoraLib.Receta.Paso
    Dim pPasoDesague As New LavadoraLib.Receta.Paso
    Dim pPasoRotacion As New LavadoraLib.Receta.Paso
    Dim pPasoMantenimiento As New LavadoraLib.Receta.Paso
    Dim pPasoTemperatura As New LavadoraLib.Receta.Paso
    Dim pPasoCentrifuga As New LavadoraLib.Receta.Paso
    Dim pPasoAditivos As New LavadoraLib.Receta.Paso
    Dim pPasoMuestreo As New LavadoraLib.Receta.Paso
    Dim pPasoFin As New LavadoraLib.Receta.Paso
    Dim pPasoJet As New LavadoraLib.Receta.Paso
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Function AgregarPaso(grid As hhGridDisplay.hhGridDisplay, paso As LavadoraLib.Receta.Paso) As Collection
        Dim cReceta As New Collection
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim iContador As Integer
        iContador = 1
        For Each pPasoSinModificar In grid.Receta
            If iContador = grid.PasoActual Then
                cReceta.Add(paso)
                If pPasoSinModificar.IdPaso <> paso.IdPaso Then
                    cReceta.Add(pPasoSinModificar)
                End If
            Else
                cReceta.Add(pPasoSinModificar)
            End If
            iContador = iContador + 1
        Next pPasoSinModificar
        Return cReceta
    End Function
    Private Function ObtenerPasoActual(grid As hhGridDisplay.hhGridDisplay) As LavadoraLib.Receta.Paso
        Dim iPasoActual As Integer
        Dim pPasoActual As New LavadoraLib.Receta.Paso
        iPasoActual = grid.PasoActual
        If iPasoActual = 0 Then iPasoActual = 1
        If grid.Receta.Count > iPasoActual Then
            pPasoActual = grid.Receta.Item(iPasoActual)
        End If
        Return pPasoActual
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim cReceta As New Collection
        Dim pPaso As New LavadoraLib.Receta.Paso

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 19532 Then
        Else
            pPaso = pPasoLlenado
        End If
        Using fForm As New FormLlenadoAuto
            fForm.HhToggleButton1.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 0)

            fForm.HhToggleButton2.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 1)

            fForm.HhToggleButton3.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 2)

            fForm.HhToggleButton4.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 3)

            fForm.HhNumericEntry1.Unidades = "lts"
            fForm.HhNumericEntry1.Tooltip = "Cantidad agua|(Litros)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.Valor = pPaso.Litros

            fForm.HhNumericEntry2.Unidades = "°C"
            fForm.HhNumericEntry2.Tooltip = "Temperatura|(°C)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.Valor = pPaso.Centigrados

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            If fForm.ShowDialog() = vbOK Then
                pPaso.Litros = fForm.HhNumericEntry1.Valor
                pPaso.Centigrados = fForm.HhNumericEntry2.Valor
                If fForm.HhToggleButton1.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 0)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 0)
                End If
                If fForm.HhToggleButton2.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 1)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 1)
                End If
                If fForm.HhToggleButton3.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 2)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 2)
                End If
                If fForm.HhToggleButton4.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 3)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 3)
                End If

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoLlenado = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 17732 Then
        Else
            pPaso = pPasoDesague
        End If
        Using fForm As New FormDesagueAuto
            fForm.HhToggleButton1.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 5)

            fForm.HhToggleButton2.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 7)

            fForm.HhNumericEntry1.Unidades = "seg"
            fForm.HhNumericEntry1.Tooltip = "Tiempo|(Segundos)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 300
            fForm.HhNumericEntry1.Valor = pPaso.Segundos

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                pPaso.Segundos = fForm.HhNumericEntry1.Valor

                If fForm.HhToggleButton1.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 5)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 5)
                End If
                If fForm.HhToggleButton2.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 7)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 7)
                End If

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoDesague = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 20306 Then
        Else
            pPaso = pPasoRotacion
        End If
        Using fForm As New FormRotacionAuto
            fForm.HhNumericEntry3.Unidades = "rev"
            fForm.HhNumericEntry3.Tooltip = "Cantidad de giros"
            fForm.HhNumericEntry3.ValorMinimo = 1
            fForm.HhNumericEntry3.ValorMaximo = 1000
            fForm.HhNumericEntry3.Valor = pPaso.ParametroAuxiliar

            fForm.HhNumericEntry2.Unidades = "seg"
            fForm.HhNumericEntry2.Tooltip = "Tiempo de pausa|(Segundos)"
            fForm.HhNumericEntry2.ValorMinimo = 1
            fForm.HhNumericEntry2.ValorMaximo = 60
            fForm.HhNumericEntry2.Valor = pPaso.Segundos

            fForm.HhNumericEntry1.Unidades = "rpm"
            fForm.HhNumericEntry1.Tooltip = "Velocidad de rotacion|(rpm)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.Valor = pPaso.RPM

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                pPaso.ParametroAuxiliar = fForm.HhNumericEntry3.Valor
                pPaso.Segundos = fForm.HhNumericEntry2.Valor
                pPaso.RPM = fForm.HhNumericEntry1.Valor

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoRotacion = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 16717 Then
        Else
            pPaso = pPasoMantenimiento
        End If
        Using fForm As New FormMantenimientoAuto
            fForm.HhToggleButton1.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 4)

            fForm.HhNumericEntry1.Unidades = "min"
            fForm.HhNumericEntry1.Tooltip = "Tiempo de trabajo|(Minutos)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 600
            fForm.HhNumericEntry1.Valor = pPaso.Minutos

            fForm.HhNumericEntry2.Unidades = "°C"
            fForm.HhNumericEntry2.Tooltip = "Temperatura|(°C)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.Valor = pPaso.Centigrados

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                pPaso.Minutos = fForm.HhNumericEntry1.Valor
                pPaso.Centigrados = fForm.HhNumericEntry2.Valor
                If fForm.HhToggleButton1.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 4)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 4)
                End If

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoMantenimiento = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 17748 Then
        Else
            pPaso = pPasoTemperatura
        End If
        Using fForm As New FormTemperaturaAuto
            fForm.HhNumericEntry1.Unidades = "°C"
            fForm.HhNumericEntry1.Tooltip = "Temperatura final|(°C)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 100
            fForm.HhNumericEntry1.Valor = pPaso.Centigrados

            fForm.HhToggleButton1.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 6)

            fForm.HhNumericEntry2.Unidades = "°C/min"
            fForm.HhNumericEntry2.Tooltip = "Gradiente de temp.|(°C/min)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.Valor = pPaso.ParametroAuxiliar

            fForm.HhToggleButton2.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 9)

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                pPaso.Centigrados = fForm.HhNumericEntry1.Valor
                pPaso.ParametroAuxiliar = fForm.HhNumericEntry2.Valor
                If fForm.HhToggleButton1.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 6)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 6)
                End If
                If fForm.HhToggleButton2.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 9)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 9)
                End If

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoTemperatura = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub


    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 17731 Then
        Else
            pPaso = pPasoCentrifuga
        End If
        Using fForm As New FormCentrifugaAuto
            fForm.HhNumericEntry1.Unidades = "rpm"
            fForm.HhNumericEntry1.Tooltip = "Velocidad|(rpm)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 3000
            fForm.HhNumericEntry1.Valor = pPaso.RPM

            fForm.HhNumericEntry2.Unidades = "min"
            fForm.HhNumericEntry2.Tooltip = "Tiempo|(Minutos)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 120
            fForm.HhNumericEntry2.Valor = pPaso.Minutos

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                pPaso.RPM = fForm.HhNumericEntry1.Valor
                pPaso.Minutos = fForm.HhNumericEntry2.Valor

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoCentrifuga = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 17473 Then
        Else
            pPaso = pPasoAditivos
        End If
        Using fForm As New FormAditivosAuto
            If mMasterk.ObtenerBoolean("KX04") Then
                fForm.HhNumericEntry2.Enabled = False
            End If

            fForm.HhNumericEntry1.ValorMinimo = 1
            fForm.HhNumericEntry1.ValorMaximo = 10
            fForm.HhNumericEntry1.Valor = pPaso.ParametroAuxiliar

            fForm.HhNumericEntry2.ValorMinimo = 1
            fForm.HhNumericEntry2.ValorMaximo = 600
            fForm.HhNumericEntry2.Unidades = "seg"

            fForm.HhToggleButton1.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 8)

            fForm.HhToggleButton2.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 10)

            fForm.HhToggleButton3.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 11)

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then

                pPaso.Segundos = fForm.HhNumericEntry2.Valor
                pPaso.ParametroAuxiliar = fForm.HhNumericEntry1.Valor

                If fForm.HhToggleButton1.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 8)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 8)
                End If
                If fForm.HhToggleButton2.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 10)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 10)
                End If
                If fForm.HhToggleButton3.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 11)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 11)
                End If

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoAditivos = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 21837 Then
        Else
            pPaso = pPasoMuestreo
        End If
        Using fForm As New FormMuestreoAuto
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoMuestreo = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub

    Private Sub HhMomentaryButton1_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton1.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 18758 Then
        Else
            pPaso = pPasoFin
        End If
        Using fForm As New FormMuestreoAuto
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoFin = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub
    Private Sub HhMomentaryButton6_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton6.Click
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoSinModificar As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection

        pPaso = ObtenerPasoActual(HhGridDisplay1)
        If pPaso.IdPaso = 17738 Then
        Else
            pPaso = pPasoJet
        End If
        Using fForm As New FormJetAuto
            fForm.HhToggleButton1.Checked = BitManipulation.BitManipulation.ExamineBit(pPaso.Argumentos, 12)

            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            If fForm.ShowDialog() = vbOK Then
                If fForm.HhToggleButton1.Checked Then
                    pPaso.Argumentos = BitManipulation.BitManipulation.SetBit(pPaso.Argumentos, 12)
                Else
                    pPaso.Argumentos = BitManipulation.BitManipulation.ClearBit(pPaso.Argumentos, 12)
                End If

                cReceta = AgregarPaso(HhGridDisplay1, pPaso)

                pPasoJet = pPaso

                HhGridDisplay1.Receta = cReceta
                HhGridDisplay1.PasoActual = HhGridDisplay1.PasoActual + 1
            End If
        End Using
    End Sub
    Private Sub FormEditorAuto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormEditorAuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pPasoLlenado.IdPaso = 19532
        pPasoLlenado.NombrePaso = "LLENADO"
        pPasoDesague.IdPaso = 17732
        pPasoDesague.NombrePaso = "DESAGUE"
        pPasoRotacion.IdPaso = 20306
        pPasoRotacion.NombrePaso = "ROTACION"
        pPasoMantenimiento.IdPaso = 16717
        pPasoMantenimiento.NombrePaso = "MANTENIMIENTO"
        pPasoTemperatura.IdPaso = 17748
        pPasoTemperatura.NombrePaso = "TEMPERATURA"
        pPasoCentrifuga.IdPaso = 17731
        pPasoCentrifuga.NombrePaso = "CENTRIFUGA"
        pPasoAditivos.IdPaso = 17473
        pPasoAditivos.NombrePaso = "ADITIVOS"
        pPasoMuestreo.IdPaso = 21837
        pPasoMuestreo.NombrePaso = "MUESTREO"
        pPasoFin.IdPaso = 18758
        pPasoFin.NombrePaso = "FIN"
        pPasojet.IdPaso = 17738
        pPasojet.NombrePaso = "JET"

        HhGridDisplay1.LongitudPaso = 10
        HhGridDisplay1.LongitudTexto = 4
        HhGridDisplay1.MostrarSeleccion = True
        HhGridDisplay1.EscribirPaso = True
        HhGridDisplay1.AutoActualizar = True

        HhNumericEntry1.ValorMaximo = 100
        HhNumericEntry1.ValorMinimo = 1

        HhMomentaryButton1.Texto = "Fin"

        HhMomentaryButton2.Texto = "Insertar"

        HhMomentaryButton3.Texto = "Eliminar"

        HhMomentaryButton4.Texto = "Envia"

        HhMomentaryButton5.Texto = "Nueva"

        Button2.Texto = "Llenado"

        Button3.Texto = "Desague"

        Button5.Texto = "Rotacion"

        Button6.Texto = "Mantenimiento"

        Button7.Texto = "Temperatura"

        Button8.Texto = "Centrifuga"

        Button9.Texto = "Aditivos"

        Button10.Texto = "Muestreo"

        Button4.Texto = "Guardar"

        Button1.Texto = "Salir"
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim bSalir As Boolean
        Dim bCancelar As Boolean
        Dim bArchivoGuardado As Boolean
        Dim bArchivoExiste As Boolean
        Dim bf As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter

        bArchivoGuardado = False
        bCancelar = False
        bSalir = False

        While Not bSalir
            HhDialogoArchivos1.Unidad = Environment.CurrentDirectory
            HhDialogoArchivos1.Extension = "*.REC"
            HhDialogoArchivos1.Longitud = 20
            HhDialogoArchivos1.ShowDialog()
            If HhDialogoArchivos1.Resultado = Windows.Forms.DialogResult.Cancel Then
                bSalir = True
            Else
                If Len(HhDialogoArchivos1.NombreCompleto) >= Len(HhDialogoArchivos1.Extension) Then
                    Try
                        bArchivoExiste = False
                        If My.Computer.FileSystem.FileExists(HhDialogoArchivos1.NombreCompleto) Then
                            bArchivoExiste = True
                        End If

                    Catch ex As Exception
                        Exit Sub
                    End Try
                    If bArchivoExiste Then
                        Using m As New hhMsgBox.hhMsgBox
                            m.Mensaje = "Sobreescribir archivo existente?"
                            m.Tamanio = 50
                            m.ImagenOk = My.Resources.tick
                            m.TextoOk = "Si"
                            m.ImagenCancel = My.Resources.cross
                            m.TextoCancel = "No"
                            m.ShowDialog()
                            If m.Resultado = Windows.Forms.DialogResult.OK Then
                                bCancelar = False
                            Else
                                bCancelar = True
                            End If
                        End Using
                    End If
                    If Not bCancelar Then
                        Try
                            Dim fs As New System.IO.FileStream(HhDialogoArchivos1.NombreCompleto, IO.FileMode.OpenOrCreate)
                            bf.Serialize(fs, HhGridDisplay1.Receta)
                            fs.Close()
                            bArchivoGuardado = True
                            bSalir = True
                        Catch
                        End Try
                    End If
                End If
            End If
        End While
    End Sub
    Private Sub HhGridDisplay1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HhGridDisplay1.CellClick
        Dim iValor As Integer
        iValor = e.RowIndex + 1
        HhNumericEntry1.Valor = iValor
    End Sub
    Private Sub HhMomentaryButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton4.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub HhMomentaryButton5_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton5.Click
        Dim iIter As Integer
        Dim cReceta As New Collection
        Dim pPaso As New LavadoraLib.Receta.Paso
        For iIter = 1 To 100
            cReceta.Add(pPaso)
        Next iIter
        HhGridDisplay1.Receta = cReceta
        HhGridDisplay1.PasoActual = 1
    End Sub

    Private Sub HhMomentaryButton2_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton2.Click
        Dim iContador As Integer
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim pPasoEnBlanco As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection
        iContador = 1
        For Each pPaso In HhGridDisplay1.Receta
            If iContador = HhGridDisplay1.PasoActual Then
                cReceta.Add(pPasoEnBlanco)
            End If
            cReceta.Add(pPaso)
            iContador = iContador + 1
        Next pPaso
        HhGridDisplay1.Receta = cReceta
    End Sub

    Private Sub HhMomentaryButton3_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton3.Click
        Dim iContador As Integer
        Dim pPaso As New LavadoraLib.Receta.Paso
        Dim cReceta As New Collection
        iContador = 1
        For Each pPaso In HhGridDisplay1.Receta
            If iContador <> HhGridDisplay1.PasoActual Then
                cReceta.Add(pPaso)
            End If
            iContador = iContador + 1
        Next pPaso
        If cReceta.Count <= 0 Then
            cReceta.Add(pPaso)
        End If
        HhGridDisplay1.Receta = cReceta
    End Sub

    Private Sub HhNumericEntry1_TextChanged(sender As Object, e As EventArgs) Handles HhNumericEntry1.TextChanged
        Dim iValor As Integer
        iValor = HhNumericEntry1.Valor
        HhGridDisplay1.PasoActual = ivalor
    End Sub
End Class