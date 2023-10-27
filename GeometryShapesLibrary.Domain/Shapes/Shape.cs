namespace GeometryShapesLibrary.Domain.Shapes;

public abstract class Shape
{
    public double Area { get; }

    public Shape(
        double area)
    {
        Area = area;
    }

    public override string ToString()
    {
        return $"Type: {GetType().Name}, Area: {Area}";
    }
}
