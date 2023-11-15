internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int slowPeople = 0;
        int averagePeople = 0;
        int fastPeople = 0;
        int userInput;
        int i = 1;

        //Set variables
        do
        {
            Console.Clear();
            Console.Write($"Please enter time {i}: ");
            userInput = Convert.ToInt32(Console.ReadLine());
            switch (userInput)
            {
                case > 60:
                    slowPeople++;
                    break;
                case > 30:
                    averagePeople++;
                    break;
                case > 0:
                    fastPeople++;
                    break;
                default:
                    break;
            }
            i++;
        } while (userInput != 0);

        //Output
        Console.Clear();
        Console.WriteLine($"Slow people: {slowPeople}");
        Console.WriteLine($"Average people: {averagePeople}");
        Console.WriteLine($"Fast people: {fastPeople}");
    }
}