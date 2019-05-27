Imports System.ComponentModel

Public Class FormLavadora

    Dim WithEvents wPagina As hhWordRegister.hhWordRegister

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cParametros = New Collection
        wPagina = New hhWordRegister.hhWordRegister
        CargarOpciones()
        AbrirPuerto()



        mMasterk = New MasterKlib.MasterK

        mMasterk.Puerto = sPuerto
        mMasterk.Estacion = 0
        Timer1.Interval = 1000
        Timer1.Enabled = True

        wPagina.Link = mMasterk
        wPagina.Nombre = "Pagina"
        wPagina.DireccionEscritura = "DW60"
        wPagina.DireccionLectura = "DW60"
        wPagina.ValorMaximo = 32
        wPagina.AutoActualizar = True


        HhAnimacion1.Color1 = SystemColors.HighlightText
        HhAnimacion1.Color2 = SystemColors.Highlight
        HhAnimacion1.Intervalo = 100
        HhAnimacion1.Pasos = 32
        HhAnimacion1.Text = "TX"
        HhAnimacion1.BorderStyle = BorderStyle.Fixed3D
        HhAnimacion1.Inicializar()

        HhAnimacion2.Color2 = SystemColors.Highlight
        HhAnimacion2.Color1 = SystemColors.HighlightText
        HhAnimacion2.Intervalo = 100
        HhAnimacion2.Pasos = 32
        HhAnimacion2.Text = "RX"
        HhAnimacion2.BorderStyle = BorderStyle.Fixed3D
        HhAnimacion2.Inicializar()

        HhBooleanLabel1.Link = mMasterk
        HhBooleanLabel1.TextoFalso = "Manual"
        HhBooleanLabel1.TextoVerdadero = "Automatico"
        HhBooleanLabel1.ColorTextoFalso = SystemColors.ControlText
        HhBooleanLabel1.ColorFondoFalso = SystemColors.Control
        HhBooleanLabel1.ColorTextoVerdadero = SystemColors.HighlightText
        HhBooleanLabel1.ColorFondoVerdadero = SystemColors.Highlight
        HhBooleanLabel1.DireccionLectura = "MX0001"
        HhBooleanLabel1.AutoSize = True
        HhBooleanLabel1.BorderStyle = BorderStyle.Fixed3D
        HhBooleanLabel1.AutoActualizar = True

        HhBooleanLabel2.Link = mMasterk
        HhBooleanLabel2.TextoFalso = "Stop"
        HhBooleanLabel2.TextoVerdadero = "Start"
        HhBooleanLabel2.ColorTextoFalso = SystemColors.ControlText
        HhBooleanLabel2.ColorFondoFalso = SystemColors.Control
        HhBooleanLabel2.ColorTextoVerdadero = SystemColors.HighlightText
        HhBooleanLabel2.ColorFondoVerdadero = SystemColors.Highlight
        HhBooleanLabel2.DireccionLectura = "MX0100"
        HhBooleanLabel2.AutoSize = True
        HhBooleanLabel2.BorderStyle = BorderStyle.Fixed3D
        HhBooleanLabel2.AutoActualizar = True

        HhCharacterDisplay3.Link = mMasterk
        HhCharacterDisplay3.DireccionLectura = "DW0000"
        HhCharacterDisplay3.LongitudTexto = 6
        HhCharacterDisplay3.AutoActualizar = False


        'dejar de utilizar mx1000
        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX1000"
        HhMomentaryButton1.DireccionLectura = "MX07"
        HhMomentaryButton1.Texto = "Manual"
        HhMomentaryButton1.AutoActualizar = True


        'dejar de utilizar mx1000
        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX1000"
        HhMomentaryButton2.DireccionLectura = "MX0100"
        HhMomentaryButton2.Texto = "Automatico"
        HhMomentaryButton2.AutoActualizar = True

        Button5.Texto = "Mandos"
        Button6.Texto = "Historial"
        Button3.Texto = "Configuracion"
        Button7.Texto = "Pruebas"
        Button1.Texto = "Salir"

        Label1.BorderStyle = BorderStyle.Fixed3D


        StatusStrip1.Items.Add(New ToolStripControlHost(HhAnimacion1))

        StatusStrip1.Items.Add(New ToolStripControlHost(HhAnimacion2))


        StatusStrip1.Items.Add(New ToolStripControlHost(HhBooleanLabel1))
        StatusStrip1.Items(2).AutoSize = False
        StatusStrip1.Items(2).Width = 100

        StatusStrip1.Items.Add(New ToolStripControlHost(HhBooleanLabel2))
        StatusStrip1.Items(3).AutoSize = False
        StatusStrip1.Items(3).Width = 100
        Dim t As New ToolStripStatusLabel
        t.Spring = True

        StatusStrip1.Items.Add(t)


        StatusStrip1.Items.Add(New ToolStripControlHost(Label1))

        'HhCharacterEntry1.Link = mMasterk
        'HhCharacterEntry1.LongitudTexto = 10
        'HhCharacterEntry1.DireccionEscritura = "DW0251"
        'HhCharacterEntry1.DireccionLectura = "DW0251"
        'HhCharacterEntry1.AutoActualizar = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If MsgBox("Desea salir?", MsgBoxStyle.YesNo) <> MsgBoxResult.No Then
            Try
                mMasterk.Puerto = Nothing
            Catch ex As Exception

            End Try
            Try
                mMasterk = Nothing

            Catch ex As Exception

            End Try
            Try
                sPuerto.Close()
            Catch ex As Exception

            End Try
            If bPermitirSalir Then

            Else
                AdjustToken()

                Dim retval As Int32
                retval = ExitWindowsEx(1 + 4, Nothing)
                If (retval = 0) Then
                    System.Diagnostics.Process.Start("shutdown", "-s -t 10")
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using f As New FormConfigura
            f.ShowDialog()
        End Using
    End Sub

    Private Sub CambioPagina(ByVal s As Object, ByVal e As System.EventArgs) Handles wPagina.Cambio
        Select Case wPagina.Valor
            Case 1
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "La maquina tiene agua. Abrir la puerta de todas formas?"
                    h.Imagen = My.Resources.stepa
                    h.TextoOk = "Abrir"
                    h.ImagenOk = My.Resources.step13
                    h.DireccionOk = "MX0048"
                    h.TextoCancel = "Desague"
                    h.ImagenCancel = My.Resources.step9
                    h.DireccionCancel = "MX004A"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 2
                Using fFormRotDesc As New FormRotacionDescarga
                    fFormRotDesc.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 3
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "La maquina no esta en horizontal. Poner en horizontal?"
                    h.Imagen = My.Resources.level
                    h.TextoOk = "Horizontal"
                    h.DireccionOk = "MX0035"
                    h.ImagenOk = My.Resources.level
                    h.TextoCancel = "Continuar"
                    h.DireccionCancel = "MX0102"
                    h.ImagenCancel = My.Resources.control_play_blue
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 4
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Proceder con descarga?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.rock
                    h.TextoOk = "Abrir"
                    h.ImagenOk = My.Resources.step13
                    h.DireccionOk = "MX002D"
                    h.TextoCancel = "Horizontal"
                    h.ImagenCancel = My.Resources.level
                    h.DireccionCancel = "MX0032"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 5
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "La puerta esta abierta. Cerrar la puerta?"
                    h.Imagen = My.Resources._error
                    h.TextoOk = "Cerrar"
                    h.ImagenOk = My.Resources.step15
                    h.DireccionOk = "MX0003"
                    h.TextoCancel = "Continuar"
                    h.ImagenCancel = My.Resources.control_play_blue
                    h.DireccionCancel = "MX0103"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 6
                'Eliminado animacion nueva receta
                wPagina.Valor = 0
            Case 7
                'Eliminado animacion enviar receta
                wPagina.Valor = 0
            Case 8
                'Eliminado animacion editar receta
                wPagina.Valor = 0
            Case 9
                'Posiblemente se borre, paso "funcion"
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Proceder con funcion mandos?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Si"
                    h.TextoCancel = "No"
                    h.DireccionOk = "MX0248"
                    h.DireccionCancel = "MX0249"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 10
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "Proceder con paso aditivos?"
                    h.Imagen = My.Resources.step12
                    h.TextoOk = "Aditivos"
                    h.ImagenOk = My.Resources.step12
                    h.DireccionCancel = "MX0116"
                    h.TextoCancel = "Sigueinte"
                    h.ImagenCancel = My.Resources.control_end_blue
                    h.DireccionOk = "MX0115"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 11
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "La maquina no esta Inicializada. Presione el boton START."
                    h.Imagen = My.Resources.switch
                    h.TextoOk = "Aceptar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX0B"
                    h.TextoCancel = "Cancelar"
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionCancel = "MX0C"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 12
                wPagina.Valor = 0
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "Proceder con paso muestreo?"
                    h.Imagen = My.Resources.step10
                    h.TextoOk = "Muestreo"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX0125"
                    h.TextoCancel = "Siguiente"
                    h.ImagenCancel = My.Resources.control_fastforward_blue
                    h.DireccionCancel = "MX0129"
                    h.ShowDialog()
                End Using
            Case 13
                wPagina.Valor = 0
                Using h As New hhInputBox.hhInputBox
                    h.Titulo = "Mantenimiento muestreo"
                    h.Mensaje = "Ingrese tiempo de mantenimiento (minutos)"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Link = mMasterk
                    h.DireccionValor = "DW0584"
                    h.Unidades = "min"
                    h.ValorMinimo = 1
                    h.ValorMaximo = 60
                    h.DireccionOk = "MX0128"
                    h.DireccionCancel = "MX0129"
                    h.ShowDialog()
                End Using

            Case 14
                wPagina.Valor = 0
                Using h As New hhInputBox.hhInputBox
                    h.Titulo = "Despedrado"
                    h.Mensaje = "Ingrese tiempo de despedrado (minutos)"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Link = mMasterk
                    h.DireccionValor = "DW0584"
                    h.Unidades = "min"
                    h.ValorMinimo = 1
                    h.ValorMaximo = 60
                    h.DireccionOk = "MX88"
                    h.DireccionCancel = "MX89"
                    h.ShowDialog()
                End Using
            Case 15
                'Posiblemente se borre, paso "funcion"
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Cerrar puerta?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Si"
                    h.TextoCancel = "No"
                    h.DireccionOk = "MX024C"
                    h.DireccionCancel = "MX000C"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 16
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "Maximo tiempo activada la bomba hidraulica."
                    h.Imagen = My.Resources._error
                    h.TextoOk = "Acptar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX002B"
                    h.TextoCancel = "Cancelar"
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 17
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Maximo tiempo activada cerrar puerta."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources._error
                    h.TextoOk = "Aceptar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX009F"
                    h.TextoCancel = "Cancelar"
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 18
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Maximo tiempo activada abrir puerta."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources._error
                    h.TextoOk = "Aceptar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX008F"
                    h.TextoCancel = "Cancelar"
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 19

                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Termico de motor disparado."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.lightning
                    h.TextoOk = "Aceptar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX002B"
                    h.TextoCancel = "Cancelar"
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 20
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Alarma de variador."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.exclamation
                    h.TextoOk = "Aceptar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX002B"
                    h.TextoCancel = "Cancelar"
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 21
                wPagina.Valor = 0
                Using hhProgressBox As New hhProgressBox.hhProgressBox
                    hhProgressBox.Link = mMasterk
                    hhProgressBox.ValorMaximo = mMasterk.ObtenerEntero("DW0586")
                    hhProgressBox.ValorMinimo = 0
                    hhProgressBox.DireccionLectura = "TW0011"
                    hhProgressBox.DireccionOk = "MX0047"
                    hhProgressBox.DireccionCancel = "MX002B"
                    hhProgressBox.AutoActualizar = True
                    hhProgressBox.ShowDialog()
                End Using
            Case 22
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Revisar si se ha realizado la succion de quimicos"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.step12
                    h.TextoOk = "Esperar"
                    h.DireccionOk = "MX9C"
                    h.ImagenOk = My.Resources.step12
                    h.TextoCancel = "Siguiente"
                    h.DireccionCancel = "MX9D"
                    h.ImagenCancel = My.Resources.control_end_blue
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 23
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "La maquina no esta Inicializada. Presione el boton START."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.switch
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX2B"
                    h.DireccionCancel = "MX0C"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0

            Case 24
                wPagina.Valor = 0
                Using hhProgressBox As New hhProgressBox.hhProgressBox
                    hhProgressBox.Link = mMasterk
                    hhProgressBox.ValorMaximo = mMasterk.ObtenerEntero("DW0710")
                    hhProgressBox.ValorMinimo = 0
                    hhProgressBox.DireccionLectura = "DW0508"
                    hhProgressBox.DireccionOk = "MX95"
                    hhProgressBox.DireccionCancel = "MX96"
                    hhProgressBox.AutoActualizar = True
                    hhProgressBox.ShowDialog()
                End Using
            Case 25
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Revisar si se ha ralizado el Desague."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.step9
                    h.TextoOk = "Esperar"
                    h.ImagenOk = My.Resources.tick
                    h.DireccionOk = "MX98"
                    h.TextoCancel = "Siguiente"
                    h.DireccionCancel = "MX99"
                    h.ImagenCancel = My.Resources.control_end_blue
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 26
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "No se detecta velocidad cero"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.step4
                    h.TextoOk = "Esperar"
                    h.DireccionOk = "MX9B"
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = "Continuar"
                    h.DireccionCancel = "MX50"
                    h.ImagenCancel = My.Resources.control_play_blue
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0

        End Select
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Text = Now.ToString("yyyy-MM-dd HH:mm:ss")
        If Len(HhCharacterDisplay1.Text) = 0 Then
            HhCharacterDisplay1.Text = sTerminal
        End If
        If Len(HhCharacterDisplay2.Text) = 0 Then
            HhCharacterDisplay2.Text = sVersion
        End If
        If Len(HhCharacterDisplay3.Text) = 0 Then
            HhCharacterDisplay3.Actualizar()
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Using f As New FormTest
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Using f As New FormMandos
            f.ShowDialog()
        End Using
    End Sub

    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click
        Using f As New FormManual

            If mMasterk.ObtenerBoolean("MX0100") Then
                Using m As New hhMsgBox.hhMsgBox
                    m.Mensaje = "La maquina esta trabajando. Parar la maquina?"
                    m.Link = mMasterk
                    m.Tamanio = 50
                    m.Imagen = My.Resources.traffic_lights_green
                    m.TextoOk = ""
                    m.ImagenOk = My.Resources.control_stop_blue
                    m.TextoCancel = ""
                    m.ImagenCancel = My.Resources.cross
                    m.DireccionOk = "MX0C"
                    m.DireccionCancel = "MX0B"
                    m.ShowDialog()
                    If m.Resultado = Windows.Forms.DialogResult.OK Then
                        f.ShowDialog()
                    End If
                End Using
            Else
                f.ShowDialog()
            End If


        End Using
    End Sub

    Private Sub HhMomentaryButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton2.Click

        Using f As New FormAutomatico
            f.ShowDialog()
        End Using
    End Sub


End Class
