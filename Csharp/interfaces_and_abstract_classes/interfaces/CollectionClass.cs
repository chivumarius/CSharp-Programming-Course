using System.Collections;

namespace CSharp.interfaces_and_abstract_classes.interfaces;


// ▬▬ "ICollection" Interface
//      → allows the "Creation"
//      → of "Custom Collections" ▬▬
public class CollectionClass : ICollection<string> 
{
    // Use "List<T>" to "Store" the "Elements" ▼
    private List<string> items = new List<string>(); 

    
    
    // ▼ Interface Properties ▼
    // ▼ To "Get" the "Number" of "Elements"
    //      → "Contained" in the "Collection" ▼
    public int Count => items.Count;   
    
    // ▼ For "Safe Access" to the "Collection" ▼
    public bool IsSynchronized => false;
    
    // ▼ For "Synchronizing Access" to the "Collection" ▼
    public object? SyncRoot => null;

    
    
    
    // ▬ "GetEnumerator()" Interface Member Method
    //      → returns an "Enumerator"
    //      → that will "Iterate"
    //      → over a "Collection" ▬
    public IEnumerator<string> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    
    
    // ▬ "CopyTo()" Interface Member Method
    //      → for "Copying" the "Elements"
    //      → of the "Collection"
    //      → to an "Array" ▬
    public void CopyTo(string[] array, int index)
    {
        items.CopyTo(array, index);
    }

    
    
    // ▬ "Add" Method
    //      → for "Adding Elements"
    //      → to the "Collection" ▬
    public void Add(string item)
    {
        items.Add(item);
    }
    
    
    
    // ▬▬ "Clear()" Method ▬▬
    public void Clear()
    {
        items.Clear();
    }

    // ▬▬ "Contains" Method ▬▬
    public bool Contains(string item)
    {
        return items.Contains(item);
    }

    // ▬▬ "IsReadOnly" Property ▬▬
    public bool IsReadOnly => false;

    // ▬▬ "Remove" Method ▬▬
    public bool Remove(string item)
    {
        return items.Remove(item);
    }

    
    
    // ▬ "RunCollectionClass()" Method ▬
    public static void RunCollectionClass()
    {
        CollectionClass collection = new CollectionClass();

        collection.Add("Element 1");
        collection.Add("Element 2");
        collection.Add("Element 3");

        Console.WriteLine("Elements in the collection:");
        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
    }

    
    
    // ▬ "ICollection" Interface ▬
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}