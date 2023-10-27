using GeometryShapesLibrary.Domain.Shapes.Circle.ValueObjects;

namespace GeometryShapesLibrary.Domain.Shapes;

/// <summary>
/// Class for circle.
/// </summary>
public class Circle : Shape
{
    /// <summary>
    /// Radius of ​​the circle.
    /// </summary>
    public Radius Radius { get; }

    /// <summary>
    /// Circle class constructor.
    /// </summary>
    /// <param name="radius">Radius of ​​the circle.</param>
    /// <param name="area">Area of ​​the circle.</param>
    private Circle(
        Radius radius,
        double area) : base(area)
    {
        Radius = radius;
    }

    /// <summary>
    /// Create circle.
    /// </summary>
    /// <param name="radius">Radius of ​​the circle.</param>
    /// <returns>Returns new circle.</returns>
    public static Circle Create(double radius)
    {
        var radiusValueObject = Radius.Create(radius);
        var area = GetArea(radiusValueObject);
        return new Circle(radiusValueObject, area);
    }

    /// <summary>
    /// Private method for calculate area of the circle.
    /// </summary>
    /// <param name="radius">Radius of ​​the circle.</param>
    /// <returns>Area of the circle.</returns>
    private static double GetArea(Radius radius)
    {
        return Math.PI * Math.Pow(radius.Value, 2);
    }
}
