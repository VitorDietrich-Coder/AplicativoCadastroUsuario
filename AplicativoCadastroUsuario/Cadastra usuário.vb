Imports System.Data.SqlClient
Public Class Cadastra_usuário

    Public mensagem As String
    Public cmd As SqlCommand = New SqlCommand()
    Public Conexao As Conexao = New Conexao()


    Public Sub Cadastra_usuário(Codigo As Integer, Nome As String, Idade As Integer, Escolaridade As String, Bairro As String, Cidade As String, Estado As String, CEP As String)

        cmd.CommandText = "Insert into  CadastroPessoa (Codigo, Nome, Idade, Escolaridade, Bairro, Cidade, Estado, CEP ) values ('" & Codigo & "','" & Nome & "', '" & Idade & "','" & Escolaridade & "', '" & Bairro & "','" & Cidade & "','" & Estado & "' ,'" & CEP & "')"

        Try
            cmd.Connection = Conexao.conectar()

            cmd.ExecuteNonQuery()

            Me.mensagem = "Cadastro efetuado com sucesso"


        Catch ex As Exception

            Me.mensagem = "Erro de conexao"

        Finally
            Conexao.desconectar()
        End Try

    End Sub


End Class
