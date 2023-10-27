// See https://aka.ms/new-console-template for more information
using GeometryShapesLibrary.Domain.Shapes;

var circle = Circle.Create(5);
Console.WriteLine(circle.ToString());

var triangle = Triangle.Create(5, 5, 5);
Console.WriteLine(triangle.ToString());