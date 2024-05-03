using System.ComponentModel;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        Tree.Node bTree = new(5);
        Tree.Add(6, bTree);
        Tree.Add(83, bTree);
        Tree.Add(34, bTree);
        Tree.Add(2, bTree);
        Tree.Add(3, bTree);
        Tree.Add(4, bTree);
        Tree.PostOrder(bTree);
    }
}

internal class Tree
{
    public static bool stored = false;
    public static void Add(int newData, Node tree)
    {
        stored = false;
        TreeAddData(newData, tree);
    }

    public static void TreeAddData(int newData, Node tree)
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

    public static void InOrder(Node tree)
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

    public static void PreOrder(Node tree)
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

    public static void PostOrder(Node tree)
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

    public class Node
    {
        public Node? left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
        }
    }
}