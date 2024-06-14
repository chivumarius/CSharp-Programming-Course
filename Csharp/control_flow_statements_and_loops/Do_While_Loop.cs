namespace CSharp.control_flow_statements_and_loops;

public class Do_While_Loop
{
    public static void DoWhileMethod()
    {
        /*
            ♦ "Do While" Loop
                → is "Similar" to "While" Loop
                → the "Difference" 
                → is that the "Do While" Loop 
                → is "Executed" at "Least Once"
                → even if the "Condition" is "False".
          
          
            ♦ "Do While" Loop
                → "Execute" a "Bloc" of "Code" 
                → "Repetitively", at "Least Once".
              
              
            ♦ The "Conditional Experssion"
                → Comes after the "Code Block".     
            
            
            ♦ "Do While" Loop 
                → can be "Nested".
            
            
            ♦ Syntax:
                do
                {
                    // Code
                } while (Condition);      
         */
        
        int i = 0;
        do
        {
            Console.WriteLine(i.ToString());
            i++;
        } while (i < 3);
    }
}