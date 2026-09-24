using ConnectFour;
using Xunit;

namespace ConnectFour.Tests;

public class GameStateWinTests
{
    [Fact]
    public void PlayerOneWins_WhenFourConnectedHorizontally()
    {
        var game = new GameState();

        // Player 1 horizontal win: columns 0,1,2,3 on bottom row
        game.TheBoard[35] = 1;
        game.TheBoard[36] = 1;
        game.TheBoard[37] = 1;
        game.TheBoard[38] = 1;

        var result = game.CheckForWin();

        Assert.Equal(GameState.WinState.Player1_Wins, result);
    }
}
