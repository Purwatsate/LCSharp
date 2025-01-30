

// readonly struct - immutable
using System;

readonly struct ReadOnlyPoint(int x, int y)
{
    public int X { get; init; } = x;
    public int Y { get; init; } = y;

    public void Display() => Console.WriteLine($"ReadOnlyPoint({X}, {Y})");

    public readonly double Sum()  // ✅ `readonly` ensures no modification
    {
        return X + Y;
    }
}