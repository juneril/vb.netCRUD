Public Class frmUserPhoto

    Private Sub brosebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_browse.Click
        With dlg_openfile 'Executes a series of statements making repeated reference to a single object or structure.
            .Title = "Please Select a Image" 'title
            .InitialDirectory = "C:\" 'browse start directory
            .Filter = "JPEG(*.jpg;*.jpeg;*.jpe.*.jfif)|*.jpg; *.jpeg; *.jpe; *.jpe" 'only possible to select this extensions
            .FilterIndex = 0 'index number filter
            .FileName = "" 'empty
            Dim answ = .ShowDialog
            If answ = DialogResult.OK Then 'if answer not cancel, etc..
                pic_display.ImageLocation = .FileName 'picterebox imagelocation = dlg_openfile.filename
                pic_display.SizeMode = PictureBoxSizeMode.StretchImage


            End If
        End With
    End Sub

    Private Sub savebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles savebtn.Click

        Dim u As New users
        u.u_id = Convert.ToInt32(Me.u_id.Text)
     

        If UpdateUsers(u) Then
            MsgBox("REcord Succesfully Updated")
            Me.Close()
        End If



    End Sub
End Class