using static System.Console;
/**
    an alias for the .NET System.Char structure type
*/

class Character
{
    static void ExampleOfCharacter()
    {
        // Initializing an array of characters with different
        //  representations of the character 'j'
        var chars = new[]
        {
            'j',         // character literal
            '\u006A',    // Unicode escape sequence
            '\x006A',    // Hexadecimal escape sequence
            (char)106,   // Casting from integer (ASCII value of 'j')
        };
        WriteLine(string.Join(" ", chars));  // output: j j j j

        //The char type is implicitly convertible to the following integral types:
        //  ushort, int, uint, long, and ulong
        char a = 'a';
        int b = a;
    }
}
