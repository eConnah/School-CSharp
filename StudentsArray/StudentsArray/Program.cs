internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string firstName;
        string lastName;
        string studentName;
        bool studentFound;

        //Student array
        string[] students = {
        "bosch, johnny",
        "bailey, laura",
        "freeman, crispin",
        "blum, steve",
        "riegel, sam",
        "strong, tara",
        "lowenthal, yuri",
        "palencia, brina",
        "mercer, matthew",
        "strait, sonny",
        "marchi, jamie",
        "lee, wendee",
        "clinkenbeard, colleen",
        "ayres, greg",
        "mcdonald, mary elizabeth",
        "sabat, christopher",
        "taylor, veronica",
        "grelle, josh",
        "fukushima, jun",
        "sinterniklaas, michael",
        "orikasa, fumiko",
        "carrero, aimee",
        "mignogna, vic",
        "karbowski, brittney",
        "patton, chris",
        "lyon, caitlin",
        "knight, joey",
        "ruff, michelle",
        "haberkorn, todd",
        "tatum, j. michael",
        "hahn, jess"
        };

        //Set variables
        studentFound = false;
        Console.Write("Please enter the students first name: ");
        firstName = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        Console.Write("Please enter the students last name: ");
        lastName = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        studentName = $"{lastName}, {firstName}";

        //Loop
        for (int i = 0; i < students.Length; i++)
        {
            if (studentName == students[i])
            {
                Console.WriteLine($"Student {studentName} is index {i+1}");
                studentFound = true;
            }
        }
        
        //Output
        if (!studentFound)
        {
            Console.WriteLine("Student was not found in database.");
        }
    }
}