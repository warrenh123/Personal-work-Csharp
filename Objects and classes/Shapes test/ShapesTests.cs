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

    [TestMethod]
    public void AreAnglesValid_ReturnsTrue()
    {
        Triangle t = new Triangle(3,4,5);
        Assert.AreEqual(36.87, t.a1, 0.01); // third argument is error tolerance
        Assert.AreEqual(53.13, t.a2, 0.01);
        Assert.AreEqual(90, t.a3, 0.0001);
    }

    [TestMethod]
    public void Area_ThreeFourFiveTriangle_ReturnsSix()
    {
        Triangle t = new Triangle(3,4,5);
        Assert.AreEqual(6,t.Area(), 0.0001);
    }

    [TestMethod]
    [DataRow(3,4,5,6)]
    [DataRow(5,5,5,10.825)]

    public void Area_TestManyTriangles(double a,double b, double c, double expectedArea)
    {
        Triangle t = new Triangle(a,b,c);
        Assert.AreEqual(expectedArea, t.Area(), 0.01);
    }
}

[TestClass]
public sealed class SquaresTests
{
    [TestMethod]
    public void Perimeter_OfSquare_ReturnsTrue()
    {
        Square s = new Square();
        s.sideLength = 5;
        Assert.AreEqual(20,s.Perimeter,0.0001);
    }

    [TestMethod]
    public void Area_OfSquare_ReturnsTrue()
    {
        Square s = new Square();
        s.sideLength = 4;
        Assert.AreEqual(16, s.Area(), 0.0001);
    }

    [TestMethod]
    public void Constructor_Increments_NumberOfSquares()
    {
        Square.NumberOfSquares = 0;
        Square s1 = new Square();
        Square s2 = new Square();
        Square s3 = new Square();

        Assert.AreEqual(4, Square.NumberOfSquares); // 4 because we initialised a square in main program
    }
}