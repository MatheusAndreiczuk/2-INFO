﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlterarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExcluirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnfiltro = New System.Windows.Forms.Button()
        Me.dgfiltro = New System.Windows.Forms.DataGridView()
        Me.btnVerVeiculo = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AlterarToolStripMenuItem, Me.ExcluirToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AlterarToolStripMenuItem
        '
        Me.AlterarToolStripMenuItem.Name = "AlterarToolStripMenuItem"
        Me.AlterarToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AlterarToolStripMenuItem.Text = "Alterar"
        '
        'ExcluirToolStripMenuItem
        '
        Me.ExcluirToolStripMenuItem.Name = "ExcluirToolStripMenuItem"
        Me.ExcluirToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ExcluirToolStripMenuItem.Text = "Excluir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Filtro"
        '
        'txtFiltro
        '
        Me.txtFiltro.Location = New System.Drawing.Point(80, 69)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(107, 20)
        Me.txtFiltro.TabIndex = 2
        '
        'btnfiltro
        '
        Me.btnfiltro.Location = New System.Drawing.Point(206, 69)
        Me.btnfiltro.Name = "btnfiltro"
        Me.btnfiltro.Size = New System.Drawing.Size(75, 23)
        Me.btnfiltro.TabIndex = 3
        Me.btnfiltro.Text = "OK"
        Me.btnfiltro.UseVisualStyleBackColor = True
        '
        'dgfiltro
        '
        Me.dgfiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfiltro.Location = New System.Drawing.Point(35, 140)
        Me.dgfiltro.Name = "dgfiltro"
        Me.dgfiltro.Size = New System.Drawing.Size(753, 276)
        Me.dgfiltro.TabIndex = 4
        '
        'btnVerVeiculo
        '
        Me.btnVerVeiculo.Location = New System.Drawing.Point(333, 69)
        Me.btnVerVeiculo.Name = "btnVerVeiculo"
        Me.btnVerVeiculo.Size = New System.Drawing.Size(107, 23)
        Me.btnVerVeiculo.TabIndex = 5
        Me.btnVerVeiculo.Text = "Ver veículos"
        Me.btnVerVeiculo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnVerVeiculo)
        Me.Controls.Add(Me.dgfiltro)
        Me.Controls.Add(Me.btnfiltro)
        Me.Controls.Add(Me.txtFiltro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlterarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExcluirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFiltro As TextBox
    Friend WithEvents btnfiltro As Button
    Friend WithEvents dgfiltro As DataGridView
    Friend WithEvents btnVerVeiculo As Button
End Class
