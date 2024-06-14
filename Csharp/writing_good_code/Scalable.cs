/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "WRITING GOOD  CODE" •
                    ───────────────────────
                      • (5) "SCALABLE" •

       


    ▬ A "Good Code" is:
        1. "Reusable"
        2. "Clean"
        3. "Safe"
        4. "Efficient"
        5. "Scalable"



    5. "Scalable" Code
        → is "Graceful"
        → even as the "Size"
        → of the "User Base Grows".


    ▬ Writing scalable code
        
        • "Scalability"
            → is how "Adaptable"
            → the "Code Is"
            → and how "Well" it "Performs"
            → as the "Number"
            → of the of "Users Increases".
        
        
        • "Keep" the "Code"
            → "Generic",
            → don't "Hardcode Anything"
        
        
        • Ex: "Any Numbers"
                → in the "Code"
                → should be "Variables".
        
        
        • "Make Cure"
            → that the "Code"
            → will "Perform v"
            → of the "Users Increases".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.writing_good_code;

//──────────────────────────────────────────────────────────────
// ▬ "UserService" Class ▬
// ▼ "Service" to "Handle User Operations" ▼
public class UserService
{
    // ▬ "AddUser()" Method ▬
    // ▼ "Simulate Adding a User" ▼
    public async Task AddUser(string userName)
    {
        // Simulate a delay to represent an operation like a database call
        await Task.Delay(100);
        Console.WriteLine($"User {userName} added.");
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Scalable" Class ▬
public class Scalable
{
    // ▬ "RunScalable()" Method ▬
    public static async Task RunScalable()
    {
        // ▼ "List of User Names" ▼
        List<string> userNames = new List<string> { "Alice", "Bob", "Charlie", "Dave", "Eve" };

        // ▼ "Instance of UserService" ▼
        UserService userService = new UserService();

        // ▼ "Add Users Concurrently" ▼
        List<Task> tasks = new List<Task>();
        foreach (var userName in userNames)
        {
            tasks.Add(userService.AddUser(userName));
        }

        // ▼ "Wait for All Tasks to Complete" ▼
        await Task.WhenAll(tasks);

        Console.WriteLine("All users added successfully.");
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Reusable" Class ▬
public class Reusable2
{
    // ▬ "RunReusable()" Method ▬
    public static async Task RunReusable()
    {
        await Scalable.RunScalable();
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "Program" Class ▬
public class Program
{
    public static async Task Main(string[] args)
    {
        await Reusable2.RunReusable();
    }
}
