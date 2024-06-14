/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
                       • "AND OPERATOR" •
                  

       


    ▬ "And Operator" ("&")
        → is "Used" 
        → to Perform a Logical "Concatenation Operation" 
        → between the "Bits" 
        → of "Two Numbers". 
    
    
    
    ▬ It "Compares" 
        → Each "Corresponding Bit" 
        → in the Two Numbers 
        → and "Produces" a "New Number" 
        → in which the "Output Bit" is "Set"
        → to "1" 
        → "Only" if "Both" Corresponding "Bits" 
        → are "1".

           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;


public class AndOperator
{
    // ▬ "RunAndOperator()" Method ▬
    public static void RunAndOperator()
    {
        // ▼ "Variables" ▼
        int i = 33;  // ◄◄ "Binary Value": 00011001 ◄◄      
        int j = 129;       // ◄◄ "Binary Value": 10000001 ◄◄
        
        Console.WriteLine("Input Data for 'i': " + i + " -> " + " " + Convert.ToString(i, 2).PadLeft(8, '0'));
        Console.WriteLine("Input Data for 'j': " + j + " -> " + Convert.ToString(j, 2).PadLeft(8, '0'));
        
        // ▼ "And Operator" ("&") ▼
        Console.Write("\nAnd Operator (Display '1' if both Compared Bits are '1'): " + (i & j));  
    }
} 