namespace CSharp.interfaces_and_abstract_classes.interfaces;


// ▬▬ "IEquatable" Interface
//      → "Defines" a "Generalized Method"
//      → that a "Value Type" or "Class" → "Implements"
//      → to "Create" a "Type-Specific Method"
//      → for Determining "Equality"
//      → of "Instances"/"Objects" ▬
public class EquatableClass : IEquatable<EquatableClass>
{
    // ▼ "Variable" ▼
    public string dataExample;
    
    
    
    // ▬ "Equals()" Member Interface Method ▬
    public bool Equals(EquatableClass? other)
    {
        if(other == null)
            return false;
        
        return dataExample.GetHashCode()
            .Equals(other.dataExample.GetHashCode());
    }
    
    
    
    
    
    // ▬ "Run Equatable()" Method ▬
    public static void RunEquatable()
    {
        // ▼ Creating "2 Instances" of the "EquatableClass" Class ▼
        EquatableClass instance1 = new EquatableClass { dataExample = "Marius" };
        EquatableClass instance2 = new EquatableClass { dataExample = "Marius" };

        // ▼ "Checking" the "Equality"
        //      → between the "2 Instances"
        //      → using the "Equals()" Method ▼
        bool areEqual = instance1.Equals(instance2);

        
        // ▼ "Displaying" the "Result" ▼
        if (areEqual)
        {
            Console.WriteLine("The 2 Instances are Equal.");
        }
        else
        {
            Console.WriteLine("The 2 Instances are Not Equal.");
        } 
    }
}