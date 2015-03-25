Imports System.Drawing
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VB_Assesment_Ride_Your_Bike

<TestClass()> Public Class RideBikeTests

    Dim RideBike As New RideGame


    <TestMethod()> Public Sub WinningTest() 'Test that game result is a win

        Dim gameResultStatusWin As Boolean = True

        Assert.AreEqual(gameResultStatusWin, RideBike.GameResult(1, True))

    End Sub

    <TestMethod()> Public Sub LosingTest() 'Test that game result as a loss

        'GameResult method returns a true or false for game result

        Dim gameResultStatusLoss As Boolean = False

        Assert.AreEqual(gameResultStatusLoss, RideBike.GameResult(1, False))

    End Sub

End Class