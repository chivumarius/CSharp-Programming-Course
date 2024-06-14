/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
               • "ASYNCHRONOUS FUNCTIONS" •
                
       

    ▬ "Asynchronous Functions" in "C#" 
        → are "Functions" 
        → that "Allow" the "Execution" 
        → of "Asynchronous Operations" 
        → in a more "Efficient" and "Simple Way". 
        
        
        ♦ "They" 
            → are "Used" 
            → to "Handle Operations" 
            → that "Might Block" 
            → an "Application's Main Thread" 
            → of "Execution", 
            → such as: 
                •► "Long I/O Operations", 
                •► "Network Requests", or 
                •► "Database Access".



    ▬ The "Main Advantages" 
        → of "Asynchronous Functions" in "C#":

        1. "Improved Performance": 
            ♦ "Asynchronous Functions" 
                → allow "Applications" 
                → to "Continue Running" 
                → and "Perform Other Operations" 
                → while "Waiting" 
                → for "Asynchronous Operations" 
                → to "Complete". 
            
            
            ♦ This "Improves" 
                → the "Reactivity" 
                → and "Performance" 
                → of the "Application".


        2. "Efficient Use" of "Resources": 
            ♦ "Instead" of "Blocking" 
                → the "Main Thread" 
                → of "Execution", 
                → "Asynchronous Functions" 
                → allow the "Resources" 
                → of the "Main Thread" 
                → to be "Freed" 
                → for "Other Tasks" 
                → while the "Asynchronous Operations" 
                → are in "Progress". 
            
            
            ♦ This can "Lead" 
                → to more "Efficient Use" 
                → of "Hardware Resources".


        3. "Simplified" and "Easier" to "Understand Code": 
            ♦ Using "Asynchronous Functions" 
                → can "Simplify Code" 
                → by "Eliminating" the "Need" 
                → to "Manually Implement" 
                → "Thread Management" 
                → or "Wait Calls".



    ▬ In "C#", "Asynchronous Functions" 
        → are "Often Implemented" 
        → using the "async" and "await" Keywords. 
        
        
        ♦ When a "Function" 
            → is "Marked" 
            → with the "async" Keyword, 
            → it can Contain "Await Statements" 
            → that allow "Waiting" 
            → for an "Asynchronous Operation" 
            → to "Complete" 
            → "Without Blocking" 
            → the "Main Thread".
    
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace Csharp.functions;

public class AsynchronousFunctions
{
    
    static async Task CookMeat()
    {
        Console.WriteLine("Cooking Meat");
    }
    
    
    static async Task CookVegetables()
    {
        Console.WriteLine("Cooking Vegetables");
    }
    
    
    static async Task MakeBread()
    {
        Console.WriteLine("Making Bread");
    }
    
    
    static async Task MakeSoup()
    {
        Console.WriteLine("Making Soup");
    }
    
    
    static async Task MakeSalad()
    {
        Console.WriteLine("Making Salad");
    }
    
    
    
    static async Task MakeDrinks()
    {
        Console.WriteLine("Making Drinks");
    }
    
    
    
    static async void MakeDinner()
    {
        // ▼ "Call" the "Functions" ▼
        await CookMeat();
        await CookVegetables();
        await MakeBread();
        await MakeSoup();
        await MakeSalad();
        await MakeDrinks();
    }
    
    
    
    public static void RunAsynchronousFunctions()
    {
        // ▼ "Call" the "Function" ▼
        MakeDinner();
    }
}