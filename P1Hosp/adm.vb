Imports System.Data.SQLite
Imports System.IO
Imports System.Data

Public Class adm

    ' Variáveis globais
    Private adaptador As SQLiteDataAdapter
    Private tabela As DataTable
    Private conexao As SQLiteConnection

    Private Sub adm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarDados()
    End Sub

    Private Sub CarregarDados()
        Dim caminhoDB As String = Application.StartupPath & "\banco.db"

        ' Verifica se o banco existe
        If Not File.Exists(caminhoDB) Then
            MessageBox.Show("Banco de dados não encontrado.")
            Exit Sub
        End If

        conexao = New SQLiteConnection("Data Source=" & caminhoDB)

        Try
            conexao.Open()

            Dim sql As String = "SELECT id, email, senha, adm FROM colaboradores"
            adaptador = New SQLiteDataAdapter(sql, conexao)

            ' Permite geração automática dos comandos
            Dim builder As New SQLiteCommandBuilder(adaptador)

            tabela = New DataTable()
            adaptador.Fill(tabela)

            DataGridView1.DataSource = tabela

            ' Configurações do DataGridView
            DataGridView1.AllowUserToAddRows = True
            DataGridView1.AllowUserToDeleteRows = True
            DataGridView1.ReadOnly = False
            DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            ' Impede edição do campo ID
            If DataGridView1.Columns.Contains("id") Then
                DataGridView1.Columns("id").ReadOnly = True
            End If

        Catch ex As Exception
            MessageBox.Show("Erro ao carregar dados: " & ex.Message)
        Finally
            conexao.Close()
        End Try
    End Sub

    ' Evento para preencher ID automaticamente ao adicionar linha
    Private Sub DataGridView1_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles DataGridView1.DefaultValuesNeeded
        Dim proximoId As Integer = 1

        If tabela.Rows.Count > 0 Then
            Dim maiorId As Integer = 0
            For Each row As DataRow In tabela.Rows
                If Not IsDBNull(row("id")) Then
                    Dim valorId As Integer = Convert.ToInt32(row("id"))
                    If valorId > maiorId Then
                        maiorId = valorId
                    End If
                End If
            Next
            proximoId = maiorId + 1
        End If

        e.Row.Cells("id").Value = proximoId
        e.Row.Cells("adm").Value = 0
    End Sub

    ' Botão para salvar alterações
    Private Sub btnSalvar_Click(sender As Object, e As EventArgs) Handles btnSalvar.Click
        Try
            conexao.Open()
            adaptador.Update(tabela)
            MessageBox.Show("Alterações salvas com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Erro ao salvar alterações: " & ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conexao.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim novaTela As New Menu()
        novaTela.Show()
        Me.Close()
    End Sub
End Class
