Public Class Form1
    Dim animal As New Animal
    Private Sub limpaTela()
        txtCodigo.Text = ""
        txtNome.Text = ""
        txtProprietario.Text = ""
        txtIdade.Text = ""
        txtEspecie.Text = ""
        txtRaca.Text = ""
    End Sub
    Private Sub telaToAnimal()
        animal.codigo = txtCodigo.Text
        animal.nome = txtNome.Text
        animal.proprietario = txtProprietario.Text
        animal.idade = txtIdade.Text
        animal.especie = txtEspecie.Text
        animal.raca = txtRaca.Text
    End Sub
    Private Sub clienteToAnimal()
        txtCodigo.Text = animal.codigo
        txtNome.Text = animal.nome
        txtProprietario.Text = animal.proprietario
        txtIdade.Text = animal.idade
        txtEspecie.Text = animal.especie
        txtRaca.Text = animal.raca
    End Sub

    Private Sub btnNovo_Click(sender As Object, e As EventArgs) Handles btnNovo.Click
        limpaTela()
    End Sub

    Private Sub btnSalva_Click(sender As Object, e As EventArgs) Handles btnSalva.Click
        telaToAnimal()
    End Sub

    Private Sub btnLe_Click(sender As Object, e As EventArgs) Handles btnLe.Click
        clienteToAnimal()
    End Sub
End Class
