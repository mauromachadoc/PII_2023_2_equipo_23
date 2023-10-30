namespace GBoard.Tests;

public class BattleshipTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestBattleShipConstructorA()
    {
        Tuple<int, int> size = Tuple.Create(2, 3);

        Battleship battleship = new Battleship(size);

        Assert.That(battleship.Size, Is.EqualTo(size));
        Assert.That(battleship.Life, Is.EqualTo(6));

    }

    [Test]

    public void TestBattleShipConstructorB()
    {
        int height = 2;
        int width = 3;

        Battleship battleship = new Battleship(height, width);

        Assert.That(battleship.Size, Is.EqualTo(Tuple.Create(2, 3)));
        Assert.That(battleship.Life, Is.EqualTo(6));
    }

    [Test]

    public void TestUpdateLife()
    {
        Battleship battleship = new Battleship(2, 3);

        battleship.UpdateLife(-2);

        Assert.That(battleship.Life, Is.EqualTo(4));
    }
}