/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
                • "RIGHT-SHIFT OPERATOR" (`>>`) •
                  

       


    ▬ "Right-Shift Operator" (`>>`)
        → "Shifts Bits" to the "Right" 
        → by a "Certain Number" of "Positions". 
    
    
    
    
    ▬ Each "Bit" 
        → in the "Input Value" 
        → is "Shifted" to the "Right"
        → and "Bits" that "Exceed" 
        → the "Original Length" 
        → are "Removed". 
    
    
    
    
    ▬ For "Positive Integer Values" 
        → the "Left-Hand Bits" of the "Value" 
        → are "Padded" with "Zeros"
        → and for "Negative Integer Values", 
        → the "Left-Hand Bits" 
        → are "Padded" with "Ones". 
    
    
    
    ▬ This "Operator" is "Used" 
        → to Quickly Perform "Integer Division" 
        → by "Powers" of "2" 
        → and to "Optimize" Certain "Algorithms".

           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;



public class RightShiftOperator 
{
    // ▬ "RunRightShiftOperator ()" Method ▬
    public static void RunRightShiftOperator()
    {
        // ▼ "Variables" as "Input Data" ▼
        int i = 128;  // ◄◄ "Binary Value":  1000 0000 (or 128) ◄◄
        Console.WriteLine("Input Data: " + i + " -> " + Convert.ToString(i, 2).PadLeft(8, '0'));
       
        
        
        // ▼ "Shift-Right" Operator
        //      → for "Shifting" the "Variable"
        //      → to the "Right" ▼
        Console.WriteLine("\nBinary Value after Shifting Right with '1': " + (i >> 1) + " -> " + Convert.ToString((i >> 1), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Right with '2': " + (i >> 2) + " -> " + Convert.ToString((i >> 2), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Right with '3': " + (i >> 3) + " -> " + Convert.ToString((i >> 3), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Right with '4': " + (i >> 4) + " -> " + Convert.ToString((i >> 4), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Right with '5': " + (i >> 5) + " -> " + Convert.ToString((i >> 5), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Right with '6': " + (i >> 6) + " -> " + Convert.ToString((i >> 6), 2).PadLeft(8, '0'));
        Console.WriteLine("Binary Value after Shifting Right with '7': " + (i >> 7) + " -> " + Convert.ToString((i >> 7), 2).PadLeft(8, '0'));
    }
} 