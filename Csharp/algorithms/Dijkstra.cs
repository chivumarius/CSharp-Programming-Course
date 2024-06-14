/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                         • "ALGORITHMS" •
                    • "SHORTEST PATH ALGORITHMS" •
                    ──────────────────────────────
                      • "DIJKSTRA" ALGORITHM •

       


    ▬ "Dijkstra" Algorithm 
        → is a "Method" for "Finding" 
        → the "Shortest Path" 
        → between a "Start Node" 
        → and "All Other Nodes" 
        → in a "Weighted Graph" 
        → with "Non-Negative Edges". 


        ♦ By "Choosing Nodes" 
            → "Based" on the "Shortest Distance" 
            → and "Constantly Updating" the "Distances", 
            → the "Algorithm" 
            → "Quickly Finds" the "Shortest Paths" 
            → to "All Nodes". 



        ♦ It is "Used" 
            → in "Network Routing" 
            → and "Other Applications" 
            → where it is "Necessary" 
            → to "Determine" 
            → the "Most Efficient Paths". 

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "Dijkstra" Class ▬
public class Dijkstra
{
    // ▬ "MinimumDistance()" Method ▬
    private static int MinimumDistance(int[] dist, bool[] shortPathTreeSet, int verticesCount)
    {
        // ▼ "Variables" ▼
        int min = int.MaxValue;
        int minIndex = 0;
        
        // ▼ "Loop" ▼
        for(int i = 0; i < verticesCount; i++)
        {
            // ▼ "Check Condition" ▼
            if(!shortPathTreeSet[i] && dist[i] <= min)
            {
                // ▼ "Update" "Variables" ▼
                minIndex = i;
                min = dist[i];
            }
        }
        
        // ▼ "Return Variables" ▼
        return minIndex;
    }
     
    
    // ▬ "DijkstraAlgorithm()" Method ▬
    public static void DijkstraAlgorithm(int[,] graph, int source, int verticesCount)
    {
        // ▬ "Distance" Array ▬
        int[] distance = new int[verticesCount];
        bool[] shortPathTreeSet = new bool[verticesCount];
        
        // ▼ "Loop" ▼
        for (int i = 0; i < verticesCount; i++)
        {
            // ▼ "Update Variables" ▼
            distance[i] = int.MaxValue;
            shortPathTreeSet[i] = false;
        }
        
        // ▼ "Update Variables" ▼
        distance[source] = 0;
        
        // ▼ "Loop" ▼
        for(int count = 0; count < verticesCount; count++)
        {
            // ▼ "Variable" ▼   
            int u = MinimumDistance(distance, shortPathTreeSet, verticesCount);
            
            // ▼ "Set" ▼
            shortPathTreeSet[u] = true;
            
            // ▼ "Inner Loop" ▼
            for (int v = 0; v < verticesCount; v++)
            {
                // ▼ "Check Condition" ▼
                if (!shortPathTreeSet[v] && 
                    Convert.ToBoolean(graph[u, v]) && 
                    distance[u] != int.MaxValue && 
                    distance[u] + graph[u, v] < distance[v])
                {
                    // ▼ "Update Variables" ▼
                    distance[v] = distance[u] + graph[u, v];
                }
            }
        }
        
        // ▬ "Display Results" ▬
        Console.WriteLine("Shortest Distances from 'Source Node' to 'All Other Nodes':");
        for (int i = 0; i < verticesCount; i++)
        {
            Console.WriteLine($" * 'Node {source}' to 'Node {i}': {distance[i]}");
        }
    }

    
    // ▬ "RunDijkstra()" Method ▬
    public static void RunDijkstra()
    {
        // ▼ "Graph" Matrix ▼
        int[,] graph = new int[,]
        {
            {0, 4, 0, 0, 0, 0, 0, 8, 0},
            {4, 0, 8, 0, 0, 0, 0, 11, 0},
            {0, 8, 0, 7, 0, 4, 0, 0, 2},
            {0, 0, 7, 0, 9, 14, 0, 0, 0},
            {0, 0, 0, 9, 0, 10, 0, 0, 0},
            {0, 0, 4, 14, 10, 0, 2, 0, 0},
            {0, 0, 0, 0, 0, 2, 0, 1, 6},
            {8, 11, 0, 0, 0, 0, 1, 0, 7},
            {0, 0, 2, 0, 0, 0, 6, 7, 0}
        };
    
        // ▼ "Source" Node ▼
        int source = 0;

        // ▼ "Run Dijkstra's Algorithm" ▼
        DijkstraAlgorithm(graph, source, graph.GetLength(0));
    }
}