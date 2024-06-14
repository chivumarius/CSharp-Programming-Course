using System.Collections;

namespace CSharp.interfaces_and_abstract_classes.interfaces;


// ▬ "IEnumerator" Interface
//      → is "Used" to "Support"
//      → "Simple Iteration"
//      → over a "Collection" of "Items"
public class EnumeratorClass : IEnumerator
{
    
    // ▼ "List" of "Objects" ▼
    List<object> items = new List<object>();

    private int current = -1;
    
    
    // ▼ "Current" Interface Member Property
    //      → to "Return" the "Current Items" ▼
    public object Current => items[current]; 



    // ▬ "MoveNext()" Interface Member Method ▬
    public bool MoveNext()
    {
        if (current < items.Count - 1)
        {
            current++;
            return true;
        }
        else
        {
            return false;
        }
    }

    
    
    // ▬ "Reset()" Interface Member Method ▬
    public void Reset()
    {
        current = 0;
    }

    
    
    
    // ▬ "RunEnumerator()" Method ▬
    public static void RunEnumerator()
    {
        // ▼ "Create" an "Instance" of "EnumeratorClass" Class ▼
        EnumeratorClass enumerator = new EnumeratorClass();
    
        
        // ▼ "Add Objects" to the "List"
        //      → in "EnumeratorClass" ▼
        enumerator.items.Add("Item 1");
        enumerator.items.Add("Item 2");
        enumerator.items.Add("Item 3");
    
        
        // ▼ "Iterate" through the "Objects" in "EnumeratorClass"
        //      → using "IEnumerator" Interface ▼
        while (enumerator.MoveNext())
        {
            Console.WriteLine(enumerator.Current); // Display the current element
        }
    }
}