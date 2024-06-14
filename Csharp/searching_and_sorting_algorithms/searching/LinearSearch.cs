/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "SEARCHING" & "SORTING" •
                           • "SEARCHING" •
                    ───────────────────────────
                    • "LINEAR SEARCH" •
                  
                  
                  
    ▬ "Searching"
        → refers to the "Process" of "Searching" 
        → for a Specific Ele"ment" 
        → or Pa"ttern" 
        → in a "Specific Data Collection" 
        → or "Data Structure". 



        ♦ This "Process" 
            → can be done using different techniques and algorithms depending on the nature of the data and application requirements.



    ▬ There are Several "Search Methods" 
        → available in "C#", 
        → "Each" with "Specific Advantages" 
        → and "Uses". 



    ▬ "Search Methods" 
        → can be Considered "Search Algorithms" 
        → because "They" 
        → are a "Set" of "Defined Steps" 
        → and "Rules" 
        → that are "Used" 
        → to "Find" a Specific Element 
        → or "Pattern" 
        → in a "Data Collection" 
        → or a "Specific Data Structure".





        ▬ "Types" of "Search Methods":

            1. "Direct Search": 
                ♦ "This" 
                    → involves "Sequentially Traversing" 
                    → the "Elements" of a "Collection" 
                    → to "Find" the "Desired Element". 
                
                
                ♦ For "Example": 
                    → to "Search" 
                    → for an "Element" 
                    → in an Array, 
                    → one "Traverses" the "Array" 
                    → from "Beginning" to "End" 
                    → and Checks "Each Element".

            
            
            2. "Binary Search": 
                ♦ "This" 
                    → is an "Efficient Algorithm" 
                    → for "Searching Ordered Collections "
                    → such as "Ordered Arrays" 
                    → or "Lists". 
                 
                    
                ♦ The "Algorithm" 
                    → Repeatedly "Splits" 
                    → the "Collection" 
                    → in "Half" 
                    → and "Compares" 
                    → the "Searched Element" 
                    → with the "Element" 
                    → in the "Middle". 
                
                
                ♦ "Based" on this "Comparison", 
                    → it "Continues Searching" 
                    → the "Corresponding Half" 
                    → until it "Finds" the "Element" 
                    → or the "Collection Ends".

            

            3. "Pattern Search" ("Regex"): 
                ♦ "This" is "Used" 
                    → to "Search" for "Text Patterns" 
                    → in a "String" 
                    → using "Regular Expressions". 
                
                
                ♦ "It" is "Useful" 
                    → for "Searching" and "Extracting Data" 
                    → from "Text" 
                    → "According" to "Certain Rules" 
                    → "Defined" by "Templates".


            
            4. "Searching" Using "Collection Search Methods": 
                ♦ Many C# "Standard Library Collection" Classes 
                    → (such as "List", "Dictionary", "HashSet", etc.) 
                    → provide "Special Search Methods" 
                    → such as: 
                        •► "Contains()", 
                        •► "Find()" , 
                        •► "FindIndex()" etc., 
                    → which can be "Used" 
                    → to "Search" for "Elements" 
                    → in "Collections" 
                    → "Without" having to "Manually" 
                    → Implement "Search Algorithms".



    ▬ In "General", 
        → the "Selection" 
        → of the Right "Search Method" 
        → "Depends" on the "Size" 
        → and "Nature" of the "Data", 
        → the "Efficiency" 
        → and the "Complexity" of the "Algorithm"
        → and the "Specific Requirements" 
        → of the "Application".




    ▬ "Linear Search": 
        → is the "Search Method" 
        → that "Finds" an "Element" 
        → in a "List" 
        → or "Array".    
    
               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.searching_and_sorting_algorithms.searching;



public class LinearSearch
{
    
    
    // ▬ "linearSearch()" Method ▬
    public static int MyLinearSearch(List<int> elements, int x)
    {
        // ▼ "Variable" ▼
        int length = elements.Count;
        
        // ▼ "Iterating"
        //      → if the "Element Exist"
        //      → in the "List" ▼
        for (int i = 0; i < length; i++)
        {
            // ▼ Checking: If te "Element"
            //      → is the "Searched Element" ▼ 
            if (elements[i] == x)
            {
                return i;
            }
        }
        
        // ▼ If the "Element" is "Not Found" ▼
        return -1;
    }

    
    
    
    // ▬ "RunLinearSearch()" Method ▬
    public static void RunLinearSearch()
    {
        // ▼ Creating a "List" of "Elements" ▼
        List<int> elements = new List<int>() { 10, 20, 30, 40, 50 };

        // ▼ The "Element" we are "Searching For" ▼
        int searchedElement = 30;

        
        // ▼ "Calling" the "Method" ▼
        int position = MyLinearSearch(elements, searchedElement);

        
        // ▼ "Displaying" the "Result" ▼
        if (position != -1)
        {
            Console.WriteLine($"The Element {searchedElement} was Found at Position {position +1}.");
        }
        else
        {
            Console.WriteLine($"The Element {searchedElement} was Not Found in the List.");
        }
    }
}  