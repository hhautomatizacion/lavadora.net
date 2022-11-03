<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJetAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormJetAuto))
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhLabel1 = New hhLabel.hhLabel()
        Me.HhToggleButton1 = New hhToggleButton.hhToggleButton()
        Me.SuspendLayout()
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
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(154, 474)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 9
        Me.HhMomentaryButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.HhMomentaryButton1.Texto = Nothing
        Me.HhMomentaryButton1.UseVisualStyleBackColor = True
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
        Me.Button1.Location = New System.Drawing.Point(260, 474)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = Nothing
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhLabel1
        '
        Me.HhLabel1.AutoActualizar = False
        Me.HhLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.HhLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HhLabel1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhLabel1.DireccionLectura = Nothing
        Me.HhLabel1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HhLabel1.Link = Nothing
        Me.HhLabel1.Location = New System.Drawing.Point(16, 12)
        Me.HhLabel1.LongitudTexto = 0
        Me.HhLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HhLabel1.Name = "HhLabel1"
        Me.HhLabel1.Size = New System.Drawing.Size(188, 45)
        Me.HhLabel1.TabIndex = 25
        Me.HhLabel1.Text = "Easy jet (Up)"
        Me.HhLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhLabel1.Texto = "Easy jet (Up)"
        Me.HhLabel1.Tooltip = Nothing
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
        Me.HhToggleButton1.Location = New System.Drawing.Point(209, 12)
        Me.HhToggleButton1.Name = "HhToggleButton1"
        Me.HhToggleButton1.Size = New System.Drawing.Size(45, 45)
        Me.HhToggleButton1.TabIndex = 24
        Me.HhToggleButton1.Tooltip = Nothing
        Me.HhToggleButton1.UseVisualStyleBackColor = True
        '
        'FormJetAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 575)
        Me.Controls.Add(Me.HhLabel1)
        Me.Controls.Add(Me.HhToggleButton1)
        Me.Controls.Add(Me.HhMomentaryButton1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FormJetAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormJetAuto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhLabel1 As hhLabel.hhLabel
    Friend WithEvents HhToggleButton1 As hhToggleButton.hhToggleButton
End Class
