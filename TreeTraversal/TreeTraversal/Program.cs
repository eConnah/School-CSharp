internal class Program
{
    private static void Main(string[] args)
    {
        BinaryTree myTree = new();
        myTree.AddNode(5);
        myTree.AddNode(6);
        myTree.AddNode(83);
        myTree.AddNode(34);
        myTree.AddNode(2);
        myTree.AddNode(3);
        myTree.AddNode(4);
        myTree.PostOrder();
    }
}

class Node
{
    public int left
    {
        get; set;
    }
    public int right
    {
        get; set;
    }
    public int data
    {
        get; set;
    }
    public Node(int l, int d, int r)
    {
        left = l;
        right = r;
        data = d;
    }
}

/*Binary Tree object making use of a dictionary of key (integer) and value (Node objects)
 * Constructor method provided - no parameters needed
 * Public method to Add Nodes to the tree - no return value
 * Overriding the method ToString so that when the object is printed to the console it appears
 * in a friendly way.
 */
class BinaryTree
{
    Dictionary<int, Node> tree;
    int currentIndex;
    public BinaryTree()
    {
        tree = new Dictionary<int, Node>();
        currentIndex = 0;
    }

    public void AddNode(int data)
    {
        if (currentIndex == 0)
        {
            tree.Add(0, new Node(-1, data, -1));
        }
        else
        {
            tree.Add(currentIndex, new Node(-1, data, -1));

            /*tempIndex variable used to keep track of position as we traverse the tree to find 
             * the new items place
             */
            int tempIndex = 0;

            /*Boolean flag variable used to control the While loop, changes to true when the
             * newly added node is in a leaf position
             */
            bool positionFound = false;
            while (!positionFound)
            {
                if (tree[currentIndex].data < tree[tempIndex].data)
                {
                    if (tree[tempIndex].left == -1)
                    {
                        tree[tempIndex].left = currentIndex;
                        positionFound = true;
                    }
                    else
                    {
                        tempIndex = tree[tempIndex].left;
                    }
                }
                else
                {
                    if (tree[currentIndex].data > tree[tempIndex].data)
                    {
                        if (tree[tempIndex].right == -1)
                        {
                            tree[tempIndex].right = currentIndex;
                            positionFound = true;
                        }
                        else
                        {
                            tempIndex = tree[tempIndex].right;
                        }
                    }
                }

            }
        }
        currentIndex++;
    }

    /*Overrides the existing toString method provided 
     * by the Object class (all classes inherit from the object class).
     */
    public override string ToString()
    {
        string stringToReturn = "";
        foreach (KeyValuePair<int, Node> pair in tree)
        {
            stringToReturn = stringToReturn + $"Key = {pair.Key} Left: {pair.Value.left} Data: {pair.Value.data} Right: {pair.Value.right}\n";
        }
        return stringToReturn;
    }

    public void InOrder(int index = 0)
    {
        if (tree[index].left != -1)
        {
            InOrder(tree[index].left);
        }
        Console.WriteLine(tree[index].data);
        if (tree[index].right != -1)
        {
            InOrder(tree[index].right);   
        }
    }

    public void PreOrder(int index = 0)
    {
        Console.WriteLine(tree[index].data);
        if (tree[index].left != -1)
        {
            PreOrder(tree[index].left);
        }
        if (tree[index].right != -1)
        {
            PreOrder(tree[index].right);   
        }
    }

    public void PostOrder(int index = 0)
    {
        if (tree[index].left != -1)
        {
            PostOrder(tree[index].left);
        }
        if (tree[index].right != -1)
        {
            PostOrder(tree[index].right);   
        }
        Console.WriteLine(tree[index].data);
    }
}
