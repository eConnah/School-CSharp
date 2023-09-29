internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        decimal num;

        //Set variables
        Console.WriteLine("Please enter your number: ");
        num = Convert.ToDecimal(Console.ReadLine());

        //Calculate
        if (num % 2 == 0){
            Console.WriteLine("Your number is even.");
        } else {
            Console.WriteLine("Your number is odd.");
        }
    }
}