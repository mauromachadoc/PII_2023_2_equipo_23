namespace Interaction.Tests;

public class ConsolePrinterTests
{

    [Test]
    public void TestStringPrinted()
    {

        ConsolePrinter consoleP = new ConsolePrinter();
        StringWriter stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        consoleP.Print("1243");

        string consoleOutput = stringWriter.ToString();

        Assert.AreEqual(consoleOutput.Trim(), "1243");

    }
}