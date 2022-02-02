Imports System.Data.SqlClient

Public Class BuscaProdutoINPUTvb


    Public Conexao As Conexao = New Conexao()
    Public dr As SqlDataReader
    Public mensagem As String = ""
    Public cmd As New SqlCommand()


    Public Function BuscaProdutoINPUTvb(Codigo As String) As DataTable

        cmd.CommandText = "Select * From CadastroPessoa where Codigo like '%" + Codigo + "' or Nome Like '%" + Codigo + "' or Idade Like '%" + Codigo + "' "

        Try

            cmd.Connection = Conexao.conectar()

            Dim dt As New DataTable()

            cmd.ExecuteNonQuery()

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            dt.Load(reader)

            If dt.Rows.Count = 0 Then

                mensagem = "Não foram localizados dados para este critério."

            Else

                mensagem = "deu boa na pesquisa"
            End If

            Return dt

        Finally

            Conexao.desconectar()

        End Try

    End Function
End Class
