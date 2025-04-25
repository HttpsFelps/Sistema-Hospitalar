Imports System.Data.SQLite
Imports System.IO
Public Class login
    Dim senha As String

    Private Sub Form_recep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"
        If Not File.Exists(caminhoDB) Then
            SQLiteConnection.CreateFile(caminhoDB)
            Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
            conexao.Open()

            ' Tabela colaboradores
            Dim sqlColaboradores As String = "CREATE TABLE colaboradores (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            cpf TEXT UNIQUE,
            senha TEXT
        )"
            Dim comandoColaboradores As New SQLiteCommand(sqlColaboradores, conexao)
            comandoColaboradores.ExecuteNonQuery()

            ' Tabela pacientes
            Dim sqlPacientes As String = "CREATE TABLE pacientes (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nome TEXT,
            cpf TEXT UNIQUE,
            telefone TEXT,
            telefone2 TEXT,
            cep TEXT,
            numero TEXT
        )"
            Dim comandoPacientes As New SQLiteCommand(sqlPacientes, conexao)
            comandoPacientes.ExecuteNonQuery()

            Dim sqlTriagem As String = "CREATE TABLE triagem (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nome TEXT,
            CPF TEXT,
            data_nascimento TEXT,
            pressao TEXT,
            altura TEXT,
            peso TEXT,
            risco TEXT,
            temperatura TEXT
            );"

            Dim comandoTriagem As New SQLiteCommand(sqlTriagem, conexao)
            comandoTriagem.ExecuteNonQuery()

            conexao.Close()
        End If
    End Sub

    Private Sub btn_criar_Click(sender As Object, e As EventArgs) Handles btn_criar.Click
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"
        Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
        conexao.Open()
        Dim query As New SQLiteCommand("SELECT * FROM colaboradores WHERE id = @assinatura", conexao)
        query.Parameters.AddWithValue("@assinatura", txt_assinatura.Text)
        Dim leitor As SQLiteDataReader = query.ExecuteReader()
        While leitor.Read()
            senha = leitor("senha")
        End While
        leitor.Close()
        conexao.Close()
        If senha = "" Then
            MessageBox.Show("Nehum registro com esta assinatura digital", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf senha <> txt_senha.Text Then
            MessageBox.Show("Senha incorreta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        ElseIf txt_senha.Text = "" Or txt_assinatura.Text = "" Then
            MessageBox.Show("Os campos Assinatura digital e senha são obrigatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            Dim novaTela As New Menu()
            novaTela.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btn_cadastrar_Click(sender As Object, e As EventArgs) Handles btn_cadastrar.Click
        Dim novaTela As New cad()
        novaTela.Show()
        Me.Hide()
    End Sub
End Class