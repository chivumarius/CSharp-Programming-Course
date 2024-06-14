/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                        • "MEMENTO" •

       


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





  ▬ "Memento" Design Pattern 
    → lets us "Restore" 
    → an "Object" 
    → to its "Previous State".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Originator Class" - "Originator" Class ▬
public class Originator
{
    // ▼ "Variable" ▼
    private string state;

    // ▬ "State" Property ▬
    // Property to get or set the state of the originator
    public string State
    {
        get { return state; }
        set { state = value; }
    }
    
    // ▬ "CreateMemento()" Method ▬
    // Creates a memento with the current state
    public Memento CreateMemento()
    {
        return new Memento(state);
    }
    
    // ▬ "SetMemento()" Method ▬
    // Sets the state of the originator based on the memento
    public void SetMemento(Memento memento)
    {
        // ▼ "Set" ▼
        state = memento.GetState();
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "Memento Class" - "Memento" Class ▬
public class Memento
{
    // ▼ "Variable" ▼
    private string state;
    
    
    
    // ▬ "Constructor" Method ▬
    public Memento(string state)
    {
        this.state = state;
    }
    
    
    
    // ▬ "GetState()" Method ▬
    public string GetState()
    {
        return state;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3) "Caretaker Class" - "Caretaker" Class ▬
public class Caretaker
{
    // ▼ "Read-Write Property" ▼
    // Property to hold the memento
    public Memento Memento { get; set; }
}




//──────────────────────────────────────────────────────────────
// ▬ "MementoDesignPattern" Class ▬
public class MementoDesignPattern
{
    // ▬ "RunMementoDesignPattern()" Method ▬
    public static void RunMementoDesignPattern()
    {
        // Creating an originator
        Originator originator = new Originator();
        
        // Setting the state of the originator
        originator.State = "Initial state";
        
        // Creating a memento for the initial state
        Memento memento = originator.CreateMemento();
        
        // Saving the memento in the caretaker
        Caretaker caretaker = new Caretaker();
        caretaker.Memento = memento;
        
        // Modifying the state of the originator
        originator.State = "New state";
        
        // Restoring the initial state using the saved memento
        originator.SetMemento(caretaker.Memento);
        
        // Displaying the current state of the originator
        Console.WriteLine("Current state: " + originator.State);
    }
} 