/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                    • "AGGREGATE()" & "COUNT()" METHODS •

       


    ▬ "Aggregate()" Method in "LINQ"
        → is "Used" to "Apply" 
        → a "Specified Function" 
        → to "Each Element" of a "Sequence", 
        → "Reducing" the "Sequence" 
        → to a "Single Value". 
        
        
        ♦ It "Receives" 
            → an "Initial Value" 
            → and an "Aggregation Function". 
        
        
        ♦ The "Aggregation Function" 
            → is "Applied Sequentially" 
            → to "Each Element" 
            → in the "Sequence", 
            → "Along" with the "Value Accumulated" 
            → "Up" to that "Point". 
        
        
        ♦ The Final Result 
            → is the "Accumulated Value" 
            → "After" the "Aggregation Function" 
            → has been "Applied" 
            → to "All Elements" 
            → in the "Sequence". 
        
        
        ♦ The "Aggregate()" Method is "Useful" 
            → for Performing "Custom Aggregation Operations" 
            → on a "Sequence", 
            → such as: 
                •► "Calculating" the "Sum", 
                •► "Product" 
            ► or Other C"omplex Operations".
        


    ▬ "Count()" Method in "LINQ"
        → is "Used" to "Count" 
        → the "Number" of "Elements" 
        → in a "Sequence" 
        → that "Meet" a G"iven Condition". 
        
        
        ♦ It can be "Used" 
            → "Without Parameters" 
            → to "Count" the "Total Number" 
            → of "Elements" in a "Sequence" 
            → or "It" can be "Given" 
            → a "Predicate" to "Count" 
            → "Only" the "Elements" 
            → that "Satisfy" 
            → the "Specified Condition". 
        
        
        ♦ The "Result" 
            → "Returned" by "Count()" Method 
            → is an "Integer" 
            → representing the "Number" of "Elements" 
            → in the "Sequence" 
            → that "Satisfy" 
            → the "Given Condition". 
        
        
        
        ♦ The "Count()" Method is "Useful" 
            → for "Determining" 
            → the "Size"  of a "Sequence" 
            → or for "Counting Elements" 
            → that M"eet Certain Criteria".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "LINQ" Class ▬
public class AggregateAndCount
{
    
    // ▬ "RunAggregateAndCount()" Method ▬
    public static void RunAggregateAndCount()
    {
        // ▼ Create a "List" of "Integers" ▼
        List<int> integers = new List<int> { 2, 4, 6, 8 };
        
        
        //------------------- "AGGREGATE()" --------------------------------
        // ▼ "Aggregate()" Method ▼
        int total = integers.Aggregate((int int1, int int2) => int1 + int2);
        
        // ▼ "Display" the "Result" ▼
        Console.WriteLine("Aggregate() Method → to 'Get' the 'Sum' of 'List Elements': " + total);
        
        
        
        //------------------- "COUNT()" --------------------------------
        // ▼ "Count()" Method ▼
        int count = integers.Count();
        
        // ▼ "Display" the "Result" ▼
        Console.WriteLine("Count() Method → to 'Get' the 'Number of Elements' in 'List': " + count);
    }
} 