/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                       • "THREADS" •
                       ─────────────
                • "CONCURRENT COLLECTIONS" •

       


    ▬ "Concurrent Collections"
        → are "Part" 
        → of the "System.Collections.Concurrent" Namespace 
        → in the ".NET" Framework 
        → and ".NET" Core, 
        → which provide "Data Collections Designed" 
        → "Specifically" for "Use" 
        → in "Concurrent Environments" 
        → where "Multiple Threads" 
        → "Access" and "Modify" 
        → the "Same Data" 
        → at the "Same Time".





    ▬ The "Main Difference" 
        → between "Concurrent Collections" 
        → and "Traditional Collections" 
        → is that "Concurrent Collections" 
        → implement "Internal Synchronization Mechanisms" 
        → to "Ensure Safe" 
        → and "Efficient Access" 
        → to "Shared Data", 
        → "Without" Requiring "Manual Locks" 
        → and "Without" Introducing "Deadlocks", 
        → that might "Block" other "Threads".





    ▬ "Concurrent Collections" in ".NET" include:

        1. "ConcurrentQueue<T>": 
            
            • Is a "Concurrent FIFO ("First-In, First-Out") Collection "
                → that allows "Adding" 
                → and "Removing Elements Concurrently". 


            • "This" is "Useful" 
                → in "Scenarios" 
                → where "Multiple Threads" 
                → "Need" to "Add" 
                → and "Remove Items" 
                → from the "Same Queue Safely".




        2. "ConcurrentStack<T>": 
            • Is a "Concurrent LIFO (Last-In, First-Out) Collection" 
                → that allows "Adding" 
                → and "Removing Elements Concurrently". 


            ♦ "This" is "Useful" 
                → in "Situations" 
                → where "Multiple Threads" 
                → "Need" to "Add" 
                → and "Remove Elements" 
                → from the "Same Stack Safely".



        3. "ConcurrentBag<T>": 
            • Is a "Non-Linear Collection" 
                → of "Concurrent Elements" 
                → that allows "Adding" 
                → and "Removing Elements Concurrently". 


            • "This" is "Useful" 
                → when the "Order" of "Elements" 
                → is "Not Important" 
                → and "Access" to the "Collection" 
                → must be "Fast" and "Secure".



        4. "ConcurrentDictionary<TKey, TValue>": 
            • Is a "Collection" 
                → of "Concurrent Key-Value Pairs" 
                → that allows Adding, Updating and 
                → "Removing Items Concurrently". 


            • "This" is "Useful" 
                → in "Scenarios" 
                → where "Multiple Threads" 
                → "Need" to "Access" and "Modify" 
                → the "Same Collection" 
                → of "Key-Value Pairs Safely".





    ▬ Concurrent Collections are "Useful" 
        → in "Parallel" 
        → and "Concurrent Programming" 
        → because they provide "Good Performance" 
        → and "Ensure Data Integrity" 
        → in "Multi-Threaded Environments". 


        ♦ "They" are "Designed" 
            → to make "Programming" 
            → in these "Environments" 
            → "Safer" and "Easier" 
            → by "Eliminating" 
            → the "Need" for "Manual Locks" 
            → and "Managing Synchronization Internally".


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Collections.Concurrent;

namespace CSharp.threads;


public class ConcurrentCollections
{
    
    // ▬ "RunConcurrentCollections()" Method ▬
    public static void RunConcurrentCollections()
    {
        // ▼ Creating an "Object" of "ConcurrentBag" Class ▼
        ConcurrentBag<int> bag = new ConcurrentBag<int>();
        
        // ▼ Creating a "List" of "Tasks" ▼
        List<Task> tasks = new List<Task>();
        
        
        // ▼ "Looping" ▼
        for (int i = 0; i < 5; i++)
        {
            // ▼ "Variable" ▼
            var numberToAdd = i;
            
            // ▼ "Adding" "Tasks" to the "List" of "Tasks" ▼
            tasks.Add(Task.Run(() => bag.Add(numberToAdd)));
        }
        
        // ▼ "Waiting" for "All" the "Tasks" to be "Completed" ▼
        Task.WaitAll(tasks.ToArray());
        
        
        
        // ▼ Creating a "List" of "Tasks" ▼
        List<Task> runningTasks = new List<Task>();
        
        // ▼ "Variable" ▼
        int numberOfItems = 0;
        
        // ▼ "Looping" ▼
        while(!bag.IsEmpty)
        {
            // ▼ "Adding" "Tasks" to the "List" of "Tasks" ▼
            runningTasks.Add(Task.Run(() =>
            {
                int item; 
                if(bag.TryTake(out item))
                {
                    Console.WriteLine(item);
                    numberOfItems++;
                }
            }));
        }
        
        // ▼ "Waiting" for "All" the "Tasks" to be "Completed" ▼
        Task.WaitAll(runningTasks.ToArray());
        
        // ▼ "Printing" the "Number of Items" ▼
        Console.WriteLine($"\nNumber of Items: {numberOfItems}");
    }
} 