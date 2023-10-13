Banking Connor = new(864, );
Connor.IncreaseBalance(754);
Console.WriteLine(Connor.GetBalance());

class Banking
{
    private int Balance;
    private DateTime BirthDate;
    private string Name;

    public Banking(int startingAmount, DateTime birthDate, string name)
    {
        Balance = startingAmount;
        BirthDate = birthDate;
        Name = name;
    }

    public void IncreaseBalance(int amount)
    {
        Balance += amount;
    }

    public void DecreaseBalance(int amount)
    {
        Balance -= amount;
    }

    public int GetBalance()
    {
        return Balance;
    }
}