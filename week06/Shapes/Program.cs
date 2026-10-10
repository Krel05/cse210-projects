using System;

class Program
{
    static void Main(string[] args)
    {
        // Square
        Square square = new Square(4, "green");
        string squareColor = square.GetColor();
        double squareArea = square.GetArea();
        Console.WriteLine($"The color of the square is {squareColor} and its area is {squareArea}");

        // Rectangle
        Rectangle rectangle = new Rectangle(2, 4, "yellow");
        string rectangleColor = rectangle.GetColor();
        double reactangleArea = rectangle.GetArea();
        Console.WriteLine($"The color of the rectangle is {squareColor} and its area is {squareArea}");

        // Circle
        Circle circle = new Circle(4, "red");
        string circleColor = circle.GetColor();
        double circleArea = circle.GetArea();
        Console.WriteLine($"The color of the circle is {circleColor} and its area is {circleArea:F2}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square(2, "purple"));
        shapes.Add(new Rectangle(3, 2, "gray"));
        shapes.Add(new Circle(5, "white"));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"The color of the {shape.GetShapeName()} is {shape.GetColor()} and its area is {shape.GetArea():F2}");
        }
    }
}