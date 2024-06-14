using System.Collections;

namespace CSharp.interfaces_and_abstract_classes.interfaces;



// ▬▬ "Officer" Class ▬▬
public class Officer
{
    // ▼ "Field" ▼
    Guid id;
    
    // ▼ "Property" ▼
    public Guid Id {
        get
        {
            return id;
        }
        
        set
        {
            id = value;
        }
    }
}





// ▬▬ "IEqualityComparer" Interface
//      → "Defines Methods" to Support 
//      → the "Comparison" of "Objects" for "Equality".
public class EqualityComparer : IEqualityComparer<Officer>
{
    
    // ▬ "Equals()" Member Interface Method ▬
    public bool Equals(Officer? x, Officer? y)
    {
        return x.Id.Equals(y.Id);
    }

    
    // ▬ "GetHashCode()" Member Interface Method ▬
    public int GetHashCode(Officer obj)
    {
        return obj.Id.GetHashCode();
    }
    
    
    
    
    // ▬ "RunEqualityComparer()" Method ▬
    public static void RunEqualityComparer()
    {
        // ▼ Creating "Instances"
        //      → of the "Officer" Class
        //      → and "Equality Comparer" Class ▼
        Officer officer1 = new Officer { Id = Guid.NewGuid() };
        Officer officer2 = new Officer { Id = Guid.NewGuid() };
        Officer officer3 = new Officer { Id = officer1.Id };    // ◄◄ "Creating" a "Duplicate ID" ◄◄
        EqualityComparer comparer = new EqualityComparer();

        // ▼ "Comparing" the "Instances"
        //      → using the "Equals()" Method ▼
        bool areEqual1And2 = comparer.Equals(officer1, officer2);
        bool areEqual2And3 = comparer.Equals(officer2, officer3);
        bool areEqual1And3 = comparer.Equals(officer1, officer3);

        // ▼ "Displaying" the "Results" ▼
        Console.WriteLine($"Officer 1 and Officer 2 are {(areEqual1And2 ? "equal" : "not equal")}.");
        Console.WriteLine($"Officer 2 and Officer 3 are {(areEqual2And3 ? "equal" : "not equal")}.");
        Console.WriteLine($"Officer 1 and Officer 3 are {(areEqual1And3 ? "equal" : "not equal")}.");
    }

}