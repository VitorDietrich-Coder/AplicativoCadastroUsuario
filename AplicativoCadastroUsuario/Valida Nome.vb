Imports System.Data.SqlClient

Public Class Valida_Nome


    Public tem As Boolean
    Public mensagem As String = ""
    Public cmd As New SqlCommand()
    Public con As New Conexao()
    Public dr As SqlDataReader
    Public Codigo2 As Integer
    Public Nome2 As String

    Public Sub Valida_Nome(Nome As String)

        Try

            cmd.CommandText = $"select * from CadastroPessoa where Nome = '{Nome}' "

            cmd.Connection = con.conectar()

            cmd.ExecuteNonQuery()

            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()

                Codigo2 = dr("Codigo").ToString
                Nome2 = dr("Nome").ToString


            End While

        Catch ex As Exception

            Me.mensagem = "Erro de conexao"

        Finally
            con.desconectar()
        End Try
    End Sub
End Class

