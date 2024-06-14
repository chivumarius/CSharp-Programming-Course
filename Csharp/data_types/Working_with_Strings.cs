namespace CSharp.data_types;

public class Working_with_Strings
{
   public static void WorkingWithString()
   {
      // ▼ "Empty String" ▼
      string emptyString = "";
      string emptyString2 = string.Empty;
      Console.WriteLine("Empty String by \" \": " + emptyString + "\nEmpty String by string.Empty Property" + emptyString2);
      
      
      // ▼ "Creating" a "String" ▼
      string myString = "My String";
      Console.WriteLine("\nString Created: " + myString);
      
      // ▼ "String Length" ▼
      Console.WriteLine("String Length Property: " + myString.Length);
      
      // ▼ "Getting" the "Index" of a "Character" in a "String" ▼
      Console.WriteLine("Index of First Character: " + myString.IndexOf('M'));
      
      // ▼ "Getting" a "Character" of a "String" ▼
      Console.WriteLine("Last Character: " + myString[8]);
      
      // ▼ Converting "To Upper Case" of a "String" ▼
      Console.WriteLine("To Uppercase: " + myString.ToUpper());
      
      // ▼ Converting "To Lower Case" of a "String" ▼
      Console.WriteLine("To Lowercase: " + myString.ToLower());
      
      // ▼ "Inserting" a "Character" into a "String" ▼
      Console.WriteLine("Inserting a _ Character: " + myString.Insert(2, "_"));  // ◄◄ "Syntax": myString.Insert(Position_In_String, "Inserted_Character") ◄◄
      
      // ▼ "Removing" a "Character" from a "String" ▼
      Console.WriteLine("Removing a _ Character: " + myString.Remove(2, 1));  // ◄◄ "Syntax": myString.Remove(Position_In_String, Length_Of_String) ◄◄
      
      
      // ▼ "Replacing" a "Character" in a "String" ▼
      Console.WriteLine("Replacing a _ Character: " + myString.Replace('_', ' '));  // ◄◄ "Syntax": myString.Replace("Replaced_Character", "Replacement_Character") ◄◄
      
      // ▼ "Trimming" a "String" ▼
      Console.WriteLine("Trimming a String Character (\"M\"): " + myString.Trim('M') + "\n");
      
      
      // ▼ "Splitting" a "String" into "Sub-Strings" ▼
      string str = "The birds fly smoothly";
      Console.WriteLine("Splitting a String into Sub-Strings:" + str);

      string[] words = str.Split(' ');
      
      foreach (string word in words)
      {
         Console.WriteLine(word);
      }
      
      
      // ▼ "Substring"/"Getting" a "Sub-String" from a "String" ▼
      Console.WriteLine("\nSubstring a Sub-string from a String: " + myString.Substring(0, 6)); // ◄◄ "Syntax": myString.Substring(Starting_Position_Of_The_Sub-String, Length_Of_the_Sub-String) ◄◄
      
   }
}