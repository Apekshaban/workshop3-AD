using System;

public class NullOperations
{
    public void PerformNullChecks()
    {
        string username = null;

        // Ternary operator check
        Console.WriteLine(username == null ? "Username is not available" : username);

        // Null-Coalescing operator
        Console.WriteLine(username ?? "Username is not available (??)");

        // Null-Coalescing Assignment operator
        username ??= "DefaultUser";
        Console.WriteLine("Updated username: " + username);
    }
}
