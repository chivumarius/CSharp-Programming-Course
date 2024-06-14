/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
                         • ";/,/]/} EXPECTED" ERROR •

       


    ▬ "Symbol Expected" Error 
        → Occurs when you are "Missing"
        → a "Symbol", 
        → that "Closes"
        → "One" of your "Programming Constructors".


    ▬ Possible "Causes":
        1- Missing "Closing Bracket" or "Parenthesis"
        2- Missing a "Semicolon" 
        3- "Mismatched Bracket".



    ▬ "Fixing" the "Problem":
        • By "Line Up Code Brackets" 
        • By "Check" that "Lines End" with "Semicolons". 

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "SymbolExpectedError" Class ▬
public class SymbolExpectedError
{ 
    // ▬ "StartMethod()" Method ▬
    public static void StartMethod()
    {
    }
    
    
    // ▬ "RunSymbolExpectedError()" Method ▬
    public static void RunSymbolExpectedError()
    {
        // ▼ "Calling" the "Method" ▼
        StartMethod();  // ◄◄ "Correct Method Call" ◄◄
        
        // StartMethod()  // ◄◄ "Getting" the "Expected Error" ◄◄
    }
} 