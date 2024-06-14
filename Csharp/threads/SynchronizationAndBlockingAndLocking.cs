/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "THREADS" •
                    ─────────────
                • "SYNCHRONIZATION" •
                   • "BLOCKING" •
                   • "LOCKING" •




    ▬ "Thread Synchronization" 
         → means having "Two" or "More Threads" 
         → "Running" at the "Same Time"


    ▬ To Achieve "Synchronization" 
        → we Use "Two Main Techniques":

        1. "Blocking"         
        2. "Locking"
        
        
        
        ▬ The `lock(){}` Statement    
            → is a "Construct" 
            → "Used" in "Programming" 
            → to Ensure "Synchronized Access" 
            → to "Shared Resources" 
            → between Multiple Threads". 
            
            
            ♦ By "Locking" 
                → the "Shared Resource" 
                → in a "lock(){}" Block, 
                → only "One Thread" 
                → is "Allowed" to "Access It" 
                → at a "Time", 
            
            
            ♦ "Thus" 
                → "Preventing Conflicts" 
                → and "Data Corruption". 
           



    ▬ When "Two Threads"
        → are "Running" 
        → "One Thread" 
        → can "Block"
        → "Another Thread" 
        → when T"hey Need" 
        → to "Access" 
        → the "Same Resources"



    ▬ There are "Two Key Functions" 
        → used in "Working" 
        → with "Threads":
        
        1. "Join()" 
            → is "Waiting" for a "Thread" 
            → to "Finish",
            → "Before" the "Code Below" 
            → is "Executed".
            
            
        2. "Sleep()"
            → is "Used" to "Suspend" 
            → the "Execution" of a "Thread" 
            → for a "Certain Period" of "Time". 
            
            
            ♦ This "Pause" 
                →can be "Specified" 
                → in "Milliseconds" 
                → or "Other Time Units". 
            
            
            ♦ Using "Sleep()" 
                → is "Useful" 
                → to "Control" the "Speed" 
                → of "Execution" 
                → or to Introduce "Delays" 
                → between "Instructions" 
                → in a "Program". 




     ▬ "Key Points" for "Thread Safety":    
         • "Deadlock Management"
         • "Eliminate" Any "Race Conditions"
         • Don't Use "Thread.Abort()" 
            → to "Stop Other Threats".
        • "Look Variables", 
            → do "Not Look Other Types".

 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.threads;


public class SynchronizationAndBlockingAndLocking
{
    // ▬ "Example1()" Method ▬
    public static void Example1()
    {
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
    }
    
    
    
    // ▬ "Example1()" Method ▬
    public static void Example2()
    {
        Console.WriteLine(4);
        Console.WriteLine(5);
        Console.WriteLine(6);
       
    }
    
    
    
    
    // ▼ "Global Variable" ▼
    private static string name = ""; 
    
    
    // ▬ 
    public static void Example3()
    {
        Console.WriteLine("Example 3");
        lock (name) {
            name = "Sebastian";
        }
    }
    
    public static void Example4()
    {
        Console.WriteLine("Example 4");
        lock (name) {
            name = "Nicholas";
        }
    }
    
    
    public static void Example5()
    {
        Console.WriteLine("Example 5");
        lock (name) {
            name = "Eduard";
        }
    }
    
    
    // ▬ "RunSynchronizationAndBlockingAndLocking()" Method ▬
    public static void RunSynchronizationAndBlockingAndLocking()
    {
        // // ▼ Create "Two Threads" ▼
        // Thread t1 = new Thread(Example1);
        // Thread t2 = new Thread(Example2);
        //
        //
        // // ▼ Start "Two Threads" ▼
        // t1.Start();
        // t2.Start();
        
        
        
        // ▼ (1) Using "Sleep()" Method ▼
        // Console.WriteLine("\nUsing 'Sleep()' Method: ");
        // Console.WriteLine(" - " + DateTime.Now);   // ◄ "Current Time" ◄
        // Thread.Sleep(2000); // ◄ "Sleep" for "2 Seconds" ◄
        // Console.WriteLine(" - " + DateTime.Now);
        
        
        
        // ▼ Create "Two Threads" ▼
        Thread t3 = new Thread(Example3);
        Thread t4 = new Thread(Example4);
        Thread t5 = new Thread(Example5);
        
        
        // ▼ Start "Two Threads" ▼
        t3.Start();
        t4.Start();
        t5.Start();

        
        // ▼ Sleep for "3 Seconds" ▼
        Thread.Sleep(3000);
        
        
        // ▼ Output "Name" ▼
        Console.WriteLine("Name: " + name);
    }
}  