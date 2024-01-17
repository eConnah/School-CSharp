internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and intialise variables
        string binaryInput;
        List<char> output = new();

        //Set variables
        Console.Write("Please enter your binary input: ");
        binaryInput = Console.ReadLine()?.Trim() ?? string.Empty;
        for (int i = 0; i < binaryInput.Length; i += 4)
        {
            int substringLength = Math.Min(4, binaryInput.Length - i);
            output.Add(ToHex(binaryInput.Substring(i, substringLength)));
        }
    }

    private static char ToHex(string nibble)
    {

        return;
    }
}