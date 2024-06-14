/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "QUEUES" •

       

    ▬  A "Queue" 
        → is a Data Structure 
        → that "Works" 
        → on the "First-In, First-Out" ("FIFO") Principle. 
        
        
        ♦ This "Means" 
            → that "Items" are "Added" 
            → to the "Queue" 
            → in the "Order" 
            → they are "Received"
            → and the "First Item Added" 
            → is the "First Item" 
            → to be "Fetched".

    
    
    
    ▬ The "Main Features" of the "Queue":

        1. "First-In", "First-Out" ("FIFO"): 
            ♦ "Items" 
                → are "Pulled" 
                → from the "Queue" 
                → in the "Order" 
                → they were "Added", 
                → "Similar" to how "People Wait" 
                → in a "Queue" 
                    - "First In" 
                    - is "First Out".



        2. "Efficient Addition" and "Deletion Operations": 
            ♦ A "Queue" 
                → provides "Efficient Methods" 
                → for "Adding" an "Element" 
                → to the "End" of the "Queue" ("Enqueue()") 
                → and for "Retrieving" 
                → the "First Element" 
                → from the "Queue" ("Dequeue()").



        3. "Access" to "Front" of "Queue Item": 
            ♦ Although "Items" 
                → are "Fetched" 
                → in the "Order" 
                → they were "Added", 
                → we can "See" the "Item" 
                → that is "Next" to be "Fetched" 
                → "Without" actually "Removing It" 
                → from the "Queue" ("Peek()").


        4. "Use" in "Queue Ordered Situations": 
            ♦ "Queues" are "Useful"
                → in "Situations" 
                → where we "Need" to "Manage Items" 
                → in the "Order" 
                → in "Which" they "Were Received", 
                → such as in a "Waiting Queue" 
                → for "Tasks" to be "Processed" 
                → or "Events" to be "Handled".
                
    
    
    
    ▬ Key Operations of the "Queue":
        1. "Enqueue()"
            → to "Add" an "Item" 
            → to the "End" of the "Queue".
            
            
        2. "Dequeue()"
            → to "Remove" and Return 
            → the "First Item"
            → from the "Queue".
            
            
        3. "Peek()":
            → to "See" the "Item" 
            → that is "Next" to be "Fetched Item".
        
        
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class Queues
{
    
    
    
    // ▬ "RunStacks()" Method ▬
    public static void RunQueuess()
    {
       // ▼ Creating an "Instance/Object" of the "Queue" ▼ 
       Queue<string> queue1 = new Queue<string>();
       
       // ▼ Adding "Items" to the "Queue" ▼
       queue1.Enqueue("a");
       queue1.Enqueue("b");
       queue1.Enqueue("c");
       
       // ▼ Printing "Items" in the "Queue" ▼
       foreach(string item in queue1){
           Console.WriteLine(item);
       }
       
       
       // ▼ "Getting" the "First Item" in the "Queue" ▼
       Console.WriteLine("\nGet the First Item from the Queue (Dequeue): " + queue1.Dequeue());
       
       // ▼ "Getting" the "Next Item" in the "Queue" ▼
       Console.WriteLine("Get the Next Item from the Queue (Peek): " + queue1.Peek());

    }
}