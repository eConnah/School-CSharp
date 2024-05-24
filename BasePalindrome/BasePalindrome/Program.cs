internal class Program
{
    private static void Main(string[] args)
    {
        int currentBaseTen = 0;
        List<int> baseTen = new();
        List<int> baseTwo = new();
        List<(int, int)> palindromes = new();
    }

    private static List<int> BinaryConverter(int number)
    {
        List<int> baseTwo = new();
        int halvedInt = number;
        while (halvedInt > 1)
        {
            baseTwo.Add(number % 2);
            halvedInt = number / 2;
        }
        baseTwo.Reverse();
        return baseTwo;
    }

    private static List<(int, int)> IsPalindrome(List<int> originalTen, List<int> originalTwo)
    {
        List<int> reversedTen = new();
        reversedTen = originalTen;
        reversedTen.Reverse();
        List<int> reversedTwo = new();
        reversedTwo = originalTwo;
        reversedTwo.Reverse();
        if (originalTen == reversedTen)
        {
            if (reversedTwo == originalTwo)
            {
                return (int.Parse(originalTen.ToString()), int.Parse(originalTwo.ToString()));
            }
        }
    }
}