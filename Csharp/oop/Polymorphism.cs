/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                   • "POLYMORPHISM" •
       



    ▬ "Polymorphism" ("Multiple Forms") 
            → means that "Classes" 
            → can have "Different Functionalities" 
            → or "Share" a "Common Interface", 
            → in other words 
            → "Objects" can Take "Multiple Forms".         
        
        
    ▬ "virtual" Keyword 
        → allows a "Method" 
        → to be "Overridden".

    ▬ "override" Keyword 
        → "Overrides" a "Method".
              
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;

//────────────────────────────────────────────────────
// ▬▬ "ParentClass" Class ("Parent Class"/ "Super Class")
//       → will be "Inherited" ▬▬
public class ParentClass
{
    
    // ▬ "Print()" Method ▬
    public virtual void Example()
    {
        Console.WriteLine("The 1st 'Example()' Method of the 'ParentClass' Class.");
    }
}




//────────────────────────────────────────────────────
// ▬▬ "ChildClass" Class ("Child Class"/ "Sub Class")
//       → "Inherit" from "ParentClass" ▬▬
public class ChildClass : ParentClass
{
    
    // ▬ "Override" the "Print()" Method ▬
    public override void Example()
    {
        // ▼ "Displaying" the "Message" ▼
        Console.WriteLine("The 2nd 'Example()' Method of the 'ChildClass' Class.");
    }
}





//────────────────────────────────────────────────────
// ▬▬ "Polymorphism" Class ▬▬
public class Polymorphism
{

    // ▬ "RunPolymorphism()" Method ▬
    public static void RunPolymorphism()
    {
        // ▼▼▼ "Polymorphism" Example ▼▼▼
        // ▼ "Create" an "Object"
        //      → from "ParentClass"
        //      → of "ChildClass" Type  ▼
        ParentClass parentObject = new ChildClass();
        parentObject.Example();
    }
} 


