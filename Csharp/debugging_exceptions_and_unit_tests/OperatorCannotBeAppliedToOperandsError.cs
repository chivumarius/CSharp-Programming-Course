/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
             • "OPERATOR ... CANNOT BE APPLIED TO OPERAND" ERROR •

       


    ▬ "OperatorCannotBeAppliedToOperands" Error
        ♦ "Occurs" when:
            • "Cannot" 
                → be "Applied" 
                → to "Operands" of "Type".
        
            • The "Operator" 
                → you are "Using" 
                → can't be "Used" 
                → with the "Types" of "Variables" 
                → you are "Using It On".


    ▬ Possible "Causes":
        1- Using "==" 
            → on "Two Different Types" of "Variables"
        
        2- "Trying" to "Add", "Subtract", "Multiply" or "Divide" 
            → "Two Different Types" 
            → that are "Incompatible".
            
        3- "Trying" to "Compare Types" 
            → "Instead" of "Values".
            
        4- Using a "Logical Operator" 
            → on "Things" 
            → that are "Not Booleans".


    ▬ "Possible Fixes":
        1- "Check"  
            → that "Values" being "Compared" 
            → are of the S"ame Type". 
        
        2- "Look" 
            → at what "Operator" 
            → is "Listed" in the "Error".
        
        3- "Make Sure" 
            → you are "Comparing Values"/ "Variables" 
            → and "Not Types".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "OperatorCannotBeAppliedToOperandsError" Class ▬
public class OperatorCannotBeAppliedToOperandsError
{
    
    // ▬ "RunOperatorCannotBeAppliedToOperandsError()" Method ▬
    public static void RunOperatorCannotBeAppliedToOperandsError()
    {
        // ▼ "Correct Comparison" ▼
        if('a' == 'a') { }
        
        
        // ▼ "Comparison" between a "Char" and an "Sting" Types"
        //      → "Give" an "Operator Cannot Be Applied To Operands" Error ▼
        // if('a' == "a") { }
    }
} 