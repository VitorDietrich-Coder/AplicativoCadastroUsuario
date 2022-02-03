Public Class ControlaCAD

    Public tem As Boolean
    Public mensagem As String = ""


    Public Function acessar(Codigo As Integer, Nome As String) As Boolean
        Dim valida As ValidaNomeCodigo = New ValidaNomeCodigo()
        tem = valida.ValidaNomeCodigo(Codigo, Nome)

        If valida.mensagem.Equals("") Then

            Me.mensagem = valida.mensagem

        End If
        Return tem

    End Function


End Class
