/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                 • "ORDER BY()" & "THEN BY()" & "REVERSE()" •

       


    ▬ "OrderBy()" Method in "LINQ" 
        → is "Used" 
        → to "Sort" the "Elements" 
        → of a "Sequence" in "Ascending Order" 
        → "Based" on a "Specific Key". 
        
        
        ♦ It "Receives" 
            → a "Sequence" of "Elements" 
            → and a "Function" 
            → that "Extracts" a "Key" 
            → from "Each Element" 
            → and then "Sorts" the "Elements" 
            → "According" to that "Key". 
        
        
        
    ▬ "OrderBy()" Method 
        → is "Essential" 
        → when we "Want" to "Order" 
        → the "Elements" in a "Sequence" 
        → in a "Certain Order" 
        → that we "Specify".
    
    
    

    ▬ "ThenBy()" Method in "LINQ" 
        → is "Used" 
        → to "Do" a "Secondary Sort" 
        → "Based" on a "Specified Key", 
        → "Applied After" a "Primary Sort" 
        → has "Already Performed" 
        → Using the: 
            •► "OrderBy()" Method or
            •► "OrderByDescending()" Method. 



    ▬ "ThenBy()" Method  
        → is Useful 
        → when we "Want" to "Set" 
        → a "Secondary Sort Criterion"  
        → when there are "Elements" 
        → that have the "Same Primary Sort Key Value".
    
    

    ▬ "Reverse()" Method in "LINQ" 
        → is "Used" to "Reverse" 
        → the "Order" of "Elements" 
        → in a "Sequence". 
        
        
        ♦ It "Takes" 
            → a "Sequence" of "Elements" 
            → and "Returns" a "Mew Sequence" 
            → in "Which" the "Elements" 
            → are "Arranged" 
            → in the "Reverse Order" 
            → of the "Original Sequence". 
    
    
    ▬ "Reverse()" Method 
        → is "Useful" 
        → when we "Want" to "Change" 
        → the "Order" of "Elements" 
        → in a "Sequence" 
        → by "Reversing Them".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;



//──────────────────────────────────────────────────────────────
// ▬ "Person2" Class ▬
public class Person2
{
    // ▼ "Variables" ▼
    public string name;
    public int age;
}




//──────────────────────────────────────────────────────────────
// ▬ "OrderByAndThenByAndReverse" Class ▬
public class OrderByAndThenByAndReverse
{
    // ▬ "List" of "People" Objects ▼
    static List<Person2> people = new List<Person2>()
    {
        new Person2() { name = "Marius", age = 40 }, 
        new Person2() { name = "Nicolas" , age = 18},
        new Person2() { name = "Jeanine" , age = 25},
        new Person2() { name = "Ela" , age = 32},
        new Person2() { name = "Ana-Maris", age = 27 },
        new Person2() { name = "Ioana", age = 20 },
        new Person2() { name = "Beatrice", age = 30 },
        new Person2() { name = "Cristian", age = 28 },
        new Person2() { name = "Laurentiu", age = 42 },
        new Person2() { name = "Octavian", age = 45 },
    };
    
    // ▬ "RunOrderByAndThenByAndReverse()" Method ▬
    public static void RunOrderByAndThenByAndReverse()
    {
        //==================== "ORDER BY()" METHOD  ====================
        // ▼ "Ordering" by the "Name"
        //      → of the "Person" ▼
        IOrderedEnumerable<Person2> ascendingNames = people.OrderBy(x => x.name);
        
        // ▼ "Printing" the "Ordered" "Names" ▼
        Console.WriteLine("OrderBy() Method -> to Order by the Name:");
        foreach (Person2 person in ascendingNames)
        {
            Console.WriteLine(" - " + person.name);
        }
        
        
        Console.WriteLine();
        
        
        //==================== "ORDER BY DESCENDING()" METHOD  ====================
        // ▼ "Descending Order"
        //      → of the "Person" ▼
        IOrderedEnumerable<Person2> descendingNames = people.OrderByDescending(x => x.name);
        
        // ▼ "Printing" the "Ordered" "Names" ▼
        Console.WriteLine("\nOrderByDescending() Method -> to Order the Names in Descending Order:");
        foreach (Person2 person in descendingNames)
        {
            Console.WriteLine(" - " + person.name);
        }

        
        
        
        Console.WriteLine();
        
        
        //==================== "THEN BY()" METHOD  ====================
        // ▼ "ThenBy()" Method
        //      → to "Sort" the "Elements"
        //      → "According" to the "Age" ▼
        IOrderedEnumerable<Person2> orderByAndThenBy = people.OrderBy(x => x.age).ThenBy(x => x.name);
    
    
        // ▼ "Printing" the "Ordered" "Names" ▼
        Console.WriteLine("\nThenBy() Method -> to Order the Names in Ascending Order and Then by the Age:");
        foreach (Person2 person in orderByAndThenBy)
        {
            Console.WriteLine(" - " + person.name + " - " + person.age);
        }

        
        Console.WriteLine();
        
        
        //==================== "REVERSE()" METHOD  ====================
        // ▼ "Reversing" the "Original Order" ▼
        people.Reverse();

        // ▼ Printing the "Reversed" "Names" ▼
        Console.WriteLine("\nReverse() Method -> to Reverse the Original Order of People List:");
        foreach (Person2 person in people)
        {
            Console.WriteLine(" - " + person.name);
        }
    }
} 