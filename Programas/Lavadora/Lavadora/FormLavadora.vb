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



        'mMasterk.EstablecerEntero("DW0029", 0)    ' dir comunicacion
        'mMasterk.EstablecerEntero("DW0028", 1)    ' dir comunicacion

        'mMasterk.EstablecerEntero("DW0024", 100)    'acel rotacion


        'mMasterk.EstablecerCadena("DW0110", "CENT")
        'mMasterk.EstablecerCadena("DW0120", "ROTA")
        'mMasterk.EstablecerCadena("DW0130", "LLEN")
        'mMasterk.EstablecerCadena("DW0140", "DESC")
        'mMasterk.EstablecerCadena("DW0150", "ADIT")
        'mMasterk.EstablecerCadena("DW0160", "MUES")
        'mMasterk.EstablecerCadena("DW0170", "FIN ")
        'mMasterk.EstablecerCadena("DW0180", "TEMP")
        'mMasterk.EstablecerCadena("DW0190", "MANT")


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
                System.Diagnostics.Process.Start("shutdown", "-s -t 10")
            End If
            Me.Close()

        End If


    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
 
        Using f As New FormManual
            CambiarLetra(f)
            f.ShowDialog()
end using
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using f As New FormConfigura
            CambiarLetra(f)
            f.ShowDialog()
        End Using
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Using f As New FormAutomatico
            CambiarLetra(f)
            f.ShowDialog()
        End Using
    End Sub


    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using f As New FormMandos
            f.ShowDialog()
        End Using
    End Sub

    Private Sub CambioPagina(ByVal s As Object, ByVal e As System.EventArgs) Handles wPagina.Cambio
       
        Select Case wPagina.Valor
            Case 1
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "La maquina tiene agua. Abrir la puerta de todas formas?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Abrir"
                    h.TextoCancel = "Tirar"
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
                    h.Mensaje = "La maquina no esta en horizontal. Poner en horizontal?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Horiz"
                    h.TextoCancel = "Continua"
                    h.DireccionOk = "MX0035"
                    h.DireccionCancel = "MX0102"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 4
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Proceder con descarga?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Descarga"
                    h.TextoCancel = "Horizontal"
                    h.DireccionOk = "MX002D"
                    h.DireccionCancel = "MX0032"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 5
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "La puerta esta abierta. Cerrar la puerta?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Cerrar"
                    h.TextoCancel = "Continua"
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
                    h.Mensaje = "Proceder con paso aditivos?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Si"
                    h.TextoCancel = "No"
                    h.DireccionOk = "MX0115"
                    h.DireccionCancel = "MX0116"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 11
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "La maquina no esta Inicializada. Presione el boton START."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Salir"
                    h.DireccionOk = "MX0B"
                    h.DireccionCancel = "MX0C"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 12
                wPagina.Valor = 0
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Proceder con paso muestreo?"
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Si"
                    h.TextoCancel = "No"
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
                    h.Mensaje = "Maximo tiempo activada la bomba hidraulica."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Cancelar"
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
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Cancelar"
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
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Cancelar"
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
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Cancelar"
                    h.DireccionOk = "MX002B"
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 20
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "Alarma de inversor."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Cancelar"
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
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Cancelar"
                    h.DireccionOk = "MX004D"
                    h.DireccionCancel = "MX002B"
                    h.ShowDialog()
                End Using
                wPagina.Valor = 0
            Case 23
                Using h As New hhMsgBox.hhMsgBox
                    h.Mensaje = "La maquina no esta Inicializada. Presione el boton START."
                    h.Link = mMasterk
                    h.Tamanio = 50
                    h.TextoOk = "Ok"
                    h.TextoCancel = "Salir"
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

 
    
End Class
