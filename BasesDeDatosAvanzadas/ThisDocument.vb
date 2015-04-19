Public Class ThisDocument

    Private Sub ThisDocument_Startup() Handles Me.Startup
        Me.fechaBookmark.Text = DateString.ToString
        Me.ActionsPane.Controls.Add(New ActionsPaneControlSexo)
        Me.ActionsPane.Controls.Add(New ActionsPaneControlEscolaridad)
    End Sub

    Private Sub ThisDocument_Shutdown() Handles Me.Shutdown

    End Sub

End Class
