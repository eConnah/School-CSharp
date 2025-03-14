using FarmOOP;
public class Cow:Animal
{
    private bool isMilked;
    public Cow() : base("Cow", true)
    {
        
    }

    public void Milk()
    {
        isMilked = true;
    }

}