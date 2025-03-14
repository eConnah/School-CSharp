internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        while (true)
        {
            Console.Write("Please enter your text to cipher: ");
            string userInput = Console.ReadLine();
            if (HasInt(userInput))
            {
                Console.Clear();
                Console.WriteLine("Only enter plaintext.");
            }
            else
            {
                break;
            }
        }
        
    }

    private static bool HasInt(string userInput)
    {
        foreach (char item in userInput)
        {
            string temp = item.ToString();
            if (int.TryParse(temp, out int _))
            {
                return true;
            }
        }
        return false;
    }
}