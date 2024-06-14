/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "SORTED LISTS" •

       

    ▬ "SortedList" 
        → is a "Class"/"Data Structure" in C"# "
        → that "Combine" the "Features" 
        → of "List" and "Dictionary".
        
        
        ♦ It 
            → represents a "Collection" 
            → of "Key-Value" Pairs 
            → "Sorted" by "Key". 
        
        
        ♦ This "Collection"/"Class" 
            → allows "Quick Access" to "Items" 
            → "Based" on "Key" 
            → and Keeps "Items Sorted" by "Key" 
            → in a "Specific Order".



    ▬ The "Main Features" of "SortedList" are:

        1. "Auto Sort": 
            ♦ "Items" 
                → are "Automatically Sorted" 
                → by "Key".
                
                
        2. "Fast Access":
            ♦ "Access" 
                → to "Collection Elements" 
                → is "Efficiently Done" 
                → "Based" on the "Key".
        
        
            ♦ The "Key Access" 
                → takes the "Functionality" 
                → of "Dictionary"
        
        
            ♦ The "Index Access" 
                → takes the "Functionality" 
                → of "Array List".
                
        
        
        3. "Efficient Search":
            ♦ "Searching" 
                → for a "Specific Key" 
                → is "Fast" 
                → due to "Internal Sorting".
       
       
       
       4. "Automatic Resizing":
            ♦ "List Size" 
                → is "Resized Automatically" 
                → when "Needed".


    ▬ This "Class" is "Useful" 
        → when you "Need" 
        → a "Sorted Collection" 
        → and Need "Quick Access" 
        → to "Elements" 
        → "Based" on "Key".
    
    
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class SortedLists
{
    
    // ▼ "Create" a "SortedList" ▼
    static SortedList<string, int> sortedList1 = new SortedList<string, int>()
        {
            {"key1", 1}, 
            {"key2", 2}, 
            {"key3", 3},
            {"key4", 4},
            {"key5", 5}
        };
    
    
    
    
    
    // ▬ "ShowPairs()" Method ▬
    static void ShowPairs()
    {
        // ▼ "Get" the "Pairs" of the "Sort List" ▼
        foreach (KeyValuePair<string, int> pair in sortedList1)
        {
            Console.WriteLine(pair.Key + ", " + pair.Value);
        }
    }
    
    
    
    
    // ▬ "RunSortedLists()" Method ▬
    public static void RunSortedLists()
    {
        
        // -------------------------------------------------------
        // ▼ "Set" the "Size" of the "Sort List"
        //      → by using the "Capacity" Property ▼
        sortedList1.Capacity = 10;
        Console.WriteLine("\nThe Sort List's Capacity (Set Size) is: " + sortedList1.Capacity);

        
        
        // -------------------------------------------------------
        // ▼ "Get" the "Current Size" of the "Sort List" 
        //      → by using the "Count" Property ▼
        Console.WriteLine("The Sort List's Count (Current Size) is: " + sortedList1.Count);

        
        
        // -------------------------------------------------------
        // ▼ "Getting" - "Each Key" of the "Sort List" ▼
        Console.WriteLine("\nGetting Each Key of the Sort List: ");
        
        foreach (string key in sortedList1.Keys)
        {
            Console.WriteLine(key);
        }
        
        
        
        
        // -------------------------------------------------------
        // ▼ "Getting" - "Each Value" of the "Sort List" ▼
        Console.WriteLine("\nGetting Each Value of the Sort List: ");
        
        foreach (int value in sortedList1.Values)
        {
            Console.WriteLine(value);
        }

        
        
        
        
        // ▬ Method ▬
        // -------------------------------------------------------
        // ▼ "Add" a "Key-Value" Pair to the "Sort List" ▼
        sortedList1.Add("key6", 6);
        ShowPairs();

        
        
        // -------------------------------------------------------
        // ▼ "Remove" an "Element" by "Index" ▼
        Console.WriteLine("\nRemoving an Element by Index: ");
        sortedList1.RemoveAt(5);
        ShowPairs();
        
        
        // -------------------------------------------------------
        // ▼ "Remove" an "Element" by "Key" ▼
        Console.WriteLine("\nRemoving an Element by Key: ");
        sortedList1.Remove("key5");
        ShowPairs();
        
        
        
        
        // -------------------------------------------------------
        // ▼ "Check" if an "Key Exist" in the "Sort List" ▼
        Console.WriteLine("\nCheck if a Key Exist in the Sort List (key5): ");
        Console.WriteLine(sortedList1.ContainsKey("key5"));
        
        
        
        // -------------------------------------------------------
        // ▼ "Check" if a "Value Exist" in the "Sort List" ▼
        Console.WriteLine("\nCheck if a Value Exist in the Sort List (1): ");
        Console.WriteLine(sortedList1.ContainsValue(1));
        
        
        
        // -------------------------------------------------------
        // ▼ "Clear"/ "Remove All Elements" of the "Sort List" ▼
        Console.WriteLine("\nClear the Sort List: ");
        sortedList1.Clear();
        ShowPairs();
    }
}