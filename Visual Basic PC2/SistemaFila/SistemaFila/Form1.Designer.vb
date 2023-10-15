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
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalva = New System.Windows.Forms.Button()
        Me.dgfiltro = New System.Windows.Forms.DataGridView()
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(297, 83)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(172, 23)
        Me.txtDescricao.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(363, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'btnSalva
        '
        Me.btnSalva.Location = New System.Drawing.Point(347, 133)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 2
        Me.btnSalva.Text = "Adicionar"
        Me.btnSalva.UseVisualStyleBackColor = True
        '
        'dgfiltro
        '
        Me.dgfiltro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgfiltro.Location = New System.Drawing.Point(231, 241)
        Me.dgfiltro.Name = "dgfiltro"
        Me.dgfiltro.RowTemplate.Height = 25
        Me.dgfiltro.Size = New System.Drawing.Size(312, 205)
        Me.dgfiltro.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 511)
        Me.Controls.Add(Me.dgfiltro)
        Me.Controls.Add(Me.btnSalva)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDescricao)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgfiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalva As Button
    Friend WithEvents dgfiltro As DataGridView
End Class
