internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int inputNum;
        int divider;
        int maxDivider;

        //Set variables
        Console.WriteLine("Enter your number: ");
        inputNum = Convert.ToInt32(Console.ReadLine());
        divider = 2;
        maxDivider = Convert.ToInt32(Math.Sqrt(inputNum));

        //Handle input
        if (inputNum < 3)
        {
            Console.WriteLine("Your number is not prime.");
            return;
        }

        //Loop
        do
        {
            if (inputNum % divider != 0)
            {
                divider++;
            } else {
                Console.WriteLine("Your number is not prime.");
                return;
            }
        } while (divider < maxDivider);

        //Declare Result
        Console.WriteLine("Your number is prime.");
    }
}