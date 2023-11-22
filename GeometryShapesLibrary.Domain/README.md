# Domain

- [Shapes](#shapes)
	- [Shape](#shape)
	- [Circle](#circle)
	- [Triangle](#triangle)
	- [ValueObjects](#valueobjects)
		- [Radius](#radius)
		- [Sides](#sides)
- [Common](#common)
	- [ValueObject](#valueobject)

# Shapes

## Shape

`Shape` - это базовый абстрактный класс, представляющий фигуры.

#### Свойства

- ` public double Area { get; private set; }`: Свойство, представляющее площадь 
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

- `public Radius Radius { get; private set; }`: Свойство, радиус круга.


#### Методы

- `public static Circle Create(double radius))`: 
Статический метод для создания объекта `Circle` на основе заданного 
радиуса. Возвращает новый экземпляр `Circle`.

- `private static double GetArea(Radius radius)`: 
Статический частный метод, который вычисляет площадь круга на основе 
заданного радиуса.

## Triangle

`Triangel` - это класс, представляющий треугольник и наследуется от базового класса [`Shape`](#shape).

#### Свойства

- `public Sides Sides { get; private set; }`: Свойство, представляющее стороны треугольник.
- `public bool IsRegularTriangle { get; private set; }`: Свойство, представляющее является ли треугольник прямоугольным.

#### Методы

- `public static Triangle Create(double sideA, double sideB, double sideC)`: 
Статический метод для создания экземпляра класса `Triangel`. Проверяет, что стороны 
положительны, и выбрасывает исключение в случае невалидных данных.

- `private static double GetArea(Sides sides)`: 
Статический частный метод, который вычисляет площадь треугольника по 
трем сторонам.

- `private bool IsRightTriangle()`: 
Метод, проверяющий является ли треугольник прямоугольным и возвращает `false`
если треугольник неправильный иначе `true`. На основе теоремы Пифагора.

- `private static bool IsValidTriangle(double sideA, double sideB, double sideC)`: 
Метод, проверяющий можно ли создать треугольник с заданными сторонами 
на основе неравенства треугольника. `true` eсли можно создать треугольник 
с заданными сторонами, и `false`, если невозможно.

## ValueObjects

## Radius

`Radius` - это класс, представляющий радиус, наследуется от базового абстрактного класса [`ValueObject`](#valueobject).

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
на валидность входных данных и может быть использован вместе с классом [`Circle`](#circle) для создания 
объектов, представляющих круг.

## Sides

`Sides` - это класс, стороны фигуры, который наследуется от базового класса [`ValueObject`](#valueobject).

#### Свойства

- `public double SideA { get; private set; }`: Свойство, представляющее сторону A.
- `public double SideB { get; private set; }`: Свойство, представляющее сторону B.
- `public double SideC { get; private set; }`: Свойство, представляющее сторону C.

#### Методы

- `public static Sides Create(double sideA, double sideB, double sideC)`: 
Статический метод для создания экземпляра класса `Triangle`. Проверяет, что стороны 
положительны, и выбрасывает `ArgumentException` в случае невалидных данных.

- `public override IEnumerable<object> GetEqualityComponents()`: 
Метод, реализованный из базового класса [`ValueObject`](#valueobject), возвращает компоненты объекта, 
используемые для сравнения на равенство.

#### Примечание

Класс `Sides` предназначен для представления сторон. Он обеспечивает проверку 
на валидность входных данных и может быть использован вместе с классом [`Circle`](#circle) для создания 
объектов, представляющих круг.

# Common

## ValueObject

`ValueObject` - это абстрактный базовый класс, предоставляющий 
общие методы и функциональность для объектов-значений ([value objects](#valueobjects)).

#### Методы

- `public abstract IEnumerable<object> GetEqualityComponents()`: 
Абстрактный метод, который должен быть реализован в производных классах. 
Возвращает компоненты объекта, используемые для сравнения на равенство.

- `public override bool Equals(object? obj)`: 
Переопределенный метод `Equals`, который сравнивает объект-значение 
с другим объектом и возвращает `true`, если они равны.

- `public static bool operator ==(ValueObject left, ValueObject right)`: 
Перегруженный оператор равенства, который позволяет сравнивать объекты-значения 
с использованием оператора `==`.

- `public static bool operator !=(ValueObject left, ValueObject right)`: 
Перегруженный оператор неравенства, который позволяет сравнивать 
объекты-значения с использованием оператора `!=`.

- `public override int GetHashCode()`: 
Переопределенный метод `GetHashCode`, который возвращает хэш-код 
объекта-значения.

- `public bool Equals(ValueObject? other)`: 
Метод для сравнения объектов-значений на равенство.

#### Примечание

Класс `ValueObject` позволяет создавать объекты-значения, которые могут 
быть сравниваемы на равенство и использоваться в коллекциях, 
таких как `HashSet` и `Dictionary`. Он предоставляет удобный способ 
реализации объектов-значений в C#.
