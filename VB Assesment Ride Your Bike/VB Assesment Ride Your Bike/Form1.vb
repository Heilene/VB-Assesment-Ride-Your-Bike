Public Class Form1
    'link form to class
    Dim myRide As New RideGame

    'Loads form title
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Text = myRide.FormName
    End Sub



    Private Sub LoadAndReset(sender As Object, e As EventArgs) Handles bntLoad.Click, btnResetGame.Click

        'Resets game to default values on either load or reset buttons
        myRide.Reset()

        'calls method to load/reset game 
        pbRide.Image = myRide.BikeImage

        'Sets lap display 
        lblLapCounter.Text = myRide.LapCounterDisplay

        'Set Axe counter
        lblAxeCounter.Text = myRide.AxeCounter

        'Resets axe message to null
        lblNoMoreAxes.Text = myRide.AxeMessage



    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        'Calls the set up method from class
        myRide.SetYourLap()

        pbRide.Image = myRide.BikeImage

        'Enables fire button
        btnFire.Enabled = True


    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        'Calls the start your lap method from class
        myRide.StartALap()

        'Displays image result according to winning, loss, defaul or with axe
        pbRide.Image = myRide.BikeImage

        lblLapCounter.Text = myRide.LapCounterDisplay

        'Sets checkbox to default ready for the next time it's selected
        cbAxe.Checked = False

        'Disable Fire button after all random numbers have been used up
        'Activate timer
        If myRide.RandomNumber = 0 And myRide.GameOver = 1 Then
            Timer1.Enabled = True
            btnFire.Enabled = False
        End If


    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbAxe.CheckedChanged

        'If Statement that only subtract from the axe counter when checkbox is selected and handels the Axe Group box display
        'Returns the axe value back to default if not checked
        If cbAxe.Checked = True Then
            myRide.Axe = True
            myRide.AxeCounter -= 1

        Else
            lblAxeCounter.Text = myRide.AxeCounter
            lblNoMoreAxes.Text = myRide.AxeMessage
            myRide.Axe = False
        End If

        'switched of check box so no more axes can be selected
        If myRide.AxeCounter = 0 Then
            lblAxeCounter.Text = 0
            cbAxe.Visible = False
        End If



    End Sub

    'Timer handels delayed message display box and win and lose counter
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Static secondsCounter As Integer

        secondsCounter += 1

        If secondsCounter = 6 Then
            'Displays number of games lost
            lblGamesLost.Text = myRide.GameLost

            'Displays number of games won
            lblGamesWon.Text = myRide.GameWon

            MsgBox(myRide.ResultMessage)
            'reset timer to 1
            secondsCounter = 1
            Timer1.Enabled = False
            cbAxe.Visible = True
        End If


    End Sub
End Class
