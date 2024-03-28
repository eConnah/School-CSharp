internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initialise variables
        int[] leavingP;
        int[] joiningP;
        int passengers = 0;
        int maxPassengers = 0;

        //Set variables
        leavingP = GetInts("Enter number of passengers leaving: ");
        joiningP = GetInts("Enter number of passengers joining: ");

        //Calculate number of passengers
        for (int i = 0; i < leavingP.Length; i++)
        {
            passengers -= leavingP[i];
            passengers += joiningP[i];
            if (passengers > maxPassengers)
            {
                maxPassengers = passengers;   
            }
        }

        //Output
        Console.WriteLine($"Maximum number of passengers at once: {maxPassengers}");
    }

    private static int[] GetInts(string prompt)
    {
        Console.Clear();
        while (true)
        {
            Console.Write(prompt);
            return Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        }
    }
}