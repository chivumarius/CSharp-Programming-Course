/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 9.0" (2020) •
                    ─────────────────────
            • "NEW()" KEYWORD FOR "OBJECT INITIALIZATION" •

       


  ▬ In the "C#-9" Version ("2020"), 
    → the "Object" Data Type 
    → can only be "Initialized" 
    → with the "new" Keyword 
    → "Followed" by "Round Brackets":
        •► new()
    → "Without Specifying" 
    → the "object" Keyword:
      ----------------------------
        object o = new();
      ----------------------------
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_9;


//──────────────────────────────────────────────────────────────
// ▬ "NewKeywordForObjectInitialization" Class ▬
public class NewKeywordForObjectInitialization
{
    // ▬ "RunNewKeywordForObjectInitialization()" Method ▬
    public static void RunNewKeywordForObjectInitialization()
    {
        // ▼ "Create" an "Object" in "C# 8" ▼
        object obj1 = new object(); 
        
        // ▼ "Create" an "Object" in "C# 9" ▼
        object obj2 = new();
        
        
        // ▼ "Print Objects" to the "Console" ▼
        Console.WriteLine($"Object 1: {obj1}");
        Console.WriteLine($"Object 2: {obj2}");
    }
} 