namespace GeometryShapesLibrary.Domain.Shapes;

/// <summary>
/// Base class for geometric shapes.
/// </summary>
public abstract class Shape
{
    /// <summary>
    /// Area of ​​the shape.
    /// </summary>
    public double Area { get; }

    /// <summary>
    /// Shape class constructor.
    /// </summary>
    /// <param name="area">Area of ​​the shape.</param>
    protected Shape(
        double area)
    {
        Area = area;
    }

    /// <summary>
    /// Returns a string representation of the shape.
    /// </summary>
    /// <returns>Returns a string representation of the shape</returns>
    public override string ToString()
    {
        return $"Type: {GetType().Name}, Area: {Area}";
    }
}
