/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
        • "TRY{}", "CATCH{}", "FINALLY{}" BLOCKS &  "THROW  ERROR MESSAGE" •

       


    ▬ "They" are "Used" 
        →to "Handle Errors" 
        → in the "Code".

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;


//──────────────────────────────────────────────────────────────
// ▬ "TryCatchFinallyBlocksAndThrowErrorMessage" Class ▬
public class TryCatchFinallyBlocksAndThrowErrorMessage
{
    // ▬ "ThrowError()" Method ▬
    public static void ThrowError(object obj)
    {
        if(obj == null)
        {
            // ▼ "Throw Error Message" ▼
            throw new NullReferenceException("Object is null!");
        }
    }
    
    
    
    // ▬ "RunTryCatchFinallyBlocksAndThrowErrorMessage()" Method ▬
    public static void RunTryCatchFinallyBlocksAndThrowErrorMessage()
    {
        // ▼ "Blocks" ▼
        try
        {
            // "Risky Code" goes "Here".
        }
        catch (NullReferenceException e)
        {
            // "Code" to "Handle"
            //  → the "Null Reference Exception"
            //  → goes "Here".
        }
        catch (IndexOutOfRangeException e)
        {
            // "Code" to "Handle"
            //  → the "Index Out Of Range Exception"
            //  → goes "Here".
        }
        finally
        {
            // "Code" to "Execute"
        }
    }
} 