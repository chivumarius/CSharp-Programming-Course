/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
                        • "NULL REFERENCE EXCEPTION" •

       


    ▬ "NullReferenceException"
        → "Occurs" when we "Try" 
        → to "Access" a "Method" 
        → or "Property" 
        → of an "Object" 
        → that is "Uninitialized". 


    ▬ To "Avoid" this "Exception", 
        → make sure you "Always Check "
        → that "Objects" are "Initialized" 
        → "Before Using Them" 
        → and "Properly" 
        → "Handle Cases" where "They" 
        → may be "N"ull".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "NullReferenceExceptionError" Class ▬
public class NullReferenceExceptionError
{
    // ▼ Declaring a "List" of "Strings" ▼
    private static List<string> strings;
    
    
    
    // ▬ "RunNullReferenceExceptionError()" Method ▬
    public static void RunNullReferenceExceptionError()
    {
        // ▼ "Initializing" the "Object" ▼
        // strings = new List<string>();
        // ►► We Get "NullReferenceException" Error Here.
        //      → because we didn't "Initialize" the "Object" first. ◄◄

        
        //▼ Using "if(){}" Statement
        //      → to "Avoid Error" in the "Code" ▼
        if(strings != null){
            // ▼ "Adding Data" to the "List" of "Strings" ▼
            strings.Add("Hello");
        }
    }
} 