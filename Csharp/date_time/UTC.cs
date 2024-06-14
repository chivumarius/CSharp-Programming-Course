namespace CSharp.date_time;

public class UTC
{
    public static void UniversalTimeCoordinated()
    {
        // ▼ "Current Local Time" ▼
        Console.WriteLine("Current Local Time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm tt"));
        
        
        // ▼ "Coordinated Universal Time" ("UTC") ▼
        Console.WriteLine("Coordinated Universal Time: " + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm tt"));
        
        // ▼ Using "ToUniversalTime()" Method ▼
        Console.WriteLine("UTC by Using \"ToUniversalTime()\" Method: " + DateTime.Now.ToUniversalTime().ToString("dd/MM/yyyy HH:mm tt"));
    
        
        // ▼ Using "ToLocalTime()" Method from "UtcNow" ▼
        Console.WriteLine("Local Time from UTC by Using \"ToLocalTime()\" Method: " + DateTime.UtcNow.ToLocalTime().ToString("dd/MM/yyyy HH:mm tt"));
        
        
        // ▼ "Detecting" if the "Date Time"
        //      → is "Universal" or "Local" ▼
        Console.WriteLine("\nDetecting the \"Kind\" of \"Local\" Date Time: " + DateTime.Now.Kind);
        Console.WriteLine("Detecting the \"Kind\" of \"UTC\" Date Time: " + DateTime.UtcNow.Kind);
    }
}