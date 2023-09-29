internal class Program
{
    private static void Main(string[] args)
    {
        //Declare the variables
        int studentsScore;
        int studentsAttendance;
        string result;
        
        //Set the variables
        studentsScore = GetInput("Enter the students score: ");
        studentsAttendance = GetInput("Enter the students attendance: ");

        //Calculate student grade
        if (studentsAttendance <= 90)
        {
            Console.WriteLine("This student failed.");
        }
        else
        {
            result = studentsScore switch
            {
                > 90 => "achieved a Grade A.",
                > 80 and <= 90 => "achieved a Grade B.",
                > 70 and <= 80 => "achieved a Grade C.",
                _ => "failed."
            };
            Console.WriteLine($"This student {result}");
        }
    }
    static int GetInput(string prompt)
    {
        //Declare the variables
        string input;
        int output;

        //Set the variable
        input = string.Empty;

        //Loop until valid input
        do
        {
            Console.WriteLine(prompt);
            input = Console.ReadLine()?.Trim() ?? string.Empty;
            if (int.TryParse(input, out output))
            {
                return output;
            }
            else
            {
                Console.WriteLine("Input is not valid.");
            }
        } while (true);
    }
}