/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                          • "SHELL SORT" •
                  


                  
    ▬ "Shell Sort" (Sort by fragmentation):
            → is a "Comparison-Based Sorting Algorithm" 
            → that "Improves" 
            → the "Performance" of "Insertion Sort" 
            → by "Breaking" the "List" 
            → into "Smaller Sub-Lists" 
            → and Applying "Insertion Sort" 
            → to "Each Sub-List".
            
            
            
            ♦ It "Uses" 
                → a "Sequence" of "Intervals" (also Called "Gaps") 
                → to "Determine" "Sub-Lists" 
                → of "Different Sizes".
            
            
            
            ♦ "It" has a "Time Complexity Intermediate" 
                → between 
                    •► "O(n) 
                → and 
                    •► "O(n^2), 
                → being "More Efficient" 
                → than the "Insertion Sort Algorithm" 
                → on "Large Lists", 
                → but can be "Slower" 
                → than "Other More Efficient Algorithms" such as 
                → "Quick Sort" or 
                → "Merge Sort".
    
               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;



public class ShellSort
{
    // ▬ "MyShellSort()" Method ▬
    public static int[] MyShellSort(int[] array)
    {
        int length = array.Length;  
    
        // ▼ "For Loop" ▼
        for(int gap = length / 2; gap > 0; gap /= 2)
        {
            // ▼ "For Loop" ▼
            for(int i = gap; i < length; i += 1)
            {
                int temp = array[i];
                int j;
            
                // ▼ "For Loop" ▼
                for(j = i; j >= gap && array[j - gap] > temp; j -= gap)
                {
                    array[j] = array[j - gap];
                }
            
                // ▼ Setting ▼
                array[j] = temp;
            }
        }
    
        // ▼ "Return Statement" ▼
        return array;
    }
    
    

    // ▬ "RunShellSort()" Method ▬
    public static void RunShellSort()
    {
        // ▼ "Defining" the "Given Array" ▼
        int[] array = { 9, 8, 3, 7, 5, 6, 4, 1 };

        
        // ▼ "Display" the "Array" Before "Shell Sorting" ▼
        Console.Write("Array Before Shell Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    
        // ▼ "Calling" the "Method" for "Shell Sorting" ▼
        array = MyShellSort(array);

        
        // ▼ "Display" the "Array" After "Shell Sorting" ▼
        Console.Write("\nArray After Shell Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
} 