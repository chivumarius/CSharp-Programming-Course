/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                       • "VISITOR" •

       


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





  ▬ "Visitor" Design Pattern 
    → "Moves" the "Hierarchy" 
    → of "Methods" 
    → into "One Object", 
    → "Separating" an "Algorithm" 
    → from the "Object Structure".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;


//──────────────────────────────────────────────────────────────
// ▬ () "Interface" - "IComponent" Interface ▬
public interface IComponent
{
    // ▬ "Accept()" Method ▬
    void Accept(IVisitor visitor);
}




//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class 1" - "ConcreteComponent1" Class
//        → that "Implements" the "IComponent" Interface ▬
public class ConcreteComponent1 : IComponent
{
    // ▬ "Accept()" Method ▬
    public void Accept(IVisitor visitor)
    {
        // ▼ "Calling" the "VisitConcreteComponent1()" Method ▼
        visitor.VisitConcreteComponent1(this);
    }
    
    
    // ▬ "MethodOfConcreteComponent1()" Method ▬
    public int MethodOfConcreteComponent1()
    {
        return 1;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class 2" - "ConcreteComponent1" Class
//        → that "Implements" the "IComponent" Interface ▬
public class ConcreteComponent2 : IComponent
{
    // ▬ "Accept()" Method ▬
    public void Accept(IVisitor visitor)
    {
        // ▼ "Calling" the "VisitConcreteComponent2()" Method ▼
        visitor.VisitConcreteComponent2(this);
    }
    
    
    // ▬ "MethodOfConcreteComponent2()" Method ▬
    public int MethodOfConcreteComponent2()
    {
        return 2;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3) "Interface" - "IVisitor" Interface ▬
public interface IVisitor
{
    // ▬ "VisitConcreteComponent1()" Method ▬
    void VisitConcreteComponent1(ConcreteComponent1 element);
    
    // ▬ "VisitConcreteComponent2()" Method ▬
    void VisitConcreteComponent2(ConcreteComponent2 element);
}




//──────────────────────────────────────────────────────────────
// ▬ (4-1) "Concrete Visitor Class 1" - "ConcreteVisitor1" Class
//        → that "Implements" the "IVisitor" Interface ▬
public class ConcreteVisitor1 : IVisitor
{
    // ▬ "VisitConcreteComponent1()" Method ▬
    public void VisitConcreteComponent1(ConcreteComponent1 element)
    {
        Console.WriteLine(element.MethodOfConcreteComponent1() + " + ConcreteVisitor1");
    }
    
    
    // ▬ "VisitConcreteComponent2()" Method ▬
    public void VisitConcreteComponent2(ConcreteComponent2 element)
    {
        Console.WriteLine(element.MethodOfConcreteComponent2() + " + ConcreteVisitor1");
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (4-2) "Concrete Visitor Class 2" - "ConcreteVisitor2" Class
//        → that "Implements" the "IVisitor" Interface ▬
public class ConcreteVisitor2 : IVisitor
{
    // ▬ "VisitConcreteComponent1()" Method ▬
    public void VisitConcreteComponent1(ConcreteComponent1 element)
    {
        Console.WriteLine(element.MethodOfConcreteComponent1() + " + ConcreteVisitor2");
    }
    
    
    // ▬ "VisitConcreteComponent2()" Method ▬
    public void VisitConcreteComponent2(ConcreteComponent2 element)
    {
        Console.WriteLine(element.MethodOfConcreteComponent2() + " + ConcreteVisitor2");
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (5) "Client2 Class" - "Client2" Class ▬
public class Client2

{
    // ▬ "Client2()" Method ▬
    public static void ClientCode(List<IComponent> components, IVisitor visitor)
    {
        // ▼ "Iterating" the "List Components" ▼
        foreach (IComponent component in components)
        {
            // ▼ "Calling" the "Accept()" Method ▼
            component.Accept(visitor);
        }
    }
}






//──────────────────────────────────────────────────────────────
// ▬ "Visitor" Class ▬
public class Visitor
{
    // ▬ "RunVisitor()" Method ▬
    public static void RunVisitor()
    {
        // ▼ "Creating" the "List" of "Components" ▼
        List<IComponent> components = new List<IComponent>
        {
            new ConcreteComponent1(),
            new ConcreteComponent2()
        };
        
        
        // ▼ "Variable" of "Concrete Visitor 1" ▼ 
        var visitor1 = new ConcreteVisitor1();
        
        // ▼ "Calling" the "ClientCode()" Method ▼
        Client2.ClientCode(components, visitor1);
        
        
        // ▼ "Variable" of "Concrete Visitor 2" ▼ 
        var visitor2 = new ConcreteVisitor2();
        
        // ▼ "Calling" the "ClientCode()" Method ▼
        Client2.ClientCode(components, visitor2);
    }
} 