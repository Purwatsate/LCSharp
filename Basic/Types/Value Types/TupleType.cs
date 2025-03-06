using System;
using System.Collections.Generic;
using System.Linq;

// C# Program demonstrating ref structs and tuple types
class Program12
{
    static void Main()
    {
        // ======== TUPLE TYPES DEMO ========

        // 1. Declaring and using a tuple
        (string Name, int Age) person = ("Alice", 25);
        Console.WriteLine($"{person.Name} is {person.Age} years old.");

        // 2. Returning tuples from a method
        var returnedPerson = GetPerson();
        Console.WriteLine($"Returned: {returnedPerson.Name}, {returnedPerson.Age}");

        // 3. Deconstructing a tuple
        (string name, int age) = GetPerson();
        Console.WriteLine($"Deconstructed: {name}, {age}");

        // 4. Tuple in LINQ query
        List<(string Name, int Score)> students =
        [
            ("Alice", 95),
            ("Bob", 80),
            ("Charlie", 85)
        ];

        var topStudents = students.Where(s => s.Score > 85);
        foreach (var (studentName, score) in topStudents)
        {
            Console.WriteLine($"{studentName} scored {score}");
        }

        // ======== REF STRUCT DEMO ========

        // Creating a ref struct instance
        MyRefStruct1 refStruct = new(100);
        refStruct.Display();
    }

    // Method returning a named tuple
    static (string Name, int Age) GetPerson()
    {
        return ("Charlie", 40);
    }
}

// REF STRUCT EXAMPLE
ref struct MyRefStruct1(int value)
{
    public int Value = value;

    public readonly void Display()
    {
        Console.WriteLine($"Ref Struct Value: {Value}");
    }
}
