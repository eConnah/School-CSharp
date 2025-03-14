using FarmOOP;

internal class Program
{
    private static void Main(string[] args)
    {
        Crop tiger = new("Tiger");
        Console.WriteLine(tiger.GetReport());
    }
}