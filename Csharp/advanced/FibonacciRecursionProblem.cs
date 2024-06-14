/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# ADVANCED" & "COLLECTIONS" •
                    ─────────────────────────────────────
                                • "RECURSION" •
                            - "FIBONACCI" PROBLEM -

       


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
    
    
    
    
    ▬ "Fibonacci" Sequence
        → is a "Sequence" 
        → of "Numbers" 
        → where the "Next Number" 
        → is the "Sum" 
        → of the "Previous 2 Numbers".
    
        ─────────────────────────────────────────────────────
            0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, ...
        ─────────────────────────────────────────────────────
    
    
    
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.advanced;

public class FibonacciRecursionProblem
{
    
    // ▬ "FibonacciUsingRecursion()" Method
    //      → using "Recursion" ▬
    static int FibonacciUsingRecursion(int n)
    {
        // ▼ "Base Case 1" ▼
        if (n == 0)
        {
            return 0;
        }
        
        // ▼ "Base Case 2" ▼
        if (n == 1)
        {
            return 1;
        }
        
        // ▼ "Recursive Case" ▼
        return FibonacciUsingRecursion(n - 1) + FibonacciUsingRecursion(n - 2);
    }
    
    
    // ▬ "FibonacciUsingIteration()" Method
    //      → using "Iteration" ▬
    static int FibonacciUsingIteration(int n)
    {
        // ▼ "Base Case" ▼
        if (n == 0 || n == 1)
        {
            return n;
        }

        
        // ▼ "Variables" ▼
        int secondLast = 0;
        int last = 1;
        int currentPosition = 2;

        
        // ▼ "Iteration" ▼
        while (currentPosition <= n)
        {
            int next = secondLast + last;
            secondLast = last;
            last = next;
            currentPosition++;
        }
        
        // ▼ "Return" ▼ 
        return last;
    }



    // ▬ "RunFibonacciRecursionProblem()" Method ▬
    public static void RunFibonacciRecursionProblem()
    {
        // ▼ "Testing Cases" of "Fibonacci"
        //      → "Using Recursion" ▼
        Console.WriteLine("\nUsing Recursion");
        Console.WriteLine("Fibonacci Number (n = 0): " + FibonacciUsingRecursion(0));
        Console.WriteLine("Fibonacci Number (n = 1): " + FibonacciUsingRecursion(1));
        Console.WriteLine("Fibonacci Number (n = 2): " + FibonacciUsingRecursion(2));
        Console.WriteLine("Fibonacci Number (n = 3): " + FibonacciUsingRecursion(3));
        Console.WriteLine("Fibonacci Number (n = 4): " + FibonacciUsingRecursion(4));
        Console.WriteLine("Fibonacci Number (n = 5): " + FibonacciUsingRecursion(5));
        Console.WriteLine("Fibonacci Number (n = 6): " + FibonacciUsingRecursion(6));
        Console.WriteLine("Fibonacci Number (n = 7): " + FibonacciUsingRecursion(7));
        Console.WriteLine("Fibonacci Number (n = 8): " + FibonacciUsingRecursion(8));
        Console.WriteLine("Fibonacci Number (n = 9): " + FibonacciUsingRecursion(9));
        Console.WriteLine("Fibonacci Number (n = 10): " + FibonacciUsingRecursion(10));
       
        
        
        
        // ▼ "Testing Cases" of "Fibonacci"
        //      → "Using Iteration" ▼
        Console.WriteLine("\nUsing Iteration");
        Console.WriteLine("Fibonacci Number (n = 0): " + FibonacciUsingIteration(0));
        Console.WriteLine("Fibonacci Number (n = 1): " + FibonacciUsingIteration(1));
        Console.WriteLine("Fibonacci Number (n = 2): " + FibonacciUsingIteration(2));
        Console.WriteLine("Fibonacci Number (n = 3): " + FibonacciUsingIteration(3));
        Console.WriteLine("Fibonacci Number (n = 4): " + FibonacciUsingIteration(4));
        Console.WriteLine("Fibonacci Number (n = 5): " + FibonacciUsingIteration(5));
        Console.WriteLine("Fibonacci Number (n = 6): " + FibonacciUsingIteration(6));
        Console.WriteLine("Fibonacci Number (n = 7): " + FibonacciUsingIteration(7));
        Console.WriteLine("Fibonacci Number (n = 8): " + FibonacciUsingIteration(8));
        Console.WriteLine("Fibonacci Number (n = 9): " + FibonacciUsingIteration(9));
        Console.WriteLine("Fibonacci Number (n = 10): " + FibonacciUsingIteration(10));

    }
}