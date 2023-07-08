
class Square : Shape
{
    private double _side;

    // constructor will accept color and side, amd then call the base 
    // constructor with the color.
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // override the GetArea method to return the area of a square
    public override double GetArea()
    {
        return _side * _side;
    }
}