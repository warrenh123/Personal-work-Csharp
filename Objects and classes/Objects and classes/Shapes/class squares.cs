class Square
{
    private double side;
    public static int NumberOfSquares;
    public double sideLength
    {
        get{ return side; }
        set{ side = value; }
    }
    public Square()
    {
        NumberOfSquares++;
    }

    public double Perimeter //We made this as a property
    {
        get{ return 4 * side; }
    }
    
    public double Area() //We made this a method but it should be a property
    {
        return side * side;
    }

}