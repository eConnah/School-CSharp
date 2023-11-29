internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise variables
        List<int> maxTemperatures = new();
        List<int> minTemperatures = new();
        int maxTemp;
        int minTemp;
        int aboveAverage = 0;
        int belowZero = 0;

        //Set variables
        while (true)
        {
            Console.Clear();
            maxTemp = inputTemperature(true);
            Console.Clear();
            minTemp = inputTemperature(false);

            if (maxTemp > 999)
            {
                break;
            }
            else if (minTemp > maxTemp)
            {
                Console.WriteLine("Minimum temperature cannot be greater than maximum temperature.");
                Console.ReadKey();
                continue;
            }

            maxTemperatures.Add(maxTemp);
            minTemperatures.Add(minTemp);
        }

        //Calculate max and min temperatures
        foreach (int item in maxTemperatures)
        {
            if (item > maxTemperatures.Average())
            {
                aboveAverage++;
            }
        }
        foreach (int item in minTemperatures)
        {
            if (item < 0)
            {
                belowZero++;
            }
        }

        //Output results
        Console.WriteLine($"There are {aboveAverage} temperatures above average.");
        Console.WriteLine($"There are {belowZero} temperatures below zero.");
    }

    private static int inputTemperature(bool max)
    {
        do
        {
            Console.Write("Please enter the temperature: ");
            if (!int.TryParse(Console.ReadLine(), out int temp))
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid input.");
            }
            else
            {
                return temp;
            }
        } while (true);
    }
}