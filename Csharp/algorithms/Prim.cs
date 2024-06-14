/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                              • "ALGORITHMS" •
                    • "MINIMUM SPANNING TREE ALGORITHMS" •
                    ──────────────────────────────────────
                          • "PRIM" ALGORITHM •

       


    ▬ "Prim" Algorithm 
      → "Finds" a "Minimum Spanning Tree" 
      → in a "Weighted Graph" 
      → by "Starting" 
      → from a "Start Node" 
      → and "Expanding It" 
      → by "Adding" the "Smallest" available "Edges", 
      → "Avoiding" the "Formation" of "Cycles". 



      ♦ It is "Efficient", 
        → having a 
          •► "Time Complexity" of "\(O(E \log V)\)". 
      

      ♦ It is "Used" 
        → in "Network Design" 
        → and "Optimization" of "Connectivity" 
        → between "Nodes".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "Prim" Class ▬
public class Prim
{
    // ▬ "GetMinimumNode()" Method ▬
    private static int GetMinimumNode(int[] nodes, bool[] set, int verticesCount)
    {
        // ▼ "Variables" Initialization ▼
        int min = int.MaxValue;
        int minIndex = 0;
        
        // ▼ "Loop" ▼
        for (int v = 0; v < verticesCount; v++) 
        {
            // ▼ "Check" ▼
            if (set[v] == false && nodes[v] < min)
            {
                // ▼ "Set" ▼
                min = nodes[v];
                minIndex = v;
            }
        }
        
        // ▼ "Return" ▼
        return minIndex;
    }
    
    
    
    
    // ▬ "PrimAlgorithm()" Method ▬
    private static int[] PrimAlgorithm(int[,] graph, int verticesCount)
    {
        // ▼"Arrays" Initialization ▼
        int[] parent = new int[verticesCount];
        int[] node = new int[verticesCount];
        bool[] minimumSpanningTreeSet = new bool[verticesCount]; 

        // ▼ "Loop" ▼
        for (int i = 0; i < verticesCount; i++)
        {
            // ▼ "Set" ▼
            node[i] = int.MaxValue;
            minimumSpanningTreeSet[i] = false;
        }

        // ▼ "Set" ▼
        parent[0] = -1;
        node[0] = 0;

        // ▼ "Loop" ▼
        for (int count = 0; count < verticesCount - 1; ++count) 
        {
            // ▼ "Variables" Initialization ▼
            int minNode = GetMinimumNode(node, minimumSpanningTreeSet, verticesCount);

            // ▼ "Set" ▼
            minimumSpanningTreeSet[minNode] = true;

            // ▼ "Nested Loop" ▼
            for (int v = 0; v < verticesCount; ++v)
            {
                // ▼ "Check" ▼
                if(Convert.ToBoolean(graph[minNode, v]) && 
                   minimumSpanningTreeSet[v] == false && 
                   graph[minNode, v] < node[v] )
                {
                    // ▼ "Set" ▼
                    parent[v] = minNode; 
                    node[v] = graph[minNode, v];
                }
            }
        }

        // ▼ Return the parent array ▼
        return parent;
    } 

    
    


// ▬ "RunPrim()" Method ▬
    public static void RunPrim()
    {
        // Initialize the graph
        int[,] graph = {
            { 0, 2, 0, 6, 0 },
            { 2, 0, 3, 8, 5 },
            { 0, 3, 0, 0, 7 },
            { 6, 8, 0, 0, 9 },
            { 0, 5, 7, 9, 0 }
        };

        // Call the Prim algorithm to find the minimum spanning tree
        int[] parent = PrimAlgorithm(graph, 5);

        // Display the edges of the minimum spanning tree
        Console.WriteLine("Edges of the 'Minimum Spanning Tree' - 'Found' by 'Prim's Algorithm':");
        Console.WriteLine(" Edge   Weight");
        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine($" {parent[i]} - {i}    {graph[i, parent[i]]}");
        }
    }
} 