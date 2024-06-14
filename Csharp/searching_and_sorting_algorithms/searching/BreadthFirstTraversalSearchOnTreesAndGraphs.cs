/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                           • "SEARCHING" •
                    ───────────────────────────
               • "BREADTH-FIRST TRAVERSAL" SEARCH •
                     • ON "TREES" & "GRAPHS" •
                  
                  
                  
    ▬ "Breadth-First Traversal" Search 
        → First "Explores All Neighbors" 
        → at the "Current Level", 
        → then "Moves" to the "Next Level". 
        
        
        ♦ A "Queue" 
            → is used to "Keep Track" 
            → of the "Traversal Order" 
        
        
        ♦ It is "Useful" 
            → for Finding "Shortest Paths" 
            → or Finding "All Reachable Nodes" 
            → from a Given Node.
         
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.searching;



// ▬▬ "Node" Class ▬▬
public class Node2
{
    // ▼ "Fields" ▼
    public Node2 left;
    public Node2 right;
    public int data;

    
    // ▼ Constructor to initialize Node with data ▼
    public Node2(int data)
    {
        this.data = data;
        this.left = null;
        this.right = null;
    }
}




// ▬▬ "BreadthFirstTraversalSearchOnTreesAndGraphs" Class ▬▬
public class BreadthFirstTraversalSearchOnTreesAndGraphs
{
    
    // ▬ "BreadthFirstSearchTraversalOnTree()" Method ▬
    public void BreadthFirstSearchTraversalOnTree(Node2 root)
    {
        // ▼ Creating "Queue" Data Structure ▼
        Queue<Node2> nodes = new Queue<Node2>();
        
        
        // ▼ Checking if "Root Node" is "Not Null" ▼
        if (root == null)
        {
            return;
        }
       
        
        // ▼ "Adding" the "Root Node"
        //   → into "Queue" Data Structure ▼
        nodes.Enqueue(root);
        
        
        // ▼ "Looping" until "Queue" Data Structure is "Empty" ▼
        while (nodes.Count > 0)
        {

            // ▼ "Popping" the "Top Node" ▼
            Node2 node = nodes.Dequeue();


            // ▼ "Visiting" the "Current Node" ▼
            Console.Write(" " + node.data);


            // ▼ "Checking" if "Left Node" is "Not Null" ▼
            if (node.left != null)
            {
                // ▼ "Adding" the "Left Node" 
                //   → into "Queue" Data Structure ▼
                nodes.Enqueue(node.left);
            }


            // ▼ "Checking" if "Right Node" is "Not Null" ▼
            if (node.right != null)
            {
                // ▼ "Adding" the "Right Node" 
                //   → into "Queue" Data Structure ▼
                nodes.Enqueue(node.right);
            }
        }
    }
    
    

    
    // ▬ "BreadthFirstSearchTraversalOnGraph()" Method ▬
    public HashSet<int> BreadthFirstSearchTraversalOnGraph(Dictionary<int, List<int>> graph, int root)
    {
        // ▼ Creating "HashSet" Data Structure ▼
        HashSet<int> visited = new HashSet<int>();

        // ▼ If "root" is "Not Present" in the "Graph",
        //   → Return "Empty Set" ▼
        if(!graph.ContainsKey(root)) 
        {
            return visited;
        }
        

        // ▼ Creating "Queue" Data Structure ▼
        Queue<int> queue = new Queue<int>();
        

        // ▼ "Adding" the "Root Node" 
        //   → into "Queue" Data Structure ▼
        queue.Enqueue(root);
        
        
        // ▼ "Looping" until "Queue" Data Structure is "Empty" ▼
        while (queue.Count > 0)
        {
            // ▼ "Popping" the "Top Node" ▼
            int vertex = queue.Dequeue();
            
            
            // ▼ "Checking" if "Node" is "Already Visited" ▼
            if (visited.Contains(vertex))
            {
                continue;
            }
            
            
            // ▼ "Visiting" the "Current Node" ▼
            visited.Add(vertex);


            foreach (var neighbor in graph[vertex])
            {
                // ▼ "Adding" the "Neighbor Node"
                queue.Enqueue(neighbor);
            }
        }
        

        // ▼ "Returning" the "Visited Set" ▼
        return visited;
    }





    // ▬ "RunBreadthFirstTraversalSearch()" Method ▬
    public static void RunBreadthFirstTraversalSearch()
    {
        // ▼ "Create" an "Instance" of the "BreadthFirstTraversalSearchOnTreesAndGraphs" Class ▼
        BreadthFirstTraversalSearchOnTreesAndGraphs bfs = new BreadthFirstTraversalSearchOnTreesAndGraphs();

        // ▼ (1) "Create" an "Example" of "Tree" ▼
        Node2 root = new Node2(1);
        root.left = new Node2(2);
        root.right = new Node2(3);
        root.left.left = new Node2(4);
        root.left.right = new Node2(5);

        // ▼ "Call" the Method for "Breadth-First Traversal" on the "Tree" ▼
        Console.WriteLine("Breadth-First Traversal on Tree:");
        bfs.BreadthFirstSearchTraversalOnTree(root);

        
        
        // ▼ (2) "Create" an "Example" of "Graph" ▼
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        graph.Add(0, new List<int> { 1, 2 });
        graph.Add(1, new List<int> { 3, 4 });
        graph.Add(2, new List<int> { 3, 5 });
        graph.Add(3, new List<int>());
        graph.Add(4, new List<int>());
        graph.Add(5, new List<int>());

        // ▼ "Call" the Method for "Breadth-First Traversal" on the "Graph" ▼
        Console.WriteLine("\n\nBreadth-First Traversal on Graph:");
        HashSet<int> visitedNodes = bfs.BreadthFirstSearchTraversalOnGraph(graph, 0);
        foreach (int node in visitedNodes)
        {
            Console.WriteLine(node);
        }
    }
}
    
