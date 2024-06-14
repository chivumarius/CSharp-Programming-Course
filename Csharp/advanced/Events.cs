/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# ADVANCED" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "EVENTS" •

       

    ▬ "Events"  
        → are "Notifications" 
        → about "State Changes" 
        → or "Actions" 
        → that "Take Place" 
        → in a "Class". 
        
        
        ♦ "They" 
            → allow "Objects" 
            → to "Communicate" 
            → "Without Knowing Details" 
            → about "Each other". 
        
        
        ♦ A "Class" 
            → can "Declare Events" 
            → and "Other Classes" 
            → can "Subscribe" 
            → to "These Events" 
            → to "Respond" to
                •► "State Changes" or 
                •►"Actions".
    
    ▬ "Example" of "Event"
        ♦ "Clicking" a "Button" 
            → "Triggers" an "Event".
    
    
    
    ▬ "Publisher" & "Subscriber" Concepts:
        ♦ "Publisher"
            → "Send" the "Event".
        
        
        ♦ "Subscriber"
            → "Receive" and "Handle" 
            → the "Event".
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.advanced;

public class Events
{
    
    // ▼ "Creating" an "EventHandler" ▼
    public static event EventHandler evt; 
    
    
    
    
    // ▬ "HandleEvent()" Method ▬
    // public static void HandleEvent(object sender, EventArgs evtArgs)
    // {
    //     Console.WriteLine("\nEvent: Hello World!");
    // }
    
    
    
    // ▬ "Creating" a "Finalizer" Method
    //      → for the "Class"
    //      → to "Unsubscribe" from "Event" ▬
    // ~Events()
    // {
    //     // ▼ "Unsubscribing" from "Event"
    //     //      → by "Removing" the "Method"
    //     //      → from the "EventHandler" ▼
    //     evt -= HandleEvent;
    // }
    
    
    
    // ▬ "RunEvents()" Method ▬
    public static void RunEvents()
    {
        // ▼ "Subscribing" to "Event"
        //      → by "Adding" the "Method"
        //      → to the "EventHandler" ▼
        // evt += HandleEvent;
        
        
        // ▼ "Subscribing" to "Event"
        //      → by using "Lambda Expression" ▼
        evt += (sender, evtArgs) =>
        {
            Console.WriteLine("\nEvent: Hello World!");
        };
        
        
        // ▼ "Subscriber" can "Manage Events"
        //      → from "Many Publishers" ▼
        evt += (sender, evtArgs) =>
        {
            Console.WriteLine("Second Event: Goodbay World!");
        };
        
        
        
        // ▼ "Publishing" the "Event" ▼
        evt?.Invoke(null, EventArgs.Empty);
    }
}