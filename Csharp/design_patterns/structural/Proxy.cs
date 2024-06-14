/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                        • "PROXY" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Structural" Design Patterns 
    → "Define" the "Relationships" 
    → between "Objects"
    → and "Allow Us" 
    → to "Compose Objects" 
    → in "Different Ways" 
    → to "Create New Functionality".


    ♦ They "Help" 
      → to "Ensure" that "Even" 
      → if "One Part Changes", 
      → the "Entire Structure" of the "Code" 
      → does "Not Need" to "Change".


    ♦ It "Focuses" 
      → on "Inheritance"
      → (which is a "Primary Component" 
      → of "Structural" Design Patterns).




  ▬ "Proxy" Design Pattern 
    → provides a "Placeholder Interface" 
    → "Aimed" at: 
      • "Controlling Access", 
      • "Reducing Cost" or 
      • "Lessening Complexity".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Interface" - "IInformation" Interface ▬
public interface IInformation
{
   // ▬ "Method" ▬
    int GetInformation();
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "Concrete Class" - "SecretInformation" Class
//        → that "Implements" the "Interface" ▬
public class SecretInformation : IInformation
{
   // ▬ "Method" ▬
    public int GetInformation()
    {
        // ▼ "Random" Object ▼
        Random codeNumber = new Random();
        
        // ▼ "Random" Number ▼
        return codeNumber.Next(0, 99999);
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3) "Access Controller" - "Proxy" Class ▬
public class Proxy
{
    // ▬ "Member Variable" ▬
    IInformation secretInfo;
    
    
    
   // ▬ "GetSecretInfo()" Method ▬
    public int GetSecretInfo(bool hasSecurityClearance = false)
    {
        // ▼ "Conditional Statement" ▼
        if (hasSecurityClearance)
        {
            // ▼ "Set" ▼
            secretInfo = new SecretInformation();
            
            // ▼ "Return" ▼
            return secretInfo.GetInformation();
        }
        else
        {
            return -1;
        }
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "ProxyDesignPattern" Class ▬
public class ProxyDesignPattern
{
  // ▬ "RunProxyDesignPattern()" Method ▬
    public static void RunProxyDesignPattern()
    {
        // ▼ "Variable" ▼
        Proxy proxy = new Proxy();
        
        // ▼ "Get Secret Info" ▼
        int info = proxy.GetSecretInfo(true); 
        
        // ▼ "Print Secret Info" ▼
        Console.WriteLine($"The Secret Information is: {info}");
    }
} 