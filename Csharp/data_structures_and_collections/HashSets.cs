/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "HASH SETS" •

       

    ▬  A "Set" Data Structure
        → that Exist in "Java" and "Python",
        → is an "Unordered Collection" 
        → of "Unique Items",
        → with does "Not Contain/Allow Duplicates".
        
        ♦ "C#" 
            → does "Not Support/Contain" 
            → "Sets".
      
      
      
    ▬ "HashSet"  
        → Combines a "Set" Concept
        → with a "Dictionary" Concept 
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class HashSets
{
    
    
    
    // ▬ "RunStacks()" Method ▬
    public static void RunHashSets()
    {
        // ▼ "Create" two "Objects/Instances" of the "HashSet" Class ▼
        HashSet<string> letters1 = new HashSet<string>() { "a", "b", "c" };
        HashSet<string> letters2 = new HashSet<string>() { "d", "e", "f", "a", "b" };

        
        
        // ▼ "Getting All Elements" from the "2 HashSet" ▼
        Console.WriteLine("\nGetting All Elements from the 2 HashSets: ");

        // ▼ Create a "New Set"
        //      → for the "Union"
        //      → of "letters1" and "letters2" ▼
        HashSet<string> unionSet = new HashSet<string>(letters1);

        // ▼ "Add All Elements"
        //      → from "letters2" to the "unionSet" ▼
        unionSet.UnionWith(letters2);

        // ▼ "Display All Elements" in the "UnionSet" ▼
        foreach (string letter in unionSet)
        {
            Console.WriteLine(letter);
        }

        
        
        
        // ▼ "Getting" the "Common Elements" from the "2 HashSets" ▼
        Console.WriteLine("\n Getting the Common Elements from the 2 HashSets: ");

        // ▼ "Create" a "New Set"
        //      → "Containing" the "Intersection"
        //      → of "letters1" and "letters2" ▼
        HashSet<string> commonElements = new HashSet<string>(letters1);
        commonElements.IntersectWith(letters2);

        // ▼ "Display" the "Common Elements" ▼
        foreach (string letter in commonElements)
        {
            Console.WriteLine(letter);
        }
        
        
        
        
        
        // ▼ "Getting" the "Common Elements" from the "2 HashSets" ▼
        Console.WriteLine("\nGetting the Difference Elements that are in letters1: ");

        // ▼ Create a "New Set"
        //      → "Containing" the "Difference"
        //      → of "letters1" and "letters2"
        HashSet<string> differenceElements = new HashSet<string>(letters1);
        differenceElements.ExceptWith(letters2);

        // ▼ "Display" the "Difference Elements" ▼
        foreach (string letter in differenceElements)
        {
            Console.WriteLine(letter);
        }
        
        
        
        
        
        // ▼ "Getting" the "Difference Elements" from the "2 HashSets" ▼
        Console.WriteLine("\n Getting the Difference Elements that are in letters2: ");

        // ▼ "Create" a "New Set"
        //      → "Containing" the "Difference"
        //      → of "letters2" and "letters1" ▼
        HashSet<string> differenceElements2 = new HashSet<string>(letters2);
        differenceElements2.ExceptWith(letters1);

        // ▼ "Display" the "Difference Elements" ▼
        foreach (string letter in differenceElements2)
        {
            Console.WriteLine(letter);
        }
        
    }
}