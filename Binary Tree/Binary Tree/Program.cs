using System.Data;
using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise Variables
        string[] inputTree;
        string[] children;
        char[] binaryTree;
        int[,] treeChildren;
        int counter = 1;
        int finalRow = 0;
        int root = 0;

        //Set variables
        Console.Write("Please enter your binary tree: ");
        inputTree = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();
        Console.Write("Please enter your children: ");
        children = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();

        //Get Final Row
        while (true)
        {
            if (Math.Pow(2, finalRow) - 1 < inputTree.Length - 1)
            {
                finalRow++;
            }
            else
            {
                finalRow--;
                finalRow = Convert.ToInt32(Math.Pow(2, finalRow));
                break;
            }
        }

        //Create binary tree
        binaryTree = new char[inputTree.Length];
        treeChildren = new int[inputTree.Length, 2];
        for (int i = 0; i < inputTree.Length; i++)
        {
            if (inputTree[i] == "None")
            {
                binaryTree[i] = ' ';
            }
            else
            {
                binaryTree[i] = Convert.ToChar(inputTree[i]);
            }
            if (i < finalRow - 1)
            {
                treeChildren[i, 0] = counter++;
                treeChildren[i, 1] = counter++;
            }
            else
            {
                treeChildren[i, 0] = -1;
                treeChildren[i, 1] = -1;
            }
        }

        //Find Children
        while (true)
        {
            if (binaryTree[root] == Convert.ToChar(children[1]) || binaryTree[root] == Convert.ToChar(children[2]))
            {
                break;
            }
            if (treeChildren[root, 0] != -1 && treeChildren[root, 1] != -1)
            {
                root = treeChildren[root, 0];
            }
        }
    }
}