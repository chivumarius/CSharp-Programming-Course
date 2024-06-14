/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "GRAPHS" •

       

    ▬  A "Graph"
        → is a "Collection" 
        → of "Interconnected Nodes"       
        
        
        ♦ It is 
            → a "Pair" 
            → of "Sets (V, E)"
                •► "V" = "Vertices" (are "Points")
                •► "E" = "Edges" (are "Links").
        
    
        ♦ "Two Nodes"
            → are "Adjacent" 
            → if "They" are "Connected"
            → by an "Edge".
        
        
        ♦ A "Path" 
            → is a "Sequence" 
            → of "Edges" between 
            → "Two Vertices".
     
        ♦ They
            → have No Concept 
            → of the "Root Node",
            → "Parent" or "Children".
     
     ▬ The "Basic Operations" that can Be Performed on a "Graph":
        → "Adding" a "Vertex" 
        → "Adding" an "Edge" 
        → "Display" an "Edge".
     
     
     ▬ "All Trees"
        → are "Graphs",
        → a "Tree" 
        → is a "Special Case" 
        → of "Graph".
     
    
    
     ▬ "Types" of "Graphs" can be 
        1. "Directed"
            → in which the "Edges"
            → have a "Direction",
            → an "Arrow"
            → at yhe "End",
            → to "Show"
            → which "Way" 
            → they "Point".
            
            
        2. "Undirected"
            → in which the "Edges"
            → do not "Show Direction".
            
            
        3. "Weighted"
            → in which the "Edges"
            → Contain "Numeric Value" signifying 
            → the "Weight".
            
            
            
        4. "Unweighted"
            → in which the "Edges"
            → do "Not Contain" 
            → a "Numeric Value".
        
        
        5. "Cyclic"
            → in which "There Is"
            → "One Cycle"
            → in the "Graph".
            
            
        6. "Acyclic"
            → do "Not Contain" 
            → "Cycles".
            
            
        7. "Sparse"
            → are those "Graphs" 
            → where the "Number" of "Edges" 
            → is "Small" compared
            → to the T"otal Possible Number" 
            → of "Edges", 
            → meaning that "Most Nodes" 
            → are "Not Connected" 
            → or have "Only" a "Few Connections" 
            → between "Them".
            
            
        8. "Dense"
            → have a "Large Number" 
            → of "Edges" compared 
            → to the "Total Possible Number"
            → of "Edges".  
  
  
  
    ▬ "Graphs" 
        → can be "Represented" as
            1. "Adjacency Lists" 
            2. "Matrix"
  
  
        1. "Graphs" as A "Adjacency Lists":
            ♦ "Graph"
                → has a "List" 
                → of "Its Nodes".
            
            
            ♦ "Each Nodes"
                → has a "List" 
                → of "Iys Neighbors".
                
                
            ♦ With an "UnDirected Graphs"
                → there is "Duplicate Edge Information".
                
            ♦ "Each Node" 
                → has "Precisely" 
                → as "Many Nodes" 
                → in "Its Adjacency List"
                → as It has "Neighbors".   
     
      
      
      
        
        2. "Graphs" as a "Matrix":
            
            ♦ For a "Graph" with "n Nodes", 
                → it is a "2D Array Size" 
                    •► "n xn"
            
            
            ♦ For a "Weighted Graph", 
                → the "Array Element" 
                    •► "a[n][n]" 
                → could "Store Weight".
            
            
            ♦ For Non Weighted Graph 
                    •► "a[n][n]" 
                → could "Store True" 
                → if "Edge" between "Nodes", 
                → "False" Otherwise
            
            
            ♦ "Determining" 
                → if an "Edge Exists" 
                → between "Nodes" 
                → Simply an "Array" lookup 
                    •► O(1) 
                → "Constant Time".
            
            
            ♦ "Downside" of "Adjacency Matrix" 
                → "Space Inefficient" 
                → an "Adjacency Matrix" 
                → requires an "n2 Element Array", 
                → so for "Sparse Graphs" 
                → much of the "Adjacency Matrix" 
                → will be "Empty".
            
            
            ♦ For "UnDirected Graphs" 
                → "Half" the "Graph Information" 
                → is just "Repeated Information".


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;


// ▬▬ Custom "Node" Class ▬▬
public class Node
{
    // ▼ "Property" ▼
    public List<Node> Neighbors { get; set; } // Changed object to Node
    
    // ▼ "Field" ▼
    public int Data;
    
