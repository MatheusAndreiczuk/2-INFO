Public Class Form1
    Dim bd As New BdAluno
    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        dgfiltro.DataSource = bd.pesquisa("").Tables(0).DefaultView
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Private Sub AlterarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlterarToolStripMenuItem1.Click
        Dim codigo = -1, linha As Integer
        linha = dgfiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            codigo = dgfiltro.Rows(linha).Cells(0).Value
            Form2.aluno = bd.localizar(codigo)
            Form2.novo = False
            Form2.Show()
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub
    Private Sub NovoToolStripMenuItem_Click1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovoToolStripMenuItem1.Click
        Form2.aluno = New Aluno
        Form2.novo = True
        Form2.Show()
    End Sub
    Private Sub ExcluirToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExcluirToolStripMenuItem1.Click
        Dim codigo = -1, linha As Integer
        linha = dgfiltro.Rows.GetFirstRow(DataGridViewElementStates.Selected)
        If linha > -1 Then
            codigo = dgfiltro.Rows(linha).Cells(0).Value
            bd.excluir(codigo)
            dgfiltro.DataSource = bd.pesquisa(txtfiltro.Text).Tables(0).DefaultView
        Else
            MsgBox("Nenhuma linha selecionada")
        End If
    End Sub
    Private Sub btnfiltro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfiltro.Click
        dgfiltro.DataSource = bd.pesquisa(txtfiltro.Text).Tables(0).DefaultView
    End Sub
End Class
