/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# ADVANCED" & "COLLECTIONS" •
                    ─────────────────────────────────────
                                • "RECURSION" •
                        - "TOWERS OF HANOI" PROBLEM -

       


    ▬ "Recursion" in "Programming" 
        → is a "Concept" 
        → where a "Function" 
        → "Calls Itself" Repeatedly 
        → until "It Reaches" 
        → a "Specified Stopping Condition". 
        
        
        ♦ This "Technique" 
            → is "Frequently Used" 
            → to "Solve Problems" 
            → that can be "Broken Down" 
            → into "Smaller Sub-Problems" 
            → of the "Same Type". 
        
        
        ♦ When a "Function" 
            → "Calls Itself", 
            → it "Creates" 
            → a "Series" of "Calls" 
            → to the "Program's Execution Stack", 
            → called the "Call Stack". 
        
        
        ♦ Each "New Function Call" 
            → is "Put" on the "Call Stack"
            → and "Execution"  
            → "Returns" to the "Previous Call" 
            → once the "Stopping Condition" 
            → is "Met". 
    
    
    
    ▬ "Recursion" 
        → "Requires" a "Stop Condition" 
        → to "Avoid" an "Infinite Loop" 
        → and Ensure "Recursive Completion".
    
    
    
    ▬ "Any Problem" 
        → that can be "Solved Iteratively" (by "Loops"), 
        → can also be "Solved Recursively" 
        → and "Vice-Versa".
    
    
    ▬ "Iteration"
        → is when we Use "Loops" 
        → to "Iterate" 
        → over a "Data"
        → and it Takes "Less Space"
        → than "Recursion". 
    
    
    ▬ "Recursion" 
        → is when a "Function" 
        → "Calls Itself" 
        → over and over 
        → to "Solve" a "Problem",
        → "Makes" the "Program"
        → more "Readable"
        → and is "Faster"
        → then "Iteration".
    
    
    
    
    
    ▬ The "Towers" of "Hanoi" Problem 
        → is a "Mathematical Puzzle" 
        → that involves "Moving" 
        → a "Set" of "Discs" 
        → from a "Source Tower" 
        → to another "Destination Tower", 
        → using a Third "Auxiliary Tower"
        → as a "Buffer" 
        → (an "Area" of "Temporary Memory" 
        →  used to "Store Data"). 
        
        
        
        ♦ "Rules" that must be "Followed":
            
            1. Only "One Disk" 
                → can be "Moved" 
                → at a "Time".
                
            2. "Placing" 
                → a "Larger Disc" 
                → on "Top" of a "Smaller Disc" 
                → is "Not Allowed".



        ♦ The "Goal" 
            → is to "Move" 
            → the "Entire Set" of "Disks" 
            → from the "Source Tower" 
            → to the "Destination Tower", 
            → using the "Auxiliary Tower" 
            → as a "Buffer" 
            → for "Temporary Storage".


    ▬ "Solving" the "Problem" 
        →uses a "Recursive" Approach:

        1. "Base Case": 
            ♦ To "Move" 
                → a "Single Disk" 
                → from "Source" 
                → to "Destination", 
                → we "Move" the "Disk Directly".
        
        
        2. "Otherwise" 
            → we use "Recursion" 
            → to Move "n-1 Disks" 
            → from the "Source" 
            → tower to the "Auxiliary Tower", 
            → using the "Destination" 
            → as a "Buffer"
            → for "Temporary Storage".
            
            
        3. "Then" 
            → we move the "n Disk" ("Largest") 
            → from the "Source Tower" 
            → to the "Destination Tower".
        
        
        4. "Finally", 
            → we "Move" the "n-1 Disks" 
            → from the "Auxiliary Tower" 
            → to the "Destination Tower", 
            → using the "Source" 
            → as a "Buffer".


        ♦ This "Approach" 
            → guarantees that the "Discs" 
            → are "Moved Correctly" 
            → and "Following" the "Rules"
            → "Imposed" by the "Towers" of "Hanoi" Problem.


 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.advanced;

public class TowersOfHanoiRecursionProblem
{

    // ▬ M"oveDisk()" Method uses a Recursive Approach ▬
    public static void MoveDisk(int n, char source, char auxiliary, char destination)
    {
        // ▼ "Base Case":
        //      → If we have Only "One Disk" to "Move",
        //      → we "Move" It "Directly"
        //      → from "Source" to "Destination" ▼
        if (n == 1)
        {
            // ▼ "Display" the "Message"
            //      → indicating the "Disk Move"
            //      → from "Source" to "Destination" ▼
            Console.WriteLine($"Move Disk 1 from {source} to {destination}");
           
            
            // ▼ We "Return Control", s
            //      → since we have "Nothing More"
            //      → to "Do" in this "Case" ▼
            return;
        }

        
        
        // ▼ We "Recursively Call" the "Method"
        //      → to "Move" the First "n-1 Disks"
        //      → from the "Source" to the "Auxiliary Tower",
        //      → using the "Destination" as an "Intermediate Tower" ▼
        MoveDisk(n - 1, source, destination, auxiliary);
    
        
        // ▼ Wwe Move "Disk n" (the "Largest Disk")
        //      → from "Source" to "Destination" ▼
        Console.WriteLine($"Move Disk {n} from {source} to {destination}");

        
        // ▼ We "Recursively Call" the "Method"
        //      → to "Move" the "n-1 Disks"
        //      → on the "Auxiliary Tower" again ▼
        //      → (which "Now Serves" as the "Source") on the destination tower, using the source as an intermediate tower.
        MoveDisk(n - 1, auxiliary, source, destination);
    }




    // ▬ "RunTowersOfHanoiRecursionProblem()" Method ▬
    public static void RunTowersOfHanoiRecursionProblem()
    {

        // ▼ "Call" the "Method"
        //      → with a S"pecific Number" of "Disks" ▼
        MoveDisk(2, 'A', 'B', 'C');
    }
}
