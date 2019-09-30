Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_hora.Text = DateTime.Now.ToString("HH:mm:ss")

        Dim hora As Date = Format(TimeValue(Date.Now), ("HH:mm:ss"))
        Dim desayunoInicio As Date = Format(TimeValue("7:00:00"), ("HH:mm:ss"))
        Dim almuerzoInicio As DateTime = Format(TimeValue("10:01:00"), ("HH:mm:ss"))
        Dim inicioMerienda As DateTime = Format(TimeValue("15:01:00"), ("HH:mm:ss"))
        Dim inicioCena As DateTime = Format(TimeValue("19:01:00"), ("HH:mm:ss"))
        Dim cierre As DateTime = Format(TimeValue("23:43:00"), ("HH:mm:ss"))

        If hora > cierre Or hora < desayunoInicio Then
            img_cena.Visible = False
            img_cerrado.Visible = True
            Label_info.Text = "Estamos descansando"
            Label_info2.Text = "Te esperamos de 7 a 23 hs"

        End If
        If hora >= desayunoInicio And hora < almuerzoInicio Then
            img_desayuno.Visible = True
            img_cerrado.Visible = False
            Label_info.Text = "Estamos Desayunando!"
            Label_info2.Text = "Vení a disfrutar del"
            Label_info3.Text = "mejor café!"

        End If
        If hora >= almuerzoInicio And hora < inicioMerienda Then
            img_almuerzo.Visible = True
            img_desayuno.Visible = False
            Label_info.Text = "Estamos almorzando!"
            Label_info2.Text = "Y no con Mirtha !!!"
            Label_info3.Text = "...(Por suerte)..."
        End If
        If hora >= inicioMerienda And hora < inicioCena Then
            img_almuerzo.Visible = False
            img_merienda.Visible = True
            Label_info.Text = "Tenemos la merienda lista!"
            Label_info2.Text = "Disfrutá la tarde con"
            Label_info3.Text = "los postres más ricos"
        End If
        If hora >= inicioCena And hora < cierre Then
            img_cena.Visible = True
            img_merienda.Visible = False
            Label_info.Text = "Estamos sirviendo la cena."
            Label_info2.Text = "Nada mejor que una rica"
            Label_info3.Text = "cena para terminar el día."
        End If

    End Sub

    Private Sub Label_sign_Click(sender As Object, e As EventArgs) Handles Label_sign.Click
        registro.Show()
    End Sub

    Private Sub Label_ingreso_Click(sender As Object, e As EventArgs) Handles Label_ingreso.Click
        Login.Show()
    End Sub

    Private Sub Label_cerrar_Click(sender As Object, e As EventArgs) Handles Label_cerrar.Click
        Label_cerrar.Visible = False
        Label_username.Visible = False
        Label_ingreso.Visible = True
        Label_sign.Visible = True
        MsgBox("Gracias por pasar. Vuelve pronto!")
    End Sub

    Public username As New List(Of String)
    Public passlist As New List(Of String)

    Private Sub Label_cerrar_MouseEnter(sender As Object, e As EventArgs) Handles Label_cerrar.MouseEnter
        Label_cerrar.Cursor = Cursors.Hand
    End Sub

    Private Sub Label_cerrar_MouseLeave(sender As Object, e As EventArgs) Handles Label_cerrar.MouseLeave
        Label_cerrar.Cursor = Cursors.Default
    End Sub

    Private Sub Label_username_MouseEnter(sender As Object, e As EventArgs) Handles Label_username.MouseEnter
        Label_username.Cursor = Cursors.Hand
    End Sub

    Private Sub Label_username_MouseLeave(sender As Object, e As EventArgs) Handles Label_username.MouseLeave
        Label_username.Cursor = Cursors.Default
    End Sub

    Private Sub Label_ingreso_MouseEnter(sender As Object, e As EventArgs) Handles Label_ingreso.MouseEnter
        Label_ingreso.Cursor = Cursors.Hand
    End Sub

    Private Sub Label_ingreso_MouseLeave(sender As Object, e As EventArgs) Handles Label_ingreso.MouseLeave
        Label_ingreso.Cursor = Cursors.Default
    End Sub

    Private Sub Label_sign_MouseEnter(sender As Object, e As EventArgs) Handles Label_sign.MouseEnter
        Label_sign.Cursor = Cursors.Hand
    End Sub

    Private Sub Label_sign_MouseLeave(sender As Object, e As EventArgs) Handles Label_sign.MouseLeave
        Label_sign.Cursor = Cursors.Default
    End Sub
End Class
