using System;


namespace CSharp.data_types
{
    internal class MathClass
    {
        public static void MathMethod()
        {
           
            Console.WriteLine("\n" + "--------------- Math Class ---------------");
            
            // ▼ "Absolut Value" ▼
            Console.WriteLine("Absolut Value of -3: " + Math.Abs(-3));
            Console.WriteLine("Absolut Value of -8.75f: " + Math.Abs(-8.75f));


            // ▼ "Rounding Up/Down" the "Number" → using "Math.Round()" Method ▼
            Console.WriteLine("Rounding Up the Number 8.75f: " + Math.Round(8.75f));
            Console.WriteLine("Rounding Down the Number 8.25f: " + Math.Round(8.25f) + "\n");


            // ▼ "Rounding Up" the "Number" → using "Math.Ceiling()" Method ▼`
            Console.WriteLine("Rounding Up the Number 9.25f: " + Math.Ceiling(9.25f));


            // ▼ "Rounding Down" the "Number" → using "Math.Floor()" Method ▼`
            Console.WriteLine("Rounding Down the Number 9.75f: " + Math.Floor(9.75f));

            
            // ▼ "Rounding Down" the "Number" → using "Math.Truncate()" Method ▼`
            Console.WriteLine("Rounding Down the Number 8.95f: " + Math.Truncate(8.95f) + "\n");




            // ▼ "Minimum Value" of "2 Numbers" → using "Math.Min()" Method ▼`
            Console.WriteLine("Minimum Value of 2 Numbers 6, 7: " + Math.Min(6, 7));


            // ▼ "Maximum Value" of "2 Numbers" → using "Math.Max()" Method ▼`
            Console.WriteLine("Maximum Value of 2 Numbers 6, 7: " + Math.Max(6, 7));

        }
    }
}
