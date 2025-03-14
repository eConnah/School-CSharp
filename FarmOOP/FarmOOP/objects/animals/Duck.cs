using FarmOOP;
public class Duck:Animal
{
    private bool isFeathered;
    public Duck() : base("Duck", random.Next(0, 1) == 0)
    {
        
    }

    public void Feather()
    {
        isFeathered = true;
    }

}