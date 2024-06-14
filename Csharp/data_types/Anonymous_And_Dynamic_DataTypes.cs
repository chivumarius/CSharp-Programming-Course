namespace CSharp.data_types;

public class Anonymous_And_Dynamic_DataTypes
{
    // ▼ "Global Variables" ▼
    
    
    public static void AnonymousAndDynamicDataTypes()
    {
        // (1) "Anonymous Data Type" Variable ("var")
        //      → Can be "Declared" Only Locally,
        //      → inside of a "Method".
        
        //   ♦ "var" is a Keyword
        //      → used to "Declare Variables"
        //      → with "Default Type" ♦
        
        //   ♦ When you Use "var",
        //      → the "Compiler Determines"
        //      → the "Type" of the "Variable"
        //      → based on the "Initial Value Assigned"
        //      → to the "Variable" ♦
        var a = 5;
        Console.WriteLine("Anonymous Variable: " + a);
        
        
        // (2) "Dynamic Data Type" Variable ("dynamic")
        //      → Can be "Declared" Only Locally,
        //      → inside of a "Method".
        //   ♦ "dynamic"
        //      → allows a "Variable"
        //      → to be "Re-Evaluated"
        //      → During "RunTime".

        //   ♦ When you Use "dynamic",
        //      → the "Type" of the "Variable"
        //      → is "Resolved" at "RunTime",
        //      → which means that you can "Perform Operations"
        //      → on the "Dynamic Variable"
        //      → "Without Checking" the "Type"
        //      → at "Compile Time".
        dynamic b = 25;
        Console.WriteLine("Dynamic Variable: " + b);
    }
} 