namespace cs_study;

class getInput
{
    static string greeting = "Hello!";

    static void Main()
    {
        Console.WriteLine(greeting);
        Console.Write("Enter something...");
        string? input = Console.ReadLine();

        var testInstance = new cs_study.Write();
        if (input != null && input != "")
        {
            testInstance.writeSomething(input);
        }
        else
        {
            Main();
        }
    }
}
