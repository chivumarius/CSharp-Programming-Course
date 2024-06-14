/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                           • "SEARCHING" •
                    ───────────────────────────
                 • "DEPTH-FIRST TRAVERSAL" SEARCH •
                     • ON "TREES" & "GRAPHS" •
                  
                  
                  
    ▬ "Depth-First Traversal" 
        → is a "Method" 
        → "Used" to "Explore" or "Search" 
        → through the "Nodes" 
        → of a "Tree" or "Graph" Data Structure. 
        
        ♦ "It" 
            → is a "Vertical Traversal",
            → which involves "Visiting Each Node" 
            → and "Recursively Exploring" 
            → its "Adjacent Nodes" or "Children", 
            → "Moving" as "Deeply" as "Possible" 
            → before "Backtracking". 
        
        
        ♦ There are "Variants" 
            → of "Depth-First Traversal" 
            → for "Trees" 
               (
                •► "Pre-Order Traversal", 
                "In-Order Traversal" and 
                •► "Post-Order Traversal"
               ) 
            → and "Graphs". 
        
        
        
    ▬ The "Main Steps" include:
        1- "Visiting" the "Starting Node", 
        2- "Exploring Adjacent Nodes Recursively", 
        3- "Backtracking" when "Necessary" and 
        4- "Repeating" until "All Nodes" are "Visited". 
        
    
    
    ▬ "Depth-First Traversal" is "Commonly Used" 
        → in "Graph Algorithms", like: 
            •► "Depth-First Search", 
            •► "Path Finding" and 
            •► "Cycle Detection".

               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.searching;


// ▬▬ "Node" Class ▬▬
public class Node
{
    // ▼ "Fields" ▼
    public Node left;
    public Node right;
    public int data;

    // ▼ Constructor to initialize Node with data ▼
    public Node(int data)
    {
        this.data = data;
        this.left = null;
        this.right = null;
    }
}




// ▬▬ "DepthFirstTraversalSearchOnTreesAndGraphs" Class ▬▬
public class DepthFirstTraversalSearchOnTreesAndGraphs
{


    // ▬ "DepthFirstSearchTraversalOnTree()" Method ▬
    public void DepthFirstSearchTraversalOnTree(Node root)
    {
        // ▼ Creating "Stack" Data Structure ▼  
        Stack<Node> nodes = new Stack<Node>();


        // ▼ "Pushing" the "Root Node"
        //   → into "Stack" Data Structure ▼
        nodes.Push(root);


        // ▼ "Looping" until "Stack" Data Structure is "Empty" ▼
        while (nodes.Count > 0)
        {

            // ▼ "Popping" the "Top Node" ▼
            Node node = nodes.Pop();


            // ▼ If "Right Node" is "Not Null" ▼
            if (node.right != null)
            {
                // ▼ "Pushing" the "Right Node" ▼
                nodes.Push(node.right);
            }


            // ▼ If "Left Node" is "Not Null" ▼ 
            if (node.left != null)
            {
                // ▼ "Pushing" the "Left Node" ▼
                nodes.Push(node.left);
            }


            // ▼ "Printing" the "Current Node" ▼
            Console.WriteLine(" " + node.data);
        }

    }





   
    // ▬ "DepthFirstSearchTraversalOnGraph()" Method ▬
    public HashSet<int> DepthFirstSearchTraversalOnGraph(Dictionary<int, List<int>> graph, int root)
    {
        // ▼ Creating "HashSet" Data Structure ▼  
        HashSet<int> visited = new HashSet<int>();

        // ▼ If root is not present in the graph, return empty set ▼
        if (!graph.ContainsKey(root))
        {
            return visited;
        }

        // ▼ Creating "Stack" Data Structure ▼
        Stack<int> stack = new Stack<int>();

        // ▼ "Pushing" the "Root Node" ▼
        stack.Push(root);

        // ▼ "Looping" until "Stack" Data Structure is "Empty" ▼
        while (stack.Count > 0)
        {
            // ▼ "Popping" the "Top Node" ▼
            int vertex = stack.Pop();

            // ▼ "Checking" if "Node" is "Already Visited" ▼
            if (visited.Contains(vertex))
            {
                continue;
            }

            // ▼ "Adding" the "Current Vertex" to the "Visited HashSet" ▼
            visited.Add(vertex);

            // ▼ "Going" through "Each Neighbor" in the Adjacency List" ▼
            foreach (int neighbor in graph[vertex])
            {
                // ▼ "Checking" if "Neighbor" is "Not Already Visited" ▼
                if (!visited.Contains(neighbor))
                {
                    // ▼ "Pushing" the "Neighbor" ▼
                    stack.Push(neighbor);
                }
            }
        }

        // Return statement was missing in the previous code
        return visited;
    }





    // ▬ "RunDepthFirstTraversalSearch()" Method ▬
    public static void RunDepthFirstTraversalSearch()
    {
        // ▼ "Create" an "Instance" of the "DepthFirstTraversalSearchOnTreesAndGraphs" Class
        DepthFirstTraversalSearchOnTreesAndGraphs dfs = new DepthFirstTraversalSearchOnTreesAndGraphs();
        
        // ▼ (1) "Create" an "Example" of "Tree" ▼
        Node root = new Node(1);
        root.left = new Node(2);
        root.right = new Node(3);
        root.left.left = new Node(4);
        root.left.right = new Node(5);
    
        
        // ▼ "Call" the "Method"
        //     → for "Depth-First Traversal"
        //     → on the "Tree" ▼
        Console.WriteLine("Depth-First Traversal on Tree:");
        dfs.DepthFirstSearchTraversalOnTree(root);

        
        
        // ▼ (2) "Create" an "Example" of "Graph" ▼
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        graph.Add(0, new List<int> { 1, 2 });
        graph.Add(1, new List<int> { 3, 4 });
        graph.Add(2, new List<int> { 3, 5 });
        graph.Add(3, new List<int>()); // Add vertex '3' without any neighbors
        graph.Add(4, new List<int>()); // Add vertex '4' without any neighbors
        graph.Add(5, new List<int>());

        
        // ▼ "Call" the Method
        //   → for "Depth-First Traversal"
        //   → on the Graph ▼
        Console.WriteLine("\nDepth-First Traversal on Graph:");
        HashSet<int> visitedNodes = dfs.DepthFirstSearchTraversalOnGraph(graph, 0);
        foreach (int node in visitedNodes)
        {
            Console.WriteLine(node);
        }
    }

}






