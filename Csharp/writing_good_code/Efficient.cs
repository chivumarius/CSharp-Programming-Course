/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "WRITING GOOD  CODE" •
                    ───────────────────────
                     • (4) "EFFICIENT" •

       


    ▬ A "Good Code" is:
        1. "Reusable"
        2. "Clean"
        3. "Safe"
        4. "Efficient"
        5. "Scalable"



    

    4. "Efficient" Code
        → is "Responsibly Uses":
            •► "Time" and
            •► "Space"
        → and "Runs"
        → in a "Timely Manner".
  

        ▬ Writing "Efficient" Code
            • Efficient Code
                → means "Our Code"
                → will "Run Faster"
                → and "Perform Better".
            
            • "Don't Want"
                → "Lag In" our "Programs",
                → that will "Cause" a
                → "Bad User Experience".




    ▬ Writing "Efficient" Code
        
        • Remember
            → the "Big-O" Notation.
        
        
        • Use "for()" Loop
            → instead of "foreach()" Loop
        
        
        • Use "Structs"
            → instead of "Classes".
        
        
        • Use "StringBuilder"
            → for "Concatenation".
        
        
        • Use "Variables"
            → instead of "Properties".
        
        
        • Use "string.Compare()"
            → for "String Comparisons".
        
        
        • Use "List"
            → instead of "ArrayList".
        
        
        • Use "&&" and "||"
            → instead of "&" and "|".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.writing_good_code;

//──────────────────────────────────────────────────────────────
// ▬ "Efficient" Class ▬
public class Efficient
{
    // ▬ "PerformEfficientOperation()" Method ▬
    private static int PerformEfficientOperation()
    {
        Console.WriteLine("Performing efficient operation...");

        // Simulating a time-consuming operation
        System.Threading.Thread.Sleep(1000);

        // Return the result of the efficient operation
        return 42;
    }

    // ▬ "RunEfficient()" Method ▬
    public static void RunEfficient()
    {
        Console.WriteLine("Starting efficient code execution...");

        // Perform efficient operations
        var result = PerformEfficientOperation();

        Console.WriteLine($"Efficient operation result: {result}");

        Console.WriteLine("Efficient code execution finished successfully.");
    }
}
