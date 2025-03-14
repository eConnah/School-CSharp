internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Please enter your ISBN number: ");
        string isbn = Console.ReadLine();
        int alternate = 0;
        int total = 0;
        int checkThingy;
        foreach (char digit in isbn)
        {
            if (alternate == 0)
            {
                total += int.Parse(digit.ToString()) * 1;
                alternate++;
            }
            else
            {
                total += int.Parse(digit.ToString()) * 3;
                alternate--;
            }
        }
        total -= int.Parse(isbn[^1].ToString());
        checkThingy = 10 - total % 10;
        if (checkThingy == 10)
        {
            checkThingy = 0;   
        }
        if (checkThingy > int.Parse(isbn[^1].ToString()) || isbn.Length != 13)
        {
            Console.WriteLine("This is not a valid ISBN");
        }
        else
        {
            Console.WriteLine("This is a valid ISBN");
        }
    }
}