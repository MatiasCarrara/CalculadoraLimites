<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnForma1 = New System.Windows.Forms.Button()
        Me.btnForma2 = New System.Windows.Forms.Button()
        Me.btnForma3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGreen
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnForma3)
        Me.Panel1.Controls.Add(Me.btnForma2)
        Me.Panel1.Controls.Add(Me.btnForma1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-14, -15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(605, 372)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Limites"
        '
        'btnForma1
        '
        Me.btnForma1.Location = New System.Drawing.Point(148, 122)
        Me.btnForma1.Name = "btnForma1"
        Me.btnForma1.Size = New System.Drawing.Size(75, 23)
        Me.btnForma1.TabIndex = 1
        Me.btnForma1.Text = "Forma 1"
        Me.btnForma1.UseVisualStyleBackColor = True
        '
        'btnForma2
        '
        Me.btnForma2.Location = New System.Drawing.Point(148, 151)
        Me.btnForma2.Name = "btnForma2"
        Me.btnForma2.Size = New System.Drawing.Size(75, 23)
        Me.btnForma2.TabIndex = 2
        Me.btnForma2.Text = "Forma 2"
        Me.btnForma2.UseVisualStyleBackColor = True
        '
        'btnForma3
        '
        Me.btnForma3.Location = New System.Drawing.Point(148, 180)
        Me.btnForma3.Name = "btnForma3"
        Me.btnForma3.Size = New System.Drawing.Size(75, 23)
        Me.btnForma3.TabIndex = 3
        Me.btnForma3.Text = "Forma 3"
        Me.btnForma3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Calcular limite de la ..."
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 334)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "menu"
        Me.Text = "menu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnForma3 As Button
    Friend WithEvents btnForma2 As Button
    Friend WithEvents btnForma1 As Button
    Friend WithEvents Label1 As Label
End Class
