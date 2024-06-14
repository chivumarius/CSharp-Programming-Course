/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
              • "PATTERN MATCHING ENHANCEMENTS" •

       


  ▬ Pattern Matching Enhancements 
    → are "Improvements" 
    → to "Pattern Matching Functionality" in "C#" 
    → "Starting" with "version 9.0". 




  ▬ These "Enhancements" 
    → "Extend" the "Ability" 
    → to "Handle" and "Match" 
      •► "Data Types", 
      •► "Data Constructs", 
    → and other "Complex Structures" 
    → "Expressively" and "Efficiently". 




  ▬ With these "Improvements", 
    → "Developers" can "Write" more "Concise" 
    → and "Understandable Code", 
    → handling "Complex Scenarios" 
    → with more "Precision" 
    → and "Flexibility".

  
  
  ▬ "Improvement" of "Switch" Statement 
      → is an "Improvement" 
      → in "C# 9.0" and "Later",     
      → that "Adds" more "Flexibility" 
      → and "Expressiveness" 
      → to the "Use" of the "Switch" Statement, 
      → allowing "Complex Value Matching" 
      → and "Providing" a more "Concise Syntax" 
      → for "Handling Multiple Cases".

  
  
  
  ▬ The "Main Improvements" to the "Switch" Statement include:

      1. "Complex Type Matching": 
            ♦ The "Switch" Statement 
                → can Now "Match Complex Data Types", 
                → such as: 
                    •► "Type Templates" and 
                    •► "Data Constructs", 
                → "Without" the "Need" 
                → for "Explicit Type Conversion".



      2. "Guard Clauses": 
          ♦ "Additional Conditions" 
            → can be "Specified" 
            → within the "Switch" Statement's "Case Clauses", 
            → allowing more "Precise Matching" 
            → of "Values" 
            → and Handling "Complex Cases" 
            → with more "Flexibility".



      3. "Properties" and "De-Constructors": 
          ♦ "Matching" in the "Switch" Statement 
            → can use "Properties" and "De-Constructors" 
            → to more "Easily Extract" 
            → and "Access Information" 
            → from an "Object".



      4. "Matching Collections": 
          ♦ "Matching Collections" and their "Elements" 
            → can be "Handled" more "Efficiently", 
            → Including "Checking" 
            → for "Presence" or "Extracting Values" 
            → from "Collections".

  
  
  
  ▬ These "Improvements" 
        → "Bring" more "Power" 
        → and "Expressiveness" 
        → to "Using" 
        → the "Switch" Statement in "C#", 
        → "Making" it "Easier" 
        → to Handle "Complex Cases" 
        → and "Write" more "Concise" 
        → and "Understandable Code".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


// ▼ "Enum" → "Type" ▼
public enum Color  
{
    Black,
    White
} 



//──────────────────────────────────────────────────────────────
// ▬ "RBGColor" Class ▬
public class RBGColor
{
    // ▼ "Variables" ▼
    private int red;
    private int green;
    private int blue;

    // ▬ "Constructor"
    //      → that "Initializes Values" ▬
    public RBGColor(int red, int green, int blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
    }

    
    
    // ▬ "ToString()" Overriden Method
    //      → to "Return" a "plain text"
    //      → "Representation" of the "Color" ▬
    public override string ToString()
    {
        return $"RBGColor [Red: {red}, Green: {green}, Blue: {blue}]";
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "PatternMatchingEnhancements" Class ▬
public class PatternMatchingEnhancements
{

    // ▬ "GetRGBColor()" Method ▬
    
    // public static RBGColor GetRGBColor(Color color)
    // {
    //     // ▼ "Switch" Statement  ("Old Syntax") ▼
    //     switch (color)
    //     {
    //         case Color.Black:
    //             return new RBGColor(0, 0, 0);
    //             break;
    //         
    //         case Color.White:
    //             return new RBGColor(255, 255, 255);
    //             break;
    //         
    //         default:
    //             // ▼ "Red" Color ▼
    //             return new RBGColor(255, 0, 0);
    //             break;
    //     }
    // }
    
    // ▼ "New Syntax" → "Switch Statement" ▼
    public static RBGColor GetRGBColor(Color color) 
        => color switch {
        // [case] => [value], ...
        Color.Black => new RBGColor(0, 0, 0),
        Color.White => new RBGColor(255, 255, 255),
        // ▼ "Default Case" [_] => [value] ▼
        _ => new RBGColor(255, 0, 0) 
    };


    // ▬ "RunPatternMatchingEnhancements()" Method ▬
    public static void RunPatternMatchingEnhancements()
    {
        // Call GetRGBColor method
        RBGColor black = GetRGBColor(Color.Black);
        RBGColor white = GetRGBColor(Color.White);
        RBGColor red = GetRGBColor((Color)10); // This will use default case
        Console.WriteLine("Black color: " + black.ToString());
        Console.WriteLine("White color: " + white.ToString());
        Console.WriteLine("Red color: " + red.ToString());
    }
} 