/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                   • "TEMPLATE METHOD" •

       


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





  ▬ "Template" Method Design Pattern 
    → lays out the "Skeleton" 
    → of an "Algorithm" 
    → using an "Abstract Class", 
    → allowing "Its Sub-Classes" 
    → to "Define" its "Behavior".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Abstract Class" - "AbstractClass" Class ▬
public abstract class AbstractClass
{
    // ▬ "TemplateMethod()" Method ▬
    public void TemplateMethod()
    {
        // ▼ "Calls" ▼
        Operation1();
        RequiredOperation1();
        Operation2();
        Hook1();
        RequiredOperation2();
        Operation3();
        Hook2();
    }

    // ▬ "Operation1()" Method ▬
    protected void Operation1()
    {
        // ▼ "Message" ▼
        Console.WriteLine("\nPerforming Operation 1");
    }

    // ▬ "Operation2()" Method ▬
    protected void Operation2()
    {
        // ▼ "Message" ▼
        Console.WriteLine("\nPerforming Operation 2");
    }

    // ▬ "Operation3()" Method ▬
    protected void Operation3()
    {
        // ▼ "Message" ▼
        Console.WriteLine("\nPerforming Operation 3");
    }

    // ▬ "RequiredOperation1()" Abstract Method ▬
    protected abstract void RequiredOperation1();

    // ▬ "RequiredOperation2()" Abstract Method ▬
    protected abstract void RequiredOperation2();

    // ▬ "Hook1()" Virtual Method ▬
    protected virtual void Hook1() { }

    // ▬ "Hook2()" Virtual Method ▬
    protected virtual void Hook2() { }
}




//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class 1" - "ConcreteClass1" Class
//          → that "Extends" the "Abstract Class" ▬
public class ConcreteClass1 : AbstractClass
{
    // ▬ "RequiredOperation1()" Overridden Method ▬
    protected override void RequiredOperation1()
    {
        Console.WriteLine("Concrete Class 1 - Performing Required Operation 1");
    }

    // ▬ "RequiredOperation2()" Overridden Method ▬
    protected override void RequiredOperation2()
    {
        Console.WriteLine("Concrete Class 1 - Performing Required Operation 2");
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class 2" - "ConcreteClass2" Class
//          → that "Extends" the "Abstract Class" ▬
public class ConcreteClass2 : AbstractClass
{
    // ▬ "RequiredOperation1()" Overridden Method ▬
    protected override void RequiredOperation1()
    {
        Console.WriteLine("Concrete Class 2 - Performing Required Operation 1");
    }

    // ▬ "RequiredOperation2()" Overridden Method ▬
    protected override void RequiredOperation2()
    {
        Console.WriteLine("Concrete Class 2 - Performing Required Operation 2");
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3) "Client2 Class" - "Client2" Class ▬
public class Client
{
    // ▬ "ClientCode()" Method ▬
    public static void ClientCode(AbstractClass abstractClass)
    {
        // ▼ "Call" the "Template Method" ▼
        abstractClass.TemplateMethod();
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "Template" Class ▬
public class Template
{
    // ▬ "RunTemplate()" Method ▬
    public static void RunTemplate()
    {
        // ▼ "Call" the "Client2 Code" ▼
        Client.ClientCode(new ConcreteClass1());
        Client.ClientCode(new ConcreteClass2());
    }
}