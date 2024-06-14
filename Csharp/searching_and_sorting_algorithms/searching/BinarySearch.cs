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


public class BinarySearch
{
    
    
    // ▬ "MyBinarySearch()" Method ▬
    public static void MyBinarySearch(List<int> listOfElements, int searchedElement)
    {
         // ▼ "Variables" ▼
         int start = 0;
         int stop = listOfElements.Count - 1;
         int middle = (start + stop) / 2;
         
         
         // ▼ "Looping" ▼
         while (listOfElements[middle] != searchedElement && start <= stop)
         {
             if (searchedElement < listOfElements[middle])
             {
                 // ▼ "Left Half" ▼
                 stop = middle - 1;
             }
             else
             {
                 // ▼ "Right Half" ▼
                 start = middle + 1;
             }
             
             
             // ▼ "Updating" "Middle" "Index" ▼
             middle = (start + stop) / 2;
         }
         
         
         // ▼ "Result" ▼
         if (listOfElements[middle] == searchedElement)
         {
             Console.WriteLine("Element Found at Index: " + middle);
         }
         else
         {
             Console.WriteLine("Element Not Found");
         }
    }

    
    
    
    
    // ▬ "RunBinarySearch()" Method ▬
    public static void RunBinarySearch()
    {
        // ▼ Creating "List" "Of" "Elements" ▼
        List<int> sortedList = new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };
        
        // ▼ "Searching" "For" "Element" ▼
        int searchedElement = 12;

        
        
       
        // ▼ "Printing" the "Searched Element" ▼
        Console.WriteLine("Searching for Element: " + searchedElement);
        
        // ▼ Finding "Element" "Index" ▼
        MyBinarySearch(sortedList, searchedElement);          
    }
} 