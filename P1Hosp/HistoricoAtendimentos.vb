Imports System.Data.SQLite

Public Class HistoricoAtendimentos
    Public Property Menu

    ' Carregar atendimentos por CPF digitado
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        If txtBuscaCPF.Text = "" Then
            MessageBox.Show("Digite um CPF para buscar.")
            Exit Sub
        End If

        Dim conn As New SQLiteConnection("Data Source=banco.db")
        conn.Open()

        Dim query As String = "
        SELECT 
            nome_paciente AS 'Nome',
            cpf_paciente AS 'CPF',
            strftime('%Y-%m-%d %H:%M', data_atendimento) AS 'Data'
        FROM atendimentos
        WHERE cpf_paciente = @cpf
        ORDER BY datetime(data_atendimento) DESC
    "

        Dim cmd As New SQLiteCommand(query, conn)
        cmd.Parameters.AddWithValue("@cpf", txtBuscaCPF.Text)

        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        DgvAtendimentos.DataSource = dt

        conn.Close()
    End Sub


    ' Ao clicar em uma linha da tabela, preencher os campos de detalhe
    Private Sub DgvAtendimentos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAtendimentos.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DgvAtendimentos.Rows(e.RowIndex)
            Dim cpfSelecionado As String = row.Cells("CPF").Value.ToString()
            Dim dataSelecionada As String = row.Cells("Data").Value.ToString()

            Dim conn As New SQLiteConnection("Data Source=banco.db")
            conn.Open()

            Dim query As String = "
            SELECT 
                nome_paciente,
                cpf_paciente,
                relato,
                relatorio_medico,
                medicamentos
            FROM atendimentos
            WHERE cpf_paciente = @cpf 
              AND substr(data_atendimento, 1, 16) = substr(@data, 1, 16)
        "

            Dim cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@cpf", cpfSelecionado)
            cmd.Parameters.AddWithValue("@data", dataSelecionada)

            Dim reader As SQLiteDataReader = cmd.ExecuteReader()

            If reader.Read() Then
                txtNome.Text = reader("nome_paciente").ToString()
                txtCPF.Text = reader("cpf_paciente").ToString()
                txtData.Text = dataSelecionada
                txtRelato.Text = reader("relato").ToString()
                txtRelatorio.Text = reader("relatorio_medico").ToString()
                txtMedicamentos.Text = reader("medicamentos").ToString()
            Else
                MessageBox.Show("Dados não encontrados para este atendimento.")
            End If

            conn.Close()
        End If
    End Sub



    ' Voltar ao menu principal
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Menu = New Menu()
        Menu.Show()
        Me.Close()
    End Sub
End Class
