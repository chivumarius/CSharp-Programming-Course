/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                       • "SELECTION SORT" •
                  
                  
    ▬ "Sorting"
        → is a "Process" 
        → of "Arranging" the "Elements" 
        → of a "Collection" 
        → in a "Specific Order", 
        → such as: 
            •► "Ascending" Order or 
            •► "Descending" Order, 
        → "Based" on "Certain Criteria". 
        
        
        ♦ The "Main Purpose" of "Sorting" 
            → is to "Facilitate Search" 
            → and "Access" to "Stored Data" 
            → by "Organizing It" 
            → in an "Orderly Form".

    
    
    
    ▬ Some of the Main "Sorting Algorithms" include:

        1. "Selection Sort": 
            ♦ The "Algorithm" 
                → "Repeatedly Picks" 
                → the "Smallest Element" 
                → from the "Unordered List" 
                → and "Places It" 
                → at the "Beginning" 
                → of the "Ordered List". 


            ♦ "It" 
                → has the "Same Time Complexity" as
                → "Bubble Sort" and
                → "Insertion Sort", 
                → it is "More Efficient" 
                → in "Practice".



    
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;



public class SelectionSort
{
    
    // ▬ "MySelectionSort()" Method ▬
    public static int[] MySelectionSort(int[] array)
    {
        // ▼ "Variable" ▼
        int length = array.Length;
        
        // ▼ "For Loop" ▼
        for (int i = 0; i < length - 1; i++)
        {
            // ▼ "Variable" ▼
            int minIndex = i;
            
            
            // ▼ "Nested For Loop" ▼
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            
            
            // ▼ "Swapping" the "Minimum Value" with the "First Value" ▼
            int temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }
        
        // ▼ "Return Array" ▼
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
    
    
    
    // ▬ "RunSelectionSort()" Method ▬
    public static void RunSelectionSort()
    {
        int[] array = { 64, 25, 12, 22, 11 };
        Console.Write("Array Before Selection Sort: ");
        PrintArray(array);
        
        
        MySelectionSort(array);
        Console.Write("\nArray After Selection Sort: ");
        PrintArray(array);  
        
        Console.WriteLine();
    }
} 