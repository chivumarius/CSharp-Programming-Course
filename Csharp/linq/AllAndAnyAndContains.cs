/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                 • "ALL()", "ANY()" & "CONTAINS()" METHODS •

       


    ▬ "All()" Method in "LINQ"
        → is "Used" to "Check" 
        → whether "All Elements" 
        → in a "Sequence" 
        → "Satisfy" a "Certain Condition" 
        → "Specified" by a "Predicate". 
    
    
    
        ♦ "It" Returns
            •► "True" 
                → if "All Elements" 
                → "Satisfy" the "Condition" and 
            •► "False' 
                → Otherwise. 
        
        
        ♦ "It" is "Useful" 
            → for "Validating All Elements" 
            → in a "Sequence" 
            → "Against" a "Certain Criterion".



    
    ▬ "Any()" Method in "LINQ"
        → is "Used" to "Check" 
        → if a "Sequence" 
        → "Contains" at "Least One Element" 
        → that "Satisfies" a "Certain Condition" 
        → "Specified" by a "Predicate". 
        
        
        ♦ It "Returns" 
            •► "True" 
                → if at "Least One Element" 
                → "Satisfies" the "Condition" and 
            •► "False"
                → Otherwise. 
        
        
        ♦ "It" is "Useful" 
            → for "Determining" 
            → whether "There" is at "Least One Element" 
            → in a "Sequence" 
            → that "Satisfies Certain Criteria".




    ▬ "Contains()" Method in "LINQ"
        → is "Used" to "Check" 
        → whether a "Sequence" 
        → "Contains" a "Specified Element". 
        
        
        ♦ It "Returns" 
            •► "True" 
                → if the "Sequence" 
                → "Contains" the "Element" and 
            •► "False"
                → Otherwise. 
        
        
        
        ♦ This "Method" is "Useful" 
            → for "Checking" 
            → for the "Existence" 
            → of an "Element" 
            → in a "Sequence" 
            → "Without Having" to "Manually Loop" 
            → through "Each Element" 
            → of the "Sequence".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "AllAndAnyAndContains" Class ▬
public class AllAndAnyAndContains
{
    // ▼ Creating a "List" of "Integers" ▼
    static List<int> collection = new List<int>(){ 1, 2, 3, 4, 5 };
    
    
    // ▬ "RunAllAndAnyAndContains()" Method ▬
    public static void RunAllAndAnyAndContains()
    {
        //----------------- "ALL()" -------------------
        // ▼ "All()" Method ▼
        Console.WriteLine("All() Method -> to Check if 'All Elements' are 'Greater' than '0': " + collection.All(x => x > 0));
        
        
        //----------------- "ANY()" -------------------
        // ▼ "Any()" Method ▼
        Console.WriteLine("Any() Method -> to Check if 'Any Element' is 'Greater' than '6': " + collection.Any(x => x > 6));
        
        
        //----------------- "CONTAINS()" -------------------
        // ▼ "Contains()" Method ▼
        Console.WriteLine("Contains() Method -> to Check if the 'Collection Contains' the 'Element 3': " + collection.Contains(3));
    }
} 