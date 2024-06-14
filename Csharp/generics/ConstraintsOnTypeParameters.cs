/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "GENERICS" •
                        ──────────────
                      ► "CONSTRAINTS" ◄
       



   
    ▬ "Constraints" 
        → are "Rules" or "Restrictions" 
        → "Placed" on "Generic Type Parameters" in "C#" 
        → to Speci"fy the "Data Types" 
        → that can "Be Used" 
        → with those "Parameters". 


        ♦ These "Constraints" 
            → make it "Possible" 
            → to "Set" Certain "Conditions" 
            → regarding the "Types" of "Data" 
            → that can "Be Used", 
            → "Increasing" the "Flexibility" 
            → and "Safety" 
            → of the "Code".


    ▬ By Adding "Constraints", 
        → we can "Limit Type Parameters" 
        → to "Ensure" 
        → that "They" are "Only" 
        → Certain "Data Types", 
        → such as: 
            •► Class Types, 
            •► Interface Types or even 
            •► Value Types. 




    ▬ There are "8 Types "of "Constraints" in "C#":

        1. `where T : class`: 
            ►► This "Constraint" 
                → "Specifies" that the "Type Parameter" `T` 
                → must be a "Reference Class".
           


        2. `where T : struct`: 
            ►► This "Constraint" 
                → "Specifies" that the "Type Parameter" `T` 
                → must be a "Value Type".

        

        3. `where T : new()`: 
            ►► This "Constraint" 
                → "Specifies" that the "Parameter" 
                → of "Type" `T` 
                → must have a "Parameterless Constructor".

        

        4. `where T : SomeClass`: T
            ►► This "Constraint" 
                → "Specifies" that the "Type Parameter" - `T` 
                → must "Be" or "Derive" 
                → from the `SomeClass` Class.

        

        5. `where T : ISomeInterface`: 
            ►► This "Constraint" 
                → "Specifies" that the "Type Parameter" - `T` 
                → must "Implement" the `ISomeInterface` Interface.

        

        6. `where T : unmanaged`: 
            ►► This "Constraint" 
                → "Specifies" that the "Type Parameter" - `T` 
                → must be an "Unmanaged Type".

        

        7. `where T : enum`: 
            ►► This "Constraint" 
                → "Specifies" that the "Parameter" of "Type" - `T` 
                → must be an "Enum".

        

        8. `where T : Delegate`: 
            ►► This "Constraint" 
                → "Specifies" that the "Parameter" 
                → of Type `T` 
                → must be a "Delegate".

            

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.generics;




//─────────────────────────────────────────────────────────────────────────
// ▬ "Example" Class ▬▬
public class Example : IExample2
{
    public string Name { get; set; }
}



// Example2 class that extends Example class
public class Example2 : Example
{
    public int Number { get; set; }
}




//─────────────────────────────────────────────────────────────────────────
// ▬ "IExample2" Interface ▬▬
public interface IExample2
{
    // We define interface methods or properties here
}




//─────────────────────────────────────────────────────────────────────────
// ▬▬ "ConstraintsOnTypeParameters" Class ▬▬
//       ►► with "Constraint" for "Example" Class ◄◄
// public class ConstraintsOnTypeParameters<T>
//      where T : Example
// {
// }



//─────────────────────────────────────────────────────────────────────────
// ▬▬ "ConstraintsOnTypeParameters" Class ▬▬
//       ►► with "Multiple Constraint" with "1 Parameter" for Each "Example" Classes ◄◄
// public class ConstraintsOnTypeParameters<T, U>
//      where T : Example
//      where U : Example
// {
// }



//─────────────────────────────────────────────────────────────────────────
// ▬▬ "ConstraintsOnTypeParameters" Class ▬▬
//       ►► with "Multiple Constraint" to a "Single Parameter" ◄◄
public class ConstraintsOnTypeParameters<T, U>
    where T : Example, IExample2
    where U : Example
{
    private T _objectT;
    private U _objectU;
    
    public ConstraintsOnTypeParameters(T objectT, U objectU)
    {
        _objectT = objectT;
        _objectU = objectU;
    }
    
    // ▬ "PrintValues()" Method ▬
    public void PrintValues()
    {
        Console.WriteLine("Value of ObjectT: " + _objectT.Name);
        Console.WriteLine("Value of ObjectU: " + _objectU.Name);
    }
    
    

    // ▬ "RunConstraintsOnTypeParameters()" Method ▬
    public static void RunConstraintsOnTypeParameters()
    {
        // Creating an instance of Example and Example2
        Example example = new Example { Name = "Example" };
        Example2 example2 = new Example2 { Name = "Example 2", Number = 42 };
    
        // ▼ Creating an "Instance" of "Class" ▼
        ConstraintsOnTypeParameters<Example, Example2> constraintsInstance = new ConstraintsOnTypeParameters<Example, Example2>(example, example2);
    
        
        // ▼ Display "Object Values" ▼
        constraintsInstance.PrintValues();
    }
}