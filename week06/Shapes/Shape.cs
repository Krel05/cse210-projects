public abstract class Shape
{
    protected string _color;
    protected string _name;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetShapeName()
    {
        return _name;
    }
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();
}