Public Class ControlaExclusao


    Public tem As Boolean
    Public mensagem As String = ""


    Public Function acessa(Codigo As Integer) As Boolean
        Dim valida As ValidaCadastroExclusao = New ValidaCadastroExclusao()
        tem = valida.ValidaCadastroExclusao(Codigo)
        If valida.mensagem.Equals("") Then

            Me.mensagem = valida.mensagem

        End If
        Return tem

    End Function
    Public Function Cadastrar(Codigo As Integer) As Integer

        Return mensagem

    End Function

End Class

