Public Class ActionsPaneControlSexo

    Private Sub SexoListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SexoListBox.SelectedIndexChanged
        Globals.ThisDocument.sexoBookmark.Text = SexoListBox.SelectedItem
    End Sub
End Class
