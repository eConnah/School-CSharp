using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        //Fish
        Fish thisFish = new("little fish", 1);
        thisFish.MaxSize(3);

        //Duck
        Duck thisDuck = new("little duck", 1);

        //Feed Loop
        for (int i = 0; i < 3; i++)
        {
            //Fish
            thisFish.Feed();
            Console.WriteLine(thisFish.GetState());

            //Duck
            thisDuck.Feed();
            Console.WriteLine(thisDuck.GetState());
        }
    }
}

class Animal
{
    protected string fedState;
    protected int size;
    public Animal(string f, int s)
    {
        fedState = f;
        size = s;
    }

    public virtual void Feed()
    {
        size++;
        Console.WriteLine("Fed");
    }

    public string GetState()
    {
        return fedState;
    }

    public int GetSize()
    {
        return size;
    }
}

class Fish : Animal
{
    private int maxSize;

    public Fish(string f, int s) : base(f, s)
    {
        maxSize = 2;
    }

    public void MaxSize(int m)
    {
        maxSize = m;
    }

    public override void Feed()
    {
        size += 2;
        Console.WriteLine("Fed");
        if (size >= maxSize)
        {
            fedState = "BIG FISH";
        }
    }
}

class Duck : Animal
{
    public Duck(string f, int s) : base(f, s)
    {

    }

    public override void Feed()
    {
        base.Feed();
        if (size >= 5)
        {
            fedState = "BIG DUCK";
        }
    }
}