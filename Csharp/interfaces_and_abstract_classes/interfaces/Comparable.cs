namespace CSharp.interfaces_and_abstract_classes.interfaces;


// ▬▬ The "Comparable" Interface
//      → Defines a Generalized Type-Specific Comparison Method
//      → that a "Value Type" or "Class" 
//      → Implements to "Order"
//      → or "Sort"
//      → its "Instances"/ "Objects" ▬▬
public class Comparable : IComparable
{
    
    /// Field to hold the length
    public int Length;

    
    
    
    // ▬ "Implementation" of the "CompareTo()" Member Method
    //      → from the "IComparable" Interface ▬
    public int CompareTo(object? obj)
    {
        // ▼ "Check": If the "Object" is "Null" or "Not"
        //      → of "Comparable" Type ▼
        if (obj == null || !(obj is Comparable))
        {
            // ▼ "Throw" an "Exception"
            //      → if the "Object"
            //      → is "Not" a "Comparable" ▼
            throw new ArgumentException("Object is not a Comparable");
        }

        // ▼ : the "Object" → to "Comparable" Type ▼
        Comparable other = (Comparable)obj;

        // ▼ "Compare" the "Lengths"
        //      → of the "2 Comparable" Objects ▼
        if (Length == other.Length)
        {
            // ▼ Return "0" → If the "Lengths" are "Equal" ▼
            return 0;
        }
        else if (Length > other.Length)
        {
            // ▼ Return "1": If the "Length" of the "Current" Object
            //      → is "Greater" than the "Other" Object ▼
            return 1;
        }
        else
        {
            // ▼ Return "-1": If the "Length" of the "Current" Object
            //      → is "Less" than the "Other" Object ▼
            return -1;
        }
    }

    
    
    
    // ▬ "Method" to "Demonstrate"
    //      → the "Usage" of the "CompareTo()" Method ▬
    public static void RunComparable()
    {
        // ▼ "Create" an "Instance" of "Comparable" Class ▼
        Comparable comparable = new Comparable() { Length = 10 };

        // ▼ "Call" the "CompareTo()" Method
        //      → with "Another Comparable" Object ▼
        Console.WriteLine(comparable.CompareTo(new Comparable() { Length = 5 }));
    }
}