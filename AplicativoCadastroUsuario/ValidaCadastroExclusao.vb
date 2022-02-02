Imports System.Data.SqlClient
Public Class ValidaCadastroExclusao

    Public tem As Boolean
    Public mensagem As String = ""
    Public cmd As New SqlCommand()
    Public con As New Conexao()
    Public dr As SqlDataReader
    Public Function ValidaCadastroExclusao(Codigo As Integer) As Boolean

        cmd.CommandText = "select * from CadastroPessoa where Codigo = '" & Codigo & "'"

        Try
            cmd.Connection = con.conectar()
            dr = cmd.ExecuteReader()
            If dr.HasRows Then

                tem = True

            End If

        Catch SqlException As Exception


            Me.mensagem = "erro com banco de dados"


        End Try

        Return tem
    End Function
End Class
