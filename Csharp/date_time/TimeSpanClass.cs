namespace CSharp.date_time;

public class TimeSpanClass
{
    public static void TimeSpanMethod()
    {
        /*
            ♦ "Syntax": 
                •► new TimeSpan(hours, minutes, seconds, milliseconds);
            
            
            ♦ There are "5 Ways" to "Initialize" a "TimeSpan":
                1. TimeSpan();
                2. TimeSpan(long ticks);
                3. TimeSpan(int hours, int minutes, int seconds);
                4. TimeSpan(int days, int hours, int minutes, int seconds);
                5. TimeSpan(int days, int hours, int minutes, int seconds, int milliseconds);
         */
        
        
        // ▼ "Create" an "Object"/"Instance" of "TimeSpan" Class ▼
        //TimeSpan timeSpan1 = new TimeSpan();  // ◄◄ "Equivalent": to "TimeSpan.Zero" ◄◄
        TimeSpan timeSpan = new TimeSpan(8, 10, 30);
        Console.WriteLine( "Hours: " + timeSpan.Hours);
        Console.WriteLine("Minutes: " + timeSpan.Minutes);
        Console.WriteLine("Seconds: " + timeSpan.Seconds);
    }
}