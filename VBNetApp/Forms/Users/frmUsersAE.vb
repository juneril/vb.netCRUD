

Option Explicit On

Public Class frmUsersAE

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Label6.Text = "Create User Account") Then

            Dim u As New users

            u.u_fname = Me.fname.Text
            u.u_lname = Me.lname.Text
            u.u_mname = Me.mname.Text
            u.u_username = Me.username.Text
            u.u_password = Me.password.Text



            If AddUsers(u) And SaveUsersPhoto(u, pic_display) Then
                MsgBox("REcord succesfully save")
                Me.Close()

            End If


        End If
        If (Label6.Text = "Update User Account") Then
            Dim u As New users
            u.u_id = Convert.ToInt32(Me.U_ID.Text)
            u.u_fname = Me.fname.Text
            u.u_lname = Me.lname.Text
            u.u_mname = Me.mname.Text
            u.u_username = Me.username.Text
            u.u_password = Me.password.Text

            If UpdateUsers(u) And UpdateUsersPhoto(u, pic_display) Then
                MsgBox("REcord Succesfully Updated")
                Me.Close()
            End If


        End If
    End Sub

    Private Sub frmUsersAE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If (Label6.Text = "Update User Account") Then

            Dim u As New users
            u.u_id = Convert.ToInt32(Me.U_ID.Text)
            GetUsersPhoto(u, Me.pic_display)





        End If


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        With dlg_openfile 'Executes a series of statements making repeated reference to a single object or structure.
            .Title = "Please Select a Image" 'title
            .InitialDirectory = "C:\" 'browse start directory
            .Filter = "JPEG(*.jpg;*.jpeg;*.jpe.*.jfif)|*.jpg; *.jpeg; *.jpe; *.jpe; *.ico" 'only possible to select this extensions
            .FilterIndex = 0 'index number filter
            .FileName = "" 'empty
            Dim answ = .ShowDialog
            If answ = DialogResult.OK Then 'if answer not cancel, etc..
                pic_display.ImageLocation = .FileName 'picterebox imagelocation = dlg_openfile.filename
                pic_display.SizeMode = PictureBoxSizeMode.StretchImage


            End If
        End With
    End Sub
End Class