/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
                • "STATIC LOCAL FUNCTIONS" •

       


  ▬ "Static Local Functions" 
        → were introduced in "C# - 7.0"
        → are "Functions" 
        → Defined "Inside Another Function" 
        → and are "Marked" 
        → with the
            •► "static" Access Mode. 
        
        
    ▬ They are "Accessible" 
        → "Only" within the "Function" 
        → in which they "Are Defined" 
        → and "Cannot" be "Called" 
        → from "Outside" that "Function". 
        
    
    ▬ These "Functions" 
        → are "Useful" 
        → for "Encapsulating" 
        → and "Organizing Logic" 
        → within "Larger Functions", 
        → thereby "Reducing Complexity" 
        → and "Breaking Functionality" 
        → into "Smaller", 
        → more "Manageable Units". 
    
    
    
    ▬ They also "Help" 
        → "Improve Performance" 
        → and "Maintain" 
        → Good "Code Isolation Practice".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "StaticLocalFunctions" Class ▬
public class StaticLocalFunctions
{
    // ▬ "PrintMessage()" Method ▬
    public static void PrintMessage()
    {
        // ▼ "Variable" ▼
        string s = "Hello from LogMessage!";
        
        
        // ▬ "LogMessage()" Method Inside Method ▬
        void LogMessage()
        {
            Console.WriteLine(s);
        }
        
        
        // ▼ "Call" the "Function" ▼
        LogMessage();
    }
    
    
    
    // ▬ "RunStaticLocalFunctions()" Method ▬
    public static void RunStaticLocalFunctions()
    {
        // ▼ "Call" the "Method" ▼
        PrintMessage();
       
    }
} 