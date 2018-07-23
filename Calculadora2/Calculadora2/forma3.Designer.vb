<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forma3
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.btnResetear = New System.Windows.Forms.Button()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtB = New System.Windows.Forms.TextBox()
        Me.txtA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.PaleGreen
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblResultado)
        Me.Panel1.Controls.Add(Me.btnCalcular)
        Me.Panel1.Controls.Add(Me.btnResetear)
        Me.Panel1.Controls.Add(Me.txtX)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtB)
        Me.Panel1.Controls.Add(Me.txtA)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-31, -41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 418)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label5.Location = New System.Drawing.Point(136, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 31)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "√ "
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(330, 220)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 13)
        Me.lblResultado.TabIndex = 9
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(359, 288)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 8
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'btnResetear
        '
        Me.btnResetear.Location = New System.Drawing.Point(266, 289)
        Me.btnResetear.Name = "btnResetear"
        Me.btnResetear.Size = New System.Drawing.Size(75, 23)
        Me.btnResetear.TabIndex = 7
        Me.btnResetear.Text = "Resetear"
        Me.btnResetear.UseVisualStyleBackColor = True
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(321, 234)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(33, 20)
        Me.txtX.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(288, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "x -->"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(285, 220)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "lim f(x) = "
        '
        'txtB
        '
        Me.txtB.Location = New System.Drawing.Point(238, 118)
        Me.txtB.Name = "txtB"
        Me.txtB.Size = New System.Drawing.Size(33, 20)
        Me.txtB.TabIndex = 3
        '
        'txtA
        '
        Me.txtA.Location = New System.Drawing.Point(172, 118)
        Me.txtA.Name = "txtA"
        Me.txtA.Size = New System.Drawing.Size(33, 20)
        Me.txtA.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(211, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "x +"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "f(x) ="
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(478, 93)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Menu"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'forma3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 321)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "forma3"
        Me.Text = "forma3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents lblResultado As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents btnResetear As Button
    Friend WithEvents txtX As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtB As TextBox
    Friend WithEvents txtA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
