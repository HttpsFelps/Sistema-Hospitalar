Imports System.Data.SQLite

Public Class TelaTriagem
    ' conecxao com o bd ------------------------
    Private Sub lstPacientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPacientes.SelectedIndexChanged
        If lstPacientes.SelectedItem Is Nothing Then Exit Sub

        Dim nomeSelecionado As String = lstPacientes.SelectedItem.ToString()

        Dim conn As New SQLiteConnection("Data Source=banco.db")
        conn.Open()

        Dim query As String = "SELECT nome, cpf FROM pacientes WHERE nome = @nome"
        Dim cmd As New SQLiteCommand(query, conn)
        cmd.Parameters.AddWithValue("@nome", nomeSelecionado)

        Dim reader As SQLiteDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            TxtNome.Text = reader("nome").ToString()
            TxtCPF.Text = reader("cpf").ToString()
        End If

        reader.Close()
        conn.Close()
    End Sub
    ' definindo as variaveis ----------------------
    Dim risco
    Dim data
    Dim ttemp
    Dim pressao
    Dim peso
    Dim alt
    Dim nome
    Dim CPF
    ' verifica o valor do ckeck box -------------- 
    Sub check_box()
        If cb_Normal.Checked Then
            risco = "normal"
        ElseIf cb_poucoUrgente.Checked Then
            risco = "Pouco urgente"

        ElseIf cb_Urgente.Checked Then
            risco = "Urgente"
        End If
        If risco = "" Then
            MessageBox.Show("selecione um risco")
        End If
    End Sub
    ' checa a temperatura -----------------
    Sub temp()
        Dim temp = txtTemp.Text
        If temp = "" Then
            MessageBox.Show("digite a temperatura")
        Else
            ttemp = txtTemp.Text
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub
    ' CLEAR
    Private Sub limparcampos()
        TxtNome.Clear()
        TxtCPF.Clear()
        dData.Checked = False

        txtTemp.Clear()
        txtAlt.Clear()
        txtPeso.Clear()
        txtPres.Clear()


    End Sub
    ' envia as respostas para o banco de dados ----------------------------


    ' ----------------- chamar os pacientes pelo nome ja cadastrado
    Private Sub TelaTriagem_load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstPacientes.Items.Clear()

        Dim conn As New SQLiteConnection("Data Source=banco.db")
        conn.Open()

        Dim query As String = "SELECT nome FROM pacientes"
        Dim cmd As New SQLiteCommand(query, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim nome As String = reader("nome").ToString()
            lstPacientes.Items.Add(nome)
        End While

        reader.Close()
        conn.Close()

    End Sub
    ' check box checagem ---------------------- 
    Private Sub cb_Normal_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Normal.CheckedChanged
        If cb_Normal.Checked Then
            cb_poucoUrgente.Checked = False
            cb_Urgente.Checked = False
        End If
    End Sub

    Private Sub cb_poucoUrgente_CheckedChanged(sender As Object, e As EventArgs) Handles cb_poucoUrgente.CheckedChanged
        If cb_poucoUrgente.Checked Then
            cb_Normal.Checked = False
            cb_Urgente.Checked = False
        End If
    End Sub

    Private Sub cb_Urgente_CheckedChanged(sender As Object, e As EventArgs) Handles cb_Urgente.CheckedChanged
        If cb_Urgente.Checked Then
            cb_poucoUrgente.Checked = False
            cb_Normal.Checked = False
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim novaTela As New Menu()
        novaTela.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class
