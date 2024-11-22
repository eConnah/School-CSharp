internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        bool validNumber = false;
        string number = string.Empty;
        while (!validNumber)
        {
            Console.Write("Insert your 6-digit number: ");
            number = Console.ReadLine();
            validNumber = true;
            foreach (char item in number)
            {
                if (!int.TryParse(item.ToString(), out _))
                {
                    validNumber = false;
                    break;
                }
            }
            if (!validNumber || number.Length != 6)
            {
                Console.Clear();
                Console.WriteLine("You input an invalid number, try again.");
                validNumber = false;
            }
        }
        string firstHalf = number[..3];
        string secondHalf = number.Substring(3, 3);
        int firstHalfValue = 0;
        int secondHalfValue = 0;
        for (int i = 0; i < 3; i++)
        {
            firstHalfValue += firstHalf[i];
            secondHalfValue += secondHalf[i];
        }
        if (firstHalfValue == secondHalfValue)
        {
            Console.WriteLine("This string is balanced.");
        }
        else
        {
            Console.WriteLine("This string is not balanced.");
        }
    }
}