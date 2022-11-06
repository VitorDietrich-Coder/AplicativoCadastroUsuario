Public Class Form1

    Public pesquisa As PesquisaPessoa = New PesquisaPessoa()
    Public valor As Cadastra_usuário = New Cadastra_usuário()



    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Altera As AlteraCadastro = New AlteraCadastro()
        Dim Control As ControlaCAD = New ControlaCAD()
        Dim Codigo3 As Valida_Nome = New Valida_Nome()


        Dim cancela As MsgBoxResult = New MsgBoxResult()

        If Codigo.Text = vbNullString Then

            MessageBox.Show("Campo Código está em branco")

        ElseIf Nome.Text = vbNullString Then

            MessageBox.Show("Campo Nome está em branco")

        ElseIf Idade.Text = vbNullString Then

            MessageBox.Show("Campo Idade está em branco")

        ElseIf Escolaridade.Text = vbNullString Then

            MessageBox.Show("Campo Escolaridade está em branco")

        ElseIf Bairro.Text = vbNullString Then

            MessageBox.Show("Campo Bairro está em branco")

        ElseIf Cidade.Text = vbNullString Then

            MessageBox.Show("Campo Cidade está em branco")

        ElseIf Estado.Text = vbNullString Then

            MessageBox.Show("Campo Estado está em branco")

        ElseIf (CEP.Text = vbNullString) Or (CEP.Text.Length < 9) Then

            MessageBox.Show("Campo Cep está em branco")

        Else
            Codigo3.Valida_Nome(Nome.Text)
            Control.acessar(Integer.Parse(Codigo.Text), Nome.Text)

            If Control.tem Then

                If Nome.Text = Codigo3.Nome2 And (Not (Codigo.Text = Codigo3.Codigo2)) Then

                    If MsgBox($"Esse Nome ou código já está cadastrado em nossa base de dados, deseja alterar o cadastro de código {Codigo3.Codigo2} ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        Altera.AlteraCadastro(Codigo3.Codigo2, Nome.Text, Integer.Parse(Idade.Text), Escolaridade.Text, Bairro.Text, Cidade.Text, Estado.Text, CEP.Text)

                        MessageBox.Show($"Alterado Cadastro código  {Codigo3.Codigo2} com sucesso!!")

                        LimpaCampos.LimpaCampoForm1()

                        DataGridView1.DataSource = pesquisa.PesquisarPessoa()

                    Else
                        Exit Sub
                    End If


                Else

                    If MsgBox("Deseja alterar esse cadastro ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                        Altera.AlteraCadastro(Integer.Parse(Codigo.Text), Nome.Text, Integer.Parse(Idade.Text), Escolaridade.Text, Bairro.Text, Cidade.Text, Estado.Text, CEP.Text)

                        MessageBox.Show(Altera.mensagem)
                        LimpaCampos.LimpaCampoForm1()

                        DataGridView1.DataSource = pesquisa.PesquisarPessoa()

                    Else

                        Exit Sub

                    End If
                End If

            Else

                valor.Cadastra_usuário(Integer.Parse(Codigo.Text), Nome.Text, Integer.Parse(Idade.Text), Escolaridade.Text, Bairro.Text, Cidade.Text, Estado.Text, CEP.Text)
                MessageBox.Show(valor.mensagem)

                Codigo.Text = ""
                Nome.Text = ""
                Idade.Text = ""
                Escolaridade.Text = ""
                Bairro.Text = ""
                Cidade.Text = ""
                Estado.Text = ""
                CEP.Text = ""

                DataGridView1.DataSource = pesquisa.PesquisarPessoa()

            End If
        End If

    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim excluir As ExcluiCadastro = New ExcluiCadastro()
        Dim Controla As ControlaExclusao = New ControlaExclusao()

        If Codigo.Text = vbNullString Then

            MessageBox.Show("Selecione o cliente no qual deseja fazer a exclusão")
        Else

            Controla.acessa(Codigo.Text)

            If Controla.tem = True Then

                If MsgBox("Deseja mesmo excluir esse cadastro? Se realizar esssa operação a mesma não pode ser desfeita", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    excluir.ExcluiCadastro(Integer.Parse(Codigo.Text))
                    MessageBox.Show(excluir.mensagem)

                    LimpaCampos.LimpaCampoForm1()

                    DataGridView1.DataSource = pesquisa.PesquisarPessoa()

                Else

                    Exit Sub

                End If
            Else

                MessageBox.Show("Esse código não existe, favor cadastre o mesmo")

            End If
        End If
    End Sub

    Private Sub Pesquisa_ProdutoKeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim pesquisa As BuscaPessoa = New BuscaPessoa()

        If e.KeyChar = Convert.ToChar(Keys.Return) Then

            DataGridView1.DataSource = pesquisa.Buscar(TextBox1.Text)

        End If
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pesquisa As PesquisaPessoa = New PesquisaPessoa()

        DataGridView1.DataSource = pesquisa.PesquisarPessoa()
        DataGridView1.Columns("Id").Visible = False
        DataGridView1.Columns("Codigo").Width = 60
        DataGridView1.Columns("Nome").Width = 250
        DataGridView1.Columns("Idade").Width = 60
        DataGridView1.Columns("Escolaridade").Width = 170
        DataGridView1.Columns("Bairro").Width = 150
        DataGridView1.Columns("Estado").Width = 150
        DataGridView1.Columns("Cidade").Width = 180
        DataGridView1.Columns("CEP").Width = 76

    End Sub

    Private Sub Double_ClickData(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick

        Dim rowindex As Integer = DataGridView1.CurrentRow.Index

        Dim codigo2 As Integer = Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("Codigo").Value.ToString())
        Dim Nome2 As String = DataGridView1.SelectedRows(0).Cells("Nome").Value.ToString()
        Dim Idade2 As String = DataGridView1.SelectedRows(0).Cells("Idade").Value.ToString()
        Dim Escolaridade2 As String = DataGridView1.SelectedRows(0).Cells("Escolaridade").Value.ToString()
        Dim Bairro2 As String = DataGridView1.SelectedRows(0).Cells("Bairro").Value.ToString()
        Dim Cidade2 As String = DataGridView1.SelectedRows(0).Cells("Cidade").Value.ToString()
        Dim Estado2 As String = DataGridView1.SelectedRows(0).Cells("Estado").Value.ToString()
        Dim Cep2 As String = DataGridView1.SelectedRows(0).Cells("Cep").Value.ToString()

        Codigo.Text = Convert.ToString(codigo2)
        Nome.Text = Nome2
        Idade.Text = Idade2
        Escolaridade.Text = Escolaridade2
        Bairro.Text = Bairro2
        Cidade.Text = Cidade2
        Estado.Text = Estado2
        CEP.Text = Cep2

    End Sub

    Private Sub Codigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Codigo.KeyPress

        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If

    End Sub

    Private Sub Idade_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Idade.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True

        End If
    End Sub

    Private Sub Sair_Box(sender As Object, e As EventArgs) Handles Codigo.Leave
        Dim Controla As ControlaExclusao = New ControlaExclusao()
        Dim busca As Busca = New Busca()

        If Not String.IsNullOrEmpty(Codigo.Text) Then
            Controla.acessa(Codigo.Text)
            If Controla.tem Then
                busca.BuscaInformacoes(Integer.Parse(Codigo.Text))
            End If
        End If
    End Sub

    Private Sub Busca_cep(sender As Object, e As EventArgs) Handles CEP.Leave

        Try
            Dim ds As New DataSet()
            Dim xml As String = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep", CEP.Text)
            ds.ReadXml(xml)
            Bairro.Text = ds.Tables(0).Rows(0)("bairro").ToString()
            Cidade.Text = ds.Tables(0).Rows(0)("cidade").ToString()
            Estado.Text = ds.Tables(0).Rows(0)("uf").ToString()

        Catch ex As Exception
            MessageBox.Show("Digite um valor valido")
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LimpaCampos.LimpaCampoForm1()
    End Sub

    Private Sub Form_Closing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If Not (String.IsNullOrEmpty(Codigo.Text)) AndAlso
            (String.IsNullOrEmpty(Nome.Text)) AndAlso
            (String.IsNullOrEmpty(Idade.Text)) AndAlso
            (String.IsNullOrEmpty(Escolaridade.Text)) AndAlso
            (String.IsNullOrEmpty(Bairro.Text)) AndAlso
            (String.IsNullOrEmpty(Cidade.Text)) AndAlso
            (String.IsNullOrEmpty(Estado.Text)) AndAlso
            (Not (CEP.Text.Length = 9)) Then
            If MsgBox("Deseja mesmo sair sem salvar?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Exit Sub
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class

