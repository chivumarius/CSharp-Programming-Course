/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                 • "EXTENSION METHODS" •
                
       

    ▬ "Extension Methods" in "C#" 
        → are "Special Static Methods" 
        → that Allow "Adding Additional Functionality" 
        → to "Existing Types" 
        → "Without Changing"  
        → the "Definition" of Those "Types" 
        → or "Creating" a "New Sub-Class" ("Derived").

    
    ▬ Basically, "Extension Methods" 
        → allow "Programmers" 
        → to "Add New Methods" to "Classes" 
        → "Without Having" to "Modify" 
        → the "Source Code" of those "Classes". These extension methods are then used as if they were originally defined in those classes.




    ▬ "Key Features" of "Extension Methods" in "C#":
        1. "Special Syntax": 
            ♦ "Extension Methods" 
                → are "Defined" 
                → as "Static Methods" 
                → in a "Static Class", 
                → and the "First Parameter" 
                → of these "Methods" 
                → is "Marked" 
                → with the "this" Keyword, 
                → "Indicating" the "Type" 
                → we "Want" to "Extend".
        
        
        
        2. "Accessibility": 
            ♦ "Extension Methods" 
                → "Must" be "Defined" 
                → in an "Accessible Static Class" and
                → "Must" be "Visible" 
                → in the "Context2" 
                → in which "They" are "Used".
        
        
        3. "Call": 
            ♦ "Extension Methods" 
                → are then "Called" on "Objects" 
                → of the "Extended Type", 
                → but they "Appear" 
                → to be "Part" of the "Definition" 
                → of that "Type".
        
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace Csharp.functions;



// ▬▬ "Static Class" ▬▬
public static class ExtensionMethods
{
    
    // ▬ Static "Extension Method"
    //      → using "this" Keyword ▬
    public static bool GreaterThen(this int i, int value)
    {
        // ▼ "Condition Check" ▼
        if (i > value)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    
    
    public static void RunExtensionMethods()
    {
        // ▼ "Call" the "Extension Method" ▼
        Console.WriteLine("Is 10 > 5: " + 10.GreaterThen(5));
    }
}