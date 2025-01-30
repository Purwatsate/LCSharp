
// simple struct
using System;

struct Point(int x, int y)
{
    public int X = x;
    public int Y = y;

    public readonly void Display() => Console.WriteLine($"Point({X}, {Y})");
}