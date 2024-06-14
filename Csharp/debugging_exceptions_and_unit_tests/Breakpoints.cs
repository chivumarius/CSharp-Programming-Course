/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
                             • "BREAKPOINTS" •

       


    ▬ A "Breakpoint" in "C#"
        → is a "Marker" 
        → "Placed Only" 
        → on a "Executable Line" of "Code" 
        → in a "Development Environment" 
        → that "Stops Program Execution" 
        → at that "Line". 


        ♦ This "Allows" the "Developer" 
            → to "Inspect" the "State" of the "Program" 
            → and "Trace" the "Execution Flow" 
            → for "Debugging" 
            → and "Better Understanding" 
            → of "Its Operation".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "Breakpoints" Class ▬
public class Breakpoints
{
    // ▼ "Variable" ▼
    static int count = 0; 
    
    
    
    // ▬ "ExMethod1()" Method ▬
    public static void ExMethod1()
    {
        count++;
    }
    
    
    
    // ▬ "ExMethod2()" Method ▬
    public static void ExMethod2()
    {
        for(int i = 0; i < 4; i++)
        {
            count += i;
        }
    }
    
    
    
    
    // ▬ "RunBreakpoints()" Method ▬
    public static void RunBreakpoints()
    {
        // ▼ "Instructions" ▼   
        // int count = 0; 
        // count++;
        // Console.Write(count);
        
        
        // ▼ "Calling" the "Methods" ▼
        ExMethod1();
        ExMethod2();
    } 
} 