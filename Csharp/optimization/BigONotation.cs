/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "OPTIMIZATION" •
                    ────────────────
                   • "BIG O" NOTATION •

       


    ▬ Big "O" Notation
        → is a "Fundamental Notion" 
        → in the "Complexity Analysis" 
        → of "Algorithms". 


        ♦ It "Expresses" 
            → the "Performance" or "Efficiency" 
            → of "Algorithms" 
            → as a "Function" 
            → of the "Size" 
            → of the "Input Data".


    ▬ Basically, "Big O" Notation 
        → provides an "Asymptotic Upper Bound" 
        → on the "Execution Time" 
        → or "Memory Space" 
        → "Required" by an "Algorithm" 
        → as a "Function" 
        → of the "Size" 
        → of the "Input Data".



    ▬ For "Example": 
        • An "Algorithm" 
            → with a "Complexity" of 
                •► "O(n)" 
            → has "Linear Performance", 
            → which "Means" 
            → that the "Execution Time" 
            → "Increases" in "Direct Proportion" 
            → to the "Size" 
            → of the "Input Data". 


        • In "Contrast", 
            → an "Algorithm" with 
                •► "O(n^2)" Complexity 
            → has Q"uadratic Performance", 
            → "Meaning" that the "Execution Time" 
            → "Increases Quadratically" 
            → with the "Size" 
            → of the "Input Data".



    ▬ "Big O" Notation 
        → helps us "Compare Algorithms" 
        → and "Understand" 
        → how "They Behave" 
        → as the "Size" of the "Input Data" 
        → "Increases", 
        → which is "Crucial" 
        → in "Algorithm Design" 
        → and "Optimization".



    ▬ "Types" of "Big O" Notation (Most Common ), 
        → which Reflect Different Behaviors 
        → of Increasing Complexity 
        → of Algorithms 
        → Depending on the Size 
        → of the Input Data:


        1. "O(1)" - "Constant Time": 
            
            ♦ The "Execution Time" 
                → of the "Algorithm" 
                → is "Constant". 


            ♦ "Regardless" 
                → of the "Size" 
                → of the "Input Data", 
                → the "Execution Time" 
                → "Remains Constant".



        2. "O(log n)" - "Logarithmic Time": 
            
            ♦ The "Execution Time" 
                → of the "Algorithm" 
                → "Increases Logarithmically" 
                → "According" to the "Size" 
                → of the "Input Data". 


            ♦ This "Means" 
                → that the "Execution Time" 
                → "Grows Slowly", 
                → "Even" when the "Input Data" 
                → "Grows Rapidly".



        3. "O(n)" - "Linear Time": 
            
            ♦ The "Execution Time" 
                → of the "Algorithm" 
                → I"ncreases Directly Proportional" 
                → to the "Size" 
                → of the "Input Data". 


            ♦ It is "Considered" 
                → a "Good Performance" 
                → because the "Execution Time" 
                → "Increases" at a "Constant Rate".



        4. "O(n log n)" - "Linearithmic Time": 
            
            ♦ The "Execution Time" 
                → of the "Algorithm" 
                → is "Multiplied" 
                → by the "Logarithm" 
                → of the Size 
                → of the "Input Data". 

            ♦ It is "Found" 
                → in "Efficient Sorting" 
                → and "Searching Algorithms" 
                → such as: 
                    •► "QuickSort" and 
                    •► "MergeSort".



        5. "O(n^2)", 'O(n^3)', ... - "Polynomial Time": 
            
            ♦ "Algorithm Execution Time" 
                → "Increases" 
                    •► "Quadratically", 
                    •► "Cubically" or in a 
                    •► Higher Degree "Polynomial" 
                → "Depending" on the "Size" 
                → of the "Input Data". 


            ♦ "This" 
                → can be "Inefficient" 
                → for "Large Data Sets".



        6. "O(2^n)", "O(n!)" - "Exponential" & "Factorial Time": 
            
            ♦ The "Execution Time" 
                → of the "Algorithm" 
                → "Increases": 
                    •► "Exponentially" or
                    •► "Factorially" 
                → "Depending" on the "Size" 
                → of the "Input Data". 


            ♦ "These" 
                → are Often "Considered" 
                → "Unacceptable" for "Large Data Sets", 
                → due to the "Rapid Increase" 
                → in "Execution Time".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.optimization;


