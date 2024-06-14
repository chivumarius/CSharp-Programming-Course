namespace CSharp.data_types;

public class Value_and_Reference_DataTypes
{
    
    // ▬ "Value" Types
    //      → directly "Store"
    //      → their "Value"
    //      → in "Memory Locations"
    //      → on the "Stack".

    //   ♦ When you "Assign" or "Pass"
    //      → a "Value" Data Type "Variable"
    //      → to "Another Variable" or "Function",
    //      → it "Copies" the "Actual Data Value"
    //      → "Instead" of "Passing" a "Reference"
    //      → to the "Memory Location" ♦
    
    /*
        ♦ Example of "Value" Types:
            - bool
            - byte
            - char
            - decimal
            - double
            - enum
            - float
            - int
            - long
            - sbyte
            - short
            - struct
            - uint
            - ulong
            - ushort
     */
    public static void ValueDataTypes()
    {
        Console.WriteLine("------------------- VALUE DATA TYPES -------------------");
        
        // ▼ "Create" a "Variable" ▼
        int i = 5;
        
        // ▼ "Print" the "Value" ▼
        Console.WriteLine(i);
        
        // ▼ Passing the "Value" to the "Function" ▼
        ChangeValue(i);
        
        // ▼ "Print" the "Value" ▼
        Console.WriteLine(i);
    }
    
    public static void ChangeValue(int number)
    {
        number = 10;
        Console.WriteLine(number);
    }



    
    
    
    // ▬ "Reference"/ "Address" Types
    //      → "Store" a "Reference"
    //      → to the "Actual Location"
    //      → of the "Data" in "Memory" ▬

    //   ♦ "Reference Variables"
    //      → do Not "Directly Store"
    //      → their "Value",
    //      → they "Contain" the "Address" (or "Reference")
    //      → to the "Memory Location"
    //      → where the "Actual Data"
    //      → is "Stored" ♣
    
    /*
        ♦ Example of "Reference" Types:
            - String
            - Arrays (even if their elements are value types)
            - Class
            - Delegate
     */
    public static void ReferenceDataTypes()
    {
        Console.WriteLine("------------------- REFERENCE DATA TYPES -------------------");
        
        // ▼ "Create" a "Pbject"/"Instance" of a "Person" Class ▼
        Person person1 = new Person();
        
        // ▼ "Assign" a "Value" to the "Property" ▼
        person1.Name = "Old Name";
        
        // ▼ "Call" the "Method" ▼
        ChangeReferenceType(person1);
        
        // ▼ "Print" the "Value" ▼
        Console.WriteLine( "Reference Type: " + person1.Name);
    }
    
    
    
    
    // ▬ "Class" Reference Type ▬
    public class Person
    {
        // ▼ "Properties" ▼
        public string Name;
    }
    
    
    // ▬ "Method" Reference Type ▬
    public static void ChangeReferenceType(Person person)
    {
        // ▼ "Assign" a "Value" to the "Property" ▼
        person.Name = "New Name";
    }
}