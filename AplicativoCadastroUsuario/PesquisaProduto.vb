Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class PesquisaProduto
    Public Conexao As Conexao = New Conexao()
    Public dr As SqlDataReader
    Public mensagem As String = ""
    Public cmd As New SqlCommand()


    Public Function PesquisaProduto() As DataTable

        cmd.CommandText = "Select * From CadastroPessoa "

        Try

            cmd.Connection = Conexao.conectar()

            Dim dt As New DataTable()

            cmd.ExecuteNonQuery()

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            dt.Load(reader)

            If dt.Rows.Count = 0 Then

                mensagem = "Não foram localizados dados para este critério."

            End If

            Return dt

        Finally

            Conexao.desconectar()

        End Try

    End Function
End Class
