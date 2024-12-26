using System;

namespace MyNamespace
{

    class Program
    {
        static void Main(string[] args)
        {
            Point a = new()
            {
                X = 10,
                Y = 20
            };
            a.X = 111;
            Console.WriteLine($"a.X = {a.X}, a.Y = {a.Y}");
        }
    }


    class  Testing {
        readonly int a;
    }
}