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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAutomatico))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HhNumericDisplay2 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay1 = New hhNumericDisplay.hhNumericDisplay()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.HhNumericDisplay4 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay3 = New hhNumericDisplay.hhNumericDisplay()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.HhNumericDisplay6 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay5 = New hhNumericDisplay.hhNumericDisplay()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.HhTimeCounterDisplay4 = New hhTimeCounterDisplay.hhTimeCounterDisplay()
        Me.HhTimeCounterDisplay3 = New hhTimeCounterDisplay.hhTimeCounterDisplay()
        Me.HhTimeCounterDisplay2 = New hhTimeCounterDisplay.hhTimeCounterDisplay()
        Me.HhTimeCounterDisplay1 = New hhTimeCounterDisplay.hhTimeCounterDisplay()
        Me.HhDialogoArchivos1 = New DialogoArchivos.hhDialogoArchivos()
        Me.HhGridDisplay1 = New hhGridDisplay.hhGridDisplay()
        Me.HhMomentaryButton4 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button5 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button4 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button3 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton3 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton2 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.HhGridDisplay1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HhNumericDisplay2)
        Me.GroupBox1.Controls.Add(Me.HhNumericDisplay1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 106)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temperatura"
        '
        'HhNumericDisplay2
        '
        Me.HhNumericDisplay2.AutoActualizar = False
        Me.HhNumericDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay2.DireccionLectura = Nothing
        Me.HhNumericDisplay2.Etiqueta = Nothing
        Me.HhNumericDisplay2.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhNumericDisplay2.Link = Nothing
        Me.HhNumericDisplay2.Location = New System.Drawing.Point(206, 60)
        Me.HhNumericDisplay2.Name = "HhNumericDisplay2"
        Me.HhNumericDisplay2.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay2.TabIndex = 0
        Me.HhNumericDisplay2.Text = "0"
        Me.HhNumericDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay2.Tooltip = Nothing
        Me.HhNumericDisplay2.Valor = 0
        Me.HhNumericDisplay2.ValorMaximo = 0
        Me.HhNumericDisplay2.ValorMinimo = 0
        '
        'HhNumericDisplay1
        '
        Me.HhNumericDisplay1.AutoActualizar = False
        Me.HhNumericDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay1.DireccionLectura = Nothing
        Me.HhNumericDisplay1.Etiqueta = Nothing
        Me.HhNumericDisplay1.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhNumericDisplay1.Link = Nothing
        Me.HhNumericDisplay1.Location = New System.Drawing.Point(206, 17)
        Me.HhNumericDisplay1.Name = "HhNumericDisplay1"
        Me.HhNumericDisplay1.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay1.TabIndex = 2
        Me.HhNumericDisplay1.Text = "0"
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
        Me.GroupBox2.Size = New System.Drawing.Size(344, 106)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Llenado"
        '
        'HhNumericDisplay4
        '
        Me.HhNumericDisplay4.AutoActualizar = False
        Me.HhNumericDisplay4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay4.DireccionLectura = Nothing
        Me.HhNumericDisplay4.Etiqueta = Nothing
        Me.HhNumericDisplay4.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhNumericDisplay4.Link = Nothing
        Me.HhNumericDisplay4.Location = New System.Drawing.Point(206, 60)
        Me.HhNumericDisplay4.Name = "HhNumericDisplay4"
        Me.HhNumericDisplay4.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay4.TabIndex = 0
        Me.HhNumericDisplay4.Text = "0"
        Me.HhNumericDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay4.Tooltip = Nothing
        Me.HhNumericDisplay4.Valor = 0
        Me.HhNumericDisplay4.ValorMaximo = 0
        Me.HhNumericDisplay4.ValorMinimo = 0
        '
        'HhNumericDisplay3
        '
        Me.HhNumericDisplay3.AutoActualizar = False
        Me.HhNumericDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay3.DireccionLectura = Nothing
        Me.HhNumericDisplay3.Etiqueta = Nothing
        Me.HhNumericDisplay3.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhNumericDisplay3.Link = Nothing
        Me.HhNumericDisplay3.Location = New System.Drawing.Point(206, 17)
        Me.HhNumericDisplay3.Name = "HhNumericDisplay3"
        Me.HhNumericDisplay3.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay3.TabIndex = 2
        Me.HhNumericDisplay3.Text = "0"
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
        Me.GroupBox3.Size = New System.Drawing.Size(344, 106)
        Me.GroupBox3.TabIndex = 68
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotacion"
        '
        'HhNumericDisplay6
        '
        Me.HhNumericDisplay6.AutoActualizar = False
        Me.HhNumericDisplay6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay6.DireccionLectura = Nothing
        Me.HhNumericDisplay6.Etiqueta = Nothing
        Me.HhNumericDisplay6.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhNumericDisplay6.Link = Nothing
        Me.HhNumericDisplay6.Location = New System.Drawing.Point(206, 60)
        Me.HhNumericDisplay6.Name = "HhNumericDisplay6"
        Me.HhNumericDisplay6.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay6.TabIndex = 0
        Me.HhNumericDisplay6.Text = "0"
        Me.HhNumericDisplay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay6.Tooltip = Nothing
        Me.HhNumericDisplay6.Valor = 0
        Me.HhNumericDisplay6.ValorMaximo = 0
        Me.HhNumericDisplay6.ValorMinimo = 0
        '
        'HhNumericDisplay5
        '
        Me.HhNumericDisplay5.AutoActualizar = False
        Me.HhNumericDisplay5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay5.DireccionLectura = Nothing
        Me.HhNumericDisplay5.Etiqueta = Nothing
        Me.HhNumericDisplay5.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhNumericDisplay5.Link = Nothing
        Me.HhNumericDisplay5.Location = New System.Drawing.Point(206, 17)
        Me.HhNumericDisplay5.Name = "HhNumericDisplay5"
        Me.HhNumericDisplay5.Size = New System.Drawing.Size(130, 40)
        Me.HhNumericDisplay5.TabIndex = 2
        Me.HhNumericDisplay5.Text = "0"
        Me.HhNumericDisplay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay5.Tooltip = Nothing
        Me.HhNumericDisplay5.Valor = 0
        Me.HhNumericDisplay5.ValorMaximo = 0
        Me.HhNumericDisplay5.ValorMinimo = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay4)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay3)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay2)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay1)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 379)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(344, 190)
        Me.GroupBox4.TabIndex = 69
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tiempo"
        '
        'HhTimeCounterDisplay4
        '
        Me.HhTimeCounterDisplay4.AutoActualizar = False
        Me.HhTimeCounterDisplay4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhTimeCounterDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay4.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay4.Etiqueta = Nothing
        Me.HhTimeCounterDisplay4.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhTimeCounterDisplay4.Link = Nothing
        Me.HhTimeCounterDisplay4.Location = New System.Drawing.Point(206, 142)
        Me.HhTimeCounterDisplay4.Name = "HhTimeCounterDisplay4"
        Me.HhTimeCounterDisplay4.Size = New System.Drawing.Size(130, 40)
        Me.HhTimeCounterDisplay4.TabIndex = 0
        Me.HhTimeCounterDisplay4.Text = "0:00"
        Me.HhTimeCounterDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay4.Tooltip = Nothing
        Me.HhTimeCounterDisplay4.Valor = 0
        Me.HhTimeCounterDisplay4.ValorMaximo = 0
        '
        'HhTimeCounterDisplay3
        '
        Me.HhTimeCounterDisplay3.AutoActualizar = False
        Me.HhTimeCounterDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhTimeCounterDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay3.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay3.Etiqueta = Nothing
        Me.HhTimeCounterDisplay3.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhTimeCounterDisplay3.Link = Nothing
        Me.HhTimeCounterDisplay3.Location = New System.Drawing.Point(206, 101)
        Me.HhTimeCounterDisplay3.Name = "HhTimeCounterDisplay3"
        Me.HhTimeCounterDisplay3.Size = New System.Drawing.Size(130, 40)
        Me.HhTimeCounterDisplay3.TabIndex = 2
        Me.HhTimeCounterDisplay3.Text = "0:00"
        Me.HhTimeCounterDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay3.Tooltip = Nothing
        Me.HhTimeCounterDisplay3.Valor = 0
        Me.HhTimeCounterDisplay3.ValorMaximo = 0
        '
        'HhTimeCounterDisplay2
        '
        Me.HhTimeCounterDisplay2.AutoActualizar = False
        Me.HhTimeCounterDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhTimeCounterDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay2.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay2.Etiqueta = Nothing
        Me.HhTimeCounterDisplay2.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhTimeCounterDisplay2.Link = Nothing
        Me.HhTimeCounterDisplay2.Location = New System.Drawing.Point(206, 60)
        Me.HhTimeCounterDisplay2.Name = "HhTimeCounterDisplay2"
        Me.HhTimeCounterDisplay2.Size = New System.Drawing.Size(130, 40)
        Me.HhTimeCounterDisplay2.TabIndex = 4
        Me.HhTimeCounterDisplay2.Text = "0:00"
        Me.HhTimeCounterDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay2.Tooltip = Nothing
        Me.HhTimeCounterDisplay2.Valor = 0
        Me.HhTimeCounterDisplay2.ValorMaximo = 0
        '
        'HhTimeCounterDisplay1
        '
        Me.HhTimeCounterDisplay1.AutoActualizar = False
        Me.HhTimeCounterDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhTimeCounterDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay1.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay1.Etiqueta = Nothing
        Me.HhTimeCounterDisplay1.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhTimeCounterDisplay1.Link = Nothing
        Me.HhTimeCounterDisplay1.Location = New System.Drawing.Point(206, 19)
        Me.HhTimeCounterDisplay1.Name = "HhTimeCounterDisplay1"
        Me.HhTimeCounterDisplay1.Size = New System.Drawing.Size(130, 40)
        Me.HhTimeCounterDisplay1.TabIndex = 6
        Me.HhTimeCounterDisplay1.Text = "0:00"
        Me.HhTimeCounterDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay1.Tooltip = Nothing
        Me.HhTimeCounterDisplay1.Valor = 0
        Me.HhTimeCounterDisplay1.ValorMaximo = 0
        '
        'HhDialogoArchivos1
        '
        Me.HhDialogoArchivos1.Extension = "*.*"
        Me.HhDialogoArchivos1.Folder = "H&H"
        Me.HhDialogoArchivos1.Longitud = 0
        Me.HhDialogoArchivos1.Unidad = "C:"
        '
        'HhGridDisplay1
        '
        Me.HhGridDisplay1.AllowUserToAddRows = False
        Me.HhGridDisplay1.AllowUserToDeleteRows = False
        Me.HhGridDisplay1.AllowUserToResizeRows = False
        Me.HhGridDisplay1.AutoActualizar = False
        Me.HhGridDisplay1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HhGridDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhGridDisplay1.DireccionEscritura = Nothing
        Me.HhGridDisplay1.DireccionLectura = Nothing
        Me.HhGridDisplay1.DireccionPaso = Nothing
        Me.HhGridDisplay1.EscribirPaso = False
        Me.HhGridDisplay1.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhGridDisplay1.Link = Nothing
        Me.HhGridDisplay1.Location = New System.Drawing.Point(362, 5)
        Me.HhGridDisplay1.LongitudPaso = 0
        Me.HhGridDisplay1.LongitudTexto = 0
        Me.HhGridDisplay1.MostrarSeleccion = False
        Me.HhGridDisplay1.MultiSelect = False
        Me.HhGridDisplay1.Name = "HhGridDisplay1"
        Me.HhGridDisplay1.PasoActual = 0
        Me.HhGridDisplay1.Receta = Nothing
        Me.HhGridDisplay1.RowHeadersVisible = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe Script", 16.0!)
        Me.HhGridDisplay1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.HhGridDisplay1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.HhGridDisplay1.ShowCellToolTips = False
        Me.HhGridDisplay1.Size = New System.Drawing.Size(418, 360)
        Me.HhGridDisplay1.TabIndex = 72
        '
        'HhMomentaryButton4
        '
        Me.HhMomentaryButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton4.AutoActualizar = False
        Me.HhMomentaryButton4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton4.DireccionEscritura = Nothing
        Me.HhMomentaryButton4.DireccionLectura = Nothing
        Me.HhMomentaryButton4.Etiqueta = Nothing
        Me.HhMomentaryButton4.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.HhMomentaryButton4.Image = CType(resources.GetObject("HhMomentaryButton4.Image"), System.Drawing.Image)
        Me.HhMomentaryButton4.Link = Nothing
        Me.HhMomentaryButton4.Location = New System.Drawing.Point(468, 467)
        Me.HhMomentaryButton4.Name = "HhMomentaryButton4"
        Me.HhMomentaryButton4.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton4.TabIndex = 71
        Me.HhMomentaryButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhMomentaryButton4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button5.AutoActualizar = False
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button5.DireccionEscritura = Nothing
        Me.Button5.DireccionLectura = Nothing
        Me.Button5.Etiqueta = Nothing
        Me.Button5.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Link = Nothing
        Me.Button5.Location = New System.Drawing.Point(574, 467)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 90)
        Me.Button5.TabIndex = 70
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button4.AutoActualizar = False
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button4.DireccionEscritura = Nothing
        Me.Button4.DireccionLectura = Nothing
        Me.Button4.Etiqueta = Nothing
        Me.Button4.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.Link = Nothing
        Me.Button4.Location = New System.Drawing.Point(362, 467)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(100, 90)
        Me.Button4.TabIndex = 69
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button3.AutoActualizar = False
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button3.DireccionEscritura = Nothing
        Me.Button3.DireccionLectura = Nothing
        Me.Button3.Etiqueta = Nothing
        Me.Button3.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Link = Nothing
        Me.Button3.Location = New System.Drawing.Point(680, 371)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 90)
        Me.Button3.TabIndex = 55
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton3
        '
        Me.HhMomentaryButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton3.AutoActualizar = False
        Me.HhMomentaryButton3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton3.DireccionEscritura = Nothing
        Me.HhMomentaryButton3.DireccionLectura = Nothing
        Me.HhMomentaryButton3.Etiqueta = Nothing
        Me.HhMomentaryButton3.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.HhMomentaryButton3.Image = CType(resources.GetObject("HhMomentaryButton3.Image"), System.Drawing.Image)
        Me.HhMomentaryButton3.Link = Nothing
        Me.HhMomentaryButton3.Location = New System.Drawing.Point(574, 371)
        Me.HhMomentaryButton3.Name = "HhMomentaryButton3"
        Me.HhMomentaryButton3.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton3.TabIndex = 46
        Me.HhMomentaryButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhMomentaryButton3.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton2
        '
        Me.HhMomentaryButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton2.AutoActualizar = False
        Me.HhMomentaryButton2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton2.DireccionEscritura = Nothing
        Me.HhMomentaryButton2.DireccionLectura = Nothing
        Me.HhMomentaryButton2.Etiqueta = Nothing
        Me.HhMomentaryButton2.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.HhMomentaryButton2.Image = CType(resources.GetObject("HhMomentaryButton2.Image"), System.Drawing.Image)
        Me.HhMomentaryButton2.Link = Nothing
        Me.HhMomentaryButton2.Location = New System.Drawing.Point(468, 371)
        Me.HhMomentaryButton2.Name = "HhMomentaryButton2"
        Me.HhMomentaryButton2.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton2.TabIndex = 37
        Me.HhMomentaryButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhMomentaryButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Etiqueta = Nothing
        Me.Button1.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(680, 467)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton1
        '
        Me.HhMomentaryButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton1.AutoActualizar = False
        Me.HhMomentaryButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton1.DireccionEscritura = Nothing
        Me.HhMomentaryButton1.DireccionLectura = Nothing
        Me.HhMomentaryButton1.Etiqueta = Nothing
        Me.HhMomentaryButton1.Font = New System.Drawing.Font("Segoe Script", 8.0!)
        Me.HhMomentaryButton1.Image = CType(resources.GetObject("HhMomentaryButton1.Image"), System.Drawing.Image)
        Me.HhMomentaryButton1.Link = Nothing
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(362, 371)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 1
        Me.HhMomentaryButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.HhGridDisplay1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhGridDisplay1 As hhGridDisplay.hhGridDisplay
    Friend WithEvents HhMomentaryButton2 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton3 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button3 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button4 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents HhTimeCounterDisplay4 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay3 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay2 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay1 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents Button5 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton4 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhDialogoArchivos1 As DialogoArchivos.hhDialogoArchivos
    Friend WithEvents HhNumericDisplay2 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay1 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay4 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay3 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay6 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay5 As hhNumericDisplay.hhNumericDisplay
End Class
