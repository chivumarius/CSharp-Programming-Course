/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "TUPLES" •

       

    ▬ A "Tuple" 
        → is an "Object" 
        → that can "Store" 
        → an "Ordered Collection" 
        → of "Elements" 
        → of "Different Types". 
        
        
        ♦ "Similar" 
            → to an "Array" or a "List", 
            → a "Tuple" 
            → can Contain "Multiple Elements", 
            → but "Unlike Them", 
            → the "Elements" of a "Tuple" 
            → can be of "Different Types" 
            → and are "Not Moved"  
            → after the "Tuple" is "Created". 
        
        
        ♦ "Essentially", a "Tuple" 
            → is a "Data Structure" 
            → "Used" to "Group Information", 
            → Especially when that "Information" 
            → does "Not Require" 
            → a "Separately Defined Class" 
            → or "Structure".

    
    
    ▬ In C#, "Tuples" 
        → are Defined using 
        → the predefined "Tuple" 
        → or "ValueTuple" Types, 
        → or they can be Defined "Implicitly" 
        → using the "Tuple Syntax".



    ▬ "Feature" of "Tuple"
        1. Has a "Specific Number" 
            → and "Order" of "Elements".
       
       
       2. It can "Have" 
            → from "1" to "7 Elements".
       
       
       3. Represent a "Single Set" 
    
        
        4. It Provide 
            → "Easy Access" 
            → and "Manipulation" 
            → of "Data Sets".        → of Data.
    
    
        5. It "Return" 
            → "Multiple Values" 
            → from a "Method".
        
        
        6. It "Pass"
            → "Multiple Values" 
            → into a "Method"
            → with "1 Parameter".
    
    
    ▬ A "Tuple" 
        1- Wit "1 Value/Element" (a "Single Value")
            → is "Called" 
            → a "One-Tuple"
            → or "Singleton", 
                → ("Not" to Be "Confused" 
                → with "Singleton" Design Pattern_.
        
        
        2- With "2 Value/Element" 
            → is "Called" 
            → a "Two-Tuple"
            → or "Pair".
       
         
        3- With "3 Value/Element" 
            → is "Called" 
            → a "Three-Tuple"
            → or "Triple".
         
    
        4- With "4 Value/Element" 
            → is "Called" 
            → a "Four-Tuple"
            → or "Quadruple".
        
        
        5- With "5 Value/Element" 
            → is "Called" 
            → a "Five-Tuple"
            → or "Quintuple".
        
        
        6- With "6 Value/Element" 
            → is "Called"  
            → a "Six-Tuple"
            → or "Sextuple".
        
        
        7- With "7 Value/Element" 
            → is "Called" 
            → a "Seven-Tuple"
            → or "Septuple".
         
         
         
         
         
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class Tuples
{
    
    // ▼ "1st Syntax" to "Create" a "Tuple" ▼
    static Tuple<int> tupleType1 = Tuple.Create(1);
    
    // ▼ "1st Syntax" to "Create" a "Tuple" ▼
    static  Tuple<int> tupleType2 = new Tuple<int>(1);
    
     
        
        
     // (1) "One-Tuple" or "Singleton":
     static Tuple<int> tuple1 = Tuple.Create(1);
     
     
     // (2) "Two-Tuple" or "Pair":
     static Tuple<int, int> tuple2 = Tuple.Create(1, 2);
     
     
     // (3) "Three-Tuple" or "Triple":
     static Tuple<int, int, int> tuple3 = Tuple.Create(1, 2, 3);
     
     
     // (4) "Four-Tuple" or "Quadruple":
     static Tuple<int, int, int, int> tuple4 = Tuple.Create(1, 2, 3, 4);
     
     
     // (5) "Five-Tuple" or "Quintuple":
     static Tuple<int, int, int, int, int> tuple5 = Tuple.Create(1, 2, 3, 4, 5);
     
     
     // (6) "Six-Tuple" or "Sextuple":
     static Tuple<int, int, int, int, int, int> tuple6 = Tuple.Create(1, 2, 3, 4, 5, 6);
        
     
     // (7) "Seven-Tuple" or "Septuple":
     static Tuple<int, int, int, int, int, int, int> tuple7 = Tuple.Create(1, 2, 3, 4, 5, 6, 7);
     
     
     
     // ▼ "Tuple" with "Mixed Type" ▼
     static Tuple<int, string, bool> mixedTuple = Tuple.Create(1, "Hello", true);
     
     
     
     
     
     
    // ▬ "RunTuples()" Method ▬
    public static void RunTuples()
    {
       
        // ▼ "Accessing" the "Tuples Elements" of a "Tuple" ▼
        Console.WriteLine("\nAccessing the Tuple 1, Element 1: " + tuple1.Item1);
        Console.WriteLine("\nAccessing the Tuple 2, Element 2: " + tuple2.Item2);
        Console.WriteLine("\nAccessing the Tuple 3, Element 3: " + tuple3.Item3);
        Console.WriteLine("\nAccessing the Tuple 4, Element 4: " + tuple4.Item4);
        Console.WriteLine("\nAccessing the Tuple 5, Element 5: " + tuple5.Item5);
        Console.WriteLine("\nAccessing the Tuple 6, Element 6: " + tuple6.Item6);
        Console.WriteLine("\nAccessing the Tuple 7, Element 7: " + tuple7.Item7);
        
        // ▼ "Accessing" the "Mixed Tuple Elements" ▼
        Console.WriteLine("\n\nAccessing the Mixed Tuple, Elements 1, 2, 3: " + mixedTuple.Item1 + ", " + mixedTuple.Item2 + ", " + mixedTuple.Item3);
    }
}