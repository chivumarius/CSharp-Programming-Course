/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
        • "NULL-COALESCING" - "??=" ASSIGNMENT (OPERATOR) •

       


  ▬ "Null-Coalescing" ("??=") Assignment in "C#" 
      → also "Known" as the "Null-Coalescing Operator" 
      → is a "Technique" 
      → "Used" to "Assign" a "Default Value" 
      → to a "Variable" 
      → if it is "Null". 
      
      
      ♦ This is "Done" 
        → "Using" the 
            •► "??" Operator. 
        → and has the "Syntax": 
          -----------------------------------------
            result = expression1 ?? expression2;. 
          -----------------------------------------
        
        
        • The "Operator" ("??")
            → "Checks" 
            → if "Expression1" is "Null". 
        
        • If is "Null", 
            → then "Expression2" 
            → is "Evaluated" 
            → and the "Result" 
            → is the "Value" 
            → of "Expression2". 
        
        • "Otherwise", 
            → if "Expression1" is "Not Null", 
            → then the "Result" 
            → is the "Value" of "expression1". 
    
    
    ▬ "Null-Coalescing" Operator 
        → is "Useful" 
        → for "Handling Situations" 
        → where you "Want" 
        → to "Assign" an "Alternate" 
        → or "Default Value" 
        → to a "Variable" 
        → if "It" is "Null".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "NullCoalescingAssignment" Class ▬
public class NullCoalescingAssignment
{
    // ▬ "RunNullCoalescingAssignment()" Method ▬
    public static void RunNullCoalescingAssignment()
    {
        // ▼ "Object" ▼
        object obj = null;
    
        // ▼ "Null-Coalescing" Assignment ▼
        obj ??= new object();
    
        // ▼ Print the "Value" ▼
        Console.WriteLine($"The value of 'obj' after null-coalescing assignment: {obj}");
    }
} 