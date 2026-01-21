
using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Hello();

        HelloName("Anandu");

        HelloNameLocation("Atif", "Vadakara");

    }
    private static void Hello()
    {
        Console.WriteLine("Hello  Sahaf");
    }

    private static void HelloName(string name)
    {
        Console.WriteLine($"Hello {name}");
    }

    private static void HelloNameLocation(string name, string location)
    {
        Console.WriteLine($"Hello {name}, located at {location}");
    }
}
