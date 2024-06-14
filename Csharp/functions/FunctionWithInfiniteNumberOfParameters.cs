/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
     • "FUNCTION" WITH "INFINITE NUMBER" OF "PARAMETERS" •


       

    ▬ A "Function" 
        → with a "Infinite"/"Variable Number" 
        → of "Parameters" 
        → is a "function" 
        → that can "Accept" 
        → a "Variable Number" 
        → of "Arguments" 
        → Within "One Invocation".


    ▬ This "Functionality" 
        → is "Achieved" 
        → using "Variable-Length Parameters", 
        → also Known as "params".
        
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace Csharp.functions;

public class FunctionWithInfiniteNumberOfParameters
{
    
    public static void Exapmple1(params string[] words)
    {
        // ▼ "ForEach" Loop ▼
        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
    }
    
    
    
    
    
    
    public static void RunFunctionWithInfiniteNumberOfParameters()
    {
        // ▼ "Call" the "Function" ▼
        Exapmple1();
        Exapmple1("\nHi!");
        Exapmple1("\nHi", "Hello!");
        Exapmple1("\nHi", "Hello", "World!");
    }
}