/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "REFLECTION" •
                    ────────────────
            • "REFLECTIONS" WITH "GENERIC TYPES" •

       

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.reflection;


//──────────────────────────────────────────────────────────────
// ▬ "Reflection" Class ▬
public class ReflectionWithGenericTypes
{
    
    // ▬ "RunReflectionWithGenericTypes()" Method ▬
    public static void RunReflectionWithGenericTypes()
    {
        Console.WriteLine("\n──────────────────── \"REFLECTIONS\" WITH \"GENERIC TYPES\"────────────────────");


        // (1) ▼ "Check" if "String" is a "Generic Type" ▼
        Console.WriteLine("Is 'String' a 'Generic Type': " + typeof(string).IsGenericType); // ◄ "False" ◄
        
        // (2) ▼ "Check" if "List" is a "Generic Type" ▼
        Console.WriteLine("Is 'List' a 'Generic Type': " + typeof(List<int>).IsGenericType); // ◄ "True" ◄

        
        // ♦♦♦ "Reflection" with "Generic Types" ♦♦♦
        
        // ▼ Creating "Type" Object
        //      → to "Find" the "Type"
        //      → of "Dictionary<>" ▼
        Type typeObj = typeof(Dictionary<,>);
        
        if(typeObj.IsGenericType)
        {
            // ▼ "Get" the "Generic Arguments"
            //      → of the "Dictionary<>" Type ▼
            Type[] typeParametrers = typeObj.GetGenericArguments();
            
            // ▼ "Print" the "Type Parameters" ▼
            Console.WriteLine("\nNumber of Type Parameters = {0}", typeParametrers.Length);
            
            foreach (Type typeParameter in typeParametrers)
            {
                if(typeParameter.IsGenericType)
                {
                    Console.WriteLine("Generic Type = {0}", typeParameter);
                }
                else
                {
                    Console.WriteLine("Type = {0}", typeParameter);
                }
            }
        }

    }
} 