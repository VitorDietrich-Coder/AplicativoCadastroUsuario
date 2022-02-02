Public Class ControlaCAD

    Public tem As Boolean
    Public mensagem As String = ""


    Public Function acessar(Codigo As Integer, Nome As String) As Boolean
        Dim valida As ValidaNomeCodigo = New ValidaNomeCodigo()
        tem = valida.ValidaNomeCodigo2(Codigo, Nome)

        If valida.mensagem.Equals("") Then

            Me.mensagem = valida.mensagem

        End If
        Return tem

    End Function
    Public Function Cadastrar(Codigo As Integer, Nome As String) As String

        Return mensagem

    End Function

End Class
