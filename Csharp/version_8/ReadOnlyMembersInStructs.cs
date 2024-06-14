/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ────────────────────
             • "READONLY" MEMBERS IN "STRUCTS" •

       


  ▬ The "readonly" Keyword in "C#" 
    → is "Used" to "Declare" 
    → a D"ata Member" 
    → as "Constant" 
    → at "Compile Time" 
    → and allows "Its Value" 
    → to be Assigned "Only Once", 
    → either at D"eclaration Time" 
    → or in the "Class"/"Struct" "Constructor". 




  ▬ "readonly" Data Member 
    → cannot be "Modified" 
    → "After" it has been "Assigned" a "Date". 




  ▬ "readonly" Keyword 
    → is "Used" 
    → to "Define Constants" 
    → within "Classes" or "Structures" 
    → and to "Ensure" 
    → that they "Cannot" be "Accidentally Changed" 
    → during "Program Runtime".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "Stats" Struct ▬
public struct Stats
{
    // ▼ "Members Declarations"
    //      → with "Readonly" Modifier ▼
    public readonly int Attack; 
    public readonly int Defence;
    
    
    // ▬ "ToString()" Overriden Method
    //      → with "Readonly" Modifier ▬
    public readonly override string ToString()
    {
        return $"Attack Value is: {Attack}, Defence Value is: {Defence}";
    }
}





//──────────────────────────────────────────────────────────────
// ▬ "ReadOnlyMembersInStructs" Class ▬
public class ReadOnlyMembersInStructs
{
    // ▬ "RunReadOnlyMembersInStructs()" Method ▬
    public static void RunReadOnlyMembersInStructs()
    {
        // ▼ "Create" an "Instance" of the "Stats" Struct ▼
        Stats playerStats = new Stats();

        
        // ▼ "Display" the "Default Values"
        //      → of the "Readonly" Data Members ▼
        Console.WriteLine($"Default Values: Attack: {playerStats.Attack}, Defence: {playerStats.Defence}");

        
        // ▼ "Trying" to "Modify"
        //      → the "Readonly" Data Members
        //      → will "Generate"
        //      → a "Compile-Time Error" ▼
        // playerStats.Attack = 100;
        // playerStats.Defence = 80;

        
        // ▼ "Display" the "String Representation"
        //      → of the "Struct"
        //      → using the Overridden "ToString()" method ▼
        Console.WriteLine(playerStats.ToString());
    }
} 