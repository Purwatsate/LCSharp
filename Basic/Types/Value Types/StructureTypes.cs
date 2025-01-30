
using System;

/*
 Value Type: Stored on the stack (except when inside a reference type).

 Lightweight: Less memory overhead compared to classes.

 No Inheritance: Cannot inherit from or be inherited by other types.

 Can Implement Interfaces: Structs can implement interfaces but not inherit from other structs or classes.

 Implicit Parameterless Constructor: Cannot define an explicit parameterless constructor; C# initializes fields automatically.

 Readonly Structs: Prevents modification of struct instances after initialization.

 Ref Structs: Restricts storage of structs to the stack for performance reasons.
 
 Value Parsing: When passing structs to methods, they are passed by value, meaning a copy is made.
*/

// simple struct
struct Point(int x, int y)
{
    public int X = x;
    public int Y = y;

    public readonly void Display() => Console.WriteLine($"Point({X}, {Y})");
}


// readonly struct
readonly struct ReadOnlyPoint(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;

    public void Display() => Console.WriteLine($"ReadOnlyPoint({X}, {Y})");
}

class StructureTypes
{
    public static void MainExample()
    {
        Point point = new(10, 20);
        ParseStructure(point);
        point.Display();

        //-------------
        ReadOnlyPoint readOnlyPoint = new(30, 40);
        ParseReadOnlyStructure(readOnlyPoint);
    }

    private static void ParseReadOnlyStructure(ReadOnlyPoint readOnlyPoint)
    {
        //readOnlyPoint.X = 100; // Error: Cannot modify readonly struct member
        // readOnlyPoint.Y = 200; // Error: Cannot modify readonly struct member
        readOnlyPoint.Display();
    }

    static void ParseStructure(Point point)
    {
        point.X = 100; // Error: Cannot modify readonly struct member
        point.Y = 200; // Error: Cannot modify readonly struct member
    }
}
