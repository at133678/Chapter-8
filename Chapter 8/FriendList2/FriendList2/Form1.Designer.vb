<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listFriends
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.lstFriend = New System.Windows.Forms.ListBox()
        Me.txtNames = New System.Windows.Forms.TextBox()
        Me.EnterFriendName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(68, 277)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(73, 51)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(567, 292)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(105, 66)
        Me.btnShowAll.TabIndex = 1
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'lstFriend
        '
        Me.lstFriend.FormattingEnabled = True
        Me.lstFriend.Location = New System.Drawing.Point(539, 73)
        Me.lstFriend.Name = "lstFriend"
        Me.lstFriend.Size = New System.Drawing.Size(159, 160)
        Me.lstFriend.TabIndex = 2
        '
        'txtNames
        '
        Me.txtNames.Location = New System.Drawing.Point(55, 195)
        Me.txtNames.Name = "txtNames"
        Me.txtNames.Size = New System.Drawing.Size(105, 20)
        Me.txtNames.TabIndex = 3
        '
        'EnterFriendName
        '
        Me.EnterFriendName.AutoSize = True
        Me.EnterFriendName.Location = New System.Drawing.Point(52, 41)
        Me.EnterFriendName.Name = "EnterFriendName"
        Me.EnterFriendName.Size = New System.Drawing.Size(111, 13)
        Me.EnterFriendName.TabIndex = 4
        Me.EnterFriendName.Text = "Enter a Friend's Name"
        '
        'listFriends
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 419)
        Me.Controls.Add(Me.EnterFriendName)
        Me.Controls.Add(Me.txtNames)
        Me.Controls.Add(Me.lstFriend)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "listFriends"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents lstFriend As System.Windows.Forms.ListBox
    Friend WithEvents txtNames As System.Windows.Forms.TextBox
    Friend WithEvents EnterFriendName As System.Windows.Forms.Label

End Class
