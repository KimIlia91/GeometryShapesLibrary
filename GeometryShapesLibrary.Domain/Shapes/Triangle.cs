using GeometryShapesLibrary.Domain.Common.Resources;
using GeometryShapesLibrary.Domain.Shapes.ValueObjects;

namespace GeometryShapesLibrary.Domain.Shapes;

/// <summary>
/// Represents a triangle shape defined by its sides.
/// </summary>
public class Triangle : Shape
{
    /// <summary>
    /// An instance of the Sides class representing the sides of a triangle.
    /// </summary>
    public Sides Sides { get; }

    public bool IsRegularTriangle { get; }

    /// <summary>
    /// Constructor of the Triangle class.
    /// </summary>
    /// <param name="sides">The sides of the triangle.</param>
    /// <param name="area">Area of ​​the triangle.</param>
    internal Triangle(
        Sides sides,
        bool isRegularTriangle,
        double area) : base(area)
    {
        Sides = sides;
        IsRegularTriangle = isRegularTriangle;
    }

    /// <summary>
    /// Creates an instance of the Triangle class based on the lengths of the sides.
    /// </summary>
    /// <param name="sideA">Length of side A.</param>
    /// <param name="sideB">Length of side B.</param>
    /// <param name="sideC">Length of side C.</param>
    /// <returns>An instance of the Triangle class.</returns>
    /// <exception cref="ArgumentException">Thrown when the provided side lengths do not form a valid triangle.</exception>
    public static Triangle Create(
        double sideA,
        double sideB,
        double sideC)
    {
        if (!IsValidTriangle(sideA, sideB, sideC))
            throw new ArgumentException(ErrorResources.InvalidTriangle);

        var sides = Sides.Create(sideA, sideB, sideC);
        var area = GetArea(sides);
        var isRegularTriangle = IsRightTriangle(sides);
        return new Triangle(sides, isRegularTriangle, area);
    }

    /// <summary>
    /// Returns a string representation of the triangle.
    /// </summary>
    /// <returns>Returns a string representation of the triangle.</returns>
    public override string ToString()
    {
        return $"Type: {GetType().Name}, Area: {Area}, Is regular triangel: {IsRegularTriangle}";
    }

    /// <summary>
    /// Calculate the area of a triangle.
    /// </summary>
    /// <param name="sides">An object containing the lengths of the three sides of the triangle.</param>
    /// <returns>The calculated area of the triangle.</returns>
    private static double GetArea(Sides sides)
    {
        double s = (sides.SideA + sides.SideB + sides.SideC) / 2;
        return Math.Sqrt(s * (s - sides.SideA) * (s - sides.SideB) * (s - sides.SideC));
    }

    /// <summary>
    /// Checks is a right triangle.
    /// </summary>
    /// <param name="sides">An object containing the lengths of the three sides of the triangle.</param>
    /// <returns>True if the triangle is a right triangle; otherwise, false.</returns>
    private static bool IsRightTriangle(
        Sides sides)
    {
        double[] sidesArr = { sides.SideA, sides.SideB, sides.SideC };
        Array.Sort(sidesArr);
        return Math.Pow(sidesArr[0], 2) + Math.Pow(sidesArr[1], 2) == Math.Pow(sidesArr[2], 2);
    }

    /// <summary>
    /// Checks if the given side lengths can form a valid triangle.
    /// </summary>
    /// <param name="sideA">Length of side A.</param>
    /// <param name="sideB">Length of side B.</param>
    /// <param name="sideC">Length of side C.</param>
    /// <returns>True if the side lengths can form a valid triangle; otherwise, false.</returns>
    private static bool IsValidTriangle(double sideA, double sideB, double sideC)
    {
        return sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA;
    }
}
