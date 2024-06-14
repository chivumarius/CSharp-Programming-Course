/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                          • "THREADS" •
                          ─────────────
                    • "PARALLEL PROGRAMMING" •
                  

       


    ▬ "Parallel Programming" 
        → is a "Programming Paradigm" 
        → that "Focuses" 
        → on Using "Multiple Threads" 
        → to "Solve Computational Problems". 


        ♦ "Essentially", "Parallel Programming" 
            → involves "Breaking" a "Large Task" 
            → into Smaller Chunks 
            → that can be "Executed Simultaneously" 
            → on "Multiple Processors" 
            → or "Processor Cores".




   ▬ By using "Parallel Programming", 
        → an "Increase" in "Performance" 
        → and a "Reduction" in "Execution Time" 
        → can be "Achieved" 
        → for "Certain Applications", 
        → since "Tasks" 
        → can be "Distributed" 
        → and "Executed Concurrently" 
        → on "Multiple Processing Units".




   ▬ There are Several "Parallel Programming Models" and "Techniques", 
        → including:

        1. "Processes" and "Threads":
            •► Using "Multiple Processes" or "Threads" 
                → to "Execute Tasks" 
                → in "Parallel".
        

        2. "Communication" and "Synchronization": 
            •► "Coordination" and "Communication" 
                → between "Processes" or "Threads" 
                → to "Share Data" 
                → and "Solve" Interdependent "Tasks".
        

        3. "Instruction-Level Parallelism": 
            •► Using the "Hardware Capability" 
                → of "Processors" 
                → to Execute "Multiple Instructions" 
                → at the "Same Time".



    ▬ "Parallel Programming" 
        → is used in a "Wide Range" of "Fields", including 
            •► "Scientific Computing", 
            •► "Image" & "Video Processing", 
            •► "Databases", 
            •► "Video Games" 
        → and more. 



    
    ▬ There are "Two Strategies" or "Parallel Programming":
        1. "Test Parallelism" 
            → is when "Each Thread" 
            → performs "Different Tasks".


        2. "Data Parallelism"
            → is "Used" 
            → to perform a "Set" of "Operations" 
            → on a "Set" of "Data", 
            → so "Each Thread" 
            → performs the "Same Task" 
            → on a "Sub-Set" 
            → of "Values".

 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/


namespace CSharp.threads;


public class ParallelProgramming
{
    // ▬ "RunParallelProgramming()" Method ▬
    public static void RunParallelProgramming()
    {
        // ▼ Using "Parallel Programming"
        //    → to "Download"
        //    → "2 Web Pages" in "Parallel" ▼
        // Parallel.Invoke(
        //         () => new WebClient().DownloadFile("https://www.google.com", "google.html"),
        //                    () => new WebClient().DownloadFile("https://www.yahoo.com", "yahoo.html")
        //         );
        
        
        
        
        // ▼ Using "Parallel Programming"
        //    → for "For" Loop ▼"
        Parallel.For(0, 3, i => Console.WriteLine("Using Parallel Programming for 'For Loop'."));
        
        
        
        Console.WriteLine();
        
        
        // ▼ Using "Parallel Programming"
        //    → for "Foreach" Loop ▼"
        Parallel.ForEach(Enumerable.Range(0, 3), i => Console.WriteLine("Using Parallel Programming for 'Foreach Loop'."));
    }
} 