using GeometryShapesLibrary.Domain.Common.Exceptions;
using GeometryShapesLibrary.Domain.Shapes;

namespace GeometryShapesLibrary.Tests;

public class CircleTests
{
    [Theory]
    [InlineData(3.0)]
    [InlineData(1.5)]
    [InlineData(0.1)]
    [InlineData(100)]
    [InlineData(1000000)]
    public void CreateCircle_WithValidRadius_ReturnsCircleObject(
        double radiusValue)
    {
        // Act
        var circle = Circle.Create(radiusValue);

        // Assert
        Assert.NotNull(circle);
        Assert.IsType<Circle>(circle);
    }

    [Theory]
    [InlineData(3.0, 28.274)]
    [InlineData(1.5, 7.069)]
    [InlineData(1000000, 3141592653589.793)]
    [InlineData(0.5, 0.785)]
    public void GetArea_WithValidCircle_ReturnsExpectedArea(
        double radiusValue, double expectedArea)
    {
        // Arrange
        var circle = Circle.Create(radiusValue);

        // Act
        double actualArea = circle.Area;

        // Assert
        Assert.Equal(expectedArea, actualArea, 3);
    }

    [Theory]
    [InlineData(0.0)]
    [InlineData(-2.0)]
    [InlineData(-2)]
    [InlineData(-0.1)]
    [InlineData(-1000000)]
    public void CreateCircle_WithInvalidRadius_ThrowsArgumentException(
        double radiusValue)
    {
        // Act & Assert
        Assert.Throws<NegativeNumberException>(() => Circle.Create(radiusValue));
    }
}
