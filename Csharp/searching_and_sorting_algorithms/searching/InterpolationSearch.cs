/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                           • "SEARCHING" •
                    ───────────────────────────
                    • "INTERPOLATION SEARCH" •
                  
                  

                  
    ▬ "Interpolation Search" 
        → requires that the "Elements" are "Sorted"
        → and that the "Elements" are "Uniformly Distributed". 


        ♦ "It"
            → is an Improvement of the "Binary Search" 
            → because its doesn't Start in the Middle. 


        ♦ "If" it is "Looking"
            → for an "Element Closer"
            → to the "Beginning",
            → it will "Start Closer" to the "Beginning"
            → and Vice-Versa.
    
        ♦ "It"
            → Uses the "Calculation" 
            → of the "Probe Position",
            → which is the "Only Difference "
            → between "Binary Search" 
            → and "Interpolation Search".


    ▬ The "Formula"
        → for "Calculating"
        → the "Probe Position":

       ─────────────────────────────────────────────────────────────────────
          probe = low end + (high end - low end)
                * (item data[lowEnd]) / data[highEnd] - data[lowEnd]
       ────────────────────────────────────────────────────────────────────
               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.searching;



public class InterpolationSearch
{
    
    // ▬ "MyInterpolationSearch()" Method ▬
    int MyInterpolationSearch(int[] arr, int length, int searchedElement)    
    {
        // ▼ "Variables" ▼
        int low = 0;
        int high = length - 1;
        
        
        // ▼ "While" Loop ▼
        while (low <= high && searchedElement >= arr[low] && searchedElement <= arr[high])
        {
            if(low == high)
            {
                if(arr[low] == searchedElement)
                {
                    return low;
                }
                else
                {
                    return -1;
                }
            }
            
            
            // ▼ "Calculation" of "Probe Position" ▼
            int probePosition = low + (high - low) * (searchedElement - arr[low]) / (arr[high] - arr[low]);
            
            
            if(arr[probePosition] == searchedElement)
            {
                return probePosition;
            }
            
            
            if(arr[probePosition] < searchedElement)
            {
                low = probePosition + 1;
            }
            else
            {
                high = probePosition - 1;
            }
        }
        
        
        // ▼ If "Element" is "Not Found" ▼
        return -1;
    }
    
    

    // ▬ "RunInterpolationSearch()" Method ▬
    public static void RunInterpolationSearch()
    {
        // ▼ "Sorted Array" ▼
        int[] sortedArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // Sorted array
        
        // ▼ "Element" to "Search" ▼
        int searchElement = 40; 
    
        
        // ▼ "Create" an "Instance" of "InterpolationSearch" Class ▼
        InterpolationSearch interpolationSearch1 = new InterpolationSearch();
        
        // ▼ Perform "Interpolation Search" ▼
        int result = interpolationSearch1.MyInterpolationSearch(sortedArray, sortedArray.Length, searchElement); 
    
        
        // ▼ "Check": If the "Element" was "Found"
        //      → and "Display" the "Result" ▼
        if (result != -1)
        {
            Console.WriteLine($"Element {searchElement} Found at Position {result}.");
        }
        else
        {
            Console.WriteLine($"Element {searchElement} Not Found.");
        }
    }
} 