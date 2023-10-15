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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdescricao = New System.Windows.Forms.TextBox()
        Me.txtmarca = New System.Windows.Forms.TextBox()
        Me.txtaplicacao = New System.Windows.Forms.TextBox()
        Me.txtcodigodebarras = New System.Windows.Forms.TextBox()
        Me.btnsalva = New System.Windows.Forms.Button()
        Me.btncancela = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descrição"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Marca"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Aplicação"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Código de barras"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(98, 42)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(75, 20)
        Me.txtid.TabIndex = 5
        '
        'txtdescricao
        '
        Me.txtdescricao.Location = New System.Drawing.Point(128, 87)
        Me.txtdescricao.Name = "txtdescricao"
        Me.txtdescricao.Size = New System.Drawing.Size(195, 20)
        Me.txtdescricao.TabIndex = 6
        '
        'txtmarca
        '
        Me.txtmarca.Location = New System.Drawing.Point(128, 127)
        Me.txtmarca.Name = "txtmarca"
        Me.txtmarca.Size = New System.Drawing.Size(195, 20)
        Me.txtmarca.TabIndex = 7
        '
        'txtaplicacao
        '
        Me.txtaplicacao.Location = New System.Drawing.Point(128, 172)
        Me.txtaplicacao.Name = "txtaplicacao"
        Me.txtaplicacao.Size = New System.Drawing.Size(195, 20)
        Me.txtaplicacao.TabIndex = 8
        '
        'txtcodigodebarras
        '
        Me.txtcodigodebarras.Location = New System.Drawing.Point(149, 211)
        Me.txtcodigodebarras.Name = "txtcodigodebarras"
        Me.txtcodigodebarras.Size = New System.Drawing.Size(174, 20)
        Me.txtcodigodebarras.TabIndex = 9
        '
        'btnsalva
        '
        Me.btnsalva.Location = New System.Drawing.Point(59, 274)
        Me.btnsalva.Name = "btnsalva"
        Me.btnsalva.Size = New System.Drawing.Size(75, 23)
        Me.btnsalva.TabIndex = 10
        Me.btnsalva.Text = "Salvar"
        Me.btnsalva.UseVisualStyleBackColor = True
        '
        'btncancela
        '
        Me.btncancela.Location = New System.Drawing.Point(188, 274)
        Me.btncancela.Name = "btncancela"
        Me.btncancela.Size = New System.Drawing.Size(75, 23)
        Me.btncancela.TabIndex = 11
        Me.btncancela.Text = "Cancelar"
        Me.btncancela.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btncancela)
        Me.Controls.Add(Me.btnsalva)
        Me.Controls.Add(Me.txtcodigodebarras)
        Me.Controls.Add(Me.txtaplicacao)
        Me.Controls.Add(Me.txtmarca)
        Me.Controls.Add(Me.txtdescricao)
        Me.Controls.Add(Me.txtid)
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
    Friend WithEvents txtid As TextBox
    Friend WithEvents txtdescricao As TextBox
    Friend WithEvents txtmarca As TextBox
    Friend WithEvents txtaplicacao As TextBox
    Friend WithEvents txtcodigodebarras As TextBox
    Friend WithEvents btnsalva As Button
    Friend WithEvents btncancela As Button
End Class
