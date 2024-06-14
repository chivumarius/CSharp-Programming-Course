/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                      • "ADAPTER" •

       


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
    → to C"reate New Functionality".


    ♦ They "Help" 
      → to "Ensure" that "Even" 
      → if "One Part Changes", 
      → the "Entire Structure" of the "Code" 
      → does "Not Need" to "Change".


    ♦ It "Focuses" 
      → on "Inheritance"
      → (which is a "Primary Component" 
      → of "Structural" Design Patterns).




  ▬ "Adapter" Design Pattern 
    → "Allows" for "Two Classes" 
    → that are "Not Compatible" 
    → to "work together" 
    → by Using 
    → an "Interface" 
    → with "One" of the "Existing Classes".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;


//──────────────────────────────────────────────────────────────
// ▬ "Adaptee" Class ▬
public class Adaptee
{
    // ▬ "GetRequest()" Method ▬
    public string GetRequest()
    {
        return "Request from the Client2.";
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "ITarget" Interface ▬
public interface ITarget
{
    // ▬ "Method" ▬
    string Request();
}




//──────────────────────────────────────────────────────────────
// ▬ "Adapter" Class
//      → that "Implements" the "ITarget" Interface ▬
public class Adapter : ITarget
{
    // ▼ "Variable" ▼
    private readonly Adaptee adaptee;
    
    
    
    // ▬ "Constructor" ▬
    public Adapter(Adaptee adaptee)
    {
        this.adaptee = adaptee;
    }
    
    
    // ▬ "Request()" Method" ▬
    public string Request()
    {
        return $"This is: {adaptee.GetRequest()}";
    }
}



//──────────────────────────────────────────────────────────────
// ▬ "AdapterDesignPattern" Class
//      → that "Adapts" the "Adaptee" Class ▬
public class AdapterDesignPattern
{
    // ▬ "RunAdapterDesignPattern()" Method ▬
    public static void RunAdapterDesignPattern()
    {
        // ▼ "Creating" the "Adaptee" Object ▼
        Adaptee adaptee = new Adaptee();
        
        // ▼ "Creating" the "Adapter" Object ▼
        ITarget target = new Adapter(adaptee);
        
        // ▼ "Printing" the "Result" ▼
        Console.WriteLine(target.Request());
    }
} 