/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
                  • "PRIMARY CONSTRUCTORS" •

       


    ▬ "Primary Constructors" 
        → are a "Feature" 
        → introduced in "C# 12" ("2023")
        → that allows "Primary Constructors" 
        → to be "Defined Directly" 
        → in the "Class Declaration", 
        → thereby Reducing "Redundancy" 
        → and Improving "Code Clarity" 
        → and "Brevity". 
    
    
    
    ▬ They are "Specified" 
        → by using the 
            •► "primary" Keyword 
        → "Before" the "Constructor Definition". 
    
    
    
    ▬ By Using "Primary Constructors", 
        → we can more "Efficiently Define" 
        → the "Behavior" 
        → of "Constructors" 
        → and "Reduce" 
        → the "Complexity" 
        → of the "Associated Code".




    ▬ "See":
        •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;



//──────────────────────────────────────────────────────────────
// ▬ "OlderCSharpVersion" Class ▬
public class OlderCSharpVersion
{
    // ▼ "Variables" ▼
    public int a;
    public int b;
    
    
    // ▬ "Constructor" ▬
    public OlderCSharpVersion(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "CSharpVersionTwelve" Class
//      → with "Primary Constructor" ▬
public class CSharpVersionTwelve(int a, int b)
{
    // ▼ "Variables" ▼
    public int a = a;
    public int b = b;
}





//──────────────────────────────────────────────────────────────
// ▬ "PrimaryConstructors" Class ▬
public class PrimaryConstructors
{
    // ▬ "RunPrimaryConstructors()" Method ▬
    public static void RunPrimaryConstructors()
    {
        // ▼ "Initialized Variables" ▼
        OlderCSharpVersion olderCSharpVersion = new OlderCSharpVersion(1, 2);
        CSharpVersionTwelve cSharpVersionTwelve = new CSharpVersionTwelve(1, 2);


        // ▼ "Print Older Variable" ▼
        Console.WriteLine("Older CSharp Version (a, b): ("
                          + olderCSharpVersion.a + ", "
                          + olderCSharpVersion.b + ")");


        // ▼ "Print New Variable" ▼
        Console.WriteLine("New CSharp Version (a, b): ("
                          + cSharpVersionTwelve.a + ", "
                          + cSharpVersionTwelve.b + ")");
    }
}