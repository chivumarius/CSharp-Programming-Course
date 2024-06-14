namespace CSharp.date_time;

public class DateTimeClass
{
    public static void DateTimeMethod()
    {
        // ▼ "Current Local Time" ▼
        Console.WriteLine("Current Local Time: " + DateTime.Now);
        
        // ▼ "Create" an "Object"/"Instance" of "DateTime" Class ▼
        DateTime dateTime = new DateTime(2010, 04, 10);
        Console.WriteLine("DateTime Instantiation: " + dateTime);
    }
}