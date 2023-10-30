namespace GBoard.Tests;

public class PairTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestPairConstructor()
    {
        int t1 = 23;
        bool t2 = false;

        Pair<int, bool> pair = new Pair<int, bool>(t1, t2);

        Assert.That(pair.First, Is.EqualTo(t1));
        Assert.That(pair.Second, Is.EqualTo(t2));
    }

    [Test]

    public void TestPairWithNullSecond()
    {
        int t1 = 0;
        List<int>? mylist = null;

        Pair<int, List<int>> pair = new Pair<int, List<int>>(t1, mylist);

        Assert.That(pair.First, Is.EqualTo(t1));
        Assert.That(pair.Second, Is.EqualTo(null));

    }

    [Test]

    public void TestPairWithNoSecond()
    {
        int t1 = 2;

        Pair<int, string> pair1 = new Pair<int, string>(t1);
        Pair<int, int> pair2 = new Pair<int, int>(t1);
        Pair<int, bool> pair3 = new Pair<int, bool>(t1);

        Assert.That(pair1.First, Is.EqualTo(t1));
        Assert.That(pair1.Second, Is.EqualTo(null));
        Assert.That(pair2.First, Is.EqualTo(t1));
        Assert.That(pair2.Second, Is.EqualTo(0));
        Assert.That(pair3.First, Is.EqualTo(t1));
        Assert.That(pair3.Second, Is.EqualTo(false));
    }
}