/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "GENERICS" •
                        ──────────────
       



    ▬ "Generic" in "C#"
        → means "Not Specific".
        → allows us to "Write Classes/Methods" 
        → that can Accept "Parameters" 
        → of "Multiple Types".
    
    
    
        ♦ This "Makes" the "Code" 
            → more "Flexible" and "Reusable", 
            → "Eliminating" the "Need" 
            → to "Rewrite" the "Same Functionality" 
            → for "Each Data Type". 
    
    
    
    ▬ "Generics" 
        → Ensure "Type Safety" 
        → at "Compile Time" 
        → and can "Improve Performance" 
        → by Avoiding "Type Conversions" 
        → and "Boxing"/"Unboxing". 
    
    
    
    ▬ "<T>"
        → is a "Placeholder" 
        → for "Data Types"
        
      
      
    ▬ "Generic Type Parameters"
        → are "Placeholders" for "Data Types" 
        → in a "Class", "Structure", or "Method". 
        
        
        
    ▬ "Instead" of "Specifying" 
        → a Specific "Data Type", 
        → we can Use a "Generic Type Parameter", 
        → usually denoted "<T>", 
        → to "Make" the "Component" 
        → as "generic". 



    ▬ For Example, 
        → we can Create a "Container Class" 
        → that can "Store Any Type" of "Data" 
        → "Without" having to "Rewrite" the "Code" 
        → for "Each Type".
    
     
     
     ▬ More "Descriptive Name" 
        → for the "<T>" Key,
        → by "Adding" 
        → the "Prefix" to "It": 
            •► "TSession".  
       
   
   
  
    ▬ "Generic Classes"
        → "Encapsulate Classes" 
        → that are "Not Specific"
        → to a "Data Type"




    ▬ Example" of "Creating" 
        → "Generic Classes":
      ──────────────────────────────────────────────
        class MyGeneric<T> {  }
      ──────────────────────────────────────────────





    ▬ "Built-In Generic Classis" in "C#":

        1. "Comparer<T>"
        2. "EqualityComparer<T>"
        3. "HashSet<T>"
        4. "KeyedByTypeCollection<TItem>"
        5. "LinkedList<T>"
        6. "LinkedListNode<T>"
        7. "List<T>"
        8. "Queue<T>"
        9. "SortedDictionary<TKey, TValue>"
        10. "SortedList<TKey, TValue>"
        11. "SortedSer<T>"
        12. "Stack<T>"
        13. "SynchronizedCollection<T>"
        14. "SynchronizedKeyCollection<K, T>"
        15. "SynchronizedReadOnlyCollection<T>"



    ▬ Some of "Built-In Generic Interfaces" in "C#":
        1. "IList<T>"
        2. "IReadonlyCollection<T>"
        3. "IReadonlyDictionary<TKey, TValue>"
        4. "IReadonlyList<T>"
        5. "ISet<T>"
        6. "ICollection<T>"
        7. "IComparer<T>"
        8. "IDictionary<TKey, TValue>"
        9. "IEnumerable<T>"
        10. "IEnumerator<T>"
        11. "IEqualityComparer<T>"
  
            
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.generics;



// ▬▬ "Generics" Class
//      → of "Generic Type" ("<T>" = Placeholder) ▬▬
public class Generics<T>
{
    
    // ▬ "Print()" Method
    //      → of "Generic Type" ▼
    void Print(T message)
    {
        Console.WriteLine(message);
    }
    
    
    
    // ▬ "RunGenerics()" Method ▬
    public static void RunGenerics()
    {
        // ▼ "Create" an "Instance" of the "Generic" Class with a specified type (eg string)
        Generics<string> genericString = new Generics<string>();

        // ▼ "Access" the "Print()" Method
        //      → with a "String Message" ▼
        genericString.Print("Accessing a Generic Method."); // "Accessing a Generic message."); 
    }    
} 


