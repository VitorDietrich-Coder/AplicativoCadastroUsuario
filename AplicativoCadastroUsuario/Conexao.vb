Imports System.Data.SqlClient
Imports System.Data

Public Class Conexao

    Public Conn As New SqlConnection()

    Public Sub New()


        Conn.ConnectionString = "Data Source=LAPTOP-CE4Q030Q; Initial Catalog=CadastroPessoa;Integrated Security=True"

    End Sub

    Public Function conectar() As SqlConnection

        If Conn.State = System.Data.ConnectionState.Closed Then

            Conn.Open()

        End If

        Return Conn

    End Function

    Public Function desconectar() As SqlConnection

        If Conn.State = System.Data.ConnectionState.Open Then

            Conn.Close()

        End If

        Return Conn
    End Function
End Class
