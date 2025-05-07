Imports System.Data.SQLite

Public Class TelaMedico

    Private Sub TelaMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregarPacientes("") ' Carrega todos ao iniciar
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBusca.TextChanged
        CarregarPacientes(TxtBusca.Text.Trim())
    End Sub

    Private Sub CarregarPacientes(filtro As String)
        lstPacientes.Items.Clear()

        Dim conn As New SQLiteConnection("Data Source=banco.db")
        conn.Open()

        Dim query As String = "SELECT p.nome, t.risco FROM pacientes p LEFT JOIN triagem t ON p.cpf = t.cpf"
        If Not String.IsNullOrEmpty(filtro) Then
            query &= " WHERE LOWER(p.nome) LIKE @filtro"
        End If

        Dim cmd As New SQLiteCommand(query, conn)
        If Not String.IsNullOrEmpty(filtro) Then
            cmd.Parameters.AddWithValue("@filtro", "%" & filtro.ToLower() & "%")
        End If

        Dim reader As SQLiteDataReader = cmd.ExecuteReader()
        Dim listaPacientes As New List(Of Tuple(Of Integer, String))

        While reader.Read()
            Dim nome As String = reader("nome").ToString()
            Dim riscoRaw As String = If(reader("risco") IsNot DBNull.Value, reader("risco").ToString().ToUpper(), "SEM TRIAGEM")
            Dim prioridade As Integer

            Select Case riscoRaw
                Case "URGENTE"
                    prioridade = 1
                Case "POUCO URGENTE"
                    prioridade = 2
                Case "NORMAL"
                    prioridade = 3
                Case Else
                    prioridade = 4
            End Select

            Dim itemTexto As String = nome & " [" & riscoRaw & "]"
            listaPacientes.Add(Tuple.Create(prioridade, itemTexto))
        End While

        reader.Close()
        conn.Close()

        For Each item In listaPacientes.OrderBy(Function(x) x.Item1)
            lstPacientes.Items.Add(item.Item2)
        Next
    End Sub

    Private Sub lstPacientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPacientes.SelectedIndexChanged
        If lstPacientes.SelectedItem Is Nothing Then Exit Sub

        Dim nomeComRisco As String = lstPacientes.SelectedItem.ToString()
        Dim nomeSelecionado As String = nomeComRisco.Split("["c)(0).Trim()

        Dim conn As New SQLiteConnection("Data Source=banco.db")
        conn.Open()

        ' Buscar nome e CPF do paciente
        Dim query As String = "SELECT nome, cpf FROM pacientes WHERE nome = @nome"
        Dim cmd As New SQLiteCommand(query, conn)
        cmd.Parameters.AddWithValue("@nome", nomeSelecionado)

        Dim reader As SQLiteDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            TxtNome.Text = reader("nome").ToString()
            TxtCPF.Text = reader("cpf").ToString()
        End If

        reader.Close()

        ' Buscar dados da triagem
        Dim queryTriagem As String = "SELECT pressao, temperatura, altura, peso, risco, data_nascimento FROM triagem WHERE CPF = @cpf"
        Dim cmdTriagem As New SQLiteCommand(queryTriagem, conn)
        cmdTriagem.Parameters.AddWithValue("@cpf", TxtCPF.Text)

        Dim readerTriagem As SQLiteDataReader = cmdTriagem.ExecuteReader()

        If readerTriagem.Read() Then
            txtPres.Text = readerTriagem("pressao").ToString()
            txtTemp.Text = readerTriagem("temperatura").ToString()
            txtAlt.Text = readerTriagem("altura").ToString()
            txtPeso.Text = readerTriagem("peso").ToString()
            txtRisco.Text = readerTriagem("risco").ToString()

            Dim dataOriginal As String = readerTriagem("data_nascimento").ToString()
            Dim dataConvertida As DateTime

            If Date.TryParse(dataOriginal, dataConvertida) Then
                dData.Text = dataConvertida.ToString("dd/MM/yyyy")
            Else
                dData.Text = "-"
            End If
        Else
            txtPres.Text = "-"
            txtTemp.Text = "-"
            txtAlt.Text = "-"
            txtPeso.Text = "-"
            txtRisco.Text = "Não informado"
            dData.Text = "-"
        End If

        readerTriagem.Close()
        conn.Close()
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        If TxtNome.Text = "" Or TxtCPF.Text = "" Then
            MessageBox.Show("Selecione um paciente primeiro!")
            Exit Sub
        End If

        If TxtRelato.Text = "" Or TxtRelatorio.Text = "" Then
            MessageBox.Show("Preencha o relato do paciente e o relatório médico antes de finalizar o atendimento.")
            Exit Sub
        End If

        Dim conn As New SQLiteConnection("Data Source=banco.db")
        conn.Open()

        Dim query As String = "INSERT INTO atendimentos (nome_paciente, cpf_paciente, relato, relatorio_medico, medicamentos) " &
                              "VALUES (@nome, @cpf, @relato, @relatorio, @medicamentos)"
        Dim cmd As New SQLiteCommand(query, conn)

        cmd.Parameters.AddWithValue("@nome", TxtNome.Text)
        cmd.Parameters.AddWithValue("@cpf", TxtCPF.Text)
        cmd.Parameters.AddWithValue("@relato", TxtRelato.Text)
        cmd.Parameters.AddWithValue("@relatorio", TxtRelatorio.Text)
        cmd.Parameters.AddWithValue("@medicamentos", TxtMedicamentos.Text)

        cmd.ExecuteNonQuery()
        conn.Close()

        MessageBox.Show("Atendimento salvo com sucesso!")

        TxtRelato.Clear()
        TxtRelatorio.Clear()
        TxtMedicamentos.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim novaTela As New Menu()
        novaTela.Show()
        Me.Close()
    End Sub
End Class
