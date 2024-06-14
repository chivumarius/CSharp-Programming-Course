/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                          • "ALGORITHMS" •
                    • "COMBINATORIAL ALGORITHM" •
                    ─────────────────────────────
                     • "M CHOOSE K" ALGORITHM •

       


    ▬  "N Choose K" Algorithms
        • How many ways can we choose k objects from a set of n objects
        • Problem of combinations
        • How many ways to pick 3 shirts out of 7
        • n! / (n - k)! k!


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "NChooseK" Class ▬
public class NChooseK
{
    // ▬ "NumberOfPossibleCombinations()" Method ▬
    public static int NumberOfPossibleCombinations(int n, int k)
    {
        // ▼ "Checking" the "Input Values" ▼
        if (k == 0 || k == n)
        {
            return 1;
        }
        else
        {
            // ▼ "Recursive Call" ▼
            return NumberOfPossibleCombinations(n - 1, k) + NumberOfPossibleCombinations(n - 1, k - 1);
        }
    }




    // ▬ "RunNChooseK()" Method ▬
    public static void RunNChooseK()
    {
        // ▼ "Input Values" ▼
        int n = 3;
        int k = 2;
        
        // ▼ "Output" ▼
        Console.WriteLine($"Number of 'Possible Combinations' for '{n} Objects' and '{k} Objects' to 'Choose From' is: {NumberOfPossibleCombinations(n, k)}");
    }
} 