using System;

class Program
{
    static void Main(string[] args)
    {
        // list will hold all the shapes, data type list<Shape>
        // a square, circle, and rectangle will be in the list.
        List<Shape> shapes = new List<Shape>();

        // create a square, circle, and rectangle
        Square square = new Square("red", 5);
        Circle circle = new Circle("blue", 3);
        Rectangle rectangle = new Rectangle("green", 4, 5);

        // add the shapes to the list
        shapes.Add(square);
        shapes.Add(circle);
        shapes.Add(rectangle);

        // loop through the list and display the area and color of each shape
        foreach (Shape shape in shapes)
        {
            DisplayShapeData(shape);
        }
    }

        // area and color of each shape will be displayed via a void method
    public static void DisplayShapeData(Shape shape)
    {
        float area = (float)shape.GetArea();
        string color = shape.GetColor();
        Console.WriteLine($"The area of the {color} {shape} shape is {area}");
    }

    
}