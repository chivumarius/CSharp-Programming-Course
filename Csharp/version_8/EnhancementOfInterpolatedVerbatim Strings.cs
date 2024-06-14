/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
        • "ENHANCEMENT" OF "INTERPOLATED VERBATIM STRINGS" •

       


  ▬ "Enhancement" of "Interpolated Verbatim Strings" 
        → is a "Feature" 
        → "Added" in "C#" 
        → to "Improve" and "Extend" 
        → the "Functionality" 
        → of "Interpolated Verbatim Strings".



  ▬ "Before" this "Enhancement", 
        → "Verbatim String Interpolation" in "C#" 
        → "Could Only" be "Done" 
        → by "Placing" the 
            •► "$" Symbol 
        → in "Front" of a "Verbatim String" 
        → and then "Placing" the 
            •► "@" Symbol 
        → in "Front" 
        → of the "String" 
        → to "Indicate" that "It" 
        → is a "Verbatim String". 
        
        
        ♦ This "Approach" 
            → did "Not Allow Verbatim Interpolation Strings" 
            → to be "Inserted" 
            → "Inside" other "Verbatim Interpolation Strings".



  ▬ With the "Enhancement", 
        → it is "Now Possible" 
        → to use "Verbatim Interpolation Strings" 
        → "Inside" other "Verbatim Interpolation Strings". 
        
        
        ♦ This "Gives Programmers" 
            → more "Flexibility" 
            → and "Makes" It "Easier" 
            → to "Handle" 
            → "Complex Strings" 
            → that "Require Interpolation" 
            → and "Advanced Formatting".

  
  ▬ A "Verbatim String" in "C#" 
        → is a "Special Type" 
        → of "Character String" 
        → that "Allows" the "Inclusion" 
        → of "Special Characters" 
        → without "Needing" 
            •► "Escaping Sequences". 
        
        ♦ This "Means" 
            → that in a "Verbatim String", 
            → "Characters" like: 
                •► "\n" or 
                •► "\t" 
            → are "Treated Literally" 
            → rather than as "Escape Sequences". 
        
        
        ♦ A "Verbatim String" 
            → "Starts" with the 
                •► "@" Symbol 
            → "Before" the "String" 
            → and is "Useful" in "Situations" 
            → where we "Need" to "Include" 
            → "Special Characters", such as 
                •► "File Paths" or 
                •► Regular Expressions". 
            
            
            ♦ For "Example": 
                    •► @"C:\Users" 
                → is a "Verbatim String" 
                → representing the "File Path". 
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "EnhancementOfInterpolatedVerbatimStrings" Class ▬
public class EnhancementOfInterpolatedVerbatimStrings
{
    // ▬ "RunEnhancementOfInterpolatedVerbatimStrings()" Method ▬
    public static void RunEnhancementOfInterpolatedVerbatimStrings()
    {
        // ▼ "Verbatim Strings" ▼
        string s1 = $@"C:\User\Marius1\";
        string s2 = @$"C:\User\Marius2\";
       
        // ▼ "Print" ▼
        Console.WriteLine("Verbatim String ('$@'): " + s1);
        Console.WriteLine("Verbatim String ('@$'): " + s2);
        
    }
} 