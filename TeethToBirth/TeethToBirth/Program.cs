internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and intialise variables
        int topTeeth;
        int bottomTeeth;
        int age = 0;
        int difference;

        //Set variables
        topTeeth = GetInt("Please enter the number of top teeth: ");
        bottomTeeth = GetInt("Please enter the number of bottom teeth: ");

        //Calculate age
        do
        {
            difference = topTeeth - bottomTeeth;
            if (difference < 0)
            {
                difference *= -1;
            }
            if (age % 2 == 0)
            {
                topTeeth = difference + 1;   
            }
            else
            {
                bottomTeeth = difference + 1;
            }
            age++;
        } while (difference != 0);

        Console.WriteLine($"The catipillar will pupate at {age - 1} days old.");
    }

    private static int GetInt(string prompt)
    {
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}