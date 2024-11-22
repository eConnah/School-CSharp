using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int tTerm;
        int cTerm;
        int numOne;
        int numTwo;

        //Store variables
        Console.WriteLine("How many terms would you like: ");
        tTerm = Convert.ToInt32(Console.ReadLine());
        cTerm = 1;
        numOne = 1;
        numTwo = 1;

        //Loop
        do
        {
            if (cTerm != tTerm + 1){
               Console.WriteLine($"Term {cTerm} = {numOne}");
                (numOne, numTwo) = (numOne + numTwo, numOne);
            } else {
               break; 
            }
            cTerm++;
        } while (true);
    }
}