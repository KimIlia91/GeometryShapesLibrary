# Geometry Shapes Library

Написать на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:

- Юнит-тесты
- Легкость добавления других фигур
- Вычисление площади фигуры без знания типа фигуры в compile-time
- Проверку на то, является ли треугольник прямоугольным

## Пример использования
### Использование
C#
```csharp
	var circle = Circle.Create(5);
	Console.WriteLine(circle.ToString());
	
	var triangle = Triangle.Create(5, 5, 5);
	Console.WriteLine(triangle.ToString());
```

### Вывод
CLI
```cli 
	Type: Circle, Area: 78,53981633974483

	Type: Triangle, Area: 10,825317547305483, Is regular triangel: False
```

[Cсылка на второе задание](https://github.com/KimIlia91/SqlImplementation)
