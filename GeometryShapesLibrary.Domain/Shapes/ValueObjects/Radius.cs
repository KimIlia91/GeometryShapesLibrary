using GeometryShapesLibrary.Domain.Common.Models;
using GeometryShapesLibrary.Domain.Common.Resources;

namespace GeometryShapesLibrary.Domain.Shapes.ValueObjects;

/// <summary>
/// Class for radius.
/// </summary>
public class Radius : ValueObject
{
    /// <summary>
    /// Value of the radius.
    /// </summary>
    public double Value { get; }

    /// <summary>
    /// Constructor of the radius class.
    /// </summary>
    /// <param name="value">Value of the radius.</param>
    private Radius(double value)
    {
        Value = value;
    }

    /// <summary>
    /// Create a radius.
    /// </summary>
    /// <param name="value">The value of the radius.</param>
    /// <returns>A new instance of the Radius class with the specified value.</returns>
    /// <exception cref="ArgumentException">Thrown when the provided value is less than or equal to zero.</exception>
    public static Radius Create(double value)
    {
        if (value <= 0)
            throw new ArgumentException(ErrorResources.NegativeNumber, nameof(value));

        return new Radius(value);
    }

    /// <summary>
    /// Gets the equality components of the radius.
    /// </summary>
    /// <returns>An IEnumerable containing the radius value.</returns>
    public override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
