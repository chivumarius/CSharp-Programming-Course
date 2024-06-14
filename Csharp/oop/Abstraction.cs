/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                    • "ABSTRACTION" •
       



    ▬ "Abstraction"
            → means "Hiding" the "Programming Details" 
            → (how "Things Work").
            → from the "End User".
                
        
    ▬ "Abstraction" 
        → can be "Achieved" 
        → through: 
            •► "Abstract Classes" and 
            •► "Interfaces".



    ▬ An "Abstract Class" 
        → cannot be "Instantiated", 
        → "It" must be "Inherited" 
        → by "Another Class" 
        → in which "It" is "Instantiated".
    
              
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;


//────────────────────────────────────────────────────
// ▬▬ "Abstract Class" ▬▬
public abstract class AbstractClass
{
    // ▼ "Defining" an "Abstract Method" ▼
    public abstract void MethodFromAbstractClass();
} 



//────────────────────────────────────────────────────
// ▬▬ "Interface Class" ▬▬
public interface InterfaceClass
{
    // ▼ "Defining" a "Method"
    //      → in the "Interface" ▼
    void MethodFromInterface();
}




//────────────────────────────────────────────────────
// ▬▬ "Abstraction" Class
//      → that "Inherits"
//      → the "Abstract Class" ▬▬
public class Abstraction : AbstractClass, InterfaceClass
{
    
    // ▬ "Qverriding" the "MethodFromAbstractClass()"  Method
    //      → from the "AbstractClass" ▬
    public override void MethodFromAbstractClass()
    {
        Console.WriteLine("Method from Abstract Class - Extended in Abstraction Class");
    }
    
    
    
    // ▬ "Overriding" the "MethodFromInterface()" Method
    //      → from the "InterfaceClass" ▬
    public void MethodFromInterface()
    {
        Console.WriteLine("Method from Interface - Implemented in Abstraction Class");
    }
    
    

    // ▬ "RunAbstraction()" Method ▬
    public static void RunAbstraction()
    {
        // ▼ "Creating" an "Instance" of the "Abstraction" Class ▼
        Abstraction abstractionObj = new Abstraction();
    
        
        // ▼ "Accessing" the "Method"
        //      → "Extended" from the "AbstractClass" ▼
        abstractionObj.MethodFromAbstractClass();
    
        // ▼ "Accessing" the "Method"
        //      → "Implemented" in the "InterfaceClass" ▼
        abstractionObj.MethodFromInterface();
    }
} 

