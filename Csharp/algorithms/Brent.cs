/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                           • "ALGORITHMS" •
                    • "CYCLE DETECTION ALGORITHMS" •
                    ────────────────────────────────
                     • "BRENT" ALGORITHM •

       


    ▬ "Brent" Algorithm 
        → is an Efficient Method 
        → for Detecting Cycles 
        → in "Circular Data Structures" 
        → such as: 
            •► "Linked Lists". 



        ♦ It "Relies" 
            → on "Two Pointers": 
                • the "Mouse" and 
                • the "Rabbit", 
            → which "Move" in "Different Ways" 
            → within the "Data Structure", 
            → "Detecting Cycles" 
            → when they "Meet". 



        ♦ It is "Used" 
            → in "Various Applications" 
            → due to its Favorable "Early Complexity" 
            → and "Efficiency" 
            → in "Cycle Detection".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;



//──────────────────────────────────────────────────────────────
// ▬ "Brent" Generic Class ▬
//──────────────────────────────────────────────────────────────
// ▬ "Brent" Generic Class ▬
public class Brent<T> where T : IEquatable<T>
{
    //▬ "FindCycles()" Method ▬
    public static Tuple<int, int> FindCycles(T x0, Func<T, T> yielder)
    {
        // ▼ "Variables" ▼
        int power = 1;          // ▼ Power of 2 ▼
        int lambda = 1;         // ▼ Length of cycle ▼
        int mu = 0;             // ▼ Position of cycle's start ▼
        
        T tortoise = x0;      // ▼ Slow mover ▼
        T hare = yielder(x0); // ▼ Fast mover ▼
        
        // ▼ "Loop" ▼
        while (!tortoise.Equals(hare))
        {
            // ▼ "Checking" ▼
            if (power == lambda)
            {
                // ▼ "Sets" ▼
                tortoise = hare;
                power *= 2;     // ▼ Doubling power of 2 ▼
                lambda = 0;
            }
            
            // ▼ "Sets" ▼
            hare = yielder(hare);
            lambda += 1;        // ▼ Incrementing lambda ▼
        }
        
        // ▼ "Sets" ▼
        tortoise = x0;
        hare = x0;
        
        // ▼ "Loop" ▼
        for(int j = 0; j < lambda; j++)
        {
            // ▼ "Set" ▼
            hare = yielder(hare);
        }
        
        // ▼ "Loop" ▼
        while (!tortoise.Equals(hare))
        {
            // ▼ "Sets" ▼
            tortoise = yielder(tortoise);
            hare = yielder(hare);
            mu += 1;            // ▼ Incrementing mu ▼
        }
        
        // ▼ "Return" ▼
        return new Tuple<int,int>(lambda, mu);
    }
}