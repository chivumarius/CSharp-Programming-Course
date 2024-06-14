/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                    • "OF TYPE()" & "WHERE()" METHODS •

       


    ▬ "OfType()" Method in "LINQ"
        → is "Used" to "Filter" 
        → the "Elements" 
        → of a "Sequence" 
        → to "Those" 
        → that are of a "Specific Type" 
        → or "SubType". 


        ♦ It "Takes" 
            → a "Sequence" of "Objects" 
            → and "Returns" a "Sequence" 
            → "Containing Only" the "Elements" 
            → of the "Specified Type". 


    ▬ "OfType()" Method
        → is "Useful" 
        → when "Working" with "Heterogeneous Collections" 
        → and "Want" to "Extract" 
        → Only "Certain Types" 
        → of "Objects".





    ▬ "Where()" Method in "LINQ"
        → is "Used" to "Filter" 
        → the "Elements" of a "Sequence" 
        → "Based" on "Some Specified Condition". 



    ▬ "Where()" Method 
        → "Receives" a "Sequence" of "Elements" 
        → and a "Function" 
        → ("Expressed" as a "Lambda Expression" 
        →   or an "Anonymous" Method) 
        → that "Evaluates" Each "Element" 
        → and Returns `true` or `false` 
        → Depending on Whether the "Element" 
        → should be "Included" 
        → in the "Result" 
        → or "Not". 



    ▬ "Where()" Method 
        → is "Essential" 
        → for "Extracting" or "Filtering Elements" 
        → that "Meet Certain Criteria" 
        → from a "Given Sequence".


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Collections;

namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "OfTypeAndWhere" Class ▬
public class OfTypeAndWhere
{
    
    // ▬ "RunOfTypeAndWhere()" Method ▬
    public static void RunOfTypeAndWhere()
    {
        //==================== "OF TYPE()" METHOD  ====================
        // ▼ Creating a "ArrayList" of "Strings" & "Integers" ▼
        ArrayList arrayList = new ArrayList(){"a", "b", "c", 1, 2, 3};
        
        
        //---------------------- "OF TYPE()" METHOD  ----------------------
        // ▼ "OfType()" Method
        //      → to "Filter" the "Elements"
        //      → of the "Array List"
        //      → and "Add Them" to "IEnumerable" ▼
        IEnumerable<string> collectionOfStrings = arrayList.OfType<string>(); 
        
        
        // ▼ "Printing" the "Collection" of "Strings" ▼
        Console.Write("OfType() Method -> to Filter the Elements & Getting only Strings: ");
        foreach(string str in collectionOfStrings)
        {
            Console.Write(str + ", ");
        }
        
        
        Console.WriteLine();
        
        
        
        //==================== "WHERE()" METHOD  ====================
        // ▼ "Creating" a "List" of "Integers" ▼
        List<int> list = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
        
        //---------------------- "WHERE()" METHOD  ----------------------
        // ▼ "Where()" Method
        //      → to "Filter" the "Elements"
        //      → of the "List"
        //      → based on a "Condition"
        //      → and "Add Them" to "IEnumerable" ▼
        IEnumerable<int> collectionOfInts = list.Where(x => x > 5); 
        
        
        // ▼ "Printing" the "Collection" of "Integers" ▼
        Console.Write("Where() Method -> to Filter the Elements based on a Condition (x > 5): ");
        foreach(int i in collectionOfInts)
        {
            Console.Write(i + ", ");
        }

        Console.WriteLine();
    }
} 