/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                   • "OVERRIDING" •


       

    ▬ "Overriding" in "C#" 
        → is the "Process" by which 
        → a "Sub-Class" (or "Derived Class") 
        → can "Provide" a "Specific Implementation" 
        → for a "Method" 
        → "Defined" in a "Super-Class" (or "Base Class"). 
        
        
        ♦ When a "Method" 
            → is "Overridden" 
            → in a "Sub-Class" ("Derived Class"), 
            → it "Overrides" the "Implementation" 
            → of the "Inherited Method" 
            → in the "Super-Class" ("Base Class").

    
    
    ▬ To "Override" a "Method" 
        → in a "Sub-Class" ("Derived Class"), 
        → it "Must Meet" 
        → the Following "Conditions":

        1. The 
                •► "Name", 
                •► "Return Type", and 
                •► "Signature" 
            → of the "Method" 
            → in the "Sub-Class" ("Derived Class")
            → "Must" be "Identical" 
            → to the "Method" 
            → in the "Super-Class" ("Base Class").
        
        
        2. The "Override" Modifier 
            → "Must" be "Added" 
            → in "Front" 
            → of the "Sub-Class" ("Derived Class") 
            → "Method Definition".
        
        
        3. The "Method" 
            → we are "Trying" to "Override" 
            → "Must" be "Marked" 
            → with the "virtual" or "abstract" Modifier 
            → in the "Super-Class" ("Base Class").

    
    
    ▬ By "Overriding" Methods, 
        → Sub-Class ("Derived Classes"" 
        → can Provide "Specific Behaviors" 
        → or "Enhancements" 
        → to "Methods Inherited" 
        → from the "Super-Class" ("Base Class") 
        → "Without Affecting" the "Behavior" 
        → of "Other Classes" 
        → that "Use" the "Super-Class" ("Base Class"). 
                
        
        ♦ This "Allows" 
            → for "Greater Flexibility" 
            → and "Adaptability" 
            → in "Class Hierarchies" in "C#".
        
    
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace Csharp.functions;

public class Overriding
{
    
    public void PrintMessage()
    {
        Console.WriteLine("Hello World, from Supper-Class!");
    }
}



// ▬ "Sub-Class" 
//      → that "Extends" (":")
//      → a "Super-Class" ▬    
public class Overriding2 : Overriding
{
    
    // ▬ "Overriding" the "Method" of the "Super-Class" ▬
    public void PrintMessage()
    {
        Console.WriteLine("Hi World, from Overriding Method!");
    }
    
    
    
    public static void RunOverriding2()
    {
        // ▼ "Create" an "Instance" of the "Sub-Class" ▼
        Overriding2 override2 = new Overriding2();
        
        // ▼ "Accessing"
        //      → the "Method" of the "Super-Class"
        //      → or the "Overridden" Method 
        override2.PrintMessage();
    }
}