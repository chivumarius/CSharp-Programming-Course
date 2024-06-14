namespace CSharp.user_input_and_files;

public static class StringAndCharUserInput
{
    //───────────────────────────────────────────────────────────────────────────────────
    // ▬ (1) "ReadLine()" Method 
    //          → is "Used" to "Read" a "Line"
    //          → of "Text Entered"
    //          → by the "User"
    public static void ReadLineMethod()
    {
        // ▼ "Message" in "Console" ▼
        Console.WriteLine("Enter a message: ");
        
        // ▼ "Reading" & "Storing" the "User Input" in a "Variable" ▼
        string? userInput = Console.ReadLine();
        
        // ▼ "Printing" the "User Input" ▼
        Console.WriteLine("You entered: " + userInput);
    }
    
    
    
   
    //───────────────────────────────────────────────────────────────────────────────────
    // ▬ (2) "Read()" Method
    //          → is "Used" to Read a "Single Character"
    //          → from "User Input" ▬
    public static void ReadMethod()
    {
        Console.WriteLine("\n\"Read()\" Method");
        
        
        // ▼ "Message" in "Console" ▼
        Console.WriteLine("Press a key:");
        
        // ▼ "Reading" & "Storing" the "User Input" in a "Variable" ▼
        int keyCode = Console.Read(); 
        
        // ▼ "Printing" the "User Input" ▼
        Console.WriteLine("The ASCII code of the entered character is: " + keyCode);
    }
    
    
    
    
    // public static void ReadMethod2()
    // {
    //     Console.WriteLine("\nChange the Color of the Background");
    //     
    //     
    //     // ▼ "Message" in "Console" ▼
    //     Console.WriteLine("g = green, r = red, b = blue, w = white");
    //     
    //     // ▼ "Reading" & "Storing" the "User Input" in a "Variable" ▼
    //     int x = Console.Read();
    //     
    //     // ▼ Converting the "User Input" to a "Character" ▼
    //     char userInput = Convert.ToChar(x);
    //
    //     // ▼ "While" Loop ▼
    //     while (userInput != 'z')
    //     {
    //        // ▼ "Switch" Statement ▼
    //        switch (userInput)
    //        {
    //            case 'g':
    //                Console.BackgroundColor = ConsoleColor.Green;
    //                break;
    //            
    //            case 'r':
    //                Console.BackgroundColor = ConsoleColor.Red;
    //                break;
    //            
    //            case 'b':
    //                Console.BackgroundColor = ConsoleColor.Blue;
    //                break;
    //            
    //            case 'w':
    //                Console.BackgroundColor = ConsoleColor.White;
    //                break;
    //            
    //            default:
    //                Console.WriteLine("Invalid Input");
    //                break;
    //        }
    //        
    //        // ▼ "Clear" the "Console" ▼
    //        Console.Clear();
    //        
    //        // ▼ "Message" in "Console" ▼
    //        Console.WriteLine("g = green, r = red, b = blue, w = white");
    //
    //        // ▼ "ReSet" the "User Input" in a "Variable" ▼
    //        x = Console.Read();
    //
    //        
    //        // ▼ ReConverting the "User Input" to a "Character" ▼
    //        userInput = Convert.ToChar(x);
    //     }
    // }



    //───────────────────────────────────────────────────────────────────────────────────
    // ▬ (3) "ReadKey()" Method 
    //      → is "Used" to "Read"
    //      → the "Key Pressed" by the "User"
    //      → "Without Requiring" the "Enter" Key
    //      → to be "Pressed" ▬
    public static void ReadKeyMethod()
    {
        Console.WriteLine("\n\"ReadKey()\" Method: ");


        // ▼ Declaring a "Console Key Info" ▼
        ConsoleKeyInfo keyInfo;

        // ▼ Enabling "Treat Control C As Input" ▼
        Console.TreatControlCAsInput = true;


        // ▼ "Loop" ▼
        do
        {
            // ▼ "Setting" the "Console Key Info" ▼
            keyInfo = Console.ReadKey();

            // ▼ "Checking": If "Alt" is "Pressed" ▼
            if ((keyInfo.Modifiers & ConsoleModifiers.Alt) != 0)
                Console.Write("  key was pressed " + "(ALT + " + keyInfo.Key + ")");

            // ▼ "Checking": If "Shift" is "Pressed" ▼
            if ((keyInfo.Modifiers & ConsoleModifiers.Shift) != 0)
                Console.Write("  key was pressed " + "(SHIFT + " + keyInfo.Key + ")");

            // ▼ "Checking": If "Control" is "Pressed" ▼
            if ((keyInfo.Modifiers & ConsoleModifiers.Control) != 0)
                Console.Write("  key was pressed " + "(CTRL + " + keyInfo.Key + ")");

        } while (keyInfo.Key != ConsoleKey.Escape);
    }
}