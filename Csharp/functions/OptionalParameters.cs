/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                • "OPTIONAL PARAMETERS" •
                  - ("DEFAULT VALUE") -

       

    ▬ An "Optional Parameter" in "C#" 
        → is a "Parameter" 
        → that "Has" a "Default Value" 
        → "Associated" with "It". 
        
        
        ♦ This "Default Value" 
            → is Used when No "Corresponding Argument" 
            → is "Supplied" 
            → to the "Function Call". 
        
        
    ▬ "Optional Parameters" 
        → provide "Flexibility" 
        → in using "Functions" 
        → because they Allow "Function Calls" 
        → "Without Having" to "Supply All Parameters".
    
    
    
    ▬ The "Optional Parameter" 
        → "Must Not" be the "First" 
        → in the "Function Signature".
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace Csharp.functions;


public class OptionalParameters
{

    // ▬ "Method"
    //      → with "Optional Parameter" ("Default Value")
    //      → or "Initialized Parameter" ▬
    static void PrintMessage(string message = "Hello World, as Optional Parameter!")
    {
        Console.WriteLine(message);
    }

    
    public  static void RunOptionalParameters()
    {
        PrintMessage();
        PrintMessage("Hi, this is Initialized in the Method Call!");
    }
}