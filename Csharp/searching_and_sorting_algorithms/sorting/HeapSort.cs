/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                           • "HEAP SORT" •
                  
                  


    ▬ "Heap Sort": 
            ♦ It is an "Efficient Sorting Algorithm "
                → that "Uses" a "Heap" Data Structure 
                → to "Sort" the "List". 
            
            
            ♦ It "Relies" on "Picking" 
                → the "Largest/ Smallest Element" 
                → from the "Heap" 
                → and "Removing It" 
                → to "Build" the "Sorted List". 
            
            
            ♦ "It" 
                → has an "Execution Time Complexity" of 
                    •► "O(n log n)".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;


public class HeapSort
{
    
    // ▬ "MyHeapSort()" Method ▬
    public static int[] MyHeapSort(int[] arr)
    {
        int n = arr.Length;
        
        // ▼ Build "Heap" by "Re-Arranging" the "Array" ▼
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            // ▼ Call "Method" ▼ ▼
            Heapify(arr, n, i);
        }
        
        
        // ▼ "Extracting" the "Elements" from "Heap" ▼
        for (int i = n - 1; i >= 0; i--)
        {
            // ▼ Call "Method" ▼ ▼
            Swap(arr, 0, i);
            Heapify(arr, i, 0);
        }

        return arr;
    }
    

    // ▬ "Heapify()" Method ▬
    public static void Heapify(int[] arr, int n, int i)
    {
        // ▼ "Variables" ▼
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        
        
        // ▼ 1- "Conditional Statements" ▼
        if(left < n && arr[left] > arr[largest])
        {
            largest = left;
        }
        
        
        // ▼ 2- "Conditional Statements" ▼
        if(right < n && arr[right] > arr[largest])
        {
            largest = right; 
        }
        
        
        // ▼ 3- "Conditional Statements" ▼
        if (largest != i)
        {
            Swap(arr, i, largest);
            Heapify(arr, n, largest);
        }
    }
    
    
    
    // ▬ "Swap()" Method ▬
    public static void Swap(int[] arr, int element1, int element2)
    {
        int swap = arr[element1];
        arr[element1] = arr[element2];
        arr[element2] = swap;
    }
    
    
    
    
    // ▬ "RunHeapSort()" Method ▬
    public static void RunHeapSort()
    {
        // ▼ "Defining" the "Given Array" ▼
        int[] array = { 8, 4, 7, 1, 3, 5 };

        
        // ▼ Display the "Array" Before "Heap Sorting" ▼
        Console.Write("Array Before Heap Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    
        
        // ▼ "Calling" the "Method" for "Sorting" ▼
        array = MyHeapSort(array);

        
        // ▼ "Display" the "Array" After "Heap Sorting" ▼
        Console.Write("\nArray After Heap Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
    }
} 