<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TelaTriagem
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TelaTriagem))
        Me.btnProx = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPres = New System.Windows.Forms.TextBox()
        Me.txtAlt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTemp = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAltura = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPressao = New System.Windows.Forms.Label()
        Me.cb_Normal = New System.Windows.Forms.CheckBox()
        Me.cb_Urgente = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cb_poucoUrgente = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dData = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtBusca = New System.Windows.Forms.TextBox()
        Me.TxtCPF = New System.Windows.Forms.TextBox()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.lstPacientes = New System.Windows.Forms.ListBox()
        Me.RECEPÇÃO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnProx
        '
        Me.btnProx.BackColor = System.Drawing.Color.Lime
        Me.btnProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProx.Location = New System.Drawing.Point(956, 1334)
        Me.btnProx.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnProx.Name = "btnProx"
        Me.btnProx.Size = New System.Drawing.Size(1092, 75)
        Me.btnProx.TabIndex = 42
        Me.btnProx.Text = "Direcionar Medico"
        Me.btnProx.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1908, 1440)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 57)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(1886, 266)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 16)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "*"
        '
        'txtPres
        '
        Me.txtPres.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPres.Location = New System.Drawing.Point(657, 398)
        Me.txtPres.Name = "txtPres"
        Me.txtPres.Size = New System.Drawing.Size(306, 31)
        Me.txtPres.TabIndex = 76
        '
        'txtAlt
        '
        Me.txtAlt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlt.Location = New System.Drawing.Point(1030, 198)
        Me.txtAlt.Name = "txtAlt"
        Me.txtAlt.Size = New System.Drawing.Size(306, 31)
        Me.txtAlt.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(1317, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "*"
        '
        'txtTemp
        '
        Me.txtTemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp.Location = New System.Drawing.Point(1030, 299)
        Me.txtTemp.Name = "txtTemp"
        Me.txtTemp.Size = New System.Drawing.Size(306, 31)
        Me.txtTemp.TabIndex = 73
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(657, 299)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(306, 31)
        Me.txtPeso.TabIndex = 72
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(1192, 938)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(220, 35)
        Me.Button2.TabIndex = 71
        Me.Button2.Text = "Voltar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(660, 206)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 18)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "*"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(657, 774)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(679, 52)
        Me.Button3.TabIndex = 69
        Me.Button3.Text = "Direcionar Medico"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(1024, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 31)
        Me.Label9.TabIndex = 68
        Me.Label9.Text = "Temperatura"
        '
        'txtAltura
        '
        Me.txtAltura.AutoSize = True
        Me.txtAltura.BackColor = System.Drawing.Color.Transparent
        Me.txtAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAltura.Location = New System.Drawing.Point(1024, 163)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(85, 31)
        Me.txtAltura.TabIndex = 67
        Me.txtAltura.Text = "Altura"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(651, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 31)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "Peso"
        '
        'txtPressao
        '
        Me.txtPressao.AutoSize = True
        Me.txtPressao.BackColor = System.Drawing.Color.Transparent
        Me.txtPressao.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPressao.Location = New System.Drawing.Point(651, 363)
        Me.txtPressao.Name = "txtPressao"
        Me.txtPressao.Size = New System.Drawing.Size(204, 31)
        Me.txtPressao.TabIndex = 65
        Me.txtPressao.Text = "Pressão arterial"
        '
        'cb_Normal
        '
        Me.cb_Normal.AutoSize = True
        Me.cb_Normal.BackColor = System.Drawing.Color.Transparent
        Me.cb_Normal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Normal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Normal.Location = New System.Drawing.Point(657, 547)
        Me.cb_Normal.Name = "cb_Normal"
        Me.cb_Normal.Size = New System.Drawing.Size(120, 35)
        Me.cb_Normal.TabIndex = 64
        Me.cb_Normal.Text = "Normal"
        Me.cb_Normal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_Normal.UseVisualStyleBackColor = False
        '
        'cb_Urgente
        '
        Me.cb_Urgente.AutoSize = True
        Me.cb_Urgente.BackColor = System.Drawing.Color.Transparent
        Me.cb_Urgente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_Urgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_Urgente.Location = New System.Drawing.Point(657, 588)
        Me.cb_Urgente.Name = "cb_Urgente"
        Me.cb_Urgente.Size = New System.Drawing.Size(130, 35)
        Me.cb_Urgente.TabIndex = 63
        Me.cb_Urgente.Text = "Urgente"
        Me.cb_Urgente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_Urgente.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(651, 472)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 31)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Risco"
        '
        'cb_poucoUrgente
        '
        Me.cb_poucoUrgente.AutoSize = True
        Me.cb_poucoUrgente.BackColor = System.Drawing.Color.Transparent
        Me.cb_poucoUrgente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_poucoUrgente.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_poucoUrgente.Location = New System.Drawing.Point(657, 506)
        Me.cb_poucoUrgente.Name = "cb_poucoUrgente"
        Me.cb_poucoUrgente.Size = New System.Drawing.Size(209, 35)
        Me.cb_poucoUrgente.TabIndex = 61
        Me.cb_poucoUrgente.Text = "Pouco urgente"
        Me.cb_poucoUrgente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_poucoUrgente.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(651, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(255, 31)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Data de nascimento"
        '
        'dData
        '
        Me.dData.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dData.Location = New System.Drawing.Point(657, 200)
        Me.dData.Name = "dData"
        Me.dData.Size = New System.Drawing.Size(306, 29)
        Me.dData.TabIndex = 59
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 48)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(256, 31)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Pesquisar Paciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1024, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(219, 31)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "CPF do Paciente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(651, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(236, 31)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Nome do Paciente"
        '
        'TxtBusca
        '
        Me.TxtBusca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBusca.Location = New System.Drawing.Point(76, 82)
        Me.TxtBusca.Name = "TxtBusca"
        Me.TxtBusca.Size = New System.Drawing.Size(475, 22)
        Me.TxtBusca.TabIndex = 55
        '
        'TxtCPF
        '
        Me.TxtCPF.Enabled = False
        Me.TxtCPF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCPF.Location = New System.Drawing.Point(1030, 102)
        Me.TxtCPF.Name = "TxtCPF"
        Me.TxtCPF.ReadOnly = True
        Me.TxtCPF.Size = New System.Drawing.Size(306, 31)
        Me.TxtCPF.TabIndex = 54
        '
        'TxtNome
        '
        Me.TxtNome.Enabled = False
        Me.TxtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNome.Location = New System.Drawing.Point(657, 102)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.ReadOnly = True
        Me.TxtNome.Size = New System.Drawing.Size(306, 31)
        Me.TxtNome.TabIndex = 53
        '
        'lstPacientes
        '
        Me.lstPacientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPacientes.FormattingEnabled = True
        Me.lstPacientes.ItemHeight = 16
        Me.lstPacientes.Location = New System.Drawing.Point(76, 102)
        Me.lstPacientes.Name = "lstPacientes"
        Me.lstPacientes.Size = New System.Drawing.Size(475, 724)
        Me.lstPacientes.TabIndex = 52
        '
        'RECEPÇÃO
        '
        Me.RECEPÇÃO.BackColor = System.Drawing.Color.Transparent
        Me.RECEPÇÃO.Font = New System.Drawing.Font("Perpetua", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RECEPÇÃO.Location = New System.Drawing.Point(123, 9)
        Me.RECEPÇÃO.Name = "RECEPÇÃO"
        Me.RECEPÇÃO.Size = New System.Drawing.Size(1115, 60)
        Me.RECEPÇÃO.TabIndex = 51
        Me.RECEPÇÃO.Text = "TRIAGEM"
        Me.RECEPÇÃO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TelaTriagem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1424, 985)
        Me.Controls.Add(Me.txtPres)
        Me.Controls.Add(Me.txtAlt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTemp)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPressao)
        Me.Controls.Add(Me.cb_Normal)
        Me.Controls.Add(Me.cb_Urgente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cb_poucoUrgente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtBusca)
        Me.Controls.Add(Me.TxtCPF)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.lstPacientes)
        Me.Controls.Add(Me.RECEPÇÃO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnProx)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "TelaTriagem"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TelaTriagem"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnProx As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtPres As TextBox
    Friend WithEvents txtAlt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTemp As TextBox
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAltura As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPressao As Label
    Friend WithEvents cb_Normal As CheckBox
    Friend WithEvents cb_Urgente As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cb_poucoUrgente As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dData As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtBusca As TextBox
    Friend WithEvents TxtCPF As TextBox
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents lstPacientes As ListBox
    Friend WithEvents RECEPÇÃO As Label
End Class
