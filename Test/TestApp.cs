using App;

namespace Test;

[TestClass]
public class TestApp
{
    [TestMethod]
    public void AppLoads()
    {
        Assert.IsTrue(SmokeTests.Test());
    }
}
