namespace ConsoleApp;

partial class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("before");
        HelloFrom("Generated Code");
        Console.WriteLine("after");
    }

    static partial void HelloFrom(string name);
}