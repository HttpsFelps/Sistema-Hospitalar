Imports System.Data.SQLite
Imports System.IO
Public Class login
    Dim senha As String
<<<<<<< HEAD
    'Dim ativo As Integer
=======
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f

    Private Sub Form_recep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"
        If Not File.Exists(caminhoDB) Then
            SQLiteConnection.CreateFile(caminhoDB)
            Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
            conexao.Open()

            ' Tabela colaboradores
<<<<<<< HEAD

            Dim sqlColaboradores As String = "CREATE TABLE colaboradores (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            email TEXT UNIQUE,
            senha TEXT,
            adm BOOLEAN CHECK (adm IN (0, 1)) DEFAULT 0
        );            
            INSERT INTO colaboradores (email, senha, adm) VALUES('admin', 'admin', 1);            
       
"
=======
            Dim sqlColaboradores As String = "CREATE TABLE colaboradores (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            cpf TEXT UNIQUE,
            senha TEXT
        )"
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
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
<<<<<<< HEAD
        Dim query As New SQLiteCommand("SELECT * FROM colaboradores WHERE email = @user", conexao)
        query.Parameters.AddWithValue("@user", txt_usuario.Text)
        Dim leitor As SQLiteDataReader = query.ExecuteReader()
        Dim isAdmin As Integer
        While leitor.Read()
            senha = leitor("senha")
            isAdmin = Convert.ToInt32(leitor("adm"))
=======
        Dim query As New SQLiteCommand("SELECT * FROM colaboradores WHERE id = @assinatura", conexao)
        query.Parameters.AddWithValue("@assinatura", txt_assinatura.Text)
        Dim leitor As SQLiteDataReader = query.ExecuteReader()
        While leitor.Read()
            senha = leitor("senha")
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
        End While
        leitor.Close()
        conexao.Close()
        If senha = "" Then
<<<<<<< HEAD
            MessageBox.Show("Nehum registro com este usuario", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
=======
            MessageBox.Show("Nehum registro com esta assinatura digital", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
            Exit Sub
        ElseIf senha <> txt_senha.Text Then
            MessageBox.Show("Senha incorreta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
<<<<<<< HEAD
        ElseIf txt_senha.Text = "" Or txt_usuario.Text = "" Then
            MessageBox.Show("Os campos Usuario e senha são obrigatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            veradm(isAdmin)

=======
        ElseIf txt_senha.Text = "" Or txt_assinatura.Text = "" Then
            MessageBox.Show("Os campos Assinatura digital e senha são obrigatorios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
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
<<<<<<< HEAD

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim novaTela As New login()
        novaTela.Show()
        Me.Close()
    End Sub
=======
>>>>>>> 62425db003551673fa92ef7a1d4001a33968cc7f
End Class