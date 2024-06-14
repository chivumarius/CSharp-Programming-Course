/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "ALGORITHMS" •
            • "DYNAMIC PROGRAMMING & MEMORIZATION ALGORITHMS" •
            ───────────────────────────────────────────────────
                    • "KADONE" ALGORITHM •

       


    ▬ "Kadane" Algorithm 
        → is an E"fficient Method" 
        → for "Finding" 
        → the "Continuous Sub-Sequence" 
        → with "Maximum Sum" 
        → in a "Sequence" of "Numbers". 



        ♦ It "Iterates" 
            → through the "Sequence", 
            → "Continuously Updating" 
            → the "Current Sum" 
            → and the "Maximum Sum" 
            → of the "Sub-Sequence Found" so far. 



        ♦ The "Algorithm" has 
            ►• "Linear Time Complexity" 


        ♦ It is "Used" 
            → in a "Variety" of "Applications" 
            → such as: 
                • "Data Analysis" and 
                • "Algorithm Optimization".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "Kadone" Class ▬
public class Kadone
{
    // ▬ "KadoneAlgorithm()" Method ▬
    public static int KadoneAlgorithm(int[] inputArray)
    {
        // ▼ "Variables" ▼
        int length = inputArray.Length;
        int localMax = 0;
        int globalMax = int.MinValue;
        
        // ▼ "Loop" ▼
        for (int i = 0; i < length; i++)
        {
            // ▼ "Set" ▼
            localMax = Math.Max(inputArray[i], inputArray[i] + localMax);
            
            // ▼ "Check" ▼
            if(localMax > globalMax)
            {
                // ▼ "Set" ▼
                globalMax = localMax;
            }
        }
        
        // ▼ "Return" ▼
        return globalMax;
    }




    // ▬ "RunKadone()" Method ▬
    public static void RunKadone()
    {
        // ▼ "Array" ▼
        int[] exampleArray = { -3, -1, -3, 4, -1, 2, 1, -5, 4 };
        
        // ▼ "Print" ▼
        Console.WriteLine($"The 'Maximum Sum' of the 'Sub-Sequence' is: {KadoneAlgorithm(exampleArray)}");
    }
} 