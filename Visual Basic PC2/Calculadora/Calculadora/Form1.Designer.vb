<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtValor2 = New System.Windows.Forms.TextBox()
        Me.bSoma = New System.Windows.Forms.Button()
        Me.bSubtrai = New System.Windows.Forms.Button()
        Me.bMultiplica = New System.Windows.Forms.Button()
        Me.bDivide = New System.Windows.Forms.Button()
        Me.lResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite o primeiro valor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digite o segundo valor"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(199, 20)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(100, 23)
        Me.txtValor1.TabIndex = 2
        '
        'txtValor2
        '
        Me.txtValor2.Location = New System.Drawing.Point(199, 49)
        Me.txtValor2.Name = "txtValor2"
        Me.txtValor2.Size = New System.Drawing.Size(100, 23)
        Me.txtValor2.TabIndex = 3
        '
        'bSoma
        '
        Me.bSoma.Location = New System.Drawing.Point(29, 110)
        Me.bSoma.Name = "bSoma"
        Me.bSoma.Size = New System.Drawing.Size(75, 23)
        Me.bSoma.TabIndex = 4
        Me.bSoma.Text = "Soma"
        Me.bSoma.UseVisualStyleBackColor = True
        '
        'bSubtrai
        '
        Me.bSubtrai.Location = New System.Drawing.Point(131, 110)
        Me.bSubtrai.Name = "bSubtrai"
        Me.bSubtrai.Size = New System.Drawing.Size(75, 23)
        Me.bSubtrai.TabIndex = 5
        Me.bSubtrai.Text = "Subtração"
        Me.bSubtrai.UseVisualStyleBackColor = True
        '
        'bMultiplica
        '
        Me.bMultiplica.Location = New System.Drawing.Point(238, 110)
        Me.bMultiplica.Name = "bMultiplica"
        Me.bMultiplica.Size = New System.Drawing.Size(92, 23)
        Me.bMultiplica.TabIndex = 6
        Me.bMultiplica.Text = "Multiplicação"
        Me.bMultiplica.UseVisualStyleBackColor = True
        '
        'bDivide
        '
        Me.bDivide.Location = New System.Drawing.Point(363, 110)
        Me.bDivide.Name = "bDivide"
        Me.bDivide.Size = New System.Drawing.Size(75, 23)
        Me.bDivide.TabIndex = 7
        Me.bDivide.Text = "Divisão"
        Me.bDivide.UseVisualStyleBackColor = True
        '
        'lResultado
        '
        Me.lResultado.AutoSize = True
        Me.lResultado.Location = New System.Drawing.Point(29, 175)
        Me.lResultado.Name = "lResultado"
        Me.lResultado.Size = New System.Drawing.Size(0, 15)
        Me.lResultado.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lResultado)
        Me.Controls.Add(Me.bDivide)
        Me.Controls.Add(Me.bMultiplica)
        Me.Controls.Add(Me.bSubtrai)
        Me.Controls.Add(Me.bSoma)
        Me.Controls.Add(Me.txtValor2)
        Me.Controls.Add(Me.txtValor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValor1 As TextBox
    Friend WithEvents txtValor2 As TextBox
    Friend WithEvents bSoma As Button
    Friend WithEvents bSubtrai As Button
    Friend WithEvents bMultiplica As Button
    Friend WithEvents bDivide As Button
    Friend WithEvents lResultado As Label
End Class
