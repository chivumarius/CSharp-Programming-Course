/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                        • "INSERTION SORT" •
                  
                  


    ▬ "Insertion Sort": 
            ♦ This "Algorithm" 
                → "Sorts" the "List" 
                → by "Building" a "Sorted Part" 
                → on the "Left Side" 
                → and "Inserting" 
                → the U"nordered Elements" 
                → "One" by "One" 
                → into the "Sorted Part". 
            
            
            ♦ It is "Efficient" 
                → for "Small Lists", 
                → but has "High Time Complexity" 
                → for "Large Lists".
        
               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;


public class InsertionSort
{
    // ▬ "MyInsertionSort()" Method ▬
    public static int[] MyInsertionSort(int[] array)
    {
        // ▼ "Iterating" over "All Elements" of the "Array" ▼ 
        for (int i = 1; i < array.Length; i++)
        {
            // ▼ "Setting" the "Value" of the "Current Element" ▼
            int value = array[i];
        
            // ▼ "Iterating Backward" over "All Elements" of the "Array" ▼
            int j = i - 1;
            while (j >= 0 && array[j] > value)
            {
                // ▼ "Shifting" elements to the right to make space for the current value ▼
                array[j + 1] = array[j];
                j--;
            }
        
            // ▼ "Placing" the "Current Value" in the correct position ▼
            array[j + 1] = value;
        }
    
        // ▼ "Returning" the "Sorted Array" ▼
        return array;
    }
    
    

    // ▬ "RunInsertionSort()" Method ▬
    public static void RunInsertionSort()
    {
        // ▼ "Defining" the "Given Array" ▼
        int[] array = { 4, 3, 2, 10, 12, 1 };

        
        // ▼ "Display" the "Array" Before "Insertion Sorting" ▼
        Console.Write("Array Before Insertion Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        
        
        
        // ▼ "Calling" the "Method"
        //      → for "Sorting" the "Array" ▼
        array = MyInsertionSort(array);

        // ▼ "Display" the "Array" After "Insertion Sorting" ▼
        Console.Write("\nArray After Insertion Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        
        Console.WriteLine();       
    }
} 