<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConfAditivos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormConfAditivos))
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhNumericEntry2 = New hhNumericEntry.hhNumericEntry()
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry()
        Me.HhNumericEntry3 = New hhNumericEntry.hhNumericEntry()
        Me.HhLabel1 = New hhLabel.hhLabel()
        Me.HhLabel2 = New hhLabel.hhLabel()
        Me.HhLabel3 = New hhLabel.hhLabel()
        Me.HhToggleButton4 = New hhToggleButton.hhToggleButton()
        Me.HhLabel4 = New hhLabel.hhLabel()
        Me.HhToggleButton1 = New hhToggleButton.hhToggleButton()
        Me.HhLabel5 = New hhLabel.hhLabel()
        Me.HhToggleButton2 = New hhToggleButton.hhToggleButton()
        Me.HhLabel6 = New hhLabel.hhLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(688, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 2
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = Nothing
        Me.Button1.Tooltip = Nothing
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.HhNumericEntry2.Factor = 1.0!
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericEntry2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhNumericEntry2.Link = Nothing
        Me.HhNumericEntry2.Location = New System.Drawing.Point(220, 95)
        Me.HhNumericEntry2.Name = "HhNumericEntry2"
        Me.HhNumericEntry2.Size = New System.Drawing.Size(220, 40)
        Me.HhNumericEntry2.TabIndex = 6
        Me.HhNumericEntry2.Text = "0"
        Me.HhNumericEntry2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry2.Tooltip = "Tiempo de enjuague|de cubeta de quimicos.|(seg)"
        Me.HhNumericEntry2.Unidades = "seg"
        Me.HhNumericEntry2.Valor = 0
        Me.HhNumericEntry2.ValorMaximo = 0
        Me.HhNumericEntry2.ValorMinimo = 0
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
        Me.HhNumericEntry1.Factor = 1.0!
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericEntry1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(220, 50)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(220, 40)
        Me.HhNumericEntry1.TabIndex = 4
        Me.HhNumericEntry1.Text = "0"
        Me.HhNumericEntry1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry1.Tooltip = "Tiempo de|introduccion de|aditivos. (seg)"
        Me.HhNumericEntry1.Unidades = "seg"
        Me.HhNumericEntry1.Valor = 0
        Me.HhNumericEntry1.ValorMaximo = 0
        Me.HhNumericEntry1.ValorMinimo = 0
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
        Me.HhNumericEntry3.Factor = 1.0!
        Me.HhNumericEntry3.Font = New System.Drawing.Font("Verdana", 18.0!)
        Me.HhNumericEntry3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhNumericEntry3.Link = Nothing
        Me.HhNumericEntry3.Location = New System.Drawing.Point(220, 162)
        Me.HhNumericEntry3.Name = "HhNumericEntry3"
        Me.HhNumericEntry3.Size = New System.Drawing.Size(220, 40)
        Me.HhNumericEntry3.TabIndex = 10
        Me.HhNumericEntry3.Text = "0"
        Me.HhNumericEntry3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry3.Tooltip = "Tiempo maximo|de cubeta de quimicos.|(seg)"
        Me.HhNumericEntry3.Unidades = "seg"
        Me.HhNumericEntry3.Valor = 0
        Me.HhNumericEntry3.ValorMaximo = 0
        Me.HhNumericEntry3.ValorMinimo = 0
        '
        'HhLabel1
        '
        Me.HhLabel1.AutoActualizar = False
        Me.HhLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel1.DireccionLectura = Nothing
        Me.HhLabel1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel1.Link = Nothing
        Me.HhLabel1.Location = New System.Drawing.Point(14, 50)
        Me.HhLabel1.LongitudTexto = 0
        Me.HhLabel1.Name = "HhLabel1"
        Me.HhLabel1.Size = New System.Drawing.Size(200, 40)
        Me.HhLabel1.TabIndex = 11
        Me.HhLabel1.Text = "Intro aditivos"
        Me.HhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel1.Texto = "Intro aditivos"
        Me.HhLabel1.Tooltip = Nothing
        '
        'HhLabel2
        '
        Me.HhLabel2.AutoActualizar = False
        Me.HhLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel2.DireccionLectura = Nothing
        Me.HhLabel2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel2.Link = Nothing
        Me.HhLabel2.Location = New System.Drawing.Point(14, 95)
        Me.HhLabel2.LongitudTexto = 0
        Me.HhLabel2.Name = "HhLabel2"
        Me.HhLabel2.Size = New System.Drawing.Size(200, 40)
        Me.HhLabel2.TabIndex = 12
        Me.HhLabel2.Text = "Enjuague aditivos"
        Me.HhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel2.Texto = "Enjuague aditivos"
        Me.HhLabel2.Tooltip = Nothing
        '
        'HhLabel3
        '
        Me.HhLabel3.AutoActualizar = False
        Me.HhLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel3.DireccionLectura = Nothing
        Me.HhLabel3.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel3.Link = Nothing
        Me.HhLabel3.Location = New System.Drawing.Point(14, 162)
        Me.HhLabel3.LongitudTexto = 0
        Me.HhLabel3.Name = "HhLabel3"
        Me.HhLabel3.Size = New System.Drawing.Size(200, 40)
        Me.HhLabel3.TabIndex = 13
        Me.HhLabel3.Text = "Tiempo maximo"
        Me.HhLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel3.Texto = "Tiempo maximo"
        Me.HhLabel3.Tooltip = Nothing
        '
        'HhToggleButton4
        '
        Me.HhToggleButton4.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton4.AutoActualizar = False
        Me.HhToggleButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.HhToggleButton4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton4.DireccionEscritura = Nothing
        Me.HhToggleButton4.DireccionLectura = Nothing
        Me.HhToggleButton4.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhToggleButton4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhToggleButton4.Link = Nothing
        Me.HhToggleButton4.Location = New System.Drawing.Point(271, 286)
        Me.HhToggleButton4.Name = "HhToggleButton4"
        Me.HhToggleButton4.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton4.TabIndex = 35
        Me.HhToggleButton4.Tooltip = Nothing
        Me.HhToggleButton4.UseVisualStyleBackColor = True
        '
        'HhLabel4
        '
        Me.HhLabel4.AutoActualizar = False
        Me.HhLabel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel4.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel4.DireccionLectura = Nothing
        Me.HhLabel4.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel4.Link = Nothing
        Me.HhLabel4.Location = New System.Drawing.Point(14, 286)
        Me.HhLabel4.LongitudTexto = 0
        Me.HhLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel4.Name = "HhLabel4"
        Me.HhLabel4.Size = New System.Drawing.Size(250, 45)
        Me.HhLabel4.TabIndex = 36
        Me.HhLabel4.Text = "Introducir a izquierda"
        Me.HhLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel4.Texto = "Introducir a izquierda"
        Me.HhLabel4.Tooltip = Nothing
        '
        'HhToggleButton1
        '
        Me.HhToggleButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton1.AutoActualizar = False
        Me.HhToggleButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.HhToggleButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton1.DireccionEscritura = Nothing
        Me.HhToggleButton1.DireccionLectura = Nothing
        Me.HhToggleButton1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhToggleButton1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhToggleButton1.Link = Nothing
        Me.HhToggleButton1.Location = New System.Drawing.Point(271, 337)
        Me.HhToggleButton1.Name = "HhToggleButton1"
        Me.HhToggleButton1.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton1.TabIndex = 37
        Me.HhToggleButton1.Tooltip = Nothing
        Me.HhToggleButton1.UseVisualStyleBackColor = True
        '
        'HhLabel5
        '
        Me.HhLabel5.AutoActualizar = False
        Me.HhLabel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel5.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel5.DireccionLectura = Nothing
        Me.HhLabel5.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel5.Link = Nothing
        Me.HhLabel5.Location = New System.Drawing.Point(14, 337)
        Me.HhLabel5.LongitudTexto = 0
        Me.HhLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel5.Name = "HhLabel5"
        Me.HhLabel5.Size = New System.Drawing.Size(250, 45)
        Me.HhLabel5.TabIndex = 38
        Me.HhLabel5.Text = "Introducir a derecha"
        Me.HhLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel5.Texto = "Introducir a derecha"
        Me.HhLabel5.Tooltip = Nothing
        '
        'HhToggleButton2
        '
        Me.HhToggleButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton2.AutoActualizar = False
        Me.HhToggleButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.HhToggleButton2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton2.DireccionEscritura = Nothing
        Me.HhToggleButton2.DireccionLectura = Nothing
        Me.HhToggleButton2.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhToggleButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HhToggleButton2.Link = Nothing
        Me.HhToggleButton2.Location = New System.Drawing.Point(271, 235)
        Me.HhToggleButton2.Name = "HhToggleButton2"
        Me.HhToggleButton2.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton2.TabIndex = 39
        Me.HhToggleButton2.Tooltip = Nothing
        Me.HhToggleButton2.UseVisualStyleBackColor = True
        '
        'HhLabel6
        '
        Me.HhLabel6.AutoActualizar = False
        Me.HhLabel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel6.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel6.DireccionLectura = Nothing
        Me.HhLabel6.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel6.Link = Nothing
        Me.HhLabel6.Location = New System.Drawing.Point(14, 235)
        Me.HhLabel6.LongitudTexto = 0
        Me.HhLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel6.Name = "HhLabel6"
        Me.HhLabel6.Size = New System.Drawing.Size(250, 45)
        Me.HhLabel6.TabIndex = 40
        Me.HhLabel6.Text = "Cubeta con sonda"
        Me.HhLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel6.Texto = "Cubeta con sonda"
        Me.HhLabel6.Tooltip = Nothing
        '
        'FormConfAditivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhToggleButton2)
        Me.Controls.Add(Me.HhLabel6)
        Me.Controls.Add(Me.HhToggleButton1)
        Me.Controls.Add(Me.HhLabel5)
        Me.Controls.Add(Me.HhToggleButton4)
        Me.Controls.Add(Me.HhLabel4)
        Me.Controls.Add(Me.HhLabel3)
        Me.Controls.Add(Me.HhLabel2)
        Me.Controls.Add(Me.HhLabel1)
        Me.Controls.Add(Me.HhNumericEntry3)
        Me.Controls.Add(Me.HhNumericEntry2)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfAditivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormConfQuimicos"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry2 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhNumericEntry3 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhLabel1 As hhLabel.hhLabel
    Friend WithEvents HhLabel2 As hhLabel.hhLabel
    Friend WithEvents HhLabel3 As hhLabel.hhLabel
    Friend WithEvents HhToggleButton4 As hhToggleButton.hhToggleButton
    Friend WithEvents HhLabel4 As hhLabel.hhLabel
    Friend WithEvents HhToggleButton1 As hhToggleButton.hhToggleButton
    Friend WithEvents HhLabel5 As hhLabel.hhLabel
    Friend WithEvents HhToggleButton2 As hhToggleButton.hhToggleButton
    Friend WithEvents HhLabel6 As hhLabel.hhLabel
End Class
