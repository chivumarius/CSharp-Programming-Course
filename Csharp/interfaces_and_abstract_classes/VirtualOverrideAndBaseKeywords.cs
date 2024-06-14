/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "CLASS" •
                     ────────────────────
            • "VIRTUAL", "OVERRIDE" & "BASE" KEYWORDS •

       

    ▬ The `virtual' Keyword in "C#"
        → is "Used" to "Mark" a 
            •► "Method", 
            •► "Property", or 
            •► "Indexer" 
        → as "Overridable" 
        → in "Derived Classes" ("Sub-Classes"). When a method is declared virtual in a base class, this allows derived classes to override the method's implementation using the `override' keyword.



    ▬ By "Marking" 
        → a "Method" as `virtual', 
        → it can be "Overridden" 
        → in "Derived Classes" 
        → to "Provide" a "Specific Implementation" 
        → for that "Type" of "Class". 
        
        
        ♦ This is an "Important Technique" 
            → in the "Concepts" 
            → of "Polymorphism" ("Multiple Forms") 
            → and "Extensibility" 
            → in "OOP" ("Object-Oriented Programming").
   
   
   
    ▬ The "base" Keyword in "C#"
        → is "Used" to "Access Members" 
        → from the "Base Class" ("Parent Class")
        → in a "Derived Class" ("Child Class"). 
        
        
        ♦ It 
            → Allows the "Base Class Constructors" 
            → and "Methods" 
            → to be "Called" 
            → within a "Derived Class", 
            → thus "Allowing" the "Functionality" 
            → to be "Extended" 
            → and "Access" to the "Behavior" 
            → of the "Base Class".


    ▬ For "Example": 
        ♦ In a "Derived Class" 
            → you can Use 
                •► "base.MethodName()" 
            → to "Call" a "Method" 
            → "Defined" in the "Base Class" 
            → with the "Same Name". 
        
        ♦ "base()" 
            → can also be "Used" 
            → to Call the "Base Class Constructor" 
            → from a "Derived Class Constructor". 
        
    
    
    ▬ Using "base" Keyword 
        → is "Useful" when you "Want" 
        → to "Preserve" the "Behavior" 
        → of the "Base Class" 
        → in a "Derived Class" 
        → and "Add" new "Functionality".
 
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.interfaces_and_abstract_classes;



// ▬▬ "Base Class" ▬▬
class BaseClass
{
    
    // ▬ "Virtual" Method
    //      → that allow "Overriding"
    //      → in "Derived Classes" ▬
    public virtual  void PrintMessage()
    {
        Console.WriteLine("Message from the Base Class.");
    }
}



// ▬▬ "Derived Class" ▬▬
class DerivedClass : BaseClass
{
    // ▬ "Override" Method
    //      → and "Accessing" the "Member Method"  
    //      → from the "Base Class"
    //      → in "Derived Classes" ▬
    public override void PrintMessage()
    {
        Console.WriteLine("Message from the Derived Class.");
        
        Console.Write("\nBase Keyword: ");
        base.PrintMessage();
    }
}




// ▬▬ "Class" ▬▬
public class VirtualOverrideAndBaseKeywords
{
    
    
    // ▬ "RunVirtualMethods()" Method ▬
    public static void VirtualOverrideAndBase()
    {
        // ▼ "Create" an "Object/Instance" of the "Derived Class" ▼
        BaseClass derivedClass1 = new DerivedClass();
        
        // ▼ "Call" the "PrintMessage()" Method ▼
        derivedClass1.PrintMessage();
    }
}