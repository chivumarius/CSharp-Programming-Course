/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                           • "SEARCHING" •
                    ───────────────────────────
                       • "BINARY SEARCH" •
                  
                  
                  
    ▬ "BinarySearch"
        → is an Efficient "Search Algorithm" 
        → "Used" to "Quickly Find" an "Element" 
        → in a "Sorted Array". 
    
    
        ♦ It Works 
            → by "Repeatedly Splitting" 
            → the "Array" in "Half" 
            → and "Comparing" 
            → the "Searched Element" 
            → to the "Element" 
            → in the "Middle". 
        
        
        ♦ If the "Element" is "Found" 
            → in the "Middle" of the "Array", 
            → the "Search Ends". 
        
        
        ♦ "Otherwise", 
            → the "Search Continues" 
            → "Only" in the "Right" 
            → or "Left Half" 
            → of the "Array", 
            → "Depending" on the order "Relationship" 
            → of the "Searched Element" 
            → to the "Middle Element".



    ▬ The Main Advantages 
        → of the "BinarySearch" Algorithm 
        → are that "It" is "Fast" 
        → and "Efficient", 
        → as "It" Drastically "Reduces" 
        → the "Number" of "Elements" 
        → that "Need" to be "Checked" 
        → at "Each Step" 
        → of the "Search". 
        
        
        ♦ It is "Important" 
            → that the "Array" is "Pre-Sorted"
            → for this "Algorithm" 
            → to "Work Correctly".
        
               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.searching;



public class BinarySearchBuiltInMethod
{
   
    
    // ▬ "RunBinarySearchBuiltInMethod()" Method ▬
    public static void RunBinarySearchBuiltInMethod()
    {
         // ▼ Creating "Array" ▼
         int[] intArray = new int[6] { 1, 3, 5, 6, 8, 11 };
         
         // ▼ Using "BinarySearch()" Method ▼
         Console.WriteLine("Using BinarySearch() Method, to Find the Index of the Element 6 from Array: " + Array.BinarySearch(intArray, 6));
    }
} 