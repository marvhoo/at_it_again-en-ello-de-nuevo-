
class Circle : Shape
{
    private readonly double _radius;

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        double roundedArea = Math.Round(area, 2); // Rounds to two decimal points
        return roundedArea;
    }

}