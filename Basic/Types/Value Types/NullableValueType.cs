

using System;

class Program13
{
    static void Main()
    {
        // Declaring nullable value types
        int? nullableInt = null;
        double? nullableDouble = 3.14;
        
        // like this we can declare nullable value types
        // bool? nullableBool = null; 
        DateTime? nullableDate = DateTime.Now;

        // Checking if a nullable type has a value <----------------------
        if (nullableInt.HasValue)
        {
            Console.WriteLine($"Nullable Integer Value: {nullableInt.Value}");
        }
        else
        {
            Console.WriteLine("nullableInt is null");
        }

        // Using null-coalescing operator
        int defaultInt = nullableInt ?? 100; // If null, assign 100
        Console.WriteLine($"Default Integer: {defaultInt}");

        // Using null-conditional operator
        Console.WriteLine($"Nullable DateTime: {nullableDate?.ToString("yyyy-MM-dd") ?? "No date"}");

        // Demonstrating boxing and unboxing
        object boxedValue = nullableDouble; // Boxed if has value, otherwise null
        double? unboxedValue = boxedValue as double?; // Safe unboxing

        Console.WriteLine($"Boxed Value: {boxedValue}");
        Console.WriteLine($"Unboxed Value: {unboxedValue}");

        // Nullable type in a method
        DisplayValue(nullableInt);
        DisplayValue(42);
    }

    static void DisplayValue(int? number)
    {
        Console.WriteLine($"Received: {number ?? -1}"); // Uses -1 if null
    }
}
