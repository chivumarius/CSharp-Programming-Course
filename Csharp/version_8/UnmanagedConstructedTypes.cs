/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
              • "UNMANAGED CONSTRUCTED TYPES" •

       


  ▬ "Unmanaged constructed Types" 
        → is a "C# Concept" 
        → that "Refers" to ""Generic Types"" 
        → "Constructed" 
        → "Using" the "Keyword":
            •► "unmanaged". 
                
        
        ♦ When "Defining" 
            → a "Generic Type" 
            → "Using" the 
                •► "unmanaged" Keyword, 
            → a "Restriction" 
            → is "Imposed" 
            → on the "Generic Type", 
            → "Requiring It" to be 
            → an "Unmanaged Type".



  ▬ An "Unmanaged Type" 
        → is a Data Type 
        → that does "Not Require" 
        → "Automatic Memory Management" 
        → by the "Garbage Collector". 
        
        
        ♦ These "Types" 
            → are often "Primitives" 
            → or "Simple Structures" 
            → that are "Handled Directly" 
            → in "Managed Memory".



  ▬ "Applying" 
        → the "unmanaged" Constraint 
        → to a "Generic Type" 
        → "Guarantees" 
        → that "Any Instance" 
        → of the "Generic Type" used
        → will "Respect" these "Conditions" 
        → and be an "Unmanaged Data Type". 
    
        ♦ This "Restriction" 
            → is "Especially Useful" 
            → when "Working" 
            → with "Native Code Interoperability "
            → or when we "Want" 
            → to "Ensure" 
            → that the "Types Used" 
            → are "Memory Efficient" 
            → and do "Not Require" 
                •► "Garbage Collection".

  
    ▬ "Unmanaged Data  Types"
        1- sbyte, 
        2- byte, 
        3- short, 
        4- ushort, 
        5- int, 
        6- uint, 
        7- long, 
        8- ulong, 
        9- char, 
        10- float, 
        11- double, 
        12- decimal, 
        13- bool,
        14- pointer,
        15- enum.
     
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "MyStruct" Structure
//      → as "Unmanaged Constructed Types" ▬
public struct MyStruct<T> where T : unmanaged
{
    public T field;
}




//──────────────────────────────────────────────────────────────
// ▬ "UnmanagedConstructedTypes" Class ▬
public class UnmanagedConstructedTypes
{
    // ▬ "RunUnmanagedConstructedTypes()" Method ▬
    public static void RunUnmanagedConstructedTypes()
    {
        // ▼ "Creating" an "Instance" of "int" Type ▼
        MyStruct<int> myStructInt = new MyStruct<int>();
        
        // ▼ "Accessing" the "Field"
        myStructInt.field = 10;
        
        // ▼ "Printing" the "Value" ▼
        Console.WriteLine($"Value of field in MyStruct<int>: {myStructInt.field}");

        
        
        // ▼ "Creating" an "Instance" of "double" Type ▼
        MyStruct<double> myStructDouble = new MyStruct<double>();
        
        // ▼ "Accessing" the "Field" ▼
        myStructDouble.field = 3.14;
       
        // ▼ "Accessing" the "Field" ▼
        Console.WriteLine($"Value of Field in MyStruct<double>: {myStructDouble.field}");
    }
} 