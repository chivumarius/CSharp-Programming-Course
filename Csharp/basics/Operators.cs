namespace CSharp.basics;

public class Operators
{
    // ▬ (1) The "Modulus Operator" ("Remainder") ("%") ▬
    public static void Modulus()
    {
        Console.WriteLine("Modulus Operator: " + (5 % 4));
    }




    // ▬ (2-1) The "Increment Operator" ("++") ▬
    public static void Increment()
    {
        int number = 9;
        number++;
        Console.WriteLine("Increment Operator: " + number);
    }




    // ▬ (2-2) The "InDecrement Operator" ("--") ▬
    public static void Decrement()
    {
        int number = 9;
        number--;
        Console.WriteLine("Decrement Operator: " + number);
    }




    // ▬ (3) The "Is Operator" ("is") ▬
    public static void IsOfType()
    {
        bool a = "abc" is string;
        bool b = "123" is int;

        Console.WriteLine("Is Operator for String: " + a);
        Console.WriteLine("Is Operator for Int: " + b);
    }




    // ▬ (4) The "As Operator" ("as") ▬
    public static void AsTypeCasting()
    {
        string s1 = "A string.."; 
        object obj1 = s1;
        string s2 = obj1 as string;  // ◄ "Type Casting"

        Console.WriteLine("As Operator for Type Casting: " + s2);           
    }




    // ▬ (5) The "Ternary/Conditional Operator"  ("Condition ? True : False")  ▬
    public static void TernaryOrConditional()
    {
        
        int x = 10;
        int value = 5;


        // "Ternary Operator" = (Condition) ? True : False  
        bool isGreater = (x > value) ? true : false;   // ◄ "var" → indicates "Any Data Type" for the "Variable"
        
        
        
        // ▼ "Replace" this "Form": ▼
        // if(x e) {
        //     isGreater = true;
        // }
        // else
        // {
        //     isGreater = false;
        // }


        Console.WriteLine("Ternary/Conditional Operator: " + isGreater);             
    }




    // ▬ (6) The "Null-Coalescing Operator"  (True ?? False")  ▬
    public static void NullCoalescing()
    {                        
        
        object obj1 = null;   
        
        // ▼ "Null-Coalescing Operator"  (True ?? False") ▼
        object obj2 = obj1 ?? new object();
    
        Console.WriteLine("Null-Coalescing Operator: " + obj2);             
    }




    // ▬ (7) The "sizeof Operator" → that "Provides" the "Size" in "Bytes"  ▬
    public static void SizeOf()
    {                      
        // ▼ Te "Size" of "Data Type" ▼
        Console.WriteLine("Size Of Operator: " + sizeof(char));             
    }



    
    // ▬ (8) The "typeof Operator" → that "Provides" the "System.Type" Object for a "Data Type" ▬
    public static void TypeOf()
    {                      
        // ▼ The "Size" of "Data Type" ▼
        Console.WriteLine("Type Of Operator: " + typeof(int));             
    }
}






 // ▬ The "Box" Class with the "Overloading Operator" ▬ 
 class Box {
    
    // ▼ "Properties" ("Class Members Variables") ▼
    private int length;
    private int width;
    private int height;



    // ▬ "Constructor" with "Arguments" ▼
    public Box(int length, int width, int height){
        // ►► this.Property =  Constructor_Argument ◄◄
        this.length = length;
        this.width = width;
        this.height = height;
    }


    // ▬ "Getter" → for "Length" Private Property ▬
    private int GetLength(){
        return length;
    }




    // ▬ "Getter" → for "Width" Private Property ▬
    private int GetWidth(){
        return width;
    }




    // ▬ "Getter" → for "Height" Private Property ▬
    private int GetHeight(){
        return height;
    }



    // ▬ (9) The "Overloading Operator" (operator +Symbol) to "Add 2 Box" Objects ▬
    public static Box operator +(Box box1, Box box2) {
        
        return new Box( 
            box1.GetLength() + box2.GetLength(),
            box1.GetWidth() + box2.GetWidth(),
            box1.GetHeight() + box2.GetHeight()
        );
    }   
 }







