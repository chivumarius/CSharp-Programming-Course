/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "CRYPTOGRAPHY" •
                    ──────────────────
                   • "REVERSE CIPHER"/"DECRYPTION" •

       


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



    ▬ "Reverse Encryption"
        → also "Known" as "Decryption",
        → is the "Process" of "Transforming"
        → an "Encrypted Message"
        → "Back" into its "Original Text".
    
    
        ♦ It is "Considered"
            → a very "Weak Cipher",
            → due to the "Fact"
            → that it is "So Easy" to "Decrypt".
        
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// ▼ "Folder Name" ▼
namespace CSharp.cryptography;

//──────────────────────────────────────────────────────────────
// ▬ "ReverseCipher" Class ▬
public class ReverseCipher
{
    // ▬ "ReversingCipher()" Method ▬
    public static void ReversingCipher(string message)
    {
        // ▼ "Variables" ▼
        string translated = "";
        int i = message.Length - 1; // ◄◄ "i" is the "Index" of the "Message" ◄

        // ▼ "Loop" ▼
        while (i >= 0)
        {
            // ▼ "Set" ▼
            translated += message[i];
            i--;
        }

        // ▼ "Print" ▼
        Console.WriteLine(translated);
    }

    // ▬ "RunReverseCipher()" Method ▬
    public static void RunReverseCipher()
    {
        // ▼ "Calling"/"Accessing" the "Function" ▼
        ReversingCipher("This is a Secrete Message");
    }
}
