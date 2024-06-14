/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
                        • "EXCEPTION" CLASS IN "C#" •

       


    ▬ "Exception" Class In "C#"
        → is the Base Class 
        → for "Every Exception" in "C#" 
    
    
    
    ▬ There are "2 Types" of "Exceptions": 
        1- "System Exception" 
            → is Thrown by the "CLR" ("Common Language Runtime") 
            → of the ".Net" Framework
            → and is a "CLR Runtime Related Error" 
            → while the "Code" is "Running".
        
        
        2- "Application Exception" 
            → is the "Base Class"
            → it "Throws" an "Application Base Exception"
            → which is "Raised" 
            → when the "Business Logic Rule" 
            → is "Violated".



    ▬ ".Net Exception":
        1- "System.NullReferenceException" 
            → when we "Call" a "Method" 
            → on a "Null Object Reference"
        
        
        2- "System.IndexOutOfRangeException"
            → when we "Attempt" 
            → to "Access" an "Element" 
            → in a "Collection" 
            → at a "Position" 
            → that "Doesn't Exist" 

        
        3- "System.IO.IOException"
            → when we "Incorrectly Use" 
            → a "File" - "I/O Type" Operation.
        
        
        4- "System.Net.WebException"
            → when we "Get" an "Error" 
            → "Performing" an "HTTP Call".
        
        
        5- "System.StackOverflow Exception"
            → when a "Method Calls Itself Recursively" 
            → and "Never Stops".
        
        
        6- "System.OutOfMemoryException"
            → when "Our Program" 
            → "Runs Out" of "Memory".
        
        
        7- "System.InvalidCastException"
            → if we "Cast" an "Object" 
            → to a "Type" 
            → that "It Can't" be "Cast To".
        
        
        8- "System.InvalidOperationException"
            → a "Common Generic Exception" 
            → that is "Used" 
            → in a "Lot" of "Code Libraries".
        
        
        9- "System.ObjectDisposedException"
            → when we "Try" to "Use" 
            → an "Object" 
            → that has "Already" been "Disposed".
        
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;



//──────────────────────────────────────────────────────────────
// ▬ "CustomError#" Class
//      → that "Extends" the "Exception" Class ▬
public class CustomError : Exception
{
    // Create a "Owner Custom Error Type" Class
}






//──────────────────────────────────────────────────────────────
// ▬ "ExceptionClassInC#" Class ▬
public class ExceptionClassInCSharp
{
    
    // ▬ "RunExceptionClassInCSharp()" Method ▬
    public static void RunExceptionClassInCSharp()
    {
        // ▼ "Blocks" ▼
        try
        {
        }
        catch (Exception e)
        {
            // ▼ "Properties" ▼
            // e.Data = ;
            // e.Message = null;
            // e.InnerException = null;
            // e.Source = null;
            // e.HelpLink = null;
            // e.StackTrace = null;
            // e.HResult = 0;
            // e.TargetSite = null;
            
        }
    }
} 