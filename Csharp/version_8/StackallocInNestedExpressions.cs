/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
          • "STACKALLOC" OPERATOR IN "NESTED EXPRESSIONS" •

       


  ▬ "Stackalloc" Operator
        → is a "C# Operator" 
        → that allows "Memory" 
        → to be "Allocated" 
        → on the "Program Stack" 
        → "Instead" of the "Heap Stack". 
        
        
        ♦ This "Allocation" 
            → is "Static" 
            → and is "Automatically Released" 
            → when the "Method" or "Block" 
            → in which it is "Defined" 
            → "Terminates". 
        
        
    ▬ Using "stackalloc" 
        → can be "Useful" in "Situations" 
        → where ""High Performance"" is "Required" 
        → and when we "Know" 
        → that the "Amount" of "Memory Required" 
        → is "Small" 
        → and will "Not Exceed Stack Limits".



  ▬ "Nested Expressions" 
        → refers to the "Use" 
        → of the "stackalloc" Operator 
        → Inside other Expressions, 
        → such as 
            •► "Lambda Expressions" 
        → or "Other Complex Expression Constructs". 
    
        
        ♦ This "Technique" 
            → allows for "Fast Allocation" 
            → and "Use" of "Memory" 
            → on the "Stack" 
            → within More "Complex Code Constructions".



  ▬ "Together", 
        → "Stackalloc" in "Nested Expressions" 
        → allows E"fficient Memory Allocation" 
        → when "Needed", 
        → in "Contexts" 
        → where "Performance" 
        → and "Efficiency" 
        → are a "Priority".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "StackallocInNestedExpressions" Class ▬
public class StackallocInNestedExpressions
{
    // ▬ "RunStackallocInNestedExpressions()" Method ▬
    public static void RunStackallocInNestedExpressions()
    {
        // ▼ "Stackalloc" Operator ▼
        Span<int> numbers = stackalloc[] {1, 2, 3, 4, 5 };
        
        // ▼ "Variable" Declaration ▼
        var index = numbers.IndexOfAny(stackalloc[] { 1, 2, 3}); 
        
        // ▼ "Print" Statement ▼
        Console.WriteLine("Returned '0' if 'First Number' Exists or '1' otherwise: " + index);
    }
} 