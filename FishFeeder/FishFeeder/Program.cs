Fish cat = new Fish("Fish", 1);
Fish dog = new Fish("Fish", 1);

Console.WriteLine(cat.GetState());
while (dog.GetState() != "FISH")
{
    dog.Feed();
}
Console.WriteLine($"The dog is now a big {dog.GetState()}");

internal class Fish
{
    private string state;
    private int size;
    public Fish(string fishState, int fishSize)
    {
        state = fishState;
        size = fishSize;
    }

    public void Feed()
    {
        size++;
        if (size >= 5)
        {
            state = "FISH";
        }
    }

    public string GetState()
    {
        return state;
    }

    public int GetSize()
    {
        return size;
    }
}