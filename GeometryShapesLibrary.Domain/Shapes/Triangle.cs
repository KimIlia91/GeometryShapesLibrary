using GeometryShapesLibrary.Domain.Shapes.ValueObjects;

namespace GeometryShapesLibrary.Domain.Shapes;

/// <summary>
/// Represents a triangle shape defined by its sides.
/// </summary>
public class Triangle : Shape
{
    /// <summary>
    /// Gets the sides of the triangle.
    /// </summary>
    public Sides Sides { get; }

    /// <summary>
    /// Constructor to create a Triangle.
    /// </summary>
    /// <param name="sides">The sides of the triangle.</param>
    /// <param name="area">The area of the triangle.</param>
    private Triangle(
        Sides sides,
        double area) : base(area)
    {
        Sides = sides;
    }

    /// <summary>
    /// Create a Triangle with the given side lengths.
    /// </summary>
    /// <param name="sideA">The length of the first side (Side A).</param>
    /// <param name="sideB">The length of the second side (Side B).</param>
    /// <param name="sideC">The length of the third side (Side C).</param>
    /// <returns>A new instance of the Triangle class defined by its sides.</returns>
    public static Triangle Create(
        double sideA,
        double sideB,
        double sideC)
    {
        var sides = Sides.Create(sideA, sideB, sideC);
        var area = GetArea(sides);
        return new Triangle(sides, area);
    }

    /// <summary>
    /// Calculate the area of the triangle using its sides.
    /// </summary>
    /// <param name="sides">The sides of the triangle.</param>
    /// <returns>The calculated area of the triangle.</returns>
    private static double GetArea(Sides sides)
    {
        double s = (sides.SideA + sides.SideB + sides.SideC) / 2;
        return Math.Sqrt(s * (s - sides.SideA) * (s - sides.SideB) * (s - sides.SideC));
    }

    /// <summary>
    /// Determines whether the triangle is right-angled.
    /// </summary>
    /// <returns>True if the triangle is right-angled, otherwise False.</returns>
    public bool IsRegularTriangle()
    {
        double[] sides = { Sides.SideA, Sides.SideB, Sides.SideC };
        Array.Sort(sides);
        return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
    }
}
