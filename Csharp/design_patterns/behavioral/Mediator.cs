/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                       • "MEDIATOR" •

       


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





  ▬ "Mediator" Design Pattern 
    → provides "Loose Coup" 
    → between "Classes" 
    → by "Ensuring" 
    → that "Only Mediator Class" 
    → has "Detailed Knowledge" 
    → of "Methods".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Abstract Class" - "Friend" Class ▬
public abstract class Friend
{
    // ▼ "Variable" ▼
    protected IMediator mediator;
    
    
    // ▬ "Constructor" ▬
     public Friend(IMediator mediator)
    {
        this.mediator = mediator;
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class 1" - "AngryFriend1" Class
//          → that "Extends" the "Abstract Class" ▬
public class AngryFriend1 : Friend
{
    // ▬ "Constructor" ▬
    public AngryFriend1(IMediator mediator) : base(mediator)
    {
    } 
    
    
    // ▬ "Send()" Method ▬
    public void Send(string message)
    {
        Console.WriteLine("Friend1 sends message: " + message);
        mediator.SendMessage(this, message); // Changed 'Send' to 'SendMessage'
    }
    
    
    // ▬ "Receive()" Method ▬
    public void Receive(string message)
    {
        Console.WriteLine("Friend1 received message: " + message);
    }
}
 




//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class 2" - "AngryFriend2" Class
//          → that "Extends" the "Abstract Class" ▬
public class AngryFriend2 : Friend
{
    // ▬ "Constructor" ▬
    public AngryFriend2(IMediator mediator) : base(mediator)
    {
    } 
    
    
    // ▬ "Send()" Method ▬
    public void Send(string message)
    {
        Console.WriteLine("Friend2 sends message: " + message);
        mediator.SendMessage(this, message); // Changed 'Send' to 'SendMessage'
    }
    
    
    // ▬ "Receive()" Method ▬
    public void Receive(string message)
    {
        Console.WriteLine("Friend2 received message: " + message);
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3) "Interface" - "IMediator" Interface ▬
public interface IMediator
{
    // ▬ "SendMessage()" Method ▬
    void SendMessage(Friend caller, string message);
}


    

//──────────────────────────────────────────────────────────────
// ▬ (4) "Concrete Mediator Class" - "ConcreteMediator" Class
//          → that "Implements" the "Interface" ▬
public class ConcreteMediator : IMediator
{
    // ▼ "Property" ▼
    private AngryFriend1 AngryFriend1 { get; set; }
    private AngryFriend2 AngryFriend2 { get; set; }


    
    // ▬ "SendMessage()" Method ▬
    public void SendMessage(Friend caller, string message)
    {
        // ▼ "Checks" ▼
        if (caller == AngryFriend1)
        {
           // ▼ "Call" ▼
           AngryFriend2.Receive(message);
        }
        else
        {
            Console.WriteLine("Friend2 received message: " + message);
        }
    }
}






//──────────────────────────────────────────────────────────────
// ▬ "Mediator" Class ▬
public class Mediator
{
    // ▬ "RunMediator()" Method ▬
    public static void RunMediator()
    {
        // Create the concrete mediator
        ConcreteMediator mediator = new ConcreteMediator();

        // Creating friends and registering them in the mediator
        AngryFriend1 friend1 = new AngryFriend1(mediator);
        AngryFriend2 friend2 = new AngryFriend2(mediator);

        // Sending a message from friend1 to friend2 via the mediator
        friend1.Send("Hello from Friend1!");

        // Sending a message from friend2 to friend1 via the mediator
        friend2.Send("Hi from Friend2!");
    }
} 