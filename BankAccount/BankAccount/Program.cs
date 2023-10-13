class Banking
{
    private int Balance;

    public Banking(int startingAmount)
    {
        Balance = startingAmount;
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