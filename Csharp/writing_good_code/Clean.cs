/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "WRITING GOOD  CODE" •
                    ───────────────────────
                       • (2) "CLEAN" •

       


    ▬ A "Good Code" is:
        1. "Reusable"
        2. "Clean"
        3. "Safe"
        4. "Efficient"
        5. "Scalable"



   

    2. "Clean" Code
        → is "Conforms" to "Best Practices"
        → and is "Free"
        → of "Any Anti-Patterns".



    ▬ "Names" and "Conventions" are:
        1. "Pascal Case"
            → in which the "First Letter" is "Upper Case".
       
        2. "Camel Case"
            → in which the "First Letter" is "Lower Case".
        

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.writing_good_code;

public class Clean
{
    // ▬ "PerformCleanOperation()" Method ▬
    private static void PerformCleanOperation()
    {
        Console.WriteLine("Performing clean operation...");
        // Clean operation logic goes here
        Console.WriteLine("Clean operation performed.");
    }

    // ▬ "RunClean()" Method ▬
    public static void RunClean()
    {
        Console.WriteLine("Starting clean code execution...");

        // Call a method to perform a clean operation
        PerformCleanOperation();

        Console.WriteLine("Clean code execution finished successfully.");
    }
}
