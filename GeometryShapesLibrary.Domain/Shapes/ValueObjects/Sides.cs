using GeometryShapesLibrary.Domain.Common.Models;
using GeometryShapesLibrary.Domain.Common.Resources;

namespace GeometryShapesLibrary.Domain.Shapes.ValueObjects;

public class Sides : ValueObject
{
    /// <summary>
    /// Length of the first side (Side A) of the triangle.
    /// </summary>
    public double SideA { get; private set; }

    /// <summary>
    /// Length of the second side (Side B) of the triangle.
    /// </summary>
    public double SideB { get; private set; }

    /// <summary>
    /// Length of the third side (Side C) of the triangle.
    /// </summary>
    public double SideC { get; private set; }

    /// <summary>
    /// Private constructor to create an instance of the Sides class.
    /// </summary>
    /// <param name="sideA">Length of Side A.</param>
    /// <param name="sideB">Length of Side B.</param>
    /// <param name="sideC">Length of Side C.</param>
    private Sides(
        double sideA,
        double sideB,
        double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }

    /// <summary>
    /// Create an instance of the Sides.
    /// </summary>
    /// <param name="sideA">Length of Side A.</param>
    /// <param name="sideB">Length of Side B.</param>
    /// <param name="sideC">Length of Side C.</param>
    /// <returns>An instance of the Sides class representing the sides of a triangle.</returns>
    /// <exception cref="ArgumentException">Thrown when any of the side lengths is less than or equal to zero.</exception>
    public static Sides Create(
        double sideA,
        double sideB,
        double sideC)
    {
        if (sideA <= 0)
            throw new ArgumentException(ErrorResources.NegativeNumber, nameof(sideA));

        if (sideB <= 0)
            throw new ArgumentException(ErrorResources.NegativeNumber, nameof(sideB));

        if (sideC <= 0)
            throw new ArgumentException(ErrorResources.NegativeNumber, nameof(sideC));

        return new Sides(sideA, sideB, sideC);
    }

    /// <summary>
    /// Get the equality components of the Sides object.
    /// </summary>
    /// <returns>An IEnumerable containing the side lengths (Side A, Side B, Side C).</returns>
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return SideA;
        yield return SideB;
        yield return SideC;
    }
}
