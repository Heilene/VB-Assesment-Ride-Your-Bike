
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VB_Assesment_Ride_Your_Bike

<TestClass()> Public Class RideBikeTests

    ReadOnly _rideBike As New RideGame


    <TestMethod()> Public Sub WinningTest() 'Test that game result is a win

        Dim gameResultStatusWin As Boolean
        gameResultStatusWin = True

        'testing gameResult function
        Assert.AreEqual(gameResultStatusWin, _rideBike.GameResult(1, True))

    End Sub

    <TestMethod()> Public Sub LosingTest() 'Test that game result as a loss

        Dim gameResultStatusLoss As Boolean
        gameResultStatusLoss = False

        'testing gameResult function
        Assert.AreEqual(gameResultStatusLoss, _rideBike.GameResult(1, False))

    End Sub

End Class