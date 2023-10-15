<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVeiculo
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.txtplaca = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtmodelo = New System.Windows.Forms.TextBox()
        Me.txtano = New System.Windows.Forms.TextBox()
        Me.txtchassi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Veículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Placa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(31, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Modelo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Ano"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(31, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Chassi"
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(34, 305)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnsalvar.TabIndex = 6
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(149, 305)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 7
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(114, 31)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(71, 20)
        Me.txtcodigo.TabIndex = 8
        '
        'txtplaca
        '
        Me.txtplaca.Location = New System.Drawing.Point(85, 70)
        Me.txtplaca.Name = "txtplaca"
        Me.txtplaca.Size = New System.Drawing.Size(100, 20)
        Me.txtplaca.TabIndex = 9
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(85, 114)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(100, 20)
        Me.txtmarca.TabIndex = 10
        '
        'txtmodelo
        '
        Me.txtmodelo.Location = New System.Drawing.Point(85, 158)
        Me.txtmodelo.Name = "txtmodelo"
        Me.txtmodelo.Size = New System.Drawing.Size(100, 20)
        Me.txtmodelo.TabIndex = 11
        '
        'txtano
        '
        Me.txtano.Location = New System.Drawing.Point(85, 201)
        Me.txtano.Name = "txtano"
        Me.txtano.Size = New System.Drawing.Size(100, 20)
        Me.txtano.TabIndex = 12
        '
        'txtchassi
        '
        Me.txtchassi.Location = New System.Drawing.Point(85, 242)
        Me.txtchassi.Name = "txtchassi"
        Me.txtchassi.Size = New System.Drawing.Size(100, 20)
        Me.txtchassi.TabIndex = 13
        '
        'FormVeiculo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtchassi)
        Me.Controls.Add(Me.txtano)
        Me.Controls.Add(Me.txtmodelo)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtplaca)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormVeiculo"
        Me.Text = "FormVeiculo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents txtcodigo As TextBox
    Friend WithEvents txtplaca As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents txtmodelo As TextBox
    Friend WithEvents txtano As TextBox
    Friend WithEvents txtchassi As TextBox
End Class
