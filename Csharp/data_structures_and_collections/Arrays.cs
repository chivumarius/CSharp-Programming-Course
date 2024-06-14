/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "ARRAYS" •
                     - ("LINEAR COLLECTION") -

       

    ▬ "Data Collections" in "C#" 
        → are "Data Structures" 
        → that allow the "Storage" 
        → and "Manipulation" 
        → of a "Variable Number" of "Elements" 
        → of the "Same Type". 
        
        ♦ These "Include" 
                •► "Lists", 
                •► "Dictionaries", 
                •► "Sets" 
            → and more.
            


    ▬ "Collections" in "C#"
        → can be "Divided" 
        → into "Two Main Categories": linear collections and non-linear collections.


        1. "Linear Collections":
            → "Keep Elements" in a "Specific Sequence", 
            → either "Based" on "Position" ("Index") 
            → or "Addition Order".
            
            
            ♦ Examples of "linear collections":
                •► "Lists" (`List<T>`), 
                •► "Doubly Linked Linear Lists" (`LinkedList<T>`), 
                •► "Queues" (`Queue<T>`), and 
                •► "Stacks" (`Stack<T>`).
            
            ♦ These  
                → are Useful 
                → when you "Need" to "Keep Data" 
                → in a "Specific Order" 
                → or "Access Data" 
                → in a "Specific Sequence".




        2. "Non-Linear Collections":
            → do "Not Store Elements" 
            → in a "Specific Sequence". 
            
            ♦ They 
                → are "Based" on Other "Data Structures", 
                → such as: 
                    •► "Trees", 
                → to "Organize" 
                → and "Access Elements".
            
            
            
            ♦ "Examples":
                •► "Dictionaries" (`Dictionary<TKey, TValue>`), 
                •► "Sets" (`HashSet<T>`), and 
                •► "Trees" (`Tree<T>`).
            
            
            
            ♦ These are "Useful" 
                → when you Need 
                → to "Quickly Access Data" 
                → "Based" on a "Key" 
                → (in the "Case" of "Dictionaries" and "Sets") 
                → or "Organize Data" 
                → in a "Hierarchical Structure" 
                → (in the "Case" of "Trees").    
            
 
 
 
    ▬ An "Array" 
        → is a "linear Data Structure" 
        → that can "Store" 
        → a "Fixed Number" of "Elements" 
        → of the "Same Type", 
        → "Accessed" through an "Index". 
        
        
        ♦ These "Elements" 
            → are "Placed Consecutively" 
            → in "Memory". 
        
        
        
        ♦ Arrays 
            → "Start Indexing" at "Zero",
            → meaning the "First Element" 
            → is "Accessed" 
            → at "Index 0", 
            → the "Second Element" 
            → at "Index 1", 
            → and "So On".

  
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class Arrays
{
    
    // (1) The "1st Way" to "Create" an "Array": 
    string[] array1 = new string[5];  // ◄◄ "string[5]": means the "Size" of "Array" ◄◄
    
    
    // (2) The "2nd Way" to "Create" an "Array" 
    //      → with "Values": 
    string[] array2 = new string[5]{"a", "b", "c", "d", "e"};  

    
    
    // (3) The "3rd Way" to "Create" an "Array" 
    //      → without "Size":
    string[] array3 = new string[]{"a", "b", "c", "d", "e"};  


     
    // (4) The "4rt Way" to "Create" an "Array" 
    //      → without "new string[]":
    string[] array4 = {"a", "b", "c", "d", "e"};  

    
    // ▼ "Array Declaration" ▼
    static string[] stringArray;
    
    
    // ▼ "Integers Array" ▼
    static int[] intArray = new int[3]{6, 2, 4};
    
    
    
    
    // ▬ "RunArrays()" Method ▬
    public static void RunArrays()
    {
        // ▼ "Array Initialization" ▼
        stringArray = new string[] {"s", "m", "a", "r", "i", "u"};
        Console.WriteLine("String Array: " + stringArray[0] + ", " + stringArray[1] + ", " + stringArray[2] + ", " + stringArray[3] + ", " + stringArray[4]);
        
        
        // ▼ Accessing "Integer Array" ▼
        Console.WriteLine("\nInt Array Element 0: " + intArray[0]);
        Console.WriteLine("Int Array Element 1: " + intArray[1]);
        Console.WriteLine("Int Array Element 2: " + intArray[2]);
        
        // ▼ "Array Length" ▼
        Console.WriteLine("\nArray Length (intArray): " + intArray.Length);
        
        
        // ▼ "Sorting Array" of "Integers" ▼
        Console.WriteLine("\nSorting Array: ");
        Array.Sort(intArray);
        foreach(int i in intArray)
        {
            Console.WriteLine(i);
        }
        
        
        
        // ▼ "Sorting Array" of "Strings" ▼
        Console.WriteLine("\nSorting Array: ");
        Array.Sort(stringArray);
        foreach(string s in stringArray)
        {
            Console.WriteLine(s);
        }
    }
}