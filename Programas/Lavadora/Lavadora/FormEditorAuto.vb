Public Class FormEditorAuto
   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Using fForm As New FormLlenadoAuto
            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionLectura = "MX010"
            fForm.HhToggleButton1.DireccionEscritura = "MX010"
            fForm.HhToggleButton1.Etiqueta = "Agua fria"
            fForm.HhToggleButton1.AutoActualizar = True

            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionLectura = "MX011"
            fForm.HhToggleButton2.DireccionEscritura = "MX011"
            fForm.HhToggleButton2.Etiqueta = "Agua caliente"
            fForm.HhToggleButton2.AutoActualizar = True

            fForm.HhToggleButton3.Link = mMasterk
            fForm.HhToggleButton3.DireccionLectura = "MX012"
            fForm.HhToggleButton3.DireccionEscritura = "MX012"
            fForm.HhToggleButton3.Etiqueta = "Rotacion"
            fForm.HhToggleButton3.AutoActualizar = True

            fForm.HhToggleButton4.Link = mMasterk
            fForm.HhToggleButton4.DireccionLectura = "MX13"
            fForm.HhToggleButton4.DireccionEscritura = "MX13"
            fForm.HhToggleButton4.Etiqueta = "Temperatura"
            fForm.HhToggleButton4.AutoActualizar = True

            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0135"
            fForm.HhNumericEntry1.DireccionLectura = "DW0135"
            fForm.HhNumericEntry1.Unidades = "lts"
            fForm.HhNumericEntry1.Etiqueta = "Cantidad agua"
            fForm.HhNumericEntry1.Tooltip = "Cantidad agua|(Litros)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 2000
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.DireccionEscritura = "DW0134"
            fForm.HhNumericEntry2.DireccionLectura = "DW0134"
            fForm.HhNumericEntry2.Unidades = "�C"
            fForm.HhNumericEntry2.Etiqueta = "Temperatura"
            fForm.HhNumericEntry2.Tooltip = "Temperatura|(�C)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX20"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub

    Private Sub FormEditorAuto_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
    End Sub

    Private Sub FormEditorAuto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        HhGridDisplay1.Link = mMasterk
        HhGridDisplay1.DireccionLectura = "DW3000"
        HhGridDisplay1.DireccionPaso = "DW0050"
        HhGridDisplay1.LongitudPaso = 10
        HhGridDisplay1.LongitudTexto = 4
        HhGridDisplay1.MostrarSeleccion = True
        HhGridDisplay1.AutoActualizar = True

        HhNumericEntry1.Link = mMasterk
        HhNumericEntry1.DireccionLectura = "DW0050"
        HhNumericEntry1.DireccionEscritura = "DW0050"
        HhNumericEntry1.ValorMaximo = 100
        HhNumericEntry1.ValorMinimo = 1
        HhNumericEntry1.Etiqueta = "Paso #"
        HhNumericEntry1.AutoActualizar = True

        HhMomentaryButton1.Link = mMasterk
        HhMomentaryButton1.DireccionEscritura = "MX0027"
        HhMomentaryButton1.Texto = "Fin"

        HhMomentaryButton2.Link = mMasterk
        HhMomentaryButton2.DireccionEscritura = "MX0031"
        HhMomentaryButton2.Texto = "Insertar"

        HhMomentaryButton3.Link = mMasterk
        HhMomentaryButton3.DireccionEscritura = "MX0029"
        HhMomentaryButton3.Texto = "Eliminar"

        HhMomentaryButton4.Link = mMasterk
        HhMomentaryButton4.DireccionEscritura = "MX0076"
        HhMomentaryButton4.Texto = "Envia"

        HhMomentaryButton5.Link = mMasterk
        HhMomentaryButton5.DireccionEscritura = "MX0028"
        HhMomentaryButton5.Texto = "Nueva"

        Button2.Link = mMasterk
        Button2.DireccionEscritura = "MX0210"
        Button2.Texto = "Llenado"

        Button3.Link = mMasterk
        Button3.DireccionEscritura = "MX0213"
        Button3.Texto = "Desague"

        Button5.Link = mMasterk
        Button5.DireccionEscritura = "MX0211"
        Button5.Texto = "Rotacion"

        Button6.Link = mMasterk
        Button6.DireccionEscritura = "MX0212"
        Button6.Texto = "Mantenimiento"

        Button7.Link = mMasterk
        Button7.DireccionEscritura = "MX0214"
        Button7.Texto = "Temperatura"

        Button8.Link = mMasterk
        Button8.DireccionEscritura = "MX0218"
        Button8.Texto = "Centrifuga"

        Button9.Link = mMasterk
        Button9.DireccionEscritura = "MX0217"
        Button9.Texto = "Aditivos"

        Button10.Link = mMasterk
        Button10.DireccionEscritura = "MX0215"
        Button10.Texto = "Muestreo"

        Button4.Texto = "Guardar"

        Button1.Texto = "Salir"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using fForm As New FormDesagueAuto
            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionEscritura = "MX15"
            fForm.HhToggleButton1.DireccionLectura = "MX15"
            fForm.HhToggleButton1.Etiqueta = "Desague 1"
            fForm.HhToggleButton1.AutoActualizar = True

            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionEscritura = "MX17"
            fForm.HhToggleButton2.DireccionLectura = "MX17"
            fForm.HhToggleButton2.Etiqueta = "Rotacion"
            fForm.HhToggleButton2.AutoActualizar = True

            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0147"
            fForm.HhNumericEntry1.DireccionLectura = "DW0147"
            fForm.HhNumericEntry1.Unidades = "seg"
            fForm.HhNumericEntry1.Etiqueta = "Tiempo"
            fForm.HhNumericEntry1.Tooltip = "Tiempo|(Segundos)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 300
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX23"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub
    Private Sub HhMomentaryButton2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HhMomentaryButton2.MouseDown
        'HhGridDisplay1.AutoActualizar = False
    End Sub

    Private Sub HhMomentaryButton2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HhMomentaryButton2.MouseUp
        'Do
        'Application.DoEvents()
        'Loop Until mMasterk.ObtenerBoolean("MX0030") = False
        'HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub
    Private Sub HhMomentaryButton3_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HhMomentaryButton3.MouseDown
        'HhGridDisplay1.AutoActualizar = False
    End Sub

    Private Sub HhMomentaryButton3_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles HhMomentaryButton3.MouseUp
        'Do
        'Application.DoEvents()
        'Loop Until mMasterk.ObtenerBoolean("MX0040") = False
        'HhGridDisplay1.Inicializar()
        'HhGridDisplay1.AutoActualizar = True
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
            Debug.Print(HhDialogoArchivos1.ToString)
            If HhDialogoArchivos1.Resultado = Windows.Forms.DialogResult.Cancel Then
                Debug.Print("Cancelar guardar")
                bSalir = True
            Else
                Debug.Print("Comprobar nombre vacio")
                If Len(HhDialogoArchivos1.NombreCompleto) >= Len(HhDialogoArchivos1.Extension) Then
                    Try
                        Debug.Print("Revisar si existe archivo")
                        bArchivoExiste = False
                        If My.Computer.FileSystem.FileExists(HhDialogoArchivos1.NombreCompleto) Then
                            bArchivoExiste = True
                        End If

                    Catch ex As Exception
                        Exit Sub
                    End Try
                    If bArchivoExiste Then
                        Debug.Print("Preguntar si sobreescribir")
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
                            Debug.Print("Guardar archivo")
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


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
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
            fForm.HhMomentaryButton1.DireccionEscritura = "MX21"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True


    End Sub

    Private Sub HhMomentaryButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton1.Click
        'boton fin

        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Using fForm As New FormMantenimientoManual
            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.Etiqueta = "Temperatura constante"
            fForm.HhToggleButton1.DireccionLectura = "MX14"
            fForm.HhToggleButton1.DireccionEscritura = "MX14"
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
            fForm.HhNumericEntry2.Unidades = "�C"
            fForm.HhNumericEntry2.Etiqueta = "Temperatura"
            fForm.HhNumericEntry2.Tooltip = "Temperatura|(�C)"
            fForm.HhNumericEntry2.DireccionEscritura = "DW0194"
            fForm.HhNumericEntry2.DireccionLectura = "DW0194"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX22"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Using fForm As New FormCalefaccionManual
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0184"
            fForm.HhNumericEntry1.DireccionLectura = "DW0184"
            fForm.HhNumericEntry1.Unidades = "�C"
            fForm.HhNumericEntry1.Etiqueta = "Temperatura final"
            fForm.HhNumericEntry1.Tooltip = "Temperatura final|(�C)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 100
            fForm.HhNumericEntry1.AutoActualizar = True

            fForm.HhToggleButton1.Link = mMasterk
            fForm.HhToggleButton1.DireccionEscritura = "MX16"
            fForm.HhToggleButton1.DireccionLectura = "MX16"
            fForm.HhToggleButton1.Etiqueta = "Con rotacion"
            fForm.HhToggleButton1.AutoActualizar = True

            fForm.HhNumericEntry2.Link = mMasterk
            fForm.HhNumericEntry2.DireccionEscritura = "DW0183"
            fForm.HhNumericEntry2.DireccionLectura = "DW0183"
            fForm.HhNumericEntry2.Unidades = "�C/min"
            fForm.HhNumericEntry2.Etiqueta = "Gradiente"
            fForm.HhNumericEntry2.Tooltip = "Gradiente de temp.|(�C/min)"
            fForm.HhNumericEntry2.ValorMinimo = 0
            fForm.HhNumericEntry2.ValorMaximo = 100
            fForm.HhNumericEntry2.AutoActualizar = True

            fForm.HhToggleButton2.Link = mMasterk
            fForm.HhToggleButton2.DireccionEscritura = "MX19"
            fForm.HhToggleButton2.DireccionLectura = "MX19"
            fForm.HhToggleButton2.Etiqueta = "Con gradiente"
            fForm.HhToggleButton2.AutoActualizar = True

            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX25"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True


    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Using fForm As New FormCentrifugaAuto
            fForm.HhNumericEntry1.Link = mMasterk
            fForm.HhNumericEntry1.DireccionEscritura = "DW0116"
            fForm.HhNumericEntry1.DireccionLectura = "DW0116"
            fForm.HhNumericEntry1.Unidades = "rpm"
            fForm.HhNumericEntry1.Etiqueta = "Velocidad"
            fForm.HhNumericEntry1.Tooltip = "Velocidad|(rpm)"
            fForm.HhNumericEntry1.ValorMinimo = 0
            fForm.HhNumericEntry1.ValorMaximo = 3000
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
            fForm.HhMomentaryButton1.DireccionEscritura = "MX74"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub

    Private Sub HhGridDisplay1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HhGridDisplay1.CellClick
        Dim iValor As Integer
        iValor = e.RowIndex
        If iValor >= 0 Then
            iValor = iValor + 1
            mMasterk.EstablecerEntero("DW50", iValor)
        End If
    End Sub

    Private Sub HhGridDisplay1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles HhGridDisplay1.CellContentClick

    End Sub

    Private Sub HhGridDisplay1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles HhGridDisplay1.SelectionChanged

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
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
            fForm.HhMomentaryButton1.DireccionEscritura = "MX24"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True


    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Using fForm As New FormMuestreoAuto
            fForm.HhMomentaryButton1.Link = mMasterk
            fForm.HhMomentaryButton1.DireccionEscritura = "MX26"
            fForm.HhMomentaryButton1.Texto = "Aceptar"

            fForm.Button1.Texto = "Cancelar"

            fForm.ShowDialog()
        End Using
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub

    Private Sub HhMomentaryButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HhMomentaryButton4.Click
        DialogResult = DialogResult.OK
    End Sub

    Private Sub HhMomentaryButton5_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton5.Click
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub

    Private Sub HhMomentaryButton2_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton2.Click
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub

    Private Sub HhMomentaryButton3_Click(sender As Object, e As EventArgs) Handles HhMomentaryButton3.Click
        HhGridDisplay1.AutoActualizar = False
        HhGridDisplay1.Inicializar()
        HhGridDisplay1.AutoActualizar = True
    End Sub
End Class