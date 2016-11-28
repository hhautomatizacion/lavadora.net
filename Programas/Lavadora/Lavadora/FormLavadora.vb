Public Class FormLavadora

    Dim WithEvents wPagina As hhWordRegister.hhWordRegister

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cParametros = New Collection
        wPagina = New hhWordRegister.hhWordRegister
        CargarOpciones()
        CambiarLetra(Me)
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
        HhCharacterDisplay3.Longitud = 6
        HhCharacterDisplay3.AutoActualizar = False


        'dejar de utilizar mx1000
        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX1000"
        HhMomentaryButton1.DireccionLectura = "MX07"
        HhMomentaryButton1.AutoActualizar = True


        'dejar de utilizar mx1000
        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX1000"
        HhMomentaryButton2.DireccionLectura = "MX0100"
        HhMomentaryButton2.AutoActualizar = True

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
            If bDepuracion Then

            Else
                System.Diagnostics.Process.Start("shutdown", "-s -t 10")
            End If
            Me.Close()

        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using f As New FormConfigura
            CambiarLetra(f)
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.step13
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.step9
                    h.DireccionOk = "MX0048"
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
                    h.TextoOk = ""
                    h.DireccionOk = "MX0035"
                    h.ImagenOk = My.Resources.level
                    h.TextoCancel = ""
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.step13
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.level
                    h.DireccionOk = "MX002D"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.step15
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.control_play_blue
                    h.DireccionOk = "MX0003"
                    h.DireccionCancel = "MX0103"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 6
                Using hhProgressBox As New hhProgressBox.hhProgressBox
                    hhProgressBox.Link = mMasterk
                    hhProgressBox.ValorMaximo = 990
                    hhProgressBox.ValorMinimo = 0
                    hhProgressBox.DireccionLectura = "DW0222"
                    hhProgressBox.DireccionOk = "MX008B"
                    hhProgressBox.DireccionCancel = "MX008B"
                    hhProgressBox.AutoActualizar = True
                    hhProgressBox.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 7
                Using hhProgressBox As New hhProgressBox.hhProgressBox
                    hhProgressBox.Link = mMasterk
                    hhProgressBox.ValorMaximo = 990
                    hhProgressBox.ValorMinimo = 0
                    hhProgressBox.DireccionLectura = "DW0222"
                    hhProgressBox.DireccionOk = "MX006F"
                    hhProgressBox.DireccionCancel = "MX006F"
                    hhProgressBox.AutoActualizar = True
                    hhProgressBox.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 8
                Using hhProgressBox As New hhProgressBox.hhProgressBox
                    hhProgressBox.Link = mMasterk
                    hhProgressBox.ValorMaximo = 990
                    hhProgressBox.ValorMinimo = 0
                    hhProgressBox.DireccionLectura = "DW0222"
                    hhProgressBox.DireccionOk = "MX0124"
                    hhProgressBox.DireccionCancel = "MX0124"
                    hhProgressBox.AutoActualizar = True
                    hhProgressBox.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 9
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.step12
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.control_end_blue
                    h.DireccionOk = "MX0115"
                    h.DireccionCancel = "MX0116"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 11
                Using h As New hhMsgBox.hhMsgBox
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Mensaje = "La maquina no esta Inicializada. Presione el boton START."
                    h.Imagen = My.Resources.switch
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX0B"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.control_fastforward_blue
                    h.DireccionOk = "MX0125"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX002B"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX002B"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX002B"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX002B"
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
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX002B"
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
                    h.Mensaje = "Maximo tiempo activada la bomba de quimicos."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.Imagen = My.Resources.filter
                    h.TextoOk = ""
                    h.ImagenOk = My.Resources.tick
                    h.TextoCancel = ""
                    h.ImagenCancel = My.Resources.cross
                    h.DireccionOk = "MX002B"
                    h.DireccionCancel = "MX002B"
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
            CambiarLetra(f)
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
            CambiarLetra(f)
            If mMasterk.ObtenerBoolean("MX0100") Then
                HhMsgBox1.Mensaje = "La maquina esta trabajando. Parar la maquina?"
                HhMsgBox1.Link = mMasterk
                HhMsgBox1.Tamanio = 50
                HhMsgBox1.Imagen = My.Resources.traffic_lights_green
                HhMsgBox1.TextoOk = ""
                HhMsgBox1.ImagenOk = My.Resources.control_stop_blue
                HhMsgBox1.TextoCancel = ""
                HhMsgBox1.ImagenCancel = My.Resources.cross
                HhMsgBox1.DireccionOk = "MX0C"
                HhMsgBox1.DireccionCancel = "MX0B"
                HhMsgBox1.ShowDialog()
                If HhMsgBox1.Resultado = Windows.Forms.DialogResult.OK Then
                    f.ShowDialog()
                End If
            Else
                f.ShowDialog()
            End If


        End Using
    End Sub

    Private Sub HhMomentaryButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton2.Click

        Using f As New FormAutomatico
            CambiarLetra(f)
            f.ShowDialog()
        End Using
    End Sub
End Class
