using System;

class FloatingPointNumericTypes
{
    static void FloatingPointTypes()
    {
        float a = 1.23F;    // ±1.5 x 10−45 to ±3.4 x 1038 (~6-9 digits, 4 bytes)
        double b = 1.23;    // ±5.0 × 10−324 to ±1.7 × 10308 (~15-17 digits, 8 bytes)
        decimal c = 1.23M;  // ±1.0 x 10-28 to ±7.9228 x 1028 (28-29 digits, 16 bytes)

        Console.WriteLine($"float: {a}");
        Console.WriteLine($"double: {b}");
        Console.WriteLine($"decimal: {c}");
        Console.WriteLine("------------------------");
    }

}