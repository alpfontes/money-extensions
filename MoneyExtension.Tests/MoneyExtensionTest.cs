namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTest
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 270.91M;
        var cents = valor.ToCents();

        Assert.AreEqual(27091, cents);
    }
}