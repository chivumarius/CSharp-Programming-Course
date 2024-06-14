namespace CSharp.control_flow_statements_and_loops;

public class For_Loop
{
    public static void ForLoop()
    {
        /*
            ♦ For Loop
                → allows us to "Execute Block" of "Code"
                → Multiple Times
                → when we "Know" the "Number" 
                → of "Needed Iterations".
            
            
            ♦ For Loop
                → Iterate "Forward" and "Backward"
            
            
            ♦ Syntax:
                for (Start; End; Increment/Decrement)
                {
                    Code To Be Executed Multiple Times;
                }         
         */
        
        
        // ▼ (Ex. 1) - "Displaying" a "Message" → 5 Times ▼
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Message " + i);
        }
        
        
        Console.WriteLine("\n");
        
        
        // ▼ (Ex. 2-1) - Displaying the "Letters" of a "String" in "Order" ▼
        string str = "Hello";
        
        for (int i = 0; i < str.Length; i++)
        {
            Console.WriteLine("The " + (i+1) + " Letter of String is: " + str[i]);
        }
        
        
        Console.WriteLine("\n");
        
        
        // ▼ (Ex. 2-2) - Displaying the "Letters" of a "String" in "Reverse Order" ▼
        for(int i = str.Length - 1; i >= 0; i--)
        {
            Console.WriteLine("The " + (i+1) + " Letter of String is: " + str[i]);
        }
        
        
        
        Console.WriteLine("\n");
        
       
         
        // ▼ (Ex. 3) - "Nest For" Loop ▼
        Console.WriteLine("\n\"Nest For\" Loop: ");
        
        for (int i = 1; i < 3; i++)
        {
            for (int j = 1; j < 3; j++)
            {
                Console.WriteLine("i = " + i + ", " + "j = " + j);
            }
        }
        
        
        
        Console.WriteLine("\n");
        
        
         
        // ▼ (Ex. 4) - "Infinite For" Loop with "Break" Statement ▼
        Console.WriteLine("\n\"Infinite For\" Loop with \"Break\" Statement:");
        
        // int iter = 1;  // ◄ "i": comes from the "iteration" ◄◄
        //
        // for(;;)
        // {
        //     // Console.WriteLine("Infinite Loop");
        //     
        //     // ▼ "Break" Statement for "Infinite For" Loop ▼
        //     if (iter < 6)
        //     {
        //         Console.WriteLine(iter.ToString());
        //         iter++;
        //     }
        // }
        
        
        
        
        Console.WriteLine("\n");
        
        
        //--------------------------------------------------------------------------------------
        /*
            ♦ "Exercise" 
                → Use a "For" Loop
                → to "Add All" the "Numbers" 
                → from 1 to 100.
            
            ♦ Print out the "Sum" to the Console.
         */
        Console.WriteLine("Exercise \"For\" Loop - Sum of Numbers from 1 to 100:");
        
        int sum = 0;
        
        for (int i = 1; i <= 100; i++)
        {
            sum += i;
        }
        
        Console.WriteLine("The Sum of Numbers from 1 to 100 is: " + sum);
    }
}