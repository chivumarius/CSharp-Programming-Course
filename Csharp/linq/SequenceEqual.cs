/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                    • "SEQUENCE EQUAL()" METHOD •

       


    ▬ The "SequenceEqual()" Method in "LINQ" 
        → is "Used" to "Check" 
        → if "Two Sequences/Collections" 
        → are "Equal" 
        → and if they "Contain" 
        → the "Same Elements" 
        → in the "Same Order". 
    
    
    
    ▬ "SequenceEqual()" Method 
        → "Compares Each Element" 
        → in the "First Sequence" 
        → with its "Counterpart" 
        → in the "Second Sequence" 
        → "Using" the "Equality Operator" (`==`). 
        
        
        ♦ If "Both Sequences" 
            → are the "Same Length" 
            → and "Each Element" 
            → in the "First Sequence" 
            → is "Equal" to "Its Counterpart" 
            → in the "Second Sequence", 
            → then the "SequenceEqual()" Method 
            → Returns "True", 
            → "Otherwise" Return "False".




    ▬ This method is "Useful" 
        → when you "Want" 
        → to "Compare Two Collections" 
        → of "Objects" 
        → to "Check" if they "Have" 
        → the "Same Elements" 
        → in the "Same Order".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "Person" Class ▬
public class Person4
{
    // ▼ "Variables" ▼
    public string name;
    public int age;
}





//──────────────────────────────────────────────────────────────
// ▬ "SequenceEqual" Class ▬
public class SequenceEqual
{
    
    // ▬ "RunSequenceEqual()" Method ▬
    public static void RunSequenceEqual()
    {
        // ▼ Create "3 Lists" of "Strings" ▼
        List<string> list1 = new List<string> { "a", "b", "c", "d" };
        List<string> list2 = new List<string> { "a", "b", "c", "d" };
        List<string> list3 = new List<string> { "a", "b", "c", "d", "e" };
        
        
        //-------------"SEQUENCE EQUAL()" -------------
        // ▼ "SequenceEqual()" Method ▼
        Console.WriteLine("SequenceEqual() → to Check if 'List 1' is 'Equal' to 'List 2': " + list1.SequenceEqual(list2));
        Console.WriteLine("SequenceEqual() → to Check if 'List 1' is 'Equal' to 'List 3': " + list1.SequenceEqual(list3));
        
        
        Console.WriteLine();
        
        
        //-------------"SEQUENCE EQUAL()" FOR "REFERENCE TYPES" -------------
        // ▼ For "Reference Types" 
        //    → the "Values" are "Not Equal" 
        //    → to "Compare" 
        //    → if they "Contain"
        //    → the "Same Elements" 
        //    → in the "Same Order",
        //    → because they are "Stored"
        //    → in "Different Memory Locations".
        
        
        // ▼ Creating "2 Equal Lists" of "Persons" ▼
        List<Person4> people1 = new List<Person4>
            { new Person4 { name = "Alexandra", age = 21 } };
        
        List<Person4> people2 = new List<Person4>
            { new Person4 { name = "Alexandra", age = 21 } };
        
        
        //-------------"SEQUENCE EQUAL()" -------------
        // ▼ "SequenceEqual()" Method ▼
        Console.WriteLine("SequenceEqual() → to Check if 'People 1' is 'Equal' to 'People 2' as 'Reference Types': " + people1.SequenceEqual(people2));
    }
} 