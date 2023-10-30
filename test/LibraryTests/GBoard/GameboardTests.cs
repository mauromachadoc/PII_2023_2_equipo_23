namespace GBoard.Tests;

public class GameboardTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestGameboardConstructor()
    {
        Battleship battleship1 = new Battleship(2, 3);
        Battleship battleship2 = new Battleship(1, 5);
        Battleship battleship3 = new Battleship(2, 1);
        Battleship battleship4 = new Battleship(2, 4);
        List<Battleship> battleships = new List<Battleship> { battleship1, battleship2, battleship3, battleship4 };
        Tuple<int, int> size = Tuple.Create(10, 11);

        Gameboard gameboard = new Gameboard(battleships, size);

        Assert.That(gameboard.Board.GetLength(0), Is.EqualTo(10));
        Assert.That(gameboard.Board.GetLength(1), Is.EqualTo(11));
        Assert.True(gameboard.Battleships.Contains(battleship1));
        Assert.True(gameboard.Battleships.Contains(battleship2));
        Assert.True(gameboard.Battleships.Contains(battleship3));
        Assert.True(gameboard.Battleships.Contains(battleship4));
        Assert.That(gameboard.IsBoardAlive, Is.EqualTo(true));
    }

    [Test]

    public void TestGameboardAllBattleshipsSunk()
    {
        Battleship battleship1 = new Battleship(2, 3);
        Battleship battleship2 = new Battleship(1, 5);
        Battleship battleship3 = new Battleship(2, 1);
        Battleship battleship4 = new Battleship(2, 4);
        List<Battleship> battleships = new List<Battleship> { battleship1, battleship2, battleship3, battleship4 };
        Tuple<int, int> size = Tuple.Create(10, 11);

        Gameboard gameboard = new Gameboard(battleships, size);
        battleship1.UpdateLife(-6);
        battleship2.UpdateLife(-5);
        battleship3.UpdateLife(-2);
        battleship4.UpdateLife(-8);

        Assert.That(gameboard.IsBoardAlive, Is.EqualTo(false));

    }
}