# example-aspnet-learning-c-sharp-201
https://code.tutsplus.com/courses/learning-c-201

## 2.1 ##

- [Code Coverage - JetBrains Resharper] (https://www.jetbrains.com/resharper/download/)
- [Test Suite - NCrunch] (http://www.ncrunch.net/)

## 2.2 Plus & Minus Operator (Lesson 1) ##
- Overload operator is in *Point.cs* and the test is in *pointTest.cs*
- + is a binary operator requiring 2 values
- Example in this is 
	- point + point
	- point - point
	- point + int
	- point - int

```csharp
public static Point operator +(Point p1, Point p2)
{
    return new Point(p1.X + p2.X, p1.Y + p2.Y);
}
```

## 2.3 Equality & Inequiality (Lesson 2) ##
- Overload operator is in *Point.cs* and the test is in *pointTest.cs*
- When it comes with ewuality and inequality you need to overload both, you can't just do one.
- Example in this is
	- point == point2
	- point != point2
	- point1.Equals(point2)
	- point1.GetHashCode()
- It's best practice to also overload `Equal` and `GetHasCode` when overloading equalities and inequialities.  It's optional, but best practice.
- Code can also be seen on MSDN https://msdn.microsoft.com/en-us/library/system.object.gethashcode(v=vs.110).aspx

```csharp
public static bool operator ==(Point p1, Point p2)
{
    return p1.X == p2.X && p1.Y == p2.Y;
}

public bool Equals(Point point)
{
    return this == point;
}

public override int GetHashCode()
{
    return X ^ Y;
}
```

## 2.4 Conversion (Lesson 3) ##
- 2 types of conversion: explicit and implicit
- Microsoft wants implicit conversions to be silent, it should not throw an exception.  You do not use a try..catch.  You'll use `cast` instead since `cast` can fail while inplicit can't fail.
- Best practice is to use explicit when a conversion can fail and fail catastrophically.
```csharp
// every byte can be an integer, but an integer can't be converted to a byte.

// implicit
byte foo = 5;
int bar = foo; // assignment will work

// explicit
int foo = 5;
// byte bar = foo; // assignment will not work
byte bar = (byte) foo; // must be casted

```csharp
public static implicit operator int(Digit digit)
{
    return digit.Value;
}

public static explicit operator Digit(int value)
{
    return new Digit((byte)value);
}
```

## 2.5 Indexer (Lesson 4) ###
- You can not overload conditional operator.
- You can not overload square bracket.  You use this when defining attributes, defining array, etc..
- This is useful, allows you to do this, grab a person from a collection.

```csharp
[TestMethod]
        public void SquareBracket()
        {
            var strings = new[]
            {
                "String 1",
                "String 2",
                "String 3"
            };

            Assert.AreEqual(strings[0], "String 1");
        }

        [TestMethod]
        public void ListSample()
        {
            var sample = new List<string>
            {
                "First String",
                "Second String",
                "Third String"
            };

            Assert.AreEqual(sample[0], "First String");
        }

        [TestMethod]
        public void DictionarySample()
        {
            var sample = new Dictionary<string, int>
            {
                {"First String", 5},
                {"Second String", 10},
                {"Third String", 15}
            };

            Assert.AreEqual(sample["First String"], 5);
        }

        [TestMethod]
        public void IndexerTest()
        {
            var person = new Person
            {
                FirstName = "John",
                LastName = "Doe"
            };

            var people = new PersonCollection();

            people.Add(person);

            var foo = people[0];

            Assert.AreSame(person, foo);

            var bar = people["John", "Doe"];

            Assert.AreEqual(bar.Count(), 1);
        }
```

## 2.6 Generics (Lesson 5) ##
- You'll use `T`
- Allows you to use `Int` or `Int32`

```csharp
[TestMethod]
public void Int32Point()
{
    var p1 = new Point<int>(1, 1);

    Assert.AreEqual(p1.X, 1);
    Assert.AreEqual(p1.Y, 1);
}

[TestMethod]
public void FloatPoint()
{
    var p1 = new Point<float>(1.1f, 1.1f);

    Assert.AreEqual(p1.X, 1.1f);
    Assert.AreEqual(p1.Y, 1.1f);
}
```

## 2.7 Geenerics & The Operator Problem (Lesson 6) ##
- Allows

```csharp
var calculator = new CalculatorInt32();
var p1 = new Point<int>(1, 1);
var p2 = new Point<int>(2, 2);

var p3 = calculator.AddPoints(p1, p2);

Assert.AreEqual(p3.X, 3);
```

## 2.10-2.11 Lync ###

