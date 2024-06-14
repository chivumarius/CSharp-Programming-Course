/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "CRYPTOGRAPHY" •
                    ──────────────────
                • "MONOALPHABETIC CIPHER" •

       


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



    ▬ "Monoalphabetic Cipher"
        → is a "Substitution Cipher"
        → where "Each Letter"
        → in the "Plaintext"
        → is "Replaced"
        → by a "Fixed Letter"
        → in the "Ciphertext",
        → making it "Simple" to "Implement",
        → but "Vulnerable"
        → to "Frequency Analysis".
    
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
// ▼ "Folder Name" ▼
namespace CSharp.cryptography;

//──────────────────────────────────────────────────────────────
// ▬ "MonoalphabeticCipher" Class ▬
public class MonoalphabeticCipher
{
    // ▼ "Array Variables" ▼
    public static char[] alphabet =
    {
        'a',
        'b',
        'c',
        'd',
        'e',
        'f',
        'g',
        'h',
        'i',
        'j',
        'k',
        'l',
        'm',
        'n',
        'o',
        'p',
        'q',
        'r',
        's',
        't',
        'u',
        'v',
        'w',
        'x',
        'y',
        'z'
    };

    public static char[] cipherAlphabet =
    {
        'Q',
        'W',
        'E',
        'R',
        'T',
        'Y',
        'U',
        'I',
        'O',
        'P',
        'A',
        'S',
        'D',
        'F',
        'G',
        'H',
        'J',
        'K',
        'L',
        'Z',
        'X',
        'C',
        'V',
        'B',
        'N',
        'M'
    }; // ◄◄ "Keyboard Order" ◄◄

    // ▬ "MonoAlphabeticCipher()" Method ▬
    public static void MonoAlphabeticCipher(string message)
    {
        // ▼ "Array" ▼
        char[] c = new char[message.Length];

        // ▼ "Loop" ▼
        for (int i = 0; i < message.Length; i++)
        {
            // ▼ "Nested Loop" ▼
            for (int j = 0; j < 26; j++)
            {
                // ▼ "Condition" ▼
                if (alphabet[j] == message[i])
                {
                    c[i] = cipherAlphabet[j];
                    break;
                }
            }
        }

        // ▼ "Output" ▼
        Console.WriteLine(c);
    }

    // ▬ "RunMonoalphabeticCipher()" Method ▬
    public static void RunMonoalphabeticCipher()
    {
        // ▼ "Calling"/"Accessing" the "Function" ▼
        MonoAlphabeticCipher("hello");
    }
}
