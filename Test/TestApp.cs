using App;

namespace Test;

[TestClass]
public class UnitTestApp
{
    [TestMethod]
    public void AppLoads()
    {
        Assert.IsTrue(Lib.SmokeTest());
    }
}
