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
        Me.Button1.Location = New System.Drawing.Point(688, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 2
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button1.Texto = Nothing
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
        Me.HhNumericEntry2.Font = New System.Drawing.Font("Verdana", 14.0!)
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
        Me.HhNumericEntry1.Font = New System.Drawing.Font("Verdana", 14.0!)
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
        Me.HhNumericEntry3.Font = New System.Drawing.Font("Verdana", 14.0!)
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
        Me.HhLabel1.Font = New System.Drawing.Font("Segoe Script", 12.0!)
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
        Me.HhLabel2.Font = New System.Drawing.Font("Segoe Script", 12.0!)
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
        Me.HhLabel3.Font = New System.Drawing.Font("Segoe Script", 12.0!)
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
        'FormConfQuimicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 575)
        Me.Controls.Add(Me.HhLabel3)
        Me.Controls.Add(Me.HhLabel2)
        Me.Controls.Add(Me.HhLabel1)
        Me.Controls.Add(Me.HhNumericEntry3)
        Me.Controls.Add(Me.HhNumericEntry2)
        Me.Controls.Add(Me.HhNumericEntry1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormConfQuimicos"
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
End Class
