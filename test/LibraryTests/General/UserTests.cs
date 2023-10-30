namespace General.Tests;

public class UserTests
{
    [Test]
    public void TestConstructor()
    {
        string name = "john";

        User user = new User(name);

        Assert.AreEqual(name, user.Name);
        Assert.GreaterOrEqual(user.Id, 100000);
        Assert.Less(user.Id, 1000000);
    }

    [Test]
    public void TestEmptyConstructor()
    {
        string expectedName = "undefined";

        User user = new User(String.Empty);

        Assert.AreEqual(expectedName, user.Name);
    }
}