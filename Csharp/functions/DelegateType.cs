/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                     • "FUNCTIONS" •
                     ───────────────
                   • "DELEGATE TYPE" •


       

    ▬ "Delegations" in "C#" 
        → are "Special Types" of "Objects" 
        → that Allow "Functions" 
        → to be "Treated" as "Objects". 
    
        
        ♦ "They" 
            → are "References" 
            → to "Create" and "Manage Methods", 
            → and Allow these references 
            → to Be "Passed" as
                •► "Parameters", 
            → "Returned" from "Methods", 
            → or "Stored" 
            → in "Collections".

        
    
    ▬ "Key Points" about "Delegation":
        1. "Method Pointers": 
            ♦ "Delegations" 
                → "Provide" a "Mechanism" 
                → to "Refer" 
                → to "Methods" as "Objects", 
                → Allowing them 
                → to be "Stored" 
                → in "Variables", 
                → "Passed" as "Parameters" 
                → and "Returned" 
                → from "Other Methods".



        2. "Flexibility": 
            ♦ "Delegations" 
                → Allow "Instances" 
                → to "Be Created" 
                → to "Represent" 
                → any "Value" 
                → with a "Signature" 
                → that "Matches" 
                → the "Set Delegate". 
            
            
            ♦ This "Flexibility" 
                → allows "Delegation" 
                → to be "Used" 
                → to Define: 
                    • "Anonymous Functions" or 
                    • "Lambda Expressions", 
                → which Makes It "Easier" 
                → to "Work" with: 
                    •► "Events", 
                    •► "Callbacks" 
                → and Other "Asynchronous Programming Patterns".



        3. "Events": 
            ♦ "Delegations" in "C#"  
                → are "Common" 
                → to "Implement" 
                → the "Event Pattern". 
            
            
            ♦ A "Class" 
                → "Declares" an "Event", 
                → which is "Actually" 
                → a "Pair" of "Subscriber Add" 
                → and "Remove Methods", 
                → both of which 
                → the "Delegate" can "Reach".


        4. "Behavior Encapsulation": 
            ♦ By "Using Delegations" 
                → the "Logic" of a "Method" 
                → can be "Encapsulated" 
                → and "Passed" 
                → as an "Argument", 
                → Allowing "Other Parts" of the "Code" 
                → to "Determine Exactly" 
                → what "Behavior" to "Execute" 
                → in a "Given Context2".

    
    
    ▬ Essentially, "Delegations" 
        → "Enable" a "High Degree" 
        → of "Flexibility" 
        → and "Extensibility" in "C#", 
        → allowing "Programmers" 
        → to "Implement" 
        → "Complex Programming Patterns" 
        → such as: 
            •► "Callbacks", 
            •► "Events",
        → and "Other Forms" 
        → of "Asynchronous Programming".
            
    
    
    ▬ "Lambda Expressions" 
        → are "Anonymous Functions" 
        → that can be "Treated" 
        → as "Data Objects" 
        → and "Assigned" 
        → to "Delegate Variables".
        
        ♦ "They" 
            → are "used" to Create "Inline Functions" 
            → in a "Concise" 
            → and "Expressive Manner". 
            
             
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace Csharp.functions;

public class DelegateType
{
    
    public static void RunDelegateType()
    {
        // ▼ "Variable" of "Delegate Type"
        //      → and Its "Assignment"
        //      → to a "Anonymous Function" ("Lambda Expression") ▼
        Func<int, int, int> multiply = (x, y) => x * y;
        
        Console.WriteLine("Delegate Type and its Assignment to a Lambda Expression - for Multiply: " + multiply(5, 10));
    }
}