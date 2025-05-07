<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_recep
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form_recep))
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.txt_nomeac = New System.Windows.Forms.TextBox()
        Me.txt_tel = New System.Windows.Forms.MaskedTextBox()
        Me.txt_tel2 = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpf = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cep = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cpfac = New System.Windows.Forms.MaskedTextBox()
        Me.cb_op1 = New System.Windows.Forms.CheckBox()
        Me.cb_op2 = New System.Windows.Forms.CheckBox()
        Me.RECEPÇÃO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_addpac = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome.Location = New System.Drawing.Point(433, 71)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(300, 35)
        Me.txt_nome.TabIndex = 0
        '
        'txt_num
        '
        Me.txt_num.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_num.Location = New System.Drawing.Point(432, 73)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(300, 35)
        Me.txt_num.TabIndex = 1
        '
        'txt_nomeac
        '
        Me.txt_nomeac.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nomeac.Location = New System.Drawing.Point(58, 172)
        Me.txt_nomeac.Name = "txt_nomeac"
        Me.txt_nomeac.Size = New System.Drawing.Size(300, 35)
        Me.txt_nomeac.TabIndex = 2
        '
        'txt_tel
        '
        Me.txt_tel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel.Location = New System.Drawing.Point(58, 194)
        Me.txt_tel.Mask = "(99) 00000-0000"
        Me.txt_tel.Name = "txt_tel"
        Me.txt_tel.Size = New System.Drawing.Size(300, 35)
        Me.txt_tel.TabIndex = 3
        '
        'txt_tel2
        '
        Me.txt_tel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_tel2.Location = New System.Drawing.Point(433, 194)
        Me.txt_tel2.Mask = "(99) 00000-0000"
        Me.txt_tel2.Name = "txt_tel2"
        Me.txt_tel2.Size = New System.Drawing.Size(300, 35)
        Me.txt_tel2.TabIndex = 4
        '
        'txt_cpf
        '
        Me.txt_cpf.BackColor = System.Drawing.SystemColors.Window
        Me.txt_cpf.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpf.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_cpf.Location = New System.Drawing.Point(57, 71)
        Me.txt_cpf.Mask = "000,000,000-99"
        Me.txt_cpf.Name = "txt_cpf"
        Me.txt_cpf.Size = New System.Drawing.Size(300, 35)
        Me.txt_cpf.TabIndex = 7
        '
        'txt_cep
        '
        Me.txt_cep.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cep.Location = New System.Drawing.Point(57, 73)
        Me.txt_cep.Mask = "00000-999"
        Me.txt_cep.Name = "txt_cep"
        Me.txt_cep.Size = New System.Drawing.Size(300, 35)
        Me.txt_cep.TabIndex = 8
        '
        'txt_cpfac
        '
        Me.txt_cpfac.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cpfac.Location = New System.Drawing.Point(433, 172)
        Me.txt_cpfac.Mask = "000,000,000-99"
        Me.txt_cpfac.Name = "txt_cpfac"
        Me.txt_cpfac.Size = New System.Drawing.Size(300, 35)
        Me.txt_cpfac.TabIndex = 9
        '
        'cb_op1
        '
        Me.cb_op1.AutoSize = True
        Me.cb_op1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_op1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_op1.Location = New System.Drawing.Point(58, 45)
        Me.cb_op1.Name = "cb_op1"
        Me.cb_op1.Size = New System.Drawing.Size(343, 33)
        Me.cb_op1.TabIndex = 11
        Me.cb_op1.Text = "PEDIATRIA - MENOR DE 18 "
        Me.cb_op1.UseVisualStyleBackColor = True
        '
        'cb_op2
        '
        Me.cb_op2.AutoSize = True
        Me.cb_op2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_op2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_op2.Location = New System.Drawing.Point(58, 93)
        Me.cb_op2.Name = "cb_op2"
        Me.cb_op2.Size = New System.Drawing.Size(326, 33)
        Me.cb_op2.TabIndex = 12
        Me.cb_op2.Text = "GERIATRIA - MAIOR DE 65"
        Me.cb_op2.UseVisualStyleBackColor = True
        '
        'RECEPÇÃO
        '
        Me.RECEPÇÃO.AutoSize = True
        Me.RECEPÇÃO.BackColor = System.Drawing.Color.Transparent
        Me.RECEPÇÃO.Font = New System.Drawing.Font("Perpetua", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RECEPÇÃO.Location = New System.Drawing.Point(594, 49)
        Me.RECEPÇÃO.Name = "RECEPÇÃO"
        Me.RECEPÇÃO.Size = New System.Drawing.Size(282, 60)
        Me.RECEPÇÃO.TabIndex = 14
        Me.RECEPÇÃO.Text = "RECEPÇÃO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(428, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 25)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "NOME DO PACIENTE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 25)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "CPF DO PACIENTE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "TELEFONE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(428, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 25)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "TELEFONE 2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(52, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 25)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "CEP"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(427, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 25)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "NUMERO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 144)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(295, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "NOME DO ACOMPANHANTE"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(428, 144)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(274, 25)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "CPF DO ACOMPANHANTE"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_tel2)
        Me.GroupBox1.Controls.Add(Me.txt_tel)
        Me.GroupBox1.Controls.Add(Me.txt_cpf)
        Me.GroupBox1.Controls.Add(Me.txt_nome)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(324, 148)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 256)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INFORMAÇÕES PESSOAIS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_cep)
        Me.GroupBox2.Controls.Add(Me.txt_num)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(324, 425)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(826, 141)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ENDEREÇO"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.LightBlue
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.cb_op2)
        Me.GroupBox3.Controls.Add(Me.cb_op1)
        Me.GroupBox3.Controls.Add(Me.txt_cpfac)
        Me.GroupBox3.Controls.Add(Me.txt_nomeac)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(324, 606)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(825, 235)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INFORMAÇÕES DO ACOMPANHANTE"
        '
        'btn_addpac
        '
        Me.btn_addpac.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_addpac.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_addpac.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addpac.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_addpac.Location = New System.Drawing.Point(324, 892)
        Me.btn_addpac.Name = "btn_addpac"
        Me.btn_addpac.Size = New System.Drawing.Size(827, 60)
        Me.btn_addpac.TabIndex = 28
        Me.btn_addpac.Text = "&ADICIONAR PACIENTE"
        Me.btn_addpac.UseVisualStyleBackColor = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1324, 916)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 36)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Voltar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form_recep
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1424, 985)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_addpac)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RECEPÇÃO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form_recep"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recepção"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_num As TextBox
    Friend WithEvents txt_nomeac As TextBox
    Friend WithEvents txt_tel As MaskedTextBox
    Friend WithEvents txt_tel2 As MaskedTextBox
    Friend WithEvents txt_cpf As MaskedTextBox
    Friend WithEvents txt_cep As MaskedTextBox
    Friend WithEvents txt_cpfac As MaskedTextBox
    Friend WithEvents cb_op1 As CheckBox
    Friend WithEvents cb_op2 As CheckBox
    Friend WithEvents RECEPÇÃO As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btn_addpac As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Button1 As Button
End Class
