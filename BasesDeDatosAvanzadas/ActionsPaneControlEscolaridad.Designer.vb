<System.ComponentModel.ToolboxItemAttribute(False)> _
Partial Public Class ActionsPaneControlEscolaridad
    Inherits System.Windows.Forms.UserControl

    <System.Diagnostics.DebuggerNonUserCode()> _
    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

    End Sub

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EscolaridadLabel = New System.Windows.Forms.Label()
        Me.EscolaridadListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'EscolaridadLabel
        '
        Me.EscolaridadLabel.AutoSize = True
        Me.EscolaridadLabel.Location = New System.Drawing.Point(4, 4)
        Me.EscolaridadLabel.Name = "EscolaridadLabel"
        Me.EscolaridadLabel.Size = New System.Drawing.Size(62, 13)
        Me.EscolaridadLabel.TabIndex = 0
        Me.EscolaridadLabel.Text = "Escolaridad"
        '
        'EscolaridadListBox
        '
        Me.EscolaridadListBox.FormattingEnabled = True
        Me.EscolaridadListBox.Items.AddRange(New Object() {"Primaria", "Secundaria", "Preparatoria", "Bachillerato", "Universidad", "Maestría", "Doctorado"})
        Me.EscolaridadListBox.Location = New System.Drawing.Point(4, 21)
        Me.EscolaridadListBox.Name = "EscolaridadListBox"
        Me.EscolaridadListBox.Size = New System.Drawing.Size(120, 95)
        Me.EscolaridadListBox.TabIndex = 1
        '
        'ActionsPaneControl1
        '
        Me.Controls.Add(Me.EscolaridadListBox)
        Me.Controls.Add(Me.EscolaridadLabel)
        Me.Name = "ActionsPaneControl1"
        Me.Size = New System.Drawing.Size(476, 150)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents EscolaridadLabel As System.Windows.Forms.Label
    Friend WithEvents EscolaridadListBox As System.Windows.Forms.ListBox

End Class
