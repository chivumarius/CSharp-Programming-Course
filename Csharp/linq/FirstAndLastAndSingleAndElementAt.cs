/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
        • "FIRST()", "LAST()", "SINGLE()", "ELEMENT AT()" METHODS • •

       
       


    ▬ "First()" Method in "LINQ"
        → is "Used" to "Get" 
        → the "First Element" 
        → in a "Sequence" 
        → that "Meets" a "Certain Condition". 
        
        
        ♦ If the "Sequence" 
            → is "Empty" 
            → or there is "No Element" 
            → that "Satisfies" 
            → the "Condition", 
            → it "Throws" an "Exception". 
                
        
        ♦ To "Avoid" this "Exception" 
            →  can be "Used":
                •► "FirstOrDefault()" Method,
            → which "Returns" the "Default Value" 
            → for the "Element's Data Type" 
            → in "Case" of an "Empty Sequence".
        
        
    
    ▬ "Last()" Method in "LINQ"
        → is "Used" to "Get" 
        → the "Last Element" 
        → in a "Sequence" 
        → that "Meets" a "Certain Condition". 
        
        
        ♦ "If" the "Sequence" 
            → is "Empty" 
            → or there is "No Element" 
            → that "Satisfies" 
            → the "Condition", 
            → it "Throws" an "Exception". 
        
        
        ♦ To "Avoid" this "Exception",             
            → can be "Used":
                •► "LastOrDefault()" Method  
            → which "Returns" 
            → the "Default Value" 
            → for the "Element's Data Type" 
            → in "Case" of an "Empty Sequence".
        
        
    
    ▬ "Single()" Method in "LINQ"
        → is "Used" to "Get" 
        → the "Only Element" 
        → in a "Sequence" 
        → that "Meets" 
        → a "Given Condition". 
        
        
        ♦ This "Method" can be "Used" 
            → when the "Sequence" 
            → is "Known" to "Contain" 
            → "Only One Element" 
            → that "Satisfies" the "Condition", 
            → otherwise "It" will "Throw" an "Exception". 
        
        
        ♦ "If" the "Sequence" 
            → is "Empty" 
            → or "Contains" 
            → "More" than "One Element" 
            → "Satisfying" the "Condition"
            → an "Exception" will be "Thrown". 
        
        
        ♦ To "Avoid" this "Exception"
            → can be "Used":
                •► "SingleOrDefault()" Method 
            → which "Returns" the "Default Value" 
            → for the "Element's Data Type" 
            → in "Case" of an "Empty Sequence" 
            → or a "Sequence" 
            → with "More" than "One Element" 
            → "Satisfying" the "Condition".
        
        
        
    
    ▬ "ElementAt()" Method in "LINQ"
        → "Returns" the "Element" 
        → at a "Specific Position" 
        → in a "Sequence", 
        → "Based" on a "Specified Index". 
        
        
        ♦ "It" is "similar" 
            → to "Regular Indexing" 
            → in an "Array" or "List", 
            → but can also be "Used" 
            → for "Other Types" 
            → of "Sequences", 
            → such as the 
            →"Results" of a "LINQ Query" 
            → or "Enumerated Collections".



        ♦ This "Method" is "Useful" 
            → when we "Wants" 
            → to "Access" an "Element" 
            → from a "Specific Position" 
            → in a "Sequence" 
            → and the "Index" is "Known". 
        
        
        ♦ It is "Important" to "Note" 
            → that the "Index" 
            → must be in the "Valid Range" 
            → of the "Sequence", 
            → otherwise, an 
                •► "ArgumentOutOfRangeException" Exception 
            → will be "Thrown".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "FirstAndLastAndSingleAndElementAt" Class ▬
public class FirstAndLastAndSingleAndElementAt
{
    
    // ▬ "RunFirstAndLastAndSingleAndElementAt()" Method ▬
    public static void RunFirstAndLastAndSingleAndElementAt()
    { 
        // ▼ Creating a "List" of "Strings" ▼
        List<string> letters = new List<string> { "a", "b", "c", "d" };
        
        
        //-------------------------- "FIRST()" METHOD --------------------------
        Console.WriteLine("First() Method -> to 'Get' the 'First Element' from the 'List': " + letters.First());
        
        
        //-------------------------- "LAST()" METHOD ---------------------------
        Console.WriteLine("Last() Method -> to 'Get' the 'Last Element' from the 'List': " + letters.Last());
        
        
        //----------------------- "ELEMENTAT()" METHOD -------------------------
        Console.WriteLine("ElementAt() Method -> to 'Get' the 'Element' with 'Index 2' from the 'List': " + letters.ElementAt(2));
        
        
        //------------------------- "SINGLE()" METHOD --------------------------
        Console.WriteLine("Single() Method -> to 'Get' the 'b Element' from the 'List': " + letters.Single(x => x.Equals("b")));
    }
} 