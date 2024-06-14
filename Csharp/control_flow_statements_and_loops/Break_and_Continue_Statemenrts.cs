namespace CSharp.control_flow_statements_and_loops;

public class Break_and_Continue_Statemenrts
{
    public static void BreakAndContinueStatemenrts()
    {
        /*
            ♦ The "Break" Statement 
                → is "Used" to "Exit" 
                → from a "Loop" (such as "For", "While", "Do-While") 
                → or from a "Control Structure" (such as "Switch") 
                → "Prematurely", 
                → "Before" it "Finishes Normally".

            • When the "Break" Statement 
                → is "Executed", 
                → "Program Control" is Immediately "Transferred" 
                → "Out" of the "Control Structure" 
                → in which it is "Located".
           
              
            
            ♦ The "Continue" Statement 
                → is "Used" to "Skip" a "Iteration" 
                → and to "Move" 
                → to the "Next Iteration" of a "Loop", 
                → "Ignoring" any "Remaining Code" 
                → within that "Iteration".

            ♦ When the "Continue" Statement 
                → is "Executed", any "Code" 
                → within the "Loop" 
                → that "Follows Continue" 
                → is "No Longer Executed" 
                → in that "Particular Iteration"
                → and "Control" is "Transferred Directly" 
                → to "Checking" the "Conditions" 
                → for the "Next Iteration".
         */
        
        // ▼ "Switch" Statement ▼
        Console.WriteLine("Switch Statement with Break Statement:");
       
        int value = 2;
        
        switch (value)
        {
            case 1:
                Console.WriteLine("Value is 1");
                break;
            
            case 2:
                Console.WriteLine("Value is 2");
                break;
            
            case 3:
                Console.WriteLine("Value is 3");
                break;

            default:
                Console.WriteLine("Value is not between 1 and 3");
                break;
        }
        
        
        Console.WriteLine("\n");
        
        
        // ▼ "For" Loop ▼
        Console.WriteLine("For Loop with Break Statement:");
        
        for (int i = 0; i < 6; i++)
        {
            if (i == 3)
            {
                // ▼ The  Value "3" is not "Displayed" ▼
                break; // ◄◄ "Exiting" the for "Loop" when "i" becomes "3" ◄◄
            }
            Console.WriteLine(i.ToString());
        }
        
        
        Console.WriteLine("\n");

        
        
        // ▼ "Nested For" Loop ▼
        Console.WriteLine("Nested For Loop with Break Statement:");
        
        for (int j = 0; j < 3; j++)
        {
            Console.WriteLine("j = " + j.ToString());
            
            // ▼ "Nested" Loop ▼
            for (int i = 0; i < 4; i++)
            {
                if (i == 2)
                {
                    break; // ◄◄ "Exiting" the for "Loop" when "i" becomes "3" ◄◄
                }
                Console.WriteLine("i = " + i.ToString());
            }
        }
        
        
        
        Console.WriteLine("\n");

        
        // ▼ "For" Loop  with "Continue" ("Skip") Statement ▼
        Console.WriteLine("For Loop with Continue Statement:");
        
        for (int i = 0; i < 4; i++)
        {
            if (i == 2) 
            {
                // ▼ The  Value "2" is "Skipped", it will not be "Displayed" ▼
                continue; // ◄◄ Go to the "Next Iteration" when "i" is "2" ◄◄
            }
            Console.WriteLine(i.ToString());
        }
    }
}