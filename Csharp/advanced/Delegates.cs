/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# ADVANCED" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "DELEGATES" •

       

    ▬ In C#, "Delegates" 
        → are "Specialized Data Types" 
        → (or "Special Type" of "Variable")
        → that allow "Functions" 
        → to be "Defined" and "Used" 
        → as "Parameters" 
        → to "Other Functions". 
        
        
        ♦ "They" 
            → are a "Reference" Type 
            → to a "Request". 
        
        
        ♦ The "Delegate" 
            → "Defines" the "Signature" 
            → of the "Method" it can "Refer" 
            → to allowing "Programmers" 
            → to "Pass Methods" 
            → as "Arguments" 
            → to "Other Functions".

    ▬ In other words "Delegates" 
        → are "Special Type" 
        → of "Variable"
        → "Used" to "Store"
        → a "Method" or "Function".
        
    
    ▬ The "Syntax" for "Declaring" a "Delegate":
       ──────────────────────────────────────────────────────── 
            delegate returnType DelegateName(parameters);
       ──────────────────────────────────────────────────────── 

        • "returnType": 
            → The "Data Type" 
            → of the "Value Returned" 
            → by the "Method" 
            → "Associated" with the "Delegate".
        
        
        • "DelegateName": 
            → "Name" of the "Delegate".
        
        • "parameters": 
            → The "List" of "Parameters" 
            2♠ that the "Method Associated" 
            → with the "Delegate" Accepts.

                
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// using CSharp.advanced;

namespace CSharp.advanced;

public class Delegates
{
    
    // ▼ "Creating" a "Delegate" Variable ▼
    delegate void Print();
    
    
    
    // ▬ "HelloWorld()" Method ▬
    static void HelloWorld()
    {
        Console.WriteLine("Hello World, using Delegates!");
    }
    
    
    
    
    // ▬ "GoodbyeWorld()" Method ▬
    static void GoodbyeWorld()
    {
        Console.WriteLine("Goodbye World, using Delegates!");
    }
    
    
    
    
    // ▬ "RunDelegates()" Method ▬
    public static void RunDelegates()
    {
        //---------------------------------------------------------
        // ▼ "Instantiating" the "Delegate" Variable ▼
        Print helloWorld1 = HelloWorld;
        
        Console.WriteLine("\n Instantiating the Delegate Variable for HelloWorld Method : ");

        // ▼ "Calling" the "Delegate" Variable ▼
        helloWorld1();
        
        
        
        
        //---------------------------------------------------------
        // ▼ "Instantiating" the "Delegate" Variable
        //      → but for "Goodbye World" ▼
        Print helloWorld2 = GoodbyeWorld;
        
        Console.WriteLine("\n Instantiating the Delegate Variable,  but for GoodbyeWorld Method : ");

        // ▼ "Calling" the "Delegate" Variable ▼
        helloWorld2();


        
    
        //---------------------------------------------------------
        // ▼ Creating a "Multi-Cast  Delegate"
        //    → to Access "Multiple Functions" ▼
        Print print = null;
        
        
        // ▼ Adding "Functions" to the "Multi-Cast Delegate" ▼
        print += HelloWorld;
        print += GoodbyeWorld;
        
        Console.WriteLine("\n Multi-Cast Delegate to Access Multiple Functions: ");
        
        // ▼ Calling the "Multi-Cast Delegate" ▼
        print();

    }
}