/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                • "FINALIZE()" FUNCTION •
        - (MUST BE "REPLACED" WITH "DISPOSABLE" INTERFACE) -



    ▬ The "Finalizer" in "C#" 
        → is a "Special Method" 
        → Called "Finalize()", 
        → which is "Used" to "Release Resources" 
        → and Perform "Cleanup" 
        → when an "Object" is "Destroyed" 
        → by the "Garbage Collector". It is used to clean up and release system resources associated with an object before it is deleted from memory.


    
    ▬ The "Finalize()" Method 
        → can "Only" be "Invoked" 
        → by the "Garbage Collector".


    ▬ The "Finalizer" 
        → is "Automatically Called" 
        → by the "Garbage Collector" 
        → when "It Decides" 
        → that an "Object" 
        → is "No Longer Referenced" 
        → and can Be "Removed" 
        → from "Memory".


    ▬ The "Finalization Process" 
        → "Occurs Before" the "Object" 
        → is "Permanently Deleted" 
        → from "Memory".



    ▬ Is "Important" to "Note" 
        → that "Using" the "Finalizer" 
        → is a "Less Recommended Practice" 
        → in "C#". 
        
        
        ♦ This is "Because" 
            → the "Finalizer" 
            → can "Negatively Impact" 
            → "Application Performance" 
            → and Make It "Difficult" 
            → to Properly "Manage Resources".



    ▬ "Instead", in C#, 
        → It is "Recommended" 
        → to "Use" the 
            •► "IDisposable" Interface and the 
            •► "Dispose()" Method 
        → to "Release Resources" 
        → when "They" are "No Longer Needed". 
        
        
        ♦ "Implementing" 
            → the "IDisposable" Interface 
            → Allows "Finer Control Over" 
            → when "Resources" 
            → are "Freed" 
            → and "Eliminates" the "Need" 
            → to "Wait" for the "Garbage Collector" 
            → to "Do So".


    ▬ In "General", 
        → it is "Good" to "Avoid" 
        → "Using" the "Finalizer" 
        → in "Favor" of "Implementing" 
        → the "IDisposable" Interface and the `Dispose()` method to ensure efficient resource management in C# applications.


    ▬ "Syntax" of "Finalizer":
        ─────────────────────────
            ~ClasName()
            {
                ~Finalize();
            }
        ─────────────────────────

        
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.functions;

public class FinalizeFunction
{

}