/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                        • "SORTED DICTIONARIES" •

       

    ▬  A "Sorted Dictionary" 
        → is "Very Similar" to a "Sorted List".
        
        ♦ Its 
            → a "Data Structure"
            → that Combine 
            → the "Features" 
            → of "List" and "Dictionary".
     
     
     ▬ The "Main Difference"
        → between "Sorted List" and "Sorted Dictionary" is:
        
        ♦ "Sorted List"
            → uses "Less Memory"
            → and is "Faster" if tle "List" 
            → is "Populated All" at "Once"
            → with "Sorted Data". 
        
        
        ♦ "Sorted Dictionary"
            → has :Faster Insertion" and "Removal" 
            → for "Unsorted Data".
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class SortedDictionaries
{
    
    // ▼ "Create" a "Sorted Dictionary" ▼
    static SortedDictionary<string, string> sortedDictionary1 = new SortedDictionary<string, string>()
    {
        {"key1", "value1"},
        {"key2", "value2"},
        {"key3", "value3"},
    };
    
    
    
    // ▬ "ShowPairsOfSortedDictionary()" Method ▬
    static void ShowPairsOfSortedDictionary()
    {
        // ▼ "Get" the "Pairs" of the "Sort Dictionary" ▼
        foreach (KeyValuePair<string, string> pair in sortedDictionary1)
        {
            Console.WriteLine(pair.Key + ", " + pair.Value);
        }
    }
    
    
    
    
    // ▬ "RunSortedDictionaries()" Method ▬
    public static void RunSortedDictionaries()
    {
        
        //----------------------------------------------------------
        // ▼ "Get" the "Pairs" of the "Sort Dictionary" ▼
        Console.WriteLine("\nGet the Pairs of the Sorted Dictionary");
        ShowPairsOfSortedDictionary();
        
        
        
        //----------------------------------------------------------
        // ▼ "Add" - "New Pair" to the "Sort Dictionary" ▼
        Console.WriteLine("\nAdd a New Pair to the Sorted Dictionary");
        sortedDictionary1.Add("key4", "value4");
        sortedDictionary1.Add("key5", "value5");
        ShowPairsOfSortedDictionary();
        
        
        
        // ------------------------------------------------------------
        // ▼ "Get" the "Current Size" of the "Sort Dictionary" ▼
        Console.WriteLine("\nGet the Current Size of the Sorted Dictionary: " + sortedDictionary1.Count);
       
        
        
        
        //------------------------------------------------------------
        // ▼ "Check" if a "Key" Exists in the "Sort Dictionary" ▼
        Console.WriteLine(
                "\nCheck if a Key Exists in the Sorted Dictionary (key1): " 
                + sortedDictionary1.ContainsKey("key1")
            );
       
        
        
        
        //------------------------------------------------------------
        // ▼ "Check" if a "Value" Exists in the "Sort Dictionary" ▼
        Console.WriteLine(
            "\nCheck if a Value Exists in the Sorted Dictionary (value6): "
            + sortedDictionary1.ContainsValue("value6")
        );
        
        
        
        //------------------------------------------------------------
        // ▼ "Remove" a "Element" from the "Sort Dictionary" ▼
        Console.WriteLine(
            "\nRemove an Element from the Sorted Dictionary (key5): "
            + sortedDictionary1.Remove("key5")
        );
        ShowPairsOfSortedDictionary();
        
        
        
        //------------------------------------------------------------
        // ▼ "Remove All"|"Clear" Elements of the "Sort Dictionary" ▼
        Console.WriteLine("\nRemove All Elements from the Sorted Dictionary: ");
        sortedDictionary1.Clear();
        ShowPairsOfSortedDictionary();
    }
}