using System.Collections;

namespace CSharp.interfaces_and_abstract_classes.interfaces;


// ▬▬ "Class" ▬▬
class Employee
{
    public int id;
}



// ▬▬ "IComparer" Interface
//      → "Exposes" a "Method"
//      → that "Compares 2 Objects" ▬▬
public class Comparer : IComparer
{
    

    public int Compare(object? x, object? y)
    {
        // ▼ Variables ▼
        Employee employee1 = (Employee) x;
        Employee employee2 = (Employee) y;

        // ▼ ".CompareTo()" Method
        //      • "0" = means that the "2 Ids" are "Equals" 
        //      • "1" = means that the "Id" of the "First Employee"
        //                  → is "Greater"
        //      • "-1" = means that the "Id" of the "Second Employee"
        //                  → is "Greater"
        return employee1.id.CompareTo(employee2.id);
    }
    
    
    
    
    // ▬   "Method" to "Run" the "Class" ▬
    public static void RunComparer()
    {
        // ▼ "Create" "Instances"
        //      → of the "Employee" Class
        //      → and "Compare" Class ▼
        Employee employee1 = new Employee { id = 1 };
        Employee employee2 = new Employee { id = 2 };
        Comparer comparer1 = new Comparer();

        
        // ▼ "Compare" the "Two Instances"
        //      → of "Employee" Class
        //      → using "Comparer()" Member Method ▼
        int result = comparer1.Compare(employee1, employee2);

        
        // ▼ "Display" the "Comparison Result" ▼
        Console.WriteLine($"Comparison result: {result}");
    }
}