/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                       • "THREADS" •
                       ─────────────
                    • "THREAD POOLING" •

       


    ▬ "Thread Pooling"
        → is a "Programming Technique" 
        → that "Involves" 
        → "Creating" a "Pool" of "Threads" 
        → to "Efficiently Manage" Concurrent "Tasks". 
    
    
    
    
    ▬ "Instead" of "Creating" 
        → "New Threads" for "Each Task", 
        → a "Fixed Number" of "Threads" 
        → are "Maintained" 
        → in the "Pool" 
        → and "Reused" 
        → as "Needed". 
    
    
    
    
    ▬ T"his Approach" 
        → Improves "Resource Utilization", 
        → "Reduces Overhead"
        → and Provides "Control" 
        → over the "Number" of "Active Threads". 
    
    
    
    
    ▬ The `ThreadPool` Class IN "C#"
        → Facilitates "Thread Pooling" 
        → by allowing "Tasks" 
        → to be "Scheduled" 
        → for "Execution" 
        → and Providing "Mechanisms" 
        → for "Task Completion Notification".
   

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.threads;


public class ThreadPooling
{
    // ▬ "Example1()" Method ▬
    public static void Example1(object state)
    {
        Console.WriteLine("Example 1");
    }
    
    // ▬ "Example2()" Method ▬
    public static void Example2(object state)
    {
        Console.WriteLine("Example 2");
    }
    
    // ▬ "Example3()" Method ▬
    public static void Example3(object state)
    {
        Console.WriteLine("Example 3");
    }
    
    // ▬ "RunThreadPooling()" Method ▬
    public static void RunThreadPooling()
    {
        ThreadPool.QueueUserWorkItem(new WaitCallback(Example1));
        ThreadPool.QueueUserWorkItem(new WaitCallback(Example2));
        ThreadPool.QueueUserWorkItem(new WaitCallback(Example3));
        
        // ▼ Count "Active Threads" ▼
        Console.WriteLine($"Count Active Threads: {ThreadPool.ThreadCount}");
        
        // ▼ "Sleep" for "3 Seconds" ▼
        Thread.Sleep(3000);
    }
}