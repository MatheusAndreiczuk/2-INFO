<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVeiculoEmprestimo
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
        Me.txtidveiculo = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.btnempresta = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Veículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Cliente"
        '
        'txtidveiculo
        '
        Me.txtidveiculo.Location = New System.Drawing.Point(130, 40)
        Me.txtidveiculo.Name = "txtidveiculo"
        Me.txtidveiculo.Size = New System.Drawing.Size(73, 20)
        Me.txtidveiculo.TabIndex = 2
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(130, 85)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(73, 20)
        Me.txtidcliente.TabIndex = 3
        '
        'btnempresta
        '
        Me.btnempresta.Location = New System.Drawing.Point(57, 161)
        Me.btnempresta.Name = "btnempresta"
        Me.btnempresta.Size = New System.Drawing.Size(75, 23)
        Me.btnempresta.TabIndex = 4
        Me.btnempresta.Text = "Emprestar"
        Me.btnempresta.UseVisualStyleBackColor = True
        '
        'btncancela
        '
        Me.btncancela.Location = New System.Drawing.Point(163, 161)
        Me.btncancela.Name = "btncancela"
        Me.btncancela.Size = New System.Drawing.Size(75, 23)
        Me.btncancela.TabIndex = 5
        Me.btncancela.Text = "Cancelar"
        Me.btncancela.UseVisualStyleBackColor = True
        '
        'FormVeiculoEmprestimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 377)
        Me.Controls.Add(Me.btncancela)
        Me.Controls.Add(Me.btnempresta)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtidveiculo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormVeiculoEmprestimo"
        Me.Text = "FormVeiculoEmprestimo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtidveiculo As TextBox
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents btnempresta As Button
    Friend WithEvents btncancela As Button
End Class
