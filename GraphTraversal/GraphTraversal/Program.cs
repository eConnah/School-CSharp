internal class Program
{
    private static void Main(string[] args)
    {
        Dictionary<string, string[]> graphOne = new()
        {
            {"A",new[]{"B","C" } },
            {"B",new[]{"A","D","E" } },
            {"C",new[]{"A","F","G" } },
            {"D",new[]{"B","E" } },
            {"E",new[]{"B","D" } },
            {"F",new[]{"C","G" } },
            {"G",new[]{"C","F","H","I"} },
            {"H",new[]{"G","I" } },
            {"I",new[]{"G","H","X" } },
            {"X",new[]{"I" } }
        };

        Dictionary<string, string[]> graphTwo = new()
        {
            { "A", new[]{ "B", "D", "E" } },
            { "B", new[]{ "A", "C", "D"} },
            { "C", new[]{ "B", "G" } },
            { "D", new[]{ "A", "B", "E", "F" } },
            { "E", new[]{ "A", "D" } },
            { "F", new[] { "D" } },
            { "G", new[] { "C" } }
        };

        List<string> VisitedNodes = new();
        VisitedNodes = BreadthFirst(graphTwo, "A");
        foreach (string node in VisitedNodes)
        {
            Console.Write($"{node} ");
        }
        Console.WriteLine();
    }

    private static List<string> DepthFirst(Dictionary<string, string[]?> graph, string currentVertex, List<string> visitedNodes)
    {
        visitedNodes.Add(currentVertex);
        foreach (string node in graph[currentVertex])
        {
            if (!visitedNodes.Contains(node))
            {
                DepthFirst(graph, node, visitedNodes);
            }
        }
        return visitedNodes;
    }

    private static List<string> BreadthFirst(Dictionary<string, string[]> graph, string firstVertex)
    {
        List<string> visistedNodes = new();
        Queue<string> toVisit = new();
        string currentVertex;
        toVisit.Enqueue(firstVertex);
        while (toVisit.Count > 0)
        {
            currentVertex = toVisit.Dequeue();
            visistedNodes.Add(currentVertex);
            foreach (string node in graph[currentVertex])
            {
                if (!visistedNodes.Contains(node) && !toVisit.Contains(node))
                {
                    toVisit.Enqueue(node);
                }
            }
        }
        return visistedNodes;
    }
}