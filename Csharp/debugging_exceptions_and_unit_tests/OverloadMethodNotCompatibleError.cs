/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
                  • "OVERLOAD  METHOD  NOT  COMPATIBLE" ERROR •

       


    ▬ "Overload Method Not Compatible" Error
        → "Occurs" when you "Try" 
        → to "Override" a "Method" 
        → with "Another Method" 
        → in a "Derived Class", 
        → but the "Signatures" 
        → of these "Two Methods" 
        → are "Not Compatible". 


        ♦ This can be "Caused" by 
            •► "Different Parameter Types", 
            •► "Difference Number" of "Parameters" or a 
            •► "Difference" in "Return Type". 



        ♦ To "Work Around" this "Problem" 
            → you "Need" to "Adjust" 
            → the "Method Signatures" 
            → so that they are "Compatible" 
            → or "Use" 
            → the "Correct" - "override" Keyword 
            → when "Overriding" a "Method" 
            → in a "Base Class".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "OverloadMethodNotCompatibleError" Class ▬
public class OverloadMethodNotCompatibleError
{
    // ▬ "ExampleMethod()" Method ▬
    static void ExampleMethod()
    {
    }
    
    // ▬ "RunOverloadMethodNotCompatibleError()" Method ▬
    public static void RunOverloadMethodNotCompatibleError()
    {
        // ▼ Call "ExampleMethod()" Method ▼
        ExampleMethod();        // ◄◄ "Correct Call" ◄◄ 
        
        // ExampleMethod(1, 2);    // ◄◄ "Overload Method Not Compatible" Error ◄◄
    }
} 