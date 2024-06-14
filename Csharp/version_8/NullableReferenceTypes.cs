/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
                • "NULLABLE REFERENCE TYPES" •

       


  ▬ "Nullable" Reference Types in "C#" 
      → allow "Programmers" 
      → to "Clearly Specify" 
      → when a "Reference Variable" 
      → "Can" and "Cannot" 
      → be "Null". 



  ▬ This "Functionality" 
      → is "Enabled" in "Code" 
      → by "Appending" the 
        •► "?" Character 
      → to the "End" 
      → of the "Type" 
      → to "Indicate" 
      ► a "Nullable" Reference. 



  ▬ "Before" 
      → this "Functionality" was "Enabled",
        •► "Reference Type Variables" 
      → "Could" be "Null" 
      → by "Default", 
      → which "Could Lead" to
        •► "Null Reference Errors" 
      → while "Running Programs". 



  ▬ With "Null" Reference Ttypes "Enabled", 
      → the "Compiler" can more "Explicitly Check" 
      → and "Issue Compile-Time Warnings" 
      → or "Errors" 
      → for "Invalid Use" 
      → of "Null References". 



  ▬ This 
      → Makes "Code Safer" 
      → and "Easier" 
      → to "Understand", 
      → "Avoiding" many "Common Errors" 
      → "Associated" with "Null References".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "Version8" Class ▬
public class NullableReferenceTypes
{
    // ▬ "RunNullableReferenceTypes()" Method ▬
    public static void RunNullableReferenceTypes()
    {
        // ▼ "Nullable" Reference Types "Enabled" ▼
        string? username = null;

        // ▼ "Check" if "Username" is "Null"
        //      → "Before Accessing" its "Length" ▼
        if (username != null)
        {
            Console.WriteLine($"Username: {username}");
            Console.WriteLine($"Username Length: {username.Length}");
        }
        else
        {
            Console.WriteLine("Username is Null");
        }

        // ▼ "Set Username" to a "Non-Null Value" ▼
        username = "MariusChivu";

        // ▼ "Access" the "Length" of "Username"
        //      → without "Additional Checks" ▼
        Console.WriteLine($"Username: {username}");
        Console.WriteLine($"Username length: {username.Length}");
    }
} 