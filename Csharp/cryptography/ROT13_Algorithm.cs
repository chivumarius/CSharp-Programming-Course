/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "CRYPTOGRAPHY" •
                    ──────────────────
            • "ROT13 ALGORITHM" ("ROTATE 13") •

       


    ▬ "Cryptography"
      → is the "Study"
      → of "Communication Techniques"
      → that are "Designed"
      → to be "Secure".



    ▬ "Encryption"
      → means "Scrambling" a "Message"
      → into "Ciphertext",
      → an "Encoded Message".



    ▬ "Decryption"
      → is when we "Take" that "Ciphertext"
      → and "Translate It Back"
      → to "English".



    ▬ "ROT13" Algorithm ("Rotates 13")
        → stands from "Rotates 13"
        → is a "Simple"
        → "Encryption Technique"
        → that is Similar with "Caesar Cipher",
        → but always use the "Letter 13 Position"
        → to "Rotates by 13".
        
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// ▼ "Folder Name" ▼
namespace CSharp.cryptography;

//──────────────────────────────────────────────────────────────
// ▬ "ROT13_Algorithm" Class ▬
public class ROT13_Algorithm
{
    // ▬ "Rot13Algorithm()" Method ▬
    public static void Rot13Algorithm(string message, int amount)
    {
        // ▼ "Variable" ▼
        string result = "";

        // ▼ "Loop" ▼
        for (int i = 0; i < message.Length; i++)
        {
            // ▼ "Set Variable" ▼
            char c = message[i];

            // ▼ "Convert" a "Character" ('c')
            //      → to "Another Character"
            //      → that is a "Number" of "Positions Further"
            //      → in the "Alphabet",
            //      → "Rounding Back" to the "Beginning"
            //      → of the "Alphabet" if "Necessary" ▼
            result += (char)((c + amount - 97) % 26 + 97); //  ◄◄ In "ASCII": 97 = 'a' ◄◄
        }

        // ▼ "Print" the "Result" ▼
        Console.WriteLine(
            "The Result of the 'ROT13' Encrypted Text ('abcd') having the Key '13' is: " + result
        );
    }

    // ▬ "RunROT13_Algorithm()" Method ▬
    public static void RunROT13_Algorithm()
    {
        // ▼ "Calling"/"Accessing" the "Method" ▼
        Rot13Algorithm("abcd", 13);
    }
}
