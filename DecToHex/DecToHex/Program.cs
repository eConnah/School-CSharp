internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int userInput;
        string hexNumber;

        //Set variables
        Console.Write("Please input the number you would like to convert to hex: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        //Convert
        hexNumber = Convert.ToString(userInput, 16).ToUpper();

        //Output
        Console.WriteLine($"The hex number is: {hexNumber}");
    }
}