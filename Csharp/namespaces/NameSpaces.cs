/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                • "NAME SPACES" •
                ────────────────

       

    ▬ "Namespace" 
        → let us "Give" the "Compiler" 
        → "Context2" for the "Different Classes"
        → in a "Project",
        → "Save" us "Time",
        → "Wrap" and "Organize" 
        → our "Code"
        
        
        ♦ "It"
            → "Reduces" the "Possibility" of
            → of "Naming Conflicts".
        
        
        ♦ "There" 
            → "Cannot" be "2 Classes"
            → with the "Same Name"
            → "Inside" of a "Namespace".


    ▬ "Nested Namespace"
        → is when a "Namespace"
        → Contains "Another Namespace".
    
    
    
    ▬ "namespace" Keyword
        → "Defines" a "Namespace".
        
    
    
     ▬ "namespace"
        → is "Placed Below" 
        → the "using" Instructions 
        → and "Above" 
        → the "Class Declaration".
     
  
  
    ▬ An "Alias"
        → is a "Way" to "Use" 
        → "Shorter Hand"
        → to "Refer" to a "Space Name"
   
   
   
   ▬ "." ("Dot") Operator
       → "Points" to "Another Namespace".
   
   
   ▬ "::" ("Double Colon") Operator
        → is "Used" to "Access"  
        → "Members" or "Types" 
        → within a "Specific Namespace". 
        
        
        ♦ "This" can be "Useful" 
            → when we "Can Access Members" 
            → in a "Namespace" 
            → that has the "Same Name" 
            → as a "Keyword" or an "Alias" 
            → "Defined" in "Code".
         
         
         ♦  "Syntax" for "::" Operator
            ───────────────────────────────────────────
                global :: [Name_Similar_To_Keyword]
            ───────────────────────────────────────────
           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// ▼ "using" Statements ▼
// ▼ Create "Log Alias" ▼
using Log = System.Console;


// ▼ The "namespaces" with "." Operator ▼
namespace CSharp.namespaces;

// ▼ The "namespaces" with "::" Operator ▼
// namespace CSharp.namespaces.System;  



// ▬▬ The "Class Declaration" ▬▬
public class NameSpaces
{

    // ▬ "RunNameSpaces()" Method ▬
    public static void RunNameSpaces()
    {
        // ▼ Using "Alias" as "Log" ▼
        Log.WriteLine("Aliases for Using Statement.");
        
        
        // ▼ Using "::" Operator ▼
        // global::System.Console.WriteLine("Using '::' Operator to Access a Sub-Namespace.");
        
    }
} 