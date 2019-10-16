Public Class Form1
    Private Sub CloseImage_Click(sender As Object, e As EventArgs) Handles CloseImage.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim JMLBYR, JMLBYRDISC, JMLBYRDISK As Double
        LabelKet.Visible = False
        BoxSebDisk.Visible = False
        Jabatan.Visible = True

        JMLBYR = (QTY.Text * HRGBRG.Text)

        If (JMLBYR >= 300000 And HRGBRG.Text >= 100000) Then
            KETDISK.Text = "Tidak Dapat Kartu Diskon"
            BYRAKH.Text = JMLBYR
        ElseIf (QTY.Text >= 100) Then
            KETDISK.Text = "Dapat Diskon 30%"
            JMLBYRDISC = JMLBYR * 0.3
            JMLBYRDISK = JMLBYR - JMLBYRDISC
            LabelKet.Visible = True
            BoxSebDisk.Visible = True
            Jabatan.Visible = False
            BoxSebDisk.Text = JMLBYR
            BYRAKH.Text = JMLBYRDISK
        Else
            KETDISK.Text = "Tidak Dapat Diskon"
            BYRAKH.Text = JMLBYR
        End If
    End Sub

    Private Sub ClearText_Click(sender As Object, e As EventArgs) Handles ClearText.Click
        QTY.Clear()
        HRGBRG.Clear()
        KETDISK.Clear()
        BoxSebDisk.Clear()
        BYRAKH.Clear()
        LabelKet.Visible = False
        BoxSebDisk.Visible = False
        Jabatan.Visible = True
    End Sub
End Class
