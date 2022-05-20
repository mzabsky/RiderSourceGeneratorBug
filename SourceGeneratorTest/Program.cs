namespace SourceGeneratorTest;

public class Program
{
    public static void Main()
    {
        var a = GeneratedClass.NotFound;
        var b = GeneratedClass.SourceGeneratorTest;
        
        Console.WriteLine($"{a} {b}");
    }
}
