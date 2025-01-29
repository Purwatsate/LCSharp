using System;

namespace IntegralNumericType
{
    // Signed types support <negative values>, but their positive range is smaller.

    // Unsigned types don’t support negatives, but their positive range is <larger>.

    class ExampleOfNumric
    {
        static void SignedIntegerTypes()
        {
            sbyte a = 1;   // -128 <-> 127 (8-bit)  
            short b = 1;   // -32,768 <-> 32,767 (16-bit)  
            int c = 1;     // -2,147,483,648 <-> 2,147,483,647 (32-bit)  
            long d = 1L;   // -9,223,372,036,854,775,808 <-> 9,223,372,036,854,775,807 (64-bit)  
            nint e = 1;    // Depends on platform (Signed 32-bit or 64-bit)  

            Console.WriteLine($"sbyte: {a}");
            Console.WriteLine($"short: {b}");
            Console.WriteLine($"int: {c}");
            Console.WriteLine($"long: {d}");
            Console.WriteLine($"nint: {e}");
            Console.WriteLine("------------------------");
        }

        static void UnsignedIntegerTypes()
        {
            byte f = 1;             // 0 <-> 255 (8-bit)  
            ushort g = 1;           // 0 <-> 65,535 (16-bit)  
            uint h = 1000000000U;   // 0 <-> 4,294,967,295 (32-bit)  
            ulong i = 1UL;          // 0 <-> 18,446,744,073,709,551,615 (64-bit)  
            nuint j = 1;            // Depends on platform (Unsigned 32-bit or 64-bit)  

            Console.WriteLine($"byte: {f}");
            Console.WriteLine($"ushort: {g}");
            Console.WriteLine($"uint: {h}");
            Console.WriteLine($"ulong: {i}");
            Console.WriteLine($"nuint: {j}");
            Console.WriteLine("------------------------");
        }
    }

}

