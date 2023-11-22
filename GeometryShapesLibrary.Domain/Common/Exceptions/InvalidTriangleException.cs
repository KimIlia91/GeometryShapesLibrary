namespace GeometryShapesLibrary.Domain.Common.Exceptions;

public sealed class InvalidTriangleException : Exception
{
    public InvalidTriangleException(string message) : base(message)
    {
    }
}
