/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEPENCENCY  INJECTION" •
                    ───────────────────────────
                      • "IMPLEMENTATION" •

       


    ▬ "Dependency Injection" ("DI")
        → is a "Design Pattern"
        → in which an "Object's Dependencies"
        → are "provided"
        → by an "External Source"
        → rather than the "Object Itself",
        → promoting "Loose Coupling"
        → and "Easier Testing".



   ▬ "Dependency Injection Guidelines" and "Best Practices"
       
        1- Avoid "Storing Global State".
        
        2- Avoid "Directly Referencing One Class"
            → from "Inside" of "Another Class".
        
        3- "Write Methods"
            → that are "Small"
            → and "Easily Testable".
        
        4- "Follow"
            →the "Single Responsibility" Principle.



    ▬ "Advantages" of "Dependency Injection"

        1- "Improves Code Reusability".
        
        2- Makes "Unit Testing" the "Code"
            → "Easier"
            → by allowing us to Create "Mock Code"
            → of the "Injected Dependencies".
        
        3- It "Reduces Boilerplate Code"
            → in our "Program"
            → since the "Dependencies"
            → get "Initialized"
            → by their "Injector Component".
        
        4- It Changes "Tightly Coupled Code"
            → into "Loosely Coupled Code",
            → "Removing Dependencies" between "Objects".
        
        5- It makes the "Code Cleaner"
            → and "Easier" to "Maintain",
            → especially as the "Program Grows"
            → in "Size" and "Complexity".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// ▼ "Folder Name" ▼
namespace CSharp.dependency_injection;

//──────────────────────────────────────────────────────────────
// ▬ "Injector" Interface ▬
interface Injector
{
    // ▬ "Method1()" ▬
    public void Method1();
}

//──────────────────────────────────────────────────────────────
// ▬ "Class1" Class
//     → implementing "Injector" Interface ▬
class Class1 : Injector
{
    // ▬ "RunClass1()" Method ▬
    public void Method1()
    {
        // ▼ "Outout" ▼
        Console.WriteLine("Method 1 was Called.");
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Class2" Class ▬
class Class2
{
    // ▼ "Variable Declaration" ▼
    Injector class1;

    // ▬ "Constructor" ▬
    public Class2(Injector injector)
    {
        class1 = injector;
    }

    // ▬ "RunClass2()" Method ▬
    public void Method2()
    {
        // ▼ "Call"/"Access" → the "Method1()" of the "Class1" ▼
        class1.Method1();
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "DependencyInjection" Class ▬
public class DependencyInjection
{
    // ▬ "RunDependencyInjection()" Method ▬
    public static void RunDependencyInjection()
    {
        // ▼ "Variable" ▼
        Class1 class1 = new Class1();
        Class2 class2 = new Class2(class1);

        // ▼ "Call"/"Access" → the "Method2()" of the "Class2" ▼
        class2.Method2();
    }
}
