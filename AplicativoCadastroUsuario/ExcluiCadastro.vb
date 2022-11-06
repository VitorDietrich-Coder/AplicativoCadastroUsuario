Imports System.Data.SqlClient
Public Class ExcluiCadastro
    Public mensagem As String
    Public cmd As SqlCommand = New SqlCommand()
    Public Conexao As Conexao = New Conexao()
    Public Sub ExcluiCadastro(Codigo As Integer)
        Try
            cmd.CommandText = $"DELETE FROM CadastroPessoa Where Codigo = '{Codigo}'"

            cmd.Connection = Conexao.conectar()

            cmd.ExecuteNonQuery()

            Me.mensagem = "Cadastro Excluido com sucesso!"

        Catch ex As Exception

            Me.mensagem = "Erro de conexao"

        Finally
            Conexao.desconectar()
        End Try

    End Sub

End Class

