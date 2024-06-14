/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "OPTIMIZATION" •
                    ────────────────
                     • "TECHNIQUES" •

       


 Recommendations:

    (1) "Use" of "for()" Loop 
            → Instead of the "foreach()" Loop 
            → because "It" is "Faster".



    (2) "Use" of "Structs" 
        → instead of "Classes"

        ♦ "Structs" 
            → are "Value Type"
            → and "More Efficient" for "Simple Data" 
            → and "Passing" as "Parameters" 
            → in "Methods".
        
        
        ♦ "Classes" 
            → are "Reference Type"
            → and "Better" for "Complex Objects" 
            → and C"ode Reuse".



    (3) Use "StringBuilder" 
        → for "String Concatenation" Operations.
        
       
 
    (4) Use "Variables" 
        → "Instead" of "Properties"  
        


    (5) Uae "string.Compare()"
        → "Instead" of "string.ToUpper()"
        → or "string.ToLower()" Case.  



    (6) Uae "List<>"
        → "Instead" of "ArrayList<>".  



    (7) Uae "&&" or "||" Operators
        → "Instead" of "&" or "|".  
               
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

using System.Diagnostics;
using System.Text;

namespace CSharp.optimization;


//──────────────────────────────────────────────────────────────
// ▬ "OptimizationTechniques" Class ▬
public class OptimizationTechniques
{
    // ------------------------------------------------------------------
    // (1) Using "for()" Loop Instead of "foreach()" Loop
    // ------------------------------------------------------------------
    //     ▬ "ForLoop()" Method ▬
    public static void ForLoop()
    {
        // ▼ "Lists" ▼
        List<int> elements = new List<int>();
        List<int> list = new List<int>(); 
        
        
        // ▼ "For Loop" to "Add Elements" into "List" ▼
        for (int i = 0; i < 20000; i++)
        {
            elements.Add(i);
        }
        
        
        // ▼ Creating "Stopwatch" Object
        //     → to "See" the "Time Execution"
        //     → of "For Loop" ▼
        Stopwatch stopwatch = new Stopwatch();
        
        // ▼ "Start" the "Stopwatch" ▼
        stopwatch.Start(); 
        
        
        
        // ▼ "For" Loop
        //      → to "Add Elements" into "List 1" ▼
        for(int i = 0; i < elements.Count; i++)
        {
            list.Add(i);
        }
        
        // ▼ "Stop" the "Stopwatch" ▼
        stopwatch.Stop();
        
        // ▼ "Print" the "Time Execution" of "For Loop" ▼
        Console.WriteLine($" - The 'Execution Time' of 'For Loop' - that 'Iterates' from '0' to '20 000' is: {stopwatch.Elapsed}");
    }
    
    
    
    
    //     ▬ "ForEachLoop()" Method ▬
    public static void ForEachLoop()
    {
        // ▼ "List" Initialization ▼
        List<int> elements = new List<int>();
        List<int> list = new List<int>(); 

        // ▼ "For Loop" to "Add Elements" into "List" ▼
        for (int i = 0; i < 20000; i++)
        {
            elements.Add(i);
        }

        // ▼ Creating "Stopwatch" Object
        //     → to "See" the "Time Execution"
        //     → of "Foreach Loop" ▼
        Stopwatch stopwatch = new Stopwatch();

        // ▼ "Start" the "Stopwatch" ▼
        stopwatch.Start(); 

        // ▼ "Foreach" Loop
        //      → to "Add Elements" into "List" ▼
        foreach(int element in elements)
        {
            list.Add(element);
        }

        // ▼ "Stop" the "Stopwatch" ▼
        stopwatch.Stop();

        // ▼ "Print" the "Time Execution" of "Foreach Loop" ▼
        Console.WriteLine($" - The 'Execution Time' of 'Foreach Loop' - that 'Iterates' from '0' to '20,000' is: {stopwatch.Elapsed}");
    }
    
    
    
    
    // ------------------------------------------------------------------
    // (2) Using "Struct" → Instead of "Classes"
    // ------------------------------------------------------------------
    // ▼ "Creating" a "Struct" ▼
    public struct Struct1
    {
        public string String1;
        public string String2;
    }
    
    
    // ▬ "MyStruct()" Method ▬
    public static void MyStruct()
    {
        // ▼ "Array" Initialization ▼
        Struct1[] objStruct = new Struct1[10000];
        
        
        // ▼ Creating "Stopwatch" Object
        //     → to "See" the "Time Execution"
        //     → of "For Loop" ▼
        Stopwatch stopwatch = new Stopwatch();
        
        // ▼ "Start" the "Stopwatch" ▼
        stopwatch.Start();


        // ▼ "Struct" Initialization ▼
        for(int i = 0; i < objStruct.Length; i++)
        {
            objStruct[i] = new Struct1();
            
            // ▼ "String" Initialization ▼
            objStruct[i].String1 = "Hello";
            objStruct[i].String2 = "World";
        }
        
        // ▼ "Stop" the "Stopwatch" ▼
        stopwatch.Stop();

        // ▼ "Print" the "Time Execution" of "For Loop" ▼
        Console.WriteLine($" - The 'Execution Time' of 'Struct Initialization' - that 'Iterates' from '0' to '10,000' is: {stopwatch.Elapsed}");
    }

    
    

