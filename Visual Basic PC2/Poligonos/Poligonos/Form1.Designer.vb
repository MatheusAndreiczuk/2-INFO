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
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtBase = New System.Windows.Forms.TextBox()
        Me.btnAreaTriangulo = New System.Windows.Forms.Button()
        Me.btnPerimetro = New System.Windows.Forms.Button()
        Me.btnAreaRetangulo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Digite a altura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Digite a base"
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(108, 29)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(186, 23)
        Me.txtAltura.TabIndex = 2
        '
        'txtBase
        '
        Me.txtBase.Location = New System.Drawing.Point(108, 65)
        Me.txtBase.Name = "txtBase"
        Me.txtBase.Size = New System.Drawing.Size(186, 23)
        Me.txtBase.TabIndex = 3
        '
        'btnAreaTriangulo
        '
        Me.btnAreaTriangulo.Location = New System.Drawing.Point(14, 129)
        Me.btnAreaTriangulo.Name = "btnAreaTriangulo"
        Me.btnAreaTriangulo.Size = New System.Drawing.Size(124, 30)
        Me.btnAreaTriangulo.TabIndex = 4
        Me.btnAreaTriangulo.Text = "Área do triângulo"
        Me.btnAreaTriangulo.UseVisualStyleBackColor = True
        '
        'btnPerimetro
        '
        Me.btnPerimetro.Location = New System.Drawing.Point(167, 129)
        Me.btnPerimetro.Name = "btnPerimetro"
        Me.btnPerimetro.Size = New System.Drawing.Size(102, 29)
        Me.btnPerimetro.TabIndex = 5
        Me.btnPerimetro.Text = "Perímetro"
        Me.btnPerimetro.UseVisualStyleBackColor = True
        '
        'btnAreaRetangulo
        '
        Me.btnAreaRetangulo.Location = New System.Drawing.Point(301, 129)
        Me.btnAreaRetangulo.Name = "btnAreaRetangulo"
        Me.btnAreaRetangulo.Size = New System.Drawing.Size(129, 29)
        Me.btnAreaRetangulo.TabIndex = 6
        Me.btnAreaRetangulo.Text = "Área do retângulo"
        Me.btnAreaRetangulo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(-13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 15)
        Me.Label3.TabIndex = 7
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Location = New System.Drawing.Point(23, 206)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 15)
        Me.lblResultado.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAreaRetangulo)
        Me.Controls.Add(Me.btnPerimetro)
        Me.Controls.Add(Me.btnAreaTriangulo)
        Me.Controls.Add(Me.txtBase)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAltura As TextBox
    Friend WithEvents txtBase As TextBox
    Friend WithEvents btnAreaTriangulo As Button
    Friend WithEvents btnPerimetro As Button
    Friend WithEvents btnAreaRetangulo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResultado As Label
End Class
