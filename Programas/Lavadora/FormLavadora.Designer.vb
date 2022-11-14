<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLavadora
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLavadora))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.HhAnimacion1 = New hhAnimacion.hhAnimacion()
        Me.HhAnimacion2 = New hhAnimacion.hhAnimacion()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.HhBooleanLabel1 = New hhBooleanLabel.hhBooleanLabel()
        Me.HhBooleanLabel2 = New hhBooleanLabel.hhBooleanLabel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.HhLabel3 = New hhLabel.hhLabel()
        Me.HhLabel2 = New hhLabel.hhLabel()
        Me.HhLabel1 = New hhLabel.hhLabel()
        Me.HhCharacterDisplay3 = New hhCharacterDisplay.hhCharacterDisplay()
        Me.HhCharacterDisplay2 = New hhCharacterDisplay.hhCharacterDisplay()
        Me.HhCharacterDisplay1 = New hhCharacterDisplay.hhCharacterDisplay()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button7 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button6 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton2 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button3 = New hhMomentaryButton.hhMomentaryButton()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.AutoSize = False
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 25)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Timer1
        '
        '
        'HhAnimacion1
        '
        Me.HhAnimacion1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhAnimacion1.Color1 = System.Drawing.Color.Empty
        Me.HhAnimacion1.Color2 = System.Drawing.Color.Empty
        Me.HhAnimacion1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhAnimacion1.Intervalo = 0
        Me.HhAnimacion1.Location = New System.Drawing.Point(0, 0)
        Me.HhAnimacion1.Name = "HhAnimacion1"
        Me.HhAnimacion1.PasoActual = 0
        Me.HhAnimacion1.Pasos = 0
        Me.HhAnimacion1.Size = New System.Drawing.Size(16, 16)
        Me.HhAnimacion1.TabIndex = 0
        Me.HhAnimacion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HhAnimacion2
        '
        Me.HhAnimacion2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhAnimacion2.Color1 = System.Drawing.Color.Empty
        Me.HhAnimacion2.Color2 = System.Drawing.Color.Empty
        Me.HhAnimacion2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhAnimacion2.Intervalo = 0
        Me.HhAnimacion2.Location = New System.Drawing.Point(22, 0)
        Me.HhAnimacion2.Name = "HhAnimacion2"
        Me.HhAnimacion2.PasoActual = 0
        Me.HhAnimacion2.Pasos = 0
        Me.HhAnimacion2.Size = New System.Drawing.Size(16, 16)
        Me.HhAnimacion2.TabIndex = 9
        Me.HhAnimacion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Reloj"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HhBooleanLabel1
        '
        Me.HhBooleanLabel1.AutoActualizar = False
        Me.HhBooleanLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhBooleanLabel1.DireccionLectura = Nothing
        Me.HhBooleanLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhBooleanLabel1.Link = Nothing
        Me.HhBooleanLabel1.Location = New System.Drawing.Point(132, 558)
        Me.HhBooleanLabel1.MinimumSize = New System.Drawing.Size(100, 0)
        Me.HhBooleanLabel1.Name = "HhBooleanLabel1"
        Me.HhBooleanLabel1.Size = New System.Drawing.Size(100, 47)
        Me.HhBooleanLabel1.TabIndex = 11
        Me.HhBooleanLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhBooleanLabel1.TextoFalso = Nothing
        Me.HhBooleanLabel1.TextoVerdadero = Nothing
        Me.HhBooleanLabel1.Valor = False
        '
        'HhBooleanLabel2
        '
        Me.HhBooleanLabel2.AutoActualizar = False
        Me.HhBooleanLabel2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhBooleanLabel2.DireccionLectura = Nothing
        Me.HhBooleanLabel2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhBooleanLabel2.Link = Nothing
        Me.HhBooleanLabel2.Location = New System.Drawing.Point(188, 575)
        Me.HhBooleanLabel2.MinimumSize = New System.Drawing.Size(100, 0)
        Me.HhBooleanLabel2.Name = "HhBooleanLabel2"
        Me.HhBooleanLabel2.Size = New System.Drawing.Size(100, 30)
        Me.HhBooleanLabel2.TabIndex = 12
        Me.HhBooleanLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhBooleanLabel2.TextoFalso = Nothing
        Me.HhBooleanLabel2.TextoVerdadero = Nothing
        Me.HhBooleanLabel2.Valor = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Button5, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Button7, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Button6, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HhMomentaryButton2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button3, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(269, 575)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox1, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(527, 575)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.HhLabel3)
        Me.GroupBox1.Controls.Add(Me.HhLabel2)
        Me.GroupBox1.Controls.Add(Me.HhLabel1)
        Me.GroupBox1.Controls.Add(Me.HhCharacterDisplay3)
        Me.GroupBox1.Controls.Add(Me.HhCharacterDisplay2)
        Me.GroupBox1.Controls.Add(Me.HhCharacterDisplay1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 405)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 167)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Info"
        '
        'HhLabel3
        '
        Me.HhLabel3.AutoActualizar = False
        Me.HhLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.HhLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel3.DireccionLectura = Nothing
        Me.HhLabel3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.HhLabel3.Link = Nothing
        Me.HhLabel3.Location = New System.Drawing.Point(43, 106)
        Me.HhLabel3.LongitudTexto = 0
        Me.HhLabel3.Name = "HhLabel3"
        Me.HhLabel3.Size = New System.Drawing.Size(200, 41)
        Me.HhLabel3.TabIndex = 7
        Me.HhLabel3.Text = "PLC"
        Me.HhLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel3.Texto = "PLC"
        Me.HhLabel3.Tooltip = Nothing
        '
        'HhLabel2
        '
        Me.HhLabel2.AutoActualizar = False
        Me.HhLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.HhLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel2.DireccionLectura = Nothing
        Me.HhLabel2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.HhLabel2.Link = Nothing
        Me.HhLabel2.Location = New System.Drawing.Point(43, 61)
        Me.HhLabel2.LongitudTexto = 0
        Me.HhLabel2.Name = "HhLabel2"
        Me.HhLabel2.Size = New System.Drawing.Size(200, 41)
        Me.HhLabel2.TabIndex = 6
        Me.HhLabel2.Text = "PC"
        Me.HhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel2.Texto = "PC"
        Me.HhLabel2.Tooltip = Nothing
        '
        'HhLabel1
        '
        Me.HhLabel1.AutoActualizar = False
        Me.HhLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.HhLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel1.DireccionLectura = Nothing
        Me.HhLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(153, Byte), Integer))
        Me.HhLabel1.Link = Nothing
        Me.HhLabel1.Location = New System.Drawing.Point(43, 16)
        Me.HhLabel1.LongitudTexto = 0
        Me.HhLabel1.Name = "HhLabel1"
        Me.HhLabel1.Size = New System.Drawing.Size(200, 41)
        Me.HhLabel1.TabIndex = 5
        Me.HhLabel1.Text = "Terminal"
        Me.HhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel1.Texto = "Terminal"
        Me.HhLabel1.Tooltip = Nothing
        '
        'HhCharacterDisplay3
        '
        Me.HhCharacterDisplay3.AutoActualizar = False
        Me.HhCharacterDisplay3.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.HhCharacterDisplay3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhCharacterDisplay3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhCharacterDisplay3.DireccionLectura = Nothing
        Me.HhCharacterDisplay3.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhCharacterDisplay3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.HhCharacterDisplay3.Link = Nothing
        Me.HhCharacterDisplay3.Location = New System.Drawing.Point(249, 106)
        Me.HhCharacterDisplay3.LongitudTexto = 0
        Me.HhCharacterDisplay3.Name = "HhCharacterDisplay3"
        Me.HhCharacterDisplay3.Size = New System.Drawing.Size(197, 41)
        Me.HhCharacterDisplay3.TabIndex = 4
        Me.HhCharacterDisplay3.Tag = "PLC:"
        Me.HhCharacterDisplay3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhCharacterDisplay3.Texto = Nothing
        Me.HhCharacterDisplay3.Tooltip = Nothing
        '
        'HhCharacterDisplay2
        '
        Me.HhCharacterDisplay2.AutoActualizar = False
        Me.HhCharacterDisplay2.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.HhCharacterDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhCharacterDisplay2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhCharacterDisplay2.DireccionLectura = Nothing
        Me.HhCharacterDisplay2.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhCharacterDisplay2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.HhCharacterDisplay2.Link = Nothing
        Me.HhCharacterDisplay2.Location = New System.Drawing.Point(249, 61)
        Me.HhCharacterDisplay2.LongitudTexto = 0
        Me.HhCharacterDisplay2.Name = "HhCharacterDisplay2"
        Me.HhCharacterDisplay2.Size = New System.Drawing.Size(197, 41)
        Me.HhCharacterDisplay2.TabIndex = 2
        Me.HhCharacterDisplay2.Tag = "PC:"
        Me.HhCharacterDisplay2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhCharacterDisplay2.Texto = Nothing
        Me.HhCharacterDisplay2.Tooltip = Nothing
        '
        'HhCharacterDisplay1
        '
        Me.HhCharacterDisplay1.AutoActualizar = False
        Me.HhCharacterDisplay1.BackColor = System.Drawing.Color.FromArgb(CType(CType(145, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.HhCharacterDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhCharacterDisplay1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhCharacterDisplay1.DireccionLectura = Nothing
        Me.HhCharacterDisplay1.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhCharacterDisplay1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.HhCharacterDisplay1.Link = Nothing
        Me.HhCharacterDisplay1.Location = New System.Drawing.Point(249, 16)
        Me.HhCharacterDisplay1.LongitudTexto = 0
        Me.HhCharacterDisplay1.Name = "HhCharacterDisplay1"
        Me.HhCharacterDisplay1.Size = New System.Drawing.Size(197, 41)
        Me.HhCharacterDisplay1.TabIndex = 0
        Me.HhCharacterDisplay1.Tag = "Terminal:"
        Me.HhCharacterDisplay1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhCharacterDisplay1.Texto = Nothing
        Me.HhCharacterDisplay1.Tooltip = Nothing
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 575)
        Me.SplitContainer1.SplitterDistance = 527
        Me.SplitContainer1.TabIndex = 14
        Me.SplitContainer1.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Lavadora.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(521, 396)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button5.AutoActualizar = False
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button5.DireccionEscritura = Nothing
        Me.Button5.DireccionLectura = Nothing
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Link = Nothing
        Me.Button5.Location = New System.Drawing.Point(17, 169)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(100, 90)
        Me.Button5.TabIndex = 5
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.Texto = Nothing
        Me.Button5.Tooltip = Nothing
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button7.AutoActualizar = False
        Me.Button7.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button7.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button7.DireccionEscritura = Nothing
        Me.Button7.DireccionLectura = Nothing
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button7.Image = Global.Lavadora.My.Resources.Resources.cog
        Me.Button7.Link = Nothing
        Me.Button7.Location = New System.Drawing.Point(17, 457)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(100, 90)
        Me.Button7.TabIndex = 11
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.Texto = Nothing
        Me.Button7.Tooltip = Nothing
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button6.AutoActualizar = False
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button6.DireccionEscritura = Nothing
        Me.Button6.DireccionLectura = Nothing
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.Link = Nothing
        Me.Button6.Location = New System.Drawing.Point(17, 312)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 90)
        Me.Button6.TabIndex = 12
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.Texto = Nothing
        Me.Button6.Tooltip = Nothing
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(151, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 15
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = Nothing
        Me.Button1.Tooltip = Nothing
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton1
        '
        Me.HhMomentaryButton1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton1.AutoActualizar = False
        Me.HhMomentaryButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.HhMomentaryButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton1.DireccionEscritura = Nothing
        Me.HhMomentaryButton1.DireccionLectura = Nothing
        Me.HhMomentaryButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HhMomentaryButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhMomentaryButton1.Image = CType(resources.GetObject("HhMomentaryButton1.Image"), System.Drawing.Image)
        Me.HhMomentaryButton1.Link = Nothing
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(17, 26)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 16
        Me.HhMomentaryButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton1.Texto = Nothing
        Me.HhMomentaryButton1.Tooltip = Nothing
        Me.HhMomentaryButton1.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton2
        '
        Me.HhMomentaryButton2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HhMomentaryButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton2.AutoActualizar = False
        Me.HhMomentaryButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.HhMomentaryButton2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton2.DireccionEscritura = Nothing
        Me.HhMomentaryButton2.DireccionLectura = Nothing
        Me.HhMomentaryButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.HhMomentaryButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhMomentaryButton2.Image = CType(resources.GetObject("HhMomentaryButton2.Image"), System.Drawing.Image)
        Me.HhMomentaryButton2.Link = Nothing
        Me.HhMomentaryButton2.Location = New System.Drawing.Point(151, 26)
        Me.HhMomentaryButton2.Name = "HhMomentaryButton2"
        Me.HhMomentaryButton2.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton2.TabIndex = 17
        Me.HhMomentaryButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton2.Texto = Nothing
        Me.HhMomentaryButton2.Tooltip = Nothing
        Me.HhMomentaryButton2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button3.AutoActualizar = False
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button3.DireccionEscritura = Nothing
        Me.Button3.DireccionLectura = Nothing
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button3.Image = Global.Lavadora.My.Resources.Resources.setting_tools
        Me.Button3.Link = Nothing
        Me.Button3.Location = New System.Drawing.Point(151, 312)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 90)
        Me.Button3.TabIndex = 14
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.Texto = Nothing
        Me.Button3.Tooltip = Nothing
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FormLavadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.HhBooleanLabel2)
        Me.Controls.Add(Me.HhBooleanLabel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HhAnimacion2)
        Me.Controls.Add(Me.HhAnimacion1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLavadora"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Lavadora"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HhAnimacion1 As hhAnimacion.hhAnimacion
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents HhAnimacion2 As hhAnimacion.hhAnimacion
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HhBooleanLabel1 As hhBooleanLabel.hhBooleanLabel
    Friend WithEvents HhBooleanLabel2 As hhBooleanLabel.hhBooleanLabel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Button5 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button7 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button6 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton2 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button3 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents HhCharacterDisplay3 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents HhCharacterDisplay2 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents HhCharacterDisplay1 As hhCharacterDisplay.hhCharacterDisplay
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents HhLabel3 As hhLabel.hhLabel
    Friend WithEvents HhLabel2 As hhLabel.hhLabel
    Friend WithEvents HhLabel1 As hhLabel.hhLabel
End Class
