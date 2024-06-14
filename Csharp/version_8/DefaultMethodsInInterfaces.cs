/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
            • "DEFAULT METHODS" IN "INTERFACES" •

       


  ▬ "Default Methods" in "Interfaces" 
    → are a "Significant Addition" 
    → in "C# 8.0", 
    → allowing "Interfaces" 
    → to Provide "Default Implementations" 
    → for their "Methods". 




  ▬ This "Feature" 
    → allows "Extending" 
    → the "Functionality" of "Interfaces" 
    → without "Affecting" 
    → "Existing Code" 
    → and "Provides" an "Elegant Way" 
    → to "Manage" 
    → the "Evolution"  of "Interfaces" 
    → over "Time" 
    → without "Breaking Compatibility" 
    → with "Existing Implementations". 




  ▬ "Implicit Implementations" 
    → allow "Classes" 
    → that "Implement Interfaces" 
    → to "Automatically Benefit" 
    → from the "Implementations Involved", 
    → with the "Ability" 
    → to "Selectively Override" Them
    → if "Needed". 




  ▬ This "Approach" 
    → provides a "Greater Degree" 
    → of "Flexibility" 
    → and "Code Reuse", 
    → "Helping" to "Develop" and "Maintain" 
    → a more "Robust" and "Flexible" 
    → "C# Code" base.

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "IHelloWorld" Interface ▬
public interface IHelloWorld
{
    // ▬ "HelloWorld()" Static Method ▬
    public static void HelloWorld()
    {
        Console.WriteLine("Hello World!");
    }
}
 



//──────────────────────────────────────────────────────────────
// ▬ "DefaultMethodsInInterfaces" Class
//      → that "Implements" the "Interface" ▬
public class DefaultMethodsInInterfaces : IHelloWorld
{
    // ▬ "RunDefaultMethodsInInterfaces()" Method ▬
    public static void RunDefaultMethodsInInterfaces()
    {
        // ▼ "Accessing" the "Default Method"
        //      → of the  "Interface" ▼
        IHelloWorld.HelloWorld();
    }
} 