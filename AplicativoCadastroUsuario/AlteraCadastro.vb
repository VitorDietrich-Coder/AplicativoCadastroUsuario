﻿Imports System.Data.SqlClient

Public Class AlteraCadastro

    Public mensagem As String
    Public cmd As SqlCommand = New SqlCommand()
    Public Conexao As Conexao = New Conexao()

    Public Sub AlteraCadastro(Codigo As Integer, Nome As String, Idade As Integer, Escolaridade As String, Bairro As String, Cidade As String, Estado As String, CEP As String)

        Try
            cmd.CommandText = $"UPDATE CadastroPessoa SET Codigo = '{Codigo}',  Nome = '{Nome}', Idade = '{Idade}', Escolaridade = '{Escolaridade}', Bairro = '{Bairro}', Cidade = '{Cidade}', Estado = '{Estado}', CEP = '{CEP}' where Codigo = '{Codigo}'"
            cmd.Connection = Conexao.conectar()
            cmd.ExecuteNonQuery()

            Me.mensagem = "Cadastro Alterado com sucesso"

        Catch ex As Exception

            Me.mensagem = "Erro de conexao"

        Finally
            Conexao.desconectar()
        End Try
    End Sub
End Class
