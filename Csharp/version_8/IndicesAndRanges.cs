/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
             • "INDICES"/"INDEXES" & "RANGES" •

       


  ▬ "Indices" and "Ranges" in "C#", 
        → are "Two Features" 
        → introduced with "Version 8.0". 
        
        
        ♦ They "Facilitate"
            → "Access" to "Elements" 
            → in: 
                •► "Strings" and 
                •► Collections" 
            → using "Compact" 
            → and "Expressive syntax".

    
    
    (1) "Index":
        ♦ An "Index" 
            → is a "Structure" 
            → that "Represents" 
            → the "Position" 
            → of an "Element" 
            → in a "Collection".
        
        
        ♦ The "^" Syntax 
            → is "Used" to "Indicate" 
            → an "Inverse" or "Relative Index" 
            → at the "End" of the "Collection". 
        
        
            ♦ For Example, 
                •► ^0 
                    → represents the "Last Element", 
                •► ^1 
                    → represents the "Penultimate Element", 
                    → and so on.
        
        
        ♦ "Indexes" 
            → are "Used" to "Access Elements" 
            → in a "Specific Direction" 
            → of a "Collection", 
            → whether "Accessing Elements" 
            → "Starting" from the "Beginning" 
            → (using a Regular "Index") 
            → or "Starting" from the "End" 
            → (using a "Inverse Index").

    
    
    2. "Ranges":
        ♦ A "Range" 
            → is a "Structure" 
            → that "Defines" 
            → a "Range" of "Elements" 
            → in a "Collection".
        
        
        ♦ The "Syntax" 
            → for a "Range" is 
                •► "start..end", 
            → where "start" and "end" 
            → are "Indices" 
            → "Delimiting" the "Range". 
        
        
        ♦ This "Range" 
            → "Includes" the "Element" 
            → at Index "start", 
            → but not the "Element" 
            → at Index "end".
        
        
        ♦ "Ranges" 
            → are "Used" 
            → to "Extract" a
            →  "Sequence" of "Elements" 
            → from a "Collection", 
            → "Defining" the "Start" and "End" 
            → of the "Desired Range".

    
    
    ▬ These "Features" are "Useful" 
        → for "Working" with 
            •► "Strings", 
            •► "Lists", 
        → and "Other Collections", 
        → allowing "Easy Access" 
        → to "Their Elements" 
        → using a "Clear" 
        → and "Concise Syntax".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "IndicesAndRanges" Class ▬
public class IndicesAndRanges
{
    // ▬ "RunIndicesAndRanges()" Method ▬
    public static void RunIndicesAndRanges()
    {
        //♦♦♦   "Indices"   ♦♦♦
        // ▼ "List" of "Strings" ▼
        List<string> letters = new List<string>() { "a", "b", "c", "d", "e" };
        
        Console.WriteLine("Indices - the 'Last Letter' ([^1]) is: " + letters[^1]);
        Console.WriteLine("Indices - the 'Penultimate Letter' ([^2]) is: " + letters[^2]);
        
        
        Console.WriteLine();
        
        
        //♦♦♦   "Ranges"   ♦♦♦
        // ▼ "String Array" ▼
        string[] words = { "Hello", "Hi", "Hi there", "Hey", "Bye bye", "Goodbye" };
        
        // ▼ "Variable" of "Words" ▼
        var range1 = words[0..^3];
        var range2 = words[3..^0];
        
        Console.WriteLine("Ranges - the 'First 3 Words' ([0..^3]) are: " + string.Join(", ", range1));
        Console.WriteLine("Ranges - the 'Last 3 Words' ([3..^0]) are: " + string.Join(", ", range2));
    }
} 