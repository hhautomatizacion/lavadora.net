<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAutomatico
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Button1 = New System.Windows.Forms.Button
        Me.HhCharacterDisplay1 = New hhCharacterDisplay.hhCharacterDisplay
        Me.HhGridDisplay1 = New hhGridDisplay.hhGridDisplay
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.HhNumericDisplay2 = New hhNumericDisplay.hhNumericDisplay
        Me.HhNumericDisplay1 = New hhNumericDisplay.hhNumericDisplay
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.HhNumericDisplay4 = New hhNumericDisplay.hhNumericDisplay
        Me.HhNumericDisplay3 = New hhNumericDisplay.hhNumericDisplay
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.HhNumericDisplay6 = New hhNumericDisplay.hhNumericDisplay
        Me.HhNumericDisplay5 = New hhNumericDisplay.hhNumericDisplay
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.HhTimeCounterDisplay4 = New hhTimeCounterDisplay.hhTimeCounterDisplay
        Me.HhTimeCounterDisplay3 = New hhTimeCounterDisplay.hhTimeCounterDisplay
        Me.HhTimeCounterDisplay2 = New hhTimeCounterDisplay.hhTimeCounterDisplay
        Me.HhTimeCounterDisplay1 = New hhTimeCounterDisplay.hhTimeCounterDisplay
        Me.Button5 = New System.Windows.Forms.Button
        Me.HhMsgBox1 = New hhMsgBox.hhMsgBox
        Me.HhDialogoArchivos1 = New DialogoArchivos.hhDialogoArchivos
        Me.HhMomentaryButton4 = New hhMomentaryButton.hhMomentaryButton
        Me.HhMomentaryButton3 = New hhMomentaryButton.hhMomentaryButton
        Me.HhMomentaryButton2 = New hhMomentaryButton.hhMomentaryButton
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton
        CType(Me.HhGridDisplay1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salida"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhCharacterDisplay1
        '
        Me.HhCharacterDisplay1.AutoActualizar = False
        Me.HhCharacterDisplay1.DireccionLectura = Nothing
        Me.HhCharacterDisplay1.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhCharacterDisplay1.Link = Nothing
        Me.HhCharacterDisplay1.Location = New System.Drawing.Point(10, 5)
        Me.HhCharacterDisplay1.Longitud = 0
        Me.HhCharacterDisplay1.Name = "HhCharacterDisplay1"
        Me.HhCharacterDisplay1.Size = New System.Drawing.Size(310, 34)
        Me.HhCharacterDisplay1.TabIndex = 2
        Me.HhCharacterDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'HhGridDisplay1
        '
        Me.HhGridDisplay1.AllowUserToAddRows = False
        Me.HhGridDisplay1.AllowUserToDeleteRows = False
        Me.HhGridDisplay1.AllowUserToResizeRows = False
        Me.HhGridDisplay1.AutoActualizar = False
        Me.HhGridDisplay1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HhGridDisplay1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.HhGridDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhGridDisplay1.DireccionEscritura = Nothing
        Me.HhGridDisplay1.DireccionLectura = Nothing
        Me.HhGridDisplay1.DireccionPaso = Nothing
        Me.HhGridDisplay1.EscribirPaso = False
        Me.HhGridDisplay1.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhGridDisplay1.Link = Nothing
        Me.HhGridDisplay1.Location = New System.Drawing.Point(332, 5)
        Me.HhGridDisplay1.LongitudPaso = 0
        Me.HhGridDisplay1.LongitudTexto = 0
        Me.HhGridDisplay1.MostrarSeleccion = False
        Me.HhGridDisplay1.Name = "HhGridDisplay1"
        Me.HhGridDisplay1.PasoActual = 0
        Me.HhGridDisplay1.ReadOnly = True
        Me.HhGridDisplay1.Receta = Nothing
        Me.HhGridDisplay1.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhGridDisplay1.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.HhGridDisplay1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HhGridDisplay1.ShowCellToolTips = False
        Me.HhGridDisplay1.Size = New System.Drawing.Size(448, 360)
        Me.HhGridDisplay1.TabIndex = 19
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn7.HeaderText = "#"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn7.Width = 56
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn8.HeaderText = "Pasos"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn8.Width = 371
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn5.HeaderText = "#"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn5.Width = 56
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Pasos"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn6.Width = 371
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn3.HeaderText = "#"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Width = 56
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn4.HeaderText = "Pasos"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn4.Width = 371
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "#"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Pasos"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn2.Width = 371
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(680, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 90)
        Me.Button3.TabIndex = 55
        Me.Button3.Text = "Salta paso"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HhNumericDisplay2)
        Me.GroupBox1.Controls.Add(Me.HhNumericDisplay1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 106)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temperatura"
        '
        'HhNumericDisplay2
        '
        Me.HhNumericDisplay2.AutoActualizar = False
        Me.HhNumericDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhNumericDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay2.DireccionLectura = Nothing
        Me.HhNumericDisplay2.Etiqueta = Nothing
        Me.HhNumericDisplay2.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhNumericDisplay2.Link = Nothing
        Me.HhNumericDisplay2.Location = New System.Drawing.Point(206, 60)
        Me.HhNumericDisplay2.Name = "HhNumericDisplay2"
        Me.HhNumericDisplay2.Size = New System.Drawing.Size(100, 38)
        Me.HhNumericDisplay2.TabIndex = 3
        Me.HhNumericDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay2.Tooltip = Nothing
        Me.HhNumericDisplay2.Valor = 0
        Me.HhNumericDisplay2.ValorMaximo = 0
        Me.HhNumericDisplay2.ValorMinimo = 0
        '
        'HhNumericDisplay1
        '
        Me.HhNumericDisplay1.AutoActualizar = False
        Me.HhNumericDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhNumericDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay1.DireccionLectura = Nothing
        Me.HhNumericDisplay1.Etiqueta = Nothing
        Me.HhNumericDisplay1.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhNumericDisplay1.Link = Nothing
        Me.HhNumericDisplay1.Location = New System.Drawing.Point(206, 17)
        Me.HhNumericDisplay1.Name = "HhNumericDisplay1"
        Me.HhNumericDisplay1.Size = New System.Drawing.Size(100, 38)
        Me.HhNumericDisplay1.TabIndex = 0
        Me.HhNumericDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay1.Tooltip = Nothing
        Me.HhNumericDisplay1.Valor = 0
        Me.HhNumericDisplay1.ValorMaximo = 0
        Me.HhNumericDisplay1.ValorMinimo = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.HhNumericDisplay4)
        Me.GroupBox2.Controls.Add(Me.HhNumericDisplay3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 159)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(314, 106)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Llenado"
        '
        'HhNumericDisplay4
        '
        Me.HhNumericDisplay4.AutoActualizar = False
        Me.HhNumericDisplay4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhNumericDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay4.DireccionLectura = Nothing
        Me.HhNumericDisplay4.Etiqueta = Nothing
        Me.HhNumericDisplay4.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhNumericDisplay4.Link = Nothing
        Me.HhNumericDisplay4.Location = New System.Drawing.Point(206, 60)
        Me.HhNumericDisplay4.Name = "HhNumericDisplay4"
        Me.HhNumericDisplay4.Size = New System.Drawing.Size(100, 38)
        Me.HhNumericDisplay4.TabIndex = 3
        Me.HhNumericDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay4.Tooltip = Nothing
        Me.HhNumericDisplay4.Valor = 0
        Me.HhNumericDisplay4.ValorMaximo = 0
        Me.HhNumericDisplay4.ValorMinimo = 0
        '
        'HhNumericDisplay3
        '
        Me.HhNumericDisplay3.AutoActualizar = False
        Me.HhNumericDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhNumericDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay3.DireccionLectura = Nothing
        Me.HhNumericDisplay3.Etiqueta = Nothing
        Me.HhNumericDisplay3.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhNumericDisplay3.Link = Nothing
        Me.HhNumericDisplay3.Location = New System.Drawing.Point(206, 17)
        Me.HhNumericDisplay3.Name = "HhNumericDisplay3"
        Me.HhNumericDisplay3.Size = New System.Drawing.Size(100, 38)
        Me.HhNumericDisplay3.TabIndex = 0
        Me.HhNumericDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay3.Tooltip = Nothing
        Me.HhNumericDisplay3.Valor = 0
        Me.HhNumericDisplay3.ValorMaximo = 0
        Me.HhNumericDisplay3.ValorMinimo = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.HhNumericDisplay6)
        Me.GroupBox3.Controls.Add(Me.HhNumericDisplay5)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 267)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(314, 106)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotacion"
        '
        'HhNumericDisplay6
        '
        Me.HhNumericDisplay6.AutoActualizar = False
        Me.HhNumericDisplay6.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhNumericDisplay6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay6.DireccionLectura = Nothing
        Me.HhNumericDisplay6.Etiqueta = Nothing
        Me.HhNumericDisplay6.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhNumericDisplay6.Link = Nothing
        Me.HhNumericDisplay6.Location = New System.Drawing.Point(206, 60)
        Me.HhNumericDisplay6.Name = "HhNumericDisplay6"
        Me.HhNumericDisplay6.Size = New System.Drawing.Size(100, 38)
        Me.HhNumericDisplay6.TabIndex = 3
        Me.HhNumericDisplay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay6.Tooltip = Nothing
        Me.HhNumericDisplay6.Valor = 0
        Me.HhNumericDisplay6.ValorMaximo = 0
        Me.HhNumericDisplay6.ValorMinimo = 0
        '
        'HhNumericDisplay5
        '
        Me.HhNumericDisplay5.AutoActualizar = False
        Me.HhNumericDisplay5.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhNumericDisplay5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay5.DireccionLectura = Nothing
        Me.HhNumericDisplay5.Etiqueta = Nothing
        Me.HhNumericDisplay5.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhNumericDisplay5.Link = Nothing
        Me.HhNumericDisplay5.Location = New System.Drawing.Point(206, 17)
        Me.HhNumericDisplay5.Name = "HhNumericDisplay5"
        Me.HhNumericDisplay5.Size = New System.Drawing.Size(100, 38)
        Me.HhNumericDisplay5.TabIndex = 0
        Me.HhNumericDisplay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay5.Tooltip = Nothing
        Me.HhNumericDisplay5.Valor = 0
        Me.HhNumericDisplay5.ValorMaximo = 0
        Me.HhNumericDisplay5.ValorMinimo = 0
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(332, 467)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 90)
        Me.Button4.TabIndex = 69
        Me.Button4.Text = "Recetas"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay4)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay3)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay2)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 379)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(314, 196)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tiempo"
        '
        'HhTimeCounterDisplay4
        '
        Me.HhTimeCounterDisplay4.AutoActualizar = False
        Me.HhTimeCounterDisplay4.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhTimeCounterDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay4.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay4.Etiqueta = Nothing
        Me.HhTimeCounterDisplay4.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhTimeCounterDisplay4.Link = Nothing
        Me.HhTimeCounterDisplay4.Location = New System.Drawing.Point(206, 142)
        Me.HhTimeCounterDisplay4.Name = "HhTimeCounterDisplay4"
        Me.HhTimeCounterDisplay4.Size = New System.Drawing.Size(100, 38)
        Me.HhTimeCounterDisplay4.TabIndex = 7
        Me.HhTimeCounterDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay4.Valor = 0
        Me.HhTimeCounterDisplay4.ValorMaximo = 0
        '
        'HhTimeCounterDisplay3
        '
        Me.HhTimeCounterDisplay3.AutoActualizar = False
        Me.HhTimeCounterDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhTimeCounterDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay3.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay3.Etiqueta = Nothing
        Me.HhTimeCounterDisplay3.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhTimeCounterDisplay3.Link = Nothing
        Me.HhTimeCounterDisplay3.Location = New System.Drawing.Point(206, 101)
        Me.HhTimeCounterDisplay3.Name = "HhTimeCounterDisplay3"
        Me.HhTimeCounterDisplay3.Size = New System.Drawing.Size(100, 38)
        Me.HhTimeCounterDisplay3.TabIndex = 5
        Me.HhTimeCounterDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay3.Valor = 0
        Me.HhTimeCounterDisplay3.ValorMaximo = 0
        '
        'HhTimeCounterDisplay2
        '
        Me.HhTimeCounterDisplay2.AutoActualizar = False
        Me.HhTimeCounterDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhTimeCounterDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay2.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay2.Etiqueta = Nothing
        Me.HhTimeCounterDisplay2.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhTimeCounterDisplay2.Link = Nothing
        Me.HhTimeCounterDisplay2.Location = New System.Drawing.Point(206, 60)
        Me.HhTimeCounterDisplay2.Name = "HhTimeCounterDisplay2"
        Me.HhTimeCounterDisplay2.Size = New System.Drawing.Size(100, 38)
        Me.HhTimeCounterDisplay2.TabIndex = 3
        Me.HhTimeCounterDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay2.Valor = 0
        Me.HhTimeCounterDisplay2.ValorMaximo = 0
        '
        'HhTimeCounterDisplay1
        '
        Me.HhTimeCounterDisplay1.AutoActualizar = False
        Me.HhTimeCounterDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.HhTimeCounterDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay1.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay1.Etiqueta = Nothing
        Me.HhTimeCounterDisplay1.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhTimeCounterDisplay1.Link = Nothing
        Me.HhTimeCounterDisplay1.Location = New System.Drawing.Point(206, 19)
        Me.HhTimeCounterDisplay1.Name = "HhTimeCounterDisplay1"
        Me.HhTimeCounterDisplay1.Size = New System.Drawing.Size(100, 38)
        Me.HhTimeCounterDisplay1.TabIndex = 0
        Me.HhTimeCounterDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay1.Valor = 0
        Me.HhTimeCounterDisplay1.ValorMaximo = 0
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(544, 468)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 90)
        Me.Button5.TabIndex = 70
        Me.Button5.Text = "Mandos"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'HhMsgBox1
        '
        Me.HhMsgBox1.DireccionCancel = Nothing
        Me.HhMsgBox1.DireccionOk = Nothing
        Me.HhMsgBox1.Link = Nothing
        Me.HhMsgBox1.Mensaje = Nothing
        Me.HhMsgBox1.Tamanio = 0
        Me.HhMsgBox1.TextoCancel = Nothing
        Me.HhMsgBox1.TextoOk = Nothing
        '
        'HhDialogoArchivos1
        '
        Me.HhDialogoArchivos1.Extension = "*.*"
        Me.HhDialogoArchivos1.Folder = "H&H"
        Me.HhDialogoArchivos1.Longitud = 0
        Me.HhDialogoArchivos1.Unidad = "C:"
        '
        'HhMomentaryButton4
        '
        Me.HhMomentaryButton4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton4.DireccionEscritura = Nothing
        Me.HhMomentaryButton4.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhMomentaryButton4.Link = Nothing
        Me.HhMomentaryButton4.Location = New System.Drawing.Point(438, 467)
        Me.HhMomentaryButton4.Name = "HhMomentaryButton4"
        Me.HhMomentaryButton4.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton4.TabIndex = 71
        Me.HhMomentaryButton4.Text = "Edit"
        Me.HhMomentaryButton4.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton3
        '
        Me.HhMomentaryButton3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton3.DireccionEscritura = Nothing
        Me.HhMomentaryButton3.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhMomentaryButton3.Link = Nothing
        Me.HhMomentaryButton3.Location = New System.Drawing.Point(544, 372)
        Me.HhMomentaryButton3.Name = "HhMomentaryButton3"
        Me.HhMomentaryButton3.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton3.TabIndex = 46
        Me.HhMomentaryButton3.Text = "Abort"
        Me.HhMomentaryButton3.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton2
        '
        Me.HhMomentaryButton2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton2.DireccionEscritura = Nothing
        Me.HhMomentaryButton2.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhMomentaryButton2.Link = Nothing
        Me.HhMomentaryButton2.Location = New System.Drawing.Point(438, 371)
        Me.HhMomentaryButton2.Name = "HhMomentaryButton2"
        Me.HhMomentaryButton2.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton2.TabIndex = 37
        Me.HhMomentaryButton2.Text = "Stop"
        Me.HhMomentaryButton2.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton1
        '
        Me.HhMomentaryButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton1.DireccionEscritura = Nothing
        Me.HhMomentaryButton1.Font = New System.Drawing.Font("Teenage angst", 20.0!)
        Me.HhMomentaryButton1.Link = Nothing
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(332, 371)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 1
        Me.HhMomentaryButton1.Text = "Start"
        Me.HhMomentaryButton1.UseVisualStyleBackColor = True
        '
        'FormAutomatico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhMomentaryButton4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.HhGridDisplay1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.HhMomentaryButton3)
        Me.Controls.Add(Me.HhMomentaryButton2)
        Me.Controls.Add(Me.HhCharacterDisplay1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.HhMomentaryButton1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormAutomatico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormAutomatico"
        CType(Me.HhGridDisplay1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhCharacterDisplay1 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents HhGridDisplay1 As hhGridDisplay.hhGridDisplay
    Friend WithEvents HhMomentaryButton2 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton3 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents HhTimeCounterDisplay4 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay3 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay2 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay1 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents HhMomentaryButton4 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMsgBox1 As hhMsgBox.hhMsgBox
    Friend WithEvents HhDialogoArchivos1 As DialogoArchivos.hhDialogoArchivos
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HhNumericDisplay2 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay1 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay4 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay3 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay6 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay5 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
