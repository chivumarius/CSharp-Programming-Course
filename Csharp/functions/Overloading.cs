/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                   • "OVERLOADING" •


       

    ▬ "Overloading" in "C#" 
        → is the "Ability" 
        → to Define "Multiple Methods" 
        → with the "Same Name" 
        → in a "Class", 
        → but with "Different Signatures". 
        
        
        ♦ A "Method's Signature" 
            → is "Determined" 
            → by the "Method's Name" 
            → and its "List" of "Parameters", 
            → "Including" their "Types" 
            → and How they are "Passed" 
            → (such as "Value", "Reference", or "Out").


    ▬ When a "Method" 
        → is "Overloaded", 
        → the "Compiler" 
        → can "Distinguish" between these "Methods" 
        → "Based" on their "Signatures" 
        → so that It can "Call" 
        → the "Correct Method" 
        → "Based" on the "Arguments Received" 
        → in a "Specific Method Call".


    ▬ By "Overloading", 
        → we can "Create Methods" 
        → with the "Same Name" 
        → that Provide "Similar Functionality" 
        → but Accept "Different Data Types" 
        → or Different "Number" of "Arguments". 
        
        
        ♦ This "Leads" 
            → to "Greater Flexibility" 
            → in the "Design" 
            → and "Use" of "Classes" 
            → and Methods in "C#".
        
    
    ▬ By "Overloading" 
        → we "Use" the "Concept" 
        → of "Polymorphism", 
        → which means "More" 
        → than "One Form".
        
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace Csharp.functions;

public class Overloading
{

    // ▬ "Base Method" 
    //          → without "Parameters" ▬
    void Example()
    {
    }
            
        
    // ▬ 1- "Overloading" 
    //          → with a "Int Types" ▬
    void Example(int number)
    {
    }
    
    
    // ▬ 2- "Overloading" 
    //          → with "2 Int Types" ▬
    void Example(int number1, int number2)
    {
    }
    
    
    // ▬ 3- "Overloading"
    //          → with "String Types" ▬
    void Example(string word1, string word2)
    {
    }
    
    
    
    
    // ▬ 4- "Overloading"
    //          → by using "Different Types" ▬
    void Example(string word, int number)
    {
    }
    
    
    // ▬ 4- "Overloading"
    //          → by "Changing" the "Order"
    //          → of the "Parameters" ▬
    void Example(int number, string word)
    {
    }
    
}