/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "CRYPTOGRAPHY" •
                    ──────────────────
                    • "CAESAR CIPHER" •

       


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




    ▬ "Caesar Cipher"
        → is one of the "Simplest"
        → and "Most Well-Known Encryption Techniques".
        
        
        ♦ It is a "Type"
          → of "Substitution Cipher"
          → in which "Each Letter"
          → in the "Plaintext"
          → is "Replaced"
          → by "Another Letter"
          → a Fixed Distance between them in the alphabet.
        
        
        ♦ For Example,
          → with an "Offset" of "3 positions",
          → the "Letter"
            •► 'A' becomes 'D',
            •► 'B' becomes 'E',
          → and so on.



    ▬ "Main Features" of the "Caesar Cipher":
        1- "Type" of "Cipher":
            • "Substitution Cipher"
        
        
        2- "Working Principle":
            • "Each Letter"
                → in the "Clear Text"
                → is "Replaced"
                → by a "Letter"
                → at a "Fixed Distance"
                → in the "Alphabet".
        
        
        3- "Encryption Key":
            • Shift Distance in the Alphabet
                → (example "3 Positions").



    ▬ "Example":
        • "Clear Text": HELLO
        • "Key" ("3 Position Gap"): 3
        • "Encrypted Text": KHOOR


        ♦ The Process Works:
            ► H -> K (H is the 8th letter, K is the 11th letter in the alphabet)
            ► E -> H (E is the 5th letter, H is the 8th letter in the alphabet)
            ► L -> O (L is the 12th letter, O is the 15th letter in the alphabet)
            ► L -> O (L is the 12th letter, O is the 15th letter in the alphabet)
            ► O -> R (O is the 15th letter, R is the 18th letter in the alphabet)


    ▬ "Caesar Cipher Algorithm":
        
        1. "Choose" a "Numeric Key" ("Gap").
        
        2. For "Each Letter" in the "Clear Text":
             • "Find" the "Position"
                → of the "Letter"
                → in the "Alphabet".
                
             • "Add" the "Key Value"
                → to that "Position".
                
             • "Replace" the "Initial Letter"
                → with the "Letter Corresponding"
                → to the "New Position".



    ▬ "In Short":
        
        • The "Caesar Cipher"
            → is a "Simple Encryption Algorithm"
            → in which "Each Letter"
            → of a "Message"
            → is "Replaced"
            → by "Another Letter"
            → "Located" at a "Fixed Distance"
            → in the "Alphabet",
            → "Based" on a "Numeric Key" ("Offset").

▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// ▼ "Folder Name" ▼
namespace CSharp.cryptography;

//──────────────────────────────────────────────────────────────
// ▬ "CaesarCipher" Class ▬
public class CaesarCipher
{
    // ▬ "CaesarCipherMethod()" Method ▬
    public static void CaesarCipherMethod(string message, int amount)
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
            "The Result of the 'Caesar Cipher' Encrypted Text ('abcd') having the Key '2' is: "
                + result
        );
    }

    // ▬ "RunCaesarCipher()" Method ▬
    public static void RunCaesarCipher()
    {
        // ▼ "Calling"/"Accessing" the "Method" ▼
        CaesarCipherMethod("abcd", 2);
    }
}
