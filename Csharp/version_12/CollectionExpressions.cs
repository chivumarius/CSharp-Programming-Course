/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
                • "COLLECTION EXPRESSIONS" •

       


    ▬ "Collection Expressions" in "C# 12"
        → are a "New Feature"
        → that allows "Collections"
        → to be "Quickly Initialized"
        → and "Defined"
        → "Directly" in "Code",
        → using a "Concise"
        → and "Expressive Syntax".



        ♦ This "Makes" it "Easier"
            → to "Work" with:
                •► "Lists",
                •► "Dictionaries"
            → and other "Collective Data Structures",
            → "Reducing" the "Amount"
            → of "Code Required"
            → and "Improving Readability".



    ▬ "Inline Arrays" in "C# 12" ("2023")
        → represents a more "Concise"
        → and "Expressive Syntax"
        → for "Initializing Arrays",
        → which "Eliminates" the "Need"
        → to "Explicitly Use" the
        •► "new" Keyword and
        •► "{ }" Brackets.
        
        
    ▬ This "Syntax"
        → "Simplifies" the "Code"
        → and "Makes" it "Easier"
        → to "Read".
    

    ▬ For "Example":
        -----------------------------------------------
          // ▼ "Older Syntax" ▼
          int[] numbers = new int[] { 1, 2, 3, 4, 5 };

          // ▼ "Newest Syntax" ▼
          int[] numbers = [ 1, 2, 3, 4, 5 ];
        -----------------------------------------------



    ▬ "See":
        •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
 
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;

//──────────────────────────────────────────────────────────────
// ▬ "CollectionExpressions" Class ▬
public class CollectionExpressions
{
    // ▬ "RunCollectionExpressions()" Method ▬
    public static void RunCollectionExpressions()
    {
        // ▼ "Array" in "Older Versions" of "C#" ▼
        int[] olderVersionArray = new int[] { 1, 2, 3, 4, 5 };

        // ▼ "Array" with "Collection Expressions" in "C#-12" ▼
        int[] newerVersionArray = [1, 2, 3, 4, 5];

        //----------------------------------------------------------------------
        Console.WriteLine("Collection Expressions in C#-12: ");

        // ▼ "Iterating" the "Array" ▼
        foreach (int i in newerVersionArray)
        {
            Console.Write(i + ", ");
        }

        //----------------------------------------------------------------------
        Console.WriteLine("\nSpread Operator in C#-12: ");

        // ▼ "Array" with "Collection Expressions" in "C#-12" ▼
        int[] newerVersionArray2 = [6, 7, 8, 9, 10];

        // ▼ "Spread Operator" in "C#-12" ▼
        int[] allNumbers = [.. newerVersionArray, .. newerVersionArray2];

        // ▼ "Iterating" the "allNumbers" Array ▼
        foreach (int i in allNumbers)
        {
            Console.Write(i + ", ");
        }
    }
}
