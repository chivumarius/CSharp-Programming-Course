/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                       • "FACADE" •

       


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




  ▬ "Façade" Design pattern
    → provides a "Simple Interface" 
    → allowing us to "Work" 
    → with a More "Complex Object" 
    → that the "Interface Works" with.


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;


//──────────────────────────────────────────────────────────────
// ▬ (1-1) "Subsystem" - "Subsystem1" Class ▬
public class Subsystem1
{
    // ▬ "Operation1" Method ▬
    public string Operation1()
    {
        return "\t Subsystem 1 - Operation 1\n";
    }
    
    
    // ▬ "Operation2" Method ▬
    public string Operation2()
    {
        return "\t Subsystem 1 - Operation 2\n";
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (1-2) "Subsystem" - "Subsystem2" Class ▬
public class Subsystem2
{
    // ▬ "Operation1" Method ▬
    public string Operation1()
    {
        return "\t Subsystem 2 - Operation 1\n";
    }
    
    
    // ▬ "Operation2" Method ▬
    public string Operation2()
    {
        return "\t Subsystem 2 - Operation 2\n";
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2) "Façade" Class ▬
public class Façade
{
    // ▼ "Variables" ▼
    protected Subsystem1 subsystem1;
    protected Subsystem2 subsystem2;
    
    
    // ▬ "Constructor" ▬
    public Façade(Subsystem1 subsystem1, Subsystem2 subsystem2)
    {
        this.subsystem1 = subsystem1;
        this.subsystem2 = subsystem2;
    }
    
    
    // ▬ "Operation" Method ▬
    public string Operation()
    {
        // ▼ "Set" ▼
        string result = "Facade Initializes Subsystems: \n";
        result += subsystem1.Operation1();
        result += subsystem2.Operation1();
        
        result += "\nFacade Orders Subsystems to Perform the Action: \n";
        result += subsystem1.Operation2();
        result += subsystem2.Operation2();
        
        // ▼ "Return" ▼
        return result;
    }
}






//──────────────────────────────────────────────────────────────
// ▬ (3) "Client2" Class ▬
public class Client
{
    // ▬ "ClientCode()" Method ▬
    public static void ClientCode(Façade façade)
    {
        Console.WriteLine(façade.Operation());
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "FaçadeDesignPattern" Class ▬
public class FaçadeDesignPattern
{
    // ▬ "RunFaçadeDesignPattern()" Method ▬
    public static void RunFaçadeDesignPattern()
    {
        // ▼ "Creating" the "Subsystem" Objects ▼
        Subsystem1 subsystem1 = new Subsystem1();
        Subsystem2 subsystem2 = new Subsystem2();
        
        // ▼ "Creating" the "Façade" Object ▼
        Façade façade = new Façade(subsystem1, subsystem2);
        
        // ▼ "Pulling" the "ClientCode()" Method ▼
        Client.ClientCode(façade);
    }
} 