<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFinAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormFinAuto))
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
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
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(206, 584)
        Me.HhMomentaryButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(133, 111)
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
        Me.Button1.Location = New System.Drawing.Point(347, 584)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 111)
        Me.Button1.TabIndex = 8
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.Texto = Nothing
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FormFinAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 708)
        Me.Controls.Add(Me.HhMomentaryButton1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormFinAuto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormFinAuto"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
End Class
