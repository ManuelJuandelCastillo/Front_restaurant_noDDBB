Public Class registro

    Private Sub Btn_reg_Click(sender As Object, e As EventArgs) Handles btn_reg.Click
        If Trim(txt_pass.Text) <> "" And Trim(txt_user.Text) <> "" Then
            If txt_user.Text.Length < 5 Or txt_user.Text.Length > 9 Then
                MsgBox("el usuario debe tener entre 5 y 9 caracteres")
            Else
                Dim user = txt_user.Text
                Dim pass = txt_pass.Text

                Form1.username.Add(user)
                Form1.passlist.Add(pass)

                Form1.Label_username.Text = user
                Form1.Label_username.Visible = True
                Form1.Label_sign.Visible = False
                Form1.Label_ingreso.Visible = False
                Form1.Label_cerrar.Visible = True
                Me.Close()
                MsgBox($"Hola {user}! Nos alegra tenerte con nosotros!")
            End If

        End If
    End Sub

    Private Sub Pass_check_CheckedChanged(sender As Object, e As EventArgs) Handles pass_check.CheckedChanged
        If pass_check.Checked Then
            txt_pass.UseSystemPasswordChar = False
        Else
            txt_pass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Txt_pass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pass.KeyPress
        If Char.IsControl(e.KeyChar) Or Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
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
End Class