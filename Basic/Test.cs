public record Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

public record Name(string first, string last);
public record Person(string FirstName, string LastName);

public record Employee(string FirstName, string LastName, string EmployeeId)
    : Person(FirstName, LastName);