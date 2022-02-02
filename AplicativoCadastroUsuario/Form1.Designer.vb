<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Codigo = New System.Windows.Forms.TextBox()
        Me.Nome = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Cidade = New System.Windows.Forms.TextBox()
        Me.Estado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Bairro = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Escolaridade = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CEP = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(182, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(296, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'Codigo
        '
        Me.Codigo.Location = New System.Drawing.Point(182, 93)
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Size = New System.Drawing.Size(77, 23)
        Me.Codigo.TabIndex = 2
        '
        'Nome
        '
        Me.Nome.Location = New System.Drawing.Point(296, 93)
        Me.Nome.Name = "Nome"
        Me.Nome.Size = New System.Drawing.Size(461, 23)
        Me.Nome.TabIndex = 2
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(604, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 42)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Gravar Cadastro"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(512, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cidade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Estado"
        '
        'Cidade
        '
        Me.Cidade.Location = New System.Drawing.Point(512, 174)
        Me.Cidade.Name = "Cidade"
        Me.Cidade.Size = New System.Drawing.Size(422, 23)
        Me.Cidade.TabIndex = 2
        '
        'Estado
        '
        Me.Estado.Location = New System.Drawing.Point(182, 245)
        Me.Estado.Name = "Estado"
        Me.Estado.Size = New System.Drawing.Size(517, 23)
        Me.Estado.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bairro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(761, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "CEP"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(794, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Escolaridade"
        '
        'Bairro
        '
        Me.Bairro.Location = New System.Drawing.Point(182, 174)
        Me.Bairro.Name = "Bairro"
        Me.Bairro.Size = New System.Drawing.Size(292, 23)
        Me.Bairro.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(314, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 42)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Excluir cadastro"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Escolaridade
        '
        Me.Escolaridade.FormattingEnabled = True
        Me.Escolaridade.Items.AddRange(New Object() {"Ensino Fundamental", "Ensino Médio", "Ensino Superior", "Pós-Graduação"})
        Me.Escolaridade.Location = New System.Drawing.Point(794, 93)
        Me.Escolaridade.Name = "Escolaridade"
        Me.Escolaridade.Size = New System.Drawing.Size(140, 23)
        Me.Escolaridade.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(461, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(164, 30)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Cadastro Pessoa"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(182, 447)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(761, 182)
        Me.DataGridView1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 406)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(713, 23)
        Me.TextBox1.TabIndex = 9
        '
        'CEP
        '
        Me.CEP.Location = New System.Drawing.Point(767, 245)
        Me.CEP.Mask = "00000-000"
        Me.CEP.Name = "CEP"
        Me.CEP.Size = New System.Drawing.Size(167, 23)
        Me.CEP.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(182, 406)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(478, 363)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 30)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Exibe Pessoa"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1136, 656)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CEP)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Escolaridade)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Estado)
        Me.Controls.Add(Me.Nome)
        Me.Controls.Add(Me.Cidade)
        Me.Controls.Add(Me.Bairro)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Codigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Codigo As TextBox
    Friend WithEvents Nome As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Cidade As TextBox
    Friend WithEvents Estado As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Bairro As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Escolaridade As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Public WithEvents CEP As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Public WithEvents DataGridView1 As DataGridView
End Class
