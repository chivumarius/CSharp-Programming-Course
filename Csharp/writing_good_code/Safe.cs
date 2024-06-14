/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "WRITING GOOD  CODE" •
                    ───────────────────────
                        • (3) "SAFE" •

       


    ▬ A "Good Code" is:
        1. "Reusable"
        2. "Clean"
        3. "Safe"
        4. "Efficient"
        5. "Scalable"



    3. "Safe" Code
        → is "Secure" and "Gracefully"
        → "Handles Exceptions".
  

        ▬ Writing safe code
            
            • "Guards Against Bugs"
                → and "Errors".
            
            • "Quality", "Comprehensible", and "Predictable".
            
            • "Defensive Coding"
                → means "Writing Code"
                → that "Guards Against Errors"
                → and "Handles" them "Gracefully"
                → if they "Pop Up".
                
            • "Unit Tests", "Validation", and "Exception Handling".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.writing_good_code;

//──────────────────────────────────────────────────────────────
// ▬ "Safe" Class ▬
public class Safe
{
    // ▬ "PerformSafeOperation()" Method ▬
    private static void PerformSafeOperation()
    {
        Console.WriteLine("Performing safe operation...");
        // Safe operation logic goes here
        Console.WriteLine("Safe operation performed.");
    }

    // ▬ "RunSafe()" Method ▬
    public static void RunSafe()
    {
        Console.WriteLine("Starting safe code execution...");

        // Perform safe operations
        try
        {
            PerformSafeOperation();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            // Handle the exception gracefully or log it for further investigation
        }

        Console.WriteLine("Safe code execution finished successfully.");
    }
}
