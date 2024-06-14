namespace CSharp.data_types;

public class Strings_Validation_Using_IsNullOrEmpty
{
    public static void StringValidationUsingIsNullOrEmpty()
    {
        // ▼ "Empty" String ▼
        string emptyString1 = "";  
        string emptyString2 = string.Empty;
        
        // ▼ "Not Empty" String ▼
        string notEmptyString = "Marius";
        
        // ▼ "Null" String ▼
        string nullString = null;
        
        
        // Using "IsNullOrEmpty()" Method ▼
        Console.WriteLine("IsNullOrEmpty() Method: " + string.IsNullOrEmpty(emptyString1));
        Console.WriteLine("IsNullOrEmpty() Method: " + string.IsNullOrEmpty(emptyString2));
        Console.WriteLine("IsNullOrEmpty() Method: " + string.IsNullOrEmpty(notEmptyString));
        Console.WriteLine("IsNullOrEmpty() Method: " + string.IsNullOrEmpty(nullString));
    }
}