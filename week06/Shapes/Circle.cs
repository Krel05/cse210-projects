public class Circle : Shape
{
    private double _radius;
    private double PI = Math.PI;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        _name = "Circle";
    }

    public override double GetArea()
    {
        return PI * _radius * _radius;
    }
}