//──────────────────────────────────────────────────────────────
// ▬ "BigONotation" Class ▬
public class BigONotation
{
    //---------------------------------------------------------
    // (1) "Constant Runtime" Algorithm ("O(1)")
    //      ▬  "ReturnFirstArrayElementWithConstantRuntime()" Method ▬
    public static int ReturnFirstArrayElementWithConstantRuntime(int[] elements)
    {
        return elements[0];
    }
    
    
    
    //---------------------------------------------------------
    // (2) "Linear Runtime" Algorithm ("O(n)")
    //      ▬  "ReturnArrayElementWithLinearRuntime()" Method ▬
    public static bool ReturnArrayElementWithLinearRuntime(int[] elements, int value)
    {
        // ▼ "For Loop" ▼
        for (int i = 0; i < elements.Length; i++)
        {
            // ▼ "Check" ▼
            if (elements[i] == value)
            {
                return true; // Return true if value is found
            }
        }
        
        // ▼ "Return" ▼
        return false; // Return false if value is not found
    }
    
    
    
    
    //---------------------------------------------------------
    // (3) "Quadratic Runtime" Algorithm ("O(n^2)")
    //      ▬  "QuadraticRuntime()" Method ▬
    public static void QuadraticRuntime()
    {
        // ▼ "Array" Initialization ▼
        int[] collection = new int[]{ 1, 2, 3 }; 
        
        // ▼ "Message Display" ▼
        Console.WriteLine("\n (3) Quadratic Runtime 'O(n^2)' for '3^2' is: ");
        
        
        // ▼ "Foreach()" Loop ▼
        foreach(int i in collection)
        {
            // ▼ "Nested Foreach()" Loop ▼
            foreach(int j in collection)
            {
                Console.Write("\t- " + " " + i + " " + j + "\n");
            }
        }
    }
    
    
    
    
    //---------------------------------------------------------
    // (4) "Cubic Runtime" Algorithm ("O(n^3)")
    //      ▬  "CubicRuntime()" Method ▬
    public static void CubicRuntime()
    {
        // ▼ "Array" Initialization ▼
        int[] collection = new int[]{ 1, 2 }; 
        
        // ▼ "Message Display" ▼
        Console.WriteLine("\n (4) Cubic Runtime 'O(n^3)' for '2^3' is: ");
        
        
        // ▼ "For Loop" ▼
        for(int i = 0; i < collection.Length; i++)
        {
            // ▼ "1st Nested For Loop" ▼
            for(int j = 0; j < collection.Length; j++)
            {
                // ▼ "2nd Nested For Loop" ▼
                for(int k = 0; k < collection.Length; k++)
                {
                    Console.Write("\t- " + " " + i + " " + j + " " + k + "\n");
                }
            }
        }
    }
    
    
    
    
    
    // ▬ "RunBigONotation()" Method ▬
    public static void RunBigONotation()
    {
        //---------------------------------------------------------
        // (1) "\nConstant Runtime" Algorithm ("O(1)")
        
        // ▼ "Array" Initialization ▼
        int[] array = { 3, 7, 12, 9, 5 };

        // ▼ "Display" the "Array" ▼
        Console.Write("The 'Array' is: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        
        
        // ▼ "Method Call" ▼
        int firstElement = ReturnFirstArrayElementWithConstantRuntime(array);

        // ▼ "Display" the "Result" ▼
        Console.WriteLine("\n\n (1) The 'First Element' of the 'Array' with 'Constant Runtime' (\"O(1)\") is: " + firstElement + "\n");
        
        
        
        
        //---------------------------------------------------------
        // (2) "Linear Runtime" Algorithm ("O(n)")

        // ▼ "Method Call" ▼
        int valueToFind = 12; // Example Value to Find
        bool found = ReturnArrayElementWithLinearRuntime(array, valueToFind);

        // ▼ "Display" the "Result" ▼
        if (found)
        {
            Console.WriteLine($" (2) The 'Value {valueToFind}' was 'Found' in the 'Array'.");
        }
        else
        {
            Console.WriteLine($" (2) The 'Value {valueToFind}' was 'Not Found' in the 'Array'.");
        } 
        
        
        
        
        //---------------------------------------------------------
        // (3) "Quadratic Runtime" Algorithm ("O(n^2)")
        // ▼ "Method Call" ▼
        QuadraticRuntime();
        
        
        
        
        //---------------------------------------------------------
        // (4) "Cubic Runtime" Algorithm ("O(n^3)")
        // ▼ "Method Call" ▼
        CubicRuntime();
    }
} 