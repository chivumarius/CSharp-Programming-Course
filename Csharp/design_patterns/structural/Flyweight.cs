/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "STRUCTURAL" •
                    ────────────────────
                      • "FLYWEIGHT" •

       


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




  ▬ "Flyweight" Design Pattern 
    → "Reduces" the "Overhead" 
    → of Creating "Complex Object" Patterns.

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.structural;



//──────────────────────────────────────────────────────────────
// ▬ (1) "Interface" - "IColor" Interface ▬
public interface IColor
{
    // ▬ "Print()" Method ▬
    void Print();
}



//──────────────────────────────────────────────────────────────
// ▬ (2-1) "Concrete Class 1" - "Red" Class
//          → that "Implements" the "Interface" ▬
public class Red : IColor
{
    // ▬ "Print()" Method Implementation ▬
    public void Print()
    {
        Console.WriteLine("Printing Red");
    }
}



//──────────────────────────────────────────────────────────────
// ▬ (2-2) "Concrete Class 2" - "Green" Class
//          → that "Implements" the "Interface" ▬
public class Green : IColor
{
    // ▬ "Print()" Method Implementation ▬
    public void Print()
    {
        Console.WriteLine("Printing Green");
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (2-3) "Concrete Class 3" - "Blue" Class
//          → that "Implements" the "Interface" ▬
public class Blue : IColor
{
    // ▬ "Print()" Method Implementation ▬
    public void Print()
    {
        Console.WriteLine("Printing Blue");
    }
}




//──────────────────────────────────────────────────────────────
// ▬ (3) "Factory" - "ColorObjectFactory" Class
//          → that "Allow" to "Reuse" an "Object" ▬
public class ColorObjectFactory
{
    // ▼ "Constants" ▼
    const string RED = "Red";
    const string GREEN = "Green";
    const string BLUE = "Blue";
    
    
    // ▼ "Member Variable" ▼
    Dictionary<string, IColor> colors = new Dictionary<string, IColor>();

    // ▼ "Property" ▼
    public int TotalObjectsCreated
    {
        get
        {
            return colors.Count;
        }
    }

    
    // ▬ "GetColor()" Method ▬
    public IColor GetColor(string colorName)
    {
        // ▼ "Variable" ▼
        IColor color = null;
        
        // ▼ "Conditional Statement" ▼
        if (colors.ContainsKey(colorName))
        {
            color = colors[colorName];
        }
        else
        {
            // ▼ "Switch Statement" ▼
            switch (colorName)
            {
                case RED:
                    color = new Red();
                    colors.Add(RED, color);
                    break;
                
                case GREEN:
                    color = new Green();
                    colors.Add(GREEN, color);
                    break;
                
                case BLUE:
                    color = new Blue();
                    colors.Add(BLUE, color);
                    break;
                
                default:
                    throw new Exception("Factory cannot create the specified object");
            }
        }
        
        // ▼ "Return" ▼
        return color;
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "Flyweight" Class ▬
public class Flyweight
{
    // ▬ "RunFlyweight()" Method ▬
    public static void RunFlyweight()
    {
        // ▼ "Variable" ▼
        ColorObjectFactory factory = new ColorObjectFactory();
        
        // ▼ "Get" the "Red Color"  ▼
        IColor colorRed = factory.GetColor("Red");
        colorRed.Print();
        
        // ▼ "Get" the "Green Color" ▼
        IColor colorGreen = factory.GetColor("Green");
        colorGreen.Print();
        
        // ▼ "Get" the "Blue Color"  ▼
        IColor colorBlue = factory.GetColor("Blue");
        colorBlue.Print();
        
        
        
        Console.WriteLine();
        
        
        // ▼ "Reset" the "Red Color"  ▼
        colorRed = factory.GetColor("Red");
        colorRed.Print();
        
        // ▼ "Reset" the "Green Color" ▼
        colorGreen = factory.GetColor("Green");
        colorGreen.Print();
        
        // ▼ "Reset" the "Blue Color"  ▼
        colorBlue = factory.GetColor("Blue");
        colorBlue.Print();

        
        
        // ▼ "Variable" ▼
        int numberOfObjects = factory.TotalObjectsCreated;
        
        // ▼ "Output" ▼
        Console.WriteLine($"Total Objects Created {numberOfObjects}");
    }
} 