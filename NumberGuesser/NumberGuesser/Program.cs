internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        Random randomN;
        int randomNum;
        int guess;

        //Set variables
        randomN = new Random();
        randomNum = randomN.Next(1, 101);
        
        //Check
        do
        {
            Console.WriteLine("Please guess the random number from 1-100: ");
            guess = Convert.ToInt32(Console.ReadLine());
            if (guess > randomNum){
                Console.WriteLine("Go a bit lower.");
            } else if (guess < randomNum){
                Console.WriteLine("Go a bit higher.");
            }
        } while (guess != randomNum);

        //Result
        Console.WriteLine("Congratulations you're correct!");
    }
}