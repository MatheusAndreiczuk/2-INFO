<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormVeiculosDg
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmprestarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgFiltro = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.btnVerTodosVeiculos = New System.Windows.Forms.Button()
        Me.btnVerEmprestimo = New System.Windows.Forms.Button()
        Me.btnclientes = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(854, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.ExcluirToolStripMenuItem, Me.EmprestarToolStripMenuItem, Me.DevolverToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'EmprestarToolStripMenuItem
        '
        Me.EmprestarToolStripMenuItem.Name = "EmprestarToolStripMenuItem"
        Me.EmprestarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmprestarToolStripMenuItem.Text = "Emprestar"
        '
        'DevolverToolStripMenuItem
        '
        Me.DevolverToolStripMenuItem.Name = "DevolverToolStripMenuItem"
        Me.DevolverToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DevolverToolStripMenuItem.Text = "Devolver"
        '
        'dgFiltro
        '
        Me.dgFiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgFiltro.Location = New System.Drawing.Point(25, 140)
        Me.dgFiltro.Name = "dgFiltro"
        Me.dgFiltro.Size = New System.Drawing.Size(502, 296)
        Me.dgFiltro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Filtro"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(77, 82)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(125, 20)
        Me.txtFiltro.TabIndex = 3
        '
        'btnfiltro
        '
        Me.btnfiltro.Location = New System.Drawing.Point(225, 80)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnfiltro.TabIndex = 4
        Me.btnfiltro.Text = "OK"
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'btnVerTodosVeiculos
        '
        Me.btnVerTodosVeiculos.Location = New System.Drawing.Point(647, 168)
        Me.btnVerTodosVeiculos.Name = "btnVerTodosVeiculos"
        Me.btnVerTodosVeiculos.Size = New System.Drawing.Size(145, 23)
        Me.btnVerTodosVeiculos.TabIndex = 5
        Me.btnVerTodosVeiculos.Text = "Ver todos os veículos"
        Me.btnVerTodosVeiculos.UseVisualStyleBackColor = True
        '
        'btnVerEmprestimo
        '
        Me.btnVerEmprestimo.Location = New System.Drawing.Point(647, 218)
        Me.btnVerEmprestimo.Name = "btnVerEmprestimo"
        Me.btnVerEmprestimo.Size = New System.Drawing.Size(145, 23)
        Me.btnVerEmprestimo.TabIndex = 6
        Me.btnVerEmprestimo.Text = "Ver veículos emprestados"
        Me.btnVerEmprestimo.UseVisualStyleBackColor = True
        '
        'btnclientes
        '
        Me.btnclientes.Location = New System.Drawing.Point(647, 273)
        Me.btnclientes.Name = "btnclientes"
        Me.btnclientes.Size = New System.Drawing.Size(145, 23)
        Me.btnclientes.TabIndex = 7
        Me.btnclientes.Text = "Ver clientes"
        Me.btnclientes.UseVisualStyleBackColor = True
        '
        'FormVeiculosDg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 501)
        Me.Controls.Add(Me.btnclientes)
        Me.Controls.Add(Me.btnVerEmprestimo)
        Me.Controls.Add(Me.btnVerTodosVeiculos)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgFiltro)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormVeiculosDg"
        Me.Text = "FormVeiculosDg"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmprestarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DevolverToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgFiltro As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnfiltro As Button
    Friend WithEvents btnVerTodosVeiculos As Button
    Friend WithEvents btnVerEmprestimo As Button
    Friend WithEvents btnclientes As Button
End Class
