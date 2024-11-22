internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Please enter your national insurance number: ");
        string input = Console.ReadLine();
        if (IsValid(input))
        {
            Console.WriteLine("Valid");   
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }

    private static bool IsValid(string input)
    {
        if (input.Length != 9)
        {
            return false;   
        }
        for (int i = 0; i < input.Length; i++)
        {
            if (i == 0 || i == 1 || i == 8)
            {
                if (Convert.ToInt32(input[i]) <= 57)
                {
                    return false;
                }   
            }
            else if (Convert.ToInt32(input[i]) >= 65)
            {
                return false;
            }
        }
        return true;
    }
}