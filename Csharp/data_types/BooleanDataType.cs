namespace CSharp.data_types;

public class BooleanDataType
{
    public static void BooleanType()
    {
        // ▼ "Boolean Type Values"  ▼
        bool boolean1 = true;
        bool boolean2 = false;
        
        bool? boolean3 = null;  // ◄◄ "?": Allows Store "Null" Values ◄◄
        
        Console.WriteLine("Boolean \"True\" Value: " + boolean1);
        Console.WriteLine("Boolean \"False\" Value: " + boolean2);
        Console.WriteLine("Boolean \"Null\" Value: " + boolean3);
                
        
        
        
        // ▼ "Logical Operators" ▼
        Console.WriteLine("\n-------------------- LOGICAL OPERATORS --------------------");
        Console.WriteLine("-------------------- NOT (!) OPERATOR --------------------");
        bool completed = false;
        Console.WriteLine("Not (!) → Return the Opposite Value: " + !completed);

        
        // ▼ "AND (&) Logical Operators" ▼  
        Console.WriteLine("\n-------------------- AND (&) OPERATOR --------------------");
        bool incomplete = true;
        Console.WriteLine("And (&) → Return the Value if Both are True: " + (completed & incomplete));
        
        Console.WriteLine("-------------------- AND (&&) LOGICAL CONDITIONAL OPERATOR --------------------");
        Console.WriteLine("And (&&) → In witch if the First Value is Checked, the Second Value wil Not be Checked: " + (completed && incomplete));
        
        
        // ▼ "AND Compound Assignment Operator" (&=)  ▼
        //      → which does an "AND" Operation
        //      → between the "Left Operand"
        //      → and the "Right Operand"
        //      → and "Assigns"
        //      → the "Result Back"
        //      → to the "Left Operand".
        Console.WriteLine("-------------------- AND COMPOUND ASSIGNMENT OPERATOR (&=) --------------------");
        bool myExample = true;
        myExample &= true;  
        
        Console.WriteLine("AND Compound Assignment Operator (&=): " + myExample);
        
        
        
        
        
        // ▼ "OR (|) Logical Operators" ▼
        Console.WriteLine("\n-------------------- OR (|) OPERATOR --------------------");
        Console.WriteLine("Or (|) → Return the Value if One is True: " + (completed | incomplete));
        
        // ▼ "OR (||) Conditional Logical Operators" ▼
        Console.WriteLine("-------------------- OR (||) LOGICAL CONDITIONAL OPERATOR --------------------");
        Console.WriteLine("Or (||) → In witch if the First Value is Checked, the Second Value wil Not be Checked: " + (completed || incomplete));
        
        
        
        
        
        // ▼ "Boolean Flag Technique" ▼
        Console.WriteLine("\n-------------------- BOOLEAN FLAG TECHNIQUE --------------------");
        
        bool flag = false;
        List<int> intList = new List<int>(){1, 2, 3, 4, 5};

        // ▼ "Iterate" & "Check"
        //      → if "There Is" a "Value"
        //      → in the "List" ▼
        foreach (int i in intList)
        {
           if(i == 3){
               flag = true;
           }
        }

        if (flag)
        {
            Console.WriteLine("Is \"3\" Inside of the List: " + flag);
        }
    }
} 