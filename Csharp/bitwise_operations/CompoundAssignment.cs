/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
                    • "COMPOUND ASSIGNMENT" ('=')•
                  

       


    ▬ "Compound Assignment"
        → is a "Programming Concept" 
        → that "Combines" an "Arithmetic" 
        → or "Assignment Operation" 
        →  with a "Simple Assignment Operation" ("="). 
        
       
        
    ▬ For "Example" 
        → the "Compound Operator" - "+=" 
        → "Adds" a "Value" 
        → to the "Existing Variable" 
        → and "Assigns" the "Result" 
        → "Back" to the "Same Variable".

           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;


public class CompoundAssignment
{
    // ▼ "Variables" ▼
    static int i = 33;      // ◄◄ "Binary Value": 00011001 ◄◄      
    static int j = 129;     // ◄◄ "Binary Value": 10000001 ◄◄
    
    
    
    // ▬ "RunCompoundAssignment()" Method ▬
    public static void RunCompoundAssignment()
    {
        // ▼ "Input Data" ▼
        Console.WriteLine("Input Data for 'i': " + i + " -> " + " " + Convert.ToString(i, 2).PadLeft(8, '0'));
        Console.WriteLine("Input Data for 'j': " + j + " -> " + Convert.ToString(j, 2).PadLeft(8, '0'));

        
        // ▼ "Compound Assignment" ('=')
        //      → with "Bitwise And" ('&') ▼
        i &= j;
        Console.WriteLine("\nCompound Assignment with AND ('i &= j'): " + " " + i + " " + " -> " + Convert.ToString(i, 2).PadLeft(8, '0'));
        
        
        // ▼ "Compound Assignment" ('=')
        //      → with "Bitwise Logical Or" ('|') ▼
        i |= j;
        Console.WriteLine("Compound Assignment with OR ('i |= j'): " + " " + i + " -> " + Convert.ToString(i, 2).PadLeft(8, '0'));
        
        
        // ▼ "Compound Assignment" ('=')
        //      → with "Bitwise XOrr" ('^') ▼
        i ^= j;
        Console.WriteLine("Compound Assignment with XOR ('i ^= j'): " + " " + i + " " + " -> " + Convert.ToString(i, 2).PadLeft(8, '0'));
    }
} 