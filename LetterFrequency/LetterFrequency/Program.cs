internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Dictionary<char, int> acceptedLetters = new()
        {
            { 'a', 0 },
            { 'b', 0 },
            { 'c', 0 },
            { 'd', 0 },
            { 'e', 0 },
            { 'f', 0 }
        };
        Console.Write("Please enter your string: ");
        string input = Console.ReadLine().ToLower();
        bool valid = true;
        foreach (char item in input)
        {
            if (!acceptedLetters.ContainsKey(item))
            {
                valid = false;
                break;
            }
            else
            {
                acceptedLetters[item]++;
            }
        }
        if (valid)
        {
            int highestValue = acceptedLetters.Values.Max();
            string output = string.Empty;
            foreach (char item in input)
            {
                if (acceptedLetters[item] == highestValue)
                {
                    output += char.ToUpper(item);
                }
                else
                {
                    output += item;
                }
            }
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}