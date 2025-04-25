<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TelaMedico
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaMedico))
        Me.lstPacientes = New System.Windows.Forms.ListBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.TxtCPF = New System.Windows.Forms.TextBox()
        Me.TxtRelato = New System.Windows.Forms.TextBox()
        Me.TxtBusca = New System.Windows.Forms.TextBox()
        Me.TxtRelatorio = New System.Windows.Forms.TextBox()
        Me.TxtMedicamentos = New System.Windows.Forms.TextBox()
        Me.btnFinalizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RECEPÇÃO = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dData = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAlt = New System.Windows.Forms.TextBox()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.txtPres = New System.Windows.Forms.TextBox()
        Me.txtRisco = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRisco1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dData1 = New System.Windows.Forms.Label()
        Me.txtPeso1 = New System.Windows.Forms.Label()
        Me.txtAlt1 = New System.Windows.Forms.Label()
        Me.txtTemp1 = New System.Windows.Forms.Label()
        Me.txtPres1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPacientes
        '
        Me.lstPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPacientes.FormattingEnabled = True
        Me.lstPacientes.ItemHeight = 16
        Me.lstPacientes.Location = New System.Drawing.Point(41, 146)
        Me.lstPacientes.Name = "lstPacientes"
        Me.lstPacientes.Size = New System.Drawing.Size(463, 404)
        Me.lstPacientes.TabIndex = 0
        '
        'TxtNome
        '
        Me.TxtNome.Enabled = False
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(581, 146)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.ReadOnly = True
        Me.TxtNome.Size = New System.Drawing.Size(315, 26)
        Me.TxtNome.TabIndex = 1
        '
        'TxtCPF
        '
        Me.TxtCPF.Enabled = False
        Me.TxtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCPF.Location = New System.Drawing.Point(1013, 146)
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.ReadOnly = True
        Me.TxtCPF.Size = New System.Drawing.Size(315, 26)
        Me.TxtCPF.TabIndex = 2
        '
        'TxtRelato
        '
        Me.TxtRelato.Location = New System.Drawing.Point(581, 226)
        Me.TxtRelato.Multiline = True
        Me.TxtRelato.Name = "TxtRelato"
        Me.TxtRelato.Size = New System.Drawing.Size(747, 143)
        Me.TxtRelato.TabIndex = 3
        '
        'TxtBusca
        '
        Me.TxtBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusca.Location = New System.Drawing.Point(41, 128)
        Me.TxtBusca.Name = "TxtBusca"
        Me.TxtBusca.Size = New System.Drawing.Size(463, 22)
        Me.TxtBusca.TabIndex = 4
        '
        'TxtRelatorio
        '
        Me.TxtRelatorio.Location = New System.Drawing.Point(581, 414)
        Me.TxtRelatorio.Multiline = True
        Me.TxtRelatorio.Name = "TxtRelatorio"
        Me.TxtRelatorio.Size = New System.Drawing.Size(747, 171)
        Me.TxtRelatorio.TabIndex = 5
        '
        'TxtMedicamentos
        '
        Me.TxtMedicamentos.Location = New System.Drawing.Point(581, 626)
        Me.TxtMedicamentos.Multiline = True
        Me.TxtMedicamentos.Name = "TxtMedicamentos"
        Me.TxtMedicamentos.Size = New System.Drawing.Size(747, 110)
        Me.TxtMedicamentos.TabIndex = 6
        '
        'btnFinalizar
        '
        Me.btnFinalizar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnFinalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFinalizar.ForeColor = System.Drawing.Color.White
        Me.btnFinalizar.Location = New System.Drawing.Point(581, 780)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(747, 38)
        Me.btnFinalizar.TabIndex = 7
        Me.btnFinalizar.Text = "Finalizar Atendimento"
        Me.btnFinalizar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(578, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nome do Paciente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1010, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CPF do Paciente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(578, 207)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(176, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "RELATO DO PACIENTE:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(578, 395)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "RELATORIO MÉDICO:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(578, 607)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "MEDICAMENTOS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(1306, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 24)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(1306, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "*"
        '
        'RECEPÇÃO
        '
        Me.RECEPÇÃO.AutoSize = True
        Me.RECEPÇÃO.BackColor = System.Drawing.Color.Transparent
        Me.RECEPÇÃO.Font = New System.Drawing.Font("Perpetua", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RECEPÇÃO.Location = New System.Drawing.Point(571, 9)
        Me.RECEPÇÃO.Name = "RECEPÇÃO"
        Me.RECEPÇÃO.Size = New System.Drawing.Size(285, 60)
        Me.RECEPÇÃO.TabIndex = 15
        Me.RECEPÇÃO.Text = "CONSULTA"
        Me.RECEPÇÃO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 109)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(153, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Pesquisar Paciente:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1264, 934)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 39)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.dData)
        Me.GroupBox1.Controls.Add(Me.txtPeso)
        Me.GroupBox1.Controls.Add(Me.txtAlt)
        Me.GroupBox1.Controls.Add(Me.txtTemp)
        Me.GroupBox1.Controls.Add(Me.txtPres)
        Me.GroupBox1.Controls.Add(Me.txtRisco)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtRisco1)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dData1)
        Me.GroupBox1.Controls.Add(Me.txtPeso1)
        Me.GroupBox1.Controls.Add(Me.txtAlt1)
        Me.GroupBox1.Controls.Add(Me.txtTemp1)
        Me.GroupBox1.Controls.Add(Me.txtPres1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(43, 567)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(460, 251)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Triagem"
        '
        'dData
        '
        Me.dData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dData.Location = New System.Drawing.Point(158, 196)
        Me.dData.Margin = New System.Windows.Forms.Padding(2)
        Me.dData.Name = "dData"
        Me.dData.ReadOnly = True
        Me.dData.Size = New System.Drawing.Size(84, 23)
        Me.dData.TabIndex = 15
        Me.dData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(60, 163)
        Me.txtPeso.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.ReadOnly = True
        Me.txtPeso.Size = New System.Drawing.Size(84, 23)
        Me.txtPeso.TabIndex = 14
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtAlt
        '
        Me.txtAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt.Location = New System.Drawing.Point(65, 131)
        Me.txtAlt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtAlt.Name = "txtAlt"
        Me.txtAlt.ReadOnly = True
        Me.txtAlt.Size = New System.Drawing.Size(84, 23)
        Me.txtAlt.TabIndex = 13
        Me.txtAlt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(110, 96)
        Me.txtTemp.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.ReadOnly = True
        Me.txtTemp.Size = New System.Drawing.Size(84, 23)
        Me.txtTemp.TabIndex = 12
        Me.txtTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPres
        '
        Me.txtPres.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPres.Location = New System.Drawing.Point(130, 63)
        Me.txtPres.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPres.Name = "txtPres"
        Me.txtPres.ReadOnly = True
        Me.txtPres.Size = New System.Drawing.Size(84, 23)
        Me.txtPres.TabIndex = 11
        Me.txtPres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRisco
        '
        Me.txtRisco.Location = New System.Drawing.Point(64, 30)
        Me.txtRisco.Margin = New System.Windows.Forms.Padding(2)
        Me.txtRisco.Name = "txtRisco"
        Me.txtRisco.ReadOnly = True
        Me.txtRisco.Size = New System.Drawing.Size(144, 23)
        Me.txtRisco.TabIndex = 10
        Me.txtRisco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-7, 102)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 15)
        Me.Label11.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 15)
        Me.Label10.TabIndex = 8
        '
        'txtRisco1
        '
        Me.txtRisco1.AutoSize = True
        Me.txtRisco1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRisco1.Location = New System.Drawing.Point(13, 38)
        Me.txtRisco1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtRisco1.Name = "txtRisco1"
        Me.txtRisco1.Size = New System.Drawing.Size(47, 15)
        Me.txtRisco1.TabIndex = 6
        Me.txtRisco1.Text = "Risco:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 200)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(0, 15)
        Me.Label14.TabIndex = 5
        '
        'dData1
        '
        Me.dData1.AutoSize = True
        Me.dData1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dData1.Location = New System.Drawing.Point(13, 200)
        Me.dData1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.dData1.Name = "dData1"
        Me.dData1.Size = New System.Drawing.Size(141, 15)
        Me.dData1.TabIndex = 4
        Me.dData1.Text = "Data de Nascimento:"
        '
        'txtPeso1
        '
        Me.txtPeso1.AutoSize = True
        Me.txtPeso1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso1.Location = New System.Drawing.Point(13, 167)
        Me.txtPeso1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPeso1.Name = "txtPeso1"
        Me.txtPeso1.Size = New System.Drawing.Size(43, 15)
        Me.txtPeso1.TabIndex = 3
        Me.txtPeso1.Text = "Peso:"
        '
        'txtAlt1
        '
        Me.txtAlt1.AutoSize = True
        Me.txtAlt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt1.Location = New System.Drawing.Point(13, 135)
        Me.txtAlt1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtAlt1.Name = "txtAlt1"
        Me.txtAlt1.Size = New System.Drawing.Size(48, 15)
        Me.txtAlt1.TabIndex = 2
        Me.txtAlt1.Text = "Altura:"
        '
        'txtTemp1
        '
        Me.txtTemp1.AutoSize = True
        Me.txtTemp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp1.Location = New System.Drawing.Point(13, 102)
        Me.txtTemp1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtTemp1.Name = "txtTemp1"
        Me.txtTemp1.Size = New System.Drawing.Size(93, 15)
        Me.txtTemp1.TabIndex = 1
        Me.txtTemp1.Text = "Temperatura:"
        '
        'txtPres1
        '
        Me.txtPres1.AutoSize = True
        Me.txtPres1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPres1.Location = New System.Drawing.Point(13, 71)
        Me.txtPres1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtPres1.Name = "txtPres1"
        Me.txtPres1.Size = New System.Drawing.Size(113, 15)
        Me.txtPres1.TabIndex = 0
        Me.txtPres1.Text = "Pressão Arterial:"
        '
        'TelaMedico
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1424, 985)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RECEPÇÃO)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.TxtMedicamentos)
        Me.Controls.Add(Me.TxtRelatorio)
        Me.Controls.Add(Me.TxtBusca)
        Me.Controls.Add(Me.TxtRelato)
        Me.Controls.Add(Me.TxtCPF)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.lstPacientes)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "TelaMedico"
        Me.Text = "TelaMedico"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPacientes As ListBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents TxtCPF As TextBox
    Friend WithEvents TxtRelato As TextBox
    Friend WithEvents TxtBusca As TextBox
    Friend WithEvents TxtRelatorio As TextBox
    Friend WithEvents TxtMedicamentos As TextBox
    Friend WithEvents btnFinalizar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents RECEPÇÃO As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents dData1 As Label
    Friend WithEvents txtPeso1 As Label
    Friend WithEvents txtAlt1 As Label
    Friend WithEvents txtTemp1 As Label
    Friend WithEvents txtPres1 As Label
    Friend WithEvents txtRisco1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents dData As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents txtAlt As TextBox
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents txtPres As TextBox
    Friend WithEvents txtRisco As TextBox
End Class
