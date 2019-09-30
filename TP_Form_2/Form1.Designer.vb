<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label_sign = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.img_cerrado = New System.Windows.Forms.PictureBox()
        Me.Label_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label_info = New System.Windows.Forms.Label()
        Me.Label_info2 = New System.Windows.Forms.Label()
        Me.Label_info3 = New System.Windows.Forms.Label()
        Me.img_desayuno = New System.Windows.Forms.PictureBox()
        Me.img_almuerzo = New System.Windows.Forms.PictureBox()
        Me.img_merienda = New System.Windows.Forms.PictureBox()
        Me.img_cena = New System.Windows.Forms.PictureBox()
        Me.Label_ingreso = New System.Windows.Forms.Label()
        Me.Label_username = New System.Windows.Forms.Label()
        Me.Label_cerrar = New System.Windows.Forms.Label()
        CType(Me.img_cerrado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_desayuno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_almuerzo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_merienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_cena, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label_sign
        '
        Me.Label_sign.AutoSize = True
        Me.Label_sign.BackColor = System.Drawing.Color.Transparent
        Me.Label_sign.Location = New System.Drawing.Point(702, 9)
        Me.Label_sign.Name = "Label_sign"
        Me.Label_sign.Size = New System.Drawing.Size(60, 13)
        Me.Label_sign.TabIndex = 1
        Me.Label_sign.Text = "Registrarse"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Gabriola", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label3.Location = New System.Drawing.Point(157, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 65)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RestoBar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Gabriola", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label4.Location = New System.Drawing.Point(108, 238)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(271, 65)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "En estos momentos..."
        '
        'img_cerrado
        '
        Me.img_cerrado.Image = Global.TP_Form_2.My.Resources.Resources.closed
        Me.img_cerrado.Location = New System.Drawing.Point(385, 233)
        Me.img_cerrado.Name = "img_cerrado"
        Me.img_cerrado.Size = New System.Drawing.Size(376, 256)
        Me.img_cerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cerrado.TabIndex = 4
        Me.img_cerrado.TabStop = False
        Me.img_cerrado.Visible = False
        '
        'Label_hora
        '
        Me.Label_hora.AutoSize = True
        Me.Label_hora.BackColor = System.Drawing.Color.Transparent
        Me.Label_hora.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_hora.Location = New System.Drawing.Point(709, 39)
        Me.Label_hora.Name = "Label_hora"
        Me.Label_hora.Size = New System.Drawing.Size(0, 15)
        Me.Label_hora.TabIndex = 5
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label_info
        '
        Me.Label_info.AutoSize = True
        Me.Label_info.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_info.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info.Location = New System.Drawing.Point(190, 326)
        Me.Label_info.Name = "Label_info"
        Me.Label_info.Size = New System.Drawing.Size(0, 35)
        Me.Label_info.TabIndex = 6
        '
        'Label_info2
        '
        Me.Label_info2.AutoSize = True
        Me.Label_info2.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_info2.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info2.Location = New System.Drawing.Point(190, 361)
        Me.Label_info2.Name = "Label_info2"
        Me.Label_info2.Size = New System.Drawing.Size(0, 35)
        Me.Label_info2.TabIndex = 7
        '
        'Label_info3
        '
        Me.Label_info3.AutoSize = True
        Me.Label_info3.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label_info3.Font = New System.Drawing.Font("Gabriola", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_info3.Location = New System.Drawing.Point(190, 396)
        Me.Label_info3.Name = "Label_info3"
        Me.Label_info3.Size = New System.Drawing.Size(0, 35)
        Me.Label_info3.TabIndex = 8
        '
        'img_desayuno
        '
        Me.img_desayuno.Image = Global.TP_Form_2.My.Resources.Resources.desayunos
        Me.img_desayuno.Location = New System.Drawing.Point(385, 233)
        Me.img_desayuno.Name = "img_desayuno"
        Me.img_desayuno.Size = New System.Drawing.Size(366, 256)
        Me.img_desayuno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_desayuno.TabIndex = 9
        Me.img_desayuno.TabStop = False
        Me.img_desayuno.Visible = False
        '
        'img_almuerzo
        '
        Me.img_almuerzo.Image = Global.TP_Form_2.My.Resources.Resources.almuerzo
        Me.img_almuerzo.Location = New System.Drawing.Point(385, 233)
        Me.img_almuerzo.Name = "img_almuerzo"
        Me.img_almuerzo.Size = New System.Drawing.Size(376, 256)
        Me.img_almuerzo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_almuerzo.TabIndex = 10
        Me.img_almuerzo.TabStop = False
        Me.img_almuerzo.Visible = False
        '
        'img_merienda
        '
        Me.img_merienda.Image = Global.TP_Form_2.My.Resources.Resources.merienda1
        Me.img_merienda.Location = New System.Drawing.Point(385, 233)
        Me.img_merienda.Name = "img_merienda"
        Me.img_merienda.Size = New System.Drawing.Size(378, 256)
        Me.img_merienda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_merienda.TabIndex = 11
        Me.img_merienda.TabStop = False
        Me.img_merienda.Visible = False
        '
        'img_cena
        '
        Me.img_cena.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.img_cena.Image = Global.TP_Form_2.My.Resources.Resources.cena
        Me.img_cena.Location = New System.Drawing.Point(385, 233)
        Me.img_cena.Name = "img_cena"
        Me.img_cena.Size = New System.Drawing.Size(362, 256)
        Me.img_cena.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_cena.TabIndex = 12
        Me.img_cena.TabStop = False
        Me.img_cena.Visible = False
        '
        'Label_ingreso
        '
        Me.Label_ingreso.AutoSize = True
        Me.Label_ingreso.BackColor = System.Drawing.Color.Transparent
        Me.Label_ingreso.Location = New System.Drawing.Point(613, 9)
        Me.Label_ingreso.Name = "Label_ingreso"
        Me.Label_ingreso.Size = New System.Drawing.Size(45, 13)
        Me.Label_ingreso.TabIndex = 13
        Me.Label_ingreso.Text = "Ingresar"
        '
        'Label_username
        '
        Me.Label_username.AutoSize = True
        Me.Label_username.BackColor = System.Drawing.Color.Transparent
        Me.Label_username.Location = New System.Drawing.Point(613, 9)
        Me.Label_username.Name = "Label_username"
        Me.Label_username.Size = New System.Drawing.Size(63, 13)
        Me.Label_username.TabIndex = 14
        Me.Label_username.Text = "INGRESAR"
        Me.Label_username.Visible = False
        '
        'Label_cerrar
        '
        Me.Label_cerrar.AutoSize = True
        Me.Label_cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Label_cerrar.Location = New System.Drawing.Point(702, 9)
        Me.Label_cerrar.Name = "Label_cerrar"
        Me.Label_cerrar.Size = New System.Drawing.Size(70, 13)
        Me.Label_cerrar.TabIndex = 15
        Me.Label_cerrar.Text = "Cerrar Sesión"
        Me.Label_cerrar.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TP_Form_2.My.Resources.Resources.carnal_resto_bar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 501)
        Me.Controls.Add(Me.Label_cerrar)
        Me.Controls.Add(Me.Label_username)
        Me.Controls.Add(Me.Label_ingreso)
        Me.Controls.Add(Me.img_cena)
        Me.Controls.Add(Me.img_merienda)
        Me.Controls.Add(Me.img_almuerzo)
        Me.Controls.Add(Me.img_desayuno)
        Me.Controls.Add(Me.Label_info3)
        Me.Controls.Add(Me.Label_info2)
        Me.Controls.Add(Me.Label_info)
        Me.Controls.Add(Me.Label_hora)
        Me.Controls.Add(Me.img_cerrado)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_sign)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.RightToLeftLayout = True
        Me.Text = "RestoBar"
        CType(Me.img_cerrado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_desayuno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_almuerzo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_merienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_cena, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label_sign As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents img_cerrado As PictureBox
    Friend WithEvents Label_hora As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label_info As Label
    Friend WithEvents Label_info2 As Label
    Friend WithEvents Label_info3 As Label
    Friend WithEvents img_desayuno As PictureBox
    Friend WithEvents img_almuerzo As PictureBox
    Friend WithEvents img_merienda As PictureBox
    Friend WithEvents img_cena As PictureBox
    Friend WithEvents Label_ingreso As Label
    Friend WithEvents Label_username As Label
    Friend WithEvents Label_cerrar As Label
End Class
