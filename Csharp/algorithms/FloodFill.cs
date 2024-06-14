/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                        • "ALGORITHMS" •
            • "DYNAMIC PROGRAMMING & MEMORIZATION ALGORITHMS" •
            ───────────────────────────────────────────────────
                    • "FLOOD FILL" ALGORITHM •

       


    ▬ "Flood Fill" Algorithm 
        → is a "Technique" 
        → "Used" to "Fill" an "Area" 
        → of an "Image" 
        → or "Surface" 
        → in a "2D Data Structure". 



        ♦ It "Starts" 
            → from a "Start Point" 
            → and "Spreads" 
            → in "All Adjacent Directions", 
            → "Filling" Connected "Regions" 
            → that "Meet Certain Criteria", 
            → such as 
                • "Having" the "Same Color" 
                • or "Value" 
            → as the "Reference Point". 



        ♦ It is "Used" in : 
                • "Image Editors", 
                • "Computer Graphics Applications", 
            → and "Others" 
            → to perform "Color Fills" 
            → or to "Identify Connected Regions" 
            → within an "Image" 
            → or "2D Data Dtructure".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.algorithms;


//──────────────────────────────────────────────────────────────
// ▬ "FloodFill" Class ▬
public class FloodFill
{
    // ▼ "2D Array" of "ConsoleColor" ▼ 
    static ConsoleColor[,] pixels = new ConsoleColor[5, 5];    
    
    
    
    // ▬ "FloodFillAlgorithm()" Method ▬
    public static void FloodFillAlgorithm(int height, int width, int x, int y, ConsoleColor fill, ConsoleColor old)
    {
        // ▼ "Check" ▼
        if (x < 0 || x >= width) return;
        if (y < 0 || y >= height) return;

        if (pixels[x, y] == old)
        {
            // ▼ "Set" to "Fill" ▼
            pixels[x, y] = fill;
            
            // ▼ "Recursive Calls" ▼
            FloodFillAlgorithm(5, 5, x + 1, y, fill, old);
            FloodFillAlgorithm(5, 5, x, y+1, fill, old);
            FloodFillAlgorithm(5, 5, x - 1, y, fill, old);
            FloodFillAlgorithm(5, 5, x, y - 1, fill, old);
        }

    }


    
    // ▬ "PrintPixels()" Method ▬
    private static void PrintPixels(ConsoleColor[,] pixels)
    {
        for (int i = 0; i < pixels.GetLength(0); i++)
        {
            for (int j = 0; j < pixels.GetLength(1); j++)
            {
                Console.BackgroundColor = pixels[i, j];
                Console.Write("  ");
            }
            Console.WriteLine();
        }
        Console.ResetColor();
    }
    
    
    
    
    
    // ▬ "RunFloodFill()" Method ▬
    public static void RunFloodFill()
    {
        // Initialize a matrix of colors
        ConsoleColor[,] pixels = new ConsoleColor[5, 5]
        {
            { ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White },
            { ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White },
            { ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White },
            { ConsoleColor.White, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.Black, ConsoleColor.White },
            { ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White, ConsoleColor.White }
        };

        // Display the initial matrix
        Console.WriteLine("Initial Matrix:");
        PrintPixels(pixels);

        // Apply the Flood Fill algorithm
        FloodFillAlgorithm(5, 5, 2, 2, ConsoleColor.Red, ConsoleColor.Black);

        // Display the matrix after applying the Flood Fill algorithm
        Console.WriteLine("\nMatrix after applying the Flood Fill algorithm:");
        PrintPixels(pixels);
    }
} 