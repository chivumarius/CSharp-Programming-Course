/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
             • "REFERENCE READONLY PARAMETERS" •

       


    ▬ "Ref Readonly Parameters" in "C# 12",
        → allows the "Parameters" of a "Method"
        → to be "Specified" as "Both":
            •► "ref" ("Reference") and
            •► "readonly" ("Read-Only").
    
    
    
    ▬ This "Combination"
        → allows a "Parameter"
        → to be "Treated"
        → as a "Reference"
        → to the "Original Value"
        → of the "Variable"
        → in the "Caller"
        → and at the "Same Time"
        → "Indicates" that the "Method"
        → will "Not Change"
        → the "Value"
        → of this "Reference".
    
    
    
    ▬ It is "Useful"
        → to "Ensure" that a "Method"
        → will "Not Accidentally Change"
        → the "Value" of a "Variable"
        → in the "Caller".



    ▬ "See":
        •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;

//──────────────────────────────────────────────────────────────
// ▬ "RefReadonlyParameters" Class ▬
public class RefReadonlyParameters
{
    // ▼ "Struct" ▼
    public struct ExampleStruct { }

    // ▬ "ForceByRef()" Method
    //      → that "Takes" a "Ref Readonly Parameter"
    //      → and "Demonstrates" its "Usage" ▬
    public static void ForceByRef(ref readonly ExampleStruct example)
    {
        Console.WriteLine("The Method was Called with a Readonly Reference Parameter.");
    }

    // ▬ "RunRefReadonlyParameters()" Method ▬
    public static void RunRefReadonlyParameters()
    {
        // ▼ "Initialize" an "Instance" of the "Structure" ▼
        ExampleStruct example = new ExampleStruct();

        // ▼ "Call" the "Method" with the "Structure Parameter"
        ForceByRef(ref example);
    }
}
