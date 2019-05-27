<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormManual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormManual))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.HhMomentaryButton7 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton6 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton4 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton5 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton3 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton2 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button2 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhNumericDisplay1 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay2 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay3 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay4 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay5 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhNumericDisplay6 = New hhNumericDisplay.hhNumericDisplay()
        Me.HhTimeCounterDisplay1 = New hhTimeCounterDisplay.hhTimeCounterDisplay()
        Me.HhTimeCounterDisplay2 = New hhTimeCounterDisplay.hhTimeCounterDisplay()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 575)
        Me.SplitContainer1.SplitterDistance = 370
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox4, 0, 3)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(5, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(360, 565)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HhNumericDisplay2)
        Me.GroupBox1.Controls.Add(Me.HhNumericDisplay1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Temperatura"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.HhNumericDisplay3)
        Me.GroupBox2.Controls.Add(Me.HhNumericDisplay4)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(354, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Llenado"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.HhNumericDisplay5)
        Me.GroupBox3.Controls.Add(Me.HhNumericDisplay6)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 285)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(354, 135)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Rotacion"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay1)
        Me.GroupBox4.Controls.Add(Me.HhTimeCounterDisplay2)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 426)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(354, 136)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tiempo"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Button2, 0, 4)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(426, 575)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'HhMomentaryButton7
        '
        Me.HhMomentaryButton7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton7.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton7.AutoActualizar = False
        Me.HhMomentaryButton7.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton7.DireccionEscritura = Nothing
        Me.HhMomentaryButton7.DireccionLectura = Nothing
        Me.HhMomentaryButton7.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton7.Image = CType(resources.GetObject("HhMomentaryButton7.Image"), System.Drawing.Image)
        Me.HhMomentaryButton7.Link = Nothing
        Me.HhMomentaryButton7.Location = New System.Drawing.Point(56, 357)
        Me.HhMomentaryButton7.Name = "HhMomentaryButton7"
        Me.HhMomentaryButton7.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton7.TabIndex = 16
        Me.HhMomentaryButton7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton7.Texto = "Centrifuga"
        Me.HhMomentaryButton7.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton6
        '
        Me.HhMomentaryButton6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton6.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton6.AutoActualizar = False
        Me.HhMomentaryButton6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton6.DireccionEscritura = Nothing
        Me.HhMomentaryButton6.DireccionLectura = Nothing
        Me.HhMomentaryButton6.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton6.Image = CType(resources.GetObject("HhMomentaryButton6.Image"), System.Drawing.Image)
        Me.HhMomentaryButton6.Link = Nothing
        Me.HhMomentaryButton6.Location = New System.Drawing.Point(269, 242)
        Me.HhMomentaryButton6.Name = "HhMomentaryButton6"
        Me.HhMomentaryButton6.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton6.TabIndex = 15
        Me.HhMomentaryButton6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton6.Texto = "Aditivos"
        Me.HhMomentaryButton6.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton4
        '
        Me.HhMomentaryButton4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton4.AutoActualizar = False
        Me.HhMomentaryButton4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton4.DireccionEscritura = Nothing
        Me.HhMomentaryButton4.DireccionLectura = Nothing
        Me.HhMomentaryButton4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton4.Image = CType(resources.GetObject("HhMomentaryButton4.Image"), System.Drawing.Image)
        Me.HhMomentaryButton4.Link = Nothing
        Me.HhMomentaryButton4.Location = New System.Drawing.Point(269, 127)
        Me.HhMomentaryButton4.Name = "HhMomentaryButton4"
        Me.HhMomentaryButton4.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton4.TabIndex = 14
        Me.HhMomentaryButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton4.Texto = "Mantenimiento"
        Me.HhMomentaryButton4.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton5
        '
        Me.HhMomentaryButton5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton5.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton5.AutoActualizar = False
        Me.HhMomentaryButton5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton5.DireccionEscritura = Nothing
        Me.HhMomentaryButton5.DireccionLectura = Nothing
        Me.HhMomentaryButton5.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton5.Image = CType(resources.GetObject("HhMomentaryButton5.Image"), System.Drawing.Image)
        Me.HhMomentaryButton5.Link = Nothing
        Me.HhMomentaryButton5.Location = New System.Drawing.Point(56, 242)
        Me.HhMomentaryButton5.Name = "HhMomentaryButton5"
        Me.HhMomentaryButton5.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton5.TabIndex = 13
        Me.HhMomentaryButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton5.Texto = "Temperatura"
        Me.HhMomentaryButton5.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton3
        '
        Me.HhMomentaryButton3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton3.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton3.AutoActualizar = False
        Me.HhMomentaryButton3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton3.DireccionEscritura = Nothing
        Me.HhMomentaryButton3.DireccionLectura = Nothing
        Me.HhMomentaryButton3.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton3.Image = CType(resources.GetObject("HhMomentaryButton3.Image"), System.Drawing.Image)
        Me.HhMomentaryButton3.Link = Nothing
        Me.HhMomentaryButton3.Location = New System.Drawing.Point(56, 127)
        Me.HhMomentaryButton3.Name = "HhMomentaryButton3"
        Me.HhMomentaryButton3.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton3.TabIndex = 12
        Me.HhMomentaryButton3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton3.Texto = "Rotacion"
        Me.HhMomentaryButton3.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton1
        '
        Me.HhMomentaryButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton1.AutoActualizar = False
        Me.HhMomentaryButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton1.DireccionEscritura = Nothing
        Me.HhMomentaryButton1.DireccionLectura = Nothing
        Me.HhMomentaryButton1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton1.Image = CType(resources.GetObject("HhMomentaryButton1.Image"), System.Drawing.Image)
        Me.HhMomentaryButton1.Link = Nothing
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(56, 12)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 11
        Me.HhMomentaryButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton1.Texto = "Llenado"
        Me.HhMomentaryButton1.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton2
        '
        Me.HhMomentaryButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton2.AutoActualizar = False
        Me.HhMomentaryButton2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton2.DireccionEscritura = Nothing
        Me.HhMomentaryButton2.DireccionLectura = Nothing
        Me.HhMomentaryButton2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton2.Image = CType(resources.GetObject("HhMomentaryButton2.Image"), System.Drawing.Image)
        Me.HhMomentaryButton2.Link = Nothing
        Me.HhMomentaryButton2.Location = New System.Drawing.Point(269, 12)
        Me.HhMomentaryButton2.Name = "HhMomentaryButton2"
        Me.HhMomentaryButton2.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton2.TabIndex = 10
        Me.HhMomentaryButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton2.Texto = "Desague"
        Me.HhMomentaryButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(269, 472)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 17
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button2.AutoActualizar = False
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button2.DireccionEscritura = Nothing
        Me.Button2.DireccionLectura = Nothing
        Me.Button2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Link = Nothing
        Me.Button2.Location = New System.Drawing.Point(56, 472)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 90)
        Me.Button2.TabIndex = 18
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Texto = "Mandos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'HhNumericDisplay1
        '
        Me.HhNumericDisplay1.AutoActualizar = False
        Me.HhNumericDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay1.DireccionLectura = Nothing
        Me.HhNumericDisplay1.Etiqueta = "Temperatura"
        Me.HhNumericDisplay1.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericDisplay1.Link = Nothing
        Me.HhNumericDisplay1.Location = New System.Drawing.Point(203, 16)
        Me.HhNumericDisplay1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhNumericDisplay1.Name = "HhNumericDisplay1"
        Me.HhNumericDisplay1.Size = New System.Drawing.Size(145, 55)
        Me.HhNumericDisplay1.TabIndex = 2
        Me.HhNumericDisplay1.Text = "0"
        Me.HhNumericDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay1.Tooltip = Nothing
        Me.HhNumericDisplay1.Valor = 0
        Me.HhNumericDisplay1.ValorMaximo = 0
        Me.HhNumericDisplay1.ValorMinimo = 0
        '
        'HhNumericDisplay2
        '
        Me.HhNumericDisplay2.AutoActualizar = False
        Me.HhNumericDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay2.DireccionLectura = Nothing
        Me.HhNumericDisplay2.Etiqueta = "Set"
        Me.HhNumericDisplay2.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericDisplay2.Link = Nothing
        Me.HhNumericDisplay2.Location = New System.Drawing.Point(203, 74)
        Me.HhNumericDisplay2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhNumericDisplay2.Name = "HhNumericDisplay2"
        Me.HhNumericDisplay2.Size = New System.Drawing.Size(145, 55)
        Me.HhNumericDisplay2.TabIndex = 4
        Me.HhNumericDisplay2.Text = "0"
        Me.HhNumericDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay2.Tooltip = Nothing
        Me.HhNumericDisplay2.Valor = 0
        Me.HhNumericDisplay2.ValorMaximo = 0
        Me.HhNumericDisplay2.ValorMinimo = 0
        '
        'HhNumericDisplay3
        '
        Me.HhNumericDisplay3.AutoActualizar = False
        Me.HhNumericDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay3.DireccionLectura = Nothing
        Me.HhNumericDisplay3.Etiqueta = "Litros"
        Me.HhNumericDisplay3.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericDisplay3.Link = Nothing
        Me.HhNumericDisplay3.Location = New System.Drawing.Point(203, 16)
        Me.HhNumericDisplay3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhNumericDisplay3.Name = "HhNumericDisplay3"
        Me.HhNumericDisplay3.Size = New System.Drawing.Size(145, 55)
        Me.HhNumericDisplay3.TabIndex = 4
        Me.HhNumericDisplay3.Text = "0"
        Me.HhNumericDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay3.Tooltip = Nothing
        Me.HhNumericDisplay3.Valor = 0
        Me.HhNumericDisplay3.ValorMaximo = 0
        Me.HhNumericDisplay3.ValorMinimo = 0
        '
        'HhNumericDisplay4
        '
        Me.HhNumericDisplay4.AutoActualizar = False
        Me.HhNumericDisplay4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay4.DireccionLectura = Nothing
        Me.HhNumericDisplay4.Etiqueta = "Set"
        Me.HhNumericDisplay4.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericDisplay4.Link = Nothing
        Me.HhNumericDisplay4.Location = New System.Drawing.Point(203, 74)
        Me.HhNumericDisplay4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhNumericDisplay4.Name = "HhNumericDisplay4"
        Me.HhNumericDisplay4.Size = New System.Drawing.Size(145, 55)
        Me.HhNumericDisplay4.TabIndex = 5
        Me.HhNumericDisplay4.Text = "0"
        Me.HhNumericDisplay4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay4.Tooltip = Nothing
        Me.HhNumericDisplay4.Valor = 0
        Me.HhNumericDisplay4.ValorMaximo = 0
        Me.HhNumericDisplay4.ValorMinimo = 0
        '
        'HhNumericDisplay5
        '
        Me.HhNumericDisplay5.AutoActualizar = False
        Me.HhNumericDisplay5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay5.DireccionLectura = Nothing
        Me.HhNumericDisplay5.Etiqueta = "Velocidad"
        Me.HhNumericDisplay5.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericDisplay5.Link = Nothing
        Me.HhNumericDisplay5.Location = New System.Drawing.Point(203, 16)
        Me.HhNumericDisplay5.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhNumericDisplay5.Name = "HhNumericDisplay5"
        Me.HhNumericDisplay5.Size = New System.Drawing.Size(145, 55)
        Me.HhNumericDisplay5.TabIndex = 4
        Me.HhNumericDisplay5.Text = "0"
        Me.HhNumericDisplay5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay5.Tooltip = Nothing
        Me.HhNumericDisplay5.Valor = 0
        Me.HhNumericDisplay5.ValorMaximo = 0
        Me.HhNumericDisplay5.ValorMinimo = 0
        '
        'HhNumericDisplay6
        '
        Me.HhNumericDisplay6.AutoActualizar = False
        Me.HhNumericDisplay6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhNumericDisplay6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhNumericDisplay6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhNumericDisplay6.DireccionLectura = Nothing
        Me.HhNumericDisplay6.Etiqueta = "Set"
        Me.HhNumericDisplay6.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericDisplay6.Link = Nothing
        Me.HhNumericDisplay6.Location = New System.Drawing.Point(203, 74)
        Me.HhNumericDisplay6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhNumericDisplay6.Name = "HhNumericDisplay6"
        Me.HhNumericDisplay6.Size = New System.Drawing.Size(145, 55)
        Me.HhNumericDisplay6.TabIndex = 5
        Me.HhNumericDisplay6.Text = "0"
        Me.HhNumericDisplay6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhNumericDisplay6.Tooltip = Nothing
        Me.HhNumericDisplay6.Valor = 0
        Me.HhNumericDisplay6.ValorMaximo = 0
        Me.HhNumericDisplay6.ValorMinimo = 0
        '
        'HhTimeCounterDisplay1
        '
        Me.HhTimeCounterDisplay1.AutoActualizar = False
        Me.HhTimeCounterDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhTimeCounterDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay1.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay1.Etiqueta = "Tiempo paso"
        Me.HhTimeCounterDisplay1.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhTimeCounterDisplay1.Link = Nothing
        Me.HhTimeCounterDisplay1.Location = New System.Drawing.Point(203, 16)
        Me.HhTimeCounterDisplay1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhTimeCounterDisplay1.Name = "HhTimeCounterDisplay1"
        Me.HhTimeCounterDisplay1.Size = New System.Drawing.Size(145, 55)
        Me.HhTimeCounterDisplay1.TabIndex = 4
        Me.HhTimeCounterDisplay1.Text = "0:00"
        Me.HhTimeCounterDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay1.Tooltip = Nothing
        Me.HhTimeCounterDisplay1.Valor = 0
        Me.HhTimeCounterDisplay1.ValorMaximo = 0
        '
        'HhTimeCounterDisplay2
        '
        Me.HhTimeCounterDisplay2.AutoActualizar = False
        Me.HhTimeCounterDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhTimeCounterDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhTimeCounterDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhTimeCounterDisplay2.DireccionLectura = Nothing
        Me.HhTimeCounterDisplay2.Etiqueta = "Duracion paso"
        Me.HhTimeCounterDisplay2.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhTimeCounterDisplay2.Link = Nothing
        Me.HhTimeCounterDisplay2.Location = New System.Drawing.Point(203, 74)
        Me.HhTimeCounterDisplay2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.HhTimeCounterDisplay2.Name = "HhTimeCounterDisplay2"
        Me.HhTimeCounterDisplay2.Size = New System.Drawing.Size(145, 55)
        Me.HhTimeCounterDisplay2.TabIndex = 5
        Me.HhTimeCounterDisplay2.Text = "0:00"
        Me.HhTimeCounterDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhTimeCounterDisplay2.Tooltip = Nothing
        Me.HhTimeCounterDisplay2.Valor = 0
        Me.HhTimeCounterDisplay2.ValorMaximo = 0
        '
        'FormManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormManual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormManual"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    'Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents HhMomentaryButton2 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton3 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton7 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton6 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton4 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton5 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button2 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents HhNumericDisplay2 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay1 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay3 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay4 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay5 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhNumericDisplay6 As hhNumericDisplay.hhNumericDisplay
    Friend WithEvents HhTimeCounterDisplay1 As hhTimeCounterDisplay.hhTimeCounterDisplay
    Friend WithEvents HhTimeCounterDisplay2 As hhTimeCounterDisplay.hhTimeCounterDisplay
    'Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    'Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    'Friend WithEvents HhNumericDisplay7 As hhNumericDisplay.hhNumericDisplay
End Class
