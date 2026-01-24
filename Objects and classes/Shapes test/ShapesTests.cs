namespace Shapes_test;

[TestClass]
public sealed class TriangleTests
{
    [TestMethod]
    public void IsValidTriangle_ReturnsTrue()
    {
        Triangle t = new Triangle(3,4,5);
        Assert.IsTrue(t.IsValidTriangle);
    }

    public void AreAnglesValid_ReturnsTrue()
    {
        Triangle t = new Triangle(3,4,5);
        Assert.AreEqual(90, t.a1, 0.0001); // third argument is error tolerance
        Assert.AreEqual(36.87, t.a1, 0.01);
        Assert.AreEqual(53.13, t.a3, 0.01);
    }

    public void Area_ThreeFourFiveTriangle_ReturnsSix()
    {
        Triangle t = new Triangle(3,4,5);
        Assert.AreEqual(6,t.Area(), 0.0001);
    }
}

public sealed class SquaresTests
{
    
}
