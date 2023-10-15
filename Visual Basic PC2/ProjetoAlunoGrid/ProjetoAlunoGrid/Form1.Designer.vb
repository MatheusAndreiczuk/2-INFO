<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfiltro = New System.Windows.Forms.TextBox()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.dgfiltro = New System.Windows.Forms.DataGridView()
        Me.Arquivo = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Arquivo.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Filtro"
        '
        'txtfiltro
        '
        Me.txtfiltro.Location = New System.Drawing.Point(97, 135)
        Me.txtfiltro.Name = "txtfiltro"
        Me.txtfiltro.Size = New System.Drawing.Size(136, 20)
        Me.txtfiltro.TabIndex = 1
        '
        'btnfiltro
        '
        Me.btnfiltro.Location = New System.Drawing.Point(270, 131)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(46, 24)
        Me.btnfiltro.TabIndex = 2
        Me.btnfiltro.Text = "Ok"
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'dgfiltro
        '
        Me.dgfiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfiltro.Location = New System.Drawing.Point(50, 191)
        Me.dgfiltro.Name = "dgfiltro"
        Me.dgfiltro.Size = New System.Drawing.Size(690, 246)
        Me.dgfiltro.TabIndex = 3
        '
        'Arquivo
        '
        Me.Arquivo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.Arquivo.Name = "ContextMenuStrip1"
        Me.Arquivo.Size = New System.Drawing.Size(110, 70)
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem1, Me.AlterarToolStripMenuItem1, Me.ExcluirToolStripMenuItem1})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem1
        '
        Me.NovoToolStripMenuItem1.Name = "NovoToolStripMenuItem1"
        Me.NovoToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.NovoToolStripMenuItem1.Text = "Novo"
        '
        'AlterarToolStripMenuItem1
        '
        Me.AlterarToolStripMenuItem1.Name = "AlterarToolStripMenuItem1"
        Me.AlterarToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AlterarToolStripMenuItem1.Text = "Alterar"
        '
        'ExcluirToolStripMenuItem1
        '
        Me.ExcluirToolStripMenuItem1.Name = "ExcluirToolStripMenuItem1"
        Me.ExcluirToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ExcluirToolStripMenuItem1.Text = "Excluir"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dgfiltro)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.txtfiltro)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Arquivo.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtfiltro As TextBox
    Friend WithEvents btnfiltro As Button
    Friend WithEvents dgfiltro As DataGridView
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Arquivo As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem1 As ToolStripMenuItem
End Class
