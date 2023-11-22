namespace GeometryShapesLibrary.Domain.Common.Exceptions;

public sealed class NegativeNumberException : ArgumentException
{
    public NegativeNumberException(string message, string paramName) : base(message, paramName)
    {
    }
}
