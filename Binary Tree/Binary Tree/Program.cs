using System.Data;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise Variables
        string[] binaryTree;
        string[] children;

        //Set variables
        Console.Write("Please enter your binary tree: ");
        binaryTree = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();
        Console.Write("Please enter your children: ");
        children = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();
    }
}