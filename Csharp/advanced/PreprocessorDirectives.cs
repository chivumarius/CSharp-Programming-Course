/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# ADVANCED" & "COLLECTIONS" •
                    ─────────────────────────────────────
                      • "PREPROCESSOR DIRECTIVES" •

       

    ▬ In C#, "Preprocessor Directives" 
        → are "Special Instructions" 
        → that "Control" 
        → the "Compiler's Behavior" 
        → during "Preprocessing" 
        → of "Source Code". 
        
        
        ♦ These "Directives" 
            → "C" with the "#" Character 
            → and are "Interpreted" 
            → by the "Compiler" 
            → before "Compiling" 
            → the actual "Source Code". 
        
        
    ▬ "Preprocessor Directives" 
        → are "Used" 
        → to "Condition" 
        → the "Compilation" of "Source Code", 
        → to "Include" or "Exclude" 
        → certain "Portions" of "Code"
        → or to "Define Symbols" 
        → that can "Be Used" 
        → at "Compile Time" 
        → to "Enable" or "Disable" 
        → different "Sections" of "Code".

    
    
    ▬ Some "Examples" of Common "Preprocessor Directives" in "C#" include:

        1. "#define" and "#undef":
            ♦ These "Directives" 
                → are "Used" 
                → to "Define" and "Disable" 
                → "Preprocessor Symbols". 
            
            
            ♦ For "Example": 
                    •► "#define DEBUG" 
                → "Defines" the "DEBUG" Symbol 
                → and 
                    •► "#undef DEBUG' 
                → "Disables It".



        2. `#if`, `#elif`, `#else`, `#endif`:
            ♦ These "Directives" 
                → are "Used" 
                → to "Condition" 
                → the "Compilation" 
                → of certain Portions of "Code" 
                → "Based" on the "Value" 
                → of "Preprocessor" Symbols. 
            
            
            ♦ For "Example": 
                    •► "#if DEBUG" 
                → "Checks" if the :DEBUG" Symbol 
                → is "Defined".



        3. "#warning" and "#error": 
            ♦ "#warning" 
                → is "Used" to "Generate" 
                → a "Compile-Time Warning". 
            
            
            ♦ "#error" 
                → is "Used" to "Generate" 
                → a "Compile-Time Error".



        4. "#region" and "#endregion":
            ♦ These "Directives" 
                → are "Used" to "Group" 
                → "Pieces" of "Code" 
                → into "Regions", 
                → to "Make" them "Easier" to "Manage"
                → and "Navigate" in the "Code Editor".



        5. "#pragma": 
            ♦ This "Directive" 
                → is "Used" to "Control" 
                → certain "Aspects" 
                → of the "Compilation", 
                → such as "Specific Warnings" 
                → or "Optimization Level".

    
    
    ▬ "Preprocessor Directives" 
        → are "Powerful Tools" 
        → for "Controlling": 
            •► "Program Compilation" and
            •► "Behavior", 
        → but they must be "Used Carefully" 
        → to | the "Source Code": 
            • "Clean" and
            • "Easy" to "Understand".
    
    
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.advanced;

public class PreprocessorDirectives
{
    
    
    // ▬ "RunPreprocessorDirectives" Method ▬
    public static void RunPreprocessorDirectives()
    {
        // ▼ Adding the "#region" Preprocessor Directive ▼
        // #region         // ◄◄ "Start" of "Preprocessor" ◄◄
        // Console.WriteLine("\nAdding the \"#region\" Preprocessor Directive:");
        // #endregion      // ◄◄ "End" of "Preprocessor" ◄◄
    }
}