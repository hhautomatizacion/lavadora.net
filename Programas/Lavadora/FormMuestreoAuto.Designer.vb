<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMuestreoAuto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMuestreoAuto))
        Me.Button1 = New hhMomentaryButton.hhMomentaryButton()
        Me.HhMomentaryButton1 = New hhMomentaryButton.hhMomentaryButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Button1.AutoActualizar = False
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Button1.DireccionEscritura = Nothing
        Me.Button1.DireccionLectura = Nothing
        Me.Button1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Link = Nothing
        Me.Button1.Location = New System.Drawing.Point(258, 473)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 90)
        Me.Button1.TabIndex = 0
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Button1.Texto = Nothing
        Me.Button1.UseVisualStyleBackColor = True
        '
        'HhMomentaryButton1
        '
        Me.HhMomentaryButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.HhMomentaryButton1.AutoActualizar = False
        Me.HhMomentaryButton1.Cursor = System.Windows.Forms.Cursors.Cross
        Me.HhMomentaryButton1.DireccionEscritura = Nothing
        Me.HhMomentaryButton1.DireccionLectura = Nothing
        Me.HhMomentaryButton1.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.HhMomentaryButton1.Image = CType(resources.GetObject("HhMomentaryButton1.Image"), System.Drawing.Image)
        Me.HhMomentaryButton1.Link = Nothing
        Me.HhMomentaryButton1.Location = New System.Drawing.Point(152, 473)
        Me.HhMomentaryButton1.Name = "HhMomentaryButton1"
        Me.HhMomentaryButton1.Size = New System.Drawing.Size(100, 90)
        Me.HhMomentaryButton1.TabIndex = 1
        Me.HhMomentaryButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.HhMomentaryButton1.Texto = Nothing
        Me.HhMomentaryButton1.UseVisualStyleBackColor = True
        '
        'FormMuestreoAuto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 575)
        Me.Controls.Add(Me.HhMomentaryButton1)
        Me.Controls.Add(Me.Button1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormMuestreoAuto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "FormMuestreoAuto"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As hhMomentaryButton.hhMomentaryButton
    Friend WithEvents HhMomentaryButton1 As hhMomentaryButton.hhMomentaryButton
End Class
