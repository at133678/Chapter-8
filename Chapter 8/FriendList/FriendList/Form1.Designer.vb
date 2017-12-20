<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FriendList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnEnterNames = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ListFriends = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnEnterNames
        '
        Me.btnEnterNames.Location = New System.Drawing.Point(150, 296)
        Me.btnEnterNames.Name = "btnEnterNames"
        Me.btnEnterNames.Size = New System.Drawing.Size(85, 50)
        Me.btnEnterNames.TabIndex = 0
        Me.btnEnterNames.Text = "Enter Names"
        Me.btnEnterNames.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(360, 296)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 50)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'ListFriends
        '
        Me.ListFriends.FormattingEnabled = True
        Me.ListFriends.Location = New System.Drawing.Point(168, 21)
        Me.ListFriends.Name = "ListFriends"
        Me.ListFriends.Size = New System.Drawing.Size(295, 160)
        Me.ListFriends.TabIndex = 2
        '
        'FriendList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 372)
        Me.Controls.Add(Me.ListFriends)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEnterNames)
        Me.Name = "FriendList"
        Me.Text = "Friend List"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEnterNames As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ListFriends As System.Windows.Forms.ListBox

End Class
