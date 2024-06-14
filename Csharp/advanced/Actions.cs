/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# ADVANCED" & "COLLECTIONS" •
                    ─────────────────────────────────────
                             • "ACTIONS" •

       

    ▬ "Actions" 
        → are "Functional" Data Types 
        → that "Represent" a "Pointer" 
        → to a "Method" 
        → that "Receives One" 
        → or "More Parameters" 
        → and "Returns Nothing". 
       
       
        
     ▬ "They" are "Used" 
        → to "Pass Functions" 
        → as "Parameters" 
        → to "Other Functions" 
        → or "Methods". 
        
        
    ▬ "Actions" are "Useful" 
        → when you "Want" 
        → to "Execute Code" 
        → in a "Specific Context2" 
        → "Without" having to "Define" 
        → a "Custom Delegate" 
        → for that "Purpose".
    
    
        ♦ "Actions" 
            → can have "Parameters"
            → between "Zero" and "Sixteen".
            
            
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.advanced;

public class Actions
{
    
    // ▼ "Creating" an "Action" Variable ▼
    private static Action action;
    
    // ▼ "Creating" an "Action" With "Parameters" ▼
    private static Action<int, int> actionWithParameters;
    
    
    
    // ▬ "HandleActions()" Method ▬
    public static void HandleActions()
    {
        Console.WriteLine("Action Handled without Parameters!");
    }
    
    
    
    // ▬ "HandleActionsWithParameters()" Method ▬
    public static void HandleActionsWithParameters(int int1, int int2)
    {
        Console.WriteLine("Action With Parameters Handled - Sum: " + (int1 + int2));
    }
    
    
    
    // ▬ "RunActions()" Method ▬
    public static void RunActions()
    {
        //---------------------------------------------------------
        // ▼ "Substituting" the "Action" to the "Method)" ▼
        action += HandleActions;
        
        // ▼ "Invoking" the "Action" ▼
        action.Invoke();
        
        
        
        //---------------------------------------------------------
        // ▼ "Substituting" the "Action With Parameters"
        //      → to the "Method)" ▼
        actionWithParameters += HandleActionsWithParameters;
        
        
        // ▼ "Invoking" the "Action With Parameters" ▼
        actionWithParameters.Invoke(4, 6);
    }
}