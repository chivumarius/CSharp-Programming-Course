/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                              • "ALGORITHMS" •
                    • "MINIMUM SPANNING TREE ALGORITHMS" •
                    ──────────────────────────────────────
                          • "KRUSKAL" ALGORITHM •

       


    ▬ "Kruskal" Algorithm 
        → "Finds" the "Smallest Spanning Tree" 
        → in a "Weighted Graph" 
        → by "Sorting" and "Adding Edges" 
        → in "Increasing Order" of "Weights", 
        → "Avoiding" the "Formation" 
        → of "Cycles". 



        ♦ It is "Efficient" and "Useful" 
            → in "Designing Networks", 
            → having a 
                •► "Time Complexity" of "\(O(E \log E)\)", 
            → where "\(E\)" 
            → is the "Number" of "Edges".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "Edge" Class ▬
public class Edge
{
    public int Source;
    public int Destination;
    public int Weight;
}



//──────────────────────────────────────────────────────────────
// ▬ "Graph" Class ▬
public class Graph
{
    public int NumberOfVertices;
    public int NumberOfEdges;
    public Edge[] Edges;
}



//──────────────────────────────────────────────────────────────
// ▬ "Subset" Class ▬
public class Subset
{
    public int Parent;
    public int Rank;
}



//──────────────────────────────────────────────────────────────
// ▬ "Kruskal" Class ▬
public class Kruskal
{
    // ▬ "Find()" Method ▬
    private static int Find(Subset[] subsets, int i)
    {
        // ▼ "Checking" ▼
        if (subsets[i].Parent != i)
        {
            // ▼ "Recursion Call" ▼
            subsets[i].Parent = Find(subsets, subsets[i].Parent);
        }
        
        // ▼ "Returning" ▼
        return subsets[i].Parent;
    }
    
    
    
    // ▬ "Union()" Method ▬
    private static void Union(Subset[] subsets, int x, int y)
    {
        // ▼ "Checking Variables" ▼
        int xRoot = Find(subsets, x);
        int yRoot = Find(subsets, y);
        
        // ▼ "Checking Rank" ▼
        if (subsets[xRoot].Rank < subsets[yRoot].Rank)
        {
            // ▼ "Set" ▼
            subsets[xRoot].Parent = yRoot;
        }
        else if (subsets[xRoot].Rank > subsets[yRoot].Rank)
        {
            // ▼ "Set" ▼
            subsets[yRoot].Parent = xRoot;
        }
        else
        {
            // ▼ "Set" ▼
            subsets[yRoot].Parent = xRoot;
            subsets[xRoot].Rank++;
        }
    }
    
    
    
    
    // ▬ "KruskalAlgorithm()" Method ▬
    public static void KruskalAlgorithm(Graph graph)
    {
        // ▼ Create "Subsets" ▼
        Subset[] subsets = new Subset[graph.NumberOfVertices];
        for (int i = 0; i < graph.NumberOfVertices; i++)
        {
            subsets[i] = new Subset();
            subsets[i].Parent = i;
            subsets[i].Rank = 0;
        }

        // ▼ "Object" from "Array" ▼
        Edge[] result = new Edge[graph.NumberOfVertices];
    
        // ▼ "Variables" ▼
        int nodeIndex = 0;
        int edgeIndex = 0;
    
        // ▼ (1) Step 1: "Sorting Edges"
        //        → in "Ascending Order"
        //        → "Based" on their "Weights" ▼
        Array.Sort(graph.Edges, delegate(Edge a, Edge b)
        {
            return a.Weight.CompareTo(b.Weight);
        });
    
        // ▼ (2) Step 2: "Traverse" "Edges"
        while (edgeIndex < graph.NumberOfVertices - 1)
        {
            // ▼ "Create" an "Edge" ▼
            Edge nextEdge = graph.Edges[nodeIndex++];

            // ▼ "Set" ▼
            int x = Find(subsets, nextEdge.Source);
            int y = Find(subsets, nextEdge.Destination);

            // ▼ "Checking" ▼
            if (x != y)
            {
                // ▼ "Set" ▼
                result[edgeIndex++] = nextEdge;

                // ▼ "Method Call" ▼
                Union(subsets, x, y);
            }
        }
    }
    
    
    
    
    // ▬ "RunKruskal()" Method ▬
    public static void RunKruskal()
    {
        // Initialize the graph and edges
        Graph graph = new Graph
        {
            NumberOfVertices = 4, // Set the number of vertices in the graph
            NumberOfEdges = 5, // Set the number of edges in the graph
            Edges = new Edge[]
            {
                new Edge { Source = 0, Destination = 1, Weight = 10 },
                new Edge { Source = 0, Destination = 2, Weight = 6 },
                new Edge { Source = 0, Destination = 3, Weight = 5 },
                new Edge { Source = 1, Destination = 3, Weight = 15 },
                new Edge { Source = 2, Destination = 3, Weight = 4 }
            }
        };

        // Call the Kruskal algorithm to find the minimum spanning tree
        KruskalAlgorithm(graph);

        // Display the edges of the minimum spanning tree
        Console.WriteLine("Edges of the 'Minimum Spanning Tree' - 'Found' by 'Kruskal's Algorithm':");
        for (int i = 0; i < graph.NumberOfVertices - 1; i++)
        {
            if (graph.Edges[i] != null)
            {
                Console.WriteLine($" * Edge {graph.Edges[i].Source} - {graph.Edges[i].Destination}, Weight: {graph.Edges[i].Weight}");
            }
        }
    }
} 