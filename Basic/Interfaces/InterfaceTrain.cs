using System;

public interface IShape
{
    double GetArea();
    double GetPerimeter();
}

public abstract class Shape : IShape
{
    public abstract double GetArea();
    public abstract double GetPerimeter();
}

public struct Circle : IShape
{
    public double Radius { get; set; }
    public double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    public double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea()
    {
        return Width * Height;
    }

    public double GetPerimeter()
    {
        return 2 * (Width + Height);
    }
}


interface ITrain
{

    string Name { get; set; }
    void Start();
    void Stop();

    void LogWarning(string warning) => Console.WriteLine($"Warning: {warning}");
}

class BClass : AClass
{
    void show()
    {
        Start();
        Stop();
    }
}

class AClass : ITrain
{
    public string Name { get; set; }
    public void Start()
    {
        Console.WriteLine("Train started");
    }

    public void Stop()
    {
        Console.WriteLine("Train stopped");
    }
}

class CClass
{
    public static void TestMethod()
    {
        ITrain train = new BClass();
        train.Start();
        train.Stop();
        train.Name = "Train 1";
        train.LogWarning($"This is a warning {train.Name}");
        train.LogWarning("This is a warning");
    }
}