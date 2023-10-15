<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtnome = New System.Windows.Forms.TextBox()
        Me.txtsenha = New System.Windows.Forms.TextBox()
        Me.btnnovo = New System.Windows.Forms.Button()
        Me.btnsalvar = New System.Windows.Forms.Button()
        Me.btnexcluir = New System.Windows.Forms.Button()
        Me.btnlocalizar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Senha"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(101, 27)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(140, 20)
        Me.txtuser.TabIndex = 3
        '
        'txtnome
        '
        Me.txtnome.Location = New System.Drawing.Point(101, 70)
        Me.txtnome.Name = "txtnome"
        Me.txtnome.Size = New System.Drawing.Size(140, 20)
        Me.txtnome.TabIndex = 4
        '
        'txtsenha
        '
        Me.txtsenha.Location = New System.Drawing.Point(101, 114)
        Me.txtsenha.Name = "txtsenha"
        Me.txtsenha.Size = New System.Drawing.Size(140, 20)
        Me.txtsenha.TabIndex = 5
        '
        'btnnovo
        '
        Me.btnnovo.Location = New System.Drawing.Point(39, 175)
        Me.btnnovo.Name = "btnnovo"
        Me.btnnovo.Size = New System.Drawing.Size(90, 28)
        Me.btnnovo.TabIndex = 6
        Me.btnnovo.Text = "Novo"
        Me.btnnovo.UseVisualStyleBackColor = True
        '
        'btnsalvar
        '
        Me.btnsalvar.Location = New System.Drawing.Point(162, 175)
        Me.btnsalvar.Name = "btnsalvar"
        Me.btnsalvar.Size = New System.Drawing.Size(90, 28)
        Me.btnsalvar.TabIndex = 7
        Me.btnsalvar.Text = "Salvar"
        Me.btnsalvar.UseVisualStyleBackColor = True
        '
        'btnexcluir
        '
        Me.btnexcluir.Location = New System.Drawing.Point(284, 175)
        Me.btnexcluir.Name = "btnexcluir"
        Me.btnexcluir.Size = New System.Drawing.Size(93, 28)
        Me.btnexcluir.TabIndex = 8
        Me.btnexcluir.Text = "Excluir"
        Me.btnexcluir.UseVisualStyleBackColor = True
        '
        'btnlocalizar
        '
        Me.btnlocalizar.Location = New System.Drawing.Point(314, 27)
        Me.btnlocalizar.Name = "btnlocalizar"
        Me.btnlocalizar.Size = New System.Drawing.Size(123, 26)
        Me.btnlocalizar.TabIndex = 9
        Me.btnlocalizar.Text = "Localizar"
        Me.btnlocalizar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnlocalizar)
        Me.Controls.Add(Me.btnexcluir)
        Me.Controls.Add(Me.btnsalvar)
        Me.Controls.Add(Me.btnnovo)
        Me.Controls.Add(Me.txtsenha)
        Me.Controls.Add(Me.txtnome)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtnome As TextBox
    Friend WithEvents txtsenha As TextBox
    Friend WithEvents btnnovo As Button
    Friend WithEvents btnsalvar As Button
    Friend WithEvents btnexcluir As Button
    Friend WithEvents btnlocalizar As Button
End Class
