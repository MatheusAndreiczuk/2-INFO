<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnsalva = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtcargahoraria = New System.Windows.Forms.TextBox()
        Me.txtprofessor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Carga horária"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Professor"
        '
        'btnsalva
        '
        Me.btnsalva.Location = New System.Drawing.Point(40, 229)
        Me.btnsalva.Name = "btnsalva"
        Me.btnsalva.Size = New System.Drawing.Size(78, 25)
        Me.btnsalva.TabIndex = 4
        Me.btnsalva.Text = "Salvar"
        Me.btnsalva.UseVisualStyleBackColor = True
        '
        'btncancela
        '
        Me.btncancela.Location = New System.Drawing.Point(165, 229)
        Me.btncancela.Name = "btncancela"
        Me.btncancela.Size = New System.Drawing.Size(79, 24)
        Me.btncancela.TabIndex = 5
        Me.btncancela.Text = "Cancelar"
        Me.btncancela.UseVisualStyleBackColor = True
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(107, 30)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(91, 20)
        Me.txtcodigo.TabIndex = 6
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(107, 72)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(154, 20)
        Me.txtnome.TabIndex = 7
        '
        'txtcargahoraria
        '
        Me.txtcargahoraria.Location = New System.Drawing.Point(125, 123)
        Me.txtcargahoraria.Name = "txtcargahoraria"
        Me.txtcargahoraria.Size = New System.Drawing.Size(136, 20)
        Me.txtcargahoraria.TabIndex = 8
        '
        'txtprofessor
        '
        Me.txtprofessor.Location = New System.Drawing.Point(125, 168)
        Me.txtprofessor.Name = "txtprofessor"
        Me.txtprofessor.Size = New System.Drawing.Size(136, 20)
        Me.txtprofessor.TabIndex = 9
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtprofessor)
        Me.Controls.Add(Me.txtcargahoraria)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.btncancela)
        Me.Controls.Add(Me.btnsalva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnsalva As Button
    Friend WithEvents btncancela As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtcargahoraria As TextBox
    Friend WithEvents txtprofessor As TextBox
End Class
