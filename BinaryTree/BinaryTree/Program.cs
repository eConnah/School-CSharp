using System.Data;
using System.Security.AccessControl;

class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise Variables
        string[] inputTree;
        string[] children;
        BNode tree = new(' ');

        //Set variables
        Console.Write("Please enter your binary tree: ");
        inputTree = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();
        Console.Write("Please enter your children: ");
        children = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();

        for (int i = 0; i < inputTree.Length; i++)
        {
            if (inputTree[i] != "None")
            {
                tree.left.data = Convert.ToChar(inputTree[i]);
            }
        }

    }

    public static (BNode, bool) FillTree(BNode tree, char input)
    {
        if (tree.left.data != null)
        {
            if (tree.right.data != null)
            {
                FillTree(tree.left, input);
            }
            else
            {
                tree.right.data = input;
            }
        }
        else
        {
            tree.left.data = input;
        }
    }

    public static void RecursiveInorder(BNode root)
    {
        if (root.left != null)
        {
            RecursiveInorder(root.left);
        }
        Console.Write(root.data.ToString());
        if (root.right != null)
        {
            RecursiveInorder(root.right);
        }
    }
}
class BNode
{
    public char? data;
    public BNode? left, right;
    public BNode(char data)
    {
        this.data = data;
    }
}