/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                    • "INHERITANCE" •
       



    ▬ "Inheritance"
            → means that a "Class" 
            → can Share 
            → "Data" and "Functionalities" 
            → to "Other Classes" 
            → "Without" to "Writing" 
            → the "Logic".
                
         
       ▬ To "Inherit" 
            → from "Another Class" 
            → we use "Colon" (":") Symbol.
   
   
   
    ▬ There ar "2 Types" of "Classes"
        1- "Base Class" ("Parent Class"/ "Super Class").
        2- "Derived Class" ("Child Class"/ "Sub Class").
    
    
    ▬ `sealed' Keyword in "C#" 
        → is Used to "Block Extending" 
        → a "Class" or "Method" 
        → through "Inheritance". 
        
        
    ▬ A `sealed' Class 
        → cannot be "Inherited" 
        → by "Other Classes" 
        → and a `sealed' Method 
        → cannot be "Overridden" 
        → in "Derived Classes". 
    
  
    ▬ "virtual" Keyword 
        → allows a "Method" 
        → to be "Overridden".

    ▬ "override" Keyword 
        → "Overrides" a "Method".
        
                        
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;



//────────────────────────────────────────────────────
// ▬▬ "BaseClass" Class ("Parent Class"/ "Super Class")
//       → will be "Inherited" ▬▬
public class BaseClass
{
    public virtual void Print()
    {
        Console.WriteLine("The 'Print()' Method of the 'BaseClass' Class.");
    }
}




//────────────────────────────────────────────────────
// ▬▬ "DerivedClass" Class ("Child Class"/ "Sub Class")
//       → "Inherit" from "BaseClass" ▬▬
public class DerivedClass : BaseClass
{
    
    // ▬ "Override" the "Print()" Method ▬
    public override void Print()
    {
        Console.WriteLine();
        
        
        // ▼ Call "BaseClass.Print()" Method ▼
        base.Print();
        
        // ▼ "Displaying" the "Message" ▼
        Console.WriteLine("The 'Print()' Method of the 'DerivedClass' Class.");
    }
}





//────────────────────────────────────────────────────
// ▬▬ "Inheritance" Class ▬▬
public class Inheritance
{
    public static void RunInheritance()
    {
        // ▼ "Create" an "Object" of "BaseClass" ▼
        BaseClass baseObject = new BaseClass();
        baseObject.Print();
        
        
        // ▼ "Create" an "Object" of "DerivedClass" ▼
        DerivedClass derivedObject = new DerivedClass();
        derivedObject.Print();
    }
} 