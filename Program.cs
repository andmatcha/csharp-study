namespace HelloWorld;

class Hello {
    static string greeting = "Hello, world!";

    static void Main()
    {
        Console.WriteLine(greeting);
        Console.Write("Enter your name >");
        string? name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}
