/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "CREATIONAL" •
                    ────────────────────
                       • "BUILDER " •

       


  ▬ A "Design Pattern" 
    → is a "General Reusable Solution" 
    → to a "Frequent Problem" 
    → in "Software Engineering".



  ▬ "Creational" Design Patterns 
    → are "Used" 
    → to "Create Objects".



  ▬ There Contain "2 Main Ideas":
    (1) "Encapsulation"
    
    (2) "Hiding" how "Instances" 
        → of these "Classes" 
        → are "Created" 
        → and "Combined".


      
  ▬ The "Builder" Design Pattern 
    → "Facilitates" the "Creation" 
    → of "Complex Objects".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.creational;


//──────────────────────────────────────────────────────────────
// ▬ (1)  "Builder" - "IComputerBuilder" Interface  ▬
 public interface IComputerBuilder
 {
     // ▬ "Methods" ▬
     void SetMonitor();
     void SetMouse();
     void SetKeyboard();
     void SetTower();
     void SetPrinter();
     
     Computer GetComputer();
 }





//──────────────────────────────────────────────────────────────
// ▬ (2)  "Product" - "Computer" Class  ▬
public class Computer
{
    
    // ▬ "Properties" ▬
    public string Monitor { get; set; }
    public string Mouse { get; set; }
    public string Keyboard { get; set; }
    public string Tower { get; set; }
    public string Printer { get; set; }
}





//──────────────────────────────────────────────────────────────
// ▬ (3-1)  "Concrete Builder 1" - "Computer A Builder" Class
//          → that "Implements" the "Builder" Interface ▬
public class ComputerABuilder : IComputerBuilder
{
    // ▼ "Variable" ▼
    Computer computer = new Computer();
    
    
    // ▬ "SetMonitor()" Method " ▬
    public void SetMonitor()
    {
        // ▼ "Set" ▼
        computer.Monitor = "Single";
    }
    
    
    // ▬ "SetMouse()" Method " ▬
    public void SetMouse()
    {
        // ▼ "Set" ▼
        computer.Mouse = "Regular";
    }
    
    
    
    // ▬ "SetKeyboard()" Method " ▬
    public void SetKeyboard()
    {
        // ▼ "Set" ▼
        computer.Keyboard = "Standard";
    }
    
    
    
    // ▬ "SetTower()" Method " ▬
    public void SetTower()
    {
        // ▼ "Set" ▼
        computer.Tower = "16GB RAM";
    }
    
    
    
    // ▬ "SetPrinter()" Method " ▬
    public void SetPrinter()
    {
        // ▼ "Set" ▼
        computer.Printer = "HP LaserJet 5000";
    }
    
    
    
    // ▬ "GetComputer()" Method " ▬
    public Computer GetComputer()
    {
        // ▼ "Get" ▼
        return computer;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3-2)  "Concrete Builder 2" - "Computer B Builder" Class
//          → that "Implements" the "Builder" Interface ▬
public class ComputerBBuilder : IComputerBuilder
{
    // ▼ "Variable" ▼
    Computer computer = new Computer();
    
    
    // ▬ "SetMonitor()" Method ▬
    public void SetMonitor()
    {
        // ▼ "Set" ▼
        computer.Monitor = "Dual";
    }
    
    
    // ▬ "SetMouse()" Method ▬
    public void SetMouse()
    {
        // ▼ "Set" ▼
        computer.Mouse = "Gaming";
    }
    
    
    
    // ▬ "SetKeyboard()" Method ▬
    public void SetKeyboard()
    {
        // ▼ "Set" ▼
        computer.Keyboard = "Gaming";
    }
    
    
    
    // ▬ "SetTower()" Method ▬
    public void SetTower()
    {
        // ▼ "Set" ▼
        computer.Tower = "64GB RAM";
    }
    
    
    
    // ▬ "SetPrinter()" Method ▬
    public void SetPrinter()
    {
        // ▼ "Set" ▼
        computer.Printer = "HP LaserJet 7000";
    }
    
    
    
    // ▬ "GetComputer()" Method ▬
    public Computer GetComputer()
    {
        // ▼ "Get" ▼
        return computer;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (4)  "Director" - "ComputerCreator" Class  ▬
public class ComputerCreator
{
    // ▼ "Member Variable" ▼
    private IComputerBuilder computerBuilder;
    
     
    // ▬ "Constructor" ▬
    public ComputerCreator(IComputerBuilder computerBuilder) 
    {
        this.computerBuilder = computerBuilder;
    }
    
    
    
    // ▬ "CreateComputer()" Method ▬
    public Computer CreateComputer()
    {
        // ▼ "Set" ▼
        computerBuilder.SetMonitor();
        computerBuilder.SetMouse();
        computerBuilder.SetKeyboard();
        computerBuilder.SetTower();
        computerBuilder.SetPrinter();
    
        // ▼ Returnează obiectul Computer creat ▼
        return computerBuilder.GetComputer();
    }
    
    
    // ▬ "GetComputer()" Method ▬
    public Computer GetComputer()
    {
        // ▼ "Get Computer" ▼
        return computerBuilder.GetComputer();
    }
}



//──────────────────────────────────────────────────────────────
// ▬ "Builder" Class for "Test" ▬
public class Builder
{
    // ▬ "RunBuilder()" Method ▬
    public static void RunBuilder()
    {
        // ▼ "Computer A Creator" Object ▼
        ComputerCreator computerACreator = new ComputerCreator(new ComputerABuilder());
        computerACreator.CreateComputer(); 
        
        
        // ▼ "Computer B Creator" Object ▼
        ComputerCreator computerBCreator = new ComputerCreator(new ComputerBBuilder());
        computerBCreator.CreateComputer();
        
        
        // ▼ "GetComputer()" Method ▼
        Computer computerA = computerACreator.GetComputer();
        Computer computerB = computerBCreator.GetComputer();
        
        
        // ▼ "Print" → "Computer A" ▼
        Console.WriteLine("Computer A:");
        Console.WriteLine(" * Monitor: " + computerA.Monitor); 
        Console.WriteLine(" * Mouse: " + computerA.Mouse);
        Console.WriteLine(" * Keyboard: " + computerA.Keyboard);
        Console.WriteLine(" * Tower: " + computerA.Tower);
        Console.WriteLine(" * Printer: " + computerA.Printer);
        
        
        // ▼ "Print" → "Computer B" ▼
        Console.WriteLine("\nComputer B:");
        Console.WriteLine(" * Monitor: " + computerB.Monitor); 
        Console.WriteLine(" * Mouse: " + computerB.Mouse);
        Console.WriteLine(" * Keyboard: " + computerB.Keyboard);
        Console.WriteLine(" * Tower: " + computerB.Tower);
        Console.WriteLine(" * Printer: " + computerB.Printer);
    }
} 