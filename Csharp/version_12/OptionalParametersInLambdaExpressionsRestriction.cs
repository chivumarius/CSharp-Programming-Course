/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
        • "OPTIONAL PARAMETERS" IN "LAMBDA EXPRESSION" RESTRICTION •

       


    ▬ The "Restriction"
        → that "All Parameters"
        → into a "Lambda Expression"
        → "Must" be "Required Parameters"
        → was introduced in "C# 12" ("2023").
    
    
    ▬ This "Means"
        → that we "Cannot Use"
        → "Optional Parameters"
        → in "Lambda Expressions"
        → in "C# 12"
        → and "All Parameters"
        → must be "Supplied"
        → when the "Lambda" is "Called".

    
    
    ▬ This "Restriction"
        → is "Added" to Make "Lambdas"
        → more "Predictable"
        → and to Avoid "Ambiguities"
        → about their "Behavior".
    
    
    
    ▬ Eliminating "Optional Parameters"
        → Reduces "Complexity"
        → and Improves "Code Clarity".



    ▬ "See":
        •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;

//──────────────────────────────────────────────────────────────
// ▬ "OptionalParametersInLambdaExpressionsRestriction" Class ▬
public class OptionalParametersInLambdaExpressionsRestriction
{
    // ▬ "RunOptionalParametersInLambdaExpressionsRestriction()" Method ▬
    public static void RunOptionalParametersInLambdaExpressionsRestriction()
    {
        // ▼ "Old Lambda Expression" ▼
        var oldLambdaExpression = (int a, int b) => a + b;

        // ▼ "Print Old Lambda Expression" ▼
        Console.WriteLine(
            "Old Lambda Expression ((int a, int b) => a + b) with Optional Parameters (1, 2): "
                + oldLambdaExpression(1, 2)
        );

        // ▼ "New Lambda Expression" ▼
        var newLambdaExpression = (int a = 1, int b = 2) => a + b;

        // ▼ "Print New Lambda Expression" with "Default Values" - "(1, 2)" ▼
        Console.WriteLine(
            "New Lambda Expression with Default Values ((int a = 1, int b = 2) => a + b): "
                + newLambdaExpression()
        );

        // ▼ "Print New Lambda Expression" with "Optional Parameters" - "(4, 6)" ▼
        Console.WriteLine(
            "New Lambda Expression with Default Values ((int a = 1, int b = 2) => a + b) and Optional Parameters (4, 6): "
                + newLambdaExpression(4, 6)
        );
    }
}
