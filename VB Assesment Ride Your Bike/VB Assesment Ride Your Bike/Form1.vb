Public Class Form1
    'link form to class
    Dim myRide As New RideGame


    Private Sub LoadAndReset(sender As Object, e As EventArgs) Handles bntLoad.Click, btnResetGame.Click
        'calls method to load/reset game 
        pbRide.Image = myRide.BikeImage

        'Sets lap display to zero
        lblLapCounter.Text = myRide.LapCounterDisplay

        'Set Axe counter
        lblAxeCounter.Text = myRide.AxeCounter


    End Sub

    Private Sub btnSpin_Click(sender As Object, e As EventArgs) Handles btnSpin.Click
        'Calls the set up method from class
        myRide.SetYourLap()

        pbRide.Image = myRide.BikeImage


    End Sub

    Private Sub btnFire_Click(sender As Object, e As EventArgs) Handles btnFire.Click
        'Calls the start your lap method from class
        myRide.StartALap()

        pbRide.Image = myRide.BikeImage

        test.Text = myRide.RandomNumber

        lblLapCounter.Text = myRide.LapCounterDisplay

        If myRide.RandomNumber = 0 Then
            MsgBox(myRide.ResultMessage)
        End If

        'Sets checkbox to default ready for the next time it's selected
        cbAxe.Checked = False


    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbAxe.CheckedChanged

        'If Statement that only subtract from the axe counter when checkbox is selected and handels the Axe Group box display
        If cbAxe.Checked = True Then
            myRide.Axe = True
            myRide.AxeCounter -= 1

        Else
            lblAxeCounter.Text = myRide.AxeCounter
            lblNoMoreAxes.Text = myRide.AxeMessage
        End If



    End Sub
End Class