    // ▬▬ "MyClass" Class ▬▬
    class MyClass
    {
        // ▼ "Variables" ▼
        public string String1;
        public string String2;
    }
    
    
    // ▬ "ClassMethod()" Method ▬
    public static void ClassMethod()
    {
        // ▼ "Array" Initialization ▼
        MyClass[] objClass = new MyClass[10000];
        
        
        // ▼ Creating "Stopwatch" Object
        //     → to "See" the "Time Execution"
        //     → of "For Loop" ▼
        Stopwatch stopwatch = new Stopwatch();
        
        // ▼ "Start" the "Stopwatch" ▼
        stopwatch.Start(); 
        
        
        // ▼ "Class" Initialization ▼
        for(int i = 0; i < objClass.Length; i++)
        {
            // ▼ "Set" the "objClass" Object ▼
            objClass[i] = new MyClass();
            
            // ▼ "String" Initialization ▼
            objClass[i].String1 = "Hello";
            objClass[i].String2 = "World";
        }
        
        
        // ▼ "Stop" the "Stopwatch" ▼
        stopwatch.Stop();
        
        // ▼ "Print" the "Time Execution" of "For Loop" ▼
        Console.WriteLine($" - The 'Execution Time' of 'Class Initialization' - that 'Iterates' from '0' to '10,000' is: {stopwatch.Elapsed}");
    }
    
    
    
    
    
    
    // ------------------------------------------------------------------
    // (3) Using "StringBuilder" for "String Concatenation" Operations
    // ------------------------------------------------------------------
    // ▬ "MyStringBuilder()" Method ▬
    public static void MyStringBuilder()
    {
        // ▼ "Variables" ▼
        string s = "abc";
        
        // ▼ "StringBuilder" Object ▼
        StringBuilder sb = new StringBuilder("abc");
        
        
        // ▼ Creating "Stopwatch" Object
        //     → to "See" the "Time Execution"
        //     → of "For Loop" ▼
        Stopwatch stopwatch = new Stopwatch();
        
        // ▼ "Start" the "Stopwatch" ▼
        stopwatch.Start(); 

        
        // ▼ "Looping" ▼
        for(int i = 0; i < 1000; i++)
        {
            s = s + "abc";
        }
        
        
        // ▼ "Stop" the "Stopwatch" ▼
        stopwatch.Stop();
        
        // ▼ "Print" the "Time Execution" of "For Loop" ▼
        Console.WriteLine($" - The 'Execution Time' of 'StringBuilder' - that 'Iterates' from '0' to '1000' is: {stopwatch.Elapsed}");
        
        
        
        // ▼ "Restart" the "Stopwatch" ▼
        stopwatch.Restart();
        
        // ▼ "Looping" ▼
        for(int i = 0; i < 1000; i++)
        {
            sb.Append("abc");
        }
        
        
        // ▼ "Stop" the "Stopwatch" ▼
        stopwatch.Stop();
        
        // ▼ "Print" the "Time Execution" of "For Loop" ▼
        Console.WriteLine($" - The 'Execution Time' of 'StringBuilder Append' (2nd Time) - that 'Iterates' from '0' to '1000' is: {stopwatch.Elapsed}");
    }

    


    
    
