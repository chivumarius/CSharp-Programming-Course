/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "LINQ - LANGUAGE INTEGRATED QUERY" •
                    ──────────────────────────────────────
                        • "CAST" OPERATOR IN "LINQ" •

       


    ▬ "()"/".Cast()" Operator in "LINQ"
        → will "Cast" Each "Element" 
        → of the "Sequence" 
        → to "Another Type"

 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.linq;


//──────────────────────────────────────────────────────────────
// ▬ "CastOperator" Class ▬
//──────────────────────────────────────────────────────────────
// ▬ "CastOperator" Class ▬
public class CastOperator
{
    // ▬ "RunCastOperator()" Method ▬
    public static void RunCastOperator()
    {
        // ▼ "Creating" a "List" of "Integers" ▼
        List<int> intCollection = new List<int> { 1, 2, 3, 4, 5};
    
        
        //--------------------- "CAST" OPERATOR -------------------------
        // ▼ "Creating" an "IEnumerable" of "Floats"
        //     → to "Cast"/"Convert" each "Integer"
        //     → to a "Float" ▼
        IEnumerable<float> floatCollection = intCollection.Select(i => (float) i);

        
        // ▼ "Printing" the "List" of "Floats" ▼
        Console.Write("Integer Collection -> Converted into Float Collection: ");
        foreach (var item in floatCollection)
        {
            Console.Write(item + ", ");
        }
        
        
        Console.WriteLine();
    }
}