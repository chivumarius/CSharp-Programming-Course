/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                        • " STATE" •

       


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





  ▬ "State" Design Pattern 
    → Lets an "Object" 
    → to "Change Behavior" 
    → when its "Internal State" 
    → "Changes".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Context2 Class"- "Context2" Class ▬
public class Context
{
    // ▼ "Read-Write Property" ▼
    public IState State { get; set; }
    
    
    // ▬ "Constructor" ▬
    public Context(IState newState)
    {
        State = newState;
    }
    
    
    // ▬ "Request()" Method ▬
    public void Request()
    {
        // ▼ Calling "State Handler" ▼
        State.Handle(this);
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "Interface"- "IState" Interface ▬
public interface IState
{
    // ▬ "Handle()" Method ▬
    void Handle(Context context);
}



//──────────────────────────────────────────────────────────────
// ▬ (3-1) "Concrete Class 1"- "ConcreteState1" Class
//          → that "Implements" the "Class" ▬
public class ConcreteState1 : IState
{
    // ▬ "Handle()" Implementation Method ▬
    public void Handle(Context context)
    {
        // ▼ "Message" ▼
        Console.WriteLine("Handler Call from Concrete State 1");
        
        // ▼ "Transition" → by "Setting" the "Context2 State" ▼
        context.State = new ConcreteState2();
    }
}



//──────────────────────────────────────────────────────────────
// ▬ (3-2) "Concrete Class 2"- "ConcreteState2" Class
//          → that "Implements" the "Class" ▬
public class ConcreteState2 : IState
{
    // ▬ "Handle()" Implementation Method ▬
    public void Handle(Context context)
    {
        // ▼ "Message" ▼
        Console.WriteLine("Handler Call from Concrete State 2");
        
        // ▼ "Transition" → by "Setting" the "Context2 State" ▼
        context.State = new ConcreteState1();
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "State" Class ▬
public class State
{
    // ▬ "RunState()" Method ▬
    public static void RunState()
    {
        // ▼ "Context2" Object ▼
        Context client = new Context(new ConcreteState1());
        
        // ▼ "Accessing" the "Request()" Method ▼
        client.Request();
        client.Request();
        client.Request();
    }
} 