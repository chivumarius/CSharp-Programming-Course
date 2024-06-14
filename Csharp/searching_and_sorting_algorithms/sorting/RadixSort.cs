/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                            • "SORTING" •
                    ───────────────────────────
                          • "RADIX SORT" •
                  

                  
                  
    ▬ "Radix Sort":
            → is a "Non-Comparative Sorting Algorithm" 
            → that "Works" 
            → on the "Principle" 
            → of "Dividing Numbers" 
            → into "Groups" 
            → "Based" on their "Digits", 
            → "Starting" with the "Least Significant" and
            → "Continuing" with the "Most Significant".
            
            
            ♦ "It" is "Efficient" 
                → for S"orting Integers" 
                → and "Other Types" of "Keys", 
                → and Its "Execution Time" 
                → is "Influenced" 
                → by the "Number" of "Digits" 
                → and the "Number" of "Distinct Values" 
                → a "Digit" can "Have".
            
            
            ♦ There are "Two Main Variants": 
                    1- "Radix Sort LSD" ("Least Significant Digit") and 
                    2- "Radix Sort MSD ("Most Significant Digit"), 
                → each with "Specific Uses" 
                → and "Advantages".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.sorting;


public class RadixSort
{
    // ▬ "MyRadixSort()" Method ▬
    public static int[] MyRadixSort(int[] data)
    {
        // ▼ "Array" ▼
        int[] temp = new int[data.Length];
        
        
        // ▼ "Loop" ▼
        for (int shift = 31; shift > -1; shift--)
        {
            int j = 0;

            for(int i = 0; i < data.Length; i++)
            {
                bool move = (data[i] << shift) >= 0;  
                
                // ▼ Do Not Move if "shift" is "zero"
                //      → and "move" is "false" ▼
                if (shift == 0 ? !move : move)
                {
                    data[i - j] = data[i];
                }
                else
                {
                    temp[j++] = data[i];
                }
            }
            
            // ▼ Copy Array ▼
            Array.Copy(temp, 0, data, data.Length - j, j);
        }
        
        // ▼ "Return" ▼
        return data;
    } 
    
    

    // ▬ "RunRadixSort()" Method ▬
    public static void RunRadixSort()
    {
        // ▼ "Defining" the "Given Array" ▼
        int[] array = { 101, 304, 400 };

        
        // ▼ "Display" the "Array" Before "Radix Sorting" ▼
        Console.Write("Array Before Radix Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }

        
        // ▼ "Calling" the "Method" for "Sorting" the "Array" ▼
        array = MyRadixSort(array);

        
        // ▼ "Display" the "Array" After "Radix Sorting" ▼
        Console.Write("\nArray After Radix Sorting: ");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    
        Console.WriteLine();       
    }
} 