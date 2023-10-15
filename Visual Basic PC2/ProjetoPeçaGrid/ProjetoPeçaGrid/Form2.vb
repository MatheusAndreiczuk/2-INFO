Public Class Form2
    Dim mpeca As New Peca
    Dim mnovo As Boolean
    Dim bd As New PecaBd
    Private Sub pecatotela()
        txtid.Text = mpeca.id
        txtdescricao.Text = mpeca.descricao
        txtmarca.Text = mpeca.marca
        txtaplicacao.Text = mpeca.aplicacao
        txtcodigodebarras.Text = mpeca.codigodebarras
    End Sub
    Private Sub telatopeca()
        mpeca.id = txtid.Text
        mpeca.descricao = txtdescricao.Text
        mpeca.marca = txtmarca.Text
        mpeca.aplicacao = txtaplicacao.Text
        mpeca.codigodebarras = txtcodigodebarras.Text
    End Sub
    Public Property peca()
        Get
            Return mpeca
        End Get
        Set(ByVal value)
            mpeca = value
            pecatotela()
        End Set
    End Property
    Public Property novo()
        Get
            Return mnovo
        End Get
        Set(ByVal value)
            mnovo = value
        End Set
    End Property


    Private Sub btncancela_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        Me.Dispose()
    End Sub

    Private Sub btnsalva_Click(sender As Object, e As EventArgs) Handles btnsalva.Click
        telatopeca()
        If novo Then
            bd.inserir(peca)
        Else
            bd.atualizar(peca)
        End If
        Me.Dispose()
    End Sub
End Class