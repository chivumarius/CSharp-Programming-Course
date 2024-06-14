/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                         • "BUBBLE SORT" •
                  

                  
                  
    ▬ "Bubble Sort": 
            ♦ "It" 
                → is a Simple "Sorting Algorithm" 
                → that "Iterates" 
                → through the "List" 
                → and "Swaps Neighboring Elements" 
                → if "They" are in the "Wrong Order". 
            
            
            ♦ It is "Efficient" 
                → for small "Lists", 
                → but has "High Time Complexity" 
                → for "Large Lists".


               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.searching_and_sorting_algorithms.sorting;


public class BubbleSort
{
    
    // ▬ "MyBubbleSort()" Method ▬
    public static int[] MyBubbleSort(int[] arr)
    {
        // ▼ "Variable" ▼
        int length = arr.Length;
        
        
        // ▼ "For Loop" ▼
        for (int i = length - 1; i >= 1; i--)
        {
            // ▼ "For Loop" ▼
            for (int j = 1; j <= i; j++)
            {
                // ▼ "If Statement" ▼
                if (arr[j - 1] > arr[j])
                {
                    // ▼ "Variable" ▼
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        // ▼ Return Array ▼
        return arr;
    }
    

    
    // ▬ "PrintArray()" Method ▬
    private static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
    }
    
    
    
    // ▬ "RunBubbleSort()" Method ▬
    public static void RunBubbleSort()
    {
        int[] array = { 5, 1, 4, 2, 8 };
        Console.Write("Array Before Bubble Sort: ");
        PrintArray(array);
       
        
        MyBubbleSort(array);
        Console.Write("\nArray After Bubble Sort: ");
        PrintArray(array);  
        
        Console.WriteLine();
    }
} 