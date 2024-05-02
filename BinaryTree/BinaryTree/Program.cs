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

        //Test
        FixNulls(tree);
        Console.WriteLine($"The common ancestor of {children[0]} and {children[1]} is {FindCommonAncestor(tree, char.Parse(children[0]), char.Parse(children[1])).data}.");
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
        double powerTwo;

        //Path Generation
        while (index >= (Math.Pow(2, ones) - 1))
        {
            ones++;
        }
        ones--;
        for (int i = 0; i < ones; i++)
        {
            path.Add(1);
        }
        difference = index - (Math.Pow(2, ones) - 1);
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

    public static void FixNulls(BNode root)
    {
        if (root.left != null && root.left.data == ' ')
        {
            root.left = null;
        }
        if (root.right != null && root.right.data == ' ')
        {
            root.right = null;
        }
        if (root.left != null)
        {
            FixNulls(root.left);
        }
        if (root.right != null)
        {
            FixNulls(root.right);
        }
    }

    public static BNode? FindCommonAncestor(BNode? root, char node1, char node2)
    {
        if (root == null || root.data == node1 || root.data == node2)
        {
            return root;
        }

        BNode? left = FindCommonAncestor(root.left, node1, node2);
        BNode? right = FindCommonAncestor(root.right, node1, node2);

        if (left != null  && right != null)
        {
            return root;
        }

        return left ?? right;
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