using System;


namespace CSharp.data_types
{
    internal class IntegerDataType
    {
        public static void IntegerType() 
        {

            int i = 0;
            i = 5;
            Console.WriteLine("Integer: " + i);
            Console.WriteLine("Post-Incrementation: " + i++);
            Console.WriteLine("Pre-Incrementation: " + ++i);
                      
            
            Console.WriteLine("Post-Decrementation: " + i--);
            Console.WriteLine("Pre-Decrementation: " + --i);


            Console.WriteLine("Substraction (10 - 1): " + (10 - 1));
            Console.WriteLine("Adding (2 + 3): " + (2 + 3));
            
            Console.WriteLine("Multiplication (8 * 2): " + (8 * 2));
            Console.WriteLine("Division (10 / 2): " + (10 / 2));
            Console.WriteLine("Remainder of Divisions (8 / 3): " + (8 % 3));




        }   

    }
}
