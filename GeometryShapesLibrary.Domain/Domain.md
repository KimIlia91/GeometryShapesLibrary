# Domain

- [Shapes](#shapes)
	- [Shape](#shape)
	- [Circle](#circle)
	- [Triangel](#triangel)
- [ValueObjects](#value-objects)
	- [Radius](#radius)
	- [Sides](#sides)
- [Common](#common)
	- [ValueObject](#value-object)

# Shapes

## Shape

`Shape` - это базовый абстрактный класс, представляющий фигуры.

#### Свойства

- ` public double Area { get; }`: Свойство, представляющее площадь 
фигур.

#### Методы

- `public override string ToString()`: 
Этот метод возвращает строковое представление фигуры. 
Он отображает тип фигуры (например, "Круг" или "Треугольник") 
и её площадь.

## Circle

`Circle` - класс представляет круг и наследуется от базового 
класса [`Shape`](#shape). Он содержит информацию о радиусе круга 
и его площади.

#### Свойства

- `public Radius Radius { get; }`: Свойство, радиус круга.


#### Методы

- `public static Circle Create(double radius))`: 
Статический метод для создания объекта `Circle` на основе заданного 
радиуса. Возвращает новый экземпляр `Circle`.

- `private static double GetArea(Radius radius)`: 
Статический частный метод, который вычисляет площадь круга на основе 
заданного радиуса.

## Triangle

`Triangel` - это класс, представляющий треугольник и наследуется от базового класса `Shape`.

#### Свойства

- `public Sides Sides { get; }`: Свойство, представляющее стороны треугольник.
- `public bool IsRegularTriangle { get; }`: Свойство, представляющее является ли треугольник правильным или нет.

#### Методы

- `public static Triangle Create(double sideA, double sideB, double sideC)`: 
Статический метод для создания экземпляра класса `Triangel`. Проверяет, что стороны 
положительны, и выбрасывает `ArgumentException` в случае невалидных данных.

- `private static double GetArea(Sides sides)`: 
Статический частный метод, который вычисляет площадь треугольника по 
трем сторонам.

- `private bool IsRightTriangle()`: 
Метод, проверяющий является ли треугольник правильным и возвращает `false`
если треугольник неправильный иначе `true`.

# ValueObjects

## Radius

`Radius` - это класс, представляющий радиус.

#### Свойства

- `public double Value { get; private set; }`: Свойство, представляющее значение радиуса.

#### Методы

- `public static Radius Create(double radius)`: 
Статический метод для создания экземпляра класса `Radius`. Проверяет, что радиус 
положительны, и выбрасывает `ArgumentException` в случае невалидных данных.

- `public override IEnumerable<object> GetEqualityComponents()`: 
Метод, реализованный из базового класса `ValueObject`, возвращает компоненты объекта, 
используемые для сравнения на равенство.

#### Примечание

Класс `Radius` предназначен для представления радиуса. Он обеспечивает проверку 
на валидность входных данных и может быть использован вместе с классом `Circle` для создания 
объектов, представляющих круг.

## Sides

`Sides` - это класс, стороны фигуры.

#### Свойства

- `public double SideA { get; private set; }`: Свойство, представляющее сторону A.
- `public double SideB { get; private set; }`: Свойство, представляющее сторону B.
- `public double SideC { get; private set; }`: Свойство, представляющее сторону C.

#### Методы

- `public static Sides Create(double sideA, double sideB, double sideC)`: 
Статический метод для создания экземпляра класса `Triangle`. Проверяет, что стороны 
положительны, и выбрасывает `ArgumentException` в случае невалидных данных.

- `public override IEnumerable<object> GetEqualityComponents()`: 
Метод, реализованный из базового класса `ValueObject`, возвращает компоненты объекта, 
используемые для сравнения на равенство.

#### Примечание

Класс `Sides` предназначен для представления сторон. Он обеспечивает проверку 
на валидность входных данных и может быть использован вместе с классом `Circle` для создания 
объектов, представляющих круг.

# Common

## ValueObject
