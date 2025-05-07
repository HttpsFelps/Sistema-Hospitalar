Imports System.Data.SQLite
Imports System.IO
Public Class cad
<<<<<<< HEAD
    Dim email As String
=======
    Dim cpf As String
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
    Dim senha As String
    Dim senhaConfirm As String
    Dim chave As String

<<<<<<< HEAD
    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        email = txt_email.Text
=======
    Private Sub Form_recep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"
        If Not File.Exists(caminhoDB) Then
            SQLiteConnection.CreateFile(caminhoDB)
            Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
            conexao.Open()
            Dim sql As String = "CREATE TABLE colaboradores (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            cpf TEXT TYPE UNIQUE,
            senha TEXT
        )"
            Dim comando As New SQLiteCommand(sql, conexao)
            comando.ExecuteNonQuery()
            conexao.Close()
        End If
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        cpf = txt_cpf.Text
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
        senha = txt_senha.Text
        senhaConfirm = txt_senhaconfirm.Text
        If senha <> senhaConfirm Then
            MessageBox.Show("As senhas se divergem", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
<<<<<<< HEAD
        ElseIf email = "" Or senha = "" Then
            MessageBox.Show("Os campos Email e senha são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
=======
        ElseIf cpf = "   .   .   -" Or senha = "" Then
            MessageBox.Show("Os campos CPF e senha são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
        Else
            Try
                Dim caminhoDB As String = Application.StartupPath & "\banco.db"
                Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
                conexao.Open()
<<<<<<< HEAD
                Dim verificaremail As New SQLiteCommand("SELECT COUNT(*) FROM colaboradores WHERE email = @email", conexao)
                verificaremail.Parameters.AddWithValue("@email", txt_email.Text)
                Dim emailExiste As Integer = Convert.ToInt32(verificaremail.ExecuteScalar())

                If emailExiste > 0 Then

                    MessageBox.Show("Há outro registro com este email", "Saida")
                    Exit Sub
                Else
                    Dim comando As New SQLiteCommand("INSERT INTO colaboradores (email, senha) VALUES (@email, @senha)", conexao)

                    comando.Parameters.AddWithValue("@email", txt_email.Text)
                    comando.Parameters.AddWithValue("@senha", txt_senha.Text.Trim())

                    comando.ExecuteNonQuery()
                    conexao.Close()

                    MessageBox.Show("Paciente adicionado com sucesso!", "Saida")
=======
                Dim verificarCpf As New SQLiteCommand("SELECT COUNT(*) FROM colaboradores WHERE cpf = @cpf", conexao)
                verificarCpf.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                Dim cpfExiste As Integer = Convert.ToInt32(verificarCpf.ExecuteScalar())

                If cpfExiste > 0 Then

                    MessageBox.Show("Há outro registro com este CPF", "Saida")
                    Exit Sub
                Else
                    Dim comando As New SQLiteCommand("INSERT INTO colaboradores (cpf, senha) VALUES (@cpf, @senha)", conexao)

                    comando.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    comando.Parameters.AddWithValue("@senha", txt_senha.Text.Trim())

                    comando.ExecuteNonQuery()

                    Dim query As New SQLiteCommand("SELECT id FROM colaboradores WHERE cpf = @cpf", conexao)
                    query.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    Dim leitor As SQLiteDataReader = query.ExecuteReader()
                    While leitor.Read()
                        chave = leitor("id")
                    End While
                    leitor.Close()
                    conexao.Close()

                    MessageBox.Show("Paciente adicionado com sucesso! Chave de acesso: " & chave, "Saida")
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
                    Dim novaTela As New login()
                    novaTela.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                MessageBox.Show("Erro ao adicionar paciente: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim novaTela As New login()
        novaTela.Show()
        Me.Close()
    End Sub
<<<<<<< HEAD

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim novaTela As New login()
        novaTela.Show()
        Me.Close()
    End Sub
=======
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
End Class