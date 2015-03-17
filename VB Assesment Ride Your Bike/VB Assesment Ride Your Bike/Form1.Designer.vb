<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.bntLoad = New System.Windows.Forms.Button()
        Me.btnSpin = New System.Windows.Forms.Button()
        Me.btnResetGame = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbAxe = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblGamesLost = New System.Windows.Forms.Label()
        Me.lblGamesWon = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblLapCounter = New System.Windows.Forms.Label()
        Me.pbRide = New System.Windows.Forms.PictureBox()
        Me.test = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAxeCounter = New System.Windows.Forms.Label()
        Me.lblNoMoreAxes = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.pbRide, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bntLoad
        '
        Me.bntLoad.Location = New System.Drawing.Point(12, 476)
        Me.bntLoad.Name = "bntLoad"
        Me.bntLoad.Size = New System.Drawing.Size(75, 23)
        Me.bntLoad.TabIndex = 1
        Me.bntLoad.Text = "Load Game"
        Me.bntLoad.UseVisualStyleBackColor = True
        '
        'btnSpin
        '
        Me.btnSpin.Location = New System.Drawing.Point(119, 476)
        Me.btnSpin.Name = "btnSpin"
        Me.btnSpin.Size = New System.Drawing.Size(123, 23)
        Me.btnSpin.TabIndex = 2
        Me.btnSpin.Text = "Set Up Laps"
        Me.btnSpin.UseVisualStyleBackColor = True
        '
        'btnResetGame
        '
        Me.btnResetGame.Location = New System.Drawing.Point(248, 475)
        Me.btnResetGame.Name = "btnResetGame"
        Me.btnResetGame.Size = New System.Drawing.Size(75, 23)
        Me.btnResetGame.TabIndex = 3
        Me.btnResetGame.Text = "Reset Game"
        Me.btnResetGame.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Location = New System.Drawing.Point(667, 400)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(205, 99)
        Me.btnFire.TabIndex = 4
        Me.btnFire.Text = "Start Your Lap"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNoMoreAxes)
        Me.GroupBox1.Controls.Add(Me.lblAxeCounter)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbAxe)
        Me.GroupBox1.Location = New System.Drawing.Point(672, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Take an Axe?"
        '
        'cbAxe
        '
        Me.cbAxe.AutoSize = True
        Me.cbAxe.Location = New System.Drawing.Point(28, 42)
        Me.cbAxe.Name = "cbAxe"
        Me.cbAxe.Size = New System.Drawing.Size(94, 17)
        Me.cbAxe.TabIndex = 0
        Me.cbAxe.Text = "YES PLEASE!"
        Me.cbAxe.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblGamesLost)
        Me.GroupBox2.Controls.Add(Me.lblGamesWon)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(672, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ganes Results:"
        '
        'lblGamesLost
        '
        Me.lblGamesLost.AutoSize = True
        Me.lblGamesLost.Location = New System.Drawing.Point(104, 59)
        Me.lblGamesLost.Name = "lblGamesLost"
        Me.lblGamesLost.Size = New System.Drawing.Size(0, 13)
        Me.lblGamesLost.TabIndex = 3
        '
        'lblGamesWon
        '
        Me.lblGamesWon.AutoSize = True
        Me.lblGamesWon.Location = New System.Drawing.Point(104, 33)
        Me.lblGamesWon.Name = "lblGamesWon"
        Me.lblGamesWon.Size = New System.Drawing.Size(0, 13)
        Me.lblGamesWon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Games Lost:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Games Won: "
        '
        'lblLapCounter
        '
        Me.lblLapCounter.AutoSize = True
        Me.lblLapCounter.Font = New System.Drawing.Font("Myriad Web Pro", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLapCounter.Location = New System.Drawing.Point(540, 13)
        Me.lblLapCounter.Name = "lblLapCounter"
        Me.lblLapCounter.Size = New System.Drawing.Size(0, 24)
        Me.lblLapCounter.TabIndex = 7
        '
        'pbRide
        '
        Me.pbRide.Location = New System.Drawing.Point(12, 12)
        Me.pbRide.Name = "pbRide"
        Me.pbRide.Size = New System.Drawing.Size(500, 363)
        Me.pbRide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbRide.TabIndex = 0
        Me.pbRide.TabStop = False
        '
        'test
        '
        Me.test.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.test.Location = New System.Drawing.Point(442, 443)
        Me.test.Name = "test"
        Me.test.Size = New System.Drawing.Size(100, 23)
        Me.test.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Axes left: "
        '
        'lblAxeCounter
        '
        Me.lblAxeCounter.AutoSize = True
        Me.lblAxeCounter.Location = New System.Drawing.Point(87, 66)
        Me.lblAxeCounter.Name = "lblAxeCounter"
        Me.lblAxeCounter.Size = New System.Drawing.Size(0, 13)
        Me.lblAxeCounter.TabIndex = 2
        '
        'lblNoMoreAxes
        '
        Me.lblNoMoreAxes.AutoSize = True
        Me.lblNoMoreAxes.Location = New System.Drawing.Point(28, 86)
        Me.lblNoMoreAxes.Name = "lblNoMoreAxes"
        Me.lblNoMoreAxes.Size = New System.Drawing.Size(0, 13)
        Me.lblNoMoreAxes.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 511)
        Me.Controls.Add(Me.test)
        Me.Controls.Add(Me.lblLapCounter)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFire)
        Me.Controls.Add(Me.btnResetGame)
        Me.Controls.Add(Me.btnSpin)
        Me.Controls.Add(Me.bntLoad)
        Me.Controls.Add(Me.pbRide)
        Me.Name = "Form1"
        Me.Text = "s"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.pbRide, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbRide As System.Windows.Forms.PictureBox
    Friend WithEvents bntLoad As System.Windows.Forms.Button
    Friend WithEvents btnSpin As System.Windows.Forms.Button
    Friend WithEvents btnResetGame As System.Windows.Forms.Button
    Friend WithEvents btnFire As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbAxe As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGamesLost As System.Windows.Forms.Label
    Friend WithEvents lblGamesWon As System.Windows.Forms.Label
    Friend WithEvents lblLapCounter As System.Windows.Forms.Label
    Friend WithEvents test As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblAxeCounter As System.Windows.Forms.Label
    Friend WithEvents lblNoMoreAxes As System.Windows.Forms.Label

End Class
