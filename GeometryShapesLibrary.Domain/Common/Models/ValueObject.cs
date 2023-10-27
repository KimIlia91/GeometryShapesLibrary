namespace GeometryShapesLibrary.Domain.Common.Models;

/// <summary>
/// Base class for creating value objects that represent immutable, equal-by-value objects.
/// </summary>
public abstract class ValueObject : IEquatable<ValueObject>
{
    /// <summary>
    /// Gets the equality components of the value object.
    /// </summary>
    /// <returns>An enumerable collection of the components that contribute to equality.</returns>
    public abstract IEnumerable<object> GetEqualityComponents();

    /// <summary>
    /// Determines whether this value object is equal to another object.
    /// </summary>
    /// <param name="obj">The object to compare to this value object.</param>
    /// <returns>True if the objects are equal; otherwise, false.</returns>
    public override bool Equals(object? obj)
    {
        if (obj is null || obj.GetType() != GetType())
        {
            return false;
        }

        var valueObject = (ValueObject)obj;

        return GetEqualityComponents()
            .SequenceEqual(valueObject.GetEqualityComponents());
    }

    /// <summary>
    /// Equality operator for comparing two value objects for equality.
    /// </summary>
    /// <param name="left">The left value object to compare.</param>
    /// <param name="right">The right value object to compare.</param>
    /// <returns>True if the value objects are equal; otherwise, false.</returns>
    public static bool operator ==(ValueObject left, ValueObject right)
    {
        return Equals(left, right);
    }

    /// <summary>
    /// Inequality operator for comparing two value objects for inequality.
    /// </summary>
    /// <param name="left">The left value object to compare.</param>
    /// <param name="right">The right value object to compare.</param>
    /// <returns>True if the value objects are not equal; otherwise, false.</returns>
    public static bool operator !=(ValueObject left, ValueObject right)
    {
        return !Equals(left, right);
    }

    /// <summary>
    /// Gets a hash code for the value object.
    /// </summary>
    /// <returns>A hash code based on the components that contribute to equality.</returns>
    public override int GetHashCode()
    {
        return GetEqualityComponents()
            .Select(x => x?.GetHashCode() ?? 0)
            .Aggregate((x, y) => x ^ y);
    }

    /// <summary>
    /// Determines whether this value object is equal to another value object.
    /// </summary>
    /// <param name="other">The other value object to compare to.</param>
    /// <returns>True if the value objects are equal; otherwise, false.</returns>
    public bool Equals(ValueObject? other)
    {
        return Equals((object?)other);
    }
}
