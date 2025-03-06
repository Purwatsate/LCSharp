
using System;

class StructureTypes
{
    public static void MainExample()
    {
        //-------------simple struct----------------
        Point point = new(10, 20);
        ParseStructure(point);
        point.Display();

        //-------------readonly struct----------------
        ReadOnlyPoint readOnlyPoint = new() { X = 10, Y = 20 };  //because of init
        ParseReadOnlyStructure(readOnlyPoint);

        // Nondestructive mutation
        ReadOnlyPoint readOnlyPoint2 = readOnlyPoint with { X = 100, Y = 200 };
    }

    private static void ParseReadOnlyStructure(ReadOnlyPoint readOnlyPoint)
    {
        // readOnlyPoint.X = 100; // Error: Cannot modify readonly struct member
        // readOnlyPoint.Y = 200; // Error: Cannot modify readonly struct member
        readOnlyPoint.Display();
    }

    static void ParseStructure(Point point)
    {
        point.X = 100; // Error: Cannot modify readonly struct member
        point.Y = 200; // Error: Cannot modify readonly struct member
    }
}