    // ▬ "Constructor" ▬
    public Node(int data)
    {
        Data = data;
        Neighbors = new List<Node>(); // Initialize Neighbors list
    }
}





// ▬▬ "Graphs" Class ▬▬
public class Graphs
{

    // ▼ "Properties" ▼
    public int NumberOfVertices { get; set; }
    public List<Node> Vertices { get; set; }
    
    // ▬ "Constructor" ▬
    public Graphs(int size)
    {
        NumberOfVertices = size;
        Vertices = new List<Node>();
        
        // ▼ "Initializing" a "Node"
        //      → for "Each Item"
        //      → in the "Vertices List" ▼
        for(int i = 0; i < NumberOfVertices; i++)
        {
            Vertices.Add(new Node(i)); // Initialize Node with data
        }
    }
    
    // ▬ "AddEdge()" Method ▬
    public void AddEdge(Node source, Node destination)
    {
        // ▼ "Adding" a "Node"
        //      → to the "List" ▼
        source.Neighbors.Add(destination);
        destination.Neighbors.Add(source);
    }
    
    
    
    // ▬ "RemoveEdge()" Method ▬
    public void RemoveEdge(Node source, Node destination)
    {
        // ▼ "Removing" a "Node"
        //      → from the "List" ▼
        source.Neighbors.Remove(destination);
        destination.Neighbors.Remove(source);
    }
    
    
    
    
    // ▬ "IsAdjacent()" Method
    //      → which will "Check" if an "Edge Exists"
    //      → between "Two Nodes" ▬
    public bool IsAdjacent(Node node1, Node node2)
    {
        return node1.Neighbors.Contains(node2);
    }
    
    
    
    // ▬ "RunGraphs()" Method ▬
    public static void RunGraphs()
    {
        // ▼ Creating "6 Nodes" ▼
        Node one = new Node(1);
        Node two = new Node(2);
        Node three = new Node(3);
        Node four = new Node(4);
        Node five = new Node(5);
        Node six = new Node(6);
    
    
        // ▼ "Creating" a "Graph" ▼
        Graphs graph = new Graphs(6);
    
    
        // ▼ "Adding" - "Edges" ▼
        graph.AddEdge(one, two);
        graph.AddEdge(two, three);
        graph.AddEdge(three, four);
        graph.AddEdge(four, five);
        graph.AddEdge(five, six);
        graph.AddEdge(six, one);
    
    
        // ▼ "Console Display" ▼
        Console.WriteLine("\nGraph Created Successfully!");
        Console.WriteLine("Number of  (Nodes): " + graph.NumberOfVertices);
        Console.WriteLine("Number of Edges: " + graph.Vertices.Sum(node => node.Neighbors.Count));
    }
}





// ▬▬ "GraphWithAdjacencyMatrix" Class ▬▬
public class GraphWithAdjacencyMatrix
{
    // ▼ "Variable" ▼
    bool[,] adjacencyMatrix;
       
    // ▼ "Property" ▼
    int NumberOfVertices{ get; set; }
    
    
    
    
    // ▬ "Constructor" ▬
    public GraphWithAdjacencyMatrix(int size)
    {
        NumberOfVertices = size;
        adjacencyMatrix = new bool[size, size];
    }
    
    
    
    // ▬ "AddEdge()" Method ▬
    public void AddEdge(int i, int j)
    {
        adjacencyMatrix[i, j] = true;
        adjacencyMatrix[j, i] = true;
    }
    
    
    // ▬ "RemoveEdge()" Method ▬
    public void RemoveEdge(int i, int j)
    {
        adjacencyMatrix[i, j] = false;
        adjacencyMatrix[j, i] = false;
    }
    
    
    
    // ▬ "IsAdjacent2()" Method ▬
    public bool IsAdjacent(int i, int j)
    {
        return adjacencyMatrix[i, j];
    }
    
    
    
    // ▬ "RunGraphWithAdjacencyMatrix()" Method ▬
    public static void RunGraphWithAdjacencyMatrix()
    {
        // ▼ Creating a graph ▼
        GraphWithAdjacencyMatrix graph = new GraphWithAdjacencyMatrix(6);

        // ▼ Adding edges ▼
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(3, 5);

        // ▼ Displaying the adjacency matrix ▼
        Console.WriteLine("Adjacency Matrix:");
        for (int i = 0; i < graph.NumberOfVertices; i++)
        {
            for (int j = 0; j < graph.NumberOfVertices; j++)
            {
                Console.Write(graph.adjacencyMatrix[i, j] ? "1 " : "0 ");
            }
            Console.WriteLine();
        }
    }
}
    