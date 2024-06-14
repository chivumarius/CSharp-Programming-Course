namespace CSharp.control_flow_statements_and_loops;

public class While_Loop
{

    public static void WhileMethod()
    {
        /*
            ♦ "While" Loop 
                → "Repeat" a "Block" of "Code" 
                → "Until" a "Condition" 
                → is "False".
                
            ♦ It is "Used" 
                → when we want to "Execute" 
                → a "Code Repetitively", 
                → "Without" to "Not Know"
                → the "Number" of "Executions" ("Iterations").
            
             ♦ "Incrementing" and "Decrementing"
                → are "Done" 
                → "Inside" the "Loop".
                
                
             ♦ "While" Loop 
                → can be "Nested".
                
                   
            ♦ Syntax:
                while (Condition)
                {
                    // Code                    
                }
         */
        
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i.ToString());
            i++;
        }
        
        
        Console.WriteLine("\n");
        
        
        //---------------------------------------------------------
        /*
            ♦ "Exercise" 
                • Use a "While" Loop
                    → that "Start"  with "x" 
                    → at the "Value" of "3"
                 → and "Execute"
                    → while it is "Greater" than "0".
                
                • "Print" 
                    → the "Value" of "x" 
                    → to the "Console"
                    → and "Decrement"
                    → the "Value" of "x"
                    → by "1" each "Iteration".
         */
        Console.WriteLine("Exercise \"While\" Loop: ");
        
         int x = 3;
         while (x > 0)
         {
             Console.WriteLine(x);
             x--;
         }
    }    
}