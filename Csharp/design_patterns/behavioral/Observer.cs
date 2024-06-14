/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                       • "OBSERVER" •

       


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





  ▬ "Observer" Design Pattern 
    → allows us to Allow "Observer Objects" 
    → to "Subscribe" to "Events"
    → "Sent" by an "Observable".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Interface 1" - "IObserver" Interface ▬
public interface IObserver
{
    // ▬ "Update()" Method ▬
    public void Update(ISubject subject);
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "Interface 2" - "ISubject" Interface ▬
public interface ISubject
{
    // ▬ "Methods" ▬
    public void Attach(IObserver observer);
    public void Detach(IObserver observer);
    public void Notify();
}



//──────────────────────────────────────────────────────────────
// ▬ (3) "Concrete Class" - "ConcreteSubject" Class
//      → that "Implements" the "ISubject" Interface ▬
public class ConcreteSubject : ISubject
{
    // ▼ "Read-Write" Property ▼
    public int State { get; set; }
    
    // ▼ "List" of "Observers" ▼
    private List<IObserver> observers = new List<IObserver>();
    
    
    
    // ▬ "Attach()" Implementation Method ▬
    public void Attach(IObserver observer)
    {
        Console.WriteLine("Concrete Subject: Attached an Observer.");
        
        // ▼ "Add" the "Observer" to the "List" ▼
        observers.Add(observer);
    }
    
    
    // ▬ "Detach()" Implementation Method ▬
    public void Detach(IObserver observer)
    {
        // ▼ "Remove" the "Observer" from the "List" ▼
        observers.Remove(observer);
        Console.WriteLine("Concrete Subject: Detached an Observer.");
    }
    
    
    // ▬ "Notify()" Implementation Method ▬
    public void Notify()
    {
        Console.WriteLine("Concrete Subject: Notifying observers...");
        
        // ▼ "Iterate" through the "List" of "Observers" ▼
        foreach (var observer in observers)
        {
            observer.Update(this);
        }
    }
    
    
    
    
    
    // ▬ "BusinessLogic()" Method ▬
    public void BusinessLogic()
    {
        Console.WriteLine("\nConcrete Subject: Generating Random Number.");
        
        // ▼ "Set" the "State" Property ▼
        State = new Random().Next(0, 100);
        
        // ▼ "Sl
        // eep" the "Thread" for "1 Second" ▼
        Thread.Sleep(1000);
        
        // ▼ "Display" the "State" ▼
        Console.WriteLine("Subject: State has Changed to: " + State);
        
        // ▼ "Call" the "Notify()" Method ▼
        Notify();
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (4-1) "Concrete Class 1" - "ConcreteObserver1" Class
//           → that "Implements" the "IObserver" Interface ▬
public class ConcreteObserver1 : IObserver
{
    // ▬ "Update()" Implementation Method ▬
    public void Update(ISubject subject)
    {
        // ▼ "Check" ▼
        if ((subject as ConcreteSubject).State < 50)
        {
            Console.WriteLine("Concrete Observer 1: Reacted to the Event.");
        }
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (4-2) "Concrete Class 2" - "ConcreteObserver2" Class
//          → that "Implements" the "IObserver" Interface ▬
public class ConcreteObserver2 : IObserver
{
    // ▬ "Update()" Implementation Method ▬
    public void Update(ISubject subject)
    {
        // ▼ "Check" ▼
        if ((subject as ConcreteSubject).State >= 50)
        {
            Console.WriteLine("Concrete Observer 2: Reacted to the Event.");
        }
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "Observer" Class ▬
public class Observer
{
    // ▬ "RunObserver()" Method ▬
    public static void RunObserver()
    {
        // ▼ "Create" an "Object/Instance" of "ConcreteSubject" Class ▼
        ConcreteSubject subject = new ConcreteSubject();

        // ▼ "Create" an "Object/Instance" of "ConcreteObserver1" Class ▼
        ConcreteObserver1 observer1 = new ConcreteObserver1();
        // ▼ "Attach" the "Observer" to the "Subject" ▼
        subject.Attach(observer1);


        // ▼ "Create" an "Object/Instance" of "ConcreteObserver2" Class ▼
        ConcreteObserver2 observer2 = new ConcreteObserver2();
        // ▼ "Attach" the "Observer" to the "Subject" ▼
        subject.Attach(observer2);

        // ▼ "Call" the "BusinessLogic()" Method ▼
        subject.BusinessLogic();
        subject.BusinessLogic();
        subject.BusinessLogic();
        
        
        // ▼ "Detach" the "Observer 2" from the "Subject" ▼
        subject.Detach(observer2);
        
        // ▼ "Call" the "BusinessLogic()" Method ▼
        subject.BusinessLogic();
    }
}


