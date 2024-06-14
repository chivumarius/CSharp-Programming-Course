/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "BEHAVIORAL" •
                    ────────────────────
                       • "STRATEGY" •

       


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





  ▬ "Strategy" Design Ppattern 
    → "Lets" the "Program" 
    → "Select" which "Algorithm" 
    → to Use from "Several Choices" 
    → at "Run Time".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.behavioral;




//──────────────────────────────────────────────────────────────
// ▬ (1) "Context2 Class" - "Context2" Class▬
public class Context2
{
  // ▼ "Variables" ▼
  private IStrategy strategy;
  
  
  // ▬ "Constructor" ▬
  public Context2()
  {
  }
  
  
  // ▬ "SetStrategy()" Method ▬
  public void SetStrategy(IStrategy strategy)
  {
    // ▼ "Set" ▼
    this.strategy = strategy;
  }
  
  
  // ▬ "DoSomeBusinessLogic()" Method ▬
  public void DoSomeBusinessLogic()
  {
      // ▼ "Variables" ▼
      var result = strategy.DoAlgorithm(new List<int>{ 1, 2, 3, 4, 5 });
      string resultString = string.Empty;
      
      
      // ▼ "Loop" ▼
      foreach (int element in result as List<int>)
      {
          resultString += element + " ";
      }
      
      // ▼ "Print" ▼
      Console.WriteLine(resultString); 
      
  }
}




//──────────────────────────────────────────────────────────────
// ▬ (2) "Interface" - "IStrategy" Interface ▬
public interface IStrategy
{
    // ▬ "DoAlgorithm()" Method ▬
    object DoAlgorithm(object data);
}




//──────────────────────────────────────────────────────────────
// ▬ (3-1) "Concrete Class 1" - "ConcreteStrategyA" Class
//          → that "Implements" the "Interface" ▬
public class ConcreteStrategyA : IStrategy
{
    // ▬ "DoAlgorithm()" Method ▬
    public object DoAlgorithm(object data)
    {
        // ▼ "List" of "Integers" ▼
        var list = data as List<int>;
        
        // ▼ "Return" ▼
        return list;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ (3-2) "Concrete Class 2" - "ConcreteStrategyB" Class
//          → that "Implements" the "Interface" ▬
public class ConcreteStrategyB : IStrategy
{
    // ▬ "DoAlgorithm()" Method ▬
    public object DoAlgorithm(object data)
    {
        // ▼ "List" of "Integers" ▼
        var list = data as List<int>;
        
        // ▼ "Sorting" the "List" ▼
        list.Sort();
        
        // ▼ "Reverse" the "List" ▼
        list.Reverse();
        
        // ▼ "Return" ▼ 
        return list;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "Strategy" Class ▬
public class Strategy
{
    // ▬ "RunStrategy()" Method ▬
    public static void RunStrategy()
    {
        // ▼ "Variables" ▼
        var context = new Context2();
        
        
        // ▼ "Message A" ▼
        Console.Write("\nStrategy is set to Ascending Sort: ");
        
        // ▼ "Set Strategy" ▼
        context.SetStrategy(new ConcreteStrategyA());
        
        // ▼ "Do Some Business Logic" ▼
        context.DoSomeBusinessLogic();
        
        
        
        // ▼ "Message B" ▼
        Console.Write("\nStrategy is Set to Descending Sort: ");
        
        // ▼ "Set Strategy" ▼
        context.SetStrategy(new ConcreteStrategyB());
        
        // ▼ "Do Some Business Logic" ▼
        context.DoSomeBusinessLogic();
    }
} 