using System.Net.NetworkInformation;
class Program
{
    private static int SwitchPin;
    private static void Main(string[] args)
    {
        //Declare variables
        string choiceString;
        int choiceInt;
        Banking userAccount;

        //Set variables
        userAccount = CreateAccount();

        //Loop
        do
        {
            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Create a new account");
                Console.WriteLine("2. Deposit money");
                Console.WriteLine("3. Withdraw money");
                Console.WriteLine("4. Check balance");
                Console.WriteLine("5. Exit");

                //Set variables
                choiceString = Console.ReadLine()?.Trim() ?? string.Empty;
                if (int.TryParse(choiceString, out choiceInt) && choiceInt >= 1 && choiceInt <= 5)
                {
                    break;
                }
            } while (true);

            //Menu Switch
            switch (choiceInt)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Please enter your pin: ");
                    if (!CheckPin(int.Parse(Console.ReadLine()?.Trim() ?? string.Empty)))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine("WARNING! This will delete your previous account.");
                    Console.Write("Are you sure you want to continue: ");
                    if ((Console.ReadLine()?.ToLower().Trim() ?? string.Empty) == "no")
                    {
                        break;
                    }
                    userAccount = CreateAccount();
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Please enter your pin: ");
                    if (!CheckPin(int.Parse(Console.ReadLine()?.Trim() ?? string.Empty)))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.Write("How much would you like to deposit: £");
                    userAccount.IncreaseBalance(double.Parse(Console.ReadLine()?.Trim() ?? string.Empty));
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Please enter your pin: ");
                    if (!CheckPin(int.Parse(Console.ReadLine()?.Trim() ?? string.Empty)))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.Write("How much would you like to withdraw: £");
                    userAccount.DecreaseBalance(double.Parse(Console.ReadLine()?.Trim() ?? string.Empty));
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Please enter your pin: ");
                    if (!CheckPin(int.Parse(Console.ReadLine()?.Trim() ?? string.Empty)))
                    {
                        break;
                    }
                    Console.Clear();
                    Console.WriteLine($"Name: {userAccount.GetName()}");
                    Console.WriteLine($"Date of Birth: {userAccount.GetBirthDate()}");
                    Console.WriteLine($"Bank Number: {userAccount.GetSortCode()}/{userAccount.GetAccountNumber()}");
                    Console.WriteLine($"Balance: £{userAccount.GetBalance()}");
                    Console.WriteLine();
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 5:
                    return;
                default:
                    break;
            }
        } while (true);
    }

    private static bool CheckPin(int pin)
    {
        return pin == SwitchPin;
    }

    private static Banking CreateAccount()
    {
        //Declare variables
        string firstName;
        string lastName;
        DateTime switchDOB;
        double switchDeposit;

        //Set variables
        Console.Clear();
        Console.WriteLine("Please enter the following information:");
        Console.Write("First Name: ");
        firstName = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        Console.Write("Last Name: ");
        lastName = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        Console.Write("Date of Birth: ");
        switchDOB = DateTime.Parse(Console.ReadLine()?.Trim() ?? string.Empty);
        Console.Write("Deposit: ");
        switchDeposit = double.Parse(Console.ReadLine()?.Trim() ?? string.Empty);
        Console.Write("Pin: ");
        SwitchPin = int.Parse(Console.ReadLine()?.Trim() ?? string.Empty);

        //Return
        return new(switchDeposit, switchDOB, char.ToUpper(firstName[0]) + firstName.Substring(1) + " " + char.ToUpper(lastName[0]) + lastName.Substring(1), SwitchPin);
    }
}

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
        if (Balance - amount >= 0)
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