/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                         • "ALGORITHMS" •
                    • "SHORTEST PATH ALGORITHMS" •
                    ──────────────────────────────
                    • "FLOYD" - "WARSHALL" ALGORITHM •

       


    ▬ "Floyd-Warshall" Algorithm 
        → Finds the "Shortest Distances" 
        → between "All Pairs" of "Nodes" 
        → in a "Graph" 
        → Without "Negative Cycles". 



        ♦ It "Uses" 
            → an "Iterative Approach" 
            → to "Update" and "Calculate" 
            → the "Minimum Distances" b
            → etween "Nodes", 
            → using "All Other Nodes" 
            → as "Possible Intermediates". 



        ♦ Its "Advantage" 
            → is that it can be "Applied" 
            → to "Graphs" 
            → with "Positive" or "Negative Weights", 
            → but it does "Not Have" 
            → "Negative Cycles".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "FloydWarshall" Class ▬
public class FloydWarshall
{
    // ▬ "FloydWarshallAlgorithm()" Method
    //      → to Find the Shortest Distances
    //      → between "All Pairs" of "Nodes" ▬
    public static void FloydWarshallAlgorithm(int[,] graph, int verticesCount)
    {
        // ▼ "Array" ▼
        int[,] distance = new int[verticesCount, verticesCount];
        
        // ▼ "Outer Loop"  → for "All Nodes" ▼
        for (int i = 0; i < verticesCount; i++)
        {
            // ▼ "Inner Loop" ▼
            for (int j = 0; j < verticesCount; j++)
            {
                // ▼ "Set" ▼
                distance[i, j] = graph[i, j];
            }
        }
        
        
        // ▼ "Outer Loop" ▼
        for (int k = 0; k < verticesCount; k++)
        {
            // ▼ "Inner Loop" ▼
            for (int i = 0; i < verticesCount; i++)
            {
                // ▼ "Inner Inner Loop" ▼
                for (int j = 0; j < verticesCount; j++)
                {
                    // ▼ "Update" ▼
                    if (distance[i, k] + distance[k, j] < distance[i, j])
                    {
                        // ▼ "Set" ▼
                        distance[i, j] = distance[i, k] + distance[k, j];
                    }
                }
            }
        }
    }





    // ▬ "RunFloydWarshall()" Method ▬
    public static void RunFloydWarshall()
    {
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

        int verticesCount = 9; // ◄ "Change" this "Value" with the "Actual Number" of "Nodes" in the "Graph" ◄

        // ▼ "Call" the "Method" ▼
        FloydWarshallAlgorithm(graph, verticesCount);

        
        // ▼ "Display" the "Resulting Matrix" ▼
        Console.WriteLine("The 'Resulting Matrix' of 'Shortest Distances' between 'All Pairs' of 'Nodes':");
        
        // ▼ "Iteration" ▼
        for (int i = 0; i < verticesCount; i++)
        {
            for (int j = 0; j < verticesCount; j++)
            {
                Console.Write($"  {graph[i, j]} ");
            }
            
            Console.WriteLine();
        }
    }
} 