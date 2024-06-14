/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
                • "LEFT-SHIFT OPERATOR" (`<<`)•
                  

       


    ▬ "Left-Shift Operator" (`<<`)
        → "Shifts Bits" to the "Left" 
        → by a "Specified Number" of "Positions". 
        
        
    ▬ Each "Bit" 
        → in the "Input Value" 
        → is "Shifted" to the "Left" 
        → and "Bits" that "Exceed" 
        → the "Original Length" 
        → are "Removed". 
    
    
    
    ▬ "New Bits" 
        → "Added" to the "Right" 
        → are "Padded" with "Zeros". 
        
        
        
    ▬ This "Operator" is "Used" 
        → to Quickly Perform "Integer Multiplication Operations" 
        → by "Powers" of "2" 
        → and to "Optimize" Certain "Algorithms".

           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;



public class LeftShiftOperator
{
    
    // ▬ "RunLeftShiftOperator()" Method ▬
    public static void RunLeftShiftOperator()
    {
        // ▼ "Variables" as "Input Data" ▼
        int i = 2;  // ◄◄ "Binary Value":  0000 0010 (or 2) ◄◄
        Console.WriteLine("Input Data: " + i + " -> " + Convert.ToString(i, 2).PadLeft(8, '0'));
       
        
        
        // ▼ "Shift-Left" Operator
        //      → for "Shifting" the "Variable"
        //      → to the "Left" ▼
        Console.WriteLine("\nBinary Value after Shifting Left with '1': " + (i << 1) + " -> " + Convert.ToString((i << 1), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Left with '2': " + (i << 2) + " -> " + Convert.ToString((i << 2), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Left with '3': " + (i << 3) + " -> " + Convert.ToString((i << 3), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Left with '4': " + (i << 4) + " -> " + Convert.ToString((i << 4), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Left with '5': " + (i << 5) + " -> " + Convert.ToString((i << 5), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Left with '6': " + (i << 6) + " -> " + Convert.ToString((i << 6), 2).PadLeft(8, '0'));
    }
} 