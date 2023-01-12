using App.Lib;

namespace Test;

[TestClass]
public class TestEEMUA191Rev3
{
    [TestMethod]
    public void TestGetZoneForPoint00()
    {
        
        EEMUA191Rev3.GetZoneForPoint(0,0);
        // Assert.IsTrue(Lib.SmokeTest());
    }

    [DataTestMethod]
    [DataRow(0,0)]
    [DataRow(1,0)]
    [DataRow(1,10)]
    [DataRow(0,25)]
    [DataRow(0.5, 11)]
    [DataRow(0.5, 17.5 )]
    public void TestGetZoneForPointsRobust(double x, double y)
    {
        Assert.AreEqual( EEMUA191Rev3.GetZoneForPoint(0,0), EEMUA191Rev3.StateNames.Robust);
    }

    [DataTestMethod]
    [DataRow(1.1,0)]
    [DataRow(2,0)]
    [DataRow(2,25)]
    [DataRow(1,50)]
    [DataRow(0,50)]
    [DataRow(0,25.1)]
    [DataRow(1.5, 37.5)]
    public void TestGetZoneForPointsStable(double x, double y)
    {
        Assert.AreEqual( EEMUA191Rev3.GetZoneForPoint(x,y), EEMUA191Rev3.StateNames.Stable);
    }

    [DataTestMethod]
    [DataRow(10,0)]
    [DataRow(10,25)]
    [DataRow(2,50)]
    [DataRow(1.1,50)]
    [DataRow(2.1,25)]
    [DataRow(2.1,0)]
    [DataRow(6, 37.4 )]
    public void TestGetZoneForPointReactive(double x, double y)
    {
        Assert.AreEqual( EEMUA191Rev3.GetZoneForPoint(x,y), EEMUA191Rev3.StateNames.Reactive);
    }

    [DataTestMethod]
    [DataRow(100, 0)]
    [DataRow(100,50)]
    [DataRow(2.1, 50)]
    [DataRow(6, 40 )]
    public void TestGetZoneForPointOverloaded(double x, double y)
    {
        Assert.AreEqual( EEMUA191Rev3.GetZoneForPoint(x,y), EEMUA191Rev3.StateNames.Overloaded);

    }
    
}
