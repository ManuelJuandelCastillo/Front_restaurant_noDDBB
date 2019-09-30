<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_reg = New System.Windows.Forms.Button()
        Me.pass_check = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(256, 40)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TP_Form_2.My.Resources.Resources.Close_Icon
        Me.PictureBox1.Location = New System.Drawing.Point(222, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 18)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(87, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 22)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "SIGNUP"
        '
        'btn_reg
        '
        Me.btn_reg.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btn_reg.FlatAppearance.BorderSize = 0
        Me.btn_reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_reg.Location = New System.Drawing.Point(34, 245)
        Me.btn_reg.Name = "btn_reg"
        Me.btn_reg.Size = New System.Drawing.Size(178, 43)
        Me.btn_reg.TabIndex = 20
        Me.btn_reg.Text = "REGISTRARSE"
        Me.btn_reg.UseVisualStyleBackColor = False
        '
        'pass_check
        '
        Me.pass_check.AutoSize = True
        Me.pass_check.Location = New System.Drawing.Point(119, 195)
        Me.pass_check.Name = "pass_check"
        Me.pass_check.Size = New System.Drawing.Size(116, 17)
        Me.pass_check.TabIndex = 19
        Me.pass_check.Text = "mostrar contraseña"
        Me.pass_check.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 153)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 14)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 14)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "usuario"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(22, 169)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(200, 20)
        Me.txt_pass.TabIndex = 16
        Me.txt_pass.UseSystemPasswordChar = True
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(22, 123)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(200, 20)
        Me.txt_user.TabIndex = 15
        '
        'registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(256, 320)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_reg)
        Me.Controls.Add(Me.pass_check)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.txt_user)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registro"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_reg As Button
    Friend WithEvents pass_check As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_pass As TextBox
    Friend WithEvents txt_user As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
