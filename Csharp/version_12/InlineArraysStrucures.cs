/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 12.0" (2023) •
                    ──────────────────────
                • "INLINE ARRAYS STRUCTURES" •

       


    ▬ "InlineArrays Structures" in "C# 12" ("2023")
        → are "Used" to "Specify"
        → that a "Small Array"
        → should be "Treated"
        → as if "It Eere Inline",
        → so it should be "Placed Directly"
        → on the "Stack Memory"
        → without "Allocating Memory"
        → on the "Heap".



    ▬ "See":
        •► https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-12
  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_12;

using System.Runtime.CompilerServices;

//──────────────────────────────────────────────────────────────
// ▬ "InlineArrays" Class ▬
public class InlineArraysStrucures
{
    // ▼ "Defining" the "Structure"
    //      → with an "Inline Array" of "3 Elements" ▼
    [InlineArray(3)]
    public struct Example
    {
        private int exampleArray;

        public int this[int index]
        {
            get { return Unsafe.Add(ref exampleArray, index); }
            set { Unsafe.Add(ref exampleArray, index) = value; }
        }
    }

    // ▬ "RunInlineArraysStrucures()" Method
    //      → to "Demonstrate" the "Use"
    //      → of the "Inline Array" ▬
    public static void RunInlineArraysStrucures()
    {
        // ▼ "Initialize" the "Example" Structure ▼
        Example example = new Example();

        // ▼ "Iterating" through the "Array"
        //      → and "Assigning" the "Values" ▼
        for (int i = 0; i < 3; i++)
        {
            example[i] = i;
        }

        // ▼ "Display" an "Array Element" ▼
        Console.WriteLine(example[2]);
    }
}
