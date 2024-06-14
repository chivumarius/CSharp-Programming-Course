namespace CSharp.control_flow_statements_and_loops;

public class If_ElseIf_Else_statement
{
    public static void IfElseIfElse()
    {
        // ▬ "If-Else-If-Else" Conditional Statement 
        //      → allow "Controlling" the "Flow"
        //      → of "Code Execution" ▬
        
        // ▬ "Only" the "First True" Condition will be "Executed" ▬
        
        // ▼ "If(true){}" Conditional Statement ▼
        if (5 < 3) 
        {
            Console.WriteLine("3 is less than 5");
        }
        
        // ▼ "Else If(true){}" Conditional Statement ▼
        else if (4 < 2)
        {
            Console.WriteLine("2 is less than 4");
        }

        // ▼ "Else{}" Conditional Statement ▼
        else
        {
            Console.WriteLine("The previous conditions were not fulfilled!");
        }
        
        
        
        
        
        // ▬ "Nested Conditional Statement" ▬
        Console.WriteLine("\n" + "Nested Conditional Statement");
        
        if (1 < 2)
        {
            if (false)
            {
                Console.WriteLine("The \"If\" Statement is Hit!");
            }
            else
            {
                Console.WriteLine("The \"Else\" Statement is Hit!");
            }

        }
        
        
        
        
        // --------------------------------------------------------------------
        /* ▬ "Exercise"
                • Set x 
                    → to 5 if the Condition is True
                    → and to 3 if the Condition is False.
                
                • Use "if else" Conditional Statement.
                • Then Print out x to the Console.
         */
        Console.WriteLine("\n" + "Exercise - Conditional Statement");

        bool condition = true;
        int x = 0;
        
        if (condition)
        {
            x = 5;
        } else {
            x = 3;
        }
        
        Console.WriteLine("The True Value of x: " + x);
    }
} 