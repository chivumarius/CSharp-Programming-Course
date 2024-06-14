/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "CRYPTOGRAPHY" •
                    ──────────────────
                 • "XOR PROCESS CIPHER" •




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



    ▬ "XOR Process Cipher" ("Exclusive OR" Process) - '⊕'
          → is a "Logical Operation"
          → used in "Cryptography"
          → and "Data Processing".


      ♦ It "Operates"
            → on T"wo Binary Inputs"
            → and Returns:
              •► "1"
            → if "Exactly One"
            → of the "Inputs" is "1",
            → but "Not Both".



    ▬ Properties:
        1. "Symmetry":
            •► `A ⊕ B' = `B ⊕ A'.

        2. "Identity":
            •► `A ⊕ 0' = `A'.

        3. "Inversion":
            •► `A ⊕ A' = `0'.

        4. "Associativity":
            •► `(A ⊕ B) ⊕ C' = `A ⊕ (B ⊕ C)'.



    ▬ "XOR" ("⊕") in "Cryptography":

        1- "Encryption":
            •► `C = P ⊕ K'
                → where:
                    • `P' is the "Plaintext",
                    • `K' is the "Key",
                    • `C' is the "Ciphertext".


        2- "Decryption":
            •► `P = C ⊕ K` (
                → XORing with the "Key" again).



    ▬ Example:
        • "Clear Text":
            •► `P = 1100 1010`

        • "Key":
            •► `K = 1010 1100`

        • "Ciphertext":
            •► `C = 0110 0110` (XOR Result)

        • Decryption:
            •► `C = 0110 0110`,
            •► `K = 1010 1100`

        • "Clear Text":
            •► `P = 1100 1010`
                → ("Original Text" is "Obtained" again
                →   by Applying "XOR").




    ▬ "Uses":
        1- "Simple Encryption":
            • In "Stream Ciphers".

        2- "Error Detection":
            • In "Parity Bits"
                → and "Checksums".

        3- "Bit-By-Bit Manipulation":
            • In Various "Algorithms".



    ▬ "XOR" ("⊕")
        → is "Fundamental" in "Cryptography"
        → because of its Easy "Reversal Properties".


▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/

// ▼ "Folder Name" ▼
namespace CSharp.cryptography
{
    //──────────────────────────────────────────────────────────────
    // ▬ "XOR_ProcessCipher" Class ▬
    public class XOR_ProcessCipher
    {
        // ▬ "XOR_Process_Cipher()" Method ▬
        public static string XOR_Process_Cipher(string message, char key)
        {
            // ▼ "Variables" ▼
            int length = message.Length;
            char[] output = new char[length];

            // ▼ "Loop" ▼
            for (int i = 0; i < length; i++)
            {
                output[i] = (char)(message[i] ^ key);
            }

            return new string(output);
        }

        // ▬ "Run_XOR_ProcessCipher()" Method ▬
        public static void Run_XOR_ProcessCipher()
        {
            // ▼ "Original Message" ▼
            string originalMessage = "Hello World";
            // ▼ "Key" ▼
            char key = 'L';

            // ▼ "Encrypting the Message" ▼
            string encryptedMessage = XOR_Process_Cipher(originalMessage, key);
            Console.WriteLine($"Encrypted Message: {encryptedMessage}");

            // ▼ "Decrypting the Message" ▼
            string decryptedMessage = XOR_Process_Cipher(encryptedMessage, key);
            Console.WriteLine($"Decrypted Message: {decryptedMessage}");
        }
    }
}
