/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                          • "CONCAT()" METHOD •

       


    ▬ "Concat()" Method in "LINQ"
        → is "Used" to "Concatenate Two Sequences" 
        → into a "Single Sequence". 
        
        
        ♦ It "Returns" 
            → a "New Sequence" 
            → Containing "All" the "Elements" 
            → of the "First Sequence" 
            → followed by "All" the "Elements" 
            → of the "Second Sequence".


        ♦ It is "Useful" 
            → when there is a "Need" 
            → to "Combine" the "Contents" 
            → of "Two Collections" 
            → or "Sequences" 
            → into a "Single Sequence" 
            → "Without Changing" the "Original Collections". 

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "Concat" Class ▬
public class Concat
{
    
    // ▬ "RunConcat()" Method ▬
    public static void RunConcat()
    {
        // ▼ Create "2 Lists" od "Strings" ▼
        List<string> letters1 = new List<string> { "a", "b", "c" };
        List<string> names2 = new List<string> { "d", "e", "f" };
        
        
        //------------------ "CONCAT()" --------------------
        Console.Write("Concat() Method -> to 'Concatenate' - 'List 1' and 'List 2': ");
        
        // ▼ "Concat()" Method ▼
        IEnumerable<string> letters3 = letters1.Concat(names2);
        
        // ▼ "Iterate" over "List" "letters3" ▼
        foreach (string item in letters3)
        {
            Console.Write(item + ", ");
        }
        
        Console.WriteLine();
    }
} 