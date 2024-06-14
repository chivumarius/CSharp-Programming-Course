/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                       • "COMMAND" •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Behavioral" Design Patterns
    → "Help" to "Define" 
    → how "Objects Interact".


    ♦ They "Increase" 
      → the "Flexibility" 
      → in the "Communication" 
      → between "Objects".


    ♦ They "Focus" 
      → on "Assigning Responsibilities" 
      → between "Objects"
      → and on the "Way" 
      → that "Objects" 
      → are "Interconnected".





  ▬ "Command" Design Pattern
    → Creates Objects 
    → that "Encapsulate" 
      •► "Actions" and
      •► "Parameters".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Interface" - "ICommand" Interface ▬
public interface ICommand
{
    
    // ▼ "Read Only Property" ▼
    string Name { get; }
    
    
    // ▬ "Method" ▬
    void Execute();
}




//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class" - "Hello" Class
//          → that "Implements" the "Interface" ▬
public class Hello : ICommand
{
    
    // ▼ "Read Only Property" ▼
    // public string Name => "Hello";
    public string Name
    {
        get { return "Hello"; }
    }   
    

    // ▬ "Execute()" Method Implementation ▬
    public void Execute()
    {
        Console.WriteLine("I am executing 'Hello; Command!");
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class" - "Goodbye" Class
//          → that "Implements" the "Interface" ▬
public class Goodbye : ICommand
{
    
    // ▼ "Read Only Property" ▼
    // public string Name => "Goodbye";
    public string Name
    {
        get { return "Goodbye"; }
    }
    
    
    // ▬ "Execute()" Method Implementation ▬
    public void Execute()
    {
        Console.WriteLine("I am executing 'Goodbye; Command!");
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (3) "Invoker Class" - "Invoker" Class ▬
public class Invoker
{
    
    // ▼ "Variable" ▼
    ICommand Command = null;
    
    
    
    // ▬ "GetCommand()" Method ▬
    public ICommand GetCommand(string action)
    {
        // ▼ "Switch" Statement ▼
        switch (action)
        {
            case "Hello":
                Command = new Hello();
                break;
            
            case "Goodbye":
                Command = new Goodbye();
                break;
            
            default:
                break;
        }
        return Command;
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "Command" Class that ▬
public class Command
{
    // ▬ "RunCommand()" Method ▬
    public static void RunCommand()
    {
        // ▼ "Objects" ▼
        Invoker invoker = new Invoker();
        ICommand command = invoker.GetCommand("Hello");
        
        // ▼ "Execution" ▼
        command.Execute();
        
        
        // ▼ "Set Command" ▼
        command = invoker.GetCommand("Goodbye");
        
        // ▼ "Execution" ▼
        command.Execute();
    }
} 