/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "LISTS" •
                     - ("LINEAR COLLECTION") -

       

    ▬ A "List" (`List<T>`)
        → is a "Generic Collection" 
        → that can "Store" 
        → a "Variable Number" of "Elements" 
        → of the "Same Typ"e (`T`). 
        
        
        ♦ "List" 
            → is a "Flexible Implementation" 
            → of a "Data Collection" in "C#" 
            → that Allows: 
                •► "Adding", 
                •► "Deleting", 
                •► "Accessing" and 
                •► "Modifying" Elements 
            → in an "Easy" and "Efficient Manner".




    ▬ The "Main Features" of "List":

        1. Flexibility: 
            ♦ A List 
                → can "Dynamically" 
                → "Increase" or "Decrease" 
                → in "Size"  as "Elements" 
                → are "Added" or "Removed", 
                → unlike a "Classic Array", 
                → which Has a "Fixed Size".



        2. "Compile-Level Typing": 
            ♦ The "List" 
                → is "Generic", 
                → meaning it can "Store Elements" 
                → of a "Specific Type" 
                → "Specified" at the "Time" 
                → the "List" is "Created".



        3. "Element Access": 
            ♦ "Elements" 
                → in a "List" can be "Accessed" 
                → using their "Zero-Based Index", 
                → just like a "Classic Array".



        4. "Efficient Addition" and "Deletion Operations": 
            ♦ The "List" 
                → Provides "Efficient Methods" 
                → for "Adding" and "Deleting Elements", 
                → including "Adding" 
                → to the "End" of the "List", 
                → "Inserting" at a ""Specific Position, 
                → and "Deleting Elements".
    
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;




// ▬▬ "Class" ▬▬
public class Lists
{
    // ▼ "List" Variable ▼
    static List<int> numbersList = new List<int>() {1, 3, 5, 4, 2};
    
    
    
    // ▬ "DisplayList()" Method
    //      → which will be "Called"
    //      → in ".ForEach()" Method ▬
    static void ShowList(int i)
    {
        Console.Write(i + ", ");
    }
    
    
    
    
    
    
    // ▬ "RunLists()" Method ▬
    public static void RunLists()
    {
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "List Size" ▼
        Console.WriteLine("\nSize the List of Numbers: " + numbersList.Count);
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Get" & "Set"
        //      → the "Total Number" of "Elements"
        //      → in the "List" ▼
        numbersList.Capacity = 10;
        Console.WriteLine("\nCapacity of the List: " + numbersList.Capacity);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Add" Elements
        //      → to the "End" of the "List" ▼
        numbersList.Add(6);
        
        Console.Write("\n\nAdding Element 6 to List: ");
        numbersList.ForEach(ShowList);
        
        
        
        
        
        
        // ▼ "List 2" ▼
        List<int> numbersList2 = new List<int>() {10, 8, 7, 9};
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Add" the S"econs List" into the "First List" ▼
        numbersList.AddRange(numbersList2);
        
        Console.Write("\n\n" + "Adding a List to Other List: ");
        numbersList.ForEach(ShowList);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Remove" Elements
        // ▼ "Sorting" the "List Elements"
        //      → in "Ascending Order" ▼
        numbersList.Sort();
        
        Console.Write("\n\nSorting the List: ");
        numbersList.ForEach(ShowList);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ Searching Elements in the "List" 
        //      → and Returning their "Index" ▼
         int serch = numbersList.BinarySearch(5);
        
        Console.Write("\n\nSearching the Index 5: " + serch);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "nClearing" the "List" ▼
        numbersList.Clear();
        
        Console.Write("\n\nClearing the List: ");
        numbersList.ForEach(ShowList);
        
        
        
        
        
        // ▼ "List 3" ▼
        List<int> numbersList3 = new List<int>() {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
       
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Checking" if an "Element Exist" in a "List" ► "True" or "False" ▼
        bool contain10 = numbersList3.Contains(10);
        Console.WriteLine("\n\nChecking if Element 10 Exist: " + contain10);
        
        bool contain12 = numbersList3.Contains(12);
        Console.WriteLine("Checking if Element 12 Exist: " + contain12);



        //───────────────────────────────────────────────────────────────────────
        // ▼ Inserting an Element in a Given Position ▼
        numbersList3.Insert(0, 11);
        
        Console.Write("\nInserting Element 11 at Index 0: ");
        numbersList3.ForEach(ShowList);


        
        
        
        
        // ▼ "List 4" ▼
        List<int> numberList4 = new List<int>() { 14, 12, 13 };

        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Inserting Several Elements" at a "Given Position" ▼
        numbersList3.InsertRange(6, numberList4);
        
        Console.Write("\n\nInserting Several Elements at Index 6: ");
        numbersList3.ForEach(ShowList);
        

        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Removing" an Element from a "List" ▼
        numbersList3.Remove(11);
        
        Console.Write("\n\nRemoving a Specific Element 11: ");
        numbersList3.ForEach(ShowList);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ Remove an Element by "Index" ▼
        numbersList3.RemoveAt(5);
        
        Console.Write("\n\nRemoving a Element by Specify Index 5: ");
        numbersList3.ForEach(ShowList);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ Removing Several Elements from a "List" ▼
        numbersList3.RemoveRange(5, 2);
        
        Console.Write("\n\nRemoving Several Elements from a List starting from Index 5: ");
        numbersList3.ForEach(ShowList);
        
        
        
        
        
        // ▼ "Resetting" the "List Capacity" to "20" ▼
        numbersList3.Capacity = 20;
        Console.WriteLine("\n\nReset Capacity of List to: " + numbersList3.Capacity);

        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Trimming" the "List"
        //      → "According" to the "Number" 
        //      → of "Existing Elements" ▼
        numbersList3.TrimExcess();
        Console.WriteLine("\nTrimming the List According to the Number of Existing Elements: " + numbersList3.Count);
        
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ Cheching if "All Elembts" of the "List"
        //      → Match a "Given Condition" ▼
        bool allElements = numbersList3.TrueForAll(x => x > 0);
        Console.WriteLine("\nChecking if All Elements of the List Match a Given Condition: " + allElements);
      
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // "Reversing" the "List" ▼
        numbersList3.Reverse();
        
        Console.Write("\n\nReversing the List: ");
        numbersList3.ForEach(ShowList);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // "Finding" the "Index" of a "Element" ▼
        int index = numbersList3.IndexOf(10);
        Console.WriteLine("\n\nFinding the Index of Element 10: " + index);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Finding" the "Last Index" of "List" ▼
        int lastIndex = numbersList3.LastIndexOf(1);
        Console.WriteLine("\nFinding the Last Index of the List - Element 1: " + lastIndex);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ Finding the "Last Element"
        //      → that "Match" a "Condition" ▼
        int lastElementLessThen = numbersList3.Last(x => x < 5);
        Console.WriteLine("\nFinding the \"Last Element\" that is Less then 5: " + lastElementLessThen);
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "Converting" a "List" to "Array" ▼
        int[] array = numbersList3.ToArray();
        
        Console.Write("\nConverting a List to Array: " );
        foreach(int i in array)
        {
            Console.Write(i + ", ");
        }
        
        
        
        
        //───────────────────────────────────────────────────────────────────────
        // ▼ "list" of "Multiple Data Type" ▼
        List<object> multiTypeList = new List<object>() { 1, "Programmer", true };
        
        Console.Write("\n\nList of Multiple Data Type: ");
        foreach (object dataType in multiTypeList)
        {
            Console.Write(dataType + " ");
        }
        
        
        
        Console.WriteLine(); Console.WriteLine();
    }
}