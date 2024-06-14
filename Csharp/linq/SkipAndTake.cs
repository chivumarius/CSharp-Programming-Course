/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                       • "SKIP()" & "TALE()" METHODS •

       


    ▬ "Skip()" in "LINQ"
        → is "Used" to "Skip" 
        → a "Specified Number" of "Elements" 
        → in a "Sequence" 
        → and "Return" 
        → the "Rest" of the "Elements". 
        
        
        ♦ This "Method" is "Useful" 
            → when we "Want" to "Start Working" 
            → with the "Elements" 
            → in the "Sequence" 
            → "Starting" from a "Specific Position" 
            → or "Index". 
        
        
        ♦ For "Example" 
            → if we "Have" a "List" 
            → of "Elements" 
            → and "Want" to "Start Working" 
            → with the "Elements" 
            → from the "Third Element Forward", 
            → we can "Use" the
                •► "Skip(2)" Method 
            → to "Skip" the "First Two Elements" 
            → and "Start" with the "Third Element".



    ▬ "Take()" Method in "LINQ"
        → is "Used" 
        → to "Select" a "Specified Number" 
        → of "Elements" 
        → from a "Sequence" 
        → and "Return Them". 
        
        
        ♦ This "Method" is "Useful" 
            → when we "Want" to "Extract" 
            → a "Certain Amount" 
            → of "Data" 
            → from a "Sequence". 
        
        
        ♦ For "Example" 
            →if we have a "List" of "Elements" 
            → and "Want" to "Select" 
            → the "First Three Elements", 
            → we can "Use" the
                •► "Take(3)" Method 
            → to "Extract" 
            → those "Three Elements" 
            → and "Return Them".
        
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "SkipAndTake" Class ▬
public class SkipAndTake
{
    // ▼ Creating a "List" of "Integers" ▼
    static List<int> collection1 = new List<int>(){ 1, 2, 3, 4, 5 };

    
    
    
    // ▬ "RunSkipAndTake()" Method ▬
    public static void RunSkipAndTake()
    {
        //----------------- "SKIP()" -------------------
        Console.Write("Skip() Method → to 'Skip' the 'First Two Elements' of the 'List': "); 
        
        // ▼ "Skip()" Method ▼
        IEnumerable<int> collection2 = collection1.Skip(2);
        
        // ▼ "Iterating" the "Collection" ▼
        foreach (var item in collection2)
        {
            Console.Write(item + ", ");
        }
        
        
        Console.WriteLine();
        
        
        
        //----------------- "TAKE()" -------------------
        Console.Write("Take() Method → to 'Select' the 'First Three Elements' of the 'List': ");
        
        // ▼ "Take()" Method ▼
        IEnumerable<int> collection3 = collection1.Take(3);
        
        // ▼ "Iterating" the "Collection" ▼
        foreach (var item in collection3)
        {
            Console.Write(item + ", ");
        }
        
        
        Console.WriteLine();
    }   
} 