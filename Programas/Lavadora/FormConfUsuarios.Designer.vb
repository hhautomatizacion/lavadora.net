<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfUsuarios))
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry()
        Me.HhNumericEntry2 = New hhNumericEntry.hhNumericEntry()
        Me.HhNumericEntry3 = New hhNumericEntry.hhNumericEntry()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.HhComboEntry1 = New hhComboEntry.hhComboEntry()
        Me.HhComboEntry2 = New hhComboEntry.hhComboEntry()
        Me.HhComboEntry3 = New hhComboEntry.hhComboEntry()
        Me.HhComboEntry4 = New hhComboEntry.hhComboEntry()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'HhNumericEntry1
        '
        Me.HhNumericEntry1.AutoActualizar = False
        Me.HhNumericEntry1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericEntry1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry1.Decimales = 0
        Me.HhNumericEntry1.DireccionEscritura = Nothing
        Me.HhNumericEntry1.DireccionLectura = Nothing
        Me.HhNumericEntry1.Etiqueta = "Password1"
        Me.HhNumericEntry1.Factor = 1.0!
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(189, 3)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(180, 49)
        Me.HhNumericEntry1.TabIndex = 0
        Me.HhNumericEntry1.Text = "0"
        Me.HhNumericEntry1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry1.Tooltip = Nothing
        Me.HhNumericEntry1.Unidades = Nothing
        Me.HhNumericEntry1.Valor = 0
        Me.HhNumericEntry1.ValorMaximo = 999999
        Me.HhNumericEntry1.ValorMinimo = 0
        '
        'HhNumericEntry2
        '
        Me.HhNumericEntry2.AutoActualizar = False
        Me.HhNumericEntry2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericEntry2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry2.Decimales = 0
        Me.HhNumericEntry2.DireccionEscritura = Nothing
        Me.HhNumericEntry2.DireccionLectura = Nothing
        Me.HhNumericEntry2.Etiqueta = "Password2"
        Me.HhNumericEntry2.Factor = 1.0!
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry2.Link = Nothing
        Me.HhNumericEntry2.Location = New System.Drawing.Point(189, 72)
        Me.HhNumericEntry2.Name = "HhNumericEntry2"
        Me.HhNumericEntry2.Size = New System.Drawing.Size(180, 49)
        Me.HhNumericEntry2.TabIndex = 2
        Me.HhNumericEntry2.Text = "0"
        Me.HhNumericEntry2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry2.Tooltip = Nothing
        Me.HhNumericEntry2.Unidades = Nothing
        Me.HhNumericEntry2.Valor = 0
        Me.HhNumericEntry2.ValorMaximo = 999999
        Me.HhNumericEntry2.ValorMinimo = 0
        '
        'HhNumericEntry3
        '
        Me.HhNumericEntry3.AutoActualizar = False
        Me.HhNumericEntry3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericEntry3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericEntry3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericEntry3.Decimales = 0
        Me.HhNumericEntry3.DireccionEscritura = Nothing
        Me.HhNumericEntry3.DireccionLectura = Nothing
        Me.HhNumericEntry3.Etiqueta = "Password3"
        Me.HhNumericEntry3.Factor = 1.0!
        Me.HhNumericEntry3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry3.Link = Nothing
        Me.HhNumericEntry3.Location = New System.Drawing.Point(189, 141)
        Me.HhNumericEntry3.Name = "HhNumericEntry3"
        Me.HhNumericEntry3.Size = New System.Drawing.Size(180, 49)
        Me.HhNumericEntry3.TabIndex = 4
        Me.HhNumericEntry3.Text = "0"
        Me.HhNumericEntry3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry3.Tooltip = Nothing
        Me.HhNumericEntry3.Unidades = Nothing
        Me.HhNumericEntry3.Valor = 0
        Me.HhNumericEntry3.ValorMaximo = 999999
        Me.HhNumericEntry3.ValorMinimo = 0
        '
        'Button1
        '
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(921, 584)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 111)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HhNumericEntry1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HhNumericEntry2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HhNumericEntry3, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(315, 51)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(372, 209)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.HhComboEntry1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.HhComboEntry2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.HhComboEntry3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.HhComboEntry4, 1, 3)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(315, 363)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(375, 209)
        Me.TableLayoutPanel2.TabIndex = 14
        '
        'HhComboEntry1
        '
        Me.HhComboEntry1.AutoActualizar = False
        Me.HhComboEntry1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhComboEntry1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhComboEntry1.DireccionEscritura = Nothing
        Me.HhComboEntry1.DireccionLectura = Nothing
        Me.HhComboEntry1.Etiqueta = "Saltar paso"
        Me.HhComboEntry1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhComboEntry1.FormattingEnabled = True
        Me.HhComboEntry1.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.HhComboEntry1.Link = Nothing
        Me.HhComboEntry1.Location = New System.Drawing.Point(191, 4)
        Me.HhComboEntry1.LongitudTexto = 1
        Me.HhComboEntry1.Margin = New System.Windows.Forms.Padding(4)
        Me.HhComboEntry1.Name = "HhComboEntry1"
        Me.HhComboEntry1.Size = New System.Drawing.Size(180, 36)
        Me.HhComboEntry1.TabIndex = 16
        Me.HhComboEntry1.Texto = Nothing
        '
        'HhComboEntry2
        '
        Me.HhComboEntry2.AutoActualizar = False
        Me.HhComboEntry2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhComboEntry2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhComboEntry2.DireccionEscritura = Nothing
        Me.HhComboEntry2.DireccionLectura = Nothing
        Me.HhComboEntry2.Etiqueta = "Editar receta"
        Me.HhComboEntry2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhComboEntry2.FormattingEnabled = True
        Me.HhComboEntry2.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.HhComboEntry2.Link = Nothing
        Me.HhComboEntry2.Location = New System.Drawing.Point(191, 56)
        Me.HhComboEntry2.LongitudTexto = 1
        Me.HhComboEntry2.Margin = New System.Windows.Forms.Padding(4)
        Me.HhComboEntry2.Name = "HhComboEntry2"
        Me.HhComboEntry2.Size = New System.Drawing.Size(180, 36)
        Me.HhComboEntry2.TabIndex = 17
        Me.HhComboEntry2.Texto = Nothing
        '
        'HhComboEntry3
        '
        Me.HhComboEntry3.AutoActualizar = False
        Me.HhComboEntry3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhComboEntry3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhComboEntry3.DireccionEscritura = Nothing
        Me.HhComboEntry3.DireccionLectura = Nothing
        Me.HhComboEntry3.Etiqueta = "Configurar"
        Me.HhComboEntry3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhComboEntry3.FormattingEnabled = True
        Me.HhComboEntry3.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.HhComboEntry3.Link = Nothing
        Me.HhComboEntry3.Location = New System.Drawing.Point(191, 108)
        Me.HhComboEntry3.LongitudTexto = 1
        Me.HhComboEntry3.Margin = New System.Windows.Forms.Padding(4)
        Me.HhComboEntry3.Name = "HhComboEntry3"
        Me.HhComboEntry3.Size = New System.Drawing.Size(180, 36)
        Me.HhComboEntry3.TabIndex = 18
        Me.HhComboEntry3.Texto = Nothing
        '
        'HhComboEntry4
        '
        Me.HhComboEntry4.AutoActualizar = False
        Me.HhComboEntry4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhComboEntry4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhComboEntry4.DireccionEscritura = Nothing
        Me.HhComboEntry4.DireccionLectura = Nothing
        Me.HhComboEntry4.Etiqueta = "Pruebas"
        Me.HhComboEntry4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhComboEntry4.FormattingEnabled = True
        Me.HhComboEntry4.Items.AddRange(New Object() {"0", "1", "2", "3"})
        Me.HhComboEntry4.Link = Nothing
        Me.HhComboEntry4.Location = New System.Drawing.Point(191, 160)
        Me.HhComboEntry4.LongitudTexto = 1
        Me.HhComboEntry4.Margin = New System.Windows.Forms.Padding(4)
        Me.HhComboEntry4.Name = "HhComboEntry4"
        Me.HhComboEntry4.Size = New System.Drawing.Size(180, 36)
        Me.HhComboEntry4.TabIndex = 19
        Me.HhComboEntry4.Texto = Nothing
        '
        'FormConfUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 708)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FromConfUsuarios"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry2 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry3 As hhNumericEntry.hhNumericEntry
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents HhComboEntry4 As hhComboEntry.hhComboEntry
    Friend WithEvents HhComboEntry3 As hhComboEntry.hhComboEntry
    Friend WithEvents HhComboEntry2 As hhComboEntry.hhComboEntry
    Friend WithEvents HhComboEntry1 As hhComboEntry.hhComboEntry
End Class
