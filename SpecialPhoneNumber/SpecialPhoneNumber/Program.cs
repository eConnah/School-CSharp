internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        bool validInput = false;
        string phoneNumber = string.Empty;
        int sum = 0;
        int charValue = 0;
        while (!validInput)
        {
            Console.Write("Please enter your phone number: ");
            phoneNumber = Console.ReadLine();
            validInput = true;
            foreach (char item in phoneNumber)
            {
                if(int.TryParse(item.ToString(), out charValue))
                {
                    sum += charValue;
                }
                else
                {
                    validInput = false;
                    sum = 0;
                    charValue = 0;
                    break;
                }
            }
            if (validInput && phoneNumber.Length == 11 && phoneNumber.StartsWith("07"))
            {
                validInput = true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("This is not a valid phone number, try again.");
            }
        }
        if (sum % 5 == 0)
        {
            Console.WriteLine("This phone number is special.");
        }
        else
        {
            Console.WriteLine("This phone number is not special.");
        }
    }
}