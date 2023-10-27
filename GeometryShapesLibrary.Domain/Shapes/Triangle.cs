using GeometryShapesLibrary.Domain.Shapes.ValueObjects;

namespace GeometryShapesLibrary.Domain.Shapes;

public class Triangle : Shape
{
    public Sides Sides { get; }

    public Triangle(
        Sides sides,
        double area) : base(area)
    {
        Sides = sides;
    }

    public static Triangle Create(
        double sideA, 
        double sideB, 
        double sideC)
    {
        var sides = Sides.Create(sideA, sideB, sideC);
        var area = GetArea(sides);
        return new Triangle(sides, area);
    }

    private static double GetArea(Sides sides)
    {
        double s = (sides.SideA + sides.SideB + sides.SideC) / 2;
        return Math.Sqrt(s * (s - sides.SideA) * (s - sides.SideB) * (s - sides.SideC));
    }
}
