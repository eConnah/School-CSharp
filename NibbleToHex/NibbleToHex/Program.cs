internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and intialise variables
        string binaryInput;
        List<char> output = new();

        //Set variables
        Console.Clear();
        Console.Write("Please enter your binary input: ");
        binaryInput = Console.ReadLine()?.Trim() ?? string.Empty;
        for (int i = 0; i < binaryInput.Length; i += 4)
        {
            int substringLength = Math.Min(4, binaryInput.Length - i);
            output.Add(ToHex(binaryInput.Substring(i, substringLength)));
        }

        //Output
        Console.Write("The hex value is: ");
        Console.WriteLine(string.Join("", output));
    }

    private static char ToHex(string nibble)
    {
        //Declare and initialise variables
        int decValue = 0;
        int power = 0;

        //Convert to decimal
        for (int i = nibble.Length - 1; i >= 0; i--)
        {
            if (nibble[i] == '1')
            {
                decValue += (int)Math.Pow(2, power);
            }
            power++;
        }

        //Return hex
        return decValue switch
        {
            15 => 'F',
            14 => 'E',
            13 => 'D',
            12 => 'C',
            11 => 'B',
            10 => 'A',
            _ => (char)(decValue + '0'),
        };
    }
}