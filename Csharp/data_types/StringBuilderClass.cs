using System.Text;

namespace CSharp.data_types;


public class StringBuilderClass
{
    public static void StringBuilderMethod()
    {
        // ▼ Creating an "Instance"/"Object"  →of "StringBuilder" Class ▼
        StringBuilder stringBuilder = new StringBuilder();

        // ▼ "Append" a "String" → to "StringBuilder" ▼
        stringBuilder.Append("Hi there");

        // ▼ Using "for()" Loop → to "Append" a "New String" ▼
        for (int i = 0; i < 4; i++)
        {
            // ▼ "Append" a "New String" → to "StringBuilder" ▼☺☺
            stringBuilder.Append(", nice to see you");
        }

        // ▼ "Converting" to "String" ▼
        string strConv = stringBuilder.ToString();

        // ▼ "Console Display" ▼
        Console.WriteLine(strConv);


        // ▬ -------------------- ".Clear()" Method -------------------- ▬
        // ▼ Cleaning up the stringBuilder ▼
        stringBuilder.Clear();
        
        // ▼ "Reset" & "Convert" to "String" ▼
        strConv = stringBuilder.ToString();
        
        // ▼ "Console Display" ▼
        Console.WriteLine(strConv);  // ◄◄ "Nothing" will be "Displayed", because the "String" is "Empty" ◄◄ 
        
        
        
        // ▬ -------------------- "AppendLine()" Method -------------------- ▬
        // ▼ Creating a "New Instance"/"Object"  → of "StringBuilder" Type ▼
        StringBuilder stringBuilder2 = new StringBuilder();
        
        // ▼ Adding a "String" on a "Line" → by ".AppendLine()" Method ▼
        stringBuilder2.AppendLine("Hello again");
        stringBuilder2.AppendLine("Hello again");
        
        // ▼ "Console Display" → with "Sting Conversion" ▼
        Console.WriteLine(stringBuilder2.ToString());
        
        
        // ▬ -------------------- "Remove()" Method -------------------- ▬
        // ▼ Creating a "New Instance"/"Object"  → of "StringBuilder" Type ▼
        StringBuilder stringBuilder3 = new StringBuilder("Hello mysterious world");

        // ▼ "Removing Parts" from the "String" → by ".Remove()" Method ▼
        stringBuilder3.Remove(6, 11);  // ◄◄ "Syntax": .Remove(Starting_Index, Length)
        
        // ▼ "Console Display" → with "Sting Conversion" ▼
        Console.WriteLine(stringBuilder3.ToString());


        
        // ▬ -------------------- "Replace()" Method -------------------- ▬
        // ▼ Creating a "New Instance"/"Object"  → of "StringBuilder" Type ▼
        StringBuilder stringBuilder4 = new StringBuilder("This is a new string with a character replacement");
        
        
        // ▼ "Replace Character"
        //      → from the "String"
        //      → by ".Remove()" Method ▼
        stringBuilder4.Replace(" ", "_");  // ◄◄ "Syntax": .Replace("Replaced_String_Character", "Replacement_Character")

        // ▼ "Console Display" → with "Sting Conversion" ▼
        Console.WriteLine(stringBuilder4.ToString());
        
        
        // ▼ ".Length" Property → with "Sting Conversion" ▼
        Console.WriteLine(stringBuilder4.Length.ToString());  // ◄◄ "Check" the "StringBuilder Length" ◄
    }
}    