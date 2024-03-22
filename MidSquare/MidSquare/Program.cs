using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine()?.Trim() ?? string.Empty);
        Console.Write("Enter the mod: ");
        int x = int.Parse(Console.ReadLine()?.Trim() ?? string.Empty);
        number *= number;
        int[] numbers = new int[number.ToString().Length];
        int i = 0;
        string[] result = new string[2];
        foreach (char c in number.ToString())
        {
            numbers[i] = int.Parse(c.ToString());
            i++;
        }
        result[0] = numbers[(numbers.Length / 2) - 1].ToString();
        result[1] = numbers[(numbers.Length / 2)].ToString();
        number = int.Parse(result[0] + result[1]);
        number %= x;
        Console.WriteLine($"Result: {number}");
    }
}