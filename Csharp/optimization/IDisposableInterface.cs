/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "OPTIMIZATION" •
                    ────────────────
               • "I DISPOSABLE" INTERFACE •

       


    ▬ "IDisposable" Interface in "C#" 
        → is "Used" to "Manage" 
        → "Unmanaged Object Resources",
        → which is "Done Automatically" 
        → by the "Garbage Collector" ("GC"). 


        ♦ This "Provides" a "Way" 
            → to "Release Resources" 
            → when they are "No Longer Needed", 
            → thus preventing "Memory Leaks" 
            → and "Other Resource Management Issues". 



    ▬ A "Class" 
        → that "Implements" 
          •► "IDisposable" 
        → "Must Provide" a "Dispose()" Method 
        → for "Freeing Fesources". 



    ♦ Using "IDisposable" 
        → is often in "Conjunction" 
        → with the "using" Statement, 
        → which Automatically Frees 
        → the "Object's Resources" 
        → at the "End" 
        → of the "using" Block.

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.optimization;


//──────────────────────────────────────────────────────────────
// ▬ "Resource" Class
//       → that "Implements"
//       → the "IDisposable" Interface ▬
public class Resource : IDisposable
{
    // ▼ "Set" the "Disposed" Property ▼
    private bool disposed = false;

    
    // ▬ "Dispose()" Method
    //      → for "Freeing Resources" ▬
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    
    
    // ▬ "Dispose()" Method
    //      → for "Freeing Resources" ▬
    protected virtual void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if(disposing)
            {
                // ▼ "Release Managed Resources" ▼
                Console.WriteLine(" - Releasing Managed Resources.");
            }

            // ▼ "Release Unmanaged Resources" ▼
            Console.WriteLine(" - Releasing Unmanaged Resources.");

            disposed = true;
        }
    }

    
    
    // ▬ "Destructor" for "Releasing Resources" ▬
    ~Resource()
    {
        Dispose(false);
    }

    
    
    // ▬ "DoSomething()" Method ▬
    public void DoSomething()
    {
        if (disposed)
            throw new ObjectDisposedException("Resource");

        Console.WriteLine("Creating a Task...");
    }
}




//──────────────────────────────────────────────────────────────
// ▬ "IDisposableInterface" Class
//       → that "Implements"
//       → the "IDisposable" Interface ▬
public class IDisposableInterface 
{

    // ▬ "RunIDisposableInterface()" Method ▬
    public static void RunIDisposableInterface()
    {
        // Using the Resource class in a using statement
        using (var resource = new Resource())
        {
            // Execution of a task
            resource.DoSomething();
        } // At the end of the using block, resources are automatically freed
    }
} 