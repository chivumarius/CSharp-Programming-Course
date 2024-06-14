namespace CSharp.date_time;

public class Formatting_Dates_and_Times
{
    public static void FormatDatesAndTime()
    {
        // ▼ Formatting the Current Date ▼
        Console.WriteLine("Date Formatting: " + DateTime.Now.ToString("MM/dd/yyyy"));
        
        // ▼ "Date" withe "Names" ▼
        Console.WriteLine("Date Formatting with Names: " + DateTime.Now.ToString("ddd, dd MMMM yyyy"));
        
        // ▼ "Date" withe "Names" and "Time" ▼
        Console.WriteLine("Date Formatting with Names and Time: " + DateTime.Now.ToString("ddd, dd MMMM yyyy HH:mm:ss"));
        
        // ▼ "Date" withe "Numbers" and "Time" in "Hours", "Minutes" & "AM/PM" ▼
        Console.WriteLine("Date Formatting with Hours, Minutes and AM/PM: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm tt"));
    }
}