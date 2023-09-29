internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int age;
        double price;
        decimal time;
        
        //Set variables
        Console.WriteLine("Please enter your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the time of your screening in 24hr 00.00 format: ");
        time = Convert.ToDecimal(Console.ReadLine());
        price = 15;

        //Calculate
        switch (age)
        {
            case <=12:
                price = price * 0.9;
                break;
            case >=65:
                price = price * 0.9;
                break;
            default:
                break;
        }
        switch (time)
        {
            case < 17:
                price = price - 2;
                break;
            default:
                break;
        }

        //Declare result
        Console.WriteLine($"The price is £{price}");
    }
}