/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DESIGN PATTERNS" •
                      • "CREATIONAL" •
                    ────────────────────
                      • "SINGLETON" •

       


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



  ▬ "Singleton" Design Pattern 
    → "Ensures" that "Only One Instance" 
    → of an "Object" 
    → is "Created" 
    → and "Exists" in the "App"
    → at "Any One Time".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.design_patterns.creational;


//──────────────────────────────────────────────────────────────
// ▬ (1) "Singleton" - "Singleton" Class ▬
public class Singleton
{
   // ▼ "Field" ▼
   private static Singleton instance;
   
   // ▼ "Constructor" ▼
   protected Singleton()
   {
   }
   
   
   // ▬ "GetInstance()" Method ▬
   public static Singleton GetInstance()
   {
       if (instance == null)
       {
           // ▼ "Set" ▼
           instance = new Singleton();
       }
       
       return instance;
   }
}



//──────────────────────────────────────────────────────────────
// ▬ (2) "Client2" - "SingletonDesignPattern" Class
//         → that "Uses" the "Singleton" Class ▬
public class SingletonDesignPattern
{
    // ▬ "RunSingletonDesignPattern()" Method ▬
    public static void RunSingletonDesignPattern()
    {
        // ▼ Using the "GetInstance()" Method
        //      → to "Get" the "Singleton Instance" ▼
        Singleton singletonInstance = Singleton.GetInstance();

        // ▼ "Displaying" a "message" to "Show" 
        //      → that the "Singleton Instance" has been "Created" ▼
        Console.WriteLine("Singleton instance created successfully!");
    }
} 