internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables 
        int interger;

        //Set variables
        Console.Write("Please enter a number: ");
        while (!int.TryParse(Console.ReadLine(), out interger))
        {
            Console.WriteLine("Please enter a valid interger.");
        }

        //Output
        Console.WriteLine("You entered: " + interger);
    }
}