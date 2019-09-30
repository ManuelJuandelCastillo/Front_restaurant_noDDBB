Public Class Login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Trim(txt_pass.Text) <> "" And Trim(txt_user.Text) <> "" Then
            Dim user = txt_user.Text
            Dim pass = txt_pass.Text

            For Each item In Form1.username
                If user = item Then
                    Dim indice = Form1.username.IndexOf(item)

                    If pass = Form1.passlist(indice) Then
                        MsgBox($"Bienvenido/a otra vez, {user}!")
                        Form1.Label_ingreso.Visible = False
                        Form1.Label_sign.Visible = False
                        Form1.Label_username.Text = user
                        Form1.Label_username.Visible = True
                        Form1.Label_cerrar.Visible = True
                        Me.Close()
                        Exit Sub
                    End If
                End If
            Next
            MsgBox("Usuario o contraseña incorrecta")
        Else
            MsgBox("Es necesario llenar los campos usuario y contraseña")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txt_pass.UseSystemPasswordChar = False
        Else
            txt_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Cursor = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Cursor = Cursors.Default
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pass.Clear()
        txt_user.Clear()

    End Sub
End Class