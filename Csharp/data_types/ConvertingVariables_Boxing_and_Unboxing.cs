namespace CSharp.data_types;

public class ConvertingVariables_Boxing_and_Unboxing
{
    public static void ConvertingVariables()
    {
        // (1) "Implicit" Conversion 
        int a = 5;
        float b = a;  // ◄◄ "intNumber" → is "Implicitly Converted" to "float" ◄◄
        Console.WriteLine("Implicit Conversion: " + b);
        
        
        // (2) "Explicit" Conversion → using "Casting" (type)
        float c = 5.25f;
        int d = (int) c;  // ◄◄ Cast "(int)" → is "Explicitly Converted" to "int" ◄◄
        Console.WriteLine("Explicit Conversion: " + d);
        
        // (3) "User-Defined" Conversion
        // (4) "Conversion" with "Helper Class
    }

    
   
    public static void Boxing()
    {
        // ▼ "Boxing"
        //      → is the "Process" of "Converting"
        //      → a "Value" of "Type Value"
        //      → to a "Reference" of "Type Object" ▼
        int num = 1;
        object obj = num; // ◄◄ "Object" →  means "Any Type"
        Console.WriteLine("Boxing: " + obj);
    }

    
    public static void Unboxing()
    {
        // ▼ "Unboxing"
        //      → is the "Process" of "Converting"
        //      → a "Reference" of "Type Object"
        //      → to a "Value" of "Type Value" ▼
        object obj = 100;
        int num2 = (int) obj;
        Console.WriteLine("Unboxing: " + num2);
    }
    
    
    // (Nota Bene!)
    //  ♦ Both "Boxing" and "Unboxing"
    //          → are "Operations" that can "Affect Performance"
    //          → in some Situations
    //          → due to their "Cost".
}