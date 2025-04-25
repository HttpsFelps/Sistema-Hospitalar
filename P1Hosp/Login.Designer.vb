<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.RECEPÇÃO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cadastrar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_assinatura = New System.Windows.Forms.TextBox()
        Me.btn_criar = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'RECEPÇÃO
        '
        Me.RECEPÇÃO.BackColor = System.Drawing.Color.Transparent
        Me.RECEPÇÃO.Font = New System.Drawing.Font("Perpetua", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RECEPÇÃO.Location = New System.Drawing.Point(0, 58)
        Me.RECEPÇÃO.Name = "RECEPÇÃO"
        Me.RECEPÇÃO.Size = New System.Drawing.Size(1426, 60)
        Me.RECEPÇÃO.TabIndex = 23
        Me.RECEPÇÃO.Text = "Login"
        Me.RECEPÇÃO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(566, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 25)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Assinatura Digital"
        '
        'btn_cadastrar
        '
        Me.btn_cadastrar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_cadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar.ForeColor = System.Drawing.Color.White
        Me.btn_cadastrar.Location = New System.Drawing.Point(571, 482)
        Me.btn_cadastrar.Name = "btn_cadastrar"
        Me.btn_cadastrar.Size = New System.Drawing.Size(300, 42)
        Me.btn_cadastrar.TabIndex = 44
        Me.btn_cadastrar.Text = "Criar cadastro"
        Me.btn_cadastrar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(566, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 25)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Senha"
        '
        'txt_assinatura
        '
        Me.txt_assinatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_assinatura.Location = New System.Drawing.Point(571, 213)
        Me.txt_assinatura.Name = "txt_assinatura"
        Me.txt_assinatura.Size = New System.Drawing.Size(300, 35)
        Me.txt_assinatura.TabIndex = 42
        '
        'btn_criar
        '
        Me.btn_criar.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btn_criar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_criar.ForeColor = System.Drawing.Color.White
        Me.btn_criar.Location = New System.Drawing.Point(571, 417)
        Me.btn_criar.Name = "btn_criar"
        Me.btn_criar.Size = New System.Drawing.Size(300, 42)
        Me.btn_criar.TabIndex = 41
        Me.btn_criar.Text = "Login"
        Me.btn_criar.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_senha.Location = New System.Drawing.Point(571, 329)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.Size = New System.Drawing.Size(300, 35)
        Me.txt_senha.TabIndex = 40
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1424, 985)
        Me.Controls.Add(Me.btn_cadastrar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_assinatura)
        Me.Controls.Add(Me.btn_criar)
        Me.Controls.Add(Me.txt_senha)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RECEPÇÃO)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RECEPÇÃO As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cadastrar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_assinatura As TextBox
    Friend WithEvents btn_criar As Button
    Friend WithEvents txt_senha As TextBox
End Class
