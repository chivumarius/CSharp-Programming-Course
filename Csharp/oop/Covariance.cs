/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "OOP" •
                        ─────────
                    • "COVARIANCE" •
       



    ▬ "Covariance" in "C#"
        → allows a "Derived Class/Type" 
        → to be "Treated" 
        → as a "Base Class/Type" 
        → in "Contexts" where a "Base Class/Type" 
        → are "Expected". 
    
    
    
    ▬ This "Means" 
        → that we can "Use" 
        → an "Object" 
        → of a "Derived Class/Type"
        → where an "Object" of the "Base Class/Type" 
        → is "Expected" 
        → "Without" causing "Type Errors". 
    
    
    
    ▬ This "Makes It" 
        → "Easier" to Use "Type Hierarchies" 
        → and "Makes" your "Code" 
        → more "Flexible".
    
              
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.oop;



//────────────────────────────────────────────────────
// ▬▬ "SuperClass" Class ("Parent Class"/ "Base Class")
//       → will be "Inherited" ▬▬
public class SuperClass
{
    
    // ▬ "Print()" Method
    //      → will be "Overridden" 
    //      → in the "SubClass"
    //      → by "Setting It" as "virtual" ▼
    public virtual void Print()
    {
        Console.WriteLine("Printing from SuperClass.");
    }
}




//────────────────────────────────────────────────────
// ▬▬ "SubClass" Class ("Child Class"/ "DerivedClass")
//       → "Inherit" from "SuperClass" ▬▬
public class SubClass : SuperClass
{
    
    // ▬ "Override" the "Print()" Method ▬
    // ▬ "Override" the "Print()" Method ▬
    public override void Print()
    {
        Console.WriteLine("Printing from SubClass.");
    }
}






//────────────────────────────────────────────────────
// ▬▬ "Covariance" Class ▬▬
public class Covariance
{
    // ▬ "MyCovariance()" Method ▬
    public static void MyCovariance(SuperClass super)
    {
        super.Print();
    }
    
    

    // ▬ "RunPCovariance()" Method ▬
    public static void RunCovariance()
    {
        // ▼ Creating "Objects" ▼
        SuperClass superObject = new SuperClass();
        SubClass subObject = new SubClass();

        
        // ▼ "Accessing" → "MyCovariance()" Method 
        //      → with superObject ▼
        Console.Write("Accessing 'MyCovariance()' Method - with 'superObject': ");
        MyCovariance(superObject);  
        
        
        // ▼ "Accessing" → "MyCovariance()" Method 
        //      → with subObject ▼
        Console.Write("Accessing 'MyCovariance()' Method - with 'subObject': ");
        MyCovariance(subObject);    
    }
} 


