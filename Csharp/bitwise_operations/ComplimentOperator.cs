/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "BITWISE OPERATIONS" •
                    ────────────────────────
             • "BITWISE COMPLIMENT OPERATOR" ('~')•
                  

       


    ▬ The "Bitwise Compliment Operator" in "C#" ("~")
         → is "Used" to "Negate" Each "Bit" 
         → of the "Operand", 
         → "Turning":
            •► All "0s" into "1s"  and 
            •► All "1s" into "0s".

    
    
    ▬ Binary Values:                                      
        • "0"":  0000 0000   0 0 0 0    (Base 2)
        • "1"":  0000 0001 
        • "2"":  0000 0010  
        • "4"":  0000 0100 
        • "8"":  0000 1000 
        • "16"": 0001 0000
        • "32"": 0010 0000
        • "64"": 0100 0000
        • "128"": 1000 0000         
                    
         
         
                    
    ▬ Binary Representation: 
                                     
                    128  64  32  16  8  4  2  1    (Base 2)
                    ───────────────────────────              
        ♦ "13":     0    0   0   0   1  1  0  1 
          
          
            • "Binary Value": 8 + 4 + 1 = 13
    
    
    
    
    ▬ Binary Representation of "Compliment": 
                                     
                    128  64  32  16  8  4  2  1    (Base 2)
                    ───────────────────────────              
        ♦ "13":     1    1   1   1   0  0  1  0 
          
          
            • "Binary Value" of "Compliment": 128 + 64 + 32 + 16  +  2 = 242  
           
  
  
  
    ▬ Bitwise "Operator Precedence" (or "Order" of "Evaluation") 
        → refers to how "Bitwise Operators" 
        → are "Evaluated" 
        → in "Multi-Operator Expressions". 
        
        
        ♦ "Precedence" 
            → is "Important" 
            → to "Determine" the "Correct Order" 
            → of "Expression Evaluation".




    ▬ In "General", 
        → in "Programming Languages", 
        → "Bitwise Operators" 
        → have the Following "Precedence", 
        → from "Highest" to "Lowest":

        1. ~ (Bitwise Complement)
        2. << (Shift Left) and >> (Shift Right)
        3. & (Logical And)
        4. ^ (XOr Exclusive)
        5. | (Logical Or)



   ▬ This "Order" 
        → "Indicates" that the "Complement Operations" 
        → are "Evaluated First", 
        → Followed by the "Left" and "Right Shift Operations", 
        → then the "And", 
        → then "XOr" and 
        → finally the Logical "Or" Operations. 
    
    
    
    ▬ "Precedence" 
        → can be "Changed" 
        → by using "Parentheses" 
        → to "Control" the "Order" 
        → of "Evaluation".
   
   
   
   ▬ "Overloading Operators"
        ♦ "Bitwise Operators" 
        → can be "Overloaded" 
        → with "Other" "Operators":
            • '|' (Or)
            • '^' (XOr)  
            • '&' (And)          
            • '<<' (Shift Left)
            • '>>' (Shift Right)
          
   
        ♦ Can Not be "Explicitly Overloaded", 
        → but their Corresponding "Binary Operator" 
        → can be "Overloaded":
            • '|=' (Or Equal)
            • '^=' (XOr Equal)  
            • '&=' (And Equal)          
            • '<<=' (Shift-Left Equal)
            • '>>=' (Shift-Right Equal)
            
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.bitwise_operations;


public class ComplimentOperator
{
    

    // ▬ "RunComplimentOperator()" Method ▬
    public static void RunComplimentOperator()
    {
        byte byteOfData = 13; // ◄◄ Binary Value: 0000 1101 ◄◄

        // ▼ "Compliment Operator" on "8 Bit" Data ▼
        byte compliment = (byte)(~byteOfData & 0xFF); 

        
        
        // ▼ "Print Data" ▼
        Console.WriteLine($"Data Value: {byteOfData}");
        
        
        // ▼ "Print Binary Value" ▼
        Console.WriteLine($"Binary Value: {Convert.ToString(byteOfData, 2).PadLeft(8, '0')}");
        
        
        // ▼ "Print Compliment Binary Value" ▼
        Console.WriteLine($"Binary Value of Compliment: {Convert.ToString(compliment, 2).PadLeft(8, '0')}");
    }
} 