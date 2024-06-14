namespace CSharp.user_input_and_files;

public class NumericUserInput
{
    public static void NumericUserInputMethod()
    {
        // ▼ "Message" ▼
        Console.WriteLine("\nPlease enter a number: ");

        
        // ▼ "Do-While" Loop ▼
        do
        {
            // ▼ "User Input" ▼
            string userInput = Console.ReadLine();
            int number;
            
            // ▼ Cheching if the "User Input" is a "Number" ▼
            if (!int.TryParse(userInput, out number))
            {
                
                // ▼ Set Text Color to "Res" ▼
                Console.ForegroundColor = ConsoleColor.Red;
                
                // ▼ "Message" ▼
                Console.WriteLine("This is not a number!");
                
                // ▼ Reset Text Color ▼
                Console.ResetColor();
                
                // ▼ "Message" ▼
                Console.WriteLine("\nPlease enter a number: ");

            }
            else
            {
                // ▼ "Message" ▼
                Console.WriteLine("\nYou entered: " + number);
                
                // ▼ "Message" ▼
                Console.WriteLine("\nPlease enter another number: ");
            }
        } while (true);
    }
}