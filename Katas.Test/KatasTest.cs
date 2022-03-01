using NUnit.Framework;
public class KatasTest
{
    [Test]
    public void IpsBetweenTest()
    {
        Assert.AreEqual(50, Katas.Katas.IpsBetween("10.0.0.0", "10.0.0.50"));
        Assert.AreEqual(256, Katas.Katas.IpsBetween("10.0.0.0", "10.0.1.0"));
        Assert.AreEqual(246, Katas.Katas.IpsBetween("20.0.0.10", "20.0.1.0"));
    }

    [Test]
    [TestCase(155, ExpectedResult = -1)]
    [TestCase(121, ExpectedResult = 144)]
    [TestCase(625, ExpectedResult = 676)]
    [TestCase(319225, ExpectedResult = 320356)]
    [TestCase(15241383936, ExpectedResult = 15241630849)]
    public static long FindNextSquare(long num)
    {
        return Katas.Katas.FindNextSquare(num);
    }

    [Test]
    public void ReverseWordsTest()
    {
        Assert.AreEqual("sihT si na !elpmaxe", Katas.Katas.ReverseWords("This is an example!"));
    }

}
