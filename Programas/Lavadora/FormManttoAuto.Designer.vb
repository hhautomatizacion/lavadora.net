<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMantenimientoAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMantenimientoAuto))
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhToggleButton1 = New hhToggleButton.hhToggleButton()
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhNumericEntry2 = New hhNumericEntry.hhNumericEntry()
        Me.HhNumericEntry1 = New hhNumericEntry.hhNumericEntry()
        Me.HhLabel1 = New hhLabel.hhLabel()
        Me.HhLabel2 = New hhLabel.hhLabel()
        Me.HhLabel3 = New hhLabel.hhLabel()
        Me.SuspendLayout()
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
        Me.Button1.Location = New System.Drawing.Point(258, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = Nothing
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhToggleButton1
        '
        Me.HhToggleButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhToggleButton1.AutoActualizar = False
        Me.HhToggleButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhToggleButton1.DireccionEscritura = Nothing
        Me.HhToggleButton1.DireccionLectura = Nothing
        Me.HhToggleButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.HhToggleButton1.Link = Nothing
        Me.HhToggleButton1.Location = New System.Drawing.Point(207, 11)
        Me.HhToggleButton1.Name = "HhToggleButton1"
        Me.HhToggleButton1.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton1.TabIndex = 5
        Me.HhToggleButton1.Tooltip = Nothing
        Me.HhToggleButton1.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton1
        '
        Me.HhMomentaryButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton1.AutoActualizar = False
        Me.HhMomentaryButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton1.DireccionEscritura = Nothing
        Me.HhMomentaryButton1.DireccionLectura = Nothing
        Me.HhMomentaryButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.HhMomentaryButton1.Image = CType(resources.GetObject("HhMomentaryButton1.Image"), System.Drawing.Image)
        Me.HhMomentaryButton1.Link = Nothing
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(152, 473)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 7
        Me.HhMomentaryButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton1.Texto = Nothing
        Me.HhMomentaryButton1.UseVisualStyleBackColor = True
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
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry2.Link = Nothing
        Me.HhNumericEntry2.Location = New System.Drawing.Point(208, 113)
        Me.HhNumericEntry2.Name = "HhNumericEntry2"
        Me.HhNumericEntry2.Size = New System.Drawing.Size(150, 45)
        Me.HhNumericEntry2.TabIndex = 11
        Me.HhNumericEntry2.Text = "0"
        Me.HhNumericEntry2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry2.Tooltip = Nothing
        Me.HhNumericEntry2.Unidades = Nothing
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
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 14.0!)
        Me.HhNumericEntry1.Link = Nothing
        Me.HhNumericEntry1.Location = New System.Drawing.Point(208, 62)
        Me.HhNumericEntry1.Name = "HhNumericEntry1"
        Me.HhNumericEntry1.Size = New System.Drawing.Size(150, 45)
        Me.HhNumericEntry1.TabIndex = 1
        Me.HhNumericEntry1.Text = "0"
        Me.HhNumericEntry1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.HhNumericEntry1.Tooltip = Nothing
        Me.HhNumericEntry1.Unidades = Nothing
        Me.HhNumericEntry1.Valor = 0
        Me.HhNumericEntry1.ValorMaximo = 0
        Me.HhNumericEntry1.ValorMinimo = 0
        '
        'HhLabel1
        '
        Me.HhLabel1.AutoActualizar = False
        Me.HhLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel1.DireccionLectura = Nothing
        Me.HhLabel1.Font = New System.Drawing.Font("Segoe Script", 12.0!)
        Me.HhLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel1.Link = Nothing
        Me.HhLabel1.Location = New System.Drawing.Point(14, 11)
        Me.HhLabel1.LongitudTexto = 0
        Me.HhLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel1.Name = "HhLabel1"
        Me.HhLabel1.Size = New System.Drawing.Size(188, 45)
        Me.HhLabel1.TabIndex = 14
        Me.HhLabel1.Text = "Temperatura constante"
        Me.HhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel1.Texto = "Temperatura constante"
        Me.HhLabel1.Tooltip = Nothing
        '
        'HhLabel2
        '
        Me.HhLabel2.AutoActualizar = False
        Me.HhLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel2.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel2.DireccionLectura = Nothing
        Me.HhLabel2.Font = New System.Drawing.Font("Segoe Script", 12.0!)
        Me.HhLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel2.Link = Nothing
        Me.HhLabel2.Location = New System.Drawing.Point(15, 62)
        Me.HhLabel2.LongitudTexto = 0
        Me.HhLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel2.Name = "HhLabel2"
        Me.HhLabel2.Size = New System.Drawing.Size(188, 45)
        Me.HhLabel2.TabIndex = 15
        Me.HhLabel2.Text = "Tiempo"
        Me.HhLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel2.Texto = "Tiempo"
        Me.HhLabel2.Tooltip = Nothing
        '
        'HhLabel3
        '
        Me.HhLabel3.AutoActualizar = False
        Me.HhLabel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel3.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel3.DireccionLectura = Nothing
        Me.HhLabel3.Font = New System.Drawing.Font("Segoe Script", 12.0!)
        Me.HhLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel3.Link = Nothing
        Me.HhLabel3.Location = New System.Drawing.Point(15, 113)
        Me.HhLabel3.LongitudTexto = 0
        Me.HhLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel3.Name = "HhLabel3"
        Me.HhLabel3.Size = New System.Drawing.Size(188, 45)
        Me.HhLabel3.TabIndex = 16
        Me.HhLabel3.Text = "Temperatura"
        Me.HhLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel3.Texto = "Temperatura"
        Me.HhLabel3.Tooltip = Nothing
        '
        'FormMantenimientoAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 575)
        Me.Controls.Add(Me.HhLabel3)
        Me.Controls.Add(Me.HhLabel2)
        Me.Controls.Add(Me.HhLabel1)
        Me.Controls.Add(Me.HhNumericEntry2)
        Me.Controls.Add(Me.HhMomentaryButton1)
        Me.Controls.Add(Me.HhToggleButton1)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMantenimientoAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form7"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhNumericEntry1 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhToggleButton1 As hhToggleButton.hhToggleButton
    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhNumericEntry2 As hhNumericEntry.hhNumericEntry
    Friend WithEvents HhLabel1 As hhLabel.hhLabel
    Friend WithEvents HhLabel2 As hhLabel.hhLabel
    Friend WithEvents HhLabel3 As hhLabel.hhLabel
End Class
