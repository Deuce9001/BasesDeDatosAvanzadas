Public Class ActionsPaneControlEscolaridad

    Private Sub EscolaridadListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EscolaridadListBox.SelectedIndexChanged
        Globals.ThisDocument.escolaridadBookmark.Text = EscolaridadListBox.SelectedItem
    End Sub
End Class
