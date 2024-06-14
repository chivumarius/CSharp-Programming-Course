/*▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                    • "C# - 8.0" (2019) •
                    ─────────────────────
                • "DISPOSABLE REF STRUCTS" •

       


  ▬ "Disposable Ref Structs" 
      → are "Structures" 
      → that "Implement" the
        •► "IDisposable" Interface 
      → and are "Stack-Allocated". 



  ▬ "They" 
      → allow "Efficient Management" 
      → of "Resources" 
      → that "Require" 
        •► "Explicit Release", 
      → such as 
        •► "Files" or 
        •► "Native Resources". 



  ▬ By "Using" these "Structures", 
      → we can "Ensure" 
      → that "Resources" 
      → are "Released Correctly" 
      → and "Efficiently".

  
▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀*/
namespace CSharp.version_8;


//──────────────────────────────────────────────────────────────
// ▬ "DisposableRefStructs" Class ▬
public class DisposableRefStructs
{
    // ▬ "CD" Structure ▬
    ref struct CD
    {
        // ▼ "FilePath" ▼
        private readonly string filePath;

        
        // ▬ "Constructor" ▬
        public CD(string path)
        {
            filePath = path;
        }

        
        // ▬ "Write" Method ▬
        public void Write(string content)
        {
            using (var fileWriter = new StreamWriter(filePath))
            {
                fileWriter.WriteLine(content);
            }
        }

        // ▬ "Read" Method ▬
        public string Read()
        {
            using (var fileReader = new StreamReader(filePath))
            {
                return fileReader.ReadToEnd();
            }
        }
    }

    
    
    // ▬ "RunDisposableRefStructs()" Method ▬
    public static void RunDisposableRefStructs()
    {
        // ▼ "File Path" ▼
        string filePath = @"C:\Users\Administrator\RiderProjects\Csharp\Csharp\csharp_version_8\filename.txt";

        // ▼ "Create" and "Use" the "CD" structure to Write and Read the File ▼
        CD fileHandler = new CD(filePath);
        fileHandler.Write("Hello, using Declarations!");
        string fileContent = fileHandler.Read();

        // ▼ "Display" the "File Content" in the "Console" ▼
        Console.WriteLine("File content:");
        Console.WriteLine(fileContent);
    }
}