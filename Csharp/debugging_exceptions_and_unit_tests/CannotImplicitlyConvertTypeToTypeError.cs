/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DEBUGGING EXCEPTIONS" & "UNIT TESTS" •
                    ─────────────────────────────────────────
            • "CANNOT IMPLICITLY CONVERT TYPE ... TO A TYPE ..." ERROR •

       




    ▬ "Cannot Implicitly Convert Type ... ToType .." Error
        → "Occurs" when
        → we are "Not Explicitly Converting" 
        → to a "Type" 
        → ("Not" a "Type Safe Conversion").



    ▬ Possible "Causes":
        
        1- "Trying" to "Convert" 
            → a "Less Specific Type" 
            → to a "More Specific Type"
            → "Without Casting".
        

        2- "Trying" to "Implicitly Convert" 
            → the "Object Type" 
            → to a "More Specific Type". 


        3- "Setting" 
            → a "Non-Nullable Variable" 
            → as "Null".




    ▬ "Possible Fixes":
        
        1- "See If" 
            → you can "Explicitly Convert" 
            → the "Variable".
        

        2- "Convert" 
            → "Object Base Class" 
            → to a "Specific Type" 
            → (using "object.ToString()")
        

        3- "Add" a "Question Mark" 
            → to the "End" 
            → of the "Type" 
            → to "Make It" 
            → a "Nullable Type".
     

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.debugging_exceptions_and_unit_tests;



//──────────────────────────────────────────────────────────────
// ▬ "Ex1" Class ▬
public class Ex1 { }



//──────────────────────────────────────────────────────────────
// ▬ "Ex2" Class ▬
public class Ex2 : Ex1 { }



//──────────────────────────────────────────────────────────────
// ▬ "CannotImplicitlyConvertTypeToTypeError" Class ▬
public class CannotImplicitlyConvertTypeToTypeError
{
    
    // ▬ "RunCannotImplicitlyConvertTypeToTypeError()" Method ▬
    public static void RunCannotImplicitlyConvertTypeToTypeError()
    {
        // ▼ Creating "Objects/Instances" ▼
        Ex1 ex1 = new Ex1();
        Ex2 ex2 = new Ex2();
      
        // ▼ "Getting" - "Cannot Implicitly Convert Type ... To Type ..." Error ▼
        // ex2 = ex1;
        
        
        // ▼ "Error Fixed" ▼
        // ex2 = (Ex2) ex1;
        
    }
} 