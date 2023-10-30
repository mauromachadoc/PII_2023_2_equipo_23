using GBoard;
using General;
using Interaction;
namespace Matches.Tests;

public class MatchTests
{
    [Test]
    public void TestConstructor()
    {
        List<Battleship> playableBattleships = new List<Battleship>();
        Battleship b1 = new Battleship(3, 1);
        playableBattleships.Add(b1);
        Battleship b2 = new Battleship(2, 2);
        playableBattleships.Add(b2);
        Battleship b3 = new Battleship(1, 1);
        playableBattleships.Add(b3);
        Battleship b4 = new Battleship(1, 2);
        playableBattleships.Add(b4);
        Battleship b5 = new Battleship(2, 1);
        playableBattleships.Add(b5);
        Tuple<int, int> size1 = new Tuple<int, int>(5, 5);
        Gameboard user1Gameboard = new Gameboard(playableBattleships, size1);
        List<Battleship> playableBattleships1 = new List<Battleship>();
        Battleship b11 = new Battleship(3, 1);
        playableBattleships1.Add(b1);
        Battleship b21 = new Battleship(2, 2);
        playableBattleships1.Add(b2);
        Battleship b31 = new Battleship(1, 1);
        playableBattleships1.Add(b3);
        Battleship b41 = new Battleship(1, 2);
        playableBattleships1.Add(b4);
        Battleship b51 = new Battleship(2, 1);
        playableBattleships1.Add(b5);
        Tuple<int, int> size2 = new Tuple<int, int>(5, 5);
        Gameboard user2Gameboard = new Gameboard(playableBattleships1, size2);
        User user1 = new User("carlo");
        IInGamePlayerInteraction igpi = null; //Not yet implemented
        string matchstatus = "str";

        Match match = new Match(user1Gameboard, user2Gameboard, user1, igpi);

        Assert.AreEqual(user1Gameboard, match.User1Gameboard);
        Assert.AreEqual(user2Gameboard, match.User2Gameboard);
        Assert.AreEqual(user1, match.User1);
        Assert.IsNull(match.User2);
        Assert.GreaterOrEqual(match.MatchID, 100000);
        Assert.Less(match.MatchID, 1000000);
        Assert.AreEqual(matchstatus, match.MatchStatus);

    }
}