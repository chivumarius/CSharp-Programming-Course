/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                 • "SELECT()" & "SELECT MANY()" METHODS •

       


    ▬ "Select()" Method in "LINQ"
        → is "Used" 
        → to "Apply" a "Transformation" 
        → to "Each Element" 
        → in a "Sequence" 
        → and to "Get" a "New Sequence" 
        → with the "Results" 
        → of the "Transformation". 
    
    
    
    ▬ It "Takes" a "Function" 
        → that "Describes" the "Transformation" 
        → and "Returns" a "New Sequence" 
        → containing its "Results". 




    ▬ "SelectMany()" Method in "LINQ"
        → is "Used" in "LINQ" 
        → to "Design" and "Flatten" 
        → a "Sequence" of "Collections" 
        → into a "Single Sequence". 
    
    
    
    ▬ It "Receives" 
        → a "Function" 
        → that "Transforms" Each "Element" 
        → of the "Sequence" 
        → into "Another Sequence" 
        → and then "Combines" 
        → "All" these "Sequences" 
        → into a "Single Resulting Sequence". 
    
    
    
    
    ▬ "SelectMany()" Method 
        → is "Useful" 
        → when we are "Working" 
        → with "Collections" 
        → of "Collections" 
        → and "Want" to "Get" 
        → a "Single Flattened Collection" 
        → with "All Elements".
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "SelectAndSelectMany" Class ▬
public class SelectAndSelectMany
{
    
    // ▬ "RunSelectAndSelectMany()" Method ▬
    public static void RunSelectAndSelectMany()
    {
        //================== "SELECT()" METHOD ===========================
        // ▼ "Creating" a "List" of "Integers" ▼
        List<int> collection = new List<int> { 1, 2, 3, 4, 5 };

        //--------------------- "SELECT" METHOD -------------------------
        // ▼ "Creating" an "IEnumerable" of "Integers" ▼
        IEnumerable<int> intMultiplyByTwo = collection.Select(s => s *2);
        
        
        // ▼ "Printing" the "IEnumerable" of "Integers" ▼
        Console.Write("Select() Method -> to Select and Multiply the List Items by Two: ");
        foreach (int item in intMultiplyByTwo)
        {
            Console.Write(item + " ");
        }
        
        
        Console.WriteLine();
        
        
        
        
        //================== S"ELECT MANY()" METHOD ===========================
        // ▼ "Creating" a "List" of "List" of "Integers" ▼
        List<List<int>> listOfLists = new List<List<int>>()
        {
            new List<int> { 1, 2, 3 },
            new List<int> { 4, 5, 6 },
            new List<int> { 7, 8, 9 }
        };

 
        //--------------------- "SELECT MANY()" METHOD -------------------------
        // ▼ "SelectMany()" Method
        //      → to "Get Each Element"
        //      → from "Each" of the "List"
        //      → and Added to "IEnumerable Result" ▼
        IEnumerable<int> result = listOfLists.SelectMany(list => list);
        
        
        // ▼ "Count" the "IEnumerable" of "Integers" ▼
        Console.Write("\nSelectMany() Method -> to Select All the List Items from the Sub-Lists: ");
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }
        
        //▼ "Count" the "IEnumerable" of "Integers" ▼
        Console.WriteLine("\nCount the Elements: " + result.Count());
        
        Console.WriteLine();
        
    }
} 