internal class Program
{
    private static void Main(string[] args)
    {
        int currentBaseTen = 0;
        string baseTen;
        string baseTwo;
        (string, string)? result;
        List<(string, string)> palindromes = new();
        while (palindromes.Count <= 20)
        {
            baseTen = currentBaseTen.ToString();
            baseTwo = BinaryConverter(currentBaseTen);
            result = IsPalindrome(baseTen, baseTwo);
            if (result != null)
            {
                palindromes.Add(result.Value);
            }
            currentBaseTen++;
        }
        foreach ((string, string) item in palindromes)
        {
            Console.WriteLine(item);   
        }
    }

    private static string BinaryConverter(int number)
    {
        if (number == 0)
        {
            return "0";   
        }
        string baseTwo = string.Empty;
        int halvedInt = number;
        while (halvedInt > 0)
        {
            baseTwo += halvedInt % 2;
            halvedInt /= 2;
        }
        return string.Concat(baseTwo.Reverse());
    }

    private static (string, string)? IsPalindrome(string originalTen, string originalTwo)
    {
        string reversedTen;
        string reversedTwo;
        if (originalTen.Length != 1)
        {
            reversedTen = string.Concat(originalTen.Reverse());
        }
        else
        {
            reversedTen = originalTen;
        }
        if (originalTwo.Length != 1)
        {
            reversedTwo = string.Concat(originalTwo.Reverse());
        }
        else
        {
            reversedTwo = originalTwo;
        }
        if (string.Compare(originalTen, reversedTen) == 0)
        {
            if (string.Compare(reversedTwo, originalTwo) == 0)
            {
                return (originalTen, originalTwo);
            }
        }
        return null;
    }
}