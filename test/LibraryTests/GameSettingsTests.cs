using GBoard;
using Matches;

namespace General.Tests;


public class GameSettingsTests
{
    [Test]
    public void TestConstructor()
    {
        Tuple<int, int> tuple = new Tuple<int, int>(2, 2);
        Tuple<int, int> size = new Tuple<int, int>(1, 1);
        Battleship battleship = new Battleship(size);
        List<Battleship> battleships = new List<Battleship>();
        battleships.Add(battleship);


        GameSettings gameSettings = new GameSettings(size, battleships);

        Assert.AreEqual(battleships, gameSettings.PlayableBattleships);
        Assert.AreEqual(size, gameSettings.Size);
    }

    [Test]
    public void TestEmptyConstructor()
    {
        //Copy from constructor if changed
        Tuple<int, int> expectedSize = new Tuple<int, int>(5, 5);

        GameSettings gameSettings = new GameSettings();

        Assert.AreEqual(expectedSize, gameSettings.Size);
    }
}