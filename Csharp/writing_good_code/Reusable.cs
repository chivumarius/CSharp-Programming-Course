/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "WRITING GOOD  CODE" •
                    ───────────────────────
                      • (1) "REUSABLE" •

       


    ▬ A "Good Code" is:
        1. "Reusable"
        2. "Clean"
        3. "Safe"
        4. "Efficient"
        5. "Scalable"



    1. "Reusable" Code
          → is "Generic" Enough
          → to be "Applied"
          → to "Several Scenarios".
          
          
          ♦ "Write" it "Once"
            → and "Reuse" it "Everywhere".


        ▬ Writing "Reusable" Code
            
            • "Avoid Adding"
                → the "Same Code"
                → "Over" and "Over" in the "Project".
            
            
            • "DRY" = "Don't Repeat Yourself"
            
            • By "Using":
                •► "Functions",
                •► "Polymorphism",
                •► "Inheritance",
                •► "Interfaces","
                •► "Static Classes".
                
            
            • "Single Responsibility Principle"
                → mean "Each Function" or "Method"
                → should do "Only One Thing".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.writing_good_code;

//──────────────────────────────────────────────────────────────
// ▬ "Helper1" Class ▬
public class Helper1
{
    // ▬ "Method1()" Method ▬
    public static void Method1()
    {
        Console.WriteLine("Executing Helper1.Method1...");
        // Place your Helper1-specific code here
        Console.WriteLine("Helper1.Method1 executed successfully.");
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Helper2" Class ▬
public class Helper2
{
    // ▬ "Method2()" Method ▬
    public static void Method2()
    {
        Console.WriteLine("Executing Helper2.Method2...");
        // Place your Helper2-specific code here
        Console.WriteLine("Helper2.Method2 executed successfully.");
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Reusable" Class ▬
public class Reusable
{
    // ▬ "RunReusable()" Method ▬
    public static void RunReusable()
    {
        Console.WriteLine("Starting reusable code...");

        // Reusing code from Helper1
        Helper1.Method1();

        // Reusing code from Helper2
        Helper2.Method2();

        Console.WriteLine("Reusable code finished execution.");
    }
}