    // ------------------------------------------------------------------
    // (4) Using "Variables" → "Instead" of "Properties"
    // ------------------------------------------------------------------
    // ▬▬ "VariablesAndProperties" Class ▬▬
    class VariablesAndProperties
    {
        // ▼ "Property" ▼
        public static string Property{ get; set; }
        
        // ▼ "Variables" ▼
        public static string Variable;
        
        
        
        // ▬ "VariablesAndPropertiesEfficiency()" Method ▬
        public static void VariablesAndPropertiesEfficiency()
        {
            // ▼ Creating "Stopwatch" Object
            //     → to "See" the "Time Execution"
            //     → of "For Loop" ▼
            Stopwatch stopwatch = new Stopwatch();
        
            // ▼ "Start" the "Stopwatch" ▼
            stopwatch.Start(); 
        
            // ▼ "Iterating" ▼
            for(int i = 0; i < 100; i++)
            {
                // ▼ "Set" the "Class2" Property ▼
                VariablesAndProperties.Property = "Hello";
            }
        
            // ▼ "Stop" the "Stopwatch" ▼
            stopwatch.Stop();
        
            // ▼ "Print" the "Time Execution" of "For Loop" ▼
            Console.WriteLine($" - The 'Execution Time' of 'Class2 Properties' - that 'Iterates' from '0' to '100' is: {stopwatch.Elapsed}");
        
        
            // ▼ "Restart" the "Stopwatch" ▼
            stopwatch.Restart();
        
            // ▼ "Iterating" ▼
            for(int i = 0; i < 100; i++)
            {
                // ▼ "Set" the "Class2" Variable ▼
                VariablesAndProperties.Variable = "Hello";
            }
        
            // ▼ "Stop" the "Stopwatch" ▼
            stopwatch.Stop();
        
            // ▼ "Print" the "Time Execution" of "For Loop" ▼
            Console.WriteLine($" - The 'Execution Time' of 'Class2 Variables' - that 'Iterates' from '0' to '100' is: {stopwatch.Elapsed}");
        }
    }
    
    
    




    // ▬ "RunOptimizationTechniques()" Method ▬
    public static void RunOptimizationTechniques()
    {
       // ------------------------------------------------------------------
       // (1) Using "For Loop" -> "Instead" of "ForEach Loop"
       Console.WriteLine("(1) Use 'For Loop' -> 'Instead' of 'Foreach Loop':");
       ForLoop();
       ForEachLoop();
       
       
       
       
       // ------------------------------------------------------------------
       // (2) Using "Struct" Instead of "Classes"
       Console.WriteLine("\n(2) Use 'Struct' -> 'Instead' of 'Class':");
       MyStruct();
       ClassMethod();
       
       
       
       // ------------------------------------------------------------------
       // (3) Using "StringBuilder" for "String Concatenation" Operations
       Console.WriteLine("\n(3) Use 'StringBuilder' -> 'For' 'String Concatenation':");
       MyStringBuilder();
       
       
       
       
       // ------------------------------------------------------------------
       // (4) Using "Variables" -> "Instead" of "Properties"
       Console.WriteLine("\n(4) Use 'Variables' -> 'Instead' of 'Properties':");
       VariablesAndProperties.VariablesAndPropertiesEfficiency();
    }
} 