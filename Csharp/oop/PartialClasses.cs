/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                  • "PARTIAL CLASSES" •
       



    ▬ "Partial Classes" in "C#" 
        → are "Classes" 
        → that can be "Defined" 
        → in Several "Separate Files", 
        → allowing "Code" 
        → to be "Logically Broken Up" 
        → and thereby "Improving" its "Organization" 
        → and "Management". 
    
    
    
    ▬ These "Classes" 
        → are "Combined" 
        → into a "Single Entity" 
        → at "Compile Time" 
        → and are "Especially Useful" 
        → for "Large" 
        → or "Automatically Generated Classes", 
        → "Providing" an "Efficient Way" 
        → to "Collaborate" 
        → between "Multiple Developers" 
        → and "Manage Complexity" 
        → in "Software Projects".
    
    
    
    ▬ "partial" Keyword
        → is "Used" to "Declare"
        → a "Partial Class".
                  
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;



//───────────────────────────────────────── ────
// ▬▬ "PartialClass" Class ▬▬
public partial class PartialClass
{
    // ▬ "Method1()" Method ▬
    public void Method1()
    {
        Console.WriteLine("Accessing 'Method1()' from 'Partial Class 1'.");
    }
}




//───────────────────────────────────────── ────
// ▬▬ "PartialClass" Class ▬▬
public partial class PartialClass
{
    // ▬ "Method2()" Method ▬
    public void Method2()
    {
        Console.WriteLine("Accessing 'Method2()' from 'Partial Class 2'.");
    }

    
    // ▬ "Method3()" Method ▬
    public void Method3()
    {
        Console.WriteLine("Accessing 'Method3()' from 'Partial Class 2'.");
    }
}




//───────────────────────────────────────── ────
// ▬▬ "PartialClasses" Class ▬▬
public class PartialClasses
{
    // ▬ "RunPartialClasses()" Method ▬
    public static void RunPartialClasses()
    {
        // ▼ Creating an "Object" of "PartialClass" Class ▼
        PartialClass partialClassObject = new PartialClass();
        
        
        // ▼ Accessing "Methods" of "Both Partial Class" ▼
        partialClassObject.Method1();
        partialClassObject.Method2();
        partialClassObject.Method3();
    }
}