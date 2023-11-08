using System.Net.Security;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int numerator;
        int denominator;
        bool negetiveException = false;

        //Set variables
        do
        {
            Console.Write("Please enter your numerator: ");
            while (!int.TryParse(Console.ReadLine(), out numerator))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            try
            {
                if (numerator < 0)
                {
                    throw new Exception("Your number cannot be negative.");
                }
                else
                {
                    negetiveException = false;
                }
            }
            catch (Exception ex)
            {
                negetiveException = true;
                Console.WriteLine(ex.Message);
            }
        } while (negetiveException);
        do
        {
            Console.Write("Please enter your denominator: ");
            while (!int.TryParse(Console.ReadLine(), out denominator))
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
            try
            {
                if (denominator < 0)
                {
                    throw new Exception("Your number cannot be negative.");
                }
                else
                {
                    negetiveException = false;
                }
            }
            catch (Exception ex)
            {
                negetiveException = true;
                Console.WriteLine(ex.Message);
            }
        } while (negetiveException);

        //Calculate
        Console.WriteLine($"{numerator} / {denominator} = {numerator / denominator}");
    }
}