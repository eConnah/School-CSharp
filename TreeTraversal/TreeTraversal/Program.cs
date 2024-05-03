using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

internal class Program
{
    public static bool stored = false;
    private static void Main(string[] args)
    {
        BNode bTree = new(5);
        TreeAdd(6, bTree);
        TreeAdd(83, bTree);
        TreeAdd(34, bTree);
        TreeAdd(2, bTree);
        TreeAdd(3, bTree);
        TreeAdd(4, bTree);
        PostOrder(bTree);
    }

    public static void TreeAdd(int newData, BNode tree)
    {
        stored = false;
        TreeAddData(newData, tree);
    }

    public static void TreeAddData(int newData, BNode tree)
    {
        while (!stored)
        {
            if (newData < tree.data)
            {
                if (tree.left == null)
                {
                    tree.left = new(newData);
                    stored = true;
                }
                else
                {
                    TreeAddData(newData, tree.left);
                }
            }
            else if (newData > tree.data)
            {
                if (tree.right == null)
                {
                    tree.right = new(newData);
                    stored = true;
                }
                else
                {
                    TreeAddData(newData, tree.right);
                }
            }
            else
            {
                stored = true;
            }
        }
    }

    public static void InOrder(BNode tree)
    {
        if (tree.left != null)
        {
            InOrder(tree.left);
        }
        Console.WriteLine(tree.data);
        if (tree.right != null)
        {
            InOrder(tree.right);
        }
    }

    public static void PreOrder(BNode tree)
    {
        Console.WriteLine(tree.data);
        if (tree.left != null)
        {
            PreOrder(tree.left);
        }
        if (tree.right != null)
        {
            PreOrder(tree.right);
        }
    }

    public static void PostOrder(BNode tree)
    {
        if (tree.left != null)
        {
            PostOrder(tree.left);
        }
        if (tree.right != null)
        {
            PostOrder(tree.right);
        }
        Console.WriteLine(tree.data);
    }
}

class BNode
{
    public BNode? left, right;
    public int data;
    public BNode(int data)
    {
        this.data = data;
    }
}