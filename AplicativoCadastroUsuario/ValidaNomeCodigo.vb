Imports System.Data.SqlClient

Public Class ValidaNomeCodigo

    Public tem As Boolean
    Public mensagem As String = ""
    Public cmd As New SqlCommand()
    Public con As New Conexao()
    Public dr As SqlDataReader

    Public Function ValidaNomeCodigo(Codigo As Integer, Nome As String) As Boolean
        Try
            cmd.CommandText = $"select * from CadastroPessoa where Codigo = '{Codigo}' or Nome = '{Nome}'"
            cmd.Connection = con.conectar()
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                tem = True
            End If

        Catch SqlException As Exception

            Me.mensagem = "erro de Conexao com banco de dados"

        End Try
        Return tem
    End Function
End Class
