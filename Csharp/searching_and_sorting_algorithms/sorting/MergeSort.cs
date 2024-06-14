/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                          • "MERGE SORT" •
                  
                  
    ▬ "Merge Sort": 
            ♦ "It" 
                → is an "Efficient" and "Stable Sorting Algorithm" 
                → that "Splits" the "List" 
                → in "Half", 
                → "Sorts" Each "Half" Separately, 
                → then "Combines" the "Sorted Halves" 
                → into a "Single Sorted List". 
            
            
            ♦ "It" 
                → has an "Execution Time Complexity" of 
                    •► "O(n log n)".

               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;



public class MergeSort
{
    
    // ▬ "MyMergeSort()" Method ▬
    public static int[] MyMergeSort(int[] array)
    {
       // ▼ "Variables" ▼
       int[] left;
       int[] right;
       int[] result = new int[array.Length];
       
       
       // ▼ "Conditional Statements" ▼
       if(array.Length <= 1)
       {
           return array;
       }
       
       
       // ▼ "Storing" the "Middle Point Position" in the "Array" ▼
       int middlePoint = array.Length / 2;
       
       
       // ▼ Setting "Left" Array ▼
       left = new int[middlePoint]; 
       
       
       // ▼ "Building" the "Left Sub-Array" ▼
       if(array.Length % 2 == 0)
       {
           // ▼ Setting "Right" Array ▼
           right = new int[middlePoint];
       }
       else
       {
           // ▼ Setting "Right" Array ▼
           right = new int[middlePoint + 1];
       }
       
       
       // ▼ "iterating" over the "Left Sub-Array" ▼
        for(int i = 0; i < middlePoint; i++)
        {
            // ▼ "Building" the "Left Sub-Array" ▼
            left[i] = array[i];
        }
        
        
        // ▼ "iterating" over the "Right Sub-Array" ▼
        int x = 0; 
        for(int i = middlePoint; i < array.Length; i++)
        {
            // ▼ "Building" the "Right Sub-Array" ▼
            right[x] = array[i];
            x++;
        }
        
        
        // ▼ "Recursively Calls" ▼
        left = MyMergeSort(left);
        right = MyMergeSort(right);
        
        // ▼ "Coll" the "Method" ▼
        result = Merge(left, right);
        
        // ▼ "Returning" the "Result" ▼
        return result;
    }
    
    
    
    
    // ▬ "Merge()" Method ▬
    public static int[] Merge(int[] left, int[] right)
    {
        // ▼ "Variables" ▼
        int arrayLength = left.Length + right.Length;
        int[] result = new int[arrayLength];
        
        int indexLeft = 0;
        int indexRight = 0;
        int indexResult = 0;
        
        
        // ▼ "While" Loop ▼
        while(indexLeft < left.Length || indexRight < right.Length)
        {
            if(indexLeft < left.Length && indexRight < right.Length)
            {
                // ▼ "Comparing" the "Elements" ▼
                if(left[indexLeft] <= right[indexRight])
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            else if(indexLeft < left.Length)
            {
                result[indexResult] = left[indexLeft];
                indexLeft++;
                indexResult++;
            }
            else if(indexRight < right.Length)
            {
                result[indexResult] = right[indexRight];
                indexRight++;
                indexResult++;
            }
        }
        
        // ▼ "Returning" the "Result" ▼
        return result;
    }

    
    
    // ▬ "PrintArray()" Method ▬
    public static void PrintArray(int[] array)
    {
        foreach (var item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    
    
    
    
    // ▬ "RunMergeSort()" Method ▬
    public static void RunMergeSort()
    {
        int[] array = { 38, 27, 43, 3, 9, 82, 10 };
    
        Console.Write("Array Before Merge Sorting: ");
        PrintArray(array);
    
        array = MyMergeSort(array);
    
        Console.Write("Array After Merge Sorting: ");
        PrintArray(array);         
    }
} 