

using System;
using System.Collections.Generic;
using System.Linq;

class User
{
    public string UserId { get; set; }
    public string Role { get; set; }
    public string Name { get; set; }
}

class ProgramA
{
    static void Main()
    {
        // Sample user list
        List<User> assignedUserList =
        [
            new User { UserId = "A", Role = "admin", Name = "Alice" },
            new User { UserId = "B", Role = "user", Name = "Bob" },
            new User { UserId = "C", Role = "admin", Name = "Charlie" },
            new User { UserId = "D", Role = "user", Name = "David" }
        ];

        // Using FirstOrDefault() - Get first admin user
        var firstAdmin = assignedUserList.FirstOrDefault(u => u.UserId == "A" && u.Role == "admin");
        Console.WriteLine("First Admin: " + (firstAdmin != null ? firstAdmin.Name : "None"));

        // Using Where() - Get all admins
        var adminUsers = assignedUserList.Where(u => u.Role == "admin").ToList();
        Console.WriteLine("Admin Users: " + string.Join(", ", adminUsers.Select(u => u.Name)));

        // Using Select() - Get list of user IDs
        var userIds = assignedUserList.Select(u => u.UserId).ToList();
        Console.WriteLine("User IDs: " + string.Join(", ", userIds));

        // Combining Where() and Select() - Get user IDs of all admins
        var adminUserIds = assignedUserList
            .Where(u => u.Role == "admin")
            .Select(u => u.UserId)
            .ToList();
        Console.WriteLine("Admin User IDs: " + string.Join(", ", adminUserIds));
    }
}
