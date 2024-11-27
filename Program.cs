using ExodusEngine;

public class Program
{
    static void Main(string[] args)
    {
        var engine = new Engine();
        engine.Run();
    
        Console.WriteLine("Engine closed");
    }
}