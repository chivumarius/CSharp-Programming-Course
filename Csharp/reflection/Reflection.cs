/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "REFLECTION" •
                    ────────────────
              • VIEWING "TYPE  INFORMATION" •

       


    ▬ "When" 
        → we "Look" in a "Mirror", 
        → we See "Our Reflection"


        ♦ "Reflections" 
            → allow "Us" 
            → to "See Ourselves"




    ▬ "Computer Programming" 
        → also "Recognizes" 
        → the "Concept" 
        → of "Reflection".




    ▬ "Reflection" 
        → is when "Code" 
        → can "Read" its "Own Metadata",
        → it allows the "Code" 
        → to "Inspect Other Code".

    
        ♦ Ex.: "IntelliSense" in "Visual Studio".



    ▬ The "Code" 
        → uses "Metadata" 
        → to "Change" Its "Behavior" 
        → or "Inform" the "User".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
using System.Reflection;


namespace CSharp.reflection;


//──────────────────────────────────────────────────────────────
// ▬ "Reflection" Class ▬
public class Reflection
{
    
    // ▬ "RunReflection()" Method ▬
    public static void RunReflection()
    {
        Console.WriteLine("\n" + "******************** \"REFLECTION\" & \"METADATA\"    ********************");

       
        // ▼ Creating "Type" Object
        //      → to "Get" a "Type Information"
        //      → about "Any Object" ▼
        Type typeObject = typeof(int);
        
        
        //---------------------------------------------------------------
        // (1) ▼ "Member Info" Message ▼
        Console.WriteLine("\nGetting 'All Member Info' of 'int' Class: ");
        
        // ▼ "Creating" an "Array" of "Member Info" Object
        //  → to "Get" the "Members" ▼
        MemberInfo[] memberInfoArray = typeObject.GetMembers();
        
        // ▼ "Iterating" over "Each Member Info" of "Array" ▼
        foreach (MemberInfo memberInfo in memberInfoArray)
        {
            Console.WriteLine(" * Member: " + memberInfo);
        }
        
        
        
        //---------------------------------------------------------------
        // (2) ▼ "Field Info" Message ▼
        Console.WriteLine("\nField Info: ");

        // ▼ "Creating" an "Array" of "Field Info" Object
        //      → to "Get" the "Fields" ▼
        FieldInfo[] fieldInfoArray = typeObject.GetFields();
        
        // ▼ "Iterating" over "Each Field Info" of "Array" ▼
        foreach (FieldInfo fieldInfo in fieldInfoArray)
        {
            Console.WriteLine(" * Field: " + fieldInfo);
        }
        
        
        
        //---------------------------------------------------------------
        // (3) ▼ "Method Info" Message ▼
        Console.WriteLine("\nMethod Info: ");
        
        // ▼ "Creating" an "Array" of "Method Info" Object
        //      → to "Get" the "Methods" ▼
        MethodInfo[] methodInfoArray = typeObject.GetMethods();
        
        // ▼ "Iterating" over "Each Method Info" of "Array" ▼
        foreach (MethodInfo methodInfo in methodInfoArray)
        {
            Console.WriteLine(" * Method: " + methodInfo);
        }

    }
} 