/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                           • "SORTED SETS" •

       

    ▬ "Sorted Set"
        → can "Store Elements" 
        → of the "Same Type",
        → "Contains" the "Functionality" 
        → of a "Set"
        → but is also are "Ordered" 
        → in "Ascending Order"
        
        ♦  All "Elements" 
            → mast be "Unique",
            → without "Duplicates".
        
                
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;


public class SortedSets
{
    
    // ▼ "Sorted Set" ▼
    static SortedSet<int> sortedSet1 = new SortedSet<int>();
    static SortedSet<int> sortedSet2 = new SortedSet<int>(){1, 2, 3, 4, 5};
    
    
    
    // ▬ "ShowSortedSet()" Method ▬
    static void ShowSortedSet()
    {
        foreach (var item in sortedSet1)
        {
            Console.WriteLine(item);
        }
    }
    
    
    
    // ▬ "RunSortedSets()" Method ▬
    public static void RunSortedSets()
    {
        //--------------------------------------------------
        // ▼ "Add Elements" to the "Sorted Set" ▼
        Console.WriteLine("\nAdd Elements to the Sorted Set: ");
        sortedSet1.Add(2);
        sortedSet1.Add(5);
        sortedSet1.Add(3);
        sortedSet1.Add(3);
        sortedSet1.Add(1);
        sortedSet1.Add(1);
        sortedSet1.Add(4);
        sortedSet1.Add(2);
        
        ShowSortedSet();
        
        
        
        //------------------------------------------------
        // ▼ "Getting" - "Current Size" of the "Sorted Set" ▼
        Console.WriteLine("\nThe Size of the Sorted Set is " + sortedSet1.Count + " Elements");
        
        
        
        //------------------------------------------------
        // ▼ "Getting" - "Maximum Value" of the "Sorted Set" ▼
        Console.WriteLine("\nThe Maximum Value of the Sorted Set is " + sortedSet1.Max);
        
        
        
        //------------------------------------------------
        // ▼ "Getting" - "Minimum Value" of the "Sorted Set" ▼
        Console.WriteLine("\nThe Minimum Value of the Sorted Set is " + sortedSet1.Min);

        
        
        //------------------------------------------------
        // ▼ "Check" if a "Key" Exists in the "Sorted Set" ▼
        Console.WriteLine(
            "\nCheck if a Key Exists in the Sorted Set (2): " + sortedSet1.Contains(2)
        );
        
        
        
        //----------------------------------------------
        // ▼ "Reverse" the "Sorted Set" ▼
        Console.WriteLine("\nReverse the Sorted Set 2: ");
        foreach (int i in sortedSet2.Reverse())
        {
            Console.WriteLine(i);
        }
        
        
        
        
        //------------------------------------------------
        List<int> list1 = new List<int>(){9, 8, 6, 7, 8, 9, 5, 1};
        
        
        //------------------------------------------------
        Console.WriteLine("\nGetting Only the Elements of Sorted Set, that are also in the List: ");
        sortedSet1.IntersectWith(list1);
        ShowSortedSet();
        
        
        
        
        //------------------------------------------------
        // ▼ "UnionWith()" Method between "Sorted Set" and "List" ▼
        Console.WriteLine("\nUnionWith() Method between Sorted Set and List: ");
        sortedSet1.UnionWith(list1);
        ShowSortedSet();
        
        
        
        
        
        //------------------------------------------------
        Console.WriteLine("\nExceptWith() - Getting All the Unique Elements of Sorted Set, that do Not Exist in List: ");
        sortedSet1.ExceptWith(list1);
        ShowSortedSet();
        
        
        
        //------------------------------------------------
        Console.WriteLine("\nSymmetricExceptWith() - Getting All the Unique Elements of Sorted Set and List, without Duplicates: ");
        sortedSet1.SymmetricExceptWith(list1);
        ShowSortedSet();

        
        
        //------------------------------------------------
        // ▼ "Remove" a "Element" from the "Sorted Set" ▼
        Console.WriteLine("\nRemove an Element from the Sorted Set (5): " +  sortedSet1.Remove(5));
        ShowSortedSet();
        
        
        
        //------------------------------------------------
        // ▼ "Remove All"|"Clear" Elements of the "Sorted Set" ▼
        Console.WriteLine("\nRemove All Elements from the Sorted Set: ");
        sortedSet1.Clear();
        ShowSortedSet();
        
        
    }
}