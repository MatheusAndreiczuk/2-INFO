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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.txtfabricante = New System.Windows.Forms.TextBox()
        Me.txtnumserie = New System.Windows.Forms.TextBox()
        Me.txtnumpatrimonio = New System.Windows.Forms.TextBox()
        Me.txtlocalizacao = New System.Windows.Forms.TextBox()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fabricante"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 166)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Num Série"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Num Patrimônio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 253)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Localização"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(70, 39)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(61, 20)
        Me.txtid.TabIndex = 6
        '
        'txtdescricao
        '
        Me.txtdescricao.Location = New System.Drawing.Point(102, 83)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(147, 20)
        Me.txtdescricao.TabIndex = 7
        '
        'txtfabricante
        '
        Me.txtfabricante.Location = New System.Drawing.Point(102, 122)
        Me.txtfabricante.Name = "txtfabricante"
        Me.txtfabricante.Size = New System.Drawing.Size(147, 20)
        Me.txtfabricante.TabIndex = 8
        '
        'txtnumserie
        '
        Me.txtnumserie.Location = New System.Drawing.Point(102, 163)
        Me.txtnumserie.Name = "txtnumserie"
        Me.txtnumserie.Size = New System.Drawing.Size(147, 20)
        Me.txtnumserie.TabIndex = 9
        '
        'txtnumpatrimonio
        '
        Me.txtnumpatrimonio.Location = New System.Drawing.Point(121, 205)
        Me.txtnumpatrimonio.Name = "txtnumpatrimonio"
        Me.txtnumpatrimonio.Size = New System.Drawing.Size(128, 20)
        Me.txtnumpatrimonio.TabIndex = 10
        '
        'txtlocalizacao
        '
        Me.txtlocalizacao.Location = New System.Drawing.Point(121, 250)
        Me.txtlocalizacao.Name = "txtlocalizacao"
        Me.txtlocalizacao.Size = New System.Drawing.Size(128, 20)
        Me.txtlocalizacao.TabIndex = 11
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(37, 310)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(65, 24)
        Me.btnsalvar.TabIndex = 12
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(121, 310)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(65, 24)
        Me.btncancelar.TabIndex = 13
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.txtlocalizacao)
        Me.Controls.Add(Me.txtnumpatrimonio)
        Me.Controls.Add(Me.txtnumserie)
        Me.Controls.Add(Me.txtfabricante)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
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
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtdescricao As TextBox
    Friend WithEvents txtfabricante As TextBox
    Friend WithEvents txtnumserie As TextBox
    Friend WithEvents txtnumpatrimonio As TextBox
    Friend WithEvents txtlocalizacao As TextBox
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btncancelar As Button
End Class
