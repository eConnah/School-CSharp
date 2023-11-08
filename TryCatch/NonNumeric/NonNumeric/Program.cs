internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        float numerator;
        float denominator;

        //Set variables
        Console.Write("Please enter your numerator: ");
        while (!float.TryParse(Console.ReadLine(), out numerator))
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
        Console.Write("Please enter your denominator: ");
        while (!float.TryParse(Console.ReadLine(), out denominator))
        {
            Console.WriteLine("Invalid input. Please try again.");
        }

        //Calculate
        Console.WriteLine($"{numerator} / {denominator} = {numerator / denominator}");
    }
}