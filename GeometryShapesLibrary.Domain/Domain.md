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

`Shape` - ��� ������� ����������� �����, �������������� ������.

#### ��������

- ` public double Area { get; }`: ��������, �������������� ������� 
�����.

#### ������

- `public override string ToString()`: 
���� ����� ���������� ��������� ������������� ������. 
�� ���������� ��� ������ (��������, "����" ��� "�����������") 
� � �������.

## Circle

`Circle` - ����� ������������ ���� � ����������� �� �������� 
������ [`Shape`](#shape). �� �������� ���������� � ������� ����� 
� ��� �������.

#### ��������

- `public Radius Radius { get; }`: ��������, ������ �����.


#### ������

- `public static Circle Create(double radius))`: 
����������� ����� ��� �������� ������� `Circle` �� ������ ��������� 
�������. ���������� ����� ��������� `Circle`.

- `private static double GetArea(Radius radius)`: 
����������� ������� �����, ������� ��������� ������� ����� �� ������ 
��������� �������.

## Triangle

`Triangel` - ��� �����, �������������� ����������� � ����������� �� �������� ������ `Shape`.

#### ��������

- `public Sides Sides { get; }`: ��������, �������������� ������� �����������.
- `public bool IsRegularTriangle { get; }`: ��������, �������������� �������� �� ����������� ���������� ��� ���.

#### ������

- `public static Triangle Create(double sideA, double sideB, double sideC)`: 
����������� ����� ��� �������� ���������� ������ `Triangel`. ���������, ��� ������� 
������������, � ����������� `ArgumentException` � ������ ���������� ������.

- `private static double GetArea(Sides sides)`: 
����������� ������� �����, ������� ��������� ������� ������������ �� 
���� ��������.

- `private bool IsRightTriangle()`: 
�����, ����������� �������� �� ����������� ���������� � ���������� `false`
���� ����������� ������������ ����� `true`.

# ValueObjects

## Radius

`Radius` - ��� �����, �������������� ������.

#### ��������

- `public double Value { get; private set; }`: ��������, �������������� �������� �������.

#### ������

- `public static Radius Create(double radius)`: 
����������� ����� ��� �������� ���������� ������ `Radius`. ���������, ��� ������ 
������������, � ����������� `ArgumentException` � ������ ���������� ������.

- `public override IEnumerable<object> GetEqualityComponents()`: 
�����, ������������� �� �������� ������ `ValueObject`, ���������� ���������� �������, 
������������ ��� ��������� �� ���������.

#### ����������

����� `Radius` ������������ ��� ������������� �������. �� ������������ �������� 
�� ���������� ������� ������ � ����� ���� ����������� ������ � ������� `Circle` ��� �������� 
��������, �������������� ����.

## Sides

`Sides` - ��� �����, ������� ������.

#### ��������

- `public double SideA { get; private set; }`: ��������, �������������� ������� A.
- `public double SideB { get; private set; }`: ��������, �������������� ������� B.
- `public double SideC { get; private set; }`: ��������, �������������� ������� C.

#### ������

- `public static Sides Create(double sideA, double sideB, double sideC)`: 
����������� ����� ��� �������� ���������� ������ `Triangle`. ���������, ��� ������� 
������������, � ����������� `ArgumentException` � ������ ���������� ������.

- `public override IEnumerable<object> GetEqualityComponents()`: 
�����, ������������� �� �������� ������ `ValueObject`, ���������� ���������� �������, 
������������ ��� ��������� �� ���������.

#### ����������

����� `Sides` ������������ ��� ������������� ������. �� ������������ �������� 
�� ���������� ������� ������ � ����� ���� ����������� ������ � ������� `Circle` ��� �������� 
��������, �������������� ����.

# Common

## ValueObject

`ValueObject` - ��� ����������� ������� �����, ��������������� 
����� ������ � ���������������� ��� ��������-�������� (value objects).

#### ������

- `public abstract IEnumerable<object> GetEqualityComponents()`: 
����������� �����, ������� ������ ���� ���������� � ����������� �������. 
���������� ���������� �������, ������������ ��� ��������� �� ���������.

- `public override bool Equals(object? obj)`: 
���������������� ����� `Equals`, ������� ���������� ������-�������� 
� ������ �������� � ���������� `true`, ���� ��� �����.

- `public static bool operator ==(ValueObject left, ValueObject right)`: 
������������� �������� ���������, ������� ��������� ���������� �������-�������� 
� �������������� ��������� `==`.

- `public static bool operator !=(ValueObject left, ValueObject right)`: 
������������� �������� �����������, ������� ��������� ���������� 
�������-�������� � �������������� ��������� `!=`.

- `public override int GetHashCode()`: 
���������������� ����� `GetHashCode`, ������� ���������� ���-��� 
�������-��������.

- `public bool Equals(ValueObject? other)`: 
����� ��� ��������� ��������-�������� �� ���������.

#### ����������

����� `ValueObject` ��������� ��������� �������-��������, ������� ����� 
���� ����������� �� ��������� � �������������� � ����������, 
����� ��� `HashSet` � `Dictionary`. �� ������������� ������� ������ 
���������� ��������-�������� � C#.
