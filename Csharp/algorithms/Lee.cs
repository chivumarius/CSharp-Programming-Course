/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                         • "ALGORITHMS" •
                    • "SHORTEST PATH ALGORITHMS" •
                    ──────────────────────────────
                         • "LEE" ALGORITHM •

       


    ▬ "Lee" Algorithm 
        → is like "Spreading" 
        → a "Wave" of "Water" 
        → on a "Map" 
        → to "Find" the "Shortest Path" 
        → between "Two Points". 



        ♦ We "Start" 
            → from the "Starting Point" 
            → and "Let" the "Wave" 
            → "Spread" evenly in "All Directions". 



        ♦ As it "Spreads", 
            → the "Water Level Rises", 
            → "Indicating" how "Far" 
            → "Each Location" is 
            → from the "Starting Point". 



        ♦ We "Continue" this "Process" 
            → "Until" the "Wave" 
            → "Reaches" its "Destination" 
            → or "Fills" the "Entire Map". 


        ♦ Then, we "Reconstruct" 
            → the "Shortest Path" 
            → by "Following" 
            → the "Tide Levels" 
            → from the "Destination" 
            → "Back" to the "Starting Point".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;



//──────────────────────────────────────────────────────────────
// ▬ "Node" Class ▬
public class Node
{
    // ▼ "Variables" ▼
    public int x;
    public int y;
    public int distance;
    
    
    // ▼ "Constructor" ▼
    public Node(int x, int y, int distance)
    {
        this.x = x;
        this.y = y;
        this.distance = distance;
    }
}






//──────────────────────────────────────────────────────────────
// ▬ "Lee" Class ▬
public class Lee
{
    private static int[] row = { -1, 0, 0, 1 };
    private static int[] column = { 0, -1, 1, 0 };
    
    
    
    
    // ▬ "IsValid()" Method 
    //   → "Checks" if the "Movement" is "Valid" ▬
    public static bool IsValid(int[][] matrix, bool[][] visited, int row, int col)
    {
        return (row >= 0) && 
               (row < 10) && 
               (col >= 0) && 
               (col < 10) && 
               (matrix[row][col] == 1) && 
               (!visited[row][col]);
    }
    
    
    
    
    // ▬ "LeeAlgorithm()" Method 
    //     → to "Find" the "Shortest Path" ▬
    private static void LeeAlgorithm(int[][] matrix, int i, int j, int x, int y)
    {
        // ▼ "Setting" the "Bool Array" ▼
        bool[][] visited = new bool[10][];
        
        // ▼ "Initializing" the "Bool Array" ▼
        visited[0] = new bool[10];
        visited[1] = new bool[10];
        visited[2] = new bool[10];
        visited[3] = new bool[10];
        visited[4] = new bool[10];
        visited[5] = new bool[10];
        visited[6] = new bool[10];
        visited[7] = new bool[10];
        visited[8] = new bool[10];
        visited[9] = new bool[10];
        
        
        // ▼ "Creating" a"Queue" of "Nodes" ▼
        Queue<Node> queue = new Queue<Node>();
        
        // ▼ "Setting" the "Starting Point" ▼
        visited[i][j] = true;
        queue.Enqueue(new Node(i, j, 0));  
        
        // ▼ "Variable" ▼
        int minimumDistance = int.MaxValue;
        
        
        // ▼ "Traversing" the "Queue" ▼
        while (queue.Count > 0)
        {
            // ▼ "Dequeue" the "Node" from the "Queue" ▼
            Node node = queue.Dequeue();
            
            // ▼ "Setting" the "Variables" ▼
            i = node.x;
            j = node.y;
            int dist = node.distance;
            
            
            // ▼ "Checking" ▼
            if (i == x && j == y)
            {
               minimumDistance = dist; 
               break;
            }
            
            
            // ▼ "Traversing" the "Matrix" ▼
            for (int k = 0; k < 4; k++)
            {
                // ▼ "Checking" if the "Movement" is "Valid" ▼
                if(IsValid(matrix, visited, i + row[k], j + column[k]))
                {
                    // ▼ "Setting" the "Variables" ▼
                    visited[i + row[k]][j + column[k]] = true;
                    
                    // ▼ "Enqueue" the "Node" into the "Queue" ▼
                    queue.Enqueue(new Node(i + row[k], j + column[k], dist + 1));
                }
            }
        }
        
        
        // ▼ "Checking" if the "Minimum Distance" is "Valid" ▼
        if(minimumDistance != int.MaxValue)
        {
            Console.WriteLine("The 'Shortest Path' from 'Source' to 'Destination' has the 'Length': " + minimumDistance);
        }
        else
        {
            Console.WriteLine("The 'Destination' can't be 'Reached' from the 'Given Source'!");
        }
    }
        
        
        
        
    
    // ▬ "RunLee()" Method ▬
    public static void RunLee()
    {
        // ▼ "Int Matrix" ▼
        int[][] mat = new int[10][];
        
        // ▼ "Initializing" the "Int Matrix" ▼
        mat[0] = new int[10] { 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        mat[1] = new int[10] { 0, 1, 1, 1, 1, 1, 0, 1, 0, 1 };
        mat[2] = new int[10] { 0, 0, 1, 0, 1, 1, 1, 0, 0, 1 };
        mat[3] = new int[10] { 1, 0, 1, 1, 1, 0, 1, 1, 0, 1 };
        mat[4] = new int[10] { 0, 0, 0, 1, 0, 0, 0, 1, 0, 1 };
        mat[5] = new int[10] { 1, 0, 1, 1, 1, 0, 0, 1, 1, 0 };
        mat[6] = new int[10] { 0, 0, 0, 0, 1, 0, 0, 1, 0, 1 };
        mat[7] = new int[10] { 0, 1, 1, 1, 1, 1, 1, 1, 0, 0 };
        mat[8] = new int[10] { 1, 1, 1, 1, 1, 0, 0, 1, 1, 1 };
        mat[9] = new int[10] { 0, 0, 1, 0, 0, 1, 1, 0, 0, 1 };
        
        
        
        // ▼ "Method Call" ▼
        LeeAlgorithm(mat, 0, 0, 6, 4);
           
    }
} 