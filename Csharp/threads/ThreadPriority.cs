/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "THREADS" •
                        ─────────────
                    - "THREAD PRIORITY" -

       


    ▬ "Thread Priority"
        → is a "Feature" 
        → of "Operating Systems" 
        → that allows "Programmers" 
        → to "Specify" the "Degree" of "Importance" 
        → of a "Thread" 
        → "Compared" to "Other Threads"  
        → "Running" in the "Same Context2". 
        
        
        
    ▬ This "Priority" 
        → can be "Used" 
        → by the "Operating System" 
        → to "Make Decisions" 
        → regarding "Resource Allocation" 
        → and "Thread Execution Scheduling". 
    
    
    
    
    ▬ "Operating Systems" 
        → "Usually" provide "Different Levels" 
        → of "Priority", 
        → such as: 
            • "High", 
            • "Normal" and 
            • "Low" 
        → and there may be "Other Levels" 
        →in between. 
    
    
    
    
    ▬ "Programmers" 
        → can "Use" 
        → "These Priority Levels" 
        → to "Manage System Resources" 
        → and "Ensure Efficient Execution" 
        → of "Applications".


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.threads;


public class ThreadPriority
{
    // ▬ "MyThreadPriority()" Method ▬
    public static void MyThreadPriority()
    {
        Console.WriteLine("\n" + "──────────────────── \"THREAD PRIORITY\" ────────────────────");
       
        Console.WriteLine("The Thread Priority is: " + Thread.CurrentThread.Priority);
    }

    
    
    
    // ▬ "RunThreadPriority()" Method
    //      → to "Run Thread"
    //      → with "Normal Priority" ▬
    public static void RunThreadPriority()
    {
        // ▼ "Creating" a "Object" ▼
        Thread thread = new Thread(MyThreadPriority);

        
        // ▼ "Setting" the Thread "Priority" Property ▼
        thread.Priority = System.Threading.ThreadPriority.Normal; // Fully qualify Normal enum value

        
        // ▼ "Start" the "Thread" ▼
        thread.Start();

        
        // ▼ "Wait" for the "Thread"
        //  to "Complete" ▼
        thread.Join();
    }
}
