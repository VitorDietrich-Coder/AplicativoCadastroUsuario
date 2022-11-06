Imports System.Data.SqlClient

Public Class Busca
    Public Conexao As Conexao = New Conexao()
    Public dr As SqlDataReader
    Public mensagem As String = ""
    Public cmd As New SqlCommand()
    Public Sub BuscaInformacoes(Codigo As Integer)

        Try
            cmd.CommandText = $"Select * from CadastroPessoa Where Codigo = '{Codigo}'"
            cmd.Connection = Conexao.conectar()
            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Form1.Nome.Text = dr("Nome").ToString
                Form1.Idade.Text = dr("Idade").ToString
                Form1.Escolaridade.Text = dr("Escolaridade").ToString
                Form1.Bairro.Text = dr("Bairro").ToString
                Form1.Cidade.Text = dr("Cidade").ToString
                Form1.Estado.Text = dr("Estado").ToString
                Form1.CEP.Text = dr("Cep").ToString
            End While
        Catch ex As Exception
            Me.mensagem = "Erro de conexao"
        Finally
            Conexao.desconectar()
        End Try
    End Sub
End Class
