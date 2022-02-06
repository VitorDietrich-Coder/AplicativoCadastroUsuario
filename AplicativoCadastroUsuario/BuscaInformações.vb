Imports System.Data.SqlClient

Public Class BuscaInformações
    Public Conexao As Conexao = New Conexao()
    Public dr As SqlDataReader
    Public mensagem As String = ""
    Public cmd As New SqlCommand()

    Public Nome2 As String
    Public Idade2 As String
    Public Escolaridade2 As String
    Public Bairro2 As String
    Public Cidade2 As String
    Public Estado2 As String
    Public Cep2 As String

    Public Sub BuscaInformações(Codigo As Integer)

        cmd.CommandText = "Select * from CadastroPessoa Where Codigo = '" & Codigo & "'"

        Try
            cmd.Connection = Conexao.conectar()

            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()

                Nome2 = dr("Nome").ToString
                Idade2 = dr("Idade").ToString
                Escolaridade2 = dr("Escolaridade").ToString
                Bairro2 = dr("Bairro").ToString
                Cidade2 = dr("Cidade").ToString
                Estado2 = dr("Estado").ToString
                Cep2 = dr("Cep").ToString

            End While

        Catch ex As Exception

            Me.mensagem = "Erro de conexao"

        Finally
            Conexao.desconectar()
        End Try

    End Sub
End Class
