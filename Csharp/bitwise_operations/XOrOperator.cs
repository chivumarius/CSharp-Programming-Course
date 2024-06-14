/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
                      • "XOR OPERATOR" •
                  

       


    ▬ Bitwise "XOR Operator" (`^`)
        → is "Used" 
        → to Perform an Exclusive "Logical Disjunction Operation" 
        → between the "Bits" 
        → of "Two Numbers". 
    
    
    
    ▬ It "Compares" 
        → "Each" Corresponding "Bit" 
        → in the Two Numbers 
        → and "Produces" a "New Number" 
        → in which the "Output Bit" 
        → is "Set" to "1" 
        → "Only" if "One" of the "Bits" 
        → is "1", 
        → but "Not Both". 
    
    
    
    ▬ If "Both Bits" 
        → are "Identical", 
        → the "Result" 
        → will be "0".
           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;


public class XOrOperator
{
    // ▬ "RunXOrOperator()" Method ▬
    public static void RunXOrOperator()
    {
        // ▼ "Variables" ▼
        int i = 33;  // ◄◄ "Binary Value": 00011001 ◄◄      
        int j = 129;       // ◄◄ "Binary Value": 10000001 ◄◄
        
        Console.WriteLine("Input Data for 'i': " + i + " -> " + " " + Convert.ToString(i, 2).PadLeft(8, '0'));
        Console.WriteLine("Input Data for 'j': " + j + " -> " + Convert.ToString(j, 2).PadLeft(8, '0'));

        
        // ▼ "XOR Operator" ("^") ▼
        Console.WriteLine("\nXOR Operator displays 1, Only if One has the Value 1 and the Other is 0: " + "\n" + (i ^ j) + " -> " + Convert.ToString(i ^ j, 2).PadLeft(8, '0'));
        
    }
}       