using System.Data;
using System.Security.AccessControl;

class Program
{
    private static void Main(string[] args)
    {
        //Declare and initilise Variables
        string[] inputTree;
        string[] children;
        BNode tree;
        List<int> path = new();

        //Set variables
        Console.Write("Please enter your binary tree: ");
        inputTree = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();
        Console.Write("Please enter your children: ");
        children = Console.ReadLine()?.Trim().Split(' ') ?? Array.Empty<string>();

        //Fill Tree
        tree = new BNode(Convert.ToChar(inputTree[0]));
        for (int i = 1; i < inputTree.Length; i++)
        {
            path = PathGenerator(i);
            if (inputTree[i] != "None")
            {
                FillTree(tree, Convert.ToChar(inputTree[i]), path, 0);
            }
            else
            {
                FillTree(tree, ' ', path, 0);
            }
        }

        Console.WriteLine();
    }

    public static void FillTree(BNode tree, char input, List<int> path, int index)
    {
        for (int i = index; i < path.Count; i++)
        {
            if (path[i] == 1)
            {
                if (tree.left == null)
                {
                    tree.left = new BNode(input);
                }
                else
                {
                    FillTree(tree.left, input, path, i + 1);
                }
            }
            else if (path[i] == 2)
            {
                if (tree.right == null)
                {
                    tree.right = new BNode(input);
                }
                else
                {
                    FillTree(tree.right, input, path, i + 1);
                }
            }
        }
    }

    public static List<int> PathGenerator(int index)
    {
        //Variables
        List<int> path = new();
        int ones = 0;
        int twoPower = 10;
        double difference;
        double powerOne = 0;
        double powerTwo;

        //Path Generation
        while (index >= powerOne)
        {
            ones++;
            powerOne = Math.Pow(2, ones) - 1;
        }
        ones--;
        for (int i = 0; i < ones; i++)
        {
            path.Add(1);
        }
        difference = index - powerOne;
        while (twoPower > 0)
        {
            powerTwo = Math.Pow(2, twoPower);
            if (difference < powerTwo)
            {
                twoPower--;
            }
            else
            {
                path[^(twoPower + 1)] = 2;
                difference -= powerTwo;
            }
        }
        if (index % 2 == 0)
        {
            path[^1] = 2;
        }
        return path;
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