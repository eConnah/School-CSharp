internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int age;

        //Set variables
        Console.WriteLine("Please input someones age: ");
        age = Convert.ToInt32(Console.ReadLine());

        //Calculate
        switch (age)
        {
            case <= 12:
                Console.WriteLine("They would be classified as a child.");
                break;
            case <= 19:
                Console.WriteLine("They would be classified as a tennager.");
                break;
            case <= 64:
                Console.WriteLine("They would be classified as a adult.");
                break;
            default:
                Console.WriteLine("They would be classified as a senior.");
                break;
        }
    }
}