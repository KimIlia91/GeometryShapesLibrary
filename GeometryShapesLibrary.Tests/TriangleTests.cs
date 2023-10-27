using GeometryShapesLibrary.Domain.Shapes;

namespace GeometryShapesLibrary.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(3.0, 4.0, 5.0, 6.0)]
    [InlineData(6.0, 8.0, 10.0, 24.0)]
    [InlineData(1.0, 1.0, 1.0, 0.433)]
    [InlineData(3.0, 3.0, 4.0, 4.472)]
    public void GetArea_WithValidTriangle_ReturnsExpectedArea(
    double sideA, double sideB, double sideC, double expectedArea)
    {
        // Arrange
        var triangle = Triangle.Create(sideA, sideB, sideC);

        // Act
        double actualArea = triangle.Area;

        // Assert
        Assert.Equal(expectedArea, actualArea, 3);
    }

    [Theory]
    [InlineData(3.0, 4.0, 5.0)]
    [InlineData(6.0, 8.0, 10.0)]
    [InlineData(1.0, 1.0, 1.0)]
    [InlineData(3.0, 3.0, 4.0)]
    public void CreateTriangle_WithValidSides_ReturnsTriangleObject(
       double sideA, double sideB, double sideC)
    {
        // Act
        var triangle = Triangle.Create(sideA, sideB, sideC);

        // Assert
        Assert.NotNull(triangle);
        Assert.IsType<Triangle>(triangle);
    }

    [Theory]
    [InlineData(3.0, 4.0, 5.0, true)]
    [InlineData(1.0, 1.0, 1.0, false)]
    [InlineData(6.0, 8.0, 10.0, true)]
    public void IsRightTriangle_WithDifferentTriangles_ReturnsExpectedResult(
       double sideA, double sideB, double sideC, bool expectedIsRightTriangle)
    {
        // Arrange
        var triangle = Triangle.Create(sideA, sideB, sideC);

        // Act
        var isRightTriangle = triangle.IsRegularTriangle();

        // Assert
        Assert.Equal(expectedIsRightTriangle, isRightTriangle);
    }

    [Theory]
    [InlineData(0.0, 4.0, 5.0)]
    [InlineData(3.0, 0.0, 5.0)]
    [InlineData(3.0, 4.0, 0.0)]
    [InlineData(-2.0, 4.0, 5.0)]
    public void CreateTriangle_WithInvalidSides_ThrowsArgumentException(
       double sideA, double sideB, double sideC)
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => Triangle.Create(sideA, sideB, sideC));
    }
}
