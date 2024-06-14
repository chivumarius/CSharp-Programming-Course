/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                          • "QUICK SORT" •
                  
            

                  
    ▬ "Quick Sort": 
            ♦ "It" is an "Efficient Sorting Algorithm" 
                → that "Uses" 
                → the "Divide" and "Conquer" Method 
                → to "Sort" the "List". 
            
            
            ♦ "Picks" 
                → a "Pivot Element", 
                → Places "Smaller Elements" "Before"
                → the "Pivot"  
                → and "Larger" Ones "After" 
                → the "Pivot", 
                → then "Recursively Sorts" 
                → the "Two Sub-Lists". 
            
            
            ♦ It has an Average "Runtime Complexity" of 
                    •►"O(n log n)", 
                → but may have "Bad Cases" with 
                    •► "O(n^2)" 
                → "Time Complexity".

               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;



public class QuickSort
{
    
    // ▬ "Partition()" Method ▬
    public static int Partition(int[] array, int left, int right)
    {
        // ▼ "Set" the "Pivot"
        int pivot = array[left];
        
        // ▼ "Loop" ▼
        while (true)
        {
            // ▼ 1- "Nested Loop" ▼
            while (array[left] < pivot)
            {
                left++;
            }

            
            // ▼ 2- "Nested Loop" ▼
            while (array[right] > pivot)
            {
                right--;
            }

            
            // ▼ "Check" ▼
            if (left < right)
            {
                // ▼ "Swap" ▼
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
            }
            else
            {
                return right;
            }
        }
    }
    
    
    
    
    // ▬ "MyQuickSort()" Method ▬
    public static int[] MyQuickSort(int[] array, int left, int right)
    {
        // ▼ "Check" ▼
        if (left < right)
        {
            // ▼ "Set" the "Pivot" ▼
            int pivot = Partition(array, left, right);
            
            
            // ▼ 1- "Recursion" ▼ 
            if (pivot > 1)
            {
                // ▼ "Recursive Call" ▼
                MyQuickSort(array, left, pivot - 1);
            }
            
            
            // ▼ 2- "Recursive Call" ▼
            if (pivot + 1 < right)
            {
                // ▼ "Recursive Call" ▼
                MyQuickSort(array, pivot + 1, right);
            }
        }
        
        // ▼ "Return" ▼
        return array;
    }
    
    
    
    // ▬ "PrintArray()" Method ▬
    private static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
    
    
    
    // ▬ "RunQuickSort()" Method ▬
    public static void RunQuickSort()
    {
        int[] array = { 9, -3, 5, 2, 6, 8, -6, 1, 3 };
        Console.Write("Array Before Quick Sort: ");
        PrintArray(array);
        
        
        MyQuickSort(array, 0, array.Length - 1);
        Console.Write("\nArray After Quick Sort: ");
        PrintArray(array);
        
        Console.WriteLine();
    }
} 