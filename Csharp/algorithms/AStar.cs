/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                          • "ALGORITHMS" •
                    • "SHORTEST PATH ALGORITHMS" •
                    ──────────────────────────────
                         • "A*" ALGORITHM •

       


    ▬ The "A*" Algorithm 
        → is an "Intelligent Method" 
        → of "Finding" 
        → the "Shortest Path" 
        → between "Two Points" 
        → on a "Map" or "Graph". 
        
        
        ♦ It "Uses" 
            → a "Combination" 
            → of Efficient "Breadth-First Search" 
            → and "Heuristics" 
            → to "Guide" the "Search" 
            → to the "Destination". 
        
        
        ♦ By "Using" 
            → a "Priority Queue" 
            → and Constantly "Updating" 
            → the "Estimated Costs", 
            → "A*" - "Quickly Finds" 
            → the "Shortest Path" 
            → and "Reconstructs It" 
            → using the "Information Stored" 
            → in "Each Explored Cell".
    

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Dynamic;

namespace CSharp.algorithms;



//──────────────────────────────────────────────────────────────
// ▬ "Location" Class ▬
public class Location
{
    public int X;
    public int Y;
    
    public int Score1;
    public int Score2;
    public int Score3;
    
    public Location Parent;
}




//──────────────────────────────────────────────────────────────
// ▬ "AStar" Class ▬
public class AStar
{
    // ▬ "GetMovableAdjacentSpots()" Method ▬
    public static List<Location> GetMovableAdjacentSpots(int x, int y, string[] map)
    {
       // ▼ "List" of "Locations"
       //   → to "Move": Forward, Backward, Left, Right ▼ 
       List<Location> proposedLocations = new List<Location>()
       {
           new Location(){ X = x, Y = y - 1 },
           new Location(){ X = x, Y = y + 1 },
           new Location(){ X = x - 1, Y = y },
           new Location(){ X = x + 1, Y = y }
       };
       
       // ▼ "Returning" ▼
       return proposedLocations
           .Where(l => map[l.Y][l.X] == ' ' || map[l.Y][l.X] == 'B').ToList();
    }

    
    
    // ▬ "ComputeSpotHeuristics()" Method ▬
    public static int ComputeSpotHeuristics(int x, int y, int targetX, int targetY)
    {
        // ▼ "Returning" the "Absolute Value" of the "Distance" ▼
        return Math.Abs(targetX-x) + Math.Abs(targetY - y);
    }




    // ▬ "RunAStar()" Method ▬
    public static void RunAStar()
    {
        // ▼ "String Array" ▼
        string[] map = new string[]
        {
            "+----------------+",
            "|A               |", 
            "|xxxxxx          |", 
            "|            xxxx|", 
            "|                |",
            "|xxxxxx     xxxxx|",
            "|               B|",
            "+----------------+"
        };
        
        
        // ▼ "Setting" the "Foreground Color" of the "Console" ▼
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        
        
        // ▼ "Iterating" the "Map" Array ▼
        foreach (var line in map)
        {
            Console.WriteLine(line);
        }
        
        
        // ▼ "Variables" ▼
        Location current = null;
        Location start = new Location(){ X = 1, Y = 1 };
        Location target = new Location(){ X = 16, Y = 6 };  // ◄ "Cells" & "Rows"

        // ▼ "Lists" ▼
        List<Location> openList = new List<Location>();
        List<Location> closeList = new List<Location>();
        
        
        // ▼ "Variable" ▼
        int spot = 0;
        
        
        
        // ▼ "Adding" the "Start" Location to the "Open List" ▼
        openList.Add(start);
        
        
        // ▼ "While" Loop
        //      → "Executed" if 
        //      → the "Open List"
        //      → is "Not Empty" ▼
        while (openList.Count > 0)
        {
            // ▼ "Variables" ▼
            int min = openList.Min(l => l.Score1);
            current = openList.First(l => l.Score1 == min);
            closeList.Add(current);
            
            // ▼ "Setting" the "Position" of the "Cursor" ▼
            Console.SetCursorPosition(current.X, current.Y);
            
            // ▼ "Setting" the "Foreground Color" of the "Console" ▼
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write('.');
            
            
            // ▼ "Setting" the "Position" of the "Cursor" ▼
            Console.SetCursorPosition(current.X, current.Y);
            
            
            // ▼ "Sleeping" the "Console" for "1 Second" ▼
            System.Threading.Thread.Sleep(1000);
            
            // ▼ "Removing" the "Spaces" from the "Console" ▼
            openList.Remove(current);
            
            
            // ▼ "Checking" if the "Target" is in the "Close List" ▼
            if ( closeList.FirstOrDefault(l => l.X == target.X && l.Y == target.Y) != null )
            {
                break;
            }
            
            
            // ▼ "Adding" the "Adjacent" Spots to the "Open List" ▼
            List<Location> adjacentSquares = GetMovableAdjacentSpots(current.X, current.Y, map);
            spot++;
            
            
            // ▼ "Iterating" the "Adjacent Spots" List ▼
            foreach (Location adjacentSquare in adjacentSquares)
            {
                // ▼ "Checking" if the "Spot" is in the "Close List" ▼
                if (closeList.FirstOrDefault( l => l.X == adjacentSquare.X && l.Y == adjacentSquare.Y) != null)
                {
                    continue;
                }
                
                // ▼ "Checking" if the "Spot" is in the "Open List" ▼
                if (openList.FirstOrDefault(l => l.X == adjacentSquare.X && l.Y == adjacentSquare.Y) == null)
                {
                    // ▼ "Setting" the "Scores" of the "Spot" ▼
                    adjacentSquare.Score2 = spot;
                    adjacentSquare.Score3 = ComputeSpotHeuristics(adjacentSquare.X, adjacentSquare.Y, target.X, target.Y);
                    adjacentSquare.Score1 = adjacentSquare.Score2 + adjacentSquare.Score3;
                    
                    // ▼ "Setting" the "Parent" of the "Spot" ▼
                    adjacentSquare.Parent = current;
                    
                    // ▼ "Inserting" the "Spot" into the "Open List" ▼
                    openList.Insert(0, adjacentSquare);
                }
                else
                {
                    // ▼ "Checking" ▼
                    if(spot + adjacentSquare.Score3 < adjacentSquare.Score1) 
                    {
                        // ▼ "Setting" the "Scores" of the "Spot" ▼
                        adjacentSquare.Score2 = spot;
                        adjacentSquare.Score1 = adjacentSquare.Score2 + adjacentSquare.Score3;
                        
                        // ▼ "Setting" the "Parent" of the "Spot" ▼
                        adjacentSquare.Parent = current;
                    }
                }
            } 
        }
        
        
        
        // ▼ "While" Loop 
        //      → "Executed" if
        //      → the "Current" Location
        //      → is "Not Nul" ▼
        while(current != null)
        {
            // ▼ "Setting" the "Position" of the "Cursor" ▼
            Console.SetCursorPosition(current.X, current.Y);
            
            // ▼ Setting the "Foreground Color" of the "Console" ▼
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write('o');
            
            // ▼ "Setting" the "Position" of the "Cursor" ▼
            Console.SetCursorPosition(current.X, current.Y);
            
            // ▼ "Set" the "Parent" of the "Current" Location ▼
            current = current.Parent;
            
            // ▼ "Sleeping" the "Console" for "1 Second" ▼
            System.Threading.Thread.Sleep(1000);
        }
        
        
        // ▼ "Read Line" ▼
        Console.ReadLine();
    }
} 