/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                    • "ANONYMOUS FUNCTION" OR
                      "LAMBDA EXPRESSION" •


       

    ▬ An "Anonymous" Function ib "C#"
        → is a "Function Without" a "Specific Name", 
        → "Defined" in a "Context2" 
        → where a "Function" is "Needed", 
        → but does "Not Need" 
        → to be "Explicitly Defined" 
        → as a "Separate Method". 
        
        
        ♦ An "Anonymous" Function 
            → can be "Created" using the 
                •► "delegate" Keyword or using 
                •► "Lambda Expressions".



    ▬ "Lambda Expressions" 
        → are a "Special Form" 
        → of "Anonymous Functions" in "C#". 
        
        
        ♦ "They" 
            → are "Useful" for "Defining Functions" 
            → in a "Concise" and "Expressive Way". 
        
        
        ♦ The "Syntax" of a "Lambda Expression" 
          ───────────────────────────────────────────────────────────
                // ▼ "Expression Lambda" ▼
                (parameter_list) => expression
                
                // ▼ "Statement Lambda" ▼
                () => { statement_block }    
          ───────────────────────────────────────────────────────────
            → is "Short" 
            → and "Focuses" on the "Parameters" 
            → and the "Function Body". 
            

    ▬ "Lambda Expressions" 
        → are "Often Used" 
        → in "Combination" 
        → with "High-Order Functions" such as: 
            •► "Select", 
            •► "Where", 
            •► "Aggregate", etc., 
        → within "LINQ" ("Language Integrated Query") 
        → or in "Other Contexts" 
        → where "Anonymous Functions" 
        → are "Required" 
        → to "Implement Specific Behaviors". 
    
    
        ♦ Using "Lambda Expressions" in "C#"
            → makes "Code" more "Concise" 
            → and "Easier" to "Understand" 
            → in many "Situations".

         
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace Csharp.functions;

public class AnonymousFunctionsAndLambdaExpressions
{
    public static void RunAnonymousFunctionAndLambdaExpressions()
    {
        
        // 1- Using a "Expression Lambda":
        Action expressionLambda = () => Console.WriteLine("Expression Lambda: " + "Hello, World!");
        expressionLambda();


        Console.WriteLine();
        
        
        Action<string> expressionLambda2 = (s) => Console.WriteLine(s);
        expressionLambda2("Expression Lambda with String Type (s)");

        
        Console.WriteLine();
        
       
        
        
        // 2- Using a "Statement Lambda":
        Action statementLambda = () =>
        {
            Console.WriteLine("Statement Lambda: " + "Hello, World Again!");
            Console.WriteLine("I am Marius");
            Console.WriteLine("We will learn together C#");
        };
        statementLambda();
    }
}