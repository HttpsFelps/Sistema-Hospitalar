Imports System.Data.SQLite

Public Class Menu
    Private Sub btn_rec_Click(sender As Object, e As EventArgs) Handles btn_rec.Click
        Dim novaTela As New Form_recep()
        novaTela.Show()
        Me.Close()
    End Sub

    Private Sub btn_tri_Click(sender As Object, e As EventArgs) Handles btn_tri.Click
        Dim novaTela As New TelaTriagem()
        novaTela.Show()
        Me.Close()
    End Sub

    Private Sub btn_med_Click(sender As Object, e As EventArgs) Handles btn_med.Click
        Dim novaTela As New TelaMedico()
        novaTela.Show()
        Me.Close()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim novaTela As New HistoricoAtendimentos()
        novaTela.Show()
        Me.Close()
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Atendimentos()
    End Sub
    Private Sub Atendimentos()
        Try
            Dim conn As New SQLiteConnection("Data Source=banco.db")
            conn.Open()

            Dim query As String = "
            CREATE TABLE IF NOT EXISTS atendimentos (
                id INTEGER PRIMARY KEY AUTOINCREMENT,
                nome_paciente TEXT,
                cpf_paciente TEXT,
                relato TEXT,
                relatorio_medico TEXT,
                medicamentos TEXT,
                data_atendimento DATETIME DEFAULT CURRENT_TIMESTAMP
            );"

            Dim cmd As New SQLiteCommand(query, conn)
            cmd.ExecuteNonQuery()

            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Erro ao criar a tabela de atendimentos: " & ex.Message)
        End Try
    End Sub



End Class