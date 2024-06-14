/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "GENERICS" •
                        ──────────────
             ► "GENERIC" - "CLASSES" & "METHODS" ◄




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




    
    ▬ A "Generic Method"
        → is a "Method"
        → "Declared" with "Type" Parameter


        

 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.generics;



//────────────────────────────────────────────────────
// ▬▬ "GenericClassesAndMethods" Generics Class ▬▬
public class GenericClassesAndMethods<T>
{
    
    // ▬ "PrintMessage()" Generic Method ▬
    public static void PrintMessage<T>(T message)
    {
        Console.WriteLine(message);
    }
    
    
    
    
    // ▬ "PrintMessage()" Generic Method
    //      → with "2 Generic Parameters" ▬
    // public static void PrintMessage<T>(T message, T prefix)
    // {
    //     Console.WriteLine(prefix + message);
    // }
    
    
    
    // ▬ "PrintMessage()" Generic Method
    //      → with "3 Generic Parameters" ▬
    // public static void PrintMessage<T>(T message, T prefix, T suffix)
    // {
    //     Console.WriteLine(prefix + message + suffix);
    // }
    //
    
    
    // ▬ "RunGenericClassesAndMethods()" Method ▬
    public static void RunGenericClassesAndMethods()
    {
        // ▼ "Calling" the "PrintMessage()" Method ▼
        GenericClassesAndMethods<string>.PrintMessage("Generic Method - as a 'String'.");
        
        Console.Write("Generic Method - as a 'Int': ");
        GenericClassesAndMethods<int>.PrintMessage(2);
        
        Console.Write("Generic Method - as a 'Float': ");
        GenericClassesAndMethods<float>.PrintMessage(2.5f);
        
        Console.Write("Generic Method - as a 'Boolean': ");
        GenericClassesAndMethods<bool>.PrintMessage(true);
    }    
} 


