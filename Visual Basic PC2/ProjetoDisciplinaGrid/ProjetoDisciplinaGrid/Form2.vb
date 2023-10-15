Public Class Form2
    Dim mDisciplina As New Disciplina
    Dim mnovo As Boolean
    Dim bd As New DisciplinaBd
    Private Sub disciplinatotela()
        txtcodigo.Text = mDisciplina.codigo
        txtnome.Text = mDisciplina.nome
        txtcargahoraria.Text = mDisciplina.cargahoraria
        txtprofessor.Text = mDisciplina.professor
    End Sub
    Private Sub telatodisciplina()
        mDisciplina.codigo = txtcodigo.Text
        mDisciplina.cargahoraria = txtcargahoraria.Text
        mDisciplina.nome = txtnome.Text
        mDisciplina.professor = txtprofessor.Text
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btncancela.Click
        Me.Dispose()
    End Sub

    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnsalva.Click
        telatodisciplina()
        If novo Then
            bd.inserir(disciplina)
        Else
            bd.atualizar(disciplina)
        End If
        Me.Dispose()
    End Sub

    Public Property disciplina()
        Get
            Return mDisciplina
        End Get
        Set(ByVal value)
            mDisciplina = value
            disciplinatotela()
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
End Class