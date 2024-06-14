/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
                  • "LOGIC OR OPERATOR" (`|`) •
                  
       


    ▬ Logic "Or Operator" (`|`)
        → is "Used" to "Perform" 
        → a "Logical Disjunction Operation" 
        → between the "Bits" 
        → of "Two Numbers". 
    
    
    
    ▬ It "Compares" 
        → "Each" Corresponding "Bit" 
        → in the "Two Numbers" 
        → and "Produces" a "New Number" 
        → in which the "Output Bit" 
        → is "Set" to "1" 
        → if "At Least One" of the "Bits" 
        → is "1". 
    
    
    
    ▬ If "Both Bits" 
        → are "0", 
        → the "Result" will be "0". 
    
    
    
    ▬ If "Both Bits" 
        → are "1", 
        → the "Result" will be "1". 
    
    
    
    ▬ It is often "Used" 
        → to "Set" 
        → or to "Keep" Certain "Bits" 
        → in a "Number".
           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;

public class OrOperator
{
    // ▬ "RunOrOperator()" Method ▬
    public static void RunOrOperator()
    {
        // ▼ "Variables" ▼
        int i = 33;  // ◄◄ "Binary Value": 00011001 ◄◄      
        int j = 129;       // ◄◄ "Binary Value": 10000001 ◄◄
        
        Console.WriteLine("Input Data for 'i': " + i + " -> " + " " + Convert.ToString(i, 2).PadLeft(8, '0'));
        Console.WriteLine("Input Data for 'j': " + j + " -> " + Convert.ToString(j, 2).PadLeft(8, '0'));

        
        // ▼ "OR Operator" ("|") ▼
        Console.WriteLine("\nOr Operator displays 1, If Both Bits are 1 or Either is 1: " + "\n" + (i | j) + " -> " + Convert.ToString(i | j, 2).PadLeft(8, '0'));
    }
} 