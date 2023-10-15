Public Class Form2
    Dim mEquipamento As New Equipamento
    Dim mnovo As Boolean
    Dim bd As New EquipamentoBd
    Private Sub equipamentototela()
        txtid.Text = mEquipamento.id
        txtdescricao.Text = mEquipamento.descricao
        txtfabricante.Text = mEquipamento.fabricante
        txtnumserie.Text = mEquipamento.numserie
        txtnumpatrimonio.Text = mEquipamento.numpatrimonio
        txtlocalizacao.Text = mEquipamento.localizacao
    End Sub
    Private Sub telatoequipamento()
        mEquipamento.id = txtid.Text
        mEquipamento.descricao = txtdescricao.Text
        mEquipamento.fabricante = txtfabricante.Text
        mEquipamento.numserie = txtnumserie.Text
        mEquipamento.numpatrimonio = txtnumpatrimonio.Text
        mEquipamento.localizacao = txtlocalizacao.Text
    End Sub
    Public Property equipamento()
        Get
            Return mEquipamento
        End Get
        Set(ByVal value)
            mEquipamento = value
            equipamentototela()
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
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancelar.Click
        Me.Dispose()
    End Sub
    Private Sub btnSalvar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsalvar.Click
        telatoequipamento()
        If novo Then
            bd.Inserir(equipamento)
        Else
            bd.atualizar(equipamento)
        End If
        Me.Dispose()
    End Sub
End Class