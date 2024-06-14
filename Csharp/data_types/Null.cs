namespace CSharp.data_types;

public class Null
{
    public static void NullValueType()
    {
        // ▼ "Null"
        //      → means that a "Variable"
        //      → "Doesn't Have" a "Value" ▼
        Object obj = null;
        
        bool? isNull = null; // ◄◄ "?": Allow us to "Store" a "Null" Value ◄◄ 
        int? number = null;
        float? number2 = null;
        char? character = null;
        string? name = null;
        
        Console.WriteLine("-------------------- NULL VALUE -------------------");
        Console.WriteLine("Object Null Value: " + obj);
        Console.WriteLine("Boolean Null Value: " + isNull);
        Console.WriteLine("Integer Null Value: " + number);
        Console.WriteLine("Float Null Value: " + number2);
        Console.WriteLine("Character Null Value: " + character);
        Console.WriteLine("String Null Value: " + name);
    }
}