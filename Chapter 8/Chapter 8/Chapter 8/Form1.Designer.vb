<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LotteryNumbers
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Generate = New System.Windows.Forms.Button()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(360, 233)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 42)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Generate
        '
        Me.Generate.Location = New System.Drawing.Point(172, 233)
        Me.Generate.Name = "Generate"
        Me.Generate.Size = New System.Drawing.Size(75, 42)
        Me.Generate.TabIndex = 12
        Me.Generate.Text = "Generate Numbers"
        Me.Generate.UseVisualStyleBackColor = True
        '
        'lblFive
        '
        Me.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFive.Location = New System.Drawing.Point(575, 72)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(100, 56)
        Me.lblFive.TabIndex = 11
        '
        'lblFour
        '
        Me.lblFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFour.Location = New System.Drawing.Point(435, 72)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(100, 56)
        Me.lblFour.TabIndex = 10
        '
        'lblThree
        '
        Me.lblThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThree.Location = New System.Drawing.Point(292, 72)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(100, 56)
        Me.lblThree.TabIndex = 9
        '
        'lblTwo
        '
        Me.lblTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwo.Location = New System.Drawing.Point(147, 72)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(100, 56)
        Me.lblTwo.TabIndex = 8
        '
        'lblOne
        '
        Me.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOne.Location = New System.Drawing.Point(16, 72)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(100, 56)
        Me.lblOne.TabIndex = 7
        '
        'LotteryNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 298)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Generate)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Name = "LotteryNumbers"
        Me.Text = "Lottary Numbers"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Generate As System.Windows.Forms.Button
    Friend WithEvents lblFive As System.Windows.Forms.Label
    Friend WithEvents lblFour As System.Windows.Forms.Label
    Friend WithEvents lblThree As System.Windows.Forms.Label
    Friend WithEvents lblTwo As System.Windows.Forms.Label
    Friend WithEvents lblOne As System.Windows.Forms.Label

End Class
