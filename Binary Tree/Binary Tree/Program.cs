using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare Variables
        string treeInput;
        string childrenInput;
        string[] binaryTree;
        string[] children;
        List<int> childrenElements = new();

        //Set variables
        Console.Write("Please enter your binary tree: ");
        treeInput = Console.ReadLine()?.Trim() ?? string.Empty;
        Console.Write("Please enter your children: ");
        childrenInput = Console.ReadLine()?.Trim() ?? string.Empty;
        binaryTree = treeInput.Split(' ');
        children = childrenInput.Split(' ');

        //Find Index
        foreach (string item in children)
        {
            childrenElements.Add(Array.IndexOf(binaryTree, item));
        }

        //
    }

    private static int ToElement(int row, int column)
    {
        int element = 0;

        for (int i = 0; i < row; i++)
        {
            element *= 2;
            element++;
        }
        element += column;
        return element;
    }

    private static (int row, int column) FromElement(int element)
    {
        int i = 0;
        while (true)
        {
            if (element - ToElement(i, 0) >= 0)
            {
                i++;
            }
            else
            {
                i--;
                break;
            }
        }
        return (i, element - ToElement(i, 0));
    }
}