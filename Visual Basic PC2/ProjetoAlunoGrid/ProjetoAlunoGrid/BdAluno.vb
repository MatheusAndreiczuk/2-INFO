Imports MySql.Data.MySqlClient
Public Class BdAluno
    Inherits Bd
    Public Sub New()
        Me.User = "root"
        Me.Servidor = "localhost"
        Me.Senha = "vertrigo"
        Me.bd = "aluno"
    End Sub
    Public Sub inserir(ByVal aluno As Aluno)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "insert into aluno (codigo,nome,serie,turma) values (@codigo,@nome,@serie,@turma)"
            cmd.Parameters.AddWithValue("@codigo", aluno.codigo)
            cmd.Parameters.AddWithValue("@nome", aluno.nome)
            cmd.Parameters.AddWithValue("@serie", aluno.serie)
            cmd.Parameters.AddWithValue("@turma", aluno.turma)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub atualizar(ByVal aluno As Aluno)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "update aluno set nome=@nome, serie=@serie, turma=@turma where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", aluno.codigo)
            cmd.Parameters.AddWithValue("@nome", aluno.nome)
            cmd.Parameters.AddWithValue("@serie", aluno.serie)
            cmd.Parameters.AddWithValue("@turma", aluno.turma)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub excluir(ByVal codigo As Integer)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "delete from aluno where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            da.UpdateCommand = cmd
            da.UpdateCommand.ExecuteNonQuery()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function localizar(ByVal codigo As Integer) As Aluno
        Dim dr As MySqlDataReader = Nothing
        Dim cmd As MySqlCommand = New MySqlCommand
        Dim aluno As New Aluno
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from aluno where codigo=@codigo"
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Connection = Conexao
            dr = cmd.ExecuteReader
            If dr.Read Then
                aluno.codigo = dr.GetInt32("codigo")
                aluno.nome = dr.GetString("nome")
                aluno.turma = dr.GetString("turma")
                aluno.serie = dr.GetInt32("serie")
            End If
            cmd.Dispose()
            fechar()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return aluno
    End Function
    Public Function pesquisa(ByVal nome As String) As DataSet
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter
        Dim cmd As MySqlCommand = New MySqlCommand
        Try
            Abrir()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from aluno where nome like @nome"
            cmd.Parameters.AddWithValue("@nome", "%" & nome & "%")
            cmd.Connection = Conexao
            da.SelectCommand = cmd
            da.Fill(ds)
            da.Dispose()
            Return ds
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function
End Class
