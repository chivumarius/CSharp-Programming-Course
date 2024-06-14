/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
                 • "EXPERIMENTAL ATTRIBUTE" •

       


    ▬ "Experimental Attribute" in "C# 12"
        → is "Used" to "Mark Code"
        → that is "Still Experimental",
        → under "Active Development"
        → and "Subject"
        → to "Change".
        
        
    ▬ This "Attribute"
        → helps "Identify Functionality"
        → or "APIs"
        → that are "Not Yet" Considered "Stable"
        → and are "Intended"
        → for "Community Testing"
        → and "Feedback".
        
        
        ♦ It is "Recommended" to be "Used"
            → with "Caution" in Production Code",
            → as these "Functionalities"
            → may Undergo "Significant Changes"
            → in the "Near Future".


    ▬ "See":
     •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12


  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;

//──────────────────────────────────────────────────────────────
// ▬ "ExperimentalAttribute" Class ▬
// Define the custom Experimental attribute
[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class ExperimentalAttribute : Attribute
{
    // ▼ "Property" ▼
    public string Message { get; }

    // ▬ "Constructor" ▬
    public ExperimentalAttribute(string message)
    {
        Message = message;
    }
}

//──────────────────────────────────────────────────────────────
// ▬ "ExperimentalAttribute" Class
//      → that "Demonstrates" the "Use"
//      → of the "Experimental" Attribute ▬
public class ExperimentalAttributeExample
{
    // ▬ "Example()" Method ▬
    [Experimental("This is an Experimental Method.")]
    public static void Example()
    {
        // ▼ Displaying a message to indicate the method is called ▼
        Console.WriteLine("This is an Example of Using the Experimental Attribute.");
    }

    // ▬ "RunExperimentalAttribute()" Method ▬
    public static void RunExperimentalAttribute()
    {
        // ▼ Calling the "Method" ▼
        Example();
    }
}
