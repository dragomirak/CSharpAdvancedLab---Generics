namespace GenericScale;

public class StartUp
{
    static void Main()
    {
        var scale = new EqualityScale<int>(6, 6);
        var result = scale.AreEqual();
        Console.WriteLine(result);
    }
}