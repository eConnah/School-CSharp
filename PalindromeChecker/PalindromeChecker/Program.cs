internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        string palindrome;
        string reversePalindrome;
        char[] charArray;

        //Set variables
        Console.WriteLine("Please enter your palindrome without punctuation: ");
        palindrome = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;
        charArray = palindrome.ToCharArray();
        Array.Reverse(charArray);
        reversePalindrome = new string(charArray);

        //Output
        if (reversePalindrome == palindrome)
        {
            Console.WriteLine("This is a palindrome.");
        } else
        {
            Console.WriteLine("This is not a palindrome.");
        }
    }
}