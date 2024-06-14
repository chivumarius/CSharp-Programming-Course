/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "ABSTRACT CLASS" •
                     ────────────────────

       

  1 What are "Abstract Classes"?

    ▬ "Abstract Classes"
        → are "Base Templates" 
        → for "Other Classes"  
        → and they "Cannot" be "Instantiated Directly", but can be used to create other classes.


    
    ▬ "Abstract Classes"
        → can have "Abstract Methods" 
        → ("Without Implementation") 
        → and "Concrete Methods" 
        → ("With Implementation").
        
        
        ♦ "Abstract Methods" 
            → "Must" be "Implemented" 
            → by the "Classes" 
            → that "Extend Them".



    ▬ Used
        → to "Define" a "Common Behaviors" 
        → for "Multiple Derived Classes"    
        → and to "Define" 
        → a "Contract" or "Set" of "Methods" 
        → that "Derived Classes" 
        → must "Implement".


    ▬ Benefits:
        1. "Code Reuse" 
            → and "Defining" a "Common Set" 
            → of "Functionality".
        
        
        2. Supports "Polymorphism", 
            → allowing "Methods Defined" 
            → in the "Abstract Class" 
            → to be "Called" 
            → using "References" to "Objects" 
            → of the "Abstract Class" Type.

    
    ▬ We "Use" 
        → the Punctuation Mark ":" 
        → to "Extend" 
        → the "Abstract Class".


    ▬ We "Use" 
        → the "abstract" Keyword 
        → to "Declare Abstract Classes" 
        → and "Abstract Methods".

    ▬ We "Use" 
        → the "override" Keyword 
        → to "Override" 
        → the "Abstract Methods".
   
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.interfaces_and_abstract_classes.abstract_classes;


// ▬▬ "Abstract Class" ("Base Class") ▬▬
abstract class Animal
{
    
    // ▬ "Abstract Method" (without "Body") ▬
    public abstract void Run(int speed);
}


// ▬▬ "Derived Class"
//      → that "Extends" the "Base Class" ▬▬
class Dog : Animal
{
    // ▬ "Override" the "Abstract Method" ▬
    public override void Run(int speed)
    {
        Console.WriteLine($"The Dog is Running at {speed}km/h.");
    }
} 



// ▬▬ "Demonstration Class" ▬▬
public class AbstractClass
{
   // ▬ "RunApp()" Method ▬
   public static void RunAbstractClass()
   {
       // ▼ Creating an "Object/Instance" of the "Dog" Class ▼
       Dog dog = new Dog();
       
       // ▼ "Calling" the "Run()" Method ▼
       dog.Run(50);
   }
}  