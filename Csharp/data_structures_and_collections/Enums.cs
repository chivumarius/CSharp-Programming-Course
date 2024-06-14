/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "DATA STRUCTURES" & "COLLECTIONS" •
                    ─────────────────────────────────────
                            • "ENUMS" •

       

    ▬  "Enum" ("Enumeration") 
        → is a "Set" of "Named Constants".
        
        
        ♦ "Defined"
            → by "enum" Keyword. 
    
        
        ♦ It is a "Value" Data Type, 
            → and it is an "Integer".
        
        
    ▬  "Enum" is "Used"
        → to give a "Name" to "Eache Constants"
        → so that the "Constant Integers" 
        → can do refer to by "Name".
    
    
    ▬ By "Default" 
        → the "First Number" 
        → of the "Enum"
        → has the Value Zero
           
 ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

namespace CSharp.data_structures_and_collections;

public class Enums
{
    // ▼ "Enumeration" ▼
    enum Weekdays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    };
    
    
    // ▼ "Static Variable" ▼
    static Weekdays dayOfTheWeek = Weekdays.Monday; 



    // ▼ "Setting" a "Value" for the "Weekdays2" Enum ▼
    enum Weekdays2
    {
        Monday = 5,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday, 
        Sunday
    };
    
    
    
    
  
    
    // ▬ "RunStacks()" Method ▬
    public static void RunEnums()
    {
        Console.WriteLine("\nThe Days of Weekdays2 ");
        
        // ▼ "Get" the "Name" of the "Weekdays" Enum ▼
        foreach (string s in Enum.GetNames(typeof(Weekdays2)))
        {
            Console.WriteLine(s);
        }
        
        
        // ▼ "Get" the "Value" of the "Weekdays" Enum ▼
        Console.WriteLine(
            "\nGet the Value of the Weekdays Enum (1) : " +
            Enum.GetName(typeof(Weekdays), 1)
        );



        // ▼ "Get" the "Value" of the "Weekdays2" Enum ▼
        Console.WriteLine(
            "Get the Initialized Value of the Weekdays2 Enum (10) : " +
            Enum.GetName(typeof(Weekdays2), 10)
        );

        
        
        Console.WriteLine("\nGetting the Initialized Values of Weekdays2: ");

        // ▼ "Get" the "Values" of the "Weekdays2" Enum ▼
        foreach (int i in Enum.GetValues(typeof(Weekdays2)))
        {
            Console.WriteLine(i);
        }
        
        
        Console.WriteLine("\nWeekdays with Switch Statement: ");
        
        // ▼ "Switch" Statement ▼
        switch (dayOfTheWeek)
        {   
            case Weekdays.Monday:
                Console.WriteLine("Monday");
                break;
            
            case Weekdays.Tuesday:
                Console.WriteLine("Tuesday");
                break;
            
            case Weekdays.Wednesday:
                Console.WriteLine("Wednesday");
                break;
            
            case Weekdays.Thursday:
                Console.WriteLine("Thursday");
                break;
            
            case Weekdays.Friday:
                Console.WriteLine("Friday");
                break;
            
            case Weekdays.Saturday:
                Console.WriteLine("Saturday");
                break;
            
            case Weekdays.Sunday:
                Console.WriteLine("Sunday");
                break; 
            
        }
    }
}