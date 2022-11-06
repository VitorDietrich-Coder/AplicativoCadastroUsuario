Imports System.Data.SqlClient
Public Class PesquisaPessoa
    Public Conexao As Conexao = New Conexao()
    Public dr As SqlDataReader
    Public mensagem As String = ""
    Public cmd As New SqlCommand()


    Public Function PesquisarPessoa() As DataTable

        Try
            cmd.CommandText = "Select * From CadastroPessoa "

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
