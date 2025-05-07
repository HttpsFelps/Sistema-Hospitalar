Imports System.Data.SQLite
Imports System.IO

Public Class Form_recep
    Dim saida As String
    Dim nome As String
    Dim telefone As String
    Dim telefone2 As String
    Dim cep As String
    Dim numero As String

    Private Sub Form_recep_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"
        If Not File.Exists(caminhoDB) Then
            SQLiteConnection.CreateFile(caminhoDB)
            Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
            conexao.Open()
            Dim sql As String = "CREATE TABLE pacientes (
            id INTEGER PRIMARY KEY AUTOINCREMENT,
            nome TEXT,
            cpf TEXT TYPE UNIQUE,
            telefone TEXT,
            telefone2 TEXT,
            cep TEXT,
            numero TEXT
        )"
            Dim comando As New SQLiteCommand(sql, conexao)
            comando.ExecuteNonQuery()
            conexao.Close()
        End If
    End Sub

    Sub VerificarCheckbox()
        If cb_op1.Checked And cb_op2.Checked Then
            saida = saida & vbCrLf & "Não é permitido escolher as opçoes de pediatra e geriatra simultaneamente "
        ElseIf (cb_op1.Checked Or cb_op2.Checked) And (txt_cpfac.Text = "   .   .   -" Or txt_nomeac.Text = "") Then
            saida = saida & vbCrLf & "Preencha os campos de informação do acompanhante"
        ElseIf (txt_cpfac.Text <> "   .   .   -" And txt_nomeac.Text <> "") And (Not cb_op1.Checked And Not cb_op2.Checked) Then
            saida = saida & vbCrLf & "Selecione ao menos uma checkbox"
        Else
            saida = saida & ""
        End If
    End Sub

    Sub VerificarInputs()
        If (txt_nome.Text = "" Or txt_cpf.Text = "   .   .   -" Or txt_tel.Text = "(  )      -") Then
            saida = "Os campos nome, cpf e telefone são obrigatorios"
        Else
            saida = ""
        End If
        VerificarCheckbox()
    End Sub

    Sub ReiniciarForm()
        txt_nome.Text = ""
        txt_cpf.Text = ""
        txt_tel.Text = ""
        txt_tel2.Text = ""
        txt_cep.Text = ""
        txt_num.Text = ""
        txt_cpfac.Text = ""
        txt_nomeac.Text = ""
        cb_op1.Checked = False
        cb_op2.Checked = False
    End Sub

    Private Sub btn_addpac_Click(sender As Object, e As EventArgs) Handles btn_addpac.Click
        VerificarInputs()
        Dim resposta As DialogResult
        Dim redirecionar As DialogResult
        If saida = "" Then
            Try
                Dim caminhoDB As String = Application.StartupPath & "\banco.db"
                Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
                conexao.Open()
                Dim verificarCpf As New SQLiteCommand("SELECT COUNT(*) FROM pacientes WHERE cpf = @cpf", conexao)
                verificarCpf.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                Dim cpfExiste As Integer = Convert.ToInt32(verificarCpf.ExecuteScalar())

                If cpfExiste > 0 Then

                    resposta = MessageBox.Show("Há outro registro com este CPF, deseja atualizar para estes dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                    If resposta = DialogResult.Yes Then
                        Dim comando As New SQLiteCommand("UPDATE pacientes SET nome = @nome, telefone = @tel, telefone2 = @tel2, cep = @cep, numero = @num WHERE cpf = @cpf", conexao)
                        comando.Parameters.AddWithValue("@nome", txt_nome.Text.Trim())
                        comando.Parameters.AddWithValue("@tel", txt_tel.Text)
                        comando.Parameters.AddWithValue("@tel2", If(txt_tel2.Text <> "(  )      -", txt_tel2.Text, saida))
                        comando.Parameters.AddWithValue("@cep", If(txt_cep.Text <> "     -", txt_cep.Text, saida))
                        comando.Parameters.AddWithValue("@num", txt_num.Text.Trim())
                        comando.Parameters.AddWithValue("@cpf", txt_cpf.Text)

                        comando.ExecuteNonQuery()
                        redirecionar = MessageBox.Show("Paciente atualizado com sucesso, deseja retornar ao menu?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If redirecionar = DialogResult.Yes Then
                            Dim novaTela As New Menu()
                            novaTela.Show()
                            Me.Close()
                        End If

                    Else
                        saida = "Nada foi alterado"
                        Exit Try
                    End If

                Else
                    Dim comando As New SQLiteCommand("INSERT INTO pacientes (nome, cpf, telefone, telefone2, cep, numero) VALUES (@nome, @cpf, @tel, @tel2, @cep, @num)", conexao)

                    comando.Parameters.AddWithValue("@nome", txt_nome.Text.Trim())
                    comando.Parameters.AddWithValue("@cpf", txt_cpf.Text)
                    comando.Parameters.AddWithValue("@tel", txt_tel.Text)
                    comando.Parameters.AddWithValue("@tel2", If(txt_tel2.Text <> "(  )      -", txt_tel2.Text, saida))
                    comando.Parameters.AddWithValue("@cep", If(txt_cep.Text <> "     -", txt_cep.Text, saida))
                    comando.Parameters.AddWithValue("@num", txt_num.Text.Trim())

                    comando.ExecuteNonQuery()
                    conexao.Close()

                    redirecionar = MessageBox.Show("Paciente adicionado com sucesso, deseja retornar ao menu?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If redirecionar = DialogResult.Yes Then
                        Dim novaTela As New Menu()
                        novaTela.Show()
                        Me.Close()
                    End If
                End If

            Catch ex As Exception
                saida = "Erro ao adicionar paciente: " & ex.Message
            End Try
            ReiniciarForm()
        End If
        If saida <> "" Then
            MessageBox.Show(saida, "Resposta")
        End If
    End Sub

    Private Sub txt_cpf_LostFocus(sender As Object, e As EventArgs) Handles txt_cpf.LostFocus
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"
        Dim conexao As New SQLiteConnection("Data Source=" & caminhoDB)
        Dim buscaNome As String = txt_nome.Text
        nome = txt_nome.Text
        telefone = txt_tel.Text
        telefone2 = txt_tel2.Text
        cep = txt_cep.Text
        numero = txt_num.Text
        Try
            conexao.Open()
            Dim query As New SQLiteCommand("SELECT * FROM pacientes WHERE cpf = @cpf", conexao)
            query.Parameters.AddWithValue("@cpf", txt_cpf.Text)
            Dim leitor As SQLiteDataReader = query.ExecuteReader()
            While leitor.Read()
                nome = leitor("nome")
                telefone = leitor("telefone")
                telefone2 = leitor("telefone2")
                cep = leitor("cep")
                numero = leitor("numero")
            End While
            txt_nome.Text = nome
            txt_tel.Text = telefone
            txt_tel2.Text = telefone2
            txt_cep.Text = cep
            txt_num.Text = numero
            leitor.Close()
            conexao.Close()
        Catch ex As Exception
            MessageBox.Show("Erro na busca: " & ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim novaTela As New Menu()
        novaTela.Show()
        Me.Close()
    End Sub
End Class
