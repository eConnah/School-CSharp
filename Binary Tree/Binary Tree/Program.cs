using System.Data;
using System.Security.AccessControl;

internal class Program
{
    private static int treeLength = 0;
    private static void Main(string[] args)
    {
        //Declare Variables
        string treeInput;
        string childrenInput;
        string[] binaryTree;
        string[] children;
        List<int> childrenElements = new();
        int row = 0;
        int column = 0;
        bool isRoot;

        //Set variables
        Console.Write("Please enter your binary tree: ");
        treeInput = Console.ReadLine()?.Trim() ?? string.Empty;
        Console.Write("Please enter your children: ");
        childrenInput = Console.ReadLine()?.Trim() ?? string.Empty;
        binaryTree = treeInput.Split(' ');
        children = childrenInput.Split(' ');
        treeLength = binaryTree.Length;

        //Find Index
        foreach (string item in children)
        {
            childrenElements.Add(Array.IndexOf(binaryTree, item));
        }

        while (true)
        {
            switch (InTree(row, column, childrenElements[0], childrenElements[1]))
            {
                case 0:
                    column++;
                    break;
                case 1:

                    break;
                case 2:
                    row++;
                    break;
            }
        }


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

    private static int InTree(int rRow, int rColumn, int childOne, int childTwo)
    {
        //Declare and initilise variables
        int row = rRow + 1;
        int column = 0;
        int element = ToElement(row, column);
        int i = 0;

        //Loop
        while (element < treeLength)
        {
            if (element == childOne)
            {
                i++;
            }
            if (element == childTwo)
            {
                i++;
            }
            if (column < Math.Pow(2, row))
            {
                element++;
            }
            else
            {
                column = 0;
                row++;
            }
        }

        //Return
        return i;
    }
}