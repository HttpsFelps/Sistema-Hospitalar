Imports System.Data.SQLite
Imports System.IO
Public Class cad
    Dim email As String
    Dim senha As String
    Dim senhaConfirm As String
    Dim chave As String

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        email = txt_email.Text
        senha = txt_senha.Text
        senhaConfirm = txt_senhaconfirm.Text
        If senha <> senhaConfirm Then
            MessageBox.Show("As senhas se divergem", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf email = "" Or senha = "" Then
            MessageBox.Show("Os campos Email e senha são obrigatórios", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                Dim caminhoDB As String = Application.StartupPath & "\banco.db"
                Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
                conexao.Open()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim novaTela As New login()
        novaTela.Show()
        Me.Close()
    End Sub
End Class