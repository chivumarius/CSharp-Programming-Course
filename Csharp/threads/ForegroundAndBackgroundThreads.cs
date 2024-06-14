/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "THREADS" •
                        ─────────────
                    - "FOREGROUND THREADS" & 
                      "BACKGROUND THREADS" -

        


    ▬ In "C#"
        → there are "Two Types" 
        → of "Threads": 
            
            1. "Foreground Thread" 
                → is by "Default"
                → and they "Run"
                → in the "Foreground"
                → of the "Application".
                
                
                ♦ "They"
                    → Keep the "Application Alive"
                    → as long as at least
                    → "One" of "Them"
                    → is "Running".
                
                ♦ Once the "Foreground Thread"
                    → is "Finished"
                    → the "Application Ends" too.
                
                
                
            2. "Background Thread" 
                → is "Ended"
                → when the "Foreground Thread"
                → is "Finished"


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.threads;


public class ForegroundAndBackgroundThreads
{
    // ▬ "MyThread2()" Method ▬
    public static void MyThread2()
    {
        Console.WriteLine("\n" + "──────────────────── \"FOREGROUND THREADS\" AND \"BACKGROUND THREAD\" ────────────────────");

        // ▼ "For Loop" Iteration ▼
        for(int i = 0; i < 3; i++)
        {
            Console.WriteLine(i + ". Background Thread");
        }
    }
    
    
    
    // ▬ "RunForegroundAndBackgroundThreads()" Method ▬
    public static void RunForegroundAndBackgroundThreads()
    {
        // ▼ "Creating" a "Thread" Object ▼
        Thread thr1 = new Thread(MyThread2);
        
        
        // ▼ "Setting" the "Thread"
        //      → as "Background" ▼
        thr1.IsBackground = true;
        
        
        // ▼ "Starting" the "Thread" Object ▼
        thr1.Start();
    }
} 