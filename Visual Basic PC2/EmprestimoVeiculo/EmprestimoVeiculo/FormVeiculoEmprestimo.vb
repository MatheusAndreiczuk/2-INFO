﻿Public Class FormVeiculoEmprestimo
    Dim mVeiculoEmp As New Veiculo
    Dim mnovo As Boolean
    Dim bd As New BdVeiculo
    Dim bdcliente As New BdCliente
    Private Sub veiculototela()
        txtidveiculo.Text = mVeiculoEmp.id
        txtidcliente.Text = mVeiculoEmp.idCliente
    End Sub
    Private Sub telatoveiculo()
        mVeiculoEmp.id = txtidveiculo.Text
        mVeiculoEmp.idCliente = txtidcliente.Text
    End Sub
    Public Property veiculo()
        Get
            Return mVeiculoEmp
        End Get
        Set(ByVal value)
            mVeiculoEmp = value
            veiculototela()
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
    Private Sub btnCancela_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancela.Click
        Me.Dispose()
    End Sub

    Private Sub btnempresta_Click(sender As Object, e As EventArgs) Handles btnempresta.Click
        If bdcliente.localizar(Integer.Parse(txtidcliente.Text)).nome <> "" Then
            telatoveiculo()
            bd.emprestaVeiculo(veiculo)
            Me.Dispose()
        Else
            MsgBox("Cliente não encontrado!")
        End If
    End Sub
End Class