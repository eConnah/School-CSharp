using System.Net.NetworkInformation;
//Declare variables
string choiceString;
int choiceInt;
do
{
    do
    {
        //Menu
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create a new account");
        Console.WriteLine("2. Deposit money");
        Console.WriteLine("3. Withdraw money");
        Console.WriteLine("4. Check balance");
        Console.WriteLine("5. Exit");

        //Set variables
        choiceString = Console.ReadLine()?.Trim() ?? string.Empty;
    } while (int.TryParse(choiceString, out choiceInt) == false || choiceInt < 1 || choiceInt > 5);

    //Switch
    switch (choice)
    {
        case "1":
        case "2":
        case "3":
        case "4":
        case "5":
        default:
            break;
    }

} while (true);
Banking Connor = new(864, new DateTime(2006, 09, 10), "Connor", 0146);
Connor.DecreaseBalance(954.53);
Console.WriteLine($"Name: {Connor.GetName()}");
Console.WriteLine($"Date of Birth: {Connor.GetBirthDate()}");
Console.WriteLine($"Bank Number: {Connor.GetSortCode()}/{Connor.GetAccountNumber()}");
Console.WriteLine($"Balance: £{Connor.GetBalance()}");

class Banking
{
    private double Balance;
    private DateTime BirthDate;
    private string Name;
    private string SortCode = string.Empty;
    private string AccountNumber = string.Empty;
    private int Pin;

    public Banking(double startingAmount, DateTime birthDate, string name, int pin)
    {
        Balance = startingAmount;
        BirthDate = birthDate;
        Name = name;
        Pin = pin;
        CreateAccountNumbers();
    }

    private void CreateAccountNumbers()
    {
        //Declare variables
        string tempSort = string.Empty;
        Random sort = new();
        Random account = new();

        //Set variables
        tempSort = sort.Next(0, 100000).ToString("D6");
        SortCode = tempSort.Substring(0, 2) + "-" + tempSort.Substring(2, 2) + "-" + tempSort.Substring(4, 2);
        AccountNumber = account.Next(0, 10000000).ToString("D6");
    }

    private bool CheckPin(int pin)
    {
        return Pin == pin;
    }

    public void IncreaseBalance(double amount)
    {
        Balance += amount;
    }

    public void DecreaseBalance(double amount)
    {
        if (Balance - amount > 0)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("You do not have enough funds to withdraw.");
        }
    }

    public double GetBalance()
    {
        return Balance;
    }

    public string GetBirthDate()
    {
        return BirthDate.ToShortDateString();
    }

    public string GetName()
    {
        return Name;
    }

    public string GetSortCode()
    {
        return SortCode;
    }

    public string GetAccountNumber()
    {
        return AccountNumber;
    }
}