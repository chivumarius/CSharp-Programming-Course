namespace CSharp.control_flow_statements_and_loops;

public class Switch_Statement
{
    public static void SwitchStatement()
    {
        
        // ▼ "Switch" Statement
        //      → "Mast" be "Used"
        //      → when we have "More" then "3 Conditions" ▼
        int value = 2;
        
        switch (value)
        {
            case 1:
                Console.WriteLine("Value is 1");
                break;
            
            case 2:
                Console.WriteLine("Value is 2");
                break;
            
            case 3:
                Console.WriteLine("Value is 3");
                break;
            
            case 4:
                Console.WriteLine("Value is 4");
                break;
            
            case 5:
                Console.WriteLine("Value is 5");
                break;
            
            case 6:
                Console.WriteLine("Value is 6");
                break;
            
            case 7:
                Console.WriteLine("Value is 7");
                break;
            
            case 8:
                Console.WriteLine("Value is 8");
                break;
            
            case 9:
                Console.WriteLine("Value is 9");
                break;
            
            case 10:
                Console.WriteLine("Value is 10");
                break;
            
            default:
                Console.WriteLine("Value is not between 1 and 10");
                break;
        }
        
        
        
        //---------------------------------------------------------
        // ▼ "Example" of "Displaying"
        //      → the "Day" of the "Week" ▼
        Console.WriteLine("\nDay of the Week:");
        int day = 4;
        
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
                
            case 2:
                Console.WriteLine("Tuesday");
                break;
            
            case 3:
                Console.WriteLine("Wednesday");
                break;
            
            case 4:
                Console.WriteLine("Thursday");
                break;
            
            case 5:
                Console.WriteLine("Friday");
                break;
            
            case 6:
                Console.WriteLine("Saturday");
                break;
            
            case 7:
                Console.WriteLine("Sunday");
                break;
        }
    }
